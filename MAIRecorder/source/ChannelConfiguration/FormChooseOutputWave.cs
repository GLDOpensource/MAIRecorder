using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MAIRecorder {

    public partial class FormChooseOutputWave : Form {

        #region private

        #region ui_event_handlers

        private void trackBar1_Scroll(object sender, EventArgs e) {
            double t1 = ((double)trackBarFreq.Value) / 440.0;
            double Pianokey = Math.Log(t1, 2) * 12 + 49;
            labelFreq.Text = trackBarFreq.Value.ToString() + " Hz";
            SineFrequency = (uint)trackBarFreq.Value;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            trackBarFreq.Enabled = radioButton1.Checked;
            comboBox1.Enabled = radioButton2.Checked;
            textBox1.Enabled = radioButton2.Checked;
            button3.Enabled = radioButton2.Checked;
            UseSine = radioButton1.Checked;
        }

        private void button3_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(textBox1.Text)) {
                openFileDialog1.FileName = Path.GetFileName(textBox1.Text);
                openFileDialog1.InitialDirectory = Path.GetDirectoryName(textBox1.Text);
            }
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            comboBox1.Items.Clear();
            textBox1.Text = openFileDialog1.FileName;
            ReadTAFFmat(openFileDialog1.FileName);
            TMHeaderfile = textBox1.Text;
        }

        private void FormChooseOutputWave_Load(object sender, EventArgs e) {
            labelFreq.Text = SineFrequency.ToString() + " Hz";
            labelAplitude.Text = SineAmplitude.ToString();
            radioButton1.Checked = UseSine;
            radioButton2.Checked = !UseSine;
            if ((SineFrequency <= trackBarFreq.Maximum) && (SineFrequency >= trackBarFreq.Minimum)) {
                trackBarFreq.Value = (int)SineFrequency;
                trackBarAMp.Value = (int)SineAmplitude;


            }
            if (!String.IsNullOrEmpty(TMHeaderfile)) {
                textBox1.Text = TMHeaderfile;
                ReadTAFFmat(TMHeaderfile);
                int tmpi = TMChannelindex;
                comboBox1.SelectedIndex = tmpi;
            }

        }

        private void trackBarAMp_Scroll(object sender, EventArgs e) {
            labelFreq.Text = trackBarAMp.Value.ToString();
            SineAmplitude = (uint)trackBarAMp.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            TMChannelindex = comboBox1.SelectedIndex;
        } 

        #endregion

        private void ReadTAFFmat(string AIName) {
            m_trFileData = new TAFFMatReader(AIName);
            for (int i = 0; i < m_trFileData.ChannelCount; i++)
                comboBox1.Items.Add(i.ToString());
        }

        private TAFFMatReader m_trFileData;
        
        #endregion

        #region internal

        #region properties

        internal string TMHeaderfile {
            get;
            set;
        }

        internal int TMChannelindex {
            get;
            set;
        }

        internal uint SineFrequency {
            get;
            set;
        }

        internal uint SineAmplitude {
            get;
            set;
        }

        internal bool UseSine {
            get;
            set;
        } 


        #endregion

        internal double[] GetOutputDataChannel() {
            return m_trFileData.ReadScaled((uint)comboBox1.SelectedIndex, 0, m_trFileData.BurstCount, false);
        }

        internal static double[] CalcuateSinePeriod(double AISamplerate, double SineFreq, double SineAmp) {
            double SamplesPerPeriod = AISamplerate / SineFreq;
            List<double> ret = new List<double>();

            for (int i = 0; i < SamplesPerPeriod; i++) {
                double sin = Math.Sin((i * Math.PI * 2.0) / SamplesPerPeriod);
                ret.Add(sin * SineAmp);
            }
            return ret.ToArray();

        }

        #endregion

        #region public

        public FormChooseOutputWave() {
            InitializeComponent();
        }

        #endregion
    }
}
