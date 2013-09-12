using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAIRecorder {
    public partial class CounterConfigPanelIncExtTimestamp : UserControl, ICounterConfigPanel {
        public CounterConfigPanelIncExtTimestamp() {
            InitializeComponent();
        }
        CTChannel m_ctpanel;
        
        public CounterConfigPanelIncExtTimestamp(CTChannel AImyPanel) {
            InitializeComponent();
            m_ctpanel = AImyPanel;
            comboBoxResolution.SelectedIndex = (int)m_ctpanel.IncTimestampResolution;
            
        }


        #region ICounterConfigPanel Member

        void ICounterConfigPanel.WriteConfigToPanel() {
           m_ctpanel.IncTimestampResolution = (Goldammer.IncrementalCounterTimestampResolution) comboBoxResolution.SelectedIndex;
        }

        #endregion
    }
}
