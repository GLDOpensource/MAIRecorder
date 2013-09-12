namespace MAIRecorder {
    partial class CounterConfigPanelImpulse {
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
            this.comboBoxImpulseDirection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSignalEdge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPresetValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPresetValue)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxImpulseDirection
            // 
            this.comboBoxImpulseDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImpulseDirection.FormattingEnabled = true;
            this.comboBoxImpulseDirection.Items.AddRange(new object[] {
            "Up",
            "Down"});
            this.comboBoxImpulseDirection.Location = new System.Drawing.Point(89, 42);
            this.comboBoxImpulseDirection.Name = "comboBoxImpulseDirection";
            this.comboBoxImpulseDirection.Size = new System.Drawing.Size(102, 21);
            this.comboBoxImpulseDirection.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Direction";
            // 
            // comboBoxSignalEdge
            // 
            this.comboBoxSignalEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSignalEdge.FormattingEnabled = true;
            this.comboBoxSignalEdge.Items.AddRange(new object[] {
            "Rising",
            "Falling"});
            this.comboBoxSignalEdge.Location = new System.Drawing.Point(89, 15);
            this.comboBoxSignalEdge.Name = "comboBoxSignalEdge";
            this.comboBoxSignalEdge.Size = new System.Drawing.Size(102, 21);
            this.comboBoxSignalEdge.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Signal Edge";
            // 
            // numericUpDownPresetValue
            // 
            this.numericUpDownPresetValue.Location = new System.Drawing.Point(89, 69);
            this.numericUpDownPresetValue.Name = "numericUpDownPresetValue";
            this.numericUpDownPresetValue.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownPresetValue.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Preset Value";
            // 
            // CounterConfigPanelImpulse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownPresetValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxImpulseDirection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSignalEdge);
            this.Controls.Add(this.label1);
            this.Name = "CounterConfigPanelImpulse";
            this.Size = new System.Drawing.Size(216, 150);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPresetValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxImpulseDirection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSignalEdge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPresetValue;
        private System.Windows.Forms.Label label3;
    }
}
