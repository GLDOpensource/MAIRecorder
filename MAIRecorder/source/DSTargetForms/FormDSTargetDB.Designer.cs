namespace MAIRecorder {
    partial class FormDSTargetDB {
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
            this.textBoxSqlCeFile = new System.Windows.Forms.TextBox();
            this.radioButtonCE = new System.Windows.Forms.RadioButton();
            this.buttonCE = new System.Windows.Forms.Button();
            this.radioButtonServer = new System.Windows.Forms.RadioButton();
            this.buttonServerTest = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSqlCeFile
            // 
            this.textBoxSqlCeFile.Location = new System.Drawing.Point(188, 38);
            this.textBoxSqlCeFile.Name = "textBoxSqlCeFile";
            this.textBoxSqlCeFile.Size = new System.Drawing.Size(294, 20);
            this.textBoxSqlCeFile.TabIndex = 2;
            // 
            // radioButtonCE
            // 
            this.radioButtonCE.AutoSize = true;
            this.radioButtonCE.Checked = true;
            this.radioButtonCE.Location = new System.Drawing.Point(46, 39);
            this.radioButtonCE.Name = "radioButtonCE";
            this.radioButtonCE.Size = new System.Drawing.Size(115, 17);
            this.radioButtonCE.TabIndex = 3;
            this.radioButtonCE.TabStop = true;
            this.radioButtonCE.Text = "Sql Server Ce File :";
            this.radioButtonCE.UseVisualStyleBackColor = true;
            this.radioButtonCE.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(488, 36);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(24, 23);
            this.buttonCE.TabIndex = 4;
            this.buttonCE.Text = "...";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // radioButtonServer
            // 
            this.radioButtonServer.AutoSize = true;
            this.radioButtonServer.Location = new System.Drawing.Point(46, 65);
            this.radioButtonServer.Name = "radioButtonServer";
            this.radioButtonServer.Size = new System.Drawing.Size(137, 17);
            this.radioButtonServer.TabIndex = 6;
            this.radioButtonServer.Text = "Sql Server Connection :";
            this.radioButtonServer.UseVisualStyleBackColor = true;
            this.radioButtonServer.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonServerTest
            // 
            this.buttonServerTest.Enabled = false;
            this.buttonServerTest.Location = new System.Drawing.Point(488, 62);
            this.buttonServerTest.Name = "buttonServerTest";
            this.buttonServerTest.Size = new System.Drawing.Size(66, 23);
            this.buttonServerTest.TabIndex = 7;
            this.buttonServerTest.Text = "Test ...";
            this.buttonServerTest.UseVisualStyleBackColor = true;
            this.buttonServerTest.Click += new System.EventHandler(this.buttonServer_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "SqlCe Files|*.mdf|All Files|*.*";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Enabled = false;
            this.textBoxServer.Location = new System.Drawing.Point(188, 64);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(294, 20);
            this.textBoxServer.TabIndex = 8;
            this.textBoxServer.Text = "server=localhost\\sqlexpress;Trusted_Connection=yes";
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.Enabled = false;
            this.textBoxDBName.Location = new System.Drawing.Point(188, 90);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(294, 20);
            this.textBoxDBName.TabIndex = 9;
            this.textBoxDBName.Text = "TESTMeasDB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Database Name :";
            // 
            // FormDSTargetDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(623, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDBName);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.radioButtonServer);
            this.Controls.Add(this.buttonServerTest);
            this.Controls.Add(this.textBoxSqlCeFile);
            this.Controls.Add(this.radioButtonCE);
            this.Controls.Add(this.buttonCE);
            this.Name = "FormDSTargetDB";
            this.Text = "Database Output";
            this.Load += new System.EventHandler(this.FormDSTargetDB_Load);
            this.Controls.SetChildIndex(this.buttonCE, 0);
            this.Controls.SetChildIndex(this.radioButtonCE, 0);
            this.Controls.SetChildIndex(this.textBoxSqlCeFile, 0);
            this.Controls.SetChildIndex(this.buttonServerTest, 0);
            this.Controls.SetChildIndex(this.radioButtonServer, 0);
            this.Controls.SetChildIndex(this.textBoxServer, 0);
            this.Controls.SetChildIndex(this.textBoxDBName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSqlCeFile;
        private System.Windows.Forms.RadioButton radioButtonCE;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.RadioButton radioButtonServer;
        private System.Windows.Forms.Button buttonServerTest;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxDBName;
        private System.Windows.Forms.Label label1;
    }
}
