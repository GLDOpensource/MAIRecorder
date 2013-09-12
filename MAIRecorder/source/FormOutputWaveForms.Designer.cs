namespace MAIRecorder {
    partial class FormOutputWaveForms {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flpGenerators = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 50);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.checkBox1.Location = new System.Drawing.Point(637, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 43);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "PLAY";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flpGenerators
            // 
            this.flpGenerators.AutoScroll = true;
            this.flpGenerators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGenerators.Location = new System.Drawing.Point(0, 0);
            this.flpGenerators.Name = "flpGenerators";
            this.flpGenerators.Size = new System.Drawing.Size(752, 359);
            this.flpGenerators.TabIndex = 1;
            this.flpGenerators.Resize += new System.EventHandler(this.flpGenerators_Resize);
            // 
            // FormOutputWaveForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 409);
            this.Controls.Add(this.flpGenerators);
            this.Controls.Add(this.panel1);
            this.Name = "FormOutputWaveForms";
            this.ShowIcon = false;
            this.Text = "FormOutputWaveForms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOutputWaveForms_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpGenerators;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}