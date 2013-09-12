namespace MAIRecorder {
    partial class CounterConfigPanelIncExtTimestamp {
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
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolution.FormattingEnabled = true;
            this.comboBoxResolution.Items.AddRange(new object[] {
            "1 ms",
            "100 ms"});
            this.comboBoxResolution.Location = new System.Drawing.Point(86, 13);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(102, 21);
            this.comboBoxResolution.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resolution";
            // 
            // CounterConfigPanelIncExtTimestamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxResolution);
            this.Controls.Add(this.label2);
            this.Name = "CounterConfigPanelIncExtTimestamp";
            this.Size = new System.Drawing.Size(202, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.Label label2;
    }
}
