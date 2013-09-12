namespace MAIRecorder {
    partial class CardWindow {
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
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.groupBoxPWM = new System.Windows.Forms.GroupBox();
            this.buttonPWM = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCTMeasure = new System.Windows.Forms.Button();
            this.buttonDAOutput = new System.Windows.Forms.Button();
            this.buttonMeasrement = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nudSRDA = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSRCT = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownADSamplerate = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUpdateCTPerm = new System.Windows.Forms.CheckBox();
            this.cbUpdateTTLPerm = new System.Windows.Forms.CheckBox();
            this.cbUpdateADPerm = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelAD = new System.Windows.Forms.Panel();
            this.bIEPE_OFF = new System.Windows.Forms.Button();
            this.bUpdateAD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flpADChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.splitterAD = new System.Windows.Forms.Splitter();
            this.panelDA = new System.Windows.Forms.Panel();
            this.groupBoxDARange = new System.Windows.Forms.GroupBox();
            this.radioButtonOnlyPosDA = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.flpDAChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.splitterDA = new System.Windows.Forms.Splitter();
            this.panelDIO = new System.Windows.Forms.Panel();
            this.bUpdateTTL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flpDIOChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.splitterDIO = new System.Windows.Forms.Splitter();
            this.panelCT = new System.Windows.Forms.Panel();
            this.bUpdateCT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.flpCT = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGeneral.SuspendLayout();
            this.groupBoxPWM.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSRDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSRCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownADSamplerate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelAD.SuspendLayout();
            this.panelDA.SuspendLayout();
            this.groupBoxDARange.SuspendLayout();
            this.panelDIO.SuspendLayout();
            this.panelCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.groupBoxPWM);
            this.panelGeneral.Controls.Add(this.groupBox2);
            this.panelGeneral.Controls.Add(this.groupBox1);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(742, 118);
            this.panelGeneral.TabIndex = 5;
            // 
            // groupBoxPWM
            // 
            this.groupBoxPWM.Controls.Add(this.buttonPWM);
            this.groupBoxPWM.Location = new System.Drawing.Point(612, 5);
            this.groupBoxPWM.Name = "groupBoxPWM";
            this.groupBoxPWM.Size = new System.Drawing.Size(118, 102);
            this.groupBoxPWM.TabIndex = 10;
            this.groupBoxPWM.TabStop = false;
            this.groupBoxPWM.Text = "Digital";
            // 
            // buttonPWM
            // 
            this.buttonPWM.Enabled = false;
            this.buttonPWM.Location = new System.Drawing.Point(6, 19);
            this.buttonPWM.Name = "buttonPWM";
            this.buttonPWM.Size = new System.Drawing.Size(106, 23);
            this.buttonPWM.TabIndex = 0;
            this.buttonPWM.Text = "PWM / FM ...";
            this.buttonPWM.UseVisualStyleBackColor = true;
            this.buttonPWM.Click += new System.EventHandler(this.buttonPWM_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCTMeasure);
            this.groupBox2.Controls.Add(this.buttonDAOutput);
            this.groupBox2.Controls.Add(this.buttonMeasrement);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nudSRDA);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nudSRCT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDownADSamplerate);
            this.groupBox2.Location = new System.Drawing.Point(222, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 102);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automatic Modes";
            // 
            // buttonCTMeasure
            // 
            this.buttonCTMeasure.Location = new System.Drawing.Point(248, 65);
            this.buttonCTMeasure.Name = "buttonCTMeasure";
            this.buttonCTMeasure.Size = new System.Drawing.Size(131, 23);
            this.buttonCTMeasure.TabIndex = 11;
            this.buttonCTMeasure.Text = "CT Measurement ...";
            this.buttonCTMeasure.UseVisualStyleBackColor = true;
            this.buttonCTMeasure.Click += new System.EventHandler(this.buttonCTMeasure_Click);
            // 
            // buttonDAOutput
            // 
            this.buttonDAOutput.Location = new System.Drawing.Point(248, 42);
            this.buttonDAOutput.Name = "buttonDAOutput";
            this.buttonDAOutput.Size = new System.Drawing.Size(131, 23);
            this.buttonDAOutput.TabIndex = 10;
            this.buttonDAOutput.Text = "DA Wave Generator ...";
            this.buttonDAOutput.UseVisualStyleBackColor = true;
            this.buttonDAOutput.Click += new System.EventHandler(this.buttonCardConfig_Click);
            // 
            // buttonMeasrement
            // 
            this.buttonMeasrement.Location = new System.Drawing.Point(248, 19);
            this.buttonMeasrement.Name = "buttonMeasrement";
            this.buttonMeasrement.Size = new System.Drawing.Size(131, 23);
            this.buttonMeasrement.TabIndex = 9;
            this.buttonMeasrement.Text = "AD Measurement...";
            this.buttonMeasrement.UseVisualStyleBackColor = true;
            this.buttonMeasrement.Click += new System.EventHandler(this.buttonMeasrement_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "DA Output Rate [Hz]";
            // 
            // nudSRDA
            // 
            this.nudSRDA.Location = new System.Drawing.Point(190, 45);
            this.nudSRDA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSRDA.Name = "nudSRDA";
            this.nudSRDA.Size = new System.Drawing.Size(52, 20);
            this.nudSRDA.TabIndex = 7;
            this.nudSRDA.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Counter Scanlist Samplerate [Hz]";
            // 
            // nudSRCT
            // 
            this.nudSRCT.Location = new System.Drawing.Point(190, 68);
            this.nudSRCT.Name = "nudSRCT";
            this.nudSRCT.Size = new System.Drawing.Size(52, 20);
            this.nudSRCT.TabIndex = 5;
            this.nudSRCT.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "AD/CT Samplerate [Hz]";
            // 
            // numericUpDownADSamplerate
            // 
            this.numericUpDownADSamplerate.Location = new System.Drawing.Point(190, 22);
            this.numericUpDownADSamplerate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownADSamplerate.Name = "numericUpDownADSamplerate";
            this.numericUpDownADSamplerate.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownADSamplerate.TabIndex = 3;
            this.numericUpDownADSamplerate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUpdateCTPerm);
            this.groupBox1.Controls.Add(this.cbUpdateTTLPerm);
            this.groupBox1.Controls.Add(this.cbUpdateADPerm);
            this.groupBox1.Controls.Add(this.checkBoxUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permanent Update";
            // 
            // cbUpdateCTPerm
            // 
            this.cbUpdateCTPerm.AutoSize = true;
            this.cbUpdateCTPerm.Location = new System.Drawing.Point(82, 53);
            this.cbUpdateCTPerm.Name = "cbUpdateCTPerm";
            this.cbUpdateCTPerm.Size = new System.Drawing.Size(116, 17);
            this.cbUpdateCTPerm.TabIndex = 10;
            this.cbUpdateCTPerm.Text = "Counter (SLOW !!!)";
            this.cbUpdateCTPerm.UseVisualStyleBackColor = true;
            // 
            // cbUpdateTTLPerm
            // 
            this.cbUpdateTTLPerm.AutoSize = true;
            this.cbUpdateTTLPerm.Checked = true;
            this.cbUpdateTTLPerm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpdateTTLPerm.Location = new System.Drawing.Point(82, 37);
            this.cbUpdateTTLPerm.Name = "cbUpdateTTLPerm";
            this.cbUpdateTTLPerm.Size = new System.Drawing.Size(74, 17);
            this.cbUpdateTTLPerm.TabIndex = 9;
            this.cbUpdateTTLPerm.Text = "TTL State";
            this.cbUpdateTTLPerm.UseVisualStyleBackColor = true;
            // 
            // cbUpdateADPerm
            // 
            this.cbUpdateADPerm.AutoSize = true;
            this.cbUpdateADPerm.Checked = true;
            this.cbUpdateADPerm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpdateADPerm.Location = new System.Drawing.Point(82, 20);
            this.cbUpdateADPerm.Name = "cbUpdateADPerm";
            this.cbUpdateADPerm.Size = new System.Drawing.Size(86, 17);
            this.cbUpdateADPerm.TabIndex = 8;
            this.cbUpdateADPerm.Text = "Analog Input";
            this.cbUpdateADPerm.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdate
            // 
            this.checkBoxUpdate.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxUpdate.AutoSize = true;
            this.checkBoxUpdate.Checked = true;
            this.checkBoxUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUpdate.Location = new System.Drawing.Point(12, 24);
            this.checkBoxUpdate.Name = "checkBoxUpdate";
            this.checkBoxUpdate.Size = new System.Drawing.Size(47, 23);
            this.checkBoxUpdate.TabIndex = 5;
            this.checkBoxUpdate.Text = "Active";
            this.checkBoxUpdate.UseVisualStyleBackColor = true;
            this.checkBoxUpdate.CheckedChanged += new System.EventHandler(this.checkBoxUpdate_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Update interval (ms):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(130, 76);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelAD
            // 
            this.panelAD.AutoSize = true;
            this.panelAD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAD.Controls.Add(this.bIEPE_OFF);
            this.panelAD.Controls.Add(this.bUpdateAD);
            this.panelAD.Controls.Add(this.label2);
            this.panelAD.Controls.Add(this.flpADChannels);
            this.panelAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAD.Location = new System.Drawing.Point(0, 118);
            this.panelAD.Name = "panelAD";
            this.panelAD.Size = new System.Drawing.Size(742, 119);
            this.panelAD.TabIndex = 6;
            // 
            // bIEPE_OFF
            // 
            this.bIEPE_OFF.Location = new System.Drawing.Point(21, 61);
            this.bIEPE_OFF.Name = "bIEPE_OFF";
            this.bIEPE_OFF.Size = new System.Drawing.Size(75, 23);
            this.bIEPE_OFF.TabIndex = 4;
            this.bIEPE_OFF.Text = "IEPE OFF";
            this.bIEPE_OFF.UseVisualStyleBackColor = true;
            this.bIEPE_OFF.Visible = false;
            this.bIEPE_OFF.Click += new System.EventHandler(this.bIEPE_OFF_Click);
            // 
            // bUpdateAD
            // 
            this.bUpdateAD.Location = new System.Drawing.Point(21, 32);
            this.bUpdateAD.Name = "bUpdateAD";
            this.bUpdateAD.Size = new System.Drawing.Size(75, 23);
            this.bUpdateAD.TabIndex = 3;
            this.bUpdateAD.Text = "Update";
            this.bUpdateAD.UseVisualStyleBackColor = true;
            this.bUpdateAD.Click += new System.EventHandler(this.bUpdateAD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Analog Input";
            // 
            // flpADChannels
            // 
            this.flpADChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flpADChannels.AutoScroll = true;
            this.flpADChannels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpADChannels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpADChannels.Location = new System.Drawing.Point(121, 4);
            this.flpADChannels.Name = "flpADChannels";
            this.flpADChannels.Size = new System.Drawing.Size(618, 111);
            this.flpADChannels.TabIndex = 2;
            // 
            // splitterAD
            // 
            this.splitterAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterAD.Location = new System.Drawing.Point(0, 237);
            this.splitterAD.Name = "splitterAD";
            this.splitterAD.Size = new System.Drawing.Size(742, 3);
            this.splitterAD.TabIndex = 7;
            this.splitterAD.TabStop = false;
            // 
            // panelDA
            // 
            this.panelDA.Controls.Add(this.groupBoxDARange);
            this.panelDA.Controls.Add(this.label3);
            this.panelDA.Controls.Add(this.flpDAChannels);
            this.panelDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDA.Location = new System.Drawing.Point(0, 240);
            this.panelDA.Name = "panelDA";
            this.panelDA.Size = new System.Drawing.Size(742, 144);
            this.panelDA.TabIndex = 8;
            this.panelDA.Visible = false;
            // 
            // groupBoxDARange
            // 
            this.groupBoxDARange.Controls.Add(this.radioButtonOnlyPosDA);
            this.groupBoxDARange.Controls.Add(this.radioButton1);
            this.groupBoxDARange.Enabled = false;
            this.groupBoxDARange.Location = new System.Drawing.Point(24, 50);
            this.groupBoxDARange.Name = "groupBoxDARange";
            this.groupBoxDARange.Size = new System.Drawing.Size(84, 68);
            this.groupBoxDARange.TabIndex = 3;
            this.groupBoxDARange.TabStop = false;
            this.groupBoxDARange.Text = "Range";
            // 
            // radioButtonOnlyPosDA
            // 
            this.radioButtonOnlyPosDA.AutoSize = true;
            this.radioButtonOnlyPosDA.Location = new System.Drawing.Point(6, 42);
            this.radioButtonOnlyPosDA.Name = "radioButtonOnlyPosDA";
            this.radioButtonOnlyPosDA.Size = new System.Drawing.Size(74, 17);
            this.radioButtonOnlyPosDA.TabIndex = 1;
            this.radioButtonOnlyPosDA.Text = "   0 .. 10 V";
            this.radioButtonOnlyPosDA.UseVisualStyleBackColor = true;
            this.radioButtonOnlyPosDA.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "- 10 .. 10 V";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Analog Output";
            // 
            // flpDAChannels
            // 
            this.flpDAChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDAChannels.AutoScroll = true;
            this.flpDAChannels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDAChannels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDAChannels.Location = new System.Drawing.Point(121, 4);
            this.flpDAChannels.Name = "flpDAChannels";
            this.flpDAChannels.Size = new System.Drawing.Size(618, 137);
            this.flpDAChannels.TabIndex = 2;
            // 
            // splitterDA
            // 
            this.splitterDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterDA.Location = new System.Drawing.Point(0, 384);
            this.splitterDA.Name = "splitterDA";
            this.splitterDA.Size = new System.Drawing.Size(742, 3);
            this.splitterDA.TabIndex = 9;
            this.splitterDA.TabStop = false;
            // 
            // panelDIO
            // 
            this.panelDIO.Controls.Add(this.bUpdateTTL);
            this.panelDIO.Controls.Add(this.label4);
            this.panelDIO.Controls.Add(this.flpDIOChannels);
            this.panelDIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDIO.Location = new System.Drawing.Point(0, 387);
            this.panelDIO.Name = "panelDIO";
            this.panelDIO.Size = new System.Drawing.Size(742, 183);
            this.panelDIO.TabIndex = 10;
            // 
            // bUpdateTTL
            // 
            this.bUpdateTTL.Location = new System.Drawing.Point(24, 52);
            this.bUpdateTTL.Name = "bUpdateTTL";
            this.bUpdateTTL.Size = new System.Drawing.Size(75, 23);
            this.bUpdateTTL.TabIndex = 4;
            this.bUpdateTTL.Text = "Update";
            this.bUpdateTTL.UseVisualStyleBackColor = true;
            this.bUpdateTTL.Click += new System.EventHandler(this.bUpdateTTL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Digital I/O";
            // 
            // flpDIOChannels
            // 
            this.flpDIOChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDIOChannels.AutoScroll = true;
            this.flpDIOChannels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDIOChannels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDIOChannels.Location = new System.Drawing.Point(121, 4);
            this.flpDIOChannels.Name = "flpDIOChannels";
            this.flpDIOChannels.Size = new System.Drawing.Size(618, 176);
            this.flpDIOChannels.TabIndex = 2;
            // 
            // splitterDIO
            // 
            this.splitterDIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterDIO.Location = new System.Drawing.Point(0, 570);
            this.splitterDIO.Name = "splitterDIO";
            this.splitterDIO.Size = new System.Drawing.Size(742, 3);
            this.splitterDIO.TabIndex = 11;
            this.splitterDIO.TabStop = false;
            // 
            // panelCT
            // 
            this.panelCT.Controls.Add(this.bUpdateCT);
            this.panelCT.Controls.Add(this.label5);
            this.panelCT.Controls.Add(this.flpCT);
            this.panelCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCT.Location = new System.Drawing.Point(0, 573);
            this.panelCT.Name = "panelCT";
            this.panelCT.Size = new System.Drawing.Size(742, 152);
            this.panelCT.TabIndex = 12;
            // 
            // bUpdateCT
            // 
            this.bUpdateCT.Location = new System.Drawing.Point(24, 41);
            this.bUpdateCT.Name = "bUpdateCT";
            this.bUpdateCT.Size = new System.Drawing.Size(75, 23);
            this.bUpdateCT.TabIndex = 5;
            this.bUpdateCT.Text = "Update";
            this.bUpdateCT.UseVisualStyleBackColor = true;
            this.bUpdateCT.Click += new System.EventHandler(this.bUpdateCT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Counter";
            // 
            // flpCT
            // 
            this.flpCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flpCT.AutoScroll = true;
            this.flpCT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCT.Location = new System.Drawing.Point(121, 4);
            this.flpCT.Name = "flpCT";
            this.flpCT.Size = new System.Drawing.Size(618, 145);
            this.flpCT.TabIndex = 2;
            // 
            // CardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 725);
            this.Controls.Add(this.panelCT);
            this.Controls.Add(this.splitterDIO);
            this.Controls.Add(this.panelDIO);
            this.Controls.Add(this.splitterDA);
            this.Controls.Add(this.panelDA);
            this.Controls.Add(this.splitterAD);
            this.Controls.Add(this.panelAD);
            this.Controls.Add(this.panelGeneral);
            this.Name = "CardWindow";
            this.ShowIcon = false;
            this.Text = "CardWindow";
            this.Load += new System.EventHandler(this.CardWindow_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CardWindow_FormClosed);
            this.panelGeneral.ResumeLayout(false);
            this.groupBoxPWM.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSRDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSRCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownADSamplerate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelAD.ResumeLayout(false);
            this.panelAD.PerformLayout();
            this.panelDA.ResumeLayout(false);
            this.panelDA.PerformLayout();
            this.groupBoxDARange.ResumeLayout(false);
            this.groupBoxDARange.PerformLayout();
            this.panelDIO.ResumeLayout(false);
            this.panelDIO.PerformLayout();
            this.panelCT.ResumeLayout(false);
            this.panelCT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBoxUpdate;
        public System.Windows.Forms.Panel panelGeneral;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel panelAD;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.FlowLayoutPanel flpADChannels;
        public System.Windows.Forms.Splitter splitterAD;
        public System.Windows.Forms.Panel panelDA;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.FlowLayoutPanel flpDAChannels;
        public System.Windows.Forms.Splitter splitterDA;
        public System.Windows.Forms.Panel panelDIO;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.FlowLayoutPanel flpDIOChannels;
        public System.Windows.Forms.Splitter splitterDIO;
        public System.Windows.Forms.Panel panelCT;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.FlowLayoutPanel flpCT;
        public System.Windows.Forms.GroupBox groupBoxDARange;
        public System.Windows.Forms.RadioButton radioButtonOnlyPosDA;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button buttonDAOutput;
        public System.Windows.Forms.Button buttonMeasrement;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown nudSRDA;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown nudSRCT;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown numericUpDownADSamplerate;
        public System.Windows.Forms.GroupBox groupBoxPWM;
        public System.Windows.Forms.Button buttonPWM;
        public System.Windows.Forms.CheckBox cbUpdateCTPerm;
        public System.Windows.Forms.CheckBox cbUpdateTTLPerm;
        public System.Windows.Forms.CheckBox cbUpdateADPerm;
        public System.Windows.Forms.Button bUpdateAD;
        public System.Windows.Forms.Button bUpdateCT;
        public System.Windows.Forms.Button bUpdateTTL;
        public System.Windows.Forms.Button bIEPE_OFF;
        public System.Windows.Forms.Button buttonCTMeasure;
    }
}