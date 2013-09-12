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
    public partial class UCConterValue : UserControl {
        public UCConterValue() {
            InitializeComponent();
        }
     //   MAIMeasurementChannelCT m_channel;
        CTChannel m_CardFormChannel;
        FormMeasureCT m_ParentForm;
        internal void SetMChannel(CTChannel AICardformChannelCT, FormMeasureCT AIParentForm) {
            m_CardFormChannel = AICardformChannelCT;
            labelChanneltype.Text = m_CardFormChannel.GetMeasurementType();
            labelChannel.Text = m_CardFormChannel.GetMeasurementChannelCaption();
            label1.Visible = m_CardFormChannel.MChan.IsADSync;
            m_ParentForm = AIParentForm;
        }

        internal bool ADSync {
            get {
                return m_CardFormChannel.MChan.IsADSync;
            }
        }

        internal void Update() {
            try {
                uint len = m_CardFormChannel.MChan.NumberOfValues;
                uint[] val = m_CardFormChannel.MChan.ReadData(len);
                if(val.Length > 0)
                    textBoxValue.Text = String.Format("{0,8:X8}", val[0]);
            }
            catch(Exception s){
            
            }

        }

       

        private void textBoxValue_MouseClick(object sender, MouseEventArgs e) {
            // geht nicht !!

            //if (!m_ParentForm.ConfigEnabled)
            //    return;
            //m_CardFormChannel.ShowConfig();
            //labelChanneltype.Text = m_CardFormChannel.GetMeasurementType();
            //labelChannel.Text = m_CardFormChannel.GetMeasurementChannelCaption();
            //label1.Visible = m_CardFormChannel.MChan.IsADSync;
            //m_ParentForm.ReconfigureChannels();
        }




        internal void CreateMchan() {
            m_CardFormChannel.CreateTmpMeaschan();
        }
    }
}
