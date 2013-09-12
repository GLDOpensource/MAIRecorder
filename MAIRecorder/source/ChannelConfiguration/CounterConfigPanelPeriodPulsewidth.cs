using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAIRecorder {
    public partial class CounterConfigPanelPeriodPulsewidth : UserControl, ICounterConfigPanel {
        public CounterConfigPanelPeriodPulsewidth() {
            InitializeComponent();
        }

        CTChannel m_ctpanel;

        public CounterConfigPanelPeriodPulsewidth(CTChannel AImyPanel) {
            InitializeComponent();
            m_ctpanel = AImyPanel;
            comboBoxResolution.SelectedIndex = (int)m_ctpanel.Resolution;
            comboBoxSignalEdge.SelectedIndex = (int)m_ctpanel.Edge;
        }
        #region ICounterConfigPanel Member

        public void WriteConfigToPanel() {
            m_ctpanel.Resolution = (Goldammer.CounterResolution)comboBoxResolution.SelectedIndex;
           m_ctpanel.Edge  =  (Goldammer.SignalEdge)comboBoxSignalEdge.SelectedIndex;
        }

        #endregion
    }
}
