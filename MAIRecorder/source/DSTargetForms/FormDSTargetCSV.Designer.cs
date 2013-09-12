namespace MAIRecorder {
    partial class FormDSTargetCSV {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSepTab = new System.Windows.Forms.RadioButton();
            this.radioButtonSepSemi = new System.Windows.Forms.RadioButton();
            this.radioButtonSepColon = new System.Windows.Forms.RadioButton();
            this.checkBoxWriteMeta = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDE = new System.Windows.Forms.RadioButton();
            this.radioButtonNFen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilenameMain = new System.Windows.Forms.TextBox();
            this.textBoxMetaName = new System.Windows.Forms.TextBox();
            this.buttonSetFilename = new System.Windows.Forms.Button();
            this.buttonSetMetaFile = new System.Windows.Forms.Button();
            this.checkBoxAppendTo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CSV Files|*.csv|All Files|*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSepTab);
            this.groupBox1.Controls.Add(this.radioButtonSepSemi);
            this.groupBox1.Controls.Add(this.radioButtonSepColon);
            this.groupBox1.Location = new System.Drawing.Point(202, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Separator Char";
            // 
            // radioButtonSepTab
            // 
            this.radioButtonSepTab.AutoSize = true;
            this.radioButtonSepTab.Location = new System.Drawing.Point(31, 69);
            this.radioButtonSepTab.Name = "radioButtonSepTab";
            this.radioButtonSepTab.Size = new System.Drawing.Size(46, 17);
            this.radioButtonSepTab.TabIndex = 5;
            this.radioButtonSepTab.TabStop = true;
            this.radioButtonSepTab.Text = "TAB";
            this.radioButtonSepTab.UseVisualStyleBackColor = true;
            // 
            // radioButtonSepSemi
            // 
            this.radioButtonSepSemi.AutoSize = true;
            this.radioButtonSepSemi.Checked = true;
            this.radioButtonSepSemi.Location = new System.Drawing.Point(31, 46);
            this.radioButtonSepSemi.Name = "radioButtonSepSemi";
            this.radioButtonSepSemi.Size = new System.Drawing.Size(28, 17);
            this.radioButtonSepSemi.TabIndex = 4;
            this.radioButtonSepSemi.TabStop = true;
            this.radioButtonSepSemi.Text = ";";
            this.radioButtonSepSemi.UseVisualStyleBackColor = true;
            // 
            // radioButtonSepColon
            // 
            this.radioButtonSepColon.AutoSize = true;
            this.radioButtonSepColon.Location = new System.Drawing.Point(31, 23);
            this.radioButtonSepColon.Name = "radioButtonSepColon";
            this.radioButtonSepColon.Size = new System.Drawing.Size(28, 17);
            this.radioButtonSepColon.TabIndex = 3;
            this.radioButtonSepColon.Text = ",";
            this.radioButtonSepColon.UseVisualStyleBackColor = true;
            // 
            // checkBoxWriteMeta
            // 
            this.checkBoxWriteMeta.AutoSize = true;
            this.checkBoxWriteMeta.Location = new System.Drawing.Point(50, 72);
            this.checkBoxWriteMeta.Name = "checkBoxWriteMeta";
            this.checkBoxWriteMeta.Size = new System.Drawing.Size(145, 17);
            this.checkBoxWriteMeta.TabIndex = 3;
            this.checkBoxWriteMeta.Text = "Separate Metadata File : ";
            this.checkBoxWriteMeta.UseVisualStyleBackColor = true;
            this.checkBoxWriteMeta.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDE);
            this.groupBox2.Controls.Add(this.radioButtonNFen);
            this.groupBox2.Location = new System.Drawing.Point(310, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number Format";
            // 
            // radioButtonDE
            // 
            this.radioButtonDE.AutoSize = true;
            this.radioButtonDE.Checked = true;
            this.radioButtonDE.Location = new System.Drawing.Point(24, 46);
            this.radioButtonDE.Name = "radioButtonDE";
            this.radioButtonDE.Size = new System.Drawing.Size(55, 17);
            this.radioButtonDE.TabIndex = 4;
            this.radioButtonDE.TabStop = true;
            this.radioButtonDE.Text = "de-DE";
            this.radioButtonDE.UseVisualStyleBackColor = true;
            // 
            // radioButtonNFen
            // 
            this.radioButtonNFen.AutoSize = true;
            this.radioButtonNFen.Location = new System.Drawing.Point(24, 23);
            this.radioButtonNFen.Name = "radioButtonNFen";
            this.radioButtonNFen.Size = new System.Drawing.Size(55, 17);
            this.radioButtonNFen.TabIndex = 3;
            this.radioButtonNFen.Text = "en-US";
            this.radioButtonNFen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output File (Data) :";
            // 
            // textBoxFilenameMain
            // 
            this.textBoxFilenameMain.Location = new System.Drawing.Point(195, 26);
            this.textBoxFilenameMain.Name = "textBoxFilenameMain";
            this.textBoxFilenameMain.Size = new System.Drawing.Size(335, 20);
            this.textBoxFilenameMain.TabIndex = 8;
            // 
            // textBoxMetaName
            // 
            this.textBoxMetaName.Enabled = false;
            this.textBoxMetaName.Location = new System.Drawing.Point(195, 70);
            this.textBoxMetaName.Name = "textBoxMetaName";
            this.textBoxMetaName.Size = new System.Drawing.Size(335, 20);
            this.textBoxMetaName.TabIndex = 9;
            // 
            // buttonSetFilename
            // 
            this.buttonSetFilename.Location = new System.Drawing.Point(536, 24);
            this.buttonSetFilename.Name = "buttonSetFilename";
            this.buttonSetFilename.Size = new System.Drawing.Size(24, 23);
            this.buttonSetFilename.TabIndex = 10;
            this.buttonSetFilename.Text = "...";
            this.buttonSetFilename.UseVisualStyleBackColor = true;
            this.buttonSetFilename.Click += new System.EventHandler(this.buttonSetFilename_Click);
            // 
            // buttonSetMetaFile
            // 
            this.buttonSetMetaFile.Enabled = false;
            this.buttonSetMetaFile.Location = new System.Drawing.Point(536, 68);
            this.buttonSetMetaFile.Name = "buttonSetMetaFile";
            this.buttonSetMetaFile.Size = new System.Drawing.Size(24, 23);
            this.buttonSetMetaFile.TabIndex = 11;
            this.buttonSetMetaFile.Text = "...";
            this.buttonSetMetaFile.UseVisualStyleBackColor = true;
            this.buttonSetMetaFile.Click += new System.EventHandler(this.buttonSetMetaFile_Click);
            // 
            // checkBoxAppendTo
            // 
            this.checkBoxAppendTo.AutoSize = true;
            this.checkBoxAppendTo.Location = new System.Drawing.Point(195, 47);
            this.checkBoxAppendTo.Name = "checkBoxAppendTo";
            this.checkBoxAppendTo.Size = new System.Drawing.Size(119, 17);
            this.checkBoxAppendTo.TabIndex = 12;
            this.checkBoxAppendTo.Text = "Append if File exists";
            this.checkBoxAppendTo.UseVisualStyleBackColor = true;
            // 
            // FormDSTargetCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(623, 270);
            this.Controls.Add(this.checkBoxAppendTo);
            this.Controls.Add(this.buttonSetMetaFile);
            this.Controls.Add(this.buttonSetFilename);
            this.Controls.Add(this.textBoxMetaName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBoxWriteMeta);
            this.Controls.Add(this.textBoxFilenameMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormDSTargetCSV";
            this.Text = "CSV Output";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.textBoxFilenameMain, 0);
            this.Controls.SetChildIndex(this.checkBoxWriteMeta, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.textBoxMetaName, 0);
            this.Controls.SetChildIndex(this.buttonSetFilename, 0);
            this.Controls.SetChildIndex(this.buttonSetMetaFile, 0);
            this.Controls.SetChildIndex(this.checkBoxAppendTo, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSepTab;
        private System.Windows.Forms.RadioButton radioButtonSepSemi;
        private System.Windows.Forms.RadioButton radioButtonSepColon;
        private System.Windows.Forms.CheckBox checkBoxWriteMeta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDE;
        private System.Windows.Forms.RadioButton radioButtonNFen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilenameMain;
        private System.Windows.Forms.TextBox textBoxMetaName;
        private System.Windows.Forms.Button buttonSetFilename;
        private System.Windows.Forms.Button buttonSetMetaFile;
        private System.Windows.Forms.CheckBox checkBoxAppendTo;
    }
}
