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
    public partial class ADChannelSmall : UserControl {
        public ADChannelSmall() {
            InitializeComponent();
        }


        public ADChannelSmall(MAIChannelAD AIChannel) {
            InitializeComponent();
            Channel = AIChannel;
            Bipolar = true;
            IEPEGain20dB = false;
            IEPEIndex = 0;
            if (m_Channel.MyDevice.Properties.ADChannels[(int)m_Channel.HardwareChannelNumber].IEPEMode > 0)
                Channel.SetIEPEMode((IEPEMode)0, false);
        }

        private MAIChannelAD m_Channel;
        public MAIChannelAD Channel {
            get {
                return m_Channel;
            }
            set {
                m_Channel = value;
                labelChannel.Text = "K" + string.Format("{0:00}", m_Channel.HardwareChannelNumber);
            }


        }

        internal GainFactor GainF {
            get;
            set;
        }

        internal OversamplingMode Oversampling {
            get;
            set;
        }

        internal bool Bipolar {
            get;
            set;
        }

        internal int IEPEIndex {
            get;
            set;
        }

        internal bool IEPEGain20dB {
            get;
            set;
        }



        Form myConfi;
        private void ADChannelSmall_MouseDown(object sender, MouseEventArgs e) {
            ShowConfig();
            
        }

        private void ShowConfig() {
            if (m_Channel.MyDevice.Properties.ADChannels[(int)m_Channel.HardwareChannelNumber].IEPEMode > 0) {
                ADSetupIEPE Confi = new ADSetupIEPE(this);

                Confi.Location = Cursor.Position;
                Confi.checkBoxBipolar.Enabled = !(m_Channel.MyDevice.Properties.ADChannels[(int)m_Channel.HardwareChannelNumber].BipolarOnly);
                Confi.groupBox1.Text = labelChannel.Text + " Settings";
                Confi.Show();
            }
            else {
                ADSetup Confi = new ADSetup(this);
                Confi.Location = Cursor.Position;
                Confi.checkBoxBipolar.Enabled = !(m_Channel.MyDevice.Properties.ADChannels[(int)m_Channel.HardwareChannelNumber].BipolarOnly);
                Confi.groupBox1.Text = labelChannel.Text + " Settings";
                Confi.Show();
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e) {
            ShowConfig();
        }

        internal void UpdateVolt() {
            try {
                textBox1.Text =  string.Format("{0:00.0000}",m_Channel.ReadSingleVoltage(Oversampling, GainF, Bipolar));
            }
            catch { }
        }

        internal void CreateMeasurementChannel() {
            MAIMeasurementChannelAD nc =  Channel.CreateMeasurementChannel(Oversampling, GainF, Bipolar);
            nc.Name = labelChannel.Text;
            nc.Unit = "Volt";
        }
    }
}
