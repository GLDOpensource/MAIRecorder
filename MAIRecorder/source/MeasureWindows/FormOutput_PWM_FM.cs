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
    public partial class FormOutput_PWM_FM : Form {

        #region private

        #region fields

        CardWindow m_ParentWindow;

        #endregion


        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            Color tmp = checkBox1.ForeColor;
            checkBox1.ForeColor = checkBox1.BackColor;
            checkBox1.BackColor = tmp;

            foreach (UCOutputSettingsPWMChannel ch in flpChannels.Controls) {
                ch.ConfigureOutput(!checkBox1.Checked);
            }

            if (checkBox1.Checked) {
                m_ParentWindow.MAIDevice.PWMChannels.StartOutput();
            }
            else {
                m_ParentWindow.MAIDevice.PWMChannels.StopOutput();
            }


        }

        #endregion

        #region public

        public FormOutput_PWM_FM() {
            InitializeComponent();
        }

        public FormOutput_PWM_FM(CardWindow AIParentWindow) {

            InitializeComponent();
            m_ParentWindow = AIParentWindow;
            m_ParentWindow.checkBoxUpdate.Checked = false;
            flpChannels.Controls.Clear();
            for (int i = 0; i < m_ParentWindow.MAIDevice.PWMChannels.Count; i++) {
                UCOutputSettingsPWMChannel cv = new UCOutputSettingsPWMChannel();
                cv.SetNameAndChannel("Channel " + i.ToString(), m_ParentWindow.MAIDevice.PWMChannels[i]);
                flpChannels.Controls.Add(cv);
            }



        }
        
        #endregion

    }
}
