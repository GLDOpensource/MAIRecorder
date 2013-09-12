namespace MAIRecorder {
    partial class CounterConfigPanelPeriodPulsewidth {
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
            this.comboBoxSignalEdge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolution.FormattingEnabled = true;
            this.comboBoxResolution.Items.AddRange(new object[] {
            "100 ns",
            "<= 20 ns"});
            this.comboBoxResolution.Location = new System.Drawing.Point(86, 41);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(102, 21);
            this.comboBoxResolution.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resolution";
            // 
            // comboBoxSignalEdge
            // 
            this.comboBoxSignalEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSignalEdge.FormattingEnabled = true;
            this.comboBoxSignalEdge.Items.AddRange(new object[] {
            "Rising",
            "Falling"});
            this.comboBoxSignalEdge.Location = new System.Drawing.Point(86, 14);
            this.comboBoxSignalEdge.Name = "comboBoxSignalEdge";
            this.comboBoxSignalEdge.Size = new System.Drawing.Size(102, 21);
            this.comboBoxSignalEdge.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Signal Edge";
            // 
            // CounterConfigPanelPeriodPulsewidth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxResolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSignalEdge);
            this.Controls.Add(this.label1);
            this.Name = "CounterConfigPanelPeriodPulsewidth";
            this.Size = new System.Drawing.Size(210, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSignalEdge;
        private System.Windows.Forms.Label label1;
    }
}
