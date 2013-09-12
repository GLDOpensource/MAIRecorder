namespace MAIRecorder {
    partial class FormMeasureCT {
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNoChannelsCT = new System.Windows.Forms.TextBox();
            this.tbFreqCT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoChannelsAD = new System.Windows.Forms.TextBox();
            this.tbFreqAD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flpChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNoChannelsCT);
            this.panel1.Controls.Add(this.tbFreqCT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNoChannelsAD);
            this.panel1.Controls.Add(this.tbFreqAD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 92);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number Of Channels";
            // 
            // tbNoChannelsCT
            // 
            this.tbNoChannelsCT.Location = new System.Drawing.Point(411, 68);
            this.tbNoChannelsCT.Name = "tbNoChannelsCT";
            this.tbNoChannelsCT.ReadOnly = true;
            this.tbNoChannelsCT.Size = new System.Drawing.Size(100, 20);
            this.tbNoChannelsCT.TabIndex = 9;
            // 
            // tbFreqCT
            // 
            this.tbFreqCT.Location = new System.Drawing.Point(411, 45);
            this.tbFreqCT.Name = "tbFreqCT";
            this.tbFreqCT.ReadOnly = true;
            this.tbFreqCT.Size = new System.Drawing.Size(100, 20);
            this.tbFreqCT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number Of Channels";
            // 
            // tbNoChannelsAD
            // 
            this.tbNoChannelsAD.Location = new System.Drawing.Point(141, 68);
            this.tbNoChannelsAD.Name = "tbNoChannelsAD";
            this.tbNoChannelsAD.ReadOnly = true;
            this.tbNoChannelsAD.Size = new System.Drawing.Size(100, 20);
            this.tbNoChannelsAD.TabIndex = 5;
            // 
            // tbFreqAD
            // 
            this.tbFreqAD.Location = new System.Drawing.Point(141, 45);
            this.tbFreqAD.Name = "tbFreqAD";
            this.tbFreqAD.ReadOnly = true;
            this.tbFreqAD.Size = new System.Drawing.Size(100, 20);
            this.tbFreqAD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frequency";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox2.Enabled = false;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Maroon;
            this.checkBox2.Location = new System.Drawing.Point(279, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(244, 31);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "RUN CT-Scanlist";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Enabled = false;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Maroon;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(244, 31);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "RUN AD-Scanlist";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flpChannels
            // 
            this.flpChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpChannels.Location = new System.Drawing.Point(0, 92);
            this.flpChannels.Name = "flpChannels";
            this.flpChannels.Size = new System.Drawing.Size(547, 277);
            this.flpChannels.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMeasureCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 369);
            this.Controls.Add(this.flpChannels);
            this.Controls.Add(this.panel1);
            this.Name = "FormMeasureCT";
            this.ShowIcon = false;
            this.Text = "FormMeasureCT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMeasureCT_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNoChannelsCT;
        private System.Windows.Forms.TextBox tbFreqCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNoChannelsAD;
        private System.Windows.Forms.TextBox tbFreqAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flpChannels;
        private System.Windows.Forms.Timer timer1;
    }
}