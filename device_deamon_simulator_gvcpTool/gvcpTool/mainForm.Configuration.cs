using System;
using System.Windows.Forms;
using gvcpTool.Configuration;

namespace mainWindow
{
    public partial class mainForm
    {
        private static readonly string[] ConfigurationRegisterNames =
        {
            "public_scan_uid", "public_multi_param_info", "public_protocol_mode",
            "public_scan_workflow_skip_enable", "public_scan_base_num", "public_scan_option",
            "public_scan_mode", "public_exposure_mode", "public_multi_energy_mode", "public_scan_loops",
            "public_scan_loop_time", "public_start_scan_mode", "public_nvsync_trigger_type",
            "public_correction_frames", "public_pre_offset_frame_time", "public_exposure_time",
            "public_frame_time", "public_delay_exp_time", "public_exposure_xrays_number",
            "public_frames_per_cycle", "public_series_length", "public_collimator_ctrl",
            "public_coll_spot_delay", "public_ecg_start_pos", "public_ecg_stop_pos",
            "public_gantry_start_pos", "public_gantry_end_pos", "public_gantry_acceleration",
            "public_gantry_deceleration", "public_gantry_work_speed", "public_coach_start_pos",
            "public_coach_end_pos", "public_coach_exposure_start_pos", "public_coach_exposure_end_pos",
            "public_coach_accelerate", "public_coach_work_speed", "public_coach_feed",
            "public_idx_kv0", "public_idx_kv1", "public_idx_kv2", "public_idx_kv3",
            "public_idx_kv4", "public_idx_kv5", "public_idx_kv6", "public_idx_kv7",
            "public_idx_ma0", "public_idx_ma1", "public_idx_ma2", "public_idx_ma3",
            "public_idx_ma4", "public_idx_ma5", "public_idx_ma6", "public_idx_ma7",
            "public_xray_focus", "public_xray_spot_delay_time", "public_xray_error_limit",
            "public_voice_id", "public_voice_play_time", "public_det_gain", "public_det_binning",
            "public_det_shutter", "public_det_acq_mode", "public_det_encode_mode",
            "public_det_nvsync_delay", "public_det_preoffset_enable", "public_det_preoffset_num",
            "public_scan_param_reserved_0x0254", "public_scan_param_reserved_0x0258",
            "public_scan_param_reserved_0x025C", "public_scan_param_reserved_0x0260",
            "public_param_end_flag"
        };

