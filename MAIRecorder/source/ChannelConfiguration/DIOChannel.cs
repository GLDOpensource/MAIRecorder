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
    public partial class DIOChannel : UserControl {

        #region private

        #region fields

        private MAIChannelTTL m_channel;

        #endregion

        #region ui_event_handlers

        private void checkBoxDirection_CheckedChanged(object sender, EventArgs e) {

            if (checkBoxDirection.Checked) {
                m_channel.SetChannelDirection(IODirection.Output);
                m_channel.WriteBit(State);
            }
            else {
                m_channel.SetChannelDirection(IODirection.Input);
                State = m_channel.ReadBit();
                SetUIState(State);
            }

        }

        private void labelState_Click(object sender, MouseEventArgs e) {
            if (checkBoxDirection.Checked) {
                SwitchState();
                m_channel.WriteBit(State);
            }
        }

     
        #endregion
        
        #region methods

        private void SetUIState(IOBitState state) {
            if (state == IOBitState.High) {
                labelState.Text = "HI";
                labelState.BackColor = Color.Yellow;
                labelState.ForeColor = Color.Black;
            }
            else {
                labelState.Text = "LO";
                labelState.BackColor = Color.Black;
                labelState.ForeColor = Color.Yellow;
            }
        }

        private void SwitchState() {
            if (State == IOBitState.Low)
                State = IOBitState.High;
            else
                State = IOBitState.Low;

        }
        #endregion

        #endregion

        #region internal

        internal IOBitState State {
            get;
            set;
        }

        internal MAIChannelTTL Channel {
            get {
                return m_channel;
            }
            set {
                m_channel = value;
                labelChannel.Text = "Pin" + string.Format("{0:00}", m_channel.HardwareChannelNumber);
            }
        }

        internal void UpdateState(bool AITestDirection) {
            IODirection dir = m_channel.GetChannelDirection();
            if (AITestDirection) {
                //try{
                //     if (dir == IODirection.Input)
                //         m_channel.SetChannelDirection(IODirection.Output);
                //       else
                //         m_channel.SetChannelDirection(IODirection.Input);
                //     m_channel.SetChannelDirection(dir);
                // }
                //catch{
                //    checkBoxDirection.Enabled = false;
                //    if (dir == IODirection.Output)
                //        m_channel.WriteBit(State);
                //}
                if (m_channel.IsDirectionFixed()) {
                    checkBoxDirection.Enabled = false;

                }


            }
            if (dir == IODirection.Input)
                checkBoxDirection.Checked = false;
            else
                checkBoxDirection.Checked = true;
            if (!checkBoxDirection.Checked)
                State = m_channel.ReadBit();
            SetUIState(State);
        }

        #endregion
        
        #region public

        public DIOChannel() {
            InitializeComponent();
        }

        public DIOChannel(MAIChannelTTL AIChannel) {
            InitializeComponent();
            Channel = AIChannel;
            UpdateState(true);

        }
        
        #endregion
       
    }
}
