using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Goldammer.MAIExtensions.DAQ;
using System.IO;

namespace MAIRecorder {
    public partial class FormDSTargetTAFFMAT : MAIRecorder.FormDSTargetConfigBase {

        #region private

        private void buttonSetFilename_Click(object sender, EventArgs e) {
            saveFileDialog1.Title = "Select data output file";
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(textBoxFilenameMain.Text);
            saveFileDialog1.FileName = Path.GetFileName(textBoxFilenameMain.Text);
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            textBoxFilenameMain.Text = saveFileDialog1.FileName;
        } 

        #endregion

        #region protected

        protected override void CreateTarget() {
            m_target = MAIDataSinkTarget.CreateTargetTAFFMat(Path.GetDirectoryName(textBoxFilenameMain.Text) + "\\" + Path.GetFileNameWithoutExtension(textBoxFilenameMain.Text));
            m_TargetFileName = Path.GetFileNameWithoutExtension(textBoxFilenameMain.Text) + " (TAFFMAT File)";
        } 

        #endregion

        #region public

        public FormDSTargetTAFFMAT() {
            InitializeComponent();
            textBoxFilenameMain.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Output.hdr";
        } 

        #endregion
    }
}
