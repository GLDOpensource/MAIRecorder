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
    public partial class FormOutputWaveForms : Form, IDisposable {

        #region private

        #region fields

        private MAIMeasurementBufferEvent getDateEvent;
        private CardWindow m_ParentWindow;

        #endregion

        #region ui_event_handlers

        private void flpGenerators_Resize(object sender, EventArgs e) {
            foreach (UCFuncGenChan a in flpGenerators.Controls) {
             
                a.SetNewWidth(flpGenerators.Width - 10);
                
            }
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            m_ParentWindow.MAIDevice.DAChannels.StopNotificationThread();
            m_ParentWindow.MAIDevice.StopMeasure();
            m_ParentWindow.MAIDevice.DAChannels.StopOutput();
            m_ParentWindow.MAIDevice.ClearAllChannelLists();

            Color tmp = checkBox1.ForeColor;
            checkBox1.ForeColor = checkBox1.BackColor;
            checkBox1.BackColor = tmp;
            foreach (UCFuncGenChan a in flpGenerators.Controls) {

                a.ActiveEnabled = !checkBox1.Checked;

            }
            if (checkBox1.Checked)
                StartOutout();
        }

        private void FormOutputWaveForms_FormClosed(object sender, FormClosedEventArgs e) {
            m_ParentWindow.MAIDevice.DAChannels.ProcessDataBuffers -= getDateEvent;
        }

        #endregion

        #region mai_event_handlers

        private void DAChannels_ProcessDataBuffers(object obj, EventArgs args) {
            foreach (UCFuncGenChan a in flpGenerators.Controls) {
                if (!a.Active)
                    continue;
                uint numVal = a.MChannel.GetFifoSpace();
                double[] values = a.Next((int)numVal);
                a.MChannel.WriteScaledData(values, 0, numVal);
            }
        }

        #endregion

        #region methods

        private void StartOutout() {
            foreach (UCFuncGenChan a in flpGenerators.Controls) {
                if (!a.Active)
                    continue;
                a.MChannel = a.Channel.CreateOutputChannel();
            }
            m_ParentWindow.MAIDevice.DAChannels.SetSampleRate((double)m_ParentWindow.nudSRDA.Value);
            m_ParentWindow.MAIDevice.ConfigMeasure();
            m_ParentWindow.MAIDevice.DAChannels.SetMeasurementBufferNotificationLevel((uint)m_ParentWindow.nudSRDA.Value / 2);
            m_ParentWindow.MAIDevice.DAChannels.StartNotificationThread();

            m_ParentWindow.MAIDevice.DAChannels.StartOutput();
        }

        #endregion
            
        #region IDisposable Member

        void  IDisposable.Dispose() {
            m_ParentWindow.MAIDevice.StopMeasure();
            m_ParentWindow.MAIDevice.DAChannels.StopOutput();
            m_ParentWindow.MAIDevice.DAChannels.StopNotificationThread();
            m_ParentWindow.MAIDevice.DAChannels.ProcessDataBuffers -= getDateEvent;
             base.Dispose();

        }

        #endregion

        #endregion

        #region public

        public FormOutputWaveForms() {
            InitializeComponent();
        }

        public FormOutputWaveForms(CardWindow AIParentWindow) {

            InitializeComponent();
            m_ParentWindow = AIParentWindow;
            m_ParentWindow.checkBoxUpdate.Checked = false;
            foreach (DAChannelSmall a in m_ParentWindow.flpDAChannels.Controls) {
                UCFuncGenChan tmp = new UCFuncGenChan();
                tmp.LabelName = a.labelChannel.Text;
                tmp.SetNewWidth(flpGenerators.Width - 10);
                tmp.MinimumRange = -10;
                tmp.SampleRate = (int)m_ParentWindow.nudSRDA.Value;
                tmp.Channel = a.Channel;
                if (m_ParentWindow.radioButtonOnlyPosDA.Checked) {
                    tmp.MinimumRange = 0;

                }
                tmp.Init();
                flpGenerators.Controls.Add(tmp);
            }
            getDateEvent = new MAIMeasurementBufferEvent(DAChannels_ProcessDataBuffers);
            m_ParentWindow.MAIDevice.DAChannels.ProcessDataBuffers += getDateEvent;

        }

        #endregion

}
}
