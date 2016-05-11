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
    public partial class FormConfigPeriodCounter : Form {


        public FormConfigPeriodCounter() {
            InitializeComponent();
            comboBoxFCtResulution.Items.Clear();
            foreach (object o in Enum.GetValues(typeof(CounterResolution))) {
                comboBoxFCtResulution.Items.Add(o);
            }
        }

        internal int SingalEdge {
            get {
                return comboBoxSignalEdge.SelectedIndex;
            }
            set {
                comboBoxSignalEdge.SelectedIndex = value;
            }
        }

        internal int Reslution {
            get {
                return comboBoxFCtResulution.SelectedIndex;
            }
            set {
                comboBoxFCtResulution.SelectedIndex = value;
            }
        }
    }
}
