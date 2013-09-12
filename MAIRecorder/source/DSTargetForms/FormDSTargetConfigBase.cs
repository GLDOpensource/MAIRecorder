using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Goldammer.MAIExtensions.DAQ;
using Goldammer;

namespace MAIRecorder {
    public partial class FormDSTargetConfigBase : Form {

        #region private

        private void button1_Click(object sender, EventArgs e) {
            CreateTarget();
        } 

        #endregion

        #region protected

        protected IDataSinkTarget m_target;

        protected String m_TargetFileName = "not set.";

        protected virtual void CreateTarget() {
        } 

        #endregion

        #region public
        
        public FormDSTargetConfigBase() {
            InitializeComponent();
        }

        public static IDataSinkTarget ShowAsDialog(string AIMenuText, out string AOString) {
            FormDSTargetConfigBase dts = null;
            AOString = "not set.";

            if (AIMenuText.StartsWith("CSV"))
                dts = new FormDSTargetCSV();
            if (AIMenuText.StartsWith("RAW"))
                dts = new FormDSTargetRAW();
            if (AIMenuText.StartsWith("TDMS"))
                dts = new FormDSTargetTDMS();
            if (AIMenuText.StartsWith("TAFF"))
                dts = new FormDSTargetTAFFMAT();
            if (AIMenuText.StartsWith("Database"))
                dts = new FormDSTargetDB();
            if (AIMenuText.StartsWith("WAV"))
                dts = new FormDSTargetWAV();
            if (dts == null) {
                return null;
            }
            if (dts.ShowDialog() == DialogResult.OK) {
                AOString = dts.m_TargetFileName;
                return dts.m_target;
            }
            return null;
        }
     
        #endregion
     
    }
}
