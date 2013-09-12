﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAIRecorder {
    public partial class FormConfigPeriodCounter : Form {
        public FormConfigPeriodCounter() {
            InitializeComponent();
        }

        public int SingalEdge {
            get {
                return comboBoxSignalEdge.SelectedIndex;
            }
            set {
                comboBoxSignalEdge.SelectedIndex = value;
            }
        }

        public int Reslution {
            get {
                return comboBoxFCtResulution.SelectedIndex;
            }
            set {
                comboBoxFCtResulution.SelectedIndex = value;
            }
        }
    }
}