        private void InitializeUiFromConfiguration()
        {
            BindDefault(textBox_scan_uid, "public_scan_uid");
            BindDefault(textBox_multi_param_info, "public_multi_param_info");
            BindDefault(comboBox_protocol_mode, "public_protocol_mode");
            BindDefault(comboBox_workflow_skip_enable, "public_scan_workflow_skip_enable");
            BindDefault(textBox_scan_base_num, "public_scan_base_num");
            BindDefault(textBox_scan_loops, "public_scan_loops");
            BindDefault(textBox_scan_loop_time, "public_scan_loop_time");
            BindDefault(textBox_start_scan_mode, "public_start_scan_mode");
            BindDefault(textBox_correction_frames, "public_correction_frames");
            BindDefault(textBox_pre_oft_frame_time, "public_pre_offset_frame_time");
            BindDefault(textBox_exposure_time, "public_exposure_time");
            BindDefault(textBox_frame_time, "public_frame_time");
            BindDefault(textBox_delay_exp_time, "public_delay_exp_time");
            BindDefault(textBox_exposure_xrays_num, "public_exposure_xrays_number");
            BindDefault(textBox_frame_per_cycle, "public_frames_per_cycle");
            BindDefault(textBox_series_length, "public_series_length");
            BindDefault(textBox_collimator_ctrl, "public_collimator_ctrl");
            BindDefault(textBox_coll_spot_delay, "public_coll_spot_delay");
            BindDefault(textBox_ecg_start_pos, "public_ecg_start_pos");
            BindDefault(textBox_ecg_stop_pos, "public_ecg_stop_pos");
            BindDefault(textBox_start_angle, "public_gantry_start_pos");
            BindDefault(textBox_stop_angle, "public_gantry_end_pos");
            BindDefault(textBox_gantry_acc, "public_gantry_acceleration");
            BindDefault(textBox_gantry_dec, "public_gantry_deceleration");
            BindDefault(textBox_gantry_speed, "public_gantry_work_speed");
            BindDefault(textBox_coach_start_pos, "public_coach_start_pos");
            BindDefault(textBox_coach_stop_pos, "public_coach_end_pos");
            BindDefault(textBox_coach_exposure_start_pos, "public_coach_exposure_start_pos");
            BindDefault(textBox_coach_exposure_stop_pos, "public_coach_exposure_end_pos");
            BindDefault(textBox_coach_acc, "public_coach_accelerate");
            BindDefault(textBox_coach_speed, "public_coach_work_speed");
            BindDefault(textBox_coach_feed, "public_coach_feed");
            BindDefault(textBox_kv, "public_idx_kv0");
            BindDefault(textBox_ma, "public_idx_ma0");
            BindDefault(comboBox_xray_focus, "public_xray_focus");
            BindDefault(textBox_xray_spot_delay_time, "public_xray_spot_delay_time");
            BindDefault(textBox_xray_error_limit, "public_xray_error_limit");
            BindDefault(textBox_voice_id, "public_voice_id");
            BindDefault(textBox_voice_time, "public_voice_play_time");
            BindDefault(textBox_det_gain, "public_det_gain");
            BindDefault(textBox_det_binning, "public_det_binning");
            BindDefault(textBox_det_shutter, "public_det_shutter");
            BindDefault(textBox_det_acq_mode, "public_det_acq_mode");
            BindDefault(textBox_det_encode_mode, "public_det_encode_mode");
            BindDefault(textBox_det_nvsync_delay, "public_det_nvsync_delay");
            BindDefault(textBox_det_preoffset_enable, "public_det_preoffset_enable");
            BindDefault(textBox_det_preoffset_num, "public_det_preoffset_num");

            comboBox_protocol_mode.SelectedIndex = 0;
            comboBox_workflow_skip_enable.SelectedIndex = 0;
            comboBox_scan_option.SelectedIndex = 1;
            comboBox_scan_mode.SelectedIndex = 0;
            comboBox_exposure_mode.SelectedIndex = 0;
            comboBox_multi_energy_mode.SelectedIndex = 0;
            comboBox_nvsync_trigger_type.SelectedIndex = 0;
            comboBox_xray_focus.SelectedIndex = 1;
            textBox_exposure_enable.Text = "9213";
        }

