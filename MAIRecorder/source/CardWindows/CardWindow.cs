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
    public partial class CardWindow : Form {
        public CardWindow() {
            InitializeComponent();
            timer1.Enabled = checkBoxUpdate.Checked;
            timer1.Interval = (int)numericUpDown1.Value;
            ToolTip ADToolTip = CreateTooltip("AD Channels");
            ADToolTip.SetToolTip(flpADChannels, "Click on the Channel's name to configure it.");
            ADToolTip.SetToolTip(panelAD, "Click on the Channel's name to configure it.");
            ToolTip DIOToolTip = CreateTooltip("TTL Pins");
            DIOToolTip.SetToolTip(flpDIOChannels, "Click coloured HI/LO label to switch the state of an output.");
            DIOToolTip.SetToolTip(panelDIO, "Click coloured HI/LO label to switch the state of an output.");


        }

        public ToolTip CreateTooltip(string AITitle) {
            ToolTip tt = new ToolTip();
            tt.ToolTipTitle = AITitle;
            tt.UseFading = true;
            tt.UseAnimation = true;
            tt.IsBalloon = true;
            tt.ShowAlways = true;
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 100;
            tt.ReshowDelay = 500;
            return tt;
        }

        public void checkBoxUpdate_CheckedChanged(object sender, EventArgs e) {
            timer1.Enabled = checkBoxUpdate.Checked;
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            timer1.Interval = (int)numericUpDown1.Value;
        }

        public void InsertChannels(MAIDevice selected) {
            flpADChannels.Controls.Clear();
            for (int i = 0; i < selected.ADChannels.Count(); i++) {
                ADChannelSmall nc = new ADChannelSmall(selected.ADChannels[i]);
              
                flpADChannels.Controls.Add(nc);
            }
            flpDAChannels.Controls.Clear();
            for (int i = 0; i < selected.DAChannels.Count(); i++) {
                DAChannelSmall nc = new DAChannelSmall(selected.DAChannels[i]);
                flpDAChannels.Controls.Add(nc);
            }
            flpDIOChannels.Controls.Clear();
            for (int i = 0; i < selected.TTLChannels.Count(); i++) {
                DIOChannel nc = new DIOChannel(selected.TTLChannels[i]);
                flpDIOChannels.Controls.Add(nc);
            }
            flpCT.Controls.Clear();
            for (int i = 0; i < selected.CTChannels.Count(); i++) {
                CTChannel nc = new CTChannel(selected.CTChannels[i], this);
                flpCT.Controls.Add(nc);
            }
        }

        public MAIDevice m_maiDevice;

        public static void Show(MAIDevice AIDevice) {
            AIDevice.DAChannels.SetRange(DARange.Bipolar);
            
            CardWindow me = new CardWindow();
            me.m_maiDevice = AIDevice;
            if (me.m_maiDevice.Properties.ADChannels.Count > 0) {
                if (me.m_maiDevice.Properties.ADChannels[0].IEPEMode > 0)
                    me.bIEPE_OFF.Visible = true;
            }
            me.m_maiDevice.StopMeasure();
            me.m_maiDevice.DAChannels.StopOutput();
            me.m_maiDevice.ClearAllChannelLists();
             
          
            bool ADVisible = AIDevice.ADChannels.Count() > 0;
            bool DAVisible = AIDevice.DAChannels.Count() > 0; 
            bool CTVisible = AIDevice.CTChannels.Count() > 0;
            bool DIOVisible = AIDevice.TTLChannels.Count() > 0; 
            bool PWMVisible = AIDevice.PWMChannels.Count > 0;
            Panel lastVisible = null;

            me.panelAD.Visible = ADVisible;
            me.splitterAD.Visible = ADVisible;
            if (ADVisible)
                lastVisible = me.panelAD;
            me.panelDA.Visible = DAVisible;
            me.splitterDA.Visible = DAVisible;
            if (DAVisible) {
                lastVisible = me.panelDA;
            }
            me.panelDIO.Visible = DIOVisible;
            me.splitterDIO.Visible = DIOVisible;
            me.splitterDIO.Enabled = DIOVisible;
            if (DIOVisible)
                lastVisible = me.panelDIO;

            me.panelCT.Visible = CTVisible;

            if (CTVisible) {
                lastVisible = me.panelCT;

            }
            else {
               
                    me.splitterDIO.Visible = false;
                    me.splitterDIO.Enabled = false;

              
            }
            if (lastVisible != null)
                lastVisible.Dock = DockStyle.Fill;
            me.Text = AIDevice.Info.SerialNumber;
            me.groupBoxDARange.Enabled = !AIDevice.IsUSBBasicDevice;
            me.buttonDAOutput.Enabled = DAVisible;
            me.buttonMeasrement.Enabled = ADVisible;
            me.buttonCTMeasure.Enabled = CTVisible;
            me.buttonPWM.Enabled = PWMVisible;
            me.ShowDialog();
            me.Dispose();
        }

        public void CardWindow_Load(object sender, EventArgs e) {
            InsertChannels(m_maiDevice);
           
          // panelCT.Height = flpCT.ClientRectangle.Height;
           
          

          //  panelDIO.Height = flpDIOChannels.ClientRectangle.Height;
            

        
           panelDA.Height = flpDAChannels.Controls.Count * 45;


           panelAD.Height = flpADChannels.Controls.Count* 25/ 4 ;
           if (panelAD.Height < 110) {
               panelAD.Height = 110;
           }
       
 
        }

        public void timer1_Tick(object sender, EventArgs e) {
            if (cbUpdateADPerm.Checked)
                bUpdateAD.PerformClick();
            if (cbUpdateTTLPerm.Checked)
                bUpdateTTL.PerformClick();
            if (cbUpdateCTPerm.Checked)
                bUpdateCT.PerformClick();
        
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e) {
            DARange newReange = DARange.Bipolar;
            if (radioButtonOnlyPosDA.Checked)
                newReange = DARange.Unipolar;

            m_maiDevice.DAChannels.SetRange(newReange);
            UpdateDaChannelsRange(newReange);

        }

        //private void ReconfigureCTChannels() {
        //    m_maiDevice.ClearAllChannelLists();
        //    foreach (CTChannel nc in flpCT.Controls)
        //        nc.CreateMeasurementChannel();
        //}

        public void UpdateDaChannelsRange(DARange Range) {
            foreach (DAChannelSmall nc in flpDAChannels.Controls)
                nc.UpdateRange(Range);
        }

        public void RecreateCTChannels() {
            m_maiDevice.ClearAllChannelLists();
            foreach (CTChannel nc in flpCT.Controls)
                nc.CreateTmpMeaschan();
        }

        public void bUpdateAD_Click(object sender, EventArgs e) {
            foreach (ADChannelSmall nc in flpADChannels.Controls)
                nc.UpdateVolt();
        }

        public void bUpdateTTL_Click(object sender, EventArgs e) {
            foreach (DIOChannel nc in flpDIOChannels.Controls)
                nc.UpdateState(false);
        }

        public void bUpdateCT_Click(object sender, EventArgs e) {
            if (flpCT.Controls.Count != m_maiDevice.CTChannels.GetMeasurementChannels().Count) {
                foreach (CTChannel nc in flpCT.Controls)
                    nc.CreateTmpMeaschan();
            
            }

            foreach (CTChannel nc in flpCT.Controls) 
                nc.Update();
        }

        public void CardWindow_FormClosed(object sender, FormClosedEventArgs e) {
            try {
                if (m_maiDevice != null)
                    m_maiDevice.ClearAllChannelLists();
            }
            catch (Exception x) {
                MessageBox.Show(x.Message);
            
            }
        }

        public void bIEPE_OFF_Click(object sender, EventArgs e) {
            try {
                m_maiDevice.ADChannels.ResetIEPE();
                foreach (ADChannelSmall nc in flpADChannels.Controls) {
                    nc.IEPEIndex = 0;
                    nc.IEPEGain20dB = false;
                }
            }
            catch (Exception x) {
                MessageBox.Show(x.Message);

            }
        }

        public void buttonMeasrement_Click(object sender, EventArgs e) {
             try{
                FormMeasureAD mad = new FormMeasureAD(this);
                mad.ShowDialog();
                m_maiDevice.StopMeasure();
                m_maiDevice.ADChannels.DataSink.Disable();

                m_maiDevice.ADChannels.DataSink.Target = null;
                
                m_maiDevice.ClearAllChannelLists();
             }
             catch (Exception x) {
                 m_maiDevice.StopMeasure();
                 m_maiDevice.ADChannels.DataSink.Disable();

                 m_maiDevice.ADChannels.DataSink.Target = null;

                 m_maiDevice.ClearAllChannelLists();
                 MessageBox.Show(x.Message);

             }
        }

        private void buttonCardConfig_Click(object sender, EventArgs e) {
            try {
                FormOutputWaveForms outwav = new FormOutputWaveForms(this);
                outwav.ShowDialog();
                m_maiDevice.StopMeasure();
                m_maiDevice.DAChannels.StopOutput();
                m_maiDevice.DAChannels.ClearProcessDataBufferEventHandlers();
                m_maiDevice.DAChannels.StopNotificationThread();


                m_maiDevice.ClearAllChannelLists();
            }
            catch (Exception x) {
                m_maiDevice.StopMeasure();
                m_maiDevice.DAChannels.StopOutput();
                m_maiDevice.ClearAllChannelLists();
                m_maiDevice.DAChannels.ClearProcessDataBufferEventHandlers();
                m_maiDevice.DAChannels.StopNotificationThread();

                MessageBox.Show(x.Message);

            }
        }

        private void buttonPWM_Click(object sender, EventArgs e) {
            try {
                m_maiDevice.StopMeasure();
                FormOutput_PWM_FM outpwm = new FormOutput_PWM_FM(this);
                outpwm.ShowDialog();
                m_maiDevice.PWMChannels.StopOutput();

                m_maiDevice.ClearAllChannelLists();
            }
            catch (Exception x) {
                m_maiDevice.PWMChannels.StopOutput();

                m_maiDevice.StopMeasure();
                m_maiDevice.ClearAllChannelLists();
                MessageBox.Show(x.Message);

            }
        }

        private void buttonCTMeasure_Click(object sender, EventArgs e) {
            try {
                FormMeasureCT recCT = new FormMeasureCT(this);
                recCT.ShowDialog();
                m_maiDevice.StopMeasure();


                m_maiDevice.ClearAllChannelLists();
            }
            catch (Exception x) {
                m_maiDevice.StopMeasure();
                m_maiDevice.ClearAllChannelLists();
                MessageBox.Show(x.Message);

            }
        }

    }
}
