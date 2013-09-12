namespace MAIRecorder {
    partial class ADChannelSmall {
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelChannel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(4, 2);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelChannel.Size = new System.Drawing.Size(20, 13);
            this.labelChannel.TabIndex = 2;
            this.labelChannel.Text = "K0";
            this.labelChannel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // ADChannelSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelChannel);
            this.Name = "ADChannelSmall";
            this.Size = new System.Drawing.Size(121, 18);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ADChannelSmall_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label labelChannel;
    }
}
