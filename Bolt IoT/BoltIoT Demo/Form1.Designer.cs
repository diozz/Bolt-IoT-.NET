namespace BoltIoT_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeviceId = new System.Windows.Forms.TextBox();
            this.ApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CredentialsPanel = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExecuteDigitalWrite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DigitalWritePinSel = new System.Windows.Forms.ComboBox();
            this.DigitalWriteStateSel = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ExecuteDigitalRead = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DigitalReadPinSel = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ExecuteAnalogRead = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AnalogReadPinSel = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AnalogWriteValue = new System.Windows.Forms.NumericUpDown();
            this.ExecuteAnalogWrite = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AnalogWritePinSel = new System.Windows.Forms.ComboBox();
            this.ResponsePanel = new System.Windows.Forms.GroupBox();
            this.Response = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.SerialWriteReadTill = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SerialWriteReadData = new System.Windows.Forms.RichTextBox();
            this.ExecuteSerialWriteRead = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.SerialReadTill = new System.Windows.Forms.NumericUpDown();
            this.ExecuteSerialRead = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SerialWriteData = new System.Windows.Forms.RichTextBox();
            this.ExecuteSerialWrite = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ExecuteSerialBegin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.BaudRateSel = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.ExecuteRestart = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.ExecuteIsOnline = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.ExecuteGetDeviceVersion = new System.Windows.Forms.Button();
            this.OperationsPanel = new System.Windows.Forms.GroupBox();
            this.Status = new System.Windows.Forms.Label();
            this.RequestUrlPanel = new System.Windows.Forms.GroupBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.RequestURL = new System.Windows.Forms.TextBox();
            this.CredentialsPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogWriteValue)).BeginInit();
            this.ResponsePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerialWriteReadTill)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerialReadTill)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.OperationsPanel.SuspendLayout();
            this.RequestUrlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeviceId
            // 
            this.DeviceId.Location = new System.Drawing.Point(24, 48);
            this.DeviceId.Name = "DeviceId";
            this.DeviceId.Size = new System.Drawing.Size(210, 20);
            this.DeviceId.TabIndex = 0;
            // 
            // ApiKey
            // 
            this.ApiKey.Location = new System.Drawing.Point(255, 48);
            this.ApiKey.Name = "ApiKey";
            this.ApiKey.Size = new System.Drawing.Size(379, 20);
            this.ApiKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "API Key";
            // 
            // CredentialsPanel
            // 
            this.CredentialsPanel.Controls.Add(this.DeviceId);
            this.CredentialsPanel.Controls.Add(this.label2);
            this.CredentialsPanel.Controls.Add(this.ApiKey);
            this.CredentialsPanel.Controls.Add(this.label1);
            this.CredentialsPanel.Location = new System.Drawing.Point(12, 12);
            this.CredentialsPanel.Name = "CredentialsPanel";
            this.CredentialsPanel.Size = new System.Drawing.Size(656, 88);
            this.CredentialsPanel.TabIndex = 4;
            this.CredentialsPanel.TabStop = false;
            this.CredentialsPanel.Text = "Credentials";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ExecuteDigitalWrite);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.DigitalWritePinSel);
            this.groupBox3.Controls.Add(this.DigitalWriteStateSel);
            this.groupBox3.Location = new System.Drawing.Point(8, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 114);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DigitalWrite";
            // 
            // ExecuteDigitalWrite
            // 
            this.ExecuteDigitalWrite.Location = new System.Drawing.Point(9, 77);
            this.ExecuteDigitalWrite.Name = "ExecuteDigitalWrite";
            this.ExecuteDigitalWrite.Size = new System.Drawing.Size(143, 29);
            this.ExecuteDigitalWrite.TabIndex = 6;
            this.ExecuteDigitalWrite.Text = "Execute";
            this.ExecuteDigitalWrite.UseVisualStyleBackColor = true;
            this.ExecuteDigitalWrite.Click += new System.EventHandler(this.ExecuteDigitalWrite_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pin";
            // 
            // DigitalWritePinSel
            // 
            this.DigitalWritePinSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DigitalWritePinSel.FormattingEnabled = true;
            this.DigitalWritePinSel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.DigitalWritePinSel.Location = new System.Drawing.Point(10, 46);
            this.DigitalWritePinSel.MaxDropDownItems = 2;
            this.DigitalWritePinSel.MaxLength = 2;
            this.DigitalWritePinSel.Name = "DigitalWritePinSel";
            this.DigitalWritePinSel.Size = new System.Drawing.Size(52, 21);
            this.DigitalWritePinSel.TabIndex = 1;
            // 
            // DigitalWriteStateSel
            // 
            this.DigitalWriteStateSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DigitalWriteStateSel.FormattingEnabled = true;
            this.DigitalWriteStateSel.Items.AddRange(new object[] {
            "LOW",
            "HIGH"});
            this.DigitalWriteStateSel.Location = new System.Drawing.Point(72, 45);
            this.DigitalWriteStateSel.MaxDropDownItems = 2;
            this.DigitalWriteStateSel.MaxLength = 2;
            this.DigitalWriteStateSel.Name = "DigitalWriteStateSel";
            this.DigitalWriteStateSel.Size = new System.Drawing.Size(78, 21);
            this.DigitalWriteStateSel.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ExecuteDigitalRead);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.DigitalReadPinSel);
            this.groupBox4.Location = new System.Drawing.Point(178, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 114);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DigitalRead";
            // 
            // ExecuteDigitalRead
            // 
            this.ExecuteDigitalRead.Location = new System.Drawing.Point(9, 77);
            this.ExecuteDigitalRead.Name = "ExecuteDigitalRead";
            this.ExecuteDigitalRead.Size = new System.Drawing.Size(120, 29);
            this.ExecuteDigitalRead.TabIndex = 6;
            this.ExecuteDigitalRead.Text = "Execute";
            this.ExecuteDigitalRead.UseVisualStyleBackColor = true;
            this.ExecuteDigitalRead.Click += new System.EventHandler(this.ExecuteDigitalRead_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pin";
            // 
            // DigitalReadPinSel
            // 
            this.DigitalReadPinSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DigitalReadPinSel.FormattingEnabled = true;
            this.DigitalReadPinSel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "A0"});
            this.DigitalReadPinSel.Location = new System.Drawing.Point(10, 46);
            this.DigitalReadPinSel.MaxDropDownItems = 2;
            this.DigitalReadPinSel.MaxLength = 2;
            this.DigitalReadPinSel.Name = "DigitalReadPinSel";
            this.DigitalReadPinSel.Size = new System.Drawing.Size(55, 21);
            this.DigitalReadPinSel.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ExecuteAnalogRead);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.AnalogReadPinSel);
            this.groupBox5.Location = new System.Drawing.Point(492, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 114);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AnalogRead";
            // 
            // ExecuteAnalogRead
            // 
            this.ExecuteAnalogRead.Location = new System.Drawing.Point(9, 77);
            this.ExecuteAnalogRead.Name = "ExecuteAnalogRead";
            this.ExecuteAnalogRead.Size = new System.Drawing.Size(120, 29);
            this.ExecuteAnalogRead.TabIndex = 6;
            this.ExecuteAnalogRead.Text = "Execute";
            this.ExecuteAnalogRead.UseVisualStyleBackColor = true;
            this.ExecuteAnalogRead.Click += new System.EventHandler(this.ExecuteAnalogRead_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pin";
            // 
            // AnalogReadPinSel
            // 
            this.AnalogReadPinSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnalogReadPinSel.FormattingEnabled = true;
            this.AnalogReadPinSel.Items.AddRange(new object[] {
            "A0"});
            this.AnalogReadPinSel.Location = new System.Drawing.Point(10, 46);
            this.AnalogReadPinSel.MaxDropDownItems = 2;
            this.AnalogReadPinSel.MaxLength = 2;
            this.AnalogReadPinSel.Name = "AnalogReadPinSel";
            this.AnalogReadPinSel.Size = new System.Drawing.Size(55, 21);
            this.AnalogReadPinSel.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.AnalogWriteValue);
            this.groupBox6.Controls.Add(this.ExecuteAnalogWrite);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.AnalogWritePinSel);
            this.groupBox6.Location = new System.Drawing.Point(323, 11);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(161, 114);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "AnalogWrite";
            // 
            // AnalogWriteValue
            // 
            this.AnalogWriteValue.Location = new System.Drawing.Point(72, 46);
            this.AnalogWriteValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AnalogWriteValue.Name = "AnalogWriteValue";
            this.AnalogWriteValue.Size = new System.Drawing.Size(78, 20);
            this.AnalogWriteValue.TabIndex = 7;
            this.AnalogWriteValue.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // ExecuteAnalogWrite
            // 
            this.ExecuteAnalogWrite.Location = new System.Drawing.Point(11, 77);
            this.ExecuteAnalogWrite.Name = "ExecuteAnalogWrite";
            this.ExecuteAnalogWrite.Size = new System.Drawing.Size(139, 29);
            this.ExecuteAnalogWrite.TabIndex = 6;
            this.ExecuteAnalogWrite.Text = "Execute";
            this.ExecuteAnalogWrite.UseVisualStyleBackColor = true;
            this.ExecuteAnalogWrite.Click += new System.EventHandler(this.ExecuteAnalogWrite_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Pin";
            // 
            // AnalogWritePinSel
            // 
            this.AnalogWritePinSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnalogWritePinSel.FormattingEnabled = true;
            this.AnalogWritePinSel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AnalogWritePinSel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.AnalogWritePinSel.Location = new System.Drawing.Point(10, 46);
            this.AnalogWritePinSel.MaxDropDownItems = 2;
            this.AnalogWritePinSel.MaxLength = 2;
            this.AnalogWritePinSel.Name = "AnalogWritePinSel";
            this.AnalogWritePinSel.Size = new System.Drawing.Size(52, 21);
            this.AnalogWritePinSel.TabIndex = 1;
            // 
            // ResponsePanel
            // 
            this.ResponsePanel.Controls.Add(this.Response);
            this.ResponsePanel.Location = new System.Drawing.Point(12, 352);
            this.ResponsePanel.Name = "ResponsePanel";
            this.ResponsePanel.Size = new System.Drawing.Size(657, 84);
            this.ResponsePanel.TabIndex = 5;
            this.ResponsePanel.TabStop = false;
            this.ResponsePanel.Text = "Response";
            // 
            // Response
            // 
            this.Response.Location = new System.Drawing.Point(9, 14);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(639, 66);
            this.Response.TabIndex = 2;
            this.Response.Text = "- - - - - -";
            this.Response.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 153);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GPIO";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 127);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UART";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.SerialWriteReadTill);
            this.groupBox11.Controls.Add(this.label14);
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.SerialWriteReadData);
            this.groupBox11.Controls.Add(this.ExecuteSerialWriteRead);
            this.groupBox11.Location = new System.Drawing.Point(418, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(210, 114);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "SerialWriteRead";
            // 
            // SerialWriteReadTill
            // 
            this.SerialWriteReadTill.Location = new System.Drawing.Point(143, 42);
            this.SerialWriteReadTill.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.SerialWriteReadTill.Name = "SerialWriteReadTill";
            this.SerialWriteReadTill.Size = new System.Drawing.Size(58, 20);
            this.SerialWriteReadTill.TabIndex = 10;
            this.SerialWriteReadTill.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(140, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Till";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Data";
            // 
            // SerialWriteReadData
            // 
            this.SerialWriteReadData.Location = new System.Drawing.Point(11, 37);
            this.SerialWriteReadData.Name = "SerialWriteReadData";
            this.SerialWriteReadData.Size = new System.Drawing.Size(126, 30);
            this.SerialWriteReadData.TabIndex = 7;
            this.SerialWriteReadData.Text = "";
            // 
            // ExecuteSerialWriteRead
            // 
            this.ExecuteSerialWriteRead.Location = new System.Drawing.Point(10, 77);
            this.ExecuteSerialWriteRead.Name = "ExecuteSerialWriteRead";
            this.ExecuteSerialWriteRead.Size = new System.Drawing.Size(192, 29);
            this.ExecuteSerialWriteRead.TabIndex = 6;
            this.ExecuteSerialWriteRead.Text = "Execute";
            this.ExecuteSerialWriteRead.UseVisualStyleBackColor = true;
            this.ExecuteSerialWriteRead.Click += new System.EventHandler(this.ExecuteSerialWriteRead_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.SerialReadTill);
            this.groupBox10.Controls.Add(this.ExecuteSerialRead);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Location = new System.Drawing.Point(301, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(110, 114);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "SerialRead";
            // 
            // SerialReadTill
            // 
            this.SerialReadTill.Location = new System.Drawing.Point(13, 43);
            this.SerialReadTill.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.SerialReadTill.Name = "SerialReadTill";
            this.SerialReadTill.Size = new System.Drawing.Size(68, 20);
            this.SerialReadTill.TabIndex = 8;
            this.SerialReadTill.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ExecuteSerialRead
            // 
            this.ExecuteSerialRead.Location = new System.Drawing.Point(11, 77);
            this.ExecuteSerialRead.Name = "ExecuteSerialRead";
            this.ExecuteSerialRead.Size = new System.Drawing.Size(87, 29);
            this.ExecuteSerialRead.TabIndex = 6;
            this.ExecuteSerialRead.Text = "Execute";
            this.ExecuteSerialRead.UseVisualStyleBackColor = true;
            this.ExecuteSerialRead.Click += new System.EventHandler(this.ExecuteSerialRead_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Till";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.SerialWriteData);
            this.groupBox9.Controls.Add(this.ExecuteSerialWrite);
            this.groupBox9.Location = new System.Drawing.Point(126, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(169, 114);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "SerialWrite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data";
            // 
            // SerialWriteData
            // 
            this.SerialWriteData.Location = new System.Drawing.Point(11, 37);
            this.SerialWriteData.Name = "SerialWriteData";
            this.SerialWriteData.Size = new System.Drawing.Size(146, 29);
            this.SerialWriteData.TabIndex = 7;
            this.SerialWriteData.Text = "";
            // 
            // ExecuteSerialWrite
            // 
            this.ExecuteSerialWrite.Location = new System.Drawing.Point(11, 77);
            this.ExecuteSerialWrite.Name = "ExecuteSerialWrite";
            this.ExecuteSerialWrite.Size = new System.Drawing.Size(148, 29);
            this.ExecuteSerialWrite.TabIndex = 6;
            this.ExecuteSerialWrite.Text = "Execute";
            this.ExecuteSerialWrite.UseVisualStyleBackColor = true;
            this.ExecuteSerialWrite.Click += new System.EventHandler(this.ExecuteSerialWrite_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ExecuteSerialBegin);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.BaudRateSel);
            this.groupBox8.Location = new System.Drawing.Point(9, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(110, 114);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "SerialBegin";
            // 
            // ExecuteSerialBegin
            // 
            this.ExecuteSerialBegin.Location = new System.Drawing.Point(11, 77);
            this.ExecuteSerialBegin.Name = "ExecuteSerialBegin";
            this.ExecuteSerialBegin.Size = new System.Drawing.Size(87, 29);
            this.ExecuteSerialBegin.TabIndex = 6;
            this.ExecuteSerialBegin.Text = "Execute";
            this.ExecuteSerialBegin.UseVisualStyleBackColor = true;
            this.ExecuteSerialBegin.Click += new System.EventHandler(this.ExecuteSerialBegin_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Baud Rate";
            // 
            // BaudRateSel
            // 
            this.BaudRateSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateSel.FormattingEnabled = true;
            this.BaudRateSel.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200"});
            this.BaudRateSel.Location = new System.Drawing.Point(12, 45);
            this.BaudRateSel.MaxDropDownItems = 2;
            this.BaudRateSel.MaxLength = 2;
            this.BaudRateSel.Name = "BaudRateSel";
            this.BaudRateSel.Size = new System.Drawing.Size(71, 21);
            this.BaudRateSel.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox14);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(636, 127);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Utility";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.ExecuteRestart);
            this.groupBox14.Location = new System.Drawing.Point(426, 9);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(202, 111);
            this.groupBox14.TabIndex = 8;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Restart";
            // 
            // ExecuteRestart
            // 
            this.ExecuteRestart.Location = new System.Drawing.Point(33, 42);
            this.ExecuteRestart.Name = "ExecuteRestart";
            this.ExecuteRestart.Size = new System.Drawing.Size(139, 36);
            this.ExecuteRestart.TabIndex = 6;
            this.ExecuteRestart.Text = "Execute";
            this.ExecuteRestart.UseVisualStyleBackColor = true;
            this.ExecuteRestart.Click += new System.EventHandler(this.ExecuteRestart_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.ExecuteIsOnline);
            this.groupBox13.Location = new System.Drawing.Point(217, 9);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(202, 111);
            this.groupBox13.TabIndex = 7;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "IsOnline";
            // 
            // ExecuteIsOnline
            // 
            this.ExecuteIsOnline.Location = new System.Drawing.Point(31, 42);
            this.ExecuteIsOnline.Name = "ExecuteIsOnline";
            this.ExecuteIsOnline.Size = new System.Drawing.Size(139, 36);
            this.ExecuteIsOnline.TabIndex = 6;
            this.ExecuteIsOnline.Text = "Execute";
            this.ExecuteIsOnline.UseVisualStyleBackColor = true;
            this.ExecuteIsOnline.Click += new System.EventHandler(this.ExecuteIsOnline_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.ExecuteGetDeviceVersion);
            this.groupBox12.Location = new System.Drawing.Point(8, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(202, 114);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "GetDeviceVersion";
            // 
            // ExecuteGetDeviceVersion
            // 
            this.ExecuteGetDeviceVersion.Location = new System.Drawing.Point(32, 45);
            this.ExecuteGetDeviceVersion.Name = "ExecuteGetDeviceVersion";
            this.ExecuteGetDeviceVersion.Size = new System.Drawing.Size(139, 36);
            this.ExecuteGetDeviceVersion.TabIndex = 6;
            this.ExecuteGetDeviceVersion.Text = "Execute";
            this.ExecuteGetDeviceVersion.UseVisualStyleBackColor = true;
            this.ExecuteGetDeviceVersion.Click += new System.EventHandler(this.ExecuteGetDeviceVersion_Click);
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Controls.Add(this.tabControl1);
            this.OperationsPanel.Location = new System.Drawing.Point(12, 108);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(657, 182);
            this.OperationsPanel.TabIndex = 5;
            this.OperationsPanel.TabStop = false;
            this.OperationsPanel.Text = "Operations";
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Silver;
            this.Status.Location = new System.Drawing.Point(0, 443);
            this.Status.Name = "Status";
            this.Status.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.Status.Size = new System.Drawing.Size(680, 20);
            this.Status.TabIndex = 6;
            this.Status.Text = "Ready";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RequestUrlPanel
            // 
            this.RequestUrlPanel.Controls.Add(this.CopyButton);
            this.RequestUrlPanel.Controls.Add(this.RequestURL);
            this.RequestUrlPanel.Location = new System.Drawing.Point(12, 296);
            this.RequestUrlPanel.Name = "RequestUrlPanel";
            this.RequestUrlPanel.Size = new System.Drawing.Size(657, 53);
            this.RequestUrlPanel.TabIndex = 6;
            this.RequestUrlPanel.TabStop = false;
            this.RequestUrlPanel.Text = "Request URL";
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(587, 19);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(62, 24);
            this.CopyButton.TabIndex = 7;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // RequestURL
            // 
            this.RequestURL.Location = new System.Drawing.Point(9, 21);
            this.RequestURL.Name = "RequestURL";
            this.RequestURL.ReadOnly = true;
            this.RequestURL.Size = new System.Drawing.Size(572, 20);
            this.RequestURL.TabIndex = 4;
            this.RequestURL.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 463);
            this.Controls.Add(this.RequestUrlPanel);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ResponsePanel);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.CredentialsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolt IoT .NET Library Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CredentialsPanel.ResumeLayout(false);
            this.CredentialsPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogWriteValue)).EndInit();
            this.ResponsePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerialWriteReadTill)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerialReadTill)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.OperationsPanel.ResumeLayout(false);
            this.RequestUrlPanel.ResumeLayout(false);
            this.RequestUrlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox DeviceId;
        private System.Windows.Forms.TextBox ApiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox CredentialsPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ExecuteDigitalWrite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DigitalWritePinSel;
        private System.Windows.Forms.ComboBox DigitalWriteStateSel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ExecuteDigitalRead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DigitalReadPinSel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button ExecuteAnalogRead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AnalogReadPinSel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown AnalogWriteValue;
        private System.Windows.Forms.Button ExecuteAnalogWrite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AnalogWritePinSel;
        private System.Windows.Forms.GroupBox ResponsePanel;
        private System.Windows.Forms.Label Response;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox OperationsPanel;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button ExecuteSerialBegin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox BaudRateSel;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.NumericUpDown SerialWriteReadTill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox SerialWriteReadData;
        private System.Windows.Forms.Button ExecuteSerialWriteRead;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.NumericUpDown SerialReadTill;
        private System.Windows.Forms.Button ExecuteSerialRead;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox SerialWriteData;
        private System.Windows.Forms.Button ExecuteSerialWrite;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button ExecuteGetDeviceVersion;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button ExecuteIsOnline;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button ExecuteRestart;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.GroupBox RequestUrlPanel;
        private System.Windows.Forms.TextBox RequestURL;
        private System.Windows.Forms.Button CopyButton;
    }
}

