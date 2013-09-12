using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Goldammer.MAIExtensions.DAQ;
using System.IO;
using System.Security.Principal;

namespace MAIRecorder {
    public partial class FormDSTargetTDMS : MAIRecorder.FormDSTargetConfigBase {
        public FormDSTargetTDMS() {
            InitializeComponent();
            textBoxFilenameMain.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Output.tdms";
            textBoxAuthor.Text = WindowsIdentity.GetCurrent().Name;
        }
        protected override void CreateTarget() {
            if (File.Exists(textBoxFilenameMain.Text))
                File.Delete(textBoxFilenameMain.Text);
            if (File.Exists(textBoxFilenameMain.Text + "_index"))
                File.Delete(textBoxFilenameMain.Text + "_index");
            if (File.Exists(textBoxFilenameMain.Text + ".log"))
                File.Delete(textBoxFilenameMain.Text + ".log");
            m_target = MAIDataSinkTarget.CreateTargetTDMS(Path.GetDirectoryName(textBoxFilenameMain.Text) + "\\" + Path.GetFileNameWithoutExtension(textBoxFilenameMain.Text), textBoxMTitle.Text, textBoxMDesc.Text, textBoxFTitlte.Text, textBoxAuthor.Text);
            m_TargetFileName = Path.GetFileNameWithoutExtension(textBoxFilenameMain.Text) + " (TDMS File)";
       
        }

        private void buttonSetFilename_Click(object sender, EventArgs e) {
            saveFileDialog1.Title = "Select data output file";
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(textBoxFilenameMain.Text);
            saveFileDialog1.FileName = Path.GetFileName(textBoxFilenameMain.Text);
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            
            textBoxFilenameMain.Text = saveFileDialog1.FileName;
        }
    }
}
