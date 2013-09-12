using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Goldammer;

namespace MAIRecorder {
    public partial class UCOutputSettingsPWMChannel : UserControl {
        public UCOutputSettingsPWMChannel() {
            InitializeComponent();
        }

        MAIChannelPWM Channel;

        private void trackBarRatio_Scroll(object sender, EventArgs e) {
            Channel.SetNewPWMRatio((uint)trackBarRatio.Value);
            labelRatio.Text = trackBarRatio.Value.ToString();
        }

        private void numericUpDownFrequency_ValueChanged(object sender, EventArgs e) {
            Channel.SetNewFMFrequency((uint)numericUpDownFrequency.Value);
        }

        private void cbActive_CheckedChanged(object sender, EventArgs e) {
            rbFM.Enabled = cbActive.Checked;
            rbPWM.Enabled = cbActive.Checked;
            trackBarRatio.Enabled = cbActive.Checked;
            numericUpDownFrequency.Enabled = cbActive.Checked;
        }

        internal void ConfigureOutput(bool AIOutputStarted) {
            cbActive.Enabled = AIOutputStarted;
            rbFM.Enabled = AIOutputStarted;
            rbPWM.Enabled = AIOutputStarted;
            trackBarRatio.Enabled = AIOutputStarted;
            numericUpDownFrequency.Enabled = AIOutputStarted;
            if (!AIOutputStarted){
                if (cbActive.Checked) {
                    if (rbPWM.Checked) {
                        trackBarRatio.Enabled = true;
                        Channel.PreparePWM((uint)numericUpDownFrequency.Value, (uint)trackBarRatio.Value);
                        Channel.SetNewPWMRatio((uint)trackBarRatio.Value);
                    }
                    if (rbFM.Checked) {
                        numericUpDownFrequency.Enabled = true;
                        Channel.PrepareFM((uint)numericUpDownFrequency.Value, (uint)trackBarRatio.Value);
                        Channel.SetNewFMFrequency((uint)numericUpDownFrequency.Value);

                    }
                }
                else {
                    Channel.PreparePWM(0, 0);
                }
            }

        }

        internal void SetNameAndChannel(string AIName, MAIChannelPWM AIChannel) {
            groupBox1.Text = AIName;
            Channel = AIChannel;
        }
    }
}
