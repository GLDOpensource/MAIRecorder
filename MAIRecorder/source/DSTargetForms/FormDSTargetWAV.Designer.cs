namespace MAIRecorder {
    partial class FormDSTargetWAV {
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
            this.buttonSetFilename = new System.Windows.Forms.Button();
            this.textBoxFilenameMain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // buttonSetFilename
            // 
            this.buttonSetFilename.Location = new System.Drawing.Point(501, 36);
            this.buttonSetFilename.Name = "buttonSetFilename";
            this.buttonSetFilename.Size = new System.Drawing.Size(24, 23);
            this.buttonSetFilename.TabIndex = 22;
            this.buttonSetFilename.Text = "...";
            this.buttonSetFilename.UseVisualStyleBackColor = true;
            this.buttonSetFilename.Click += new System.EventHandler(this.buttonSetFilename_Click);
            // 
            // textBoxFilenameMain
            // 
            this.textBoxFilenameMain.Location = new System.Drawing.Point(142, 38);
            this.textBoxFilenameMain.Name = "textBoxFilenameMain";
            this.textBoxFilenameMain.Size = new System.Drawing.Size(335, 20);
            this.textBoxFilenameMain.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Output Prefix :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 39);
            this.label2.TabIndex = 23;
            this.label2.Text = "Will record one File per channel.\r\nThe Filenames have the form :\r\nprefix<channelN" +
                "umber>_<2GBChunk Count>.WAV";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "All Files|*.*";
            // 
            // FormDSTargetWAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(623, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSetFilename);
            this.Controls.Add(this.textBoxFilenameMain);
            this.Controls.Add(this.label1);
            this.Name = "FormDSTargetWAV";
            this.Text = "WAV Output";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxFilenameMain, 0);
            this.Controls.SetChildIndex(this.buttonSetFilename, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetFilename;
        private System.Windows.Forms.TextBox textBoxFilenameMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
