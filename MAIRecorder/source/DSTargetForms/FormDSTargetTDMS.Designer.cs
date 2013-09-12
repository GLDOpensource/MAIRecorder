namespace MAIRecorder {
    partial class FormDSTargetTDMS {
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxMTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFTitlte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetFilename
            // 
            this.buttonSetFilename.Location = new System.Drawing.Point(518, 30);
            this.buttonSetFilename.Name = "buttonSetFilename";
            this.buttonSetFilename.Size = new System.Drawing.Size(24, 23);
            this.buttonSetFilename.TabIndex = 16;
            this.buttonSetFilename.Text = "...";
            this.buttonSetFilename.UseVisualStyleBackColor = true;
            this.buttonSetFilename.Click += new System.EventHandler(this.buttonSetFilename_Click);
            // 
            // textBoxFilenameMain
            // 
            this.textBoxFilenameMain.Location = new System.Drawing.Point(159, 32);
            this.textBoxFilenameMain.Name = "textBoxFilenameMain";
            this.textBoxFilenameMain.Size = new System.Drawing.Size(335, 20);
            this.textBoxFilenameMain.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Output File :";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "TDMS Files|*.tdms|All Files|*.*";
            // 
            // textBoxMTitle
            // 
            this.textBoxMTitle.Location = new System.Drawing.Point(159, 89);
            this.textBoxMTitle.Name = "textBoxMTitle";
            this.textBoxMTitle.Size = new System.Drawing.Size(335, 20);
            this.textBoxMTitle.TabIndex = 18;
            this.textBoxMTitle.Text = "Measurement Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Measurement Title";
            // 
            // textBoxMDesc
            // 
            this.textBoxMDesc.Location = new System.Drawing.Point(159, 115);
            this.textBoxMDesc.Name = "textBoxMDesc";
            this.textBoxMDesc.Size = new System.Drawing.Size(335, 20);
            this.textBoxMDesc.TabIndex = 20;
            this.textBoxMDesc.Text = "Measurement Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Measurement Description";
            // 
            // textBoxFTitlte
            // 
            this.textBoxFTitlte.Location = new System.Drawing.Point(159, 141);
            this.textBoxFTitlte.Name = "textBoxFTitlte";
            this.textBoxFTitlte.Size = new System.Drawing.Size(335, 20);
            this.textBoxFTitlte.TabIndex = 22;
            this.textBoxFTitlte.Text = "File Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "File Title";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(159, 167);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(335, 20);
            this.textBoxAuthor.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Author";
            // 
            // FormDSTargetTDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(623, 270);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFTitlte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSetFilename);
            this.Controls.Add(this.textBoxFilenameMain);
            this.Controls.Add(this.label1);
            this.Name = "FormDSTargetTDMS";
            this.Text = "TDMS Output";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxFilenameMain, 0);
            this.Controls.SetChildIndex(this.buttonSetFilename, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBoxMTitle, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxMDesc, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxFTitlte, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBoxAuthor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetFilename;
        private System.Windows.Forms.TextBox textBoxFilenameMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxMTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFTitlte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label5;
    }
}
