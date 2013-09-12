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
        public FormOutput_PWM_FM() {
            InitializeComponent();
        }

          CardWindow m_ParentWindow;
          public FormOutput_PWM_FM(CardWindow AIParentWindow) {

            InitializeComponent();
            m_ParentWindow = AIParentWindow;
            m_ParentWindow.checkBoxUpdate.Checked = false;
            flpChannels.Controls.Clear();
            for (int i = 0; i < m_ParentWindow.m_maiDevice.PWMChannels.Count; i++ ) {
                UCOutputSettingsPWMChannel cv = new UCOutputSettingsPWMChannel();
                cv.SetNameAndChannel("Channel " + i.ToString(), m_ParentWindow.m_maiDevice.PWMChannels[i]); 
                flpChannels.Controls.Add(cv);
            }
          
           

        }

          private void checkBox1_CheckedChanged(object sender, EventArgs e) {
              Color tmp = checkBox1.ForeColor;
              checkBox1.ForeColor = checkBox1.BackColor;
              checkBox1.BackColor = tmp;
              
              foreach (UCOutputSettingsPWMChannel ch in flpChannels.Controls) {
                  ch.ConfigureOutput(!checkBox1.Checked);
              }              
              
              if (checkBox1.Checked) {
                  m_ParentWindow.m_maiDevice.PWMChannels.StartOutput();
              }
              else {
                  m_ParentWindow.m_maiDevice.PWMChannels.StopOutput();
              }


          }

    }
}
