namespace SerialAssistant
{
    partial class Form1
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

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_uart = new System.Windows.Forms.Panel();
            this.test_in_button = new System.Windows.Forms.Button();
            this.scan_uart_button = new System.Windows.Forms.Button();
            this.open_uart_button = new System.Windows.Forms.Button();
            this.comboBox_uart = new System.Windows.Forms.ComboBox();
            this.com_label = new System.Windows.Forms.Label();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.seed_button = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.down_label = new System.Windows.Forms.Label();
            this.rxcnt_label = new System.Windows.Forms.Label();
            this.panel_down = new System.Windows.Forms.Panel();
            this.version_label = new System.Windows.Forms.Label();
            this.uart_com_label = new System.Windows.Forms.Label();
            this.l_uart_com = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.panel_info = new System.Windows.Forms.Panel();
            this.l_ErrorCode = new System.Windows.Forms.Label();
            this.l_StepType = new System.Windows.Forms.Label();
            this.l_Third_Data = new System.Windows.Forms.Label();
            this.l_Program = new System.Windows.Forms.Label();
            this.l_State = new System.Windows.Forms.Label();
            this.l_Stage = new System.Windows.Forms.Label();
            this.l_RunMaxTime = new System.Windows.Forms.Label();
            this.l_DownTime = new System.Windows.Forms.Label();
            this.l_BLDC_ERROR = new System.Windows.Forms.Label();
            this.l_BLDC_Power = new System.Windows.Forms.Label();
            this.l_BLDC_RealitySpeed = new System.Windows.Forms.Label();
            this.l_AverageTurb = new System.Windows.Forms.Label();
            this.l_Temperature = new System.Windows.Forms.Label();
            this.l_WaterPulse = new System.Windows.Forms.Label();
            this.l_M_MainType = new System.Windows.Forms.Label();
            this.l_BLDC_Version = new System.Windows.Forms.Label();
            this.l_M_SoftwareVer = new System.Windows.Forms.Label();
            this.textBox_para = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.textBox_bldc = new System.Windows.Forms.TextBox();
            this.textBox_alt = new System.Windows.Forms.TextBox();
            this.model_label = new System.Windows.Forms.Label();
            this.panel_sheet = new System.Windows.Forms.Panel();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.alt_label = new System.Windows.Forms.Label();
            this.bldc_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.para_label = new System.Windows.Forms.Label();
            this.add_sheet_button = new System.Windows.Forms.Button();
            this.textBox_sheet = new System.Windows.Forms.TextBox();
            this.save_sheet_button = new System.Windows.Forms.Button();
            this.panel_load = new System.Windows.Forms.Panel();
            this.l_W_Load3 = new System.Windows.Forms.Label();
            this.l_W_Load2 = new System.Windows.Forms.Label();
            this.l_W_Load1 = new System.Windows.Forms.Label();
            this.txcnt_label = new System.Windows.Forms.Label();
            this.panel_uart.SuspendLayout();
            this.panel_down.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.panel_sheet.SuspendLayout();
            this.panel_load.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_uart
            // 
            this.panel_uart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_uart.Controls.Add(this.test_in_button);
            this.panel_uart.Controls.Add(this.scan_uart_button);
            this.panel_uart.Controls.Add(this.open_uart_button);
            this.panel_uart.Controls.Add(this.comboBox_uart);
            this.panel_uart.Controls.Add(this.com_label);
            this.panel_uart.Location = new System.Drawing.Point(6, 47);
            this.panel_uart.MinimumSize = new System.Drawing.Size(100, 100);
            this.panel_uart.Name = "panel_uart";
            this.panel_uart.Size = new System.Drawing.Size(179, 128);
            this.panel_uart.TabIndex = 0;
            // 
            // test_in_button
            // 
            this.test_in_button.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.test_in_button.Location = new System.Drawing.Point(98, 83);
            this.test_in_button.Name = "test_in_button";
            this.test_in_button.Size = new System.Drawing.Size(74, 34);
            this.test_in_button.TabIndex = 12;
            this.test_in_button.Text = "进入测试模式";
            this.test_in_button.UseVisualStyleBackColor = true;
            this.test_in_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // scan_uart_button
            // 
            this.scan_uart_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.scan_uart_button.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scan_uart_button.Location = new System.Drawing.Point(13, 83);
            this.scan_uart_button.Name = "scan_uart_button";
            this.scan_uart_button.Size = new System.Drawing.Size(74, 34);
            this.scan_uart_button.TabIndex = 11;
            this.scan_uart_button.Text = "刷新串口";
            this.scan_uart_button.UseVisualStyleBackColor = false;
            this.scan_uart_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // open_uart_button
            // 
            this.open_uart_button.BackColor = System.Drawing.Color.ForestGreen;
            this.open_uart_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.open_uart_button.Location = new System.Drawing.Point(13, 43);
            this.open_uart_button.Name = "open_uart_button";
            this.open_uart_button.Size = new System.Drawing.Size(159, 34);
            this.open_uart_button.TabIndex = 10;
            this.open_uart_button.Text = "打开串口";
            this.open_uart_button.UseVisualStyleBackColor = false;
            this.open_uart_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_uart
            // 
            this.comboBox_uart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_uart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_uart.FormattingEnabled = true;
            this.comboBox_uart.Location = new System.Drawing.Point(78, 8);
            this.comboBox_uart.Name = "comboBox_uart";
            this.comboBox_uart.Size = new System.Drawing.Size(94, 29);
            this.comboBox_uart.TabIndex = 1;
            // 
            // com_label
            // 
            this.com_label.AutoSize = true;
            this.com_label.BackColor = System.Drawing.SystemColors.Control;
            this.com_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.com_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.com_label.Location = new System.Drawing.Point(9, 11);
            this.com_label.Name = "com_label";
            this.com_label.Size = new System.Drawing.Size(57, 21);
            this.com_label.TabIndex = 0;
            this.com_label.Text = "串   口";
            // 
            // textBox_receive
            // 
            this.textBox_receive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_receive.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_receive.Location = new System.Drawing.Point(271, 13);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.ReadOnly = true;
            this.textBox_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_receive.Size = new System.Drawing.Size(152, 25);
            this.textBox_receive.TabIndex = 0;
            this.textBox_receive.Visible = false;
            // 
            // seed_button
            // 
            this.seed_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.seed_button.Enabled = false;
            this.seed_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.seed_button.Location = new System.Drawing.Point(191, 12);
            this.seed_button.Name = "seed_button";
            this.seed_button.Size = new System.Drawing.Size(51, 29);
            this.seed_button.TabIndex = 1;
            this.seed_button.Text = "发送数据";
            this.seed_button.UseVisualStyleBackColor = false;
            this.seed_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // down_label
            // 
            this.down_label.AutoSize = true;
            this.down_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.down_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.down_label.ForeColor = System.Drawing.Color.Red;
            this.down_label.Location = new System.Drawing.Point(0, 0);
            this.down_label.Name = "down_label";
            this.down_label.Size = new System.Drawing.Size(90, 21);
            this.down_label.TabIndex = 0;
            this.down_label.Text = "串口已关闭";
            // 
            // rxcnt_label
            // 
            this.rxcnt_label.AutoSize = true;
            this.rxcnt_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rxcnt_label.Location = new System.Drawing.Point(184, 0);
            this.rxcnt_label.Name = "rxcnt_label";
            this.rxcnt_label.Size = new System.Drawing.Size(86, 21);
            this.rxcnt_label.TabIndex = 1;
            this.rxcnt_label.Text = "Rx: 0Bytes";
            this.rxcnt_label.Visible = false;
            // 
            // panel_down
            // 
            this.panel_down.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_down.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_down.Controls.Add(this.version_label);
            this.panel_down.Controls.Add(this.rxcnt_label);
            this.panel_down.Controls.Add(this.txcnt_label);
            this.panel_down.Controls.Add(this.down_label);
            this.panel_down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_down.Location = new System.Drawing.Point(0, 565);
            this.panel_down.Name = "panel_down";
            this.panel_down.Size = new System.Drawing.Size(1203, 25);
            this.panel_down.TabIndex = 7;
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.version_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.version_label.ForeColor = System.Drawing.Color.SeaGreen;
            this.version_label.Location = new System.Drawing.Point(1139, 0);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(60, 21);
            this.version_label.TabIndex = 3;
            this.version_label.Text = "@V1.0";
            // 
            // uart_com_label
            // 
            this.uart_com_label.AutoSize = true;
            this.uart_com_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uart_com_label.Location = new System.Drawing.Point(8, 541);
            this.uart_com_label.Name = "uart_com_label";
            this.uart_com_label.Size = new System.Drawing.Size(110, 21);
            this.uart_com_label.TabIndex = 4;
            this.uart_com_label.Text = "原始串口数据:";
            // 
            // l_uart_com
            // 
            this.l_uart_com.AutoSize = true;
            this.l_uart_com.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_uart_com.Location = new System.Drawing.Point(124, 541);
            this.l_uart_com.Name = "l_uart_com";
            this.l_uart_com.Size = new System.Drawing.Size(106, 21);
            this.l_uart_com.TabIndex = 2;
            this.l_uart_com.Text = "原始串口数据";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_send
            // 
            this.textBox_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_send.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_send.Location = new System.Drawing.Point(15, 13);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_send.Size = new System.Drawing.Size(170, 28);
            this.textBox_send.TabIndex = 0;
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_info.Controls.Add(this.l_ErrorCode);
            this.panel_info.Controls.Add(this.l_StepType);
            this.panel_info.Controls.Add(this.l_Third_Data);
            this.panel_info.Controls.Add(this.l_Program);
            this.panel_info.Controls.Add(this.l_State);
            this.panel_info.Controls.Add(this.l_Stage);
            this.panel_info.Controls.Add(this.l_RunMaxTime);
            this.panel_info.Controls.Add(this.l_DownTime);
            this.panel_info.Controls.Add(this.l_BLDC_ERROR);
            this.panel_info.Controls.Add(this.l_BLDC_Power);
            this.panel_info.Controls.Add(this.l_BLDC_RealitySpeed);
            this.panel_info.Controls.Add(this.l_AverageTurb);
            this.panel_info.Controls.Add(this.l_Temperature);
            this.panel_info.Controls.Add(this.l_WaterPulse);
            this.panel_info.Controls.Add(this.l_M_MainType);
            this.panel_info.Controls.Add(this.l_BLDC_Version);
            this.panel_info.Controls.Add(this.l_M_SoftwareVer);
            this.panel_info.Location = new System.Drawing.Point(15, 453);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(1176, 85);
            this.panel_info.TabIndex = 18;
            // 
            // l_ErrorCode
            // 
            this.l_ErrorCode.AutoSize = true;
            this.l_ErrorCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_ErrorCode.Location = new System.Drawing.Point(981, 48);
            this.l_ErrorCode.Name = "l_ErrorCode";
            this.l_ErrorCode.Size = new System.Drawing.Size(90, 21);
            this.l_ErrorCode.TabIndex = 34;
            this.l_ErrorCode.Text = "故障代码：";
            // 
            // l_StepType
            // 
            this.l_StepType.AutoSize = true;
            this.l_StepType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_StepType.Location = new System.Drawing.Point(412, 48);
            this.l_StepType.Name = "l_StepType";
            this.l_StepType.Size = new System.Drawing.Size(90, 21);
            this.l_StepType.TabIndex = 33;
            this.l_StepType.Text = "步骤序号：";
            // 
            // l_Third_Data
            // 
            this.l_Third_Data.AutoSize = true;
            this.l_Third_Data.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_Third_Data.Location = new System.Drawing.Point(848, 48);
            this.l_Third_Data.Name = "l_Third_Data";
            this.l_Third_Data.Size = new System.Drawing.Size(90, 21);
            this.l_Third_Data.TabIndex = 32;
            this.l_Third_Data.Text = "机器信号：";
            // 
            // l_Program
            // 
            this.l_Program.AutoSize = true;
            this.l_Program.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_Program.Location = new System.Drawing.Point(715, 48);
            this.l_Program.Name = "l_Program";
            this.l_Program.Size = new System.Drawing.Size(90, 21);
            this.l_Program.TabIndex = 31;
            this.l_Program.Text = "洗涤程序：";
            // 
            // l_State
            // 
            this.l_State.AutoSize = true;
            this.l_State.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_State.Location = new System.Drawing.Point(563, 48);
            this.l_State.Name = "l_State";
            this.l_State.Size = new System.Drawing.Size(90, 21);
            this.l_State.TabIndex = 30;
            this.l_State.Text = "机器状态：";
            // 
            // l_Stage
            // 
            this.l_Stage.AutoSize = true;
            this.l_Stage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_Stage.Location = new System.Drawing.Point(279, 48);
            this.l_Stage.Name = "l_Stage";
            this.l_Stage.Size = new System.Drawing.Size(90, 21);
            this.l_Stage.TabIndex = 29;
            this.l_Stage.Text = "洗涤阶段：";
            // 
            // l_RunMaxTime
            // 
            this.l_RunMaxTime.AutoSize = true;
            this.l_RunMaxTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_RunMaxTime.Location = new System.Drawing.Point(146, 48);
            this.l_RunMaxTime.Name = "l_RunMaxTime";
            this.l_RunMaxTime.Size = new System.Drawing.Size(74, 21);
            this.l_RunMaxTime.TabIndex = 28;
            this.l_RunMaxTime.Text = "总时间：";
            // 
            // l_DownTime
            // 
            this.l_DownTime.AutoSize = true;
            this.l_DownTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_DownTime.Location = new System.Drawing.Point(13, 48);
            this.l_DownTime.Name = "l_DownTime";
            this.l_DownTime.Size = new System.Drawing.Size(90, 21);
            this.l_DownTime.TabIndex = 27;
            this.l_DownTime.Text = "剩余时间：";
            // 
            // l_BLDC_ERROR
            // 
            this.l_BLDC_ERROR.AutoSize = true;
            this.l_BLDC_ERROR.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_BLDC_ERROR.Location = new System.Drawing.Point(981, 14);
            this.l_BLDC_ERROR.Name = "l_BLDC_ERROR";
            this.l_BLDC_ERROR.Size = new System.Drawing.Size(90, 21);
            this.l_BLDC_ERROR.TabIndex = 26;
            this.l_BLDC_ERROR.Text = "电机故障：";
            // 
            // l_BLDC_Power
            // 
            this.l_BLDC_Power.AutoSize = true;
            this.l_BLDC_Power.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_BLDC_Power.Location = new System.Drawing.Point(848, 14);
            this.l_BLDC_Power.Name = "l_BLDC_Power";
            this.l_BLDC_Power.Size = new System.Drawing.Size(90, 21);
            this.l_BLDC_Power.TabIndex = 25;
            this.l_BLDC_Power.Text = "电机功率：";
            // 
            // l_BLDC_RealitySpeed
            // 
            this.l_BLDC_RealitySpeed.AutoSize = true;
            this.l_BLDC_RealitySpeed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_BLDC_RealitySpeed.Location = new System.Drawing.Point(715, 14);
            this.l_BLDC_RealitySpeed.Name = "l_BLDC_RealitySpeed";
            this.l_BLDC_RealitySpeed.Size = new System.Drawing.Size(90, 21);
            this.l_BLDC_RealitySpeed.TabIndex = 24;
            this.l_BLDC_RealitySpeed.Text = "电机转速：";
            // 
            // l_AverageTurb
            // 
            this.l_AverageTurb.AutoSize = true;
            this.l_AverageTurb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_AverageTurb.Location = new System.Drawing.Point(614, 14);
            this.l_AverageTurb.Name = "l_AverageTurb";
            this.l_AverageTurb.Size = new System.Drawing.Size(58, 21);
            this.l_AverageTurb.TabIndex = 23;
            this.l_AverageTurb.Text = "浊度：";
            // 
            // l_Temperature
            // 
            this.l_Temperature.AutoSize = true;
            this.l_Temperature.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_Temperature.Location = new System.Drawing.Point(513, 14);
            this.l_Temperature.Name = "l_Temperature";
            this.l_Temperature.Size = new System.Drawing.Size(58, 21);
            this.l_Temperature.TabIndex = 22;
            this.l_Temperature.Text = "水温：";
            // 
            // l_WaterPulse
            // 
            this.l_WaterPulse.AutoSize = true;
            this.l_WaterPulse.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_WaterPulse.Location = new System.Drawing.Point(412, 14);
            this.l_WaterPulse.Name = "l_WaterPulse";
            this.l_WaterPulse.Size = new System.Drawing.Size(58, 21);
            this.l_WaterPulse.TabIndex = 21;
            this.l_WaterPulse.Text = "水量：";
            // 
            // l_M_MainType
            // 
            this.l_M_MainType.AutoSize = true;
            this.l_M_MainType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_M_MainType.Location = new System.Drawing.Point(13, 14);
            this.l_M_MainType.Name = "l_M_MainType";
            this.l_M_MainType.Size = new System.Drawing.Size(90, 21);
            this.l_M_MainType.TabIndex = 18;
            this.l_M_MainType.Text = "机型信息：";
            // 
            // l_BLDC_Version
            // 
            this.l_BLDC_Version.AutoSize = true;
            this.l_BLDC_Version.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_BLDC_Version.Location = new System.Drawing.Point(279, 14);
            this.l_BLDC_Version.Name = "l_BLDC_Version";
            this.l_BLDC_Version.Size = new System.Drawing.Size(90, 21);
            this.l_BLDC_Version.TabIndex = 20;
            this.l_BLDC_Version.Text = "电机版本：";
            // 
            // l_M_SoftwareVer
            // 
            this.l_M_SoftwareVer.AutoSize = true;
            this.l_M_SoftwareVer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_M_SoftwareVer.Location = new System.Drawing.Point(146, 14);
            this.l_M_SoftwareVer.Name = "l_M_SoftwareVer";
            this.l_M_SoftwareVer.Size = new System.Drawing.Size(90, 21);
            this.l_M_SoftwareVer.TabIndex = 19;
            this.l_M_SoftwareVer.Text = "软件版本：";
            // 
            // textBox_para
            // 
            this.textBox_para.Location = new System.Drawing.Point(67, 30);
            this.textBox_para.Name = "textBox_para";
            this.textBox_para.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_para.Size = new System.Drawing.Size(50, 21);
            this.textBox_para.TabIndex = 20;
            this.textBox_para.Text = "0";
            this.textBox_para.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_para_KeyPress);
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(128, 30);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(50, 21);
            this.textBox_time.TabIndex = 21;
            this.textBox_time.Text = "0";
            this.textBox_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_time_KeyPress);
            // 
            // textBox_bldc
            // 
            this.textBox_bldc.Location = new System.Drawing.Point(189, 30);
            this.textBox_bldc.Name = "textBox_bldc";
            this.textBox_bldc.Size = new System.Drawing.Size(50, 21);
            this.textBox_bldc.TabIndex = 22;
            this.textBox_bldc.Text = "0";
            this.textBox_bldc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_bldc_KeyPress);
            // 
            // textBox_alt
            // 
            this.textBox_alt.Location = new System.Drawing.Point(250, 30);
            this.textBox_alt.Name = "textBox_alt";
            this.textBox_alt.Size = new System.Drawing.Size(50, 21);
            this.textBox_alt.TabIndex = 23;
            this.textBox_alt.Text = "0";
            this.textBox_alt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_alt_KeyPress);
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.model_label.Location = new System.Drawing.Point(5, 6);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(58, 21);
            this.model_label.TabIndex = 18;
            this.model_label.Text = "模块号";
            // 
            // panel_sheet
            // 
            this.panel_sheet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_sheet.Controls.Add(this.textBox_model);
            this.panel_sheet.Controls.Add(this.alt_label);
            this.panel_sheet.Controls.Add(this.bldc_label);
            this.panel_sheet.Controls.Add(this.time_label);
            this.panel_sheet.Controls.Add(this.para_label);
            this.panel_sheet.Controls.Add(this.model_label);
            this.panel_sheet.Controls.Add(this.add_sheet_button);
            this.panel_sheet.Controls.Add(this.textBox_para);
            this.panel_sheet.Controls.Add(this.textBox_alt);
            this.panel_sheet.Controls.Add(this.textBox_bldc);
            this.panel_sheet.Controls.Add(this.textBox_time);
            this.panel_sheet.Location = new System.Drawing.Point(191, 47);
            this.panel_sheet.Name = "panel_sheet";
            this.panel_sheet.Size = new System.Drawing.Size(402, 62);
            this.panel_sheet.TabIndex = 24;
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(9, 30);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_model.Size = new System.Drawing.Size(50, 21);
            this.textBox_model.TabIndex = 27;
            this.textBox_model.Text = "0";
            this.textBox_model.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_model_KeyPress);
            // 
            // alt_label
            // 
            this.alt_label.AutoSize = true;
            this.alt_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alt_label.Location = new System.Drawing.Point(246, 6);
            this.alt_label.Name = "alt_label";
            this.alt_label.Size = new System.Drawing.Size(58, 21);
            this.alt_label.TabIndex = 26;
            this.alt_label.Text = "分水阀";
            // 
            // bldc_label
            // 
            this.bldc_label.AutoSize = true;
            this.bldc_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bldc_label.Location = new System.Drawing.Point(195, 6);
            this.bldc_label.Name = "bldc_label";
            this.bldc_label.Size = new System.Drawing.Size(42, 21);
            this.bldc_label.TabIndex = 25;
            this.bldc_label.Text = "电机";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time_label.Location = new System.Drawing.Point(124, 6);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(58, 21);
            this.time_label.TabIndex = 25;
            this.time_label.Text = "倒计时";
            // 
            // para_label
            // 
            this.para_label.AutoSize = true;
            this.para_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.para_label.Location = new System.Drawing.Point(69, 6);
            this.para_label.Name = "para_label";
            this.para_label.Size = new System.Drawing.Size(42, 21);
            this.para_label.TabIndex = 24;
            this.para_label.Text = "参数";
            // 
            // add_sheet_button
            // 
            this.add_sheet_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.add_sheet_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_sheet_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_sheet_button.Location = new System.Drawing.Point(315, 6);
            this.add_sheet_button.Name = "add_sheet_button";
            this.add_sheet_button.Size = new System.Drawing.Size(84, 53);
            this.add_sheet_button.TabIndex = 25;
            this.add_sheet_button.Text = "加入时序";
            this.add_sheet_button.UseVisualStyleBackColor = false;
            this.add_sheet_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox_sheet
            // 
            this.textBox_sheet.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_sheet.Location = new System.Drawing.Point(191, 115);
            this.textBox_sheet.Multiline = true;
            this.textBox_sheet.Name = "textBox_sheet";
            this.textBox_sheet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_sheet.Size = new System.Drawing.Size(307, 332);
            this.textBox_sheet.TabIndex = 25;
            this.textBox_sheet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save_sheet_button
            // 
            this.save_sheet_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.save_sheet_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save_sheet_button.Location = new System.Drawing.Point(506, 115);
            this.save_sheet_button.Name = "save_sheet_button";
            this.save_sheet_button.Size = new System.Drawing.Size(84, 53);
            this.save_sheet_button.TabIndex = 27;
            this.save_sheet_button.Text = "保存";
            this.save_sheet_button.UseVisualStyleBackColor = false;
            this.save_sheet_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel_load
            // 
            this.panel_load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_load.Controls.Add(this.l_W_Load3);
            this.panel_load.Controls.Add(this.l_W_Load2);
            this.panel_load.Controls.Add(this.l_W_Load1);
            this.panel_load.Location = new System.Drawing.Point(504, 254);
            this.panel_load.Name = "panel_load";
            this.panel_load.Size = new System.Drawing.Size(475, 193);
            this.panel_load.TabIndex = 28;
            // 
            // l_W_Load3
            // 
            this.l_W_Load3.AutoSize = true;
            this.l_W_Load3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_W_Load3.Location = new System.Drawing.Point(252, 15);
            this.l_W_Load3.Name = "l_W_Load3";
            this.l_W_Load3.Size = new System.Drawing.Size(99, 21);
            this.l_W_Load3.TabIndex = 21;
            this.l_W_Load3.Text = "负载状态3：";
            // 
            // l_W_Load2
            // 
            this.l_W_Load2.AutoSize = true;
            this.l_W_Load2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_W_Load2.Location = new System.Drawing.Point(136, 15);
            this.l_W_Load2.Name = "l_W_Load2";
            this.l_W_Load2.Size = new System.Drawing.Size(99, 21);
            this.l_W_Load2.TabIndex = 20;
            this.l_W_Load2.Text = "负载状态2：";
            // 
            // l_W_Load1
            // 
            this.l_W_Load1.AutoSize = true;
            this.l_W_Load1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_W_Load1.Location = new System.Drawing.Point(20, 15);
            this.l_W_Load1.Name = "l_W_Load1";
            this.l_W_Load1.Size = new System.Drawing.Size(99, 21);
            this.l_W_Load1.TabIndex = 19;
            this.l_W_Load1.Text = "负载状态1：";
            // 
            // txcnt_label
            // 
            this.txcnt_label.AutoSize = true;
            this.txcnt_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txcnt_label.Location = new System.Drawing.Point(93, 0);
            this.txcnt_label.Name = "txcnt_label";
            this.txcnt_label.Size = new System.Drawing.Size(85, 21);
            this.txcnt_label.TabIndex = 2;
            this.txcnt_label.Text = "Tx: 0Bytes";
            this.txcnt_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1203, 590);
            this.Controls.Add(this.panel_load);
            this.Controls.Add(this.uart_com_label);
            this.Controls.Add(this.save_sheet_button);
            this.Controls.Add(this.l_uart_com);
            this.Controls.Add(this.textBox_sheet);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.seed_button);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.panel_down);
            this.Controls.Add(this.panel_uart);
            this.Controls.Add(this.textBox_receive);
            this.Controls.Add(this.panel_sheet);
            this.Name = "Form1";
            this.Text = "方太洗碗机测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_uart.ResumeLayout(false);
            this.panel_uart.PerformLayout();
            this.panel_down.ResumeLayout(false);
            this.panel_down.PerformLayout();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.panel_sheet.ResumeLayout(false);
            this.panel_sheet.PerformLayout();
            this.panel_load.ResumeLayout(false);
            this.panel_load.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_uart;
        private System.Windows.Forms.Button open_uart_button;
        private System.Windows.Forms.ComboBox comboBox_uart;
        private System.Windows.Forms.Label com_label;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.Button seed_button;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button scan_uart_button;
        private System.Windows.Forms.Label rxcnt_label;
        private System.Windows.Forms.Label down_label;
        private System.Windows.Forms.Panel panel_down;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_uart_com;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button test_in_button;
        private System.Windows.Forms.Label uart_com_label;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.TextBox textBox_para;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.TextBox textBox_bldc;
        private System.Windows.Forms.TextBox textBox_alt;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Panel panel_sheet;
        private System.Windows.Forms.Button add_sheet_button;
        private System.Windows.Forms.Label alt_label;
        private System.Windows.Forms.Label bldc_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label para_label;
        private System.Windows.Forms.TextBox textBox_sheet;
        private System.Windows.Forms.Button save_sheet_button;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.Label l_M_MainType;
        private System.Windows.Forms.Label l_BLDC_Version;
        private System.Windows.Forms.Label l_M_SoftwareVer;
        private System.Windows.Forms.Panel panel_load;
        private System.Windows.Forms.Label l_W_Load3;
        private System.Windows.Forms.Label l_W_Load2;
        private System.Windows.Forms.Label l_W_Load1;
        private System.Windows.Forms.Label l_ErrorCode;
        private System.Windows.Forms.Label l_StepType;
        private System.Windows.Forms.Label l_Third_Data;
        private System.Windows.Forms.Label l_Program;
        private System.Windows.Forms.Label l_State;
        private System.Windows.Forms.Label l_Stage;
        private System.Windows.Forms.Label l_RunMaxTime;
        private System.Windows.Forms.Label l_DownTime;
        private System.Windows.Forms.Label l_BLDC_ERROR;
        private System.Windows.Forms.Label l_BLDC_Power;
        private System.Windows.Forms.Label l_BLDC_RealitySpeed;
        private System.Windows.Forms.Label l_AverageTurb;
        private System.Windows.Forms.Label l_Temperature;
        private System.Windows.Forms.Label l_WaterPulse;
        private System.Windows.Forms.Label txcnt_label;
    }
}

