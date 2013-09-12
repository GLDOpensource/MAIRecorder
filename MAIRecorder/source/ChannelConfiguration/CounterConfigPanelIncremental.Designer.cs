namespace MAIRecorder {
    partial class CounterConfigPanelIncremental {
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
            this.comboBoxSignalEdge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSoftwareReset = new System.Windows.Forms.CheckBox();
            this.comboBoxHWREdge = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHWResetMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxInterpolation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSignalEdge
            // 
            this.comboBoxSignalEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSignalEdge.FormattingEnabled = true;
            this.comboBoxSignalEdge.Items.AddRange(new object[] {
            "Rising",
            "Falling"});
            this.comboBoxSignalEdge.Location = new System.Drawing.Point(85, 7);
            this.comboBoxSignalEdge.Name = "comboBoxSignalEdge";
            this.comboBoxSignalEdge.Size = new System.Drawing.Size(102, 21);
            this.comboBoxSignalEdge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Signal Edge";
            // 
            // checkBoxSoftwareReset
            // 
            this.checkBoxSoftwareReset.AutoSize = true;
            this.checkBoxSoftwareReset.Location = new System.Drawing.Point(85, 34);
            this.checkBoxSoftwareReset.Name = "checkBoxSoftwareReset";
            this.checkBoxSoftwareReset.Size = new System.Drawing.Size(99, 17);
            this.checkBoxSoftwareReset.TabIndex = 19;
            this.checkBoxSoftwareReset.Text = "Software Reset";
            this.checkBoxSoftwareReset.UseVisualStyleBackColor = true;
            // 
            // comboBoxHWREdge
            // 
            this.comboBoxHWREdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHWREdge.FormattingEnabled = true;
            this.comboBoxHWREdge.Items.AddRange(new object[] {
            "EdgeLevel",
            "Level"});
            this.comboBoxHWREdge.Location = new System.Drawing.Point(85, 84);
            this.comboBoxHWREdge.Name = "comboBoxHWREdge";
            this.comboBoxHWREdge.Size = new System.Drawing.Size(102, 21);
            this.comboBoxHWREdge.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "HWR Edge";
            // 
            // comboBoxHWResetMode
            // 
            this.comboBoxHWResetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHWResetMode.FormattingEnabled = true;
            this.comboBoxHWResetMode.Items.AddRange(new object[] {
            "Disabled",
            "Level ",
            "LevelExtended ",
            "Edge"});
            this.comboBoxHWResetMode.Location = new System.Drawing.Point(85, 57);
            this.comboBoxHWResetMode.Name = "comboBoxHWResetMode";
            this.comboBoxHWResetMode.Size = new System.Drawing.Size(102, 21);
            this.comboBoxHWResetMode.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "HW Reset ";
            // 
            // comboBoxInterpolation
            // 
            this.comboBoxInterpolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInterpolation.FormattingEnabled = true;
            this.comboBoxInterpolation.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Quad"});
            this.comboBoxInterpolation.Location = new System.Drawing.Point(85, 111);
            this.comboBoxInterpolation.Name = "comboBoxInterpolation";
            this.comboBoxInterpolation.Size = new System.Drawing.Size(102, 21);
            this.comboBoxInterpolation.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Interpolation";
            // 
            // CounterConfigPanelIncremental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxInterpolation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxHWREdge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxHWResetMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxSoftwareReset);
            this.Controls.Add(this.comboBoxSignalEdge);
            this.Controls.Add(this.label1);
            this.Name = "CounterConfigPanelIncremental";
            this.Size = new System.Drawing.Size(217, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSignalEdge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSoftwareReset;
        private System.Windows.Forms.ComboBox comboBoxHWREdge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHWResetMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxInterpolation;
        private System.Windows.Forms.Label label4;
    }
}
