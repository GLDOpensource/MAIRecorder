using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAIRecorder {
    public partial class CounterConfigPanelIncremental : UserControl, ICounterConfigPanel {

        private CTChannel m_ctpanel;

        public CounterConfigPanelIncremental() {
            InitializeComponent();
        }

        public CounterConfigPanelIncremental(CTChannel AImyPanel) {
            InitializeComponent();
            m_ctpanel = AImyPanel;
            comboBoxSignalEdge.SelectedIndex = (int)m_ctpanel.Edge;
            comboBoxHWResetMode.SelectedIndex = (int)m_ctpanel.HWResetMode;
            comboBoxHWREdge.SelectedIndex = (int)m_ctpanel.HWResetEdge;
            comboBoxInterpolation.SelectedIndex = (int)m_ctpanel.InterpolationMode;
        }

        #region ICounterConfigPanel Member

        public void WriteConfigToPanel() {
            m_ctpanel.Edge                          = (Goldammer.SignalEdge)   comboBoxSignalEdge.SelectedIndex       ;
            m_ctpanel.HWResetMode = (Goldammer.HardwareResetMode)comboBoxHWResetMode.SelectedIndex;
            m_ctpanel.HWResetEdge = (Goldammer.IncrementalCounterHardwareResetEdge)comboBoxHWREdge.SelectedIndex;
            m_ctpanel.InterpolationMode = (Goldammer.IncrementalCounterInterpolationMode)comboBoxInterpolation.SelectedIndex;

        }

        #endregion
    }
}
