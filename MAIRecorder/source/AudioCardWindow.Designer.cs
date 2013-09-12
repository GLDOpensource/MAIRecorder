namespace MAIRecorder {
    partial class AudioCardWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ucAudioCard4ChannelSettings1 = new Goldammer.Controls.AudioCard.ucAudioCard4ChannelSettings();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSamplerate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOutputRate = new System.Windows.Forms.ComboBox();
            this.groupBoxChannelConfig = new System.Windows.Forms.GroupBox();
            this.buttonConfigDA1 = new System.Windows.Forms.Button();
            this.buttonConfigDA0 = new System.Windows.Forms.Button();
            this.buttonConfigCT1 = new System.Windows.Forms.Button();
            this.buttonConfigCT0 = new System.Windows.Forms.Button();
            this.checkBoxDA1 = new System.Windows.Forms.CheckBox();
            this.checkBoxDA0 = new System.Windows.Forms.CheckBox();
            this.checkBoxCT1 = new System.Windows.Forms.CheckBox();
            this.checkBoxCT0 = new System.Windows.Forms.CheckBox();
            this.checkBoxAD3 = new System.Windows.Forms.CheckBox();
            this.checkBoxAD2 = new System.Windows.Forms.CheckBox();
            this.checkBoxAD1 = new System.Windows.Forms.CheckBox();
            this.checkBoxAD0 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAFFMatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tDMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPCServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRecTarget = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxRECORD = new System.Windows.Forms.CheckBox();
            this.checkBoxPREV = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxCT0 = new System.Windows.Forms.TextBox();
            this.textBoxCT1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxLoopBack = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioButtonRMS = new System.Windows.Forms.RadioButton();
            this.radioButtonCharts = new System.Windows.Forms.RadioButton();
            this.groupBoxChannelConfig.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucAudioCard4ChannelSettings1
            // 
            this.ucAudioCard4ChannelSettings1.Location = new System.Drawing.Point(7, 24);
            this.ucAudioCard4ChannelSettings1.MyDevice = null;
            this.ucAudioCard4ChannelSettings1.Name = "ucAudioCard4ChannelSettings1";
            this.ucAudioCard4ChannelSettings1.Size = new System.Drawing.Size(715, 254);
            this.ucAudioCard4ChannelSettings1.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Hz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Samlperate";
            // 
            // comboBoxSamplerate
            // 
            this.comboBoxSamplerate.FormattingEnabled = true;
            this.comboBoxSamplerate.Items.AddRange(new object[] {
            " 48000",
            " 96000",
            "192000"});
            this.comboBoxSamplerate.Location = new System.Drawing.Point(422, 308);
            this.comboBoxSamplerate.Name = "comboBoxSamplerate";
            this.comboBoxSamplerate.Size = new System.Drawing.Size(72, 21);
            this.comboBoxSamplerate.TabIndex = 45;
            this.comboBoxSamplerate.Text = "96000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Output Rate";
            // 
            // comboBoxOutputRate
            // 
            this.comboBoxOutputRate.FormattingEnabled = true;
            this.comboBoxOutputRate.Items.AddRange(new object[] {
            " 48000",
            " 96000",
            "192000"});
            this.comboBoxOutputRate.Location = new System.Drawing.Point(422, 335);
            this.comboBoxOutputRate.Name = "comboBoxOutputRate";
            this.comboBoxOutputRate.Size = new System.Drawing.Size(72, 21);
            this.comboBoxOutputRate.TabIndex = 48;
            this.comboBoxOutputRate.Text = "96000";
            // 
            // groupBoxChannelConfig
            // 
            this.groupBoxChannelConfig.Controls.Add(this.buttonConfigDA1);
            this.groupBoxChannelConfig.Controls.Add(this.buttonConfigDA0);
            this.groupBoxChannelConfig.Controls.Add(this.buttonConfigCT1);
            this.groupBoxChannelConfig.Controls.Add(this.buttonConfigCT0);
            this.groupBoxChannelConfig.Controls.Add(this.checkBoxDA1);
            this.groupBoxChannelConfig.Controls.Add(this.checkBoxDA0);
            this.groupBoxChannelConfig.Controls.Add(this.checkBoxCT1);
            this.groupBoxChannelConfig.Controls.Add(this.checkBoxCT0);
            this.groupBoxChannelConfig.Controls.Add(this.checkBoxAD3);
            this.groupBoxChannelConfig.Controls.Add(this.checkBoxAD2);
            this.groupBoxChannelConfig.Controls.Add(this.checkBoxAD1);
            this.groupBoxChannelConfig.Controls.Add(this.checkBoxAD0);
            this.groupBoxChannelConfig.Location = new System.Drawing.Point(12, 287);
            this.groupBoxChannelConfig.Name = "groupBoxChannelConfig";
            this.groupBoxChannelConfig.Size = new System.Drawing.Size(188, 116);
            this.groupBoxChannelConfig.TabIndex = 51;
            this.groupBoxChannelConfig.TabStop = false;
            this.groupBoxChannelConfig.Text = "Active Channels";
            // 
            // buttonConfigDA1
            // 
            this.buttonConfigDA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigDA1.Location = new System.Drawing.Point(129, 88);
            this.buttonConfigDA1.Name = "buttonConfigDA1";
            this.buttonConfigDA1.Size = new System.Drawing.Size(41, 17);
            this.buttonConfigDA1.TabIndex = 55;
            this.buttonConfigDA1.Text = "Config ...";
            this.buttonConfigDA1.UseVisualStyleBackColor = true;
            this.buttonConfigDA1.Click += new System.EventHandler(this.buttonConfigDA1_Click);
            // 
            // buttonConfigDA0
            // 
            this.buttonConfigDA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigDA0.Location = new System.Drawing.Point(129, 66);
            this.buttonConfigDA0.Name = "buttonConfigDA0";
            this.buttonConfigDA0.Size = new System.Drawing.Size(41, 17);
            this.buttonConfigDA0.TabIndex = 54;
            this.buttonConfigDA0.Text = "Config ...";
            this.buttonConfigDA0.UseVisualStyleBackColor = true;
            this.buttonConfigDA0.Click += new System.EventHandler(this.buttonConfigDA0_Click);
            // 
            // buttonConfigCT1
            // 
            this.buttonConfigCT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigCT1.Location = new System.Drawing.Point(129, 43);
            this.buttonConfigCT1.Name = "buttonConfigCT1";
            this.buttonConfigCT1.Size = new System.Drawing.Size(41, 17);
            this.buttonConfigCT1.TabIndex = 53;
            this.buttonConfigCT1.Text = "Config ...";
            this.buttonConfigCT1.UseVisualStyleBackColor = true;
            this.buttonConfigCT1.Click += new System.EventHandler(this.buttonConfigCT1_Click);
            // 
            // buttonConfigCT0
            // 
            this.buttonConfigCT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigCT0.Location = new System.Drawing.Point(129, 19);
            this.buttonConfigCT0.Name = "buttonConfigCT0";
            this.buttonConfigCT0.Size = new System.Drawing.Size(41, 17);
            this.buttonConfigCT0.TabIndex = 52;
            this.buttonConfigCT0.Text = "Config ...";
            this.buttonConfigCT0.UseVisualStyleBackColor = true;
            this.buttonConfigCT0.Click += new System.EventHandler(this.buttonConfigCT0_Click);
            // 
            // checkBoxDA1
            // 
            this.checkBoxDA1.AutoSize = true;
            this.checkBoxDA1.Location = new System.Drawing.Point(74, 88);
            this.checkBoxDA1.Name = "checkBoxDA1";
            this.checkBoxDA1.Size = new System.Drawing.Size(50, 17);
            this.checkBoxDA1.TabIndex = 9;
            this.checkBoxDA1.Text = "DA 1";
            this.checkBoxDA1.UseVisualStyleBackColor = true;
            this.checkBoxDA1.CheckedChanged += new System.EventHandler(this.DaCheckChanged);
            // 
            // checkBoxDA0
            // 
            this.checkBoxDA0.AutoSize = true;
            this.checkBoxDA0.Location = new System.Drawing.Point(74, 65);
            this.checkBoxDA0.Name = "checkBoxDA0";
            this.checkBoxDA0.Size = new System.Drawing.Size(50, 17);
            this.checkBoxDA0.TabIndex = 8;
            this.checkBoxDA0.Text = "DA 0";
            this.checkBoxDA0.UseVisualStyleBackColor = true;
            this.checkBoxDA0.CheckedChanged += new System.EventHandler(this.DaCheckChanged);
            // 
            // checkBoxCT1
            // 
            this.checkBoxCT1.AutoSize = true;
            this.checkBoxCT1.Location = new System.Drawing.Point(74, 43);
            this.checkBoxCT1.Name = "checkBoxCT1";
            this.checkBoxCT1.Size = new System.Drawing.Size(49, 17);
            this.checkBoxCT1.TabIndex = 5;
            this.checkBoxCT1.Text = "CT 1";
            this.checkBoxCT1.UseVisualStyleBackColor = true;
            this.checkBoxCT1.CheckedChanged += new System.EventHandler(this.CTChackChanged);
            // 
            // checkBoxCT0
            // 
            this.checkBoxCT0.AutoSize = true;
            this.checkBoxCT0.Location = new System.Drawing.Point(74, 20);
            this.checkBoxCT0.Name = "checkBoxCT0";
            this.checkBoxCT0.Size = new System.Drawing.Size(49, 17);
            this.checkBoxCT0.TabIndex = 4;
            this.checkBoxCT0.Text = "CT 0";
            this.checkBoxCT0.UseVisualStyleBackColor = true;
            this.checkBoxCT0.CheckedChanged += new System.EventHandler(this.CTChackChanged);
            // 
            // checkBoxAD3
            // 
            this.checkBoxAD3.AutoSize = true;
            this.checkBoxAD3.Checked = true;
            this.checkBoxAD3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAD3.Location = new System.Drawing.Point(18, 88);
            this.checkBoxAD3.Name = "checkBoxAD3";
            this.checkBoxAD3.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAD3.TabIndex = 3;
            this.checkBoxAD3.Text = "AD 3";
            this.checkBoxAD3.UseVisualStyleBackColor = true;
            this.checkBoxAD3.CheckedChanged += new System.EventHandler(this.ADCheckChanged);
            // 
            // checkBoxAD2
            // 
            this.checkBoxAD2.AutoSize = true;
            this.checkBoxAD2.Checked = true;
            this.checkBoxAD2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAD2.Location = new System.Drawing.Point(18, 65);
            this.checkBoxAD2.Name = "checkBoxAD2";
            this.checkBoxAD2.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAD2.TabIndex = 2;
            this.checkBoxAD2.Text = "AD 2";
            this.checkBoxAD2.UseVisualStyleBackColor = true;
            this.checkBoxAD2.CheckedChanged += new System.EventHandler(this.ADCheckChanged);
            // 
            // checkBoxAD1
            // 
            this.checkBoxAD1.AutoSize = true;
            this.checkBoxAD1.Checked = true;
            this.checkBoxAD1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAD1.Location = new System.Drawing.Point(18, 42);
            this.checkBoxAD1.Name = "checkBoxAD1";
            this.checkBoxAD1.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAD1.TabIndex = 1;
            this.checkBoxAD1.Text = "AD 1";
            this.checkBoxAD1.UseVisualStyleBackColor = true;
            this.checkBoxAD1.CheckedChanged += new System.EventHandler(this.ADCheckChanged);
            // 
            // checkBoxAD0
            // 
            this.checkBoxAD0.AutoSize = true;
            this.checkBoxAD0.Checked = true;
            this.checkBoxAD0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAD0.Location = new System.Drawing.Point(18, 19);
            this.checkBoxAD0.Name = "checkBoxAD0";
            this.checkBoxAD0.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAD0.TabIndex = 0;
            this.checkBoxAD0.Text = "AD 0";
            this.checkBoxAD0.UseVisualStyleBackColor = true;
            this.checkBoxAD0.CheckedChanged += new System.EventHandler(this.ADCheckChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rAWToolStripMenuItem,
            this.cSVToolStripMenuItem,
            this.tAFFMatToolStripMenuItem,
            this.tDMSToolStripMenuItem,
            this.wAVToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.oPCServerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.fileToolStripMenuItem.Text = "Output File  ";
            // 
            // rAWToolStripMenuItem
            // 
            this.rAWToolStripMenuItem.Name = "rAWToolStripMenuItem";
            this.rAWToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.rAWToolStripMenuItem.Text = "RAW ...";
            this.rAWToolStripMenuItem.Click += new System.EventHandler(this.tDMSToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cSVToolStripMenuItem.Text = "CSV ...";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.tDMSToolStripMenuItem_Click);
            // 
            // tAFFMatToolStripMenuItem
            // 
            this.tAFFMatToolStripMenuItem.Name = "tAFFMatToolStripMenuItem";
            this.tAFFMatToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.tAFFMatToolStripMenuItem.Text = "TAFF Mat ...";
            this.tAFFMatToolStripMenuItem.Click += new System.EventHandler(this.tDMSToolStripMenuItem_Click);
            // 
            // tDMSToolStripMenuItem
            // 
            this.tDMSToolStripMenuItem.Name = "tDMSToolStripMenuItem";
            this.tDMSToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.tDMSToolStripMenuItem.Text = "TDMS ...";
            this.tDMSToolStripMenuItem.Click += new System.EventHandler(this.tDMSToolStripMenuItem_Click);
            // 
            // wAVToolStripMenuItem
            // 
            this.wAVToolStripMenuItem.Name = "wAVToolStripMenuItem";
            this.wAVToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.wAVToolStripMenuItem.Text = "WAV ...";
            this.wAVToolStripMenuItem.Click += new System.EventHandler(this.tDMSToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.databaseToolStripMenuItem.Text = "Database ...";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.tDMSToolStripMenuItem_Click);
            // 
            // oPCServerToolStripMenuItem
            // 
            this.oPCServerToolStripMenuItem.Enabled = false;
            this.oPCServerToolStripMenuItem.Name = "oPCServerToolStripMenuItem";
            this.oPCServerToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.oPCServerToolStripMenuItem.Text = "OPC Server ...";
            // 
            // tbRecTarget
            // 
            this.tbRecTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecTarget.Location = new System.Drawing.Point(607, 377);
            this.tbRecTarget.Name = "tbRecTarget";
            this.tbRecTarget.ReadOnly = true;
            this.tbRecTarget.Size = new System.Drawing.Size(92, 20);
            this.tbRecTarget.TabIndex = 55;
            this.tbRecTarget.Text = "no Output selected";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "record to:";
            // 
            // checkBoxRECORD
            // 
            this.checkBoxRECORD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRECORD.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxRECORD.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxRECORD.Enabled = false;
            this.checkBoxRECORD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBoxRECORD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxRECORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRECORD.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxRECORD.Location = new System.Drawing.Point(544, 342);
            this.checkBoxRECORD.Name = "checkBoxRECORD";
            this.checkBoxRECORD.Size = new System.Drawing.Size(155, 31);
            this.checkBoxRECORD.TabIndex = 53;
            this.checkBoxRECORD.Text = "RECORD AD";
            this.checkBoxRECORD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxRECORD.UseVisualStyleBackColor = false;
            this.checkBoxRECORD.CheckedChanged += new System.EventHandler(this.checkBoxRECORD_CheckedChanged);
            // 
            // checkBoxPREV
            // 
            this.checkBoxPREV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPREV.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPREV.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxPREV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBoxPREV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxPREV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPREV.ForeColor = System.Drawing.Color.OliveDrab;
            this.checkBoxPREV.Location = new System.Drawing.Point(544, 291);
            this.checkBoxPREV.Name = "checkBoxPREV";
            this.checkBoxPREV.Size = new System.Drawing.Size(155, 42);
            this.checkBoxPREV.TabIndex = 56;
            this.checkBoxPREV.Text = "RUN ";
            this.checkBoxPREV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPREV.UseVisualStyleBackColor = false;
            this.checkBoxPREV.CheckedChanged += new System.EventHandler(this.checkBoxPREV_CheckedChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea3.Name = "ChartArea3";
            chartArea4.Name = "ChartArea4";
            chartArea5.Name = "ChartArea5";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(0, 409);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(722, 170);
            this.chart1.TabIndex = 57;
            this.chart1.Text = "chart1";
            // 
            // textBoxCT0
            // 
            this.textBoxCT0.BackColor = System.Drawing.Color.White;
            this.textBoxCT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCT0.Location = new System.Drawing.Point(206, 305);
            this.textBoxCT0.Name = "textBoxCT0";
            this.textBoxCT0.ReadOnly = true;
            this.textBoxCT0.Size = new System.Drawing.Size(113, 24);
            this.textBoxCT0.TabIndex = 66;
            // 
            // textBoxCT1
            // 
            this.textBoxCT1.BackColor = System.Drawing.Color.White;
            this.textBoxCT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCT1.Location = new System.Drawing.Point(206, 332);
            this.textBoxCT1.Name = "textBoxCT1";
            this.textBoxCT1.ReadOnly = true;
            this.textBoxCT1.Size = new System.Drawing.Size(113, 24);
            this.textBoxCT1.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "ConterValues:";
            // 
            // checkBoxLoopBack
            // 
            this.checkBoxLoopBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLoopBack.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxLoopBack.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxLoopBack.Enabled = false;
            this.checkBoxLoopBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBoxLoopBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxLoopBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLoopBack.ForeColor = System.Drawing.Color.OliveDrab;
            this.checkBoxLoopBack.Location = new System.Drawing.Point(206, 360);
            this.checkBoxLoopBack.Name = "checkBoxLoopBack";
            this.checkBoxLoopBack.Size = new System.Drawing.Size(155, 42);
            this.checkBoxLoopBack.TabIndex = 70;
            this.checkBoxLoopBack.Text = "loop back \r\nAD 0&1 to DA 0&1";
            this.checkBoxLoopBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxLoopBack.UseVisualStyleBackColor = false;
            this.checkBoxLoopBack.CheckedChanged += new System.EventHandler(this.checkBoxLoopBack_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButtonRMS
            // 
            this.radioButtonRMS.AutoSize = true;
            this.radioButtonRMS.Checked = true;
            this.radioButtonRMS.Location = new System.Drawing.Point(395, 362);
            this.radioButtonRMS.Name = "radioButtonRMS";
            this.radioButtonRMS.Size = new System.Drawing.Size(75, 17);
            this.radioButtonRMS.TabIndex = 71;
            this.radioButtonRMS.TabStop = true;
            this.radioButtonRMS.Text = "RMS View";
            this.radioButtonRMS.UseVisualStyleBackColor = true;
            this.radioButtonRMS.CheckedChanged += new System.EventHandler(this.radioButtonRMS_CheckedChanged);
            // 
            // radioButtonCharts
            // 
            this.radioButtonCharts.AutoSize = true;
            this.radioButtonCharts.Location = new System.Drawing.Point(395, 385);
            this.radioButtonCharts.Name = "radioButtonCharts";
            this.radioButtonCharts.Size = new System.Drawing.Size(76, 17);
            this.radioButtonCharts.TabIndex = 72;
            this.radioButtonCharts.Text = "WAV View";
            this.radioButtonCharts.UseVisualStyleBackColor = true;
            this.radioButtonCharts.CheckedChanged += new System.EventHandler(this.radioButtonRMS_CheckedChanged);
            // 
            // AudioCardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 582);
            this.Controls.Add(this.radioButtonCharts);
            this.Controls.Add(this.radioButtonRMS);
            this.Controls.Add(this.checkBoxPREV);
            this.Controls.Add(this.checkBoxLoopBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCT1);
            this.Controls.Add(this.textBoxCT0);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tbRecTarget);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxRECORD);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxChannelConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxOutputRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSamplerate);
            this.Controls.Add(this.ucAudioCard4ChannelSettings1);
            this.MaximumSize = new System.Drawing.Size(730, 753);
            this.Name = "AudioCardWindow";
            this.ShowIcon = false;
            this.Text = "AudioCardWindow";
            this.Load += new System.EventHandler(this.AudioCardWindow_Load);
            this.groupBoxChannelConfig.ResumeLayout(false);
            this.groupBoxChannelConfig.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Goldammer.Controls.AudioCard.ucAudioCard4ChannelSettings ucAudioCard4ChannelSettings1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSamplerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOutputRate;
        private System.Windows.Forms.GroupBox groupBoxChannelConfig;
        private System.Windows.Forms.CheckBox checkBoxAD3;
        private System.Windows.Forms.CheckBox checkBoxAD2;
        private System.Windows.Forms.CheckBox checkBoxAD1;
        private System.Windows.Forms.CheckBox checkBoxAD0;
        private System.Windows.Forms.CheckBox checkBoxDA1;
        private System.Windows.Forms.CheckBox checkBoxDA0;
        private System.Windows.Forms.CheckBox checkBoxCT1;
        private System.Windows.Forms.CheckBox checkBoxCT0;
        private System.Windows.Forms.Button buttonConfigDA1;
        private System.Windows.Forms.Button buttonConfigDA0;
        private System.Windows.Forms.Button buttonConfigCT1;
        private System.Windows.Forms.Button buttonConfigCT0;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAFFMatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tDMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPCServerToolStripMenuItem;
        private System.Windows.Forms.TextBox tbRecTarget;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxRECORD;
        private System.Windows.Forms.CheckBox checkBoxPREV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxCT0;
        private System.Windows.Forms.TextBox textBoxCT1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxLoopBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButtonRMS;
        private System.Windows.Forms.RadioButton radioButtonCharts;
    }
}