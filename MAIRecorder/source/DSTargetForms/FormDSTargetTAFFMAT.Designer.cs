namespace MAIRecorder {
    partial class FormDSTargetTAFFMAT {
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSetFilename = new System.Windows.Forms.Button();
            this.textBoxFilenameMain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "TAFF Mat Header Files|*.hdr|All Files|*.*";
            // 
            // buttonSetFilename
            // 
            this.buttonSetFilename.Location = new System.Drawing.Point(510, 55);
            this.buttonSetFilename.Name = "buttonSetFilename";
            this.buttonSetFilename.Size = new System.Drawing.Size(24, 23);
            this.buttonSetFilename.TabIndex = 19;
            this.buttonSetFilename.Text = "...";
            this.buttonSetFilename.UseVisualStyleBackColor = true;
            this.buttonSetFilename.Click += new System.EventHandler(this.buttonSetFilename_Click);
            // 
            // textBoxFilenameMain
            // 
            this.textBoxFilenameMain.Location = new System.Drawing.Point(151, 57);
            this.textBoxFilenameMain.Name = "textBoxFilenameMain";
            this.textBoxFilenameMain.Size = new System.Drawing.Size(335, 20);
            this.textBoxFilenameMain.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Output File :";
            // 
            // FormDSTargetTAFFMAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(623, 270);
            this.Controls.Add(this.buttonSetFilename);
            this.Controls.Add(this.textBoxFilenameMain);
            this.Controls.Add(this.label1);
            this.Name = "FormDSTargetTAFFMAT";
            this.Text = "TAFF Mat Output";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxFilenameMain, 0);
            this.Controls.SetChildIndex(this.buttonSetFilename, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSetFilename;
        private System.Windows.Forms.TextBox textBoxFilenameMain;
        private System.Windows.Forms.Label label1;
    }
}
