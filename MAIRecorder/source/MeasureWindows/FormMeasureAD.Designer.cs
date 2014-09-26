namespace MAIRecorder {
    partial class FormMeasureAD {
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAFFMatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tDMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPCServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_invertSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valuesRMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownADSamplerate = new System.Windows.Forms.NumericUpDown();
            this.labelPrevTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPrevRate = new System.Windows.Forms.Label();
            this.labelPrevSize = new System.Windows.Forms.Label();
            this.trBaPrevSampleRate = new System.Windows.Forms.TrackBar();
            this.trBaPreviewBufSize = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRecTarget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownADSamplerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBaPrevSampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBaPreviewBufSize)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
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
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 24);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(780, 431);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.channelsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.oPCServerToolStripMenuItem.Click += new System.EventHandler(this.tDMSToolStripMenuItem_Click);
            // 
            // channelsToolStripMenuItem
            // 
            this.channelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_invertSelection});
            this.channelsToolStripMenuItem.Name = "channelsToolStripMenuItem";
            this.channelsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.channelsToolStripMenuItem.Text = "AD Channels";
            // 
            // mi_invertSelection
            // 
            this.mi_invertSelection.Enabled = false;
            this.mi_invertSelection.Name = "mi_invertSelection";
            this.mi_invertSelection.Size = new System.Drawing.Size(155, 22);
            this.mi_invertSelection.Text = "Invert Selection";
            this.mi_invertSelection.Click += new System.EventHandler(this.ni_invertSelectedChannels_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartsToolStripMenuItem,
            this.valuesRMSToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // chartsToolStripMenuItem
            // 
            this.chartsToolStripMenuItem.Checked = true;
            this.chartsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            this.chartsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.chartsToolStripMenuItem.Text = "Charts";
            this.chartsToolStripMenuItem.Click += new System.EventHandler(this.chartsToolStripMenuItem_Click);
            // 
            // valuesRMSToolStripMenuItem
            // 
            this.valuesRMSToolStripMenuItem.Name = "valuesRMSToolStripMenuItem";
            this.valuesRMSToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.valuesRMSToolStripMenuItem.Text = "Values / RMS";
            this.valuesRMSToolStripMenuItem.Click += new System.EventHandler(this.valuesRMSToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDownADSamplerate);
            this.panel1.Controls.Add(this.labelPrevTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelPrevRate);
            this.panel1.Controls.Add(this.labelPrevSize);
            this.panel1.Controls.Add(this.trBaPrevSampleRate);
            this.panel1.Controls.Add(this.trBaPreviewBufSize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbRecTarget);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 74);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Samplerate [Hz]";
            // 
            // numericUpDownADSamplerate
            // 
            this.numericUpDownADSamplerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownADSamplerate.Location = new System.Drawing.Point(487, 50);
            this.numericUpDownADSamplerate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownADSamplerate.Name = "numericUpDownADSamplerate";
            this.numericUpDownADSamplerate.Size = new System.Drawing.Size(89, 20);
            this.numericUpDownADSamplerate.TabIndex = 11;
            this.numericUpDownADSamplerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownADSamplerate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownADSamplerate.ValueChanged += new System.EventHandler(this.numericUpDownADSamplerate_ValueChanged);
            this.numericUpDownADSamplerate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownADSamplerate_KeyUp);
            // 
            // labelPrevTime
            // 
            this.labelPrevTime.AutoSize = true;
            this.labelPrevTime.Location = new System.Drawing.Point(111, 56);
            this.labelPrevTime.Name = "labelPrevTime";
            this.labelPrevTime.Size = new System.Drawing.Size(35, 13);
            this.labelPrevTime.TabIndex = 10;
            this.labelPrevTime.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preview Time [s] = ";
            // 
            // labelPrevRate
            // 
            this.labelPrevRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrevRate.AutoSize = true;
            this.labelPrevRate.Location = new System.Drawing.Point(538, 33);
            this.labelPrevRate.Name = "labelPrevRate";
            this.labelPrevRate.Size = new System.Drawing.Size(35, 13);
            this.labelPrevRate.TabIndex = 8;
            this.labelPrevRate.Text = "label4";
            // 
            // labelPrevSize
            // 
            this.labelPrevSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrevSize.AutoSize = true;
            this.labelPrevSize.Location = new System.Drawing.Point(538, 10);
            this.labelPrevSize.Name = "labelPrevSize";
            this.labelPrevSize.Size = new System.Drawing.Size(35, 13);
            this.labelPrevSize.TabIndex = 7;
            this.labelPrevSize.Text = "label4";
            // 
            // trBaPrevSampleRate
            // 
            this.trBaPrevSampleRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trBaPrevSampleRate.AutoSize = false;
            this.trBaPrevSampleRate.Location = new System.Drawing.Point(114, 30);
            this.trBaPrevSampleRate.Margin = new System.Windows.Forms.Padding(0);
            this.trBaPrevSampleRate.Minimum = 1;
            this.trBaPrevSampleRate.Name = "trBaPrevSampleRate";
            this.trBaPrevSampleRate.Size = new System.Drawing.Size(421, 27);
            this.trBaPrevSampleRate.TabIndex = 6;
            this.trBaPrevSampleRate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trBaPrevSampleRate.Value = 1;
            this.trBaPrevSampleRate.Scroll += new System.EventHandler(this.trBaPrevSampleRate_Scroll);
            // 
            // trBaPreviewBufSize
            // 
            this.trBaPreviewBufSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trBaPreviewBufSize.AutoSize = false;
            this.trBaPreviewBufSize.Location = new System.Drawing.Point(114, 6);
            this.trBaPreviewBufSize.Margin = new System.Windows.Forms.Padding(0);
            this.trBaPreviewBufSize.Maximum = 3000;
            this.trBaPreviewBufSize.Minimum = 10;
            this.trBaPreviewBufSize.Name = "trBaPreviewBufSize";
            this.trBaPreviewBufSize.Size = new System.Drawing.Size(421, 27);
            this.trBaPreviewBufSize.TabIndex = 5;
            this.trBaPreviewBufSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trBaPreviewBufSize.Value = 200;
            this.trBaPreviewBufSize.Scroll += new System.EventHandler(this.trBaPreviewBufSize_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preview Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preview Size";
            // 
            // tbRecTarget
            // 
            this.tbRecTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecTarget.Location = new System.Drawing.Point(657, 49);
            this.tbRecTarget.Name = "tbRecTarget";
            this.tbRecTarget.ReadOnly = true;
            this.tbRecTarget.Size = new System.Drawing.Size(106, 20);
            this.tbRecTarget.TabIndex = 2;
            this.tbRecTarget.Text = "no Output selected";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "record to:";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Enabled = false;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Maroon;
            this.checkBox1.Location = new System.Drawing.Point(608, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 31);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "RECORD";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMeasureAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 529);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(788, 560);
            this.Name = "FormMeasureAD";
            this.ShowIcon = false;
            this.Text = "FormMeasureAD";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownADSamplerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBaPrevSampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBaPreviewBufSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAFFMatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tDMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPCServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valuesRMSToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbRecTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trBaPreviewBufSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrevSize;
        private System.Windows.Forms.TrackBar trBaPrevSampleRate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPrevRate;
        private System.Windows.Forms.Label labelPrevTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem mi_invertSelection;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown numericUpDownADSamplerate;
    }
}