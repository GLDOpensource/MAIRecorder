using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAIRecorder {
    public partial class ADChannel : UserControl {
        public ADChannel() {
            InitializeComponent();
        }
    
        private int n_ChannelNr;
        public int Number{
            get{
                return n_ChannelNr;
            }
            set{
                n_ChannelNr = value;
                labelChannel.Text = "K" + string.Format("{0:00}", n_ChannelNr);
            }

        
        }
    }
}
