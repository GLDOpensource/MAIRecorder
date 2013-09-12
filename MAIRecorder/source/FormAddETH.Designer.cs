namespace MAIRecorder {
    partial class FormAddETH {
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbIPPort = new System.Windows.Forms.TextBox();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.bAddETH = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUDP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Port";
            // 
            // TbIPPort
            // 
            this.TbIPPort.Location = new System.Drawing.Point(204, 31);
            this.TbIPPort.Name = "TbIPPort";
            this.TbIPPort.Size = new System.Drawing.Size(47, 20);
            this.TbIPPort.TabIndex = 12;
            this.TbIPPort.Text = "1333";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(78, 31);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(86, 20);
            this.tbIPAddress.TabIndex = 11;
            this.tbIPAddress.Text = "127.0.0.1";
            // 
            // bAddETH
            // 
            this.bAddETH.Cursor = System.Windows.Forms.Cursors.Default;
            this.bAddETH.Location = new System.Drawing.Point(58, 93);
            this.bAddETH.Name = "bAddETH";
            this.bAddETH.Size = new System.Drawing.Size(75, 23);
            this.bAddETH.TabIndex = 10;
            this.bAddETH.Text = "Add";
            this.bAddETH.UseVisualStyleBackColor = true;
            this.bAddETH.Click += new System.EventHandler(this.bAddETH_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(58, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Remember Device";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Address";
            // 
            // textBoxUDP
            // 
            this.textBoxUDP.Location = new System.Drawing.Point(204, 57);
            this.textBoxUDP.Name = "textBoxUDP";
            this.textBoxUDP.Size = new System.Drawing.Size(47, 20);
            this.textBoxUDP.TabIndex = 17;
            this.textBoxUDP.Text = "-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "UDP DataIn Port";
            // 
            // FormAddETH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 144);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUDP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbIPPort);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.bAddETH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddETH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddETH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbIPPort;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Button bAddETH;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUDP;
        private System.Windows.Forms.Label label3;
    }
}