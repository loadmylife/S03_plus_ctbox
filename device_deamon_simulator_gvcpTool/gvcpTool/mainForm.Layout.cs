using System;
using System.Drawing;
using System.Windows.Forms;

namespace mainWindow
{
    public partial class mainForm
    {
        private const int LayoutMargin = 10;
        private const int LayoutGap = 5;
        private const int LayoutMinimumWidth = 1075;
        private const int LayoutMinimumHeight = 800;

        private void InitializeResponsiveLayout()
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(640, 480);
            AutoScroll = true;
            Resize += HandleResponsiveLayout;
            ApplyResponsiveLayout();
        }

        private void HandleResponsiveLayout(object sender, EventArgs e)
        {
            ApplyResponsiveLayout();
        }

        private void ApplyResponsiveLayout()
        {
            if (IsDisposed)
                return;

            int viewportWidth = Math.Max(LayoutMinimumWidth, ClientSize.Width);
            int viewportHeight = Math.Max(LayoutMinimumHeight, ClientSize.Height);
            int contentWidth = viewportWidth - LayoutMargin * 2;
            int columnWidth = Math.Max(gui_params.LABELE_WIDTH + gui_params.TEXTBOX_WIDTH,
                (contentWidth - LayoutGap * 3) / 4);
            int column1X = LayoutMargin;
            int column2X = column1X + columnWidth + LayoutGap;
            int column3X = column2X + columnWidth + LayoutGap;
            int column4X = column3X + columnWidth + LayoutGap;

            SuspendLayout();
            try
            {
                ResizePanel(tableLayoutPanel_scan_params, column1X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT, columnWidth * 2 + LayoutGap);
                ResizeHeading(label_scan_params, column1X, gui_params.GUI_ROW_1_POS_Y, columnWidth * 2 + LayoutGap);
                ResizePanel(tableLayoutPanel_auxboard_params, column3X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT, columnWidth);
                ResizeHeading(label_auxboard_params, column3X, gui_params.GUI_ROW_1_POS_Y, columnWidth);
                ResizePanel(tableLayoutPanel_detector_params, column4X, gui_params.GUI_ROW_1_POS_Y + gui_params.LABELE_HEIGHT, columnWidth);
                ResizeHeading(label_detector_params, column4X, gui_params.GUI_ROW_1_POS_Y, columnWidth);

                ResizePanel(tableLayoutPanel_ifbox_params, column1X, gui_params.GUI_ROW_2_POS_Y, columnWidth);
                ResizeHeading(label_ifbox_params, column1X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT, columnWidth);
                ResizePanel(tableLayoutPanel_gantry_params, column2X, gui_params.GUI_ROW_2_POS_Y, columnWidth);
                ResizeHeading(label_gantry_params, column2X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT, columnWidth / 2);
                ResizeValueLabel(label_gantry_position_value, column2X + columnWidth / 2, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT, columnWidth - columnWidth / 2);
                ResizePanel(tableLayoutPanel_coach_params, column3X, gui_params.GUI_ROW_2_POS_Y, columnWidth);
                ResizeHeading(label_coach_params, column3X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT, columnWidth / 2);
                ResizeValueLabel(label_coach_position_value, column3X + columnWidth / 2, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT, columnWidth - columnWidth / 2);
                ResizePanel(tableLayoutPanel_xray_params, column4X, gui_params.GUI_ROW_2_POS_Y, columnWidth);
                ResizeHeading(label_xray_params, column4X, gui_params.GUI_ROW_2_POS_Y - gui_params.LABELE_HEIGHT, columnWidth);

                int controlsY = gui_params.GUI_CTRL_AREA_POS_Y;
                int contentRight = column4X + columnWidth;
                int controlsWidth = contentRight - LayoutMargin;
                tableLayoutPanel_reg_ctrl.Location = new Point(LayoutMargin, controlsY);
                tableLayoutPanel_reg_ctrl.Width = columnWidth * 2 + LayoutGap;
                tableLayoutPanel_reg_ctrl.Height = gui_params.LABELE_HEIGHT * 2 + 3 + gui_params.GUI_BUTTON_SIZE_HEIGHT;
                MatchRegisterColumnsToScanColumns();
                button_reg_send.Margin = new Padding(0, gui_params.GUI_BUTTON_SIZE_HEIGHT / 4, 0, 0);
                button_reg_read.Margin = new Padding(0, gui_params.GUI_BUTTON_SIZE_HEIGHT / 4, 0, 0);
                button_reg_send.Dock = DockStyle.Fill;
                button_reg_read.Dock = DockStyle.Fill;
                label_line.Location = new Point(LayoutMargin, tableLayoutPanel_reg_ctrl.Bottom + gui_params.GUI_LINE_HEIGHT);
                label_line.Width = controlsWidth;
                label_line.Height = 1;
                tableLayoutPanel_scan_ctrl.Location = new Point(LayoutMargin, label_line.Bottom + gui_params.GUI_LINE_HEIGHT);
                tableLayoutPanel_scan_ctrl.Width = controlsWidth;
                textBox_log.Location = new Point(LayoutMargin, tableLayoutPanel_scan_ctrl.Bottom);
                textBox_log.Width = Math.Max(300, controlsWidth - gui_params.GUI_BUTTON_SIZE_WIDTH - LayoutGap);
                textBox_log.Height = Math.Max(100, viewportHeight - textBox_log.Top - LayoutMargin);
                button_clear_log.Location = new Point(contentRight - gui_params.GUI_BUTTON_SIZE_WIDTH, textBox_log.Bottom - button_clear_log.Height);

                AutoScrollMinSize = new Size(contentRight + LayoutMargin, Math.Max(LayoutMinimumHeight, textBox_log.Bottom + LayoutMargin));
                StretchParameterInputs();
                StretchRegisterInputs();
            }
            finally
            {
                ResumeLayout(true);
            }
        }

        private static void ResizePanel(Control control, int x, int y, int width)
        {
            control.Location = new Point(x, y);
            control.Width = width;
        }

        private static void ResizeHeading(Control control, int x, int y, int width)
        {
            control.Location = new Point(x, y);
            control.Width = width;
        }

        private static void ResizeValueLabel(Control control, int x, int y, int width)
        {
            control.Location = new Point(x, y);
            control.Width = width;
        }

        private void StretchParameterInputs()
        {
            Control[] panels =
            {
                tableLayoutPanel_scan_params, tableLayoutPanel_auxboard_params,
                tableLayoutPanel_detector_params, tableLayoutPanel_ifbox_params,
                tableLayoutPanel_gantry_params, tableLayoutPanel_coach_params,
                tableLayoutPanel_xray_params
            };
            foreach (Control panel in panels)
            {
                foreach (Control child in panel.Controls)
                {
                    if (child is TextBox || child is ComboBox)
                        child.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                }
            }
        }

        private void StretchRegisterInputs()
        {
            TextBox[] inputs =
            {
                textBox_reg_addr, textBox_reg_data, textBox_read_reg_addr, textBox_read_reg_data
            };
            foreach (TextBox input in inputs)
            {
                input.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                input.Margin = new Padding(input.Margin.Left, input.Margin.Top, input.Margin.Right, 0);
            }
        }

        private void MatchRegisterColumnsToScanColumns()
        {
            int width = tableLayoutPanel_reg_ctrl.Width;
            int baseWidth = width / 4;
            int remainder = width - baseWidth * 4;
            for (int i = 0; i < 4; i++)
            {
                int columnWidth = baseWidth + (i < remainder ? 1 : 0);
                tableLayoutPanel_scan_params.ColumnStyles[i].SizeType = SizeType.Absolute;
                tableLayoutPanel_scan_params.ColumnStyles[i].Width = columnWidth;
                tableLayoutPanel_reg_ctrl.ColumnStyles[i].SizeType = SizeType.Absolute;
                tableLayoutPanel_reg_ctrl.ColumnStyles[i].Width = columnWidth;
            }
        }
    }
}
