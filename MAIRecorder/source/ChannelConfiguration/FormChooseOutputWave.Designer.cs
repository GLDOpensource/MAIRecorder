namespace MAIRecorder {
    partial class FormChooseOutputWave {
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.trackBarFreq = new System.Windows.Forms.TrackBar();
            this.labelFreq = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBarAMp = new System.Windows.Forms.TrackBar();
            this.labelAplitude = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAMp)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(279, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(192, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sine";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "File";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.AutoSize = false;
            this.trackBarFreq.Location = new System.Drawing.Point(142, 12);
            this.trackBarFreq.Maximum = 20000;
            this.trackBarFreq.Minimum = 20;
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(198, 30);
            this.trackBarFreq.TabIndex = 14;
            this.trackBarFreq.Value = 440;
            this.trackBarFreq.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(346, 12);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(41, 13);
            this.labelFreq.TabIndex = 15;
            this.labelFreq.Text = "440 Hz";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(328, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "File";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(161, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Channel";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBarAMp
            // 
            this.trackBarAMp.AutoSize = false;
            this.trackBarAMp.Location = new System.Drawing.Point(142, 39);
            this.trackBarAMp.Maximum = 5;
            this.trackBarAMp.Minimum = 1;
            this.trackBarAMp.Name = "trackBarAMp";
            this.trackBarAMp.Size = new System.Drawing.Size(198, 30);
            this.trackBarAMp.TabIndex = 21;
            this.trackBarAMp.Value = 5;
            this.trackBarAMp.Scroll += new System.EventHandler(this.trackBarAMp_Scroll);
            // 
            // labelAplitude
            // 
            this.labelAplitude.AutoSize = true;
            this.labelAplitude.Location = new System.Drawing.Point(346, 39);
            this.labelAplitude.Name = "labelAplitude";
            this.labelAplitude.Size = new System.Drawing.Size(13, 13);
            this.labelAplitude.TabIndex = 22;
            this.labelAplitude.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Frequency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Amplitude";
            // 
            // FormChooseOutputWave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 223);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAplitude);
            this.Controls.Add(this.trackBarAMp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelFreq);
            this.Controls.Add(this.trackBarFreq);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChooseOutputWave";
            this.Text = "FormChooseOutputWave";
            this.Load += new System.EventHandler(this.FormChooseOutputWave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAMp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TrackBar trackBarFreq;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar trackBarAMp;
        private System.Windows.Forms.Label labelAplitude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}