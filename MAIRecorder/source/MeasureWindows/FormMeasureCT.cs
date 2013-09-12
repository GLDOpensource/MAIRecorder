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
    public partial class FormMeasureCT : Form {

        #region private

        #region fields
         
        private CardWindow m_ParentWindow;
        
        #endregion

        #region ui_event_handlers

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            Color tmp = checkBox1.ForeColor;
            checkBox1.ForeColor = checkBox1.BackColor;
            checkBox1.BackColor = tmp;
            if (checkBox1.Checked)
                m_ParentWindow.MAIDevice.ADChannels.StartMeasurement();
            else
                m_ParentWindow.MAIDevice.ADChannels.StopMeasurement();

            ConfigEnabled = !checkBox2.Checked && !checkBox1.Checked;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            Color tmp = checkBox2.ForeColor;
            checkBox2.ForeColor = checkBox2.BackColor;
            checkBox2.BackColor = tmp;
            if (checkBox2.Checked)
                m_ParentWindow.MAIDevice.CTChannels.StartMeasurement();
            else
                m_ParentWindow.MAIDevice.CTChannels.StopMeasurement();
            ConfigEnabled = !checkBox2.Checked && !checkBox1.Checked;

        }

        private void timer1_Tick(object sender, EventArgs e) {
            foreach (UCConterValue c in flpChannels.Controls) {
                c.UpdateTextBox();
            }
        }

        private void FormMeasureCT_FormClosed(object sender, FormClosedEventArgs e) {
            m_ParentWindow.MAIDevice.StopMeasure();
            m_ParentWindow.MAIDevice.ClearAllChannelLists();
            timer1.Enabled = false;
        }

        #endregion
        
        #endregion

        #region internal

        #region properties

        internal bool ConfigEnabled {
            get;
            private set;
        }

        #endregion

        #region methods

        internal void ReconfigureChannels() {
            int CTList = 0;
            int ADList = 0;
            m_ParentWindow.MAIDevice.ClearAllChannelLists();
            foreach (UCConterValue c in flpChannels.Controls) {
                c.CreateMchan();
                if (c.ADSync)
                    ADList++;
                else
                    CTList++;

            }
            tbNoChannelsAD.Text = ADList.ToString();
            tbNoChannelsCT.Text = CTList.ToString();
            checkBox1.Enabled = (ADList > 0);
            checkBox2.Enabled = (CTList > 0);
            m_ParentWindow.MAIDevice.CTChannels.SetSampleRate((double)m_ParentWindow.nudSRCT.Value);
            m_ParentWindow.MAIDevice.ADChannels.SetSampleRate((double)m_ParentWindow.nudSRDA.Value);
            m_ParentWindow.MAIDevice.ConfigMeasure();
        }

        #endregion

        #endregion

        #region public

        public FormMeasureCT() {
            InitializeComponent();
        }

        public FormMeasureCT(CardWindow AIParentWindow) {

            InitializeComponent();
            m_ParentWindow = AIParentWindow;
            m_ParentWindow.checkBoxUpdate.Checked = false;
            tbFreqCT.Text = m_ParentWindow.nudSRCT.Value.ToString();
            tbFreqAD.Text = m_ParentWindow.nudSRDA.Value.ToString();
            flpChannels.Controls.Clear();
            foreach (CTChannel c in m_ParentWindow.flpCT.Controls) {
                UCConterValue cv = new UCConterValue();
                cv.SetMChannel(c, this);
                flpChannels.Controls.Add(cv);
            }
            ReconfigureChannels();
            ConfigEnabled = true;
        }

        #endregion 
    }
}
