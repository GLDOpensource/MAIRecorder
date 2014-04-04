using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Goldammer;
using System.Threading;

namespace MAIRecorder {
    public partial class CTSetup : Form {

        #region private

        private CTChannel m_CTPanel;

        private void FormCounterConfig_Deactivate(object sender, EventArgs e) {
            m_CTPanel.Mode = Mode;
            m_CTPanel.ADSync = ADSync;
            try {
                (panel1.Controls[0] as ICounterConfigPanel).WriteConfigToPanel();
                m_CTPanel.ParentForm.RecreateCTChannels();
            }
            catch {

            }

            Close();
        }

        private void Mode_CheckedChanged(object sender, EventArgs e) {
            panel1.Controls.Clear();

            if (rbImpulse.Checked) {
                panel1.Controls.Add(new CounterConfigPanelImpulse(m_CTPanel));
            }
            if (rbFreq.Checked) {
                panel1.Controls.Add(new CounterConfigPanelFrequency(m_CTPanel));
            }
            if (rbPeriod.Checked) {
                panel1.Controls.Add(new CounterConfigPanelPeriodPulsewidth(m_CTPanel));
            }

            if (rbPulsewidth.Checked) {
                panel1.Controls.Add(new CounterConfigPanelPeriodPulsewidth(m_CTPanel));
            }
            if (rbUpDown.Checked) {
                panel1.Controls.Add(new CounterConfigPanelUpDown(m_CTPanel));
            }
            if (rbIncremental.Checked) {
                panel1.Controls.Add(new CounterConfigPanelIncremental(m_CTPanel));
            }
            if (rbIncExtTime.Checked) {
                panel1.Controls.Add(new CounterConfigPanelIncExtTimestamp(m_CTPanel));
            }



        }

        #endregion
        
        #region internal

        internal bool ADSync {
            get {
                return checkBoxSyncToAD.Checked;

            }
        }

        internal CounterMode Mode {
            get {
                if (rbImpulse.Checked)
                    return CounterMode.IMPULSECOUNTER;
                if (rbFreq.Checked)
                    return CounterMode.FREQUENCYCOUNTER;
                if (rbPeriod.Checked)
                    return CounterMode.PERIODCOUNTER;
                if (rbPulsewidth.Checked)
                    return CounterMode.PULSEWIDTHCOUNTER;
                if (rbUpDown.Checked)
                    return CounterMode.UPDOWNCOUNTER;
                if (rbIncremental.Checked)
                    return CounterMode.INCREMENTALCOUNTER;
                if (rbIncExtTime.Checked)
                    return CounterMode.INCEEXTTIMESTAMP;
                if (rbIncExtFlow.Checked)
                    return CounterMode.INCEEXTFLOWRATE;
                return CounterMode.UNDEFINED;
            }
            set {
                rbImpulse.Checked = false;
                rbFreq.Checked = false;
                rbPeriod.Checked = false;
                rbPulsewidth.Checked = false;
                rbUpDown.Checked = false;
                rbIncremental.Checked = false;
                rbIncExtTime.Checked = false;
                rbIncExtFlow.Checked = false;

                switch (value) {
                    case CounterMode.IMPULSECOUNTER: rbImpulse.Checked = true; break;
                    case CounterMode.FREQUENCYCOUNTER: rbFreq.Checked = true; break;
                    case CounterMode.PERIODCOUNTER: rbPeriod.Checked = true; break;
                    case CounterMode.PULSEWIDTHCOUNTER: rbPulsewidth.Checked = true; break;
                    case CounterMode.UPDOWNCOUNTER: rbUpDown.Checked = true; break;
                    case CounterMode.INCREMENTALCOUNTER: rbIncremental.Checked = true; break;
                    case CounterMode.INCEEXTTIMESTAMP: rbIncExtTime.Checked = true; break;
                    case CounterMode.INCEEXTFLOWRATE: rbIncExtFlow.Checked = true; break;


                }
            }
        }
        
        #endregion

        #region public

        public CTSetup() {
            InitializeComponent();
        }

        public CTSetup(CTChannel AIMyPanel) {
            m_CTPanel = AIMyPanel;
            InitializeComponent();
            rbIncremental.Enabled = m_CTPanel.Channel.IsCounterModeAvailable(CounterMode.INCREMENTALCOUNTER);
            rbIncExtFlow.Enabled = m_CTPanel.Channel.IsCounterModeAvailable(CounterMode.INCEEXTFLOWRATE);
            rbIncExtTime.Enabled = m_CTPanel.Channel.IsCounterModeAvailable(CounterMode.INCEEXTTIMESTAMP);
            
            
            rbImpulse.Enabled = m_CTPanel.Channel.IsCounterModeAvailable(CounterMode.IMPULSECOUNTER);
            rbFreq.Enabled = m_CTPanel.Channel.IsCounterModeAvailable(CounterMode.FREQUENCYCOUNTER);
            rbPeriod.Enabled = m_CTPanel.Channel.IsCounterModeAvailable(CounterMode.PERIODCOUNTER);
            rbPulsewidth.Enabled = m_CTPanel.Channel.IsCounterModeAvailable(CounterMode.PULSEWIDTHCOUNTER);
            
             
            rbUpDown.Enabled = m_CTPanel.Channel.IsCounterModeAvailable(CounterMode.UPDOWNCOUNTER);
            checkBoxSyncToAD.Enabled = m_CTPanel.Channel.MyDevice.IsDSPDevice;
            Mode = m_CTPanel.Mode;
            checkBoxSyncToAD.Checked = m_CTPanel.ADSync;

        } 

        #endregion

   
    }
}
