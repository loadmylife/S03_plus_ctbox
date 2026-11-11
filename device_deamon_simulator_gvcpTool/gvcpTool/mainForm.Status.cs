using System;
using System.Globalization;
using gvcpTool.Protocol;

namespace mainWindow
{
    public partial class mainForm
    {
        private void HandlePeriodicStatus(GvcpStatusMessage message)
        {
            HandlePositionStatus(message);
        }

        private void HandlePositionStatus(GvcpStatusMessage message)
        {
            int rawValue;
            if (message.TryGetSignedValue(GvcpStatusProtocolProcessor.GantryPositionAddress, out rawValue))
                UpdateStatusLabel(label_gantry_position_value,
                    string.Format(CultureInfo.InvariantCulture, "{0:F2} бу", rawValue / 100.0));

            if (message.TryGetSignedValue(GvcpStatusProtocolProcessor.CoachAbsolutePositionAddress, out rawValue))
                UpdateStatusLabel(label_coach_position_value,
                    string.Format(CultureInfo.InvariantCulture, "{0:F2} mm", rawValue / 1000.0));
        }

        private void UpdateStatusLabel(System.Windows.Forms.Label label, string text)
        {
            if (IsDisposed || !IsHandleCreated)
                return;

            if (InvokeRequired)
            {
                try { BeginInvoke(new Action<System.Windows.Forms.Label, string>(UpdateStatusLabel), label, text); }
                catch (InvalidOperationException) { }
                return;
            }

            label.Text = text;
        }
    }
}
