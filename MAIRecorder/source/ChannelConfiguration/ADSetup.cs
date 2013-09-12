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
    public partial class ADSetup : Form {
        public ADSetup() {
            InitializeComponent();
        }
        ADChannelSmall m_Parent;
         public ADSetup(ADChannelSmall AIParent) {
            m_Parent = AIParent;
            InitializeComponent();
             comboBoxGain.SelectedIndex =(int) m_Parent.GainF;
             comboBoxOversampling.SelectedIndex = (int)m_Parent.Oversampling;
             checkBoxBipolar.Checked = m_Parent.Bipolar;

        }

        
        virtual public void ADSetup_Deactivate(object sender, EventArgs e) {
             m_Parent.GainF = (GainFactor)comboBoxGain.SelectedIndex;
             m_Parent.Oversampling = (OversamplingMode)comboBoxOversampling.SelectedIndex;
             m_Parent.Bipolar =  checkBoxBipolar.Checked;

            Close();
        }

    
    }
}
