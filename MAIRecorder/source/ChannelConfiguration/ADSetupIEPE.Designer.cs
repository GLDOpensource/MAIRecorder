namespace MAIRecorder {
    partial class ADSetupIEPE {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.checkBoxBipolar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGain = new System.Windows.Forms.ComboBox();
            this.comboBoxOversampling = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIEPEGain = new System.Windows.Forms.CheckBox();
            this.comboBoxIEPE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxBipolar
            // 
            this.checkBoxBipolar.AutoSize = true;
            this.checkBoxBipolar.Checked = true;
            this.checkBoxBipolar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBipolar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxBipolar.Location = new System.Drawing.Point(91, 71);
            this.checkBoxBipolar.Name = "checkBoxBipolar";
            this.checkBoxBipolar.Size = new System.Drawing.Size(58, 17);
            this.checkBoxBipolar.TabIndex = 20;
            this.checkBoxBipolar.Text = "Bipolar";
            this.checkBoxBipolar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(56, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gain";
            // 
            // comboBoxGain
            // 
            this.comboBoxGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGain.FormattingEnabled = true;
            this.comboBoxGain.Items.AddRange(new object[] {
            "Off",
            "x2",
            "x4",
            "x8"});
            this.comboBoxGain.Location = new System.Drawing.Point(91, 41);
            this.comboBoxGain.Name = "comboBoxGain";
            this.comboBoxGain.Size = new System.Drawing.Size(105, 21);
            this.comboBoxGain.TabIndex = 18;
            // 
            // comboBoxOversampling
            // 
            this.comboBoxOversampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOversampling.FormattingEnabled = true;
            this.comboBoxOversampling.Items.AddRange(new object[] {
            "Off",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.comboBoxOversampling.Location = new System.Drawing.Point(91, 14);
            this.comboBoxOversampling.Name = "comboBoxOversampling";
            this.comboBoxOversampling.Size = new System.Drawing.Size(105, 21);
            this.comboBoxOversampling.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Oversampling";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.checkBoxIEPEGain);
            this.groupBox1.Controls.Add(this.comboBoxIEPE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxBipolar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxGain);
            this.groupBox1.Controls.Add(this.comboBoxOversampling);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 153);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // checkBoxIEPEGain
            // 
            this.checkBoxIEPEGain.AutoSize = true;
            this.checkBoxIEPEGain.Checked = true;
            this.checkBoxIEPEGain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIEPEGain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxIEPEGain.Location = new System.Drawing.Point(91, 123);
            this.checkBoxIEPEGain.Name = "checkBoxIEPEGain";
            this.checkBoxIEPEGain.Size = new System.Drawing.Size(84, 17);
            this.checkBoxIEPEGain.TabIndex = 23;
            this.checkBoxIEPEGain.Text = "+ 20 dbGain";
            this.checkBoxIEPEGain.UseVisualStyleBackColor = true;
            // 
            // comboBoxIEPE
            // 
            this.comboBoxIEPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIEPE.FormattingEnabled = true;
            this.comboBoxIEPE.Items.AddRange(new object[] {
            "DC,SE,IEPE off",
            "DC,Diff,IEPE off",
            "AC,SE,IEPE off",
            "AC,SE,IEPE on"});
            this.comboBoxIEPE.Location = new System.Drawing.Point(91, 96);
            this.comboBoxIEPE.Name = "comboBoxIEPE";
            this.comboBoxIEPE.Size = new System.Drawing.Size(105, 21);
            this.comboBoxIEPE.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(54, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "IEPE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 158);
            this.panel1.TabIndex = 22;
            // 
            // ADSetupIEPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(230, 163);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADSetupIEPE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ADSetup";
            this.Deactivate += new System.EventHandler(this.ADSetup_Deactivate);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox comboBoxGain;
        internal System.Windows.Forms.ComboBox comboBoxOversampling;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.CheckBox checkBoxBipolar;
        internal System.Windows.Forms.ComboBox comboBoxIEPE;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkBoxIEPEGain;
        private System.Windows.Forms.Panel panel1;
    }
}