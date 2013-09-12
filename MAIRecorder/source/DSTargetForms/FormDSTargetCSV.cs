using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Goldammer.MAIExtensions.DAQ;
using System.Globalization;
using System.IO;

namespace MAIRecorder {
    public partial class FormDSTargetCSV : MAIRecorder.FormDSTargetConfigBase {
        public FormDSTargetCSV() {
            InitializeComponent();
            textBoxMetaName.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MetaOutput.csv";
            textBoxFilenameMain.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataOutput.csv";
        }

        protected override void CreateTarget() {
            m_TargetFileName = Path.GetFileName(textBoxFilenameMain.Text) + " (CSV File)";
            if (checkBoxWriteMeta.Checked) {
                m_target = MAIDataSinkTarget.CreateTargetCSV(textBoxFilenameMain.Text, textBoxMetaName.Text, checkBoxAppendTo.Checked, GetSeparatorChar(), GetFormatProvider(), false);
                
            }
            else {
                m_target = MAIDataSinkTarget.CreateTargetCSV(textBoxFilenameMain.Text, checkBoxAppendTo.Checked, GetSeparatorChar(), GetFormatProvider());
            }
        }

        private IFormatProvider GetFormatProvider() {
            if (radioButtonDE.Checked)
                return new CultureInfo("de-DE");
            return new CultureInfo("en-US");
        }

        private char GetSeparatorChar() {
            if (radioButtonSepColon.Checked)
                return ',';
            if (radioButtonSepSemi.Checked)
                return ';';
            return '\t';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            textBoxMetaName.Enabled = checkBoxWriteMeta.Checked;
            buttonSetMetaFile.Enabled = checkBoxWriteMeta.Checked;
        }

        private void buttonSetFilename_Click(object sender, EventArgs e) {
            saveFileDialog1.Title = "Select data output file";
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(textBoxFilenameMain.Text);
            saveFileDialog1.FileName = Path.GetFileName(textBoxFilenameMain.Text);
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            textBoxFilenameMain.Text = saveFileDialog1.FileName;
        }

        private void buttonSetMetaFile_Click(object sender, EventArgs e) {
            saveFileDialog1.Title = "Select header output file";
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(textBoxMetaName.Text);
            saveFileDialog1.FileName = Path.GetFileName(textBoxMetaName.Text);
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            textBoxMetaName.Text = saveFileDialog1.FileName;
        }

    }
}
