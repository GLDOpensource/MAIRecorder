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

        #region private

        private CTChannel m_CardFormChannel;
        private FormMeasureCT m_ParentForm;
   
        #endregion

        #region internal

        #region properties

        internal bool ADSync {
            get {
                return m_CardFormChannel.MChan.IsADSync;
            }
        }
        
        #endregion

        #region methods

        internal void UpdateTextBox() {
            try {
                uint len = m_CardFormChannel.MChan.NumberOfValues;
                uint[] val = m_CardFormChannel.MChan.ReadData(len);
                if (val.Length > 0)
                    textBoxValue.Text = String.Format("{0,8:X8}", val[0]);
            }
            catch (Exception s) {

            }

        }

        internal void SetMChannel(CTChannel AICardformChannelCT, FormMeasureCT AIParentForm) {
            m_CardFormChannel = AICardformChannelCT;
            labelChanneltype.Text = m_CardFormChannel.GetMeasurementType();
            labelChannel.Text = m_CardFormChannel.GetMeasurementChannelCaption();
            label1.Visible = m_CardFormChannel.MChan.IsADSync;
            m_ParentForm = AIParentForm;
        }

        internal void CreateMchan() {
            m_CardFormChannel.CreateTmpMeaschan();
        }

        #endregion
        
        #endregion

        #region public

        public UCConterValue() {
            InitializeComponent();
        }
        
        #endregion
  
    }
}
