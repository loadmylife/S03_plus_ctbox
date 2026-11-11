using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using gvcpTool.Configuration;

namespace mainWindow
{
    public partial class mainForm
    {
        private const string ParameterFileFilter = "GVCP parameter files (*.xml)|*.xml|All files (*.*)|*.*";

        private void button_load_param_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Load parameter file";
                dialog.Filter = ParameterFileFilter;
                dialog.CheckFileExists = true;
                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    Dictionary<string, uint> parameters = GvcpParameterFile.Load(dialog.FileName);
                    ApplyParameterFile(parameters);
                    nv_log(string.Format("parameter file loaded: {0} ({1} parameters)", dialog.FileName, parameters.Count));
                }
                catch (Exception ex)
                {
                    nv_log("parameter file load failed: " + ex.Message);
                    MessageBox.Show(this, ex.Message, "Load parameter file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_save_param_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Save parameter file";
                dialog.Filter = ParameterFileFilter;
                dialog.DefaultExt = "xml";
                dialog.AddExtension = true;
                dialog.FileName = "gvcp_parameters.xml";
                dialog.OverwritePrompt = true;
                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    BuildConfigurationPayload();
                    List<GvcpParameterValue> parameters = new List<GvcpParameterValue>(GvcpUiConfiguration.RegisterCount);
                    for (int i = 0; i < ConfigurationRegisterNames.Length; i++)
                    {
                        parameters.Add(new GvcpParameterValue
                        {
                            Name = _configuration.ReadRegisterName(ConfigurationRegisterNames[i]),
                            Value = _configurationPayload[i, 1]
                        });
                    }
                    GvcpParameterFile.Save(dialog.FileName, parameters);
                    nv_log(string.Format("parameter file saved: {0} ({1} parameters)", dialog.FileName, parameters.Count));
                }
                catch (Exception ex)
                {
                    nv_log("parameter file save failed: " + ex.Message);
                    MessageBox.Show(this, ex.Message, "Save parameter file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ApplyParameterFile(IDictionary<string, uint> parameters)
        {
            uint?[] values = new uint?[GvcpUiConfiguration.RegisterCount];
            foreach (KeyValuePair<string, uint> parameter in parameters)
            {
                int index = FindConfigurationRegister(parameter.Key);
                if (index < 0)
                    throw new InvalidDataException("Unknown register name: " + parameter.Key);
                values[index] = parameter.Value;
            }

            int? protocolMode = ComboIndex(values[2], 1, 2, "public_protocol_mode");
            int? workflowSkip = ComboIndex(values[3], 0, 1, "public_scan_workflow_skip_enable");
            int? scanOption = ScanOptionIndex(values[5]);
            int? scanMode = ScanModeIndex(values[6]);
            int? exposureMode = ComboIndex(values[7], 1, 4, "public_exposure_mode");
            int? multiEnergy = ComboIndex(values[8], 0, 4, "public_multi_energy_mode");
            int? triggerType = ComboIndex(values[12], 1, 4, "public_nvsync_trigger_type");
            int? xrayFocus = ComboIndex(values[53], 0, 1, "public_xray_focus");

            SetText(values[0], textBox_scan_uid);
            SetText(values[1], textBox_multi_param_info);
            SetText(values[4], textBox_scan_base_num);
            SetText(values[9], textBox_scan_loops);
            SetText(values[10], textBox_scan_loop_time);
            SetText(values[11], textBox_start_scan_mode);
            SetText(values[13], textBox_correction_frames);
            SetText(values[14], textBox_pre_oft_frame_time);
            SetText(values[15], textBox_exposure_time);
            SetText(values[16], textBox_frame_time);
            SetText(values[17], textBox_delay_exp_time);
            SetText(values[18], textBox_exposure_xrays_num);
            SetText(values[19], textBox_frame_per_cycle);
            SetText(values[20], textBox_series_length);
            SetText(values[21], textBox_collimator_ctrl);
            SetText(values[22], textBox_coll_spot_delay);
            SetText(values[23], textBox_ecg_start_pos);
            SetText(values[24], textBox_ecg_stop_pos);
            SetText(values[25], textBox_start_angle);
            SetText(values[26], textBox_stop_angle);
            SetText(values[27], textBox_gantry_acc);
            SetText(values[28], textBox_gantry_dec);
            SetText(values[29], textBox_gantry_speed);
            SetText(values[30], textBox_coach_start_pos);
            SetText(values[31], textBox_coach_stop_pos);
            SetText(values[32], textBox_coach_exposure_start_pos);
            SetText(values[33], textBox_coach_exposure_stop_pos);
            SetText(values[34], textBox_coach_acc);
            SetText(values[35], textBox_coach_speed);
            SetText(values[36], textBox_coach_feed);
            SetText(values[37], textBox_kv);
            SetText(values[45], textBox_ma);
            SetText(values[54], textBox_xray_spot_delay_time);
            SetText(values[55], textBox_xray_error_limit);
            SetText(values[56], textBox_voice_id);
            SetText(values[57], textBox_voice_time);
            SetText(values[58], textBox_det_gain);
            SetText(values[59], textBox_det_binning);
            SetText(values[60], textBox_det_shutter);
            SetText(values[61], textBox_det_acq_mode);
            SetText(values[62], textBox_det_encode_mode);
            SetText(values[63], textBox_det_nvsync_delay);
            SetText(values[64], textBox_det_preoffset_enable);
            SetText(values[65], textBox_det_preoffset_num);

            SetCombo(protocolMode, comboBox_protocol_mode);
            SetCombo(workflowSkip, comboBox_workflow_skip_enable);
            SetCombo(scanOption, comboBox_scan_option);
            SetCombo(scanMode, comboBox_scan_mode);
            SetCombo(exposureMode, comboBox_exposure_mode);
            SetCombo(multiEnergy, comboBox_multi_energy_mode);
            SetCombo(triggerType, comboBox_nvsync_trigger_type);
            SetCombo(xrayFocus, comboBox_xray_focus);
        }

        private int FindConfigurationRegister(string registerName)
        {
            for (int i = 0; i < ConfigurationRegisterNames.Length; i++)
            {
                if (string.Equals(_configuration.ReadRegisterName(ConfigurationRegisterNames[i]), registerName,
                    StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        private static int? ComboIndex(uint? value, uint minimum, uint maximum, string registerName)
        {
            if (!value.HasValue)
                return null;
            if (value.Value < minimum || value.Value > maximum)
                throw new InvalidDataException(registerName + " contains an unsupported value: " + value.Value);
            return (int)(value.Value - minimum);
        }

        private static int? ScanOptionIndex(uint? value)
        {
            if (!value.HasValue)
                return null;
            if (value.Value >= 1 && value.Value <= 4)
                return (int)value.Value - 1;
            if (value.Value == 9)
                return 4;
            throw new InvalidDataException("public_scan_option contains an unsupported value: " + value.Value);
        }

        private static int? ScanModeIndex(uint? value)
        {
            if (!value.HasValue)
                return null;
            if (value.Value == 1)
                return 0;
            if (value.Value == 8)
                return 1;
            throw new InvalidDataException("public_scan_mode contains an unsupported value: " + value.Value);
        }

        private static void SetText(uint? value, TextBox control)
        {
            if (value.HasValue)
                control.Text = value.Value.ToString();
        }

        private static void SetCombo(int? index, ComboBox control)
        {
            if (index.HasValue)
                control.SelectedIndex = index.Value;
        }
    }
}
