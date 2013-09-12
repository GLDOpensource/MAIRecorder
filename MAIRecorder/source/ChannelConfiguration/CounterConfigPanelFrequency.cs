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
    public partial class CounterConfigPanelFrequency : UserControl, ICounterConfigPanel {

        private CTChannel m_ctpanel;

        public CounterConfigPanelFrequency() {
            InitializeComponent();
       
        }

        public CounterConfigPanelFrequency(CTChannel AImyPanel) {
            InitializeComponent();
            m_ctpanel = AImyPanel;
            comboBoxFCtResulution.SelectedIndex = (int)m_ctpanel.FCResolution;
            comboBoxSignalEdge.SelectedIndex = (int)m_ctpanel.Edge;   
        }

        #region ICounterConfigPanel Member

        public void WriteConfigToPanel() {
            m_ctpanel.FCResolution = (FrequencyCounterResolution)comboBoxFCtResulution.SelectedIndex;
            m_ctpanel.Edge = (SignalEdge)comboBoxSignalEdge.SelectedIndex;     
        }

        #endregion

      
    }
}
