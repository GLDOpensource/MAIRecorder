namespace MAIRecorder {
    partial class DIOChannel {
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
            this.checkBoxDirection = new System.Windows.Forms.CheckBox();
            this.labelState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(5, 4);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(35, 13);
            this.labelChannel.TabIndex = 1;
            this.labelChannel.Text = "label1";
            // 
            // checkBoxDirection
            // 
            this.checkBoxDirection.AutoSize = true;
            this.checkBoxDirection.Location = new System.Drawing.Point(75, 3);
            this.checkBoxDirection.Name = "checkBoxDirection";
            this.checkBoxDirection.Size = new System.Drawing.Size(68, 17);
            this.checkBoxDirection.TabIndex = 2;
            this.checkBoxDirection.Text = "is Output";
            this.checkBoxDirection.UseVisualStyleBackColor = true;
            this.checkBoxDirection.CheckedChanged += new System.EventHandler(this.checkBoxDirection_CheckedChanged);
            // 
            // labelState
            // 
            this.labelState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelState.Location = new System.Drawing.Point(37, 3);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 16);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "label1";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelState.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelState_Click);
            // 
            // DIOChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.checkBoxDirection);
            this.Controls.Add(this.labelChannel);
            this.Name = "DIOChannel";
            this.Size = new System.Drawing.Size(140, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.CheckBox checkBoxDirection;
        private System.Windows.Forms.Label labelState;
    }
}
