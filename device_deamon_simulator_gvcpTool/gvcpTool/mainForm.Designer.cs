namespace mainWindow
{

    public static class gui_params
    {
        public const int    GUI_MAX_WIDTH = 1200;
        public const int    GUI_MAX_HEIGHT = 800;

        public const int    LABELE_WIDTH = 160;
        public const int    LABELE_HEIGHT = 20;

        public const int    TEXTBOX_WIDTH = 100;
        public const int    TEXTBOX_HEIGHT = 20;

        //public const int    GUI_ROW_HEIGHT = 22;
        public const int    GUI_GAP = 5;
        public const int    GUI_COLUM_1_POS_X = 10;
        public const int    GUI_COLUM_2_POS_X = GUI_COLUM_1_POS_X + LABELE_WIDTH + TEXTBOX_WIDTH + GUI_GAP;
        public const int    GUI_COLUM_3_POS_X = GUI_COLUM_2_POS_X + LABELE_WIDTH + TEXTBOX_WIDTH + GUI_GAP;
        public const int    GUI_COLUM_4_POS_X = GUI_COLUM_3_POS_X + LABELE_WIDTH + TEXTBOX_WIDTH + GUI_GAP;
        public const int    GUI_COLUM_5_POS_X = GUI_COLUM_4_POS_X + LABELE_WIDTH + TEXTBOX_WIDTH + GUI_GAP;
        public const int    GUI_COLUM_6_POS_X = GUI_COLUM_5_POS_X + LABELE_WIDTH + TEXTBOX_WIDTH + GUI_GAP;
        public const int    GUI_ROW_1_POS_Y = 20;
        public const int    GUI_ROW_2_POS_Y = 380;


        public const int GUI_CTRL_AREA_POS_X = 10;
        public const int GUI_CTRL_AREA_POS_Y = 560;
        public const int GUI_LINE_HEIGHT = 6;

        public const int GUI_BUTTON_SIZE_WIDTH = 120;
        public const int GUI_BUTTON_SIZE_HEIGHT = 40;
    }

    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        public void form_parameter_definition()
        {
            /* scan params edit module */
            this.label_scan_params = new System.Windows.Forms.Label();
            this.label_exposure_params = new System.Windows.Forms.Label();
            this.label_ifbox_params = new System.Windows.Forms.Label();
            this.label_gantry_params = new System.Windows.Forms.Label();
            this.label_coach_params = new System.Windows.Forms.Label();
            this.label_gantry_position_value = new System.Windows.Forms.Label();
            this.label_coach_position_value = new System.Windows.Forms.Label();
            this.label_xray_params = new System.Windows.Forms.Label();
            this.label_auxboard_params = new System.Windows.Forms.Label();
            this.label_detector_params = new System.Windows.Forms.Label();

            this.tableLayoutPanel_scan_params = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_exposure_params = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ifbox_params = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_gantry_params = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_coach_params = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_xray_params = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_auxboard_params = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_detector_params = new System.Windows.Forms.TableLayoutPanel();

            /* divider between edit module and control module */
            this.label_line = new System.Windows.Forms.Label();

            /* register send module */
            this.tableLayoutPanel_reg_ctrl = new System.Windows.Forms.TableLayoutPanel();
            this.label_reg_addr = new System.Windows.Forms.Label();
            this.textBox_reg_addr = new System.Windows.Forms.TextBox();

            this.label_reg_data = new System.Windows.Forms.Label();
            this.textBox_reg_data = new System.Windows.Forms.TextBox();

            this.button_reg_send = new System.Windows.Forms.Button();


            /* register read module */
            this.tableLayoutPanel_read_reg_ctrl = new System.Windows.Forms.TableLayoutPanel();
            this.label_read_reg_addr = new System.Windows.Forms.Label();
            this.textBox_read_reg_addr = new System.Windows.Forms.TextBox();

            this.label_read_reg_data = new System.Windows.Forms.Label();
            this.textBox_read_reg_data = new System.Windows.Forms.TextBox();

            this.button_reg_read = new System.Windows.Forms.Button();


            /* scan control module */
            this.tableLayoutPanel_scan_ctrl = new System.Windows.Forms.TableLayoutPanel();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_start_scan = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_all_ready = new System.Windows.Forms.Button();
            this.button_load_param = new System.Windows.Forms.Button();
            this.button_save_param = new System.Windows.Forms.Button();
            

            /* log module */
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.button_clear_log = new System.Windows.Forms.Button();
        }
        public void scan_parameter_definition()
        {
            this.label_scan_uid = new System.Windows.Forms.Label();
            this.textBox_scan_uid = new System.Windows.Forms.TextBox();
            this.label_multi_param_info = new System.Windows.Forms.Label();
            this.textBox_multi_param_info = new System.Windows.Forms.TextBox();
            this.label_protocol_mode = new System.Windows.Forms.Label();
            this.comboBox_protocol_mode = new System.Windows.Forms.ComboBox();
            this.label_workflow_skip_enable = new System.Windows.Forms.Label();
            this.comboBox_workflow_skip_enable = new System.Windows.Forms.ComboBox();
            this.label_scan_base_num = new System.Windows.Forms.Label();
            this.textBox_scan_base_num = new System.Windows.Forms.TextBox();
            this.label_scan_option = new System.Windows.Forms.Label();
            this.comboBox_scan_option = new System.Windows.Forms.ComboBox();
            this.label_scan_mode = new System.Windows.Forms.Label();
            this.comboBox_scan_mode = new System.Windows.Forms.ComboBox();
            this.label_expsoure_mode = new System.Windows.Forms.Label();
            this.comboBox_exposure_mode = new System.Windows.Forms.ComboBox();
            this.label_multi_energy_mode = new System.Windows.Forms.Label();
            this.comboBox_multi_energy_mode = new System.Windows.Forms.ComboBox();
            this.label_scan_loops = new System.Windows.Forms.Label();
            this.textBox_scan_loops = new System.Windows.Forms.TextBox();
            this.label_scan_loop_time = new System.Windows.Forms.Label();
            this.textBox_scan_loop_time = new System.Windows.Forms.TextBox();
            this.label_start_scan_mode = new System.Windows.Forms.Label();
            this.textBox_start_scan_mode = new System.Windows.Forms.TextBox();
            this.label_nvsync_trigger_type = new System.Windows.Forms.Label();
            this.comboBox_nvsync_trigger_type = new System.Windows.Forms.ComboBox();
            this.label_correction_frames = new System.Windows.Forms.Label();
            this.textBox_correction_frames = new System.Windows.Forms.TextBox();
            this.label_pre_oft_frame_time = new System.Windows.Forms.Label();
            this.textBox_pre_oft_frame_time = new System.Windows.Forms.TextBox();
            this.label_exposure_time = new System.Windows.Forms.Label();
            this.textBox_exposure_time = new System.Windows.Forms.TextBox();
            this.label_frame_time = new System.Windows.Forms.Label();
            this.textBox_frame_time = new System.Windows.Forms.TextBox();
            this.label_delay_exp_time = new System.Windows.Forms.Label();
            this.textBox_delay_exp_time = new System.Windows.Forms.TextBox();
            this.label_exposure_xrays_num = new System.Windows.Forms.Label();
            this.textBox_exposure_xrays_num = new System.Windows.Forms.TextBox();
            this.label_frame_per_cycle = new System.Windows.Forms.Label();
            this.textBox_frame_per_cycle = new System.Windows.Forms.TextBox();
            this.label_series_length = new System.Windows.Forms.Label();
            this.textBox_series_length = new System.Windows.Forms.TextBox();
            this.label_collimator_ctrl = new System.Windows.Forms.Label();
            this.textBox_collimator_ctrl = new System.Windows.Forms.TextBox();
            this.label_coll_spot_delay = new System.Windows.Forms.Label();
            this.textBox_coll_spot_delay = new System.Windows.Forms.TextBox();
            this.label_ecg_start_pos = new System.Windows.Forms.Label();
            this.textBox_ecg_start_pos = new System.Windows.Forms.TextBox();
            this.label_ecg_stop_pos = new System.Windows.Forms.Label();
            this.textBox_ecg_stop_pos = new System.Windows.Forms.TextBox();
            this.label_start_angle = new System.Windows.Forms.Label();
            this.textBox_start_angle = new System.Windows.Forms.TextBox();
            this.label_stop_angle = new System.Windows.Forms.Label();
            this.textBox_stop_angle = new System.Windows.Forms.TextBox();
            this.label_gantry_acc = new System.Windows.Forms.Label();
            this.textBox_gantry_acc = new System.Windows.Forms.TextBox();
            this.label_gantry_dec = new System.Windows.Forms.Label();
            this.textBox_gantry_dec = new System.Windows.Forms.TextBox();
            this.label_gantry_speed = new System.Windows.Forms.Label();
            this.textBox_gantry_speed = new System.Windows.Forms.TextBox();
            this.label_coach_start_pos = new System.Windows.Forms.Label();
            this.textBox_coach_start_pos = new System.Windows.Forms.TextBox();
            this.label_coach_stop_pos = new System.Windows.Forms.Label();
            this.textBox_coach_stop_pos = new System.Windows.Forms.TextBox();
            this.label_coach_exposure_start_pos = new System.Windows.Forms.Label();
            this.textBox_coach_exposure_start_pos = new System.Windows.Forms.TextBox();
            this.label_coach_exposure_stop_pos = new System.Windows.Forms.Label();
            this.textBox_coach_exposure_stop_pos = new System.Windows.Forms.TextBox();
            this.label_coach_acc = new System.Windows.Forms.Label();
            this.textBox_coach_acc = new System.Windows.Forms.TextBox();
            this.label_coach_speed = new System.Windows.Forms.Label();
            this.textBox_coach_speed = new System.Windows.Forms.TextBox();
            this.label_coach_feed = new System.Windows.Forms.Label();
            this.textBox_coach_feed = new System.Windows.Forms.TextBox();
            this.label_kv = new System.Windows.Forms.Label();
            this.textBox_kv = new System.Windows.Forms.TextBox();
            this.label_ma = new System.Windows.Forms.Label();
            this.textBox_ma = new System.Windows.Forms.TextBox();
            this.label_xray_focus = new System.Windows.Forms.Label();
            this.comboBox_xray_focus = new System.Windows.Forms.ComboBox();
            this.label_xray_spot_delay_time = new System.Windows.Forms.Label();
            this.textBox_xray_spot_delay_time = new System.Windows.Forms.TextBox();
            this.label_xray_error_limit = new System.Windows.Forms.Label();
            this.textBox_xray_error_limit = new System.Windows.Forms.TextBox();
            this.label_voice_id = new System.Windows.Forms.Label();
            this.textBox_voice_id = new System.Windows.Forms.TextBox();
            this.label_voice_time = new System.Windows.Forms.Label();
            this.textBox_voice_time = new System.Windows.Forms.TextBox();
            this.label_det_gain = new System.Windows.Forms.Label();
            this.textBox_det_gain = new System.Windows.Forms.TextBox();
            this.label_det_binning = new System.Windows.Forms.Label();
            this.textBox_det_binning = new System.Windows.Forms.TextBox();
            this.label_det_shutter = new System.Windows.Forms.Label();
            this.textBox_det_shutter = new System.Windows.Forms.TextBox();
            this.label_det_acq_mode = new System.Windows.Forms.Label();
            this.textBox_det_acq_mode = new System.Windows.Forms.TextBox();
            this.label_det_encode_mode = new System.Windows.Forms.Label();
            this.textBox_det_encode_mode = new System.Windows.Forms.TextBox();
            this.label_det_nvsync_delay = new System.Windows.Forms.Label();
            this.textBox_det_nvsync_delay = new System.Windows.Forms.TextBox();
            this.label_det_preoffset_enable = new System.Windows.Forms.Label();
            this.textBox_det_preoffset_enable = new System.Windows.Forms.TextBox();
            this.label_det_preoffset_num = new System.Windows.Forms.Label();
            this.textBox_det_preoffset_num = new System.Windows.Forms.TextBox();
            this.label_param_end = new System.Windows.Forms.Label();
            this.textBox_parma_end = new System.Windows.Forms.TextBox();

            this.label_exposure_enable = new System.Windows.Forms.Label();
            this.textBox_exposure_enable = new System.Windows.Forms.TextBox();
            
        }
        public void scan_parameter_edit()
        {
            // 
            // label_scan_params
            // 
            this.label_scan_params.BackColor = System.Drawing.SystemColors.Info;
            this.label_scan_params.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_scan_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_scan_params.Name = "label_scan_params";
            this.label_scan_params.Size = new System.Drawing.Size((gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH) * 2, gui_params.LABELE_HEIGHT);
            this.label_scan_params.TabIndex = 3;
            this.label_scan_params.Text = "scan params";
            // 
            // label_scan_uid
            // 
            this.label_scan_uid.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_scan_uid.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_scan_uid.Name = "label_scan_uid";
            this.label_scan_uid.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_scan_uid.TabIndex = 6;
            this.label_scan_uid.Text = "scan_uid";
            this.label_scan_uid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_scan_uid
            // 
            this.textBox_scan_uid.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_scan_uid.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT * 1); 
            this.textBox_scan_uid.Name = "textBox_scan_uid";
            this.textBox_scan_uid.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_scan_uid.TabIndex = 7;

            // 
            // label_multi_param_info
            // 
            this.label_multi_param_info.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_multi_param_info.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT * 2);
            this.label_multi_param_info.Name = "label_multi_param_info";
            this.label_multi_param_info.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT); 
            this.label_multi_param_info.TabIndex = 6;
            this.label_multi_param_info.Text = "multi_param_info";
            this.label_multi_param_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_multi_param_info
            // 
            this.textBox_multi_param_info.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_multi_param_info.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_multi_param_info.Name = "textBox_multi_param_info";
            this.textBox_multi_param_info.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_multi_param_info.TabIndex = 7;

            // 
            // label_protocol_mode
            // 
            this.label_protocol_mode.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_protocol_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT * 3);
            this.label_protocol_mode.Name = "label_protocol_mode";
            this.label_protocol_mode.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_protocol_mode.TabIndex = 6;
            this.label_protocol_mode.Text = "protocol_mode";
            this.label_protocol_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_protocol_mode
            // 
            this.comboBox_protocol_mode.FormattingEnabled = true;
            this.comboBox_protocol_mode.Items.AddRange(new object[] {
            "1NormalProtocol",
            "2FreeProtocol"});
            this.comboBox_protocol_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.comboBox_protocol_mode.Name = "comboBox_protocol_mode";
            this.comboBox_protocol_mode.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.comboBox_protocol_mode.TabIndex = 7;

            // 
            // label_workflow_skip_enable
            // 
            label_workflow_skip_enable.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_workflow_skip_enable.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT * 3);
            label_workflow_skip_enable.Name = "label_workflow_skip_enable";
            label_workflow_skip_enable.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_workflow_skip_enable.TabIndex = 6;
            label_workflow_skip_enable.Text = "workflow_skip_enable";
            label_workflow_skip_enable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_workflow_skip_enable
            // 
            this.comboBox_workflow_skip_enable.FormattingEnabled = true;
            this.comboBox_workflow_skip_enable.Items.AddRange(new object[] {
            "0Disable",
            "1Enable"});
            this.comboBox_workflow_skip_enable.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.comboBox_workflow_skip_enable.Name = "comboBox_workflow_skip_enable";
            this.comboBox_workflow_skip_enable.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.comboBox_workflow_skip_enable.TabIndex = 7;

            /* label_scan_base_num */
            label_scan_base_num.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_scan_base_num.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT * 3);
            label_scan_base_num.Name = "label_scan_base_num";
            label_scan_base_num.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_scan_base_num.TabIndex = 6;
            label_scan_base_num.Text = "scan_base_num";
            label_scan_base_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_scan_base_num.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_scan_base_num.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT * 3);
            this.textBox_scan_base_num.Name = "textBox_scan_base_num";
            this.textBox_scan_base_num.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_scan_base_num.TabIndex = 7;

            /* label_scan_option */
            label_scan_option.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_scan_option.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT * 3);
            label_scan_option.Name = "label_scan_option";
            label_scan_option.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_scan_option.TabIndex = 6;
            label_scan_option.Text = "scan_option";
            label_scan_option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.comboBox_scan_option.FormattingEnabled = true;
            this.comboBox_scan_option.Items.AddRange(new object[] {
            "1SURVIEW",
            "2AXIAL",
            "3HELICAL",
            "4DUAL-SURVIEW",
            "9Cine"});
            this.comboBox_scan_option.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.comboBox_scan_option.Name = "comboBox_scan_option";
            this.comboBox_scan_option.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.comboBox_scan_option.TabIndex = 7;

            /* label_scan_mode */
            label_scan_mode.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_scan_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            label_scan_mode.Name = "label_scan_mode";
            label_scan_mode.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_scan_mode.TabIndex = 6;
            label_scan_mode.Text = "scan_mode";
            label_scan_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.comboBox_scan_mode.FormattingEnabled = true;
            this.comboBox_scan_mode.Items.AddRange(new object[] {
            "1Plain",
            "8Jump"});
            this.comboBox_scan_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.comboBox_scan_mode.Name = "comboBox_scan_mode";
            this.comboBox_scan_mode.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.comboBox_scan_mode.TabIndex = 7;

            /* label_expsoure_mode */
            this.label_expsoure_mode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_expsoure_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_expsoure_mode.Name = "label_expsoure_mode";
            this.label_expsoure_mode.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_expsoure_mode.Text = "expsoure_mode";
            this.label_expsoure_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.comboBox_exposure_mode.FormattingEnabled = true;
            this.comboBox_exposure_mode.Items.AddRange(new object[] {
            "1SingleSource",
            "2DualSource",
            "3ThreeSource",
            "4SixSource"});
            this.comboBox_exposure_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.comboBox_exposure_mode.Name = "comboBox_exposure_mode";
            this.comboBox_exposure_mode.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.comboBox_exposure_mode.TabIndex = 9;

            /* label_multi_energy_mode */
            this.label_multi_energy_mode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_multi_energy_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_multi_energy_mode.Name = "label_multi_energy_mode";
            this.label_multi_energy_mode.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_multi_energy_mode.Text = "multi_energy_mode";
            this.label_multi_energy_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.comboBox_multi_energy_mode.FormattingEnabled = true;
            this.comboBox_multi_energy_mode.Items.AddRange(new object[] {
            "0Single(default)",
            "1Dual(Odd-Even)",
            "2Three",
            "3Notuse",
            "4Dual(1-12;13-24)"});
            this.comboBox_multi_energy_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.comboBox_multi_energy_mode.Name = "comboBox_exposure_mode";
            this.comboBox_multi_energy_mode.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.comboBox_multi_energy_mode.TabIndex = 9;

            /* label_scan_loops */
            label_scan_loops.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_scan_loops.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            label_scan_loops.Name = "label_scan_loops";
            label_scan_loops.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_scan_loops.TabIndex = 6;
            label_scan_loops.Text = "scan_loops";
            label_scan_loops.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_scan_loops.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_scan_loops.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_scan_loops.Name = "textBox_scan_loops";
            this.textBox_scan_loops.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_scan_loops.TabIndex = 7;

            /* label_scan_loop_time */
            label_scan_loop_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_scan_loop_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            label_scan_loop_time.Name = "label_scan_loop_time";
            label_scan_loop_time.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_scan_loop_time.TabIndex = 6;
            label_scan_loop_time.Text = "scan_loop_time";
            label_scan_loop_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_scan_loop_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_scan_loop_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_scan_loop_time.Name = "textBox_scan_loop_time";
            this.textBox_scan_loop_time.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_scan_loop_time.TabIndex = 7;

            /* label_start_scan_mode */
            label_start_scan_mode.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_start_scan_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            label_start_scan_mode.Name = "label_start_scan_mode";
            label_start_scan_mode.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_start_scan_mode.TabIndex = 6;
            label_start_scan_mode.Text = "start_scan_mode";
            label_start_scan_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_start_scan_mode.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_start_scan_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_start_scan_mode.Name = "textBox_start_scan_mode";
            this.textBox_start_scan_mode.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_start_scan_mode.TabIndex = 7;

            /* label_nvsync_trigger_type */
            this.label_nvsync_trigger_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_nvsync_trigger_type.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_nvsync_trigger_type.Name = "label_nvsync_trigger_type";
            this.label_nvsync_trigger_type.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_nvsync_trigger_type.Text = "nvsync_trigger_type";
            this.label_nvsync_trigger_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.comboBox_nvsync_trigger_type.FormattingEnabled = true;
            this.comboBox_nvsync_trigger_type.Items.AddRange(new object[] {
            "1Time",
            "2Angel",
            "3TableFeed",
            "4ECG"});
            this.comboBox_nvsync_trigger_type.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.comboBox_nvsync_trigger_type.Name = "comboBox_exposure_mode";
            this.comboBox_nvsync_trigger_type.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.comboBox_nvsync_trigger_type.TabIndex = 9;


            /* label_correction_frames */
            label_correction_frames.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_correction_frames.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            label_correction_frames.Name = "label_correction_frames";
            label_correction_frames.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_correction_frames.TabIndex = 6;
            label_correction_frames.Text = "correction_frames";
            label_correction_frames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_correction_frames.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_correction_frames.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_correction_frames.Name = "textBox_correction_frames";
            this.textBox_correction_frames.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_correction_frames.TabIndex = 7;

            /* label_pre_oft_frame_time */
            label_pre_oft_frame_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_pre_oft_frame_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            label_pre_oft_frame_time.Name = "label_pre_oft_frame_time";
            label_pre_oft_frame_time.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_pre_oft_frame_time.TabIndex = 6;
            label_pre_oft_frame_time.Text = "pre_oft_frame_time";
            label_pre_oft_frame_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_pre_oft_frame_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_pre_oft_frame_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_pre_oft_frame_time.Name = "textBox_pre_oft_frame_time";
            this.textBox_pre_oft_frame_time.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_pre_oft_frame_time.TabIndex = 7;

            /* label_exposure_time */
            label_exposure_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_exposure_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            label_exposure_time.Name = "label_exposure_time";
            label_exposure_time.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_exposure_time.TabIndex = 6;
            label_exposure_time.Text = "exposure_time";
            label_exposure_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_exposure_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_exposure_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_exposure_time.Name = "textBox_exposure_time";
            this.textBox_exposure_time.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_exposure_time.TabIndex = 7;

            /* label_frame_time */
            label_frame_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_frame_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            label_frame_time.Name = "label_frame_time";
            label_frame_time.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            label_frame_time.TabIndex = 6;
            label_frame_time.Text = "frame_time";
            label_frame_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_frame_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_frame_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_frame_time.Name = "textBox_frame_time";
            this.textBox_frame_time.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_frame_time.TabIndex = 7;


            /* label_delay_exp_time */
            this.label_delay_exp_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_delay_exp_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_delay_exp_time.Name = "label_delay_exp_time";
            this.label_delay_exp_time.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_delay_exp_time.TabIndex = 6;
            this.label_delay_exp_time.Text = "delay_exp_time";
            this.label_delay_exp_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_delay_exp_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_delay_exp_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_delay_exp_time.Name = "textBox_delay_exp_time";
            this.textBox_delay_exp_time.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_delay_exp_time.TabIndex = 7;


            /* label_exposure_xrays_num */
            this.label_exposure_xrays_num.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_exposure_xrays_num.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_exposure_xrays_num.Name = "label_exposure_xrays_num";
            this.label_exposure_xrays_num.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_exposure_xrays_num.TabIndex = 6;
            this.label_exposure_xrays_num.Text = "exposure_xrays_num";
            this.label_exposure_xrays_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_exposure_xrays_num.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_exposure_xrays_num.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_exposure_xrays_num.Name = "textBox_exposure_xrays_num";
            this.textBox_exposure_xrays_num.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_exposure_xrays_num.TabIndex = 7;

            /* label_frame_per_cycle */
            this.label_frame_per_cycle.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_frame_per_cycle.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_frame_per_cycle.Name = "label_frame_per_cycle";
            this.label_frame_per_cycle.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_frame_per_cycle.TabIndex = 6;
            this.label_frame_per_cycle.Text = "frame_per_cycle";
            this.label_frame_per_cycle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_frame_per_cycle.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_frame_per_cycle.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_frame_per_cycle.Name = "textBox_frame_per_cycle";
            this.textBox_frame_per_cycle.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_frame_per_cycle.TabIndex = 7;

            /* label_series_length */
            this.label_series_length.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_series_length.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_series_length.Name = "label_series_length";
            this.label_series_length.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_series_length.TabIndex = 6;
            this.label_series_length.Text = "series_length";
            this.label_series_length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_series_length.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_series_length.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_series_length.Name = "textBox_series_length";
            this.textBox_series_length.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_series_length.TabIndex = 7;

            /* label_exposure_enable */
            this.label_exposure_enable.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_exposure_enable.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_exposure_enable.Name = "label_exposure_enable";
            this.label_exposure_enable.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_exposure_enable.TabIndex = 6;
            this.label_exposure_enable.Text = "exposure_enable";
            this.label_exposure_enable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_exposure_enable.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_exposure_enable.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.textBox_exposure_enable.Name = "textBox_exposure_enable";
            this.textBox_exposure_enable.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_exposure_enable.TabIndex = 7;


            this.tableLayoutPanel_scan_params.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_scan_params.ColumnCount = 4;
            this.tableLayoutPanel_scan_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_scan_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_scan_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_scan_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_scan_uid, 0, 0);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_scan_uid, 1, 0);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_multi_param_info, 0, 1);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_multi_param_info, 1, 1);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_protocol_mode, 0, 2);
            this.tableLayoutPanel_scan_params.Controls.Add(this.comboBox_protocol_mode, 1, 2);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_workflow_skip_enable, 0, 3);
            this.tableLayoutPanel_scan_params.Controls.Add(this.comboBox_workflow_skip_enable, 1, 3);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_scan_base_num, 0, 4);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_scan_base_num, 1, 4);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_scan_option, 0, 5);
            this.tableLayoutPanel_scan_params.Controls.Add(this.comboBox_scan_option, 1, 5);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_scan_mode, 0, 6);
            this.tableLayoutPanel_scan_params.Controls.Add(this.comboBox_scan_mode, 1, 6);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_expsoure_mode, 0, 7);
            this.tableLayoutPanel_scan_params.Controls.Add(this.comboBox_exposure_mode, 1, 7);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_multi_energy_mode, 0, 8);
            this.tableLayoutPanel_scan_params.Controls.Add(this.comboBox_multi_energy_mode, 1, 8);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_scan_loops, 0, 9);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_scan_loops, 1, 9);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_scan_loop_time, 0, 10);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_scan_loop_time, 1, 10);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_start_scan_mode, 0, 11);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_start_scan_mode, 1, 11);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_nvsync_trigger_type, 0, 12);
            this.tableLayoutPanel_scan_params.Controls.Add(this.comboBox_nvsync_trigger_type, 1, 12);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_correction_frames, 0, 13);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_correction_frames, 1, 13);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_pre_oft_frame_time, 0, 14);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_pre_oft_frame_time, 1, 14);


            this.tableLayoutPanel_scan_params.Controls.Add(this.label_exposure_time, 2, 0);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_exposure_time, 3, 0);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_frame_time, 2, 1);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_frame_time, 3, 1);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_delay_exp_time, 2, 2);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_delay_exp_time, 3, 2);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_exposure_xrays_num, 2, 3);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_exposure_xrays_num, 3, 3);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_frame_per_cycle, 2, 4);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_frame_per_cycle, 3, 4);
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_series_length, 2, 5);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_series_length, 3, 5);
            
            this.tableLayoutPanel_scan_params.Controls.Add(this.label_exposure_enable, 2, 6);
            this.tableLayoutPanel_scan_params.Controls.Add(this.textBox_exposure_enable, 3, 6);

            this.tableLayoutPanel_scan_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT);
            this.tableLayoutPanel_scan_params.Name = "tableLayoutPanel_scan_params";
            this.tableLayoutPanel_scan_params.RowCount = 16;
            for (int i = 0; i < 16; i++)
            {
                this.tableLayoutPanel_scan_params.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            }
            //this.tableLayoutPanel_scan_params.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_scan_params.Size = new System.Drawing.Size((gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH) * 2, gui_params.LABELE_HEIGHT * 16);
        }
        public void ifbox_parameter_edit()
        {
            // 
            // label_scan_params
            // 
            this.label_ifbox_params.BackColor = System.Drawing.SystemColors.Info;
            this.label_ifbox_params.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ifbox_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_ifbox_params.Name = "label_ifbox_params";
            this.label_ifbox_params.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_ifbox_params.TabIndex = 3;
            this.label_ifbox_params.Text = "ifbox params";

            /* label_collimator_ctrl */
            this.label_collimator_ctrl.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_collimator_ctrl.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_collimator_ctrl.Name = "label_collimator_ctrl";
            this.label_collimator_ctrl.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_collimator_ctrl.TabIndex = 6;
            this.label_collimator_ctrl.Text = "collimator_ctrl";
            this.label_collimator_ctrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_collimator_ctrl.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_collimator_ctrl.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.textBox_collimator_ctrl.Name = "textBox_collimator_ctrl";
            this.textBox_collimator_ctrl.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_collimator_ctrl.TabIndex = 7;

            /* label_coll_spot_delay */
            this.label_coll_spot_delay.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_coll_spot_delay.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_coll_spot_delay.Name = "label_coll_spot_delay";
            this.label_coll_spot_delay.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_coll_spot_delay.TabIndex = 6;
            this.label_coll_spot_delay.Text = "coll_spot_delay";
            this.label_coll_spot_delay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_coll_spot_delay.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_coll_spot_delay.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.textBox_coll_spot_delay.Name = "textBox_coll_spot_delay";
            this.textBox_coll_spot_delay.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_coll_spot_delay.TabIndex = 7;

            /* label_ecg_start_pos */
            this.label_ecg_start_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ecg_start_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_ecg_start_pos.Name = "label_ecg_start_pos";
            this.label_ecg_start_pos.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_ecg_start_pos.TabIndex = 6;
            this.label_ecg_start_pos.Text = "ecg_start_pos";
            this.label_ecg_start_pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_ecg_start_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ecg_start_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.textBox_ecg_start_pos.Name = "textBox_ecg_start_pos";
            this.textBox_ecg_start_pos.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_ecg_start_pos.TabIndex = 7;

            /* label_ecg_stop_pos */
            this.label_ecg_stop_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ecg_stop_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_ecg_stop_pos.Name = "label_ecg_stop_pos";
            this.label_ecg_stop_pos.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_ecg_stop_pos.TabIndex = 6;
            this.label_ecg_stop_pos.Text = "ecg_stop_pos";
            this.label_ecg_stop_pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_ecg_stop_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ecg_stop_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.textBox_ecg_stop_pos.Name = "textBox_ecg_stop_pos";
            this.textBox_ecg_stop_pos.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_ecg_stop_pos.TabIndex = 7;

            this.tableLayoutPanel_ifbox_params.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_ifbox_params.ColumnCount = 2;
            this.tableLayoutPanel_ifbox_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ifbox_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ifbox_params.Controls.Add(this.label_collimator_ctrl, 0, 0);
            this.tableLayoutPanel_ifbox_params.Controls.Add(this.textBox_collimator_ctrl, 1, 0);
            this.tableLayoutPanel_ifbox_params.Controls.Add(this.label_coll_spot_delay, 0, 1);
            this.tableLayoutPanel_ifbox_params.Controls.Add(this.textBox_coll_spot_delay, 1, 1);
            this.tableLayoutPanel_ifbox_params.Controls.Add(this.label_ecg_start_pos, 0, 2);
            this.tableLayoutPanel_ifbox_params.Controls.Add(this.textBox_ecg_start_pos, 1, 2);
            this.tableLayoutPanel_ifbox_params.Controls.Add(this.label_ecg_stop_pos, 0, 3);
            this.tableLayoutPanel_ifbox_params.Controls.Add(this.textBox_ecg_stop_pos, 1, 3);

            this.tableLayoutPanel_ifbox_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.tableLayoutPanel_ifbox_params.Name = "tableLayoutPanel_ifbox_params";
            this.tableLayoutPanel_ifbox_params.RowCount = 4;
            for (int i = 0; i < 4; i++)
            {
                this.tableLayoutPanel_ifbox_params.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            }
            this.tableLayoutPanel_ifbox_params.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH, gui_params.LABELE_HEIGHT * 4);

        }
        public void gantry_parameter_edit()
        {
            /* label_gantry_params */
            this.label_gantry_params.BackColor = System.Drawing.SystemColors.Info;
            this.label_gantry_params.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_gantry_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_gantry_params.Name = "label_gantry_params";
            this.label_gantry_params.TabIndex = 3;
            this.label_gantry_params.Size = new System.Drawing.Size((gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH) / 2, gui_params.LABELE_HEIGHT);
            this.label_gantry_params.Text = "gantry params";
            this.label_gantry_position_value.BackColor = System.Drawing.SystemColors.Info;
            this.label_gantry_position_value.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_gantry_position_value.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X + (gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH) / 2, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_gantry_position_value.Name = "label_gantry_position_value";
            this.label_gantry_position_value.Size = new System.Drawing.Size((gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH) / 2, gui_params.LABELE_HEIGHT);
            this.label_gantry_position_value.Text = "--.-- deg";
            this.label_gantry_position_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            /* label_start_angle */
            this.label_start_angle.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_start_angle.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_start_angle.Name = "label_start_angle";
            this.label_start_angle.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_start_angle.TabIndex = 6;
            this.label_start_angle.Text = "start_angle";
            this.label_start_angle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_start_angle.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_start_angle.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X + gui_params.LABELE_WIDTH, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_start_angle.Name = "textBox_start_angle";
            this.textBox_start_angle.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_start_angle.TabIndex = 7;

            /* label_stop_angle */
            this.label_stop_angle.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_stop_angle.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X + gui_params.LABELE_WIDTH, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_stop_angle.Name = "label_stop_angle";
            this.label_stop_angle.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_stop_angle.TabIndex = 6;
            this.label_stop_angle.Text = "stop_angle";
            this.label_stop_angle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_stop_angle.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_stop_angle.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X + gui_params.LABELE_WIDTH, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_stop_angle.Name = "textBox_stop_angle";
            this.textBox_stop_angle.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_stop_angle.TabIndex = 7;

            /* label_gantry_acc */
            this.label_gantry_acc.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_gantry_acc.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X + gui_params.LABELE_WIDTH, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_gantry_acc.Name = "label_gantry_acc";
            this.label_gantry_acc.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_gantry_acc.TabIndex = 6;
            this.label_gantry_acc.Text = "gantry_acc";
            this.label_gantry_acc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_gantry_acc.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_gantry_acc.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X + gui_params.LABELE_WIDTH, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_gantry_acc.Name = "textBox_gantry_acc";
            this.textBox_gantry_acc.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_gantry_acc.TabIndex = 7;

            /* label_gantry_dec */
            this.label_gantry_dec.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_gantry_dec.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X + gui_params.LABELE_WIDTH, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_gantry_dec.Name = "label_gantry_dec";
            this.label_gantry_dec.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_gantry_dec.TabIndex = 6;
            this.label_gantry_dec.Text = "gantry_dec";
            this.label_gantry_dec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_gantry_dec.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_gantry_dec.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X + gui_params.LABELE_WIDTH, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_gantry_dec.Name = "textBox_gantry_dec";
            this.textBox_gantry_dec.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_gantry_dec.TabIndex = 7;

            /* label_gantry_speed */
            this.label_gantry_speed.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_gantry_speed.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X + gui_params.LABELE_WIDTH, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_gantry_speed.Name = "label_gantry_speed";
            this.label_gantry_speed.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_gantry_speed.TabIndex = 6;
            this.label_gantry_speed.Text = "gantry_speed";
            this.label_gantry_speed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_gantry_speed.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_gantry_speed.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X + gui_params.LABELE_WIDTH, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_gantry_speed.Name = "textBox_gantry_speed";
            this.textBox_gantry_speed.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_gantry_speed.TabIndex = 7;



            this.tableLayoutPanel_gantry_params.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_gantry_params.ColumnCount = 2;
            this.tableLayoutPanel_gantry_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_gantry_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_gantry_params.Controls.Add(this.label_start_angle, 0, 0);
            this.tableLayoutPanel_gantry_params.Controls.Add(this.textBox_start_angle, 1, 0);
            this.tableLayoutPanel_gantry_params.Controls.Add(this.label_stop_angle, 0, 1);
            this.tableLayoutPanel_gantry_params.Controls.Add(this.textBox_stop_angle, 1, 1);
            this.tableLayoutPanel_gantry_params.Controls.Add(this.label_gantry_acc, 0, 2);
            this.tableLayoutPanel_gantry_params.Controls.Add(this.textBox_gantry_acc, 1, 2);
            this.tableLayoutPanel_gantry_params.Controls.Add(this.label_gantry_dec, 0, 3);
            this.tableLayoutPanel_gantry_params.Controls.Add(this.textBox_gantry_dec, 1, 3);
            this.tableLayoutPanel_gantry_params.Controls.Add(this.label_gantry_speed, 0, 4);
            this.tableLayoutPanel_gantry_params.Controls.Add(this.textBox_gantry_speed, 1, 4);

            this.tableLayoutPanel_gantry_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.tableLayoutPanel_gantry_params.Name = "tableLayoutPanel_gantry_params";
            this.tableLayoutPanel_gantry_params.RowCount = 5;
            for (int i = 0; i < 5; i++)
            {
                this.tableLayoutPanel_gantry_params.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            }
            this.tableLayoutPanel_gantry_params.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH, gui_params.LABELE_HEIGHT * 5);
        }
        public void coach_parameter_edit()
        {
            /* label_coach_params */
            this.label_coach_params.BackColor = System.Drawing.SystemColors.Info;
            this.label_coach_params.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_coach_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_coach_params.Name = "label_coach_params";
            this.label_coach_params.Size = new System.Drawing.Size((gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH) / 2, gui_params.LABELE_HEIGHT);
            this.label_coach_params.Text = "coach params";
            this.label_coach_position_value.BackColor = System.Drawing.SystemColors.Info;
            this.label_coach_position_value.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_coach_position_value.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X + (gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH) / 2, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_coach_position_value.Name = "label_coach_position_value";
            this.label_coach_position_value.Size = new System.Drawing.Size((gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH) / 2, gui_params.LABELE_HEIGHT);
            this.label_coach_position_value.Text = "--.-- mm";
            this.label_coach_position_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            /* label_coach_start_pos */
            this.label_coach_start_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_coach_start_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_coach_start_pos.Name = "label_coach_start_pos";
            this.label_coach_start_pos.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_coach_start_pos.Text = "coach_start_pos";
            this.label_coach_start_pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_coach_start_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_coach_start_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_coach_start_pos.Name = "textBox_coach_start_pos";
            this.textBox_coach_start_pos.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_coach_stop_pos */
            this.label_coach_stop_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_coach_stop_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_coach_stop_pos.Name = "label_coach_stop_pos";
            this.label_coach_stop_pos.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_coach_stop_pos.Text = "coach_stop_pos";
            this.label_coach_stop_pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_coach_stop_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_coach_stop_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_coach_stop_pos.Name = "textBox_coach_stop_pos";
            this.textBox_coach_stop_pos.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_coach_exposure_start_pos */
            this.label_coach_exposure_start_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_coach_exposure_start_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_coach_exposure_start_pos.Name = "label_coach_exposure_start_pos";
            this.label_coach_exposure_start_pos.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_coach_exposure_start_pos.Text = "exposure_start_pos";
            this.label_coach_exposure_start_pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_coach_exposure_start_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_coach_exposure_start_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_coach_exposure_start_pos.Name = "textBox_coach_exposure_start_pos";
            this.textBox_coach_exposure_start_pos.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_coach_exposure_stop_pos */
            this.label_coach_exposure_stop_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_coach_exposure_stop_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_coach_exposure_stop_pos.Name = "label_coach_exposure_stop_pos";
            this.label_coach_exposure_stop_pos.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_coach_exposure_stop_pos.Text = "coach_exposure_stop_pos";
            this.label_coach_exposure_stop_pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_coach_exposure_stop_pos.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_coach_exposure_stop_pos.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_coach_exposure_stop_pos.Name = "textBox_coach_exposure_stop_pos";
            this.textBox_coach_exposure_stop_pos.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_coach_acc */
            this.label_coach_acc.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_coach_acc.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_coach_acc.Name = "label_coach_acc";
            this.label_coach_acc.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_coach_acc.Text = "coach_acc";
            this.label_coach_acc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_coach_acc.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_coach_acc.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_coach_acc.Name = "textBox_coach_acc";
            this.textBox_coach_acc.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_coach_speed */
            this.label_coach_speed.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_coach_speed.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_coach_speed.Name = "label_coach_speed";
            this.label_coach_speed.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_coach_speed.Text = "coach_speed";
            this.label_coach_speed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_coach_speed.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_coach_speed.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_coach_speed.Name = "textBox_coach_speed";
            this.textBox_coach_speed.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_coach_feed */
            this.label_coach_feed.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_coach_feed.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_coach_feed.Name = "label_coach_feed";
            this.label_coach_feed.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_coach_feed.Text = "coach_feed";
            this.label_coach_feed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_coach_feed.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_coach_feed.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_coach_feed.Name = "textBox_coach_feed";
            this.textBox_coach_feed.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);


            this.tableLayoutPanel_coach_params.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_coach_params.ColumnCount = 2;
            this.tableLayoutPanel_coach_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_coach_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_coach_params.Controls.Add(this.label_coach_start_pos, 0, 0);
            this.tableLayoutPanel_coach_params.Controls.Add(this.textBox_coach_start_pos, 1, 0);
            this.tableLayoutPanel_coach_params.Controls.Add(this.label_coach_stop_pos, 0, 1);
            this.tableLayoutPanel_coach_params.Controls.Add(this.textBox_coach_stop_pos, 1, 1);
            this.tableLayoutPanel_coach_params.Controls.Add(this.label_coach_exposure_start_pos, 0, 2);
            this.tableLayoutPanel_coach_params.Controls.Add(this.textBox_coach_exposure_start_pos, 1, 2);
            this.tableLayoutPanel_coach_params.Controls.Add(this.label_coach_exposure_stop_pos, 0, 3);
            this.tableLayoutPanel_coach_params.Controls.Add(this.textBox_coach_exposure_stop_pos, 1, 3);
            this.tableLayoutPanel_coach_params.Controls.Add(this.label_coach_acc, 0, 4);
            this.tableLayoutPanel_coach_params.Controls.Add(this.textBox_coach_acc, 1, 4);
            this.tableLayoutPanel_coach_params.Controls.Add(this.label_coach_speed, 0, 5);
            this.tableLayoutPanel_coach_params.Controls.Add(this.textBox_coach_speed, 1, 5);
            this.tableLayoutPanel_coach_params.Controls.Add(this.label_coach_feed, 0, 6);
            this.tableLayoutPanel_coach_params.Controls.Add(this.textBox_coach_feed, 1, 6);

            this.tableLayoutPanel_coach_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.tableLayoutPanel_coach_params.Name = "tableLayoutPanel_coach_params";
            this.tableLayoutPanel_coach_params.RowCount = 7;
            for (int i = 0; i < 7; i++)
            {
                this.tableLayoutPanel_coach_params.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            }
            this.tableLayoutPanel_coach_params.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH, gui_params.LABELE_HEIGHT * 7);
        }
        public void xray_parameter_edit()
        {
            /* label_xray_params */
            this.label_xray_params.BackColor = System.Drawing.SystemColors.Info;
            this.label_xray_params.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_xray_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.label_xray_params.Name = "label_xray_params";
            this.label_xray_params.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_xray_params.Text = "xray params";

            /* label_kv */
            this.label_kv.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_kv.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_kv.Name = "label_kv";
            this.label_kv.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_kv.TabIndex = 6;
            this.label_kv.Text = "KV";
            this.label_kv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_kv.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_kv.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_kv.Name = "textBox_kv";
            this.textBox_kv.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_kv.TabIndex = 7;

            /* label_ma */
            this.label_ma.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ma.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_ma.Name = "label_ma";
            this.label_ma.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_ma.Text = "mA";
            this.label_ma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_ma.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ma.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_ma.Name = "textBox_ma";
            this.textBox_ma.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_xray_focus */
            this.label_xray_focus.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_xray_focus.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_xray_focus.Name = "label_xray_focus";
            this.label_xray_focus.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_xray_focus.Text = "xray_focus";
            this.label_xray_focus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.comboBox_xray_focus.FormattingEnabled = true;
            this.comboBox_xray_focus.Items.AddRange(new object[] {
            "0Small",
            "1Big"});
            this.comboBox_xray_focus.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.comboBox_xray_focus.Name = "comboBox_xray_focus";
            this.comboBox_xray_focus.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.comboBox_xray_focus.TabIndex = 7;

            /* label_xray_spot_delay_time */
            this.label_xray_spot_delay_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_xray_spot_delay_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_xray_spot_delay_time.Name = "label_xray_spot_delay_time";
            this.label_xray_spot_delay_time.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_xray_spot_delay_time.Text = "xray_spot_delay_time";
            this.label_xray_spot_delay_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_xray_spot_delay_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_xray_spot_delay_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_xray_spot_delay_time.Name = "textBox_xray_spot_delay_time";
            this.textBox_xray_spot_delay_time.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_xray_error_limit */
            this.label_xray_error_limit.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_xray_error_limit.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_xray_error_limit.Name = "label_xray_error_limit";
            this.label_xray_error_limit.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_xray_error_limit.Text = "xray_error_limit";
            this.label_xray_error_limit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_xray_error_limit.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_xray_error_limit.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_xray_error_limit.Name = "textBox_xray_error_limit";
            this.textBox_xray_error_limit.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);


            this.tableLayoutPanel_xray_params.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_xray_params.ColumnCount = 2;
            this.tableLayoutPanel_xray_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_xray_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_xray_params.Controls.Add(this.label_kv, 0, 0);
            this.tableLayoutPanel_xray_params.Controls.Add(this.textBox_kv, 1, 0);
            this.tableLayoutPanel_xray_params.Controls.Add(this.label_ma, 0, 1);
            this.tableLayoutPanel_xray_params.Controls.Add(this.textBox_ma, 1, 1);
            this.tableLayoutPanel_xray_params.Controls.Add(this.label_xray_focus, 0, 2);
            this.tableLayoutPanel_xray_params.Controls.Add(this.comboBox_xray_focus, 1, 2);
            this.tableLayoutPanel_xray_params.Controls.Add(this.label_xray_spot_delay_time, 0, 3);
            this.tableLayoutPanel_xray_params.Controls.Add(this.textBox_xray_spot_delay_time, 1, 3);
            this.tableLayoutPanel_xray_params.Controls.Add(this.label_xray_error_limit, 0, 4);
            this.tableLayoutPanel_xray_params.Controls.Add(this.textBox_xray_error_limit, 1, 4);

            this.tableLayoutPanel_xray_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.tableLayoutPanel_xray_params.Name = "tableLayoutPanel_xray_params";
            this.tableLayoutPanel_xray_params.RowCount = 5;
            for (int i = 0; i < 5; i++)
            {
                this.tableLayoutPanel_xray_params.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            }
            this.tableLayoutPanel_xray_params.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH, gui_params.LABELE_HEIGHT * 5);
        }
        public void auxboard_parameter_edit()
        {
            /* label_auxboard_params */
            this.label_auxboard_params.BackColor = System.Drawing.SystemColors.Info;
            this.label_auxboard_params.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_auxboard_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_auxboard_params.Name = "label_auxboard_params";
            this.label_auxboard_params.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_auxboard_params.Text = "auxboard params";

            /* label_voice_id */
            this.label_voice_id.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_voice_id.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_voice_id.Name = "label_voice_id";
            this.label_voice_id.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_voice_id.Text = "voice_id";
            this.label_voice_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_voice_id.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_voice_id.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_voice_id.Name = "textBox_voice_id";
            this.textBox_voice_id.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_voicd_play_time */
            this.label_voice_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_voice_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_voice_time.Name = "label_voice_time";
            this.label_voice_time.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_voice_time.Text = "voice_time";
            this.label_voice_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_voice_time.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_voice_time.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_voice_time.Name = "textBox_voice_time";
            this.textBox_voice_time.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);


            this.tableLayoutPanel_auxboard_params.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_auxboard_params.ColumnCount = 2;
            this.tableLayoutPanel_auxboard_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_auxboard_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_auxboard_params.Controls.Add(this.label_voice_id, 0, 0);
            this.tableLayoutPanel_auxboard_params.Controls.Add(this.textBox_voice_id, 1, 0);
            this.tableLayoutPanel_auxboard_params.Controls.Add(this.label_voice_time, 0, 1);
            this.tableLayoutPanel_auxboard_params.Controls.Add(this.textBox_voice_time, 1, 1);
                                   
            this.tableLayoutPanel_auxboard_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_3_POS_X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT);
            this.tableLayoutPanel_auxboard_params.Name = "tableLayoutPanel_xray_params";
            this.tableLayoutPanel_auxboard_params.RowCount = 2;
            for (int i = 0; i < 2; i++)
            {
                this.tableLayoutPanel_auxboard_params.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
            this.tableLayoutPanel_auxboard_params.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH, gui_params.LABELE_HEIGHT * 2);

        }
        public void detector_parameter_edit()
        {
            /* label_detector_params */
            this.label_detector_params.BackColor = System.Drawing.SystemColors.Info;
            this.label_detector_params.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_detector_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_1_POS_Y);
            this.label_detector_params.Name = "label_detector_params";
            this.label_detector_params.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_detector_params.Text = "detector params";

            /* label_det_gain */
            this.label_det_gain.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_det_gain.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_det_gain.Name = "label_det_gain";
            this.label_det_gain.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_det_gain.Text = "det_gain";
            this.label_det_gain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_det_gain.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_det_gain.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_det_gain.Name = "textBox_det_gain";
            this.textBox_det_gain.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_det_binning */
            this.label_det_binning.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_det_binning.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_det_binning.Name = "label_det_binning";
            this.label_det_binning.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_det_binning.Text = "det_binning";
            this.label_det_binning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_det_binning.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_det_binning.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_det_binning.Name = "textBox_det_binning";
            this.textBox_det_binning.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_det_shutter */
            this.label_det_shutter.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_det_shutter.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_det_shutter.Name = "label_det_shutter";
            this.label_det_shutter.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_det_shutter.Text = "det_shutter";
            this.label_det_shutter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_det_shutter.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_det_shutter.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_det_shutter.Name = "textBox_det_shutter";
            this.textBox_det_shutter.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);


            /* label_det_acq_mode */
            this.label_det_acq_mode.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_det_acq_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_det_acq_mode.Name = "label_det_acq_mode";
            this.label_det_acq_mode.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_det_acq_mode.Text = "det_acq_mode";
            this.label_det_acq_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_det_acq_mode.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_det_acq_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_det_acq_mode.Name = "textBox_det_acq_mode";
            this.textBox_det_acq_mode.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_det_encode_mode */
            this.label_det_encode_mode.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_det_encode_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_det_encode_mode.Name = "label_det_encode_mode";
            this.label_det_encode_mode.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_det_encode_mode.Text = "det_encode_mode";
            this.label_det_encode_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_det_encode_mode.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_det_encode_mode.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_det_encode_mode.Name = "textBox_det_encode_mode";
            this.textBox_det_encode_mode.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_det_nvsync_delay */
            this.label_det_nvsync_delay.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_det_nvsync_delay.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_det_nvsync_delay.Name = "label_det_nvsync_delay";
            this.label_det_nvsync_delay.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_det_nvsync_delay.Text = "det_nvsync_delay";
            this.label_det_nvsync_delay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_det_nvsync_delay.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_det_nvsync_delay.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_det_nvsync_delay.Name = "textBox_det_nvsync_delay";
            this.textBox_det_nvsync_delay.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_det_preoffset_enable */
            this.label_det_preoffset_enable.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_det_preoffset_enable.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_det_preoffset_enable.Name = "label_det_preoffset_enable";
            this.label_det_preoffset_enable.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_det_preoffset_enable.Text = "det_preoffset_enable";
            this.label_det_preoffset_enable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_det_preoffset_enable.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_det_preoffset_enable.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_det_preoffset_enable.Name = "textBox_det_preoffset_enable";
            this.textBox_det_preoffset_enable.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            /* label_det_preoffset_num */
            this.label_det_preoffset_num.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_det_preoffset_num.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y);
            this.label_det_preoffset_num.Name = "label_det_preoffset_num";
            this.label_det_preoffset_num.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_det_preoffset_num.Text = "det_preoffset_num";
            this.label_det_preoffset_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.textBox_det_preoffset_num.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_det_preoffset_num.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT);
            this.textBox_det_preoffset_num.Name = "textBox_det_preoffset_num";
            this.textBox_det_preoffset_num.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);


            this.tableLayoutPanel_detector_params.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_detector_params.ColumnCount = 2;
            this.tableLayoutPanel_detector_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_detector_params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_detector_params.Controls.Add(this.label_det_gain, 0, 0);
            this.tableLayoutPanel_detector_params.Controls.Add(this.textBox_det_gain, 1, 0);
            this.tableLayoutPanel_detector_params.Controls.Add(this.label_det_binning, 0, 1);
            this.tableLayoutPanel_detector_params.Controls.Add(this.textBox_det_binning, 1, 1);
            this.tableLayoutPanel_detector_params.Controls.Add(this.label_det_shutter, 0, 2);
            this.tableLayoutPanel_detector_params.Controls.Add(this.textBox_det_shutter, 1, 2);
            this.tableLayoutPanel_detector_params.Controls.Add(this.label_det_acq_mode, 0, 3);
            this.tableLayoutPanel_detector_params.Controls.Add(this.textBox_det_acq_mode, 1, 3);
            this.tableLayoutPanel_detector_params.Controls.Add(this.label_det_encode_mode, 0, 4);
            this.tableLayoutPanel_detector_params.Controls.Add(this.textBox_det_encode_mode, 1, 4);
            this.tableLayoutPanel_detector_params.Controls.Add(this.label_det_nvsync_delay, 0, 5);
            this.tableLayoutPanel_detector_params.Controls.Add(this.textBox_det_nvsync_delay, 1, 5);
            this.tableLayoutPanel_detector_params.Controls.Add(this.label_det_preoffset_enable, 0, 6);
            this.tableLayoutPanel_detector_params.Controls.Add(this.textBox_det_preoffset_enable, 1, 6);
            this.tableLayoutPanel_detector_params.Controls.Add(this.label_det_preoffset_num, 0, 7);
            this.tableLayoutPanel_detector_params.Controls.Add(this.textBox_det_preoffset_num, 1, 7);

            this.tableLayoutPanel_detector_params.Location = new System.Drawing.Point(gui_params.GUI_COLUM_4_POS_X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT);
            this.tableLayoutPanel_detector_params.Name = "tableLayoutPanel_detector_params";
            this.tableLayoutPanel_detector_params.RowCount = 8;
            for (int i = 0; i < 8; i++)
            {
                this.tableLayoutPanel_detector_params.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            }
            this.tableLayoutPanel_detector_params.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH, gui_params.LABELE_HEIGHT * 8);
        }

        public void scan_control_area_edit()
        {
            // 
            // label_reg_addr
            // 
            this.label_reg_addr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_reg_addr.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y);
            this.label_reg_addr.Name = "label_reg_addr";
            this.label_reg_addr.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_reg_addr.Text = "reg_addr(Hex)";
            this.label_reg_addr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_reg_addr
            // 
            this.textBox_reg_addr.Font = new System.Drawing.Font("宋体", 8F);
            this.textBox_reg_addr.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y ); 
            this.textBox_reg_addr.Name = "textBox_reg_addr";
            this.textBox_reg_addr.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            // 
            // label_reg_data
            // 
            this.label_reg_data.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y );
            this.label_reg_data.Name = "label_reg_data";
            this.label_reg_data.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_reg_data.TabIndex = 2;
            this.label_reg_data.Text = "reg_data(Dec)";
            this.label_reg_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_reg_data
            // 
            this.textBox_reg_data.Font = new System.Drawing.Font("宋体", 8F);
            this.textBox_reg_data.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y );
            this.textBox_reg_data.Name = "textBox_reg_data";
            this.textBox_reg_data.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_reg_data.TabIndex = 3;

            // 
            // button_reg_send
            // 
            this.button_reg_send.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_CTRL_AREA_POS_Y);
            this.button_reg_send.Name = "button_reg_send";
            this.button_reg_send.Size = new System.Drawing.Size(gui_params.GUI_BUTTON_SIZE_WIDTH, gui_params.LABELE_HEIGHT * 2);
            this.button_reg_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_reg_send.Margin = new System.Windows.Forms.Padding(3);
            this.button_reg_send.Text = "Send";
            this.button_reg_send.UseVisualStyleBackColor = true;
            this.button_reg_send.Click += new System.EventHandler(this.button_reg_send_Click);


            // 
            // label_read_reg_addr
            // 
            this.label_read_reg_addr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_read_reg_addr.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y);
            this.label_read_reg_addr.Name = "label_reg_addr";
            this.label_read_reg_addr.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_read_reg_addr.Text = "read_reg_addr(Hex)";
            this.label_read_reg_addr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_read_reg_addr for read
            // 
            this.textBox_read_reg_addr.Font = new System.Drawing.Font("宋体", 8F);
            this.textBox_read_reg_addr.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y);
            this.textBox_read_reg_addr.Name = "textBox_read_reg_addr";
            this.textBox_read_reg_addr.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);

            // 
            // label_read_reg_data
            // 
            this.label_read_reg_data.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y);
            this.label_read_reg_data.Name = "label_read_reg_data";
            this.label_read_reg_data.Size = new System.Drawing.Size(gui_params.LABELE_WIDTH, gui_params.LABELE_HEIGHT);
            this.label_read_reg_data.TabIndex = 2;
            this.label_read_reg_data.Text = "reg_data(Hex / Dec)";
            this.label_read_reg_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_read_reg_data
            // 
            this.textBox_read_reg_data.Font = new System.Drawing.Font("宋体", 8F);
            this.textBox_read_reg_data.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y);
            this.textBox_read_reg_data.Name = "textBox_read_reg_data";
            this.textBox_read_reg_data.ReadOnly = true;
            this.textBox_read_reg_data.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_read_reg_data.Size = new System.Drawing.Size(gui_params.TEXTBOX_WIDTH, gui_params.TEXTBOX_HEIGHT);
            this.textBox_read_reg_data.TabIndex = 3;

            // 
            // button_read_reg_read
            // 
            this.button_reg_read.Location = new System.Drawing.Point(gui_params.GUI_COLUM_2_POS_X, gui_params.GUI_CTRL_AREA_POS_Y);
            this.button_reg_read.Name = "button_reg_read";
            this.button_reg_read.Size = new System.Drawing.Size(gui_params.GUI_BUTTON_SIZE_WIDTH, gui_params.LABELE_HEIGHT * 2);
            this.button_reg_read.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_reg_read.Margin = new System.Windows.Forms.Padding(3);
            this.button_reg_read.Text = "Read";
            this.button_reg_read.UseVisualStyleBackColor = true;
            this.button_reg_read.Click += new System.EventHandler(this.button_reg_read_Click);


            // 
            // tableLayoutPanel_reg_ctrl
            // 
            this.tableLayoutPanel_reg_ctrl.ColumnCount = 4;
            this.tableLayoutPanel_reg_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_reg_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_reg_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_reg_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_reg_ctrl.Controls.Add(this.label_reg_addr, 0, 0);
            this.tableLayoutPanel_reg_ctrl.Controls.Add(this.textBox_reg_addr, 1, 0);
            this.tableLayoutPanel_reg_ctrl.Controls.Add(this.label_reg_data, 0, 1);
            this.tableLayoutPanel_reg_ctrl.Controls.Add(this.textBox_reg_data, 1, 1);
            //this.tableLayoutPanel_reg_ctrl.Controls.Add(this.button_reg_send, 2, 0);
            this.tableLayoutPanel_reg_ctrl.Controls.Add(this.label_read_reg_addr, 2, 0);
            this.tableLayoutPanel_reg_ctrl.Controls.Add(this.textBox_read_reg_addr, 3, 0);
            this.tableLayoutPanel_reg_ctrl.Controls.Add(this.label_read_reg_data, 2, 1);
            this.tableLayoutPanel_reg_ctrl.Controls.Add(this.textBox_read_reg_data, 3, 1);
            this.tableLayoutPanel_reg_ctrl.Controls.Add(this.button_reg_send, 0, 2);
            this.tableLayoutPanel_reg_ctrl.SetColumnSpan(this.button_reg_send, 2);
            this.tableLayoutPanel_reg_ctrl.Controls.Add(this.button_reg_read, 2, 2);
            this.tableLayoutPanel_reg_ctrl.SetColumnSpan(this.button_reg_read, 2);
            this.tableLayoutPanel_reg_ctrl.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y);
            this.tableLayoutPanel_reg_ctrl.Name = "tableLayoutPanel_reg_ctrl";
            this.tableLayoutPanel_reg_ctrl.RowCount = 3;
            this.tableLayoutPanel_reg_ctrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, gui_params.LABELE_HEIGHT));
            this.tableLayoutPanel_reg_ctrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, gui_params.LABELE_HEIGHT + 3));
            this.tableLayoutPanel_reg_ctrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, gui_params.GUI_BUTTON_SIZE_HEIGHT));
            this.tableLayoutPanel_reg_ctrl.Size = new System.Drawing.Size((gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH) * 2, gui_params.LABELE_HEIGHT * 2 + 3 + gui_params.GUI_BUTTON_SIZE_HEIGHT);


            // 
            // label_line
            // 
            this.label_line.Location = new System.Drawing.Point(0, gui_params.GUI_CTRL_AREA_POS_Y + gui_params.LABELE_HEIGHT * 2 + gui_params.GUI_LINE_HEIGHT);
            this.label_line.Name = "label_line";
            this.label_line.Size = new System.Drawing.Size(gui_params.GUI_MAX_WIDTH, gui_params.GUI_LINE_HEIGHT);
            this.label_line.BackColor = System.Drawing.SystemColors.ControlDark;

            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(3, 3);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(gui_params.GUI_BUTTON_SIZE_WIDTH, gui_params.GUI_BUTTON_SIZE_HEIGHT);
            this.button_confirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_confirm.Text = "confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_start_scan
            // 
            this.button_start_scan.Location = new System.Drawing.Point(76, 3);
            this.button_start_scan.Name = "button_start_scan";
            this.button_start_scan.Size = new System.Drawing.Size(gui_params.GUI_BUTTON_SIZE_WIDTH, gui_params.GUI_BUTTON_SIZE_HEIGHT);
            this.button_start_scan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_start_scan.Text = "start";
            this.button_start_scan.UseVisualStyleBackColor = true;
            this.button_start_scan.Click += new System.EventHandler(this.button_start_scan_Click);

            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(149, 3);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(gui_params.GUI_BUTTON_SIZE_WIDTH, gui_params.GUI_BUTTON_SIZE_HEIGHT);
            this.button_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_cancel.Text = "cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);

            // 
            // button_all_ready
            // 
            this.button_all_ready.Location = new System.Drawing.Point(250, 420);
            this.button_all_ready.Name = "button_all_ready";
            this.button_all_ready.Size = new System.Drawing.Size(gui_params.GUI_BUTTON_SIZE_WIDTH, gui_params.GUI_BUTTON_SIZE_HEIGHT);
            this.button_all_ready.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_all_ready.Text = "all_ready";
            this.button_all_ready.UseVisualStyleBackColor = true;
            this.button_all_ready.Click += new System.EventHandler(this.button_all_ready_Click);

            //
            // button_load_param
            //
            this.button_load_param.Name = "button_load_param";
            this.button_load_param.Size = new System.Drawing.Size(gui_params.GUI_BUTTON_SIZE_WIDTH, gui_params.GUI_BUTTON_SIZE_HEIGHT);
            this.button_load_param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_load_param.Text = "load_param";
            this.button_load_param.UseVisualStyleBackColor = true;
            this.button_load_param.Click += new System.EventHandler(this.button_load_param_Click);

            //
            // button_save_param
            //
            this.button_save_param.Name = "button_save_param";
            this.button_save_param.Size = new System.Drawing.Size(gui_params.GUI_BUTTON_SIZE_WIDTH, gui_params.GUI_BUTTON_SIZE_HEIGHT);
            this.button_save_param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_save_param.Text = "save_param";
            this.button_save_param.UseVisualStyleBackColor = true;
            this.button_save_param.Click += new System.EventHandler(this.button_save_param_Click);

            // 
            // tableLayoutPanel_scan_ctrl
            // 
            this.tableLayoutPanel_scan_ctrl.ColumnCount = 6;
            this.tableLayoutPanel_scan_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_scan_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_scan_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_scan_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_scan_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_scan_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_scan_ctrl.Controls.Add(this.button_confirm, 0, 0);
            this.tableLayoutPanel_scan_ctrl.Controls.Add(this.button_start_scan, 1, 0);
            this.tableLayoutPanel_scan_ctrl.Controls.Add(this.button_cancel, 2, 0);
            this.tableLayoutPanel_scan_ctrl.Controls.Add(this.button_all_ready, 3, 0);
            this.tableLayoutPanel_scan_ctrl.Controls.Add(this.button_load_param, 4, 0);
            this.tableLayoutPanel_scan_ctrl.Controls.Add(this.button_save_param, 5, 0);
            this.tableLayoutPanel_scan_ctrl.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y + gui_params.LABELE_HEIGHT * 2 + gui_params.GUI_LINE_HEIGHT * 2);
            this.tableLayoutPanel_scan_ctrl.Name = "tableLayoutPanel_scan_ctrl";
            this.tableLayoutPanel_scan_ctrl.RowCount = 1;
            this.tableLayoutPanel_scan_ctrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_scan_ctrl.Size = new System.Drawing.Size(gui_params.GUI_BUTTON_SIZE_WIDTH * 6, gui_params.GUI_BUTTON_SIZE_HEIGHT);


            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(gui_params.GUI_COLUM_1_POS_X, gui_params.GUI_CTRL_AREA_POS_Y + gui_params.LABELE_HEIGHT * 2 + gui_params.GUI_LINE_HEIGHT * 2 + gui_params.GUI_BUTTON_SIZE_HEIGHT); 
            this.textBox_log.MaxLength = 65535;
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_log.Size = new System.Drawing.Size(gui_params.GUI_MAX_WIDTH - gui_params.GUI_BUTTON_SIZE_WIDTH * 2, 
                   gui_params.GUI_MAX_HEIGHT - (gui_params.GUI_CTRL_AREA_POS_Y + gui_params.LABELE_HEIGHT * 2 + gui_params.GUI_LINE_HEIGHT * 3 + gui_params.GUI_BUTTON_SIZE_HEIGHT));
            

            // 
            // button_clear_log
            // 
            this.button_clear_log.Location = new System.Drawing.Point(gui_params.GUI_MAX_WIDTH - gui_params.GUI_BUTTON_SIZE_WIDTH, gui_params.GUI_MAX_HEIGHT - gui_params.GUI_BUTTON_SIZE_HEIGHT * 2);
            this.button_clear_log.Name = "button_clear_log";
            this.button_clear_log.Size = new System.Drawing.Size(gui_params.GUI_BUTTON_SIZE_WIDTH, gui_params.GUI_BUTTON_SIZE_HEIGHT * 2);
            this.button_clear_log.Text = "clear";
            this.button_clear_log.UseVisualStyleBackColor = true;
            this.button_clear_log.Click += new System.EventHandler(this.button_clear_log_Click);
           
        }

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            form_parameter_definition();
            scan_parameter_definition();
            scan_parameter_edit();
            ifbox_parameter_edit();
            gantry_parameter_edit();
            coach_parameter_edit();
            xray_parameter_edit();
            auxboard_parameter_edit();
            detector_parameter_edit();
            scan_control_area_edit();

            this.tableLayoutPanel_scan_params.SuspendLayout();
            this.tableLayoutPanel_exposure_params.SuspendLayout();
            this.tableLayoutPanel_ifbox_params.SuspendLayout();
            this.tableLayoutPanel_gantry_params.SuspendLayout();
            this.tableLayoutPanel_coach_params.SuspendLayout();
            this.tableLayoutPanel_xray_params.SuspendLayout();
            this.tableLayoutPanel_auxboard_params.SuspendLayout();
            this.tableLayoutPanel_reg_ctrl.SuspendLayout();
            this.tableLayoutPanel_scan_ctrl.SuspendLayout();
            this.SuspendLayout();
            

            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(gui_params.GUI_MAX_WIDTH, gui_params.GUI_MAX_HEIGHT);


            this.Controls.Add(this.label_scan_params);
            this.Controls.Add(this.label_exposure_params);
            this.Controls.Add(this.label_ifbox_params);
            this.Controls.Add(this.label_gantry_params);
            this.Controls.Add(this.label_coach_params);
            this.Controls.Add(this.label_gantry_position_value);
            this.Controls.Add(this.label_coach_position_value);
            this.Controls.Add(this.label_xray_params);
            this.Controls.Add(this.label_auxboard_params);
            this.Controls.Add(this.label_detector_params);

            this.Controls.Add(this.tableLayoutPanel_scan_params);
            this.Controls.Add(this.tableLayoutPanel_exposure_params);
            this.Controls.Add(this.tableLayoutPanel_ifbox_params);
            this.Controls.Add(this.tableLayoutPanel_gantry_params);
            this.Controls.Add(this.tableLayoutPanel_coach_params);
            this.Controls.Add(this.tableLayoutPanel_xray_params);
            this.Controls.Add(this.tableLayoutPanel_auxboard_params);
            this.Controls.Add(this.tableLayoutPanel_detector_params);


            this.Controls.Add(this.tableLayoutPanel_reg_ctrl);
            //this.Controls.Add(this.button_reg_send);

            this.Controls.Add(this.label_line);

            this.Controls.Add(this.tableLayoutPanel_scan_ctrl);

            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.button_clear_log);


            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.AutoScroll = true;
            this.Name = "mainForm";
            this.Text = "gvcpTool for ctbox";
            this.tableLayoutPanel_scan_params.ResumeLayout(false);
            this.tableLayoutPanel_scan_params.PerformLayout();
            this.tableLayoutPanel_exposure_params.ResumeLayout(false);
            this.tableLayoutPanel_exposure_params.PerformLayout();

            this.tableLayoutPanel_ifbox_params.ResumeLayout(false);
            this.tableLayoutPanel_ifbox_params.PerformLayout();
            this.tableLayoutPanel_gantry_params.ResumeLayout(false);
            this.tableLayoutPanel_gantry_params.PerformLayout();
            this.tableLayoutPanel_coach_params.ResumeLayout(false);
            this.tableLayoutPanel_coach_params.PerformLayout();
            this.tableLayoutPanel_xray_params.ResumeLayout(false);
            this.tableLayoutPanel_xray_params.PerformLayout();
            this.tableLayoutPanel_auxboard_params.ResumeLayout(false);
            this.tableLayoutPanel_auxboard_params.PerformLayout();
            this.tableLayoutPanel_detector_params.ResumeLayout(false);
            this.tableLayoutPanel_detector_params.PerformLayout();

            this.tableLayoutPanel_reg_ctrl.ResumeLayout(false);
            this.tableLayoutPanel_reg_ctrl.PerformLayout();
            this.tableLayoutPanel_scan_ctrl.ResumeLayout(false);
            this.tableLayoutPanel_scan_ctrl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        /* exposure params */
        private System.Windows.Forms.Label label_scan_params;
        private System.Windows.Forms.Label label_exposure_params;
        private System.Windows.Forms.Label label_ifbox_params;
        private System.Windows.Forms.Label label_gantry_params;
        private System.Windows.Forms.Label label_coach_params;
        private System.Windows.Forms.Label label_gantry_position_value;
        private System.Windows.Forms.Label label_coach_position_value;
        private System.Windows.Forms.Label label_xray_params;
        private System.Windows.Forms.Label label_auxboard_params;
        private System.Windows.Forms.Label label_detector_params;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_scan_params;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_exposure_params;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ifbox_params;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_gantry_params;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_coach_params;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_xray_params;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_auxboard_params;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_detector_params;

        private System.Windows.Forms.Label label_scan_uid;
        private System.Windows.Forms.TextBox textBox_scan_uid;

        private System.Windows.Forms.Label label_multi_param_info;
        private System.Windows.Forms.TextBox textBox_multi_param_info;

        private System.Windows.Forms.Label label_protocol_mode;
        private System.Windows.Forms.ComboBox comboBox_protocol_mode;

        private System.Windows.Forms.Label label_workflow_skip_enable;
        private System.Windows.Forms.ComboBox comboBox_workflow_skip_enable;

        private System.Windows.Forms.Label label_scan_base_num;
        private System.Windows.Forms.TextBox textBox_scan_base_num;

        private System.Windows.Forms.Label label_scan_option;
        private System.Windows.Forms.ComboBox comboBox_scan_option;

        private System.Windows.Forms.Label label_scan_mode;
        private System.Windows.Forms.ComboBox comboBox_scan_mode;

        private System.Windows.Forms.Label label_expsoure_mode;
        private System.Windows.Forms.ComboBox comboBox_exposure_mode;

        private System.Windows.Forms.Label label_multi_energy_mode;
        private System.Windows.Forms.ComboBox comboBox_multi_energy_mode;

        private System.Windows.Forms.Label label_scan_loops;
        private System.Windows.Forms.TextBox textBox_scan_loops;

        private System.Windows.Forms.Label label_scan_loop_time;
        private System.Windows.Forms.TextBox textBox_scan_loop_time;

        private System.Windows.Forms.Label label_start_scan_mode;
        private System.Windows.Forms.TextBox textBox_start_scan_mode;

        private System.Windows.Forms.Label label_nvsync_trigger_type;
        private System.Windows.Forms.ComboBox comboBox_nvsync_trigger_type;

        private System.Windows.Forms.Label label_correction_frames;
        private System.Windows.Forms.TextBox textBox_correction_frames;

        private System.Windows.Forms.Label label_pre_oft_frame_time;
        private System.Windows.Forms.TextBox textBox_pre_oft_frame_time;

        private System.Windows.Forms.Label label_exposure_time;
        private System.Windows.Forms.TextBox textBox_exposure_time;

        private System.Windows.Forms.Label label_frame_time;
        private System.Windows.Forms.TextBox textBox_frame_time;

        private System.Windows.Forms.Label label_delay_exp_time;
        private System.Windows.Forms.TextBox textBox_delay_exp_time;

        private System.Windows.Forms.Label label_exposure_xrays_num;
        private System.Windows.Forms.TextBox textBox_exposure_xrays_num;

        private System.Windows.Forms.Label label_frame_per_cycle;
        private System.Windows.Forms.TextBox textBox_frame_per_cycle;

        private System.Windows.Forms.Label label_series_length;
        private System.Windows.Forms.TextBox textBox_series_length;

        private System.Windows.Forms.Label label_collimator_ctrl;
        private System.Windows.Forms.TextBox textBox_collimator_ctrl;

        private System.Windows.Forms.Label label_coll_spot_delay;
        private System.Windows.Forms.TextBox textBox_coll_spot_delay;

        private System.Windows.Forms.Label label_ecg_start_pos;
        private System.Windows.Forms.TextBox textBox_ecg_start_pos;

        private System.Windows.Forms.Label label_ecg_stop_pos;
        private System.Windows.Forms.TextBox textBox_ecg_stop_pos;

        private System.Windows.Forms.Label label_start_angle;
        private System.Windows.Forms.TextBox textBox_start_angle;

        private System.Windows.Forms.Label label_stop_angle;
        private System.Windows.Forms.TextBox textBox_stop_angle;

        private System.Windows.Forms.Label label_gantry_acc;
        private System.Windows.Forms.TextBox textBox_gantry_acc;

        private System.Windows.Forms.Label label_gantry_dec;
        private System.Windows.Forms.TextBox textBox_gantry_dec;

        private System.Windows.Forms.Label label_gantry_speed;
        private System.Windows.Forms.TextBox textBox_gantry_speed;
        
        private System.Windows.Forms.Label label_coach_start_pos;
        private System.Windows.Forms.TextBox textBox_coach_start_pos;

        private System.Windows.Forms.Label label_coach_stop_pos;
        private System.Windows.Forms.TextBox textBox_coach_stop_pos;

        private System.Windows.Forms.Label label_coach_exposure_start_pos;
        private System.Windows.Forms.TextBox textBox_coach_exposure_start_pos;

        private System.Windows.Forms.Label label_coach_exposure_stop_pos;
        private System.Windows.Forms.TextBox textBox_coach_exposure_stop_pos;

        private System.Windows.Forms.Label label_coach_acc;
        private System.Windows.Forms.TextBox textBox_coach_acc;

        private System.Windows.Forms.Label label_coach_speed;
        private System.Windows.Forms.TextBox textBox_coach_speed;

        private System.Windows.Forms.Label label_coach_feed;
        private System.Windows.Forms.TextBox textBox_coach_feed;

        private System.Windows.Forms.Label label_kv;
        private System.Windows.Forms.TextBox textBox_kv;

        private System.Windows.Forms.Label label_ma;
        private System.Windows.Forms.TextBox textBox_ma;

        private System.Windows.Forms.Label label_xray_focus;
        private System.Windows.Forms.ComboBox comboBox_xray_focus;

        private System.Windows.Forms.Label label_xray_spot_delay_time;
        private System.Windows.Forms.TextBox textBox_xray_spot_delay_time;

        private System.Windows.Forms.Label label_xray_error_limit;
        private System.Windows.Forms.TextBox textBox_xray_error_limit;

        private System.Windows.Forms.Label label_voice_id;
        private System.Windows.Forms.TextBox textBox_voice_id;

        private System.Windows.Forms.Label label_voice_time;
        private System.Windows.Forms.TextBox textBox_voice_time;

        private System.Windows.Forms.Label label_det_gain;
        private System.Windows.Forms.TextBox textBox_det_gain;

        private System.Windows.Forms.Label label_det_binning;
        private System.Windows.Forms.TextBox textBox_det_binning;

        private System.Windows.Forms.Label label_det_shutter;
        private System.Windows.Forms.TextBox textBox_det_shutter;

        private System.Windows.Forms.Label label_det_acq_mode;
        private System.Windows.Forms.TextBox textBox_det_acq_mode;

        private System.Windows.Forms.Label label_det_encode_mode;
        private System.Windows.Forms.TextBox textBox_det_encode_mode;

        private System.Windows.Forms.Label label_det_nvsync_delay;
        private System.Windows.Forms.TextBox textBox_det_nvsync_delay;

        private System.Windows.Forms.Label label_det_preoffset_enable;
        private System.Windows.Forms.TextBox textBox_det_preoffset_enable;

        private System.Windows.Forms.Label label_det_preoffset_num;
        private System.Windows.Forms.TextBox textBox_det_preoffset_num;

        private System.Windows.Forms.Label label_param_end;
        private System.Windows.Forms.TextBox textBox_parma_end;


        /* scan control module params */
        private System.Windows.Forms.Label label_line;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_start_scan;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_all_ready;
        private System.Windows.Forms.Button button_load_param;
        private System.Windows.Forms.Button button_save_param;


        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_reg_ctrl;
        private System.Windows.Forms.Label label_reg_addr;
        private System.Windows.Forms.TextBox textBox_reg_addr;
        private System.Windows.Forms.Label label_reg_data;
        private System.Windows.Forms.TextBox textBox_reg_data;
        private System.Windows.Forms.Button button_reg_send;


        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_read_reg_ctrl;
        private System.Windows.Forms.Label label_read_reg_addr;
        private System.Windows.Forms.TextBox textBox_read_reg_addr;
        private System.Windows.Forms.Label label_read_reg_data;
        private System.Windows.Forms.TextBox textBox_read_reg_data;
        private System.Windows.Forms.Button button_reg_read;


        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_scan_ctrl;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button button_clear_log;

        
        private System.Windows.Forms.Label label_exposure_enable;
        private System.Windows.Forms.TextBox textBox_exposure_enable;
    }
}

