namespace MAIRecorder {
    partial class CTChannel {
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
            this.labelChannel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(6, 7);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(35, 13);
            this.labelChannel.TabIndex = 3;
            this.labelChannel.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // CTChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelChannel);
            this.Name = "CTChannel";
            this.Size = new System.Drawing.Size(195, 27);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CTChannel_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.TextBox textBox1;
    }
}
