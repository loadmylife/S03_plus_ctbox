using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace gvcpTool.Protocol
{
    public sealed class GvcpRegisterOperation
    {
        public uint Address { get; set; }
        public uint? Data { get; set; }
    }

    public sealed class GvcpResponse
    {
        public ushort PacketId { get; internal set; }
        public ushort Status { get; internal set; }
        public ushort Command { get; internal set; }
        public string Operation { get; internal set; }
        public double ElapsedMilliseconds { get; internal set; }
        public IList<GvcpRegisterOperation> Registers { get; internal set; }
    }

    public sealed class GvcpClient : IDisposable
    {
        public const ushort ReadRegisterCommand = 0x0080;
        public const ushort ReadRegisterAck = 0x0081;
        public const ushort WriteRegisterCommand = 0x0082;
        public const ushort WriteRegisterAck = 0x0083;
        public const int HeaderLength = 8;
        public const uint GVCP_HEARTBEAT_REG_ADDR = 0x00000A00;

        private sealed class PendingRequest
        {
            public ushort Command { get; set; }
            public ushort ExpectedAck { get; set; }
            public string Operation { get; set; }
            public List<GvcpRegisterOperation> Registers { get; set; }
            public DateTime SentAtUtc { get; set; }
            public bool LogResponse { get; set; }
        }

        private readonly object _sync = new object();
        private readonly Dictionary<ushort, PendingRequest> _pending = new Dictionary<ushort, PendingRequest>();
        private readonly UdpClient _udpClient;
        private readonly Thread _receiveThread;
        private readonly GvcpStatusProtocolProcessor _statusProcessor;
        private Thread _heartbeatThread;
        private readonly TimeSpan _requestTimeout = TimeSpan.FromSeconds(5);
        private volatile bool _running;
        private volatile bool _heartbeatRunning;
        private ushort _nextPacketId = 1;
        private IPEndPoint _remoteEndPoint;

        public event Action<string> Log;
        public event Action<GvcpResponse> ResponseReceived;
        public event Action<GvcpStatusMessage> PeriodicStatusReceived;
        public event Action<GvcpStatusMessage> RealtimeStatusReceived;

        public GvcpClient(
            IPEndPoint remoteEndPoint,
            int realtimeStatusPort = GvcpStatusProtocolProcessor.DefaultRealtimeStatusPort,
            int periodicStatusPort = GvcpStatusProtocolProcessor.DefaultPeriodicStatusPort)
        {
            if (remoteEndPoint == null)
                throw new ArgumentNullException("remoteEndPoint");

            _remoteEndPoint = remoteEndPoint;
            _udpClient = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
            _statusProcessor = new GvcpStatusProtocolProcessor(realtimeStatusPort, periodicStatusPort);
            _statusProcessor.PeriodicStatusReceived += OnPeriodicStatusReceived;
            _statusProcessor.RealtimeStatusReceived += OnRealtimeStatusReceived;
            _receiveThread = new Thread(ReceiveLoop) { IsBackground = true, Name = "GVCP_Receive_Thread" };
            _running = true;
            _receiveThread.Start();
        }

        public IPEndPoint RemoteEndPoint
        {
            get { return _remoteEndPoint; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                _remoteEndPoint = value;
            }
        }

        public ushort ReadRegister(uint address, string operation = "read register")
        {
            byte[] packet = BuildHeader(ReadRegisterCommand, 4);
            WriteUInt32(packet, HeaderLength, address);
            return Send(packet, operation, new List<GvcpRegisterOperation>
            {
                new GvcpRegisterOperation { Address = address }
            });
        }

        public ushort WriteRegister(uint address, uint data, string operation = "write register")
        {
            byte[] packet = BuildHeader(WriteRegisterCommand, 8);
            WriteUInt32(packet, HeaderLength, address);
            WriteUInt32(packet, HeaderLength + 4, data);
            return Send(packet, operation, new List<GvcpRegisterOperation>
            {
                new GvcpRegisterOperation { Address = address, Data = data }
            });
        }

        public ushort WriteRegisters(IList<GvcpRegisterOperation> registers, string operation)
        {
            if (registers == null || registers.Count == 0)
                throw new ArgumentException("At least one register is required.", "registers");

            byte[] packet = BuildHeader(WriteRegisterCommand, checked((ushort)(registers.Count * 8)));
            for (int i = 0; i < registers.Count; i++)
            {
                WriteUInt32(packet, HeaderLength + i * 8, registers[i].Address);
                WriteUInt32(packet, HeaderLength + i * 8 + 4, registers[i].Data.GetValueOrDefault());
            }
            return Send(packet, operation, new List<GvcpRegisterOperation>(registers));
        }

        public ushort SendHeartbeat()
        {
            byte[] packet = BuildHeader(ReadRegisterCommand, 4);
            WriteUInt32(packet, HeaderLength, GVCP_HEARTBEAT_REG_ADDR);
            return Send(packet, "heartbeat", new List<GvcpRegisterOperation>
            {
                new GvcpRegisterOperation { Address = GVCP_HEARTBEAT_REG_ADDR }
            }, false);
        }

        public void StartHeartbeat(int intervalMilliseconds = 500)
        {
            if (_heartbeatRunning)
                return;
            _heartbeatRunning = true;
            _heartbeatThread = new Thread(() => HeartbeatLoop(intervalMilliseconds))
            {
                IsBackground = true,
                Name = "GVCP_Heartbeat_Thread"
            };
            _heartbeatThread.Start();
        }

        public void StopHeartbeat()
        {
            _heartbeatRunning = false;
            if (_heartbeatThread != null && _heartbeatThread.IsAlive)
                _heartbeatThread.Join(1000);
        }

        public void Dispose()
        {
            StopHeartbeat();
            _running = false;
            try { _udpClient.Close(); } catch (SocketException) { }
            if (_receiveThread != null && _receiveThread.IsAlive)
                _receiveThread.Join(1000);
            lock (_sync)
                _pending.Clear();
            _statusProcessor.PeriodicStatusReceived -= OnPeriodicStatusReceived;
            _statusProcessor.RealtimeStatusReceived -= OnRealtimeStatusReceived;
            _statusProcessor.Dispose();
        }

        private void HeartbeatLoop(int intervalMilliseconds)
        {
            while (_heartbeatRunning)
            {
                try
                {
                    SendHeartbeat();
                }
                catch (Exception ex)
                {
                    if (_heartbeatRunning)
                        WriteLog("[GVCP heartbeat failed] " + ex.Message);
                }
                Thread.Sleep(intervalMilliseconds);
            }
        }

        private ushort Send(byte[] packet, string operation, List<GvcpRegisterOperation> registers, bool logResponse = true)
        {
            ushort packetId = AllocatePacketId();
            ushort command = ReadUInt16(packet, 2);
            packet[6] = (byte)(packetId >> 8);
            packet[7] = (byte)packetId;

            PendingRequest request = new PendingRequest
            {
                Command = command,
                ExpectedAck = command == ReadRegisterCommand ? ReadRegisterAck : WriteRegisterAck,
                Operation = operation,
                Registers = registers ?? new List<GvcpRegisterOperation>(),
                SentAtUtc = DateTime.UtcNow,
                LogResponse = logResponse
            };

            lock (_sync)
                _pending[packetId] = request;

            try
            {
                _udpClient.Send(packet, packet.Length, _remoteEndPoint);
            }
            catch
            {
                lock (_sync) _pending.Remove(packetId);
                throw;
            }

            if (logResponse)
            {
                string detail = FormatRegisters(request.Registers);
                WriteLog(string.Format("[GVCP TX] packetID=0x{0:X4}, command=0x{1:X4}, operation={2}, registerCount={3}{4}",
                    packetId, command, operation, request.Registers.Count,
                    string.IsNullOrEmpty(detail) ? string.Empty : ", " + detail));
            }
            return packetId;
        }

        private static string FormatRegisters(IList<GvcpRegisterOperation> registers)
        {
            if (registers == null || registers.Count == 0)
                return string.Empty;
            if (registers.Count > 4)
                return string.Format("first_reg_addr=0x{0:X8}, last_reg_addr=0x{1:X8}",
                    registers[0].Address, registers[registers.Count - 1].Address);
            return string.Join("; ", registers.Select(register => register.Data.HasValue
                ? string.Format("reg_addr=0x{0:X8}, reg_data=0x{1:X8}", register.Address, register.Data.Value)
                : string.Format("reg_addr=0x{0:X8}", register.Address)));
        }

        private ushort AllocatePacketId()
        {
            List<KeyValuePair<ushort, PendingRequest>> expired;
            ushort id;
            lock (_sync)
            {
                DateTime boundary = DateTime.UtcNow - _requestTimeout;
                expired = _pending.Where(item => item.Value.SentAtUtc < boundary).ToList();
                foreach (KeyValuePair<ushort, PendingRequest> item in expired)
                    _pending.Remove(item.Key);

                do
                {
                    id = _nextPacketId++;
                    if (_nextPacketId == 0)
                        _nextPacketId = 1;
                } while (id == 0 || _pending.ContainsKey(id));
            }

            foreach (KeyValuePair<ushort, PendingRequest> item in expired)
                WriteLog(string.Format("[GVCP timeout] packetID=0x{0:X4}, operation={1}", item.Key, item.Value.Operation));
            return id;
        }

        private void ReceiveLoop()
        {
            while (_running)
            {
                try
                {
                    IPEndPoint source = new IPEndPoint(IPAddress.Any, 0);
                    byte[] packet = _udpClient.Receive(ref source);
                    if (packet != null)
                        ProcessPacket(packet, source);
                }
                catch (ObjectDisposedException)
                {
                    if (_running) WriteLog("[GVCP receive failed] socket was disposed");
                }
                catch (SocketException)
                {
                    if (_running) WriteLog("[GVCP receive failed] socket error");
                }
                catch (Exception ex)
                {
                    if (_running) WriteLog("[GVCP receive failed] " + ex.Message);
                }
            }
        }

        private void ProcessPacket(byte[] packet, IPEndPoint source)
        {
            if (!source.Address.Equals(_remoteEndPoint.Address))
            {
                WriteLog("[GVCP RX ignored] unexpected endpoint=" + source);
                return;
            }
            if (packet.Length < HeaderLength)
            {
                WriteLog("[GVCP RX ignored] packet is shorter than the 8-byte header");
                return;
            }

            ushort status = ReadUInt16(packet, 0);
            ushort command = ReadUInt16(packet, 2);
            ushort payloadLength = ReadUInt16(packet, 4);
            ushort packetId = ReadUInt16(packet, 6);
            if (packet.Length < HeaderLength + payloadLength)
            {
                WriteLog(string.Format("[GVCP RX ignored] packetID=0x{0:X4}, declaredLength={1}, actualLength={2}", packetId, payloadLength, packet.Length));
                return;
            }

            PendingRequest request;
            lock (_sync)
            {
                if (!_pending.TryGetValue(packetId, out request))
                {
                    WriteLog(string.Format("[GVCP RX filtered] unmatched packetID=0x{0:X4}, ack=0x{1:X4}", packetId, command));
                    return;
                }
                if (command != request.ExpectedAck)
                {
                    WriteLog(string.Format("[GVCP RX filtered] packetID=0x{0:X4}, expectedAck=0x{1:X4}, actualAck=0x{2:X4}", packetId, request.ExpectedAck, command));
                    return;
                }
                _pending.Remove(packetId);
            }

            GvcpResponse response = new GvcpResponse
            {
                PacketId = packetId,
                Status = status,
                Command = command,
                Operation = request.Operation,
                ElapsedMilliseconds = (DateTime.UtcNow - request.SentAtUtc).TotalMilliseconds,
                Registers = DecodeRegisters(packet, payloadLength, request)
            };

            if (status != 0)
            {
                WriteLog(string.Format("[GVCP RX error] packetID=0x{0:X4}, operation={1}, status=0x{2:X4}, elapsed={3:F1}ms",
                    packetId, request.Operation, status, response.ElapsedMilliseconds));
            }
            else if (!request.LogResponse)
            {
                ResponseReceived?.Invoke(response);
                return;
            }
            else if (command == ReadRegisterAck)
            {
                foreach (GvcpRegisterOperation register in response.Registers)
                {
                    WriteLog(string.Format("[GVCP READ ACK] packetID=0x{0:X4}, reg_addr=0x{1:X8}, reg_data=0x{2:X8}, elapsed={3:F1}ms",
                        packetId, register.Address, register.Data.GetValueOrDefault(), response.ElapsedMilliseconds));
                }
            }
            else
            {
                WriteLog(string.Format("[GVCP WRITE ACK] packetID=0x{0:X4}, operation={1}, registerCount={2}, elapsed={3:F1}ms",
                    packetId, request.Operation, response.Registers.Count, response.ElapsedMilliseconds));
            }
            ResponseReceived?.Invoke(response);
        }

        private void OnPeriodicStatusReceived(GvcpStatusMessage message)
        {
            Action<GvcpStatusMessage> handler = PeriodicStatusReceived;
            if (handler != null) handler(message);
        }

        private void OnRealtimeStatusReceived(GvcpStatusMessage message)
        {
            Action<GvcpStatusMessage> handler = RealtimeStatusReceived;
            if (handler != null) handler(message);
        }

        private static IList<GvcpRegisterOperation> DecodeRegisters(byte[] packet, ushort payloadLength, PendingRequest request)
        {
            List<GvcpRegisterOperation> registers = new List<GvcpRegisterOperation>();
            if (request.ExpectedAck != ReadRegisterAck)
                return request.Registers;
            int count = Math.Min(payloadLength / 4, request.Registers.Count);
            for (int i = 0; i < count; i++)
            {
                registers.Add(new GvcpRegisterOperation
                {
                    Address = request.Registers[i].Address,
                    Data = ReadUInt32(packet, HeaderLength + i * 4)
                });
            }
            return registers;
        }

        private static byte[] BuildHeader(ushort command, ushort payloadLength)
        {
            byte[] packet = new byte[HeaderLength + payloadLength];
            packet[0] = 0x42;
            packet[1] = 0x01;
            WriteUInt16(packet, 2, command);
            WriteUInt16(packet, 4, payloadLength);
            return packet;
        }

        private static ushort ReadUInt16(byte[] buffer, int offset)
        {
            return (ushort)((buffer[offset] << 8) | buffer[offset + 1]);
        }

        private static uint ReadUInt32(byte[] buffer, int offset)
        {
            return ((uint)buffer[offset] << 24) | ((uint)buffer[offset + 1] << 16) |
                   ((uint)buffer[offset + 2] << 8) | buffer[offset + 3];
        }

        private static void WriteUInt16(byte[] buffer, int offset, ushort value)
        {
            buffer[offset] = (byte)(value >> 8);
            buffer[offset + 1] = (byte)value;
        }

        private static void WriteUInt32(byte[] buffer, int offset, uint value)
        {
            buffer[offset] = (byte)(value >> 24);
            buffer[offset + 1] = (byte)(value >> 16);
            buffer[offset + 2] = (byte)(value >> 8);
            buffer[offset + 3] = (byte)value;
        }

        private void WriteLog(string message)
        {
            Log?.Invoke(message);
        }
    }
}