        private void BuildConfigurationPayload()
        {
            for (int i = 0; i < ConfigurationRegisterNames.Length; i++)
                _configurationPayload[i, 0] = _configuration.ReadAddress(ConfigurationRegisterNames[i]);

            _configurationPayload[0, 1] = Decimal(textBox_scan_uid.Text);
            _configurationPayload[1, 1] = Decimal(textBox_multi_param_info.Text);
            _configurationPayload[2, 1] = (uint)(comboBox_protocol_mode.SelectedIndex + 1);
            _configurationPayload[3, 1] = (uint)comboBox_workflow_skip_enable.SelectedIndex;
            _configurationPayload[4, 1] = Decimal(textBox_scan_base_num.Text);
            _configurationPayload[5, 1] = comboBox_scan_option.SelectedIndex == 4 ? 9u : (uint)(comboBox_scan_option.SelectedIndex + 1);
            _configurationPayload[6, 1] = comboBox_scan_mode.SelectedIndex == 1 ? 8u : 1u;
            _configurationPayload[7, 1] = (uint)(comboBox_exposure_mode.SelectedIndex + 1);
            _configurationPayload[8, 1] = (uint)comboBox_multi_energy_mode.SelectedIndex;
            _configurationPayload[9, 1] = Decimal(textBox_scan_loops.Text);
            _configurationPayload[10, 1] = Decimal(textBox_scan_loop_time.Text);
            _configurationPayload[11, 1] = Decimal(textBox_start_scan_mode.Text);
            _configurationPayload[12, 1] = (uint)(comboBox_nvsync_trigger_type.SelectedIndex + 1);
            _configurationPayload[13, 1] = Decimal(textBox_correction_frames.Text);
            _configurationPayload[14, 1] = Decimal(textBox_pre_oft_frame_time.Text);
            _configurationPayload[15, 1] = Decimal(textBox_exposure_time.Text);
            _configurationPayload[16, 1] = Decimal(textBox_frame_time.Text);
            _configurationPayload[17, 1] = Decimal(textBox_delay_exp_time.Text);
            _configurationPayload[18, 1] = Decimal(textBox_exposure_xrays_num.Text);
            _configurationPayload[19, 1] = Decimal(textBox_frame_per_cycle.Text);
            _configurationPayload[20, 1] = Decimal(textBox_series_length.Text);
            _configurationPayload[21, 1] = Decimal(textBox_collimator_ctrl.Text);
            _configurationPayload[22, 1] = Decimal(textBox_coll_spot_delay.Text);
            _configurationPayload[23, 1] = Decimal(textBox_ecg_start_pos.Text);
            _configurationPayload[24, 1] = Decimal(textBox_ecg_stop_pos.Text);
            _configurationPayload[25, 1] = Decimal(textBox_start_angle.Text);
            _configurationPayload[26, 1] = Decimal(textBox_stop_angle.Text);
            _configurationPayload[27, 1] = Decimal(textBox_gantry_acc.Text);
            _configurationPayload[28, 1] = Decimal(textBox_gantry_dec.Text);
            _configurationPayload[29, 1] = Decimal(textBox_gantry_speed.Text);
            _configurationPayload[30, 1] = Decimal(textBox_coach_start_pos.Text);
            _configurationPayload[31, 1] = Decimal(textBox_coach_stop_pos.Text);
            _configurationPayload[32, 1] = Decimal(textBox_coach_exposure_start_pos.Text);
            _configurationPayload[33, 1] = Decimal(textBox_coach_exposure_stop_pos.Text);
            _configurationPayload[34, 1] = Decimal(textBox_coach_acc.Text);
            _configurationPayload[35, 1] = Decimal(textBox_coach_speed.Text);
            _configurationPayload[36, 1] = Decimal(textBox_coach_feed.Text);
            FillRange(37, 44, Decimal(textBox_kv.Text));
            FillRange(45, 52, Decimal(textBox_ma.Text));
            _configurationPayload[53, 1] = (uint)comboBox_xray_focus.SelectedIndex;
            _configurationPayload[54, 1] = Decimal(textBox_xray_spot_delay_time.Text);
            _configurationPayload[55, 1] = Decimal(textBox_xray_error_limit.Text);
            _configurationPayload[56, 1] = Decimal(textBox_voice_id.Text);
            _configurationPayload[57, 1] = Decimal(textBox_voice_time.Text);
            _configurationPayload[58, 1] = Decimal(textBox_det_gain.Text);
            _configurationPayload[59, 1] = Decimal(textBox_det_binning.Text);
            _configurationPayload[60, 1] = Decimal(textBox_det_shutter.Text);
            _configurationPayload[61, 1] = Decimal(textBox_det_acq_mode.Text);
            _configurationPayload[62, 1] = Decimal(textBox_det_encode_mode.Text);
            _configurationPayload[63, 1] = Decimal(textBox_det_nvsync_delay.Text);
            _configurationPayload[64, 1] = Decimal(textBox_det_preoffset_enable.Text);
            _configurationPayload[65, 1] = Decimal(textBox_det_preoffset_num.Text);
            FillRange(66, 70, 0);
        }

        private void BindDefault(Control control, string registerName)
        {
            control.Text = _configuration.ReadDefaultValue(registerName).ToString();
        }

        private void FillRange(int start, int end, uint value)
        {
            for (int i = start; i <= end; i++)
                _configurationPayload[i, 1] = value;
        }

        private static uint Decimal(string value)
        {
            return Convert.ToUInt32(value);
        }

        private static uint ParseHexUInt(string value)
        {
            return GvcpUiConfiguration.ParseHex(value);
        }
    }
}
