namespace MAIRecorder {
    partial class CTSetup {
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
            this.gbCTMode = new System.Windows.Forms.GroupBox();
            this.rbIncExtTime = new System.Windows.Forms.RadioButton();
            this.rbIncExtFlow = new System.Windows.Forms.RadioButton();
            this.rbIncremental = new System.Windows.Forms.RadioButton();
            this.rbUpDown = new System.Windows.Forms.RadioButton();
            this.rbPulsewidth = new System.Windows.Forms.RadioButton();
            this.rbPeriod = new System.Windows.Forms.RadioButton();
            this.rbFreq = new System.Windows.Forms.RadioButton();
            this.rbImpulse = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSyncToAD = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbCTMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCTMode
            // 
            this.gbCTMode.BackColor = System.Drawing.SystemColors.Control;
            this.gbCTMode.Controls.Add(this.rbIncExtTime);
            this.gbCTMode.Controls.Add(this.rbIncExtFlow);
            this.gbCTMode.Controls.Add(this.rbIncremental);
            this.gbCTMode.Controls.Add(this.rbUpDown);
            this.gbCTMode.Controls.Add(this.rbPulsewidth);
            this.gbCTMode.Controls.Add(this.rbPeriod);
            this.gbCTMode.Controls.Add(this.rbFreq);
            this.gbCTMode.Controls.Add(this.rbImpulse);
            this.gbCTMode.Location = new System.Drawing.Point(7, 8);
            this.gbCTMode.Name = "gbCTMode";
            this.gbCTMode.Size = new System.Drawing.Size(121, 206);
            this.gbCTMode.TabIndex = 0;
            this.gbCTMode.TabStop = false;
            this.gbCTMode.Text = "Mode";
            // 
            // rbIncExtTime
            // 
            this.rbIncExtTime.AutoSize = true;
            this.rbIncExtTime.Location = new System.Drawing.Point(17, 180);
            this.rbIncExtTime.Name = "rbIncExtTime";
            this.rbIncExtTime.Size = new System.Drawing.Size(87, 17);
            this.rbIncExtTime.TabIndex = 7;
            this.rbIncExtTime.TabStop = true;
            this.rbIncExtTime.Text = "Inc Ext. Time";
            this.rbIncExtTime.UseVisualStyleBackColor = true;
            this.rbIncExtTime.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
            // 
            // rbIncExtFlow
            // 
            this.rbIncExtFlow.AutoSize = true;
            this.rbIncExtFlow.Location = new System.Drawing.Point(17, 157);
            this.rbIncExtFlow.Name = "rbIncExtFlow";
            this.rbIncExtFlow.Size = new System.Drawing.Size(86, 17);
            this.rbIncExtFlow.TabIndex = 6;
            this.rbIncExtFlow.TabStop = true;
            this.rbIncExtFlow.Text = "Inc Ext. Flow";
            this.rbIncExtFlow.UseVisualStyleBackColor = true;
            this.rbIncExtFlow.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
            // 
            // rbIncremental
            // 
            this.rbIncremental.AutoSize = true;
            this.rbIncremental.Location = new System.Drawing.Point(17, 134);
            this.rbIncremental.Name = "rbIncremental";
            this.rbIncremental.Size = new System.Drawing.Size(80, 17);
            this.rbIncremental.TabIndex = 5;
            this.rbIncremental.TabStop = true;
            this.rbIncremental.Text = "Incremental";
            this.rbIncremental.UseVisualStyleBackColor = true;
            this.rbIncremental.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
            // 
            // rbUpDown
            // 
            this.rbUpDown.AutoSize = true;
            this.rbUpDown.Location = new System.Drawing.Point(17, 111);
            this.rbUpDown.Name = "rbUpDown";
            this.rbUpDown.Size = new System.Drawing.Size(78, 17);
            this.rbUpDown.TabIndex = 4;
            this.rbUpDown.TabStop = true;
            this.rbUpDown.Text = "Up / Down";
            this.rbUpDown.UseVisualStyleBackColor = true;
            this.rbUpDown.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
            // 
            // rbPulsewidth
            // 
            this.rbPulsewidth.AutoSize = true;
            this.rbPulsewidth.Location = new System.Drawing.Point(17, 88);
            this.rbPulsewidth.Name = "rbPulsewidth";
            this.rbPulsewidth.Size = new System.Drawing.Size(76, 17);
            this.rbPulsewidth.TabIndex = 3;
            this.rbPulsewidth.TabStop = true;
            this.rbPulsewidth.Text = "Pulsewidth";
            this.rbPulsewidth.UseVisualStyleBackColor = true;
            this.rbPulsewidth.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
            // 
            // rbPeriod
            // 
            this.rbPeriod.AutoSize = true;
            this.rbPeriod.Location = new System.Drawing.Point(17, 65);
            this.rbPeriod.Name = "rbPeriod";
            this.rbPeriod.Size = new System.Drawing.Size(55, 17);
            this.rbPeriod.TabIndex = 2;
            this.rbPeriod.TabStop = true;
            this.rbPeriod.Text = "Period";
            this.rbPeriod.UseVisualStyleBackColor = true;
            this.rbPeriod.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
            // 
            // rbFreq
            // 
            this.rbFreq.AutoSize = true;
            this.rbFreq.Location = new System.Drawing.Point(17, 42);
            this.rbFreq.Name = "rbFreq";
            this.rbFreq.Size = new System.Drawing.Size(75, 17);
            this.rbFreq.TabIndex = 1;
            this.rbFreq.TabStop = true;
            this.rbFreq.Text = "Frequency";
            this.rbFreq.UseVisualStyleBackColor = true;
            this.rbFreq.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
            // 
            // rbImpulse
            // 
            this.rbImpulse.AutoSize = true;
            this.rbImpulse.Location = new System.Drawing.Point(17, 19);
            this.rbImpulse.Name = "rbImpulse";
            this.rbImpulse.Size = new System.Drawing.Size(61, 17);
            this.rbImpulse.TabIndex = 0;
            this.rbImpulse.TabStop = true;
            this.rbImpulse.Text = "Impulse";
            this.rbImpulse.UseVisualStyleBackColor = true;
            this.rbImpulse.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(133, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 178);
            this.panel1.TabIndex = 1;
            // 
            // checkBoxSyncToAD
            // 
            this.checkBoxSyncToAD.AutoSize = true;
            this.checkBoxSyncToAD.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxSyncToAD.Checked = true;
            this.checkBoxSyncToAD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSyncToAD.Location = new System.Drawing.Point(136, 194);
            this.checkBoxSyncToAD.Name = "checkBoxSyncToAD";
            this.checkBoxSyncToAD.Size = new System.Drawing.Size(166, 17);
            this.checkBoxSyncToAD.TabIndex = 2;
            this.checkBoxSyncToAD.Text = "record with analog channellist";
            this.checkBoxSyncToAD.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 216);
            this.panel2.TabIndex = 3;
            // 
            // CTSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(390, 222);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxSyncToAD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCTMode);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CTSetup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormCounterConfig";
            this.Deactivate += new System.EventHandler(this.FormCounterConfig_Deactivate);

            this.gbCTMode.ResumeLayout(false);
            this.gbCTMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbImpulse;
        private System.Windows.Forms.RadioButton rbIncExtTime;
        private System.Windows.Forms.RadioButton rbIncExtFlow;
        private System.Windows.Forms.RadioButton rbIncremental;
        private System.Windows.Forms.RadioButton rbUpDown;
        private System.Windows.Forms.RadioButton rbPulsewidth;
        private System.Windows.Forms.RadioButton rbPeriod;
        private System.Windows.Forms.RadioButton rbFreq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxSyncToAD;
        public System.Windows.Forms.GroupBox gbCTMode;
        private System.Windows.Forms.Panel panel2;
    }
}