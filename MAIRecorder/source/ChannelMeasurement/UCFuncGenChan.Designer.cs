namespace MAIRecorder {
    partial class UCFuncGenChan {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownCycles = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownAmplitude = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbKanalName = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude)).BeginInit();
            this.gbKanalName.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Maximum = 10;
            chartArea1.AxisY.Minimum = -10;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(10, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(701, 286);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericUpDownCycles);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownOffset);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownAmplitude);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(717, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownCycles
            // 
            this.numericUpDownCycles.Location = new System.Drawing.Point(56, 105);
            this.numericUpDownCycles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCycles.Name = "numericUpDownCycles";
            this.numericUpDownCycles.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownCycles.TabIndex = 8;
            this.numericUpDownCycles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cycles";
            // 
            // numericUpDownOffset
            // 
            this.numericUpDownOffset.Location = new System.Drawing.Point(56, 79);
            this.numericUpDownOffset.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownOffset.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            this.numericUpDownOffset.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownOffset.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Offset";
            // 
            // numericUpDownAmplitude
            // 
            this.numericUpDownAmplitude.Location = new System.Drawing.Point(56, 53);
            this.numericUpDownAmplitude.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAmplitude.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownAmplitude.Name = "numericUpDownAmplitude";
            this.numericUpDownAmplitude.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownAmplitude.TabIndex = 2;
            this.numericUpDownAmplitude.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amplitude";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sine",
            "Rect",
            "Sawtooth"});
            this.comboBox1.Location = new System.Drawing.Point(18, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // gbKanalName
            // 
            this.gbKanalName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKanalName.Controls.Add(this.checkBox1);
            this.gbKanalName.Controls.Add(this.groupBox1);
            this.gbKanalName.Controls.Add(this.chart1);
            this.gbKanalName.Location = new System.Drawing.Point(5, -1);
            this.gbKanalName.Name = "gbKanalName";
            this.gbKanalName.Size = new System.Drawing.Size(865, 317);
            this.gbKanalName.TabIndex = 3;
            this.gbKanalName.TabStop = false;
            this.gbKanalName.Text = "DA00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(51, 1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // UCFuncGenChan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbKanalName);
            this.Name = "UCFuncGenChan";
            this.Size = new System.Drawing.Size(880, 323);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude)).EndInit();
            this.gbKanalName.ResumeLayout(false);
            this.gbKanalName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownCycles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownAmplitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbKanalName;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
