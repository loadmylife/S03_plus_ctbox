using System;
using System.Collections.Generic;
using gvcpTool.Configuration;
using gvcpTool.Protocol;

namespace mainWindow
{
    public partial class mainForm
    {
        private void button_confirm_Click(object sender, EventArgs e)
        {
            ConfigureExposureEnable();
            BuildConfigurationPayload();
            ushort packetId = _businessService.WriteRegisters(
                _configuration.CreateRegisterOperations(_configurationPayload), "config params");
            nv_log(string.Format("config params sent, packetID=0x{0:X4}", packetId));
        }

        private void button_start_scan_Click(object sender, EventArgs e)
        {
            SynchronizeTimestamp();
            _businessService.WriteRegister(0x0000A128, 1, "start scan");
            button_start_scan.Enabled = false;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            _businessService.WriteRegister(0x0000A128, 0, "stop scan");
            button_start_scan.Enabled = true;
        }

        private void button_reg_send_Click(object sender, EventArgs e)
        {
            uint address = ParseHexUInt(textBox_reg_addr.Text);
            uint data = GvcpUiConfiguration.ParseUnsignedDecimal(textBox_reg_data.Text);
            _businessService.WriteRegister(address, data, "write register");
        }

        private void button_reg_read_Click(object sender, EventArgs e)
        {
            textBox_read_reg_data.Clear();
            lock (_manualReadLock)
            {
                _pendingManualReadAddress = ParseHexUInt(textBox_read_reg_addr.Text);
                _pendingManualReadPacketId = _businessService.ReadRegister(_pendingManualReadAddress);
            }
        }

        private void HandleGvcpResponse(GvcpResponse response)
        {
            string displayValue = null;
            lock (_manualReadLock)
            {
                if (!_pendingManualReadPacketId.HasValue || response == null ||
                    response.PacketId != _pendingManualReadPacketId.Value || response.Status != 0 ||
                    response.Command != GvcpClient.ReadRegisterAck || response.Registers == null)
                    return;

                foreach (GvcpRegisterOperation register in response.Registers)
                {
                    if (register.Address != _pendingManualReadAddress || !register.Data.HasValue)
                        continue;

                    _pendingManualReadPacketId = null;
                    displayValue = string.Format("0x{0:X} / {0}", register.Data.Value);
                    break;
                }
            }

            if (displayValue != null)
                UpdateReadRegisterData(displayValue);
        }

        private void UpdateReadRegisterData(string value)
        {
            if (IsDisposed || !IsHandleCreated)
                return;
            if (InvokeRequired)
            {
                try { BeginInvoke(new Action<string>(UpdateReadRegisterData), value); }
                catch (InvalidOperationException) { }
                return;
            }
            textBox_read_reg_data.Text = value;
        }

        private void button_all_ready_Click(object sender, EventArgs e)
        {
            uint exposureEnable = Convert.ToUInt32(textBox_exposure_enable.Text) & 0x3;
            _businessService.WriteRegisters(new List<GvcpRegisterOperation>
            {
                Ready(0x0002A000, 0xC0000081), Ready(0x0003A000, 0xC0001081),
                Ready(0x0004A000, 0xC0002081), Ready(0x0005A000, 0xC001F081),
                Ready(0x0006A000, 0xC0000081), Ready(0x0007A000, 0xC0000081),
                Ready(0x0008A000, 0xC0000081), Ready(0x0009A000, 0xC0000081),
                Ready(0x000AA000, 0xC0000081), Ready(0x000BA000, 0xC0000081),
                Ready(0x000CA000, 0xC0000081), Ready(0x000DA000, 0xC0000081),
                Ready(0x0001A068, 0x00000281), Ready(0x0001A074, exposureEnable)
            }, "all slave node ready");
        }

        private void SynchronizeTimestamp()
        {
            DateTime now = DateTime.Now;
            uint date = (uint)(now.Year / 100) << 24 | (uint)(now.Year % 100) << 16 |
                        (uint)now.Month << 8 | (uint)now.Day;
            uint time = (uint)now.Hour << 16 | (uint)now.Minute << 8 | (uint)now.Second;
            _businessService.WriteRegisters(new List<GvcpRegisterOperation>
            {
                Ready(0x0000A16C, date), Ready(0x0000A170, time)
            }, "sync timestamp");
        }

        private void ConfigureExposureEnable()
        {
            uint value = Convert.ToUInt32(textBox_exposure_enable.Text);
            _businessService.WriteRegister(0x0001A074, value, "exposure enable");
        }

        private static GvcpRegisterOperation Ready(uint address, uint data)
        {
            return new GvcpRegisterOperation { Address = address, Data = data };
        }
    }
}
