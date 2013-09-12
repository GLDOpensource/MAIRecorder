namespace MAIRecorder {
    partial class PWMChannel {
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
            this.labelChannel = new System.Windows.Forms.Label();
            this.cbStart = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(5, 3);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(35, 13);
            this.labelChannel.TabIndex = 2;
            this.labelChannel.Text = "label1";
            // 
            // cbStart
            // 
            this.cbStart.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbStart.AutoSize = true;
            this.cbStart.Location = new System.Drawing.Point(462, 0);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(39, 23);
            this.cbStart.TabIndex = 3;
            this.cbStart.Text = "Start";
            this.cbStart.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(115, 0);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(262, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PWM",
            "FM"});
            this.comboBox1.Location = new System.Drawing.Point(46, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(396, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // PWMChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.labelChannel);
            this.Name = "PWMChannel";
            this.Size = new System.Drawing.Size(504, 25);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.CheckBox cbStart;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
