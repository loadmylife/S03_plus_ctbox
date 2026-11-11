using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using gvcpTool.Business;
using gvcpTool.Configuration;

namespace mainWindow
{
    public partial class mainForm : Form
    {
        private readonly object _logLock = new object();
        private readonly object _manualReadLock = new object();
        private StreamWriter _logWriter;
        private GvcpBusinessService _businessService;
        private GvcpUiConfiguration _configuration;
        private uint[,] _configurationPayload = new uint[GvcpUiConfiguration.RegisterCount, 2];
        private ushort? _pendingManualReadPacketId;
        private uint _pendingManualReadAddress;

        public mainForm()
        {
            InitializeComponent();
            InitializeServices();
            InitializeUiFromConfiguration();
            InitializeResponsiveLayout();
            _businessService.StartHeartbeat();
        }

        private mainForm(bool layoutOnly)
        {
            InitializeComponent();
            InitializeResponsiveLayout();
        }

        private void InitializeServices()
        {
            Directory.CreateDirectory("Log");
            _logWriter = new StreamWriter("Log/log.txt", true);
            _configuration = new GvcpUiConfiguration("Config/udpToolConfig.xml");

            string ipText = Environment.GetEnvironmentVariable("GVCP_REMOTE_IP");
            string portText = Environment.GetEnvironmentVariable("GVCP_REMOTE_PORT");
            int port;
            if (string.IsNullOrWhiteSpace(ipText)) ipText = "78.86.65.16";
            if (!int.TryParse(portText, out port)) port = 3956;

            _businessService = new GvcpBusinessService(new IPEndPoint(IPAddress.Parse(ipText), port));
            _businessService.Log += HandleProtocolLog;
            _businessService.ResponseReceived += HandleGvcpResponse;
            _businessService.PeriodicStatusReceived += HandlePeriodicStatus;
        }

        private void HandleProtocolLog(string message)
        {
            nv_log(message);
        }

        public void nv_log(string message)
        {
            if (string.IsNullOrEmpty(message)) return;
            string line = "[" + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] " + message;
            lock (_logLock)
            {
                if (_logWriter != null)
                {
                    _logWriter.WriteLine(line);
                    _logWriter.Flush();
                }
            }
            Console.WriteLine(line);
            if (!IsDisposed && IsHandleCreated)
            {
                if (InvokeRequired)
                {
                    try { BeginInvoke(new Action<string>(AppendLogText), line); } catch (InvalidOperationException) { }
                }
                else AppendLogText(line);
            }
        }

        private void AppendLogText(string line)
        {
            if (!IsDisposed) textBox_log.AppendText(line + Environment.NewLine);
        }

        private void button_clear_log_Click(object sender, EventArgs e)
        {
            textBox_log.Clear();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_businessService != null)
            {
                _businessService.Log -= HandleProtocolLog;
                _businessService.ResponseReceived -= HandleGvcpResponse;
                _businessService.PeriodicStatusReceived -= HandlePeriodicStatus;
                _businessService.Dispose();
                _businessService = null;
            }

            lock (_logLock)
            {
                if (_logWriter != null)
                {
                    _logWriter.Flush();
                    _logWriter.Dispose();
                    _logWriter = null;
                }
            }
            base.OnFormClosing(e);
        }
    }
}
