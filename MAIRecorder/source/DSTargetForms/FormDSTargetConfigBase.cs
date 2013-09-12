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
        public FormDSTargetConfigBase() {
            InitializeComponent();
        }
        protected IDataSinkTarget m_target;
        protected String m_TargetFileName = "not set.";
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
            if (dts == null){
                return null;
            }
            if (dts.ShowDialog() == DialogResult.OK){
                AOString = dts.m_TargetFileName;
                return dts.m_target;
            }
            return null;
        }

        protected virtual void CreateTarget() { 
        }

        private void button1_Click(object sender, EventArgs e) {
            CreateTarget();
        }
    }
}
