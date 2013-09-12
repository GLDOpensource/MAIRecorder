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
    public partial class CounterConfigPanelImpulse : UserControl, ICounterConfigPanel {
        private CTChannel m_ctpanel;
        
        public CounterConfigPanelImpulse() {
            InitializeComponent();
        }

        public CounterConfigPanelImpulse(CTChannel AImyPanel) {
            InitializeComponent();
            m_ctpanel = AImyPanel;
            numericUpDownPresetValue.Maximum = UInt32.MaxValue;
            numericUpDownPresetValue.Value = m_ctpanel.PresetValue;
            comboBoxImpulseDirection.SelectedIndex = (int)m_ctpanel.UpOrDown;
            comboBoxSignalEdge.SelectedIndex = (int)m_ctpanel.Edge;
        }

        #region ICounterConfigPanel Member

        public void WriteConfigToPanel() {
            m_ctpanel.PresetValue = (uint)numericUpDownPresetValue.Value;
            m_ctpanel.UpOrDown = (ImpulseDirection)comboBoxImpulseDirection.SelectedIndex;
            m_ctpanel.Edge = (SignalEdge)comboBoxSignalEdge.SelectedIndex;     
        }

        #endregion
    }
}
