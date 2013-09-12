using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Goldammer;

namespace MAIRecorder {
    public partial class ADSetupIEPE : Form {

        private ADChannelSmall m_Parent;
        
        public ADSetupIEPE() {
            InitializeComponent();
        }
         
        public ADSetupIEPE(ADChannelSmall AIParent) {
            m_Parent = AIParent;
            InitializeComponent();
             comboBoxGain.SelectedIndex =(int) m_Parent.GainF;
             comboBoxOversampling.SelectedIndex = (int)m_Parent.Oversampling;
             checkBoxBipolar.Checked = m_Parent.Bipolar;
             comboBoxIEPE.SelectedIndex =  m_Parent.IEPEIndex;
             checkBoxIEPEGain.Checked = m_Parent.IEPEGain20dB;
        }
    
        public  void  ADSetup_Deactivate(object sender, EventArgs e) {
             m_Parent.GainF = (GainFactor)comboBoxGain.SelectedIndex;
             m_Parent.Oversampling = (OversamplingMode)comboBoxOversampling.SelectedIndex;
             m_Parent.Bipolar =  checkBoxBipolar.Checked;
             m_Parent.IEPEIndex = comboBoxIEPE.SelectedIndex;
             m_Parent.IEPEGain20dB= checkBoxIEPEGain.Checked ;
             m_Parent.Channel.SetIEPEMode((IEPEMode)comboBoxIEPE.SelectedIndex, checkBoxIEPEGain.Checked);
            Close();
        }

    }
}
