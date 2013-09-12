namespace MAIRecorder {
    partial class UCConterValue {
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
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelChannel = new System.Windows.Forms.Label();
            this.labelChanneltype = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxValue.Enabled = false;
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue.Location = new System.Drawing.Point(70, 2);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(138, 38);
            this.textBoxValue.TabIndex = 0;
            this.textBoxValue.Text = "00000000";
            this.textBoxValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxValue_MouseClick);
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(6, 11);
            this.labelChannel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(64, 25);
            this.labelChannel.TabIndex = 1;
            this.labelChannel.Text = "CT01";
            this.labelChannel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxValue_MouseClick);
            // 
            // labelChanneltype
            // 
            this.labelChanneltype.AutoSize = true;
            this.labelChanneltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChanneltype.Location = new System.Drawing.Point(28, 40);
            this.labelChanneltype.Name = "labelChanneltype";
            this.labelChanneltype.Size = new System.Drawing.Size(33, 13);
            this.labelChanneltype.TabIndex = 2;
            this.labelChanneltype.Text = "(type)";
            this.labelChanneltype.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxValue_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADSync";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxValue_MouseClick);
            // 
            // UCConterValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelChanneltype);
            this.Controls.Add(this.labelChannel);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UCConterValue";
            this.Size = new System.Drawing.Size(214, 53);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxValue_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label labelChanneltype;
        private System.Windows.Forms.Label label1;
    }
}
