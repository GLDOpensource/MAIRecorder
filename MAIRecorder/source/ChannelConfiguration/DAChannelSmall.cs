﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Goldammer;

namespace MAIRecorder {
    public partial class DAChannelSmall : UserControl {
        public DAChannelSmall() {
            InitializeComponent();
        }
        MAIChannelDA m_channel;
        public MAIChannelDA Channel {
            get {
                return m_channel;
            }
            set {
                m_channel = value;
                labelChannel.Text = "DA" + string.Format("{0:0}", m_channel.HardwareChannelNumber);
            }
        }

        public DAChannelSmall(MAIChannelDA AIChannel) {
            InitializeComponent();
            Channel = AIChannel;
            UpdateRange(DARange.Bipolar);
            
        }

        internal void UpdateRange(DARange AIRange) {
            if (AIRange == DARange.Bipolar) {
                trackBar1.Minimum = -1000;
            }
            else {
                if (trackBar1.Value < 0)
                    trackBar1.Value = 0;
                trackBar1.Minimum = 0;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            Channel.WriteChannelVoltage((double)trackBar1.Value / 100.0);
            textBox1.Text = string.Format("{0:00.00}", trackBar1.Value / 100.0);
        }
    }
}
