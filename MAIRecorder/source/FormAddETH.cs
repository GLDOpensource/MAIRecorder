using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Goldammer;
using System.Net;

namespace MAIRecorder {
    public partial class FormAddETH : Form {

        #region private

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void bAddETH_Click(object sender, EventArgs e) {

            IPAddress adr;
            uint port;
            if (!IPAddress.TryParse(tbIPAddress.Text, out adr)) {
                MessageBox.Show(Messages.ETHErrorText_IPAdress,Messages.ETHErrorCaption);
                return;
            }

            if (!uint.TryParse(TbIPPort.Text, out port)) {
                MessageBox.Show(Messages.ETHErrorText_IPPort, Messages.ETHErrorCaption);
                return;
            }
            int UDPport;

            if (!Int32.TryParse(textBoxUDP.Text, out UDPport)) {
                textBoxUDP.Text = "-1";
                UDPport = -1;
                MessageBox.Show(Messages.ETHErrorText_UDPPort, Messages.ETHErrorCaption);
            }

            IPEndPoint ep = new IPEndPoint(adr, (int)port);
            try {
                MAI.Devices.ConnectRemoteDevice(ep, UDPport);
                Close();
            }
            catch (Exception x) {
                MessageBox.Show(Messages.ETHErrorText_NoConnection, Messages.ETHErrorCaption);
            }
        }

        #endregion

        #region internal

        internal static DialogResult Show() {
            FormAddETH me = new FormAddETH();
            return me.ShowDialog();
        }

        #endregion

        #region public

        public FormAddETH() {
            InitializeComponent();
        }

        #endregion

    }
}
