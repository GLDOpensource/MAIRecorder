namespace MAIRecorder {
    partial class UCOutputSettingsPWMChannel {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRatio = new System.Windows.Forms.Label();
            this.trackBarRatio = new System.Windows.Forms.TrackBar();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.rbFM = new System.Windows.Forms.RadioButton();
            this.rbPWM = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownFrequency);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelRatio);
            this.groupBox1.Controls.Add(this.trackBarRatio);
            this.groupBox1.Controls.Add(this.rbFM);
            this.groupBox1.Controls.Add(this.rbPWM);
            this.groupBox1.Controls.Add(this.cbActive);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hz";
            // 
            // numericUpDownFrequency
            // 
            this.numericUpDownFrequency.Location = new System.Drawing.Point(160, 46);
            this.numericUpDownFrequency.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFrequency.Name = "numericUpDownFrequency";
            this.numericUpDownFrequency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownFrequency.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownFrequency.TabIndex = 7;
            this.numericUpDownFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrequency.ValueChanged += new System.EventHandler(this.numericUpDownFrequency_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frequency:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ratio:";
            // 
            // labelRatio
            // 
            this.labelRatio.Location = new System.Drawing.Point(471, 23);
            this.labelRatio.Name = "labelRatio";
            this.labelRatio.Size = new System.Drawing.Size(30, 18);
            this.labelRatio.TabIndex = 4;
            this.labelRatio.Text = "50";
            this.labelRatio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // trackBarRatio
            // 
            this.trackBarRatio.AutoSize = false;
            this.trackBarRatio.Location = new System.Drawing.Point(150, 19);
            this.trackBarRatio.Maximum = 100;
            this.trackBarRatio.Name = "trackBarRatio";
            this.trackBarRatio.Size = new System.Drawing.Size(322, 22);
            this.trackBarRatio.TabIndex = 3;
            this.trackBarRatio.Value = 50;
            this.trackBarRatio.Scroll += new System.EventHandler(this.trackBarRatio_Scroll);
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(63, 0);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(65, 17);
            this.cbActive.TabIndex = 2;
            this.cbActive.Text = "Enabled";
            this.cbActive.UseVisualStyleBackColor = true;
            this.cbActive.CheckedChanged += new System.EventHandler(this.cbActive_CheckedChanged);
            // 
            // rbFM
            // 
            this.rbFM.AutoSize = true;
            this.rbFM.Location = new System.Drawing.Point(21, 42);
            this.rbFM.Name = "rbFM";
            this.rbFM.Size = new System.Drawing.Size(40, 17);
            this.rbFM.TabIndex = 1;
            this.rbFM.TabStop = true;
            this.rbFM.Text = "FM";
            this.rbFM.UseVisualStyleBackColor = true;
            // 
            // rbPWM
            // 
            this.rbPWM.AutoSize = true;
            this.rbPWM.Checked = true;
            this.rbPWM.Location = new System.Drawing.Point(21, 19);
            this.rbPWM.Name = "rbPWM";
            this.rbPWM.Size = new System.Drawing.Size(52, 17);
            this.rbPWM.TabIndex = 0;
            this.rbPWM.TabStop = true;
            this.rbPWM.Text = "PWM";
            this.rbPWM.UseVisualStyleBackColor = true;
            // 
            // UCOutputSettingsPWMChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCOutputSettingsPWMChannel";
            this.Size = new System.Drawing.Size(519, 70);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRatio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFM;
        private System.Windows.Forms.RadioButton rbPWM;
        private System.Windows.Forms.TrackBar trackBarRatio;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownFrequency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRatio;
    }
}
