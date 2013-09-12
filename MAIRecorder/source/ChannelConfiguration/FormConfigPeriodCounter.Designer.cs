namespace MAIRecorder {
    partial class FormConfigPeriodCounter {
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
            this.comboBoxFCtResulution = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSignalEdge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFCtResulution
            // 
            this.comboBoxFCtResulution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFCtResulution.FormattingEnabled = true;
            this.comboBoxFCtResulution.Items.AddRange(new object[] {
            "1Hz ",
            "10Hz "});
            this.comboBoxFCtResulution.Location = new System.Drawing.Point(118, 54);
            this.comboBoxFCtResulution.Name = "comboBoxFCtResulution";
            this.comboBoxFCtResulution.Size = new System.Drawing.Size(102, 21);
            this.comboBoxFCtResulution.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resolution";
            // 
            // comboBoxSignalEdge
            // 
            this.comboBoxSignalEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSignalEdge.FormattingEnabled = true;
            this.comboBoxSignalEdge.Items.AddRange(new object[] {
            "Rising",
            "Falling"});
            this.comboBoxSignalEdge.Location = new System.Drawing.Point(118, 27);
            this.comboBoxSignalEdge.Name = "comboBoxSignalEdge";
            this.comboBoxSignalEdge.Size = new System.Drawing.Size(102, 21);
            this.comboBoxSignalEdge.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Signal Edge";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(128, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(215, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormConfigPeriodCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 135);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxFCtResulution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSignalEdge);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConfigPeriodCounter";
            this.Text = "FormConfigPeriodCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFCtResulution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSignalEdge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}