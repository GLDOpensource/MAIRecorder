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
        public FormChooseOutputWave() {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            double t1 = ((double)trackBarFreq.Value)/440.0;
            double Pianokey =  Math.Log(t1, 2)*12+49;
            labelFreq.Text = trackBarFreq.Value.ToString()+ " Hz";
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
            if(!String.IsNullOrEmpty(textBox1.Text)){
                openFileDialog1.FileName = Path.GetFileName(textBox1.Text);
                openFileDialog1.InitialDirectory = Path.GetDirectoryName(textBox1.Text);
            }
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            comboBox1.Items.Clear();
            textBox1.Text = openFileDialog1.FileName;
            redTaFFmat(openFileDialog1.FileName);
            TMHeaderfile  =  textBox1.Text;
        }

        private void redTaFFmat(string AiName) {
            m_trFileData = new TAFFMatReader(AiName);
            for (int i = 0; i < m_trFileData.ChannelCount; i++)
                comboBox1.Items.Add(i.ToString());
        }

        TAFFMatReader m_trFileData;

        public string TMHeaderfile{
            get;
            set;
        }


        public int TMChannelindex {
            get;
            set;
        }

        public uint SineFrequency {
            get;
            set;
        }

        public uint SineAmplitude {
            get;
            set;
        }

        public bool UseSine {
            get;
            set;
        }



        private void FormChooseOutputWave_Load(object sender, EventArgs e) {
            labelFreq.Text = SineFrequency.ToString() + " Hz";
            labelAplitude.Text = SineAmplitude.ToString() ;
            radioButton1.Checked = UseSine;
            radioButton2.Checked = !UseSine;
            if ((SineFrequency <= trackBarFreq.Maximum) && (SineFrequency >= trackBarFreq.Minimum)) {
                trackBarFreq.Value = (int)SineFrequency; 
                trackBarAMp.Value = (int)SineAmplitude;
               

            }
            if (!String.IsNullOrEmpty(TMHeaderfile)) {
                textBox1.Text = TMHeaderfile;
                redTaFFmat(TMHeaderfile);
                int tmpi = TMChannelindex;
                comboBox1.SelectedIndex = tmpi;
            }

        }

        public double[] GetOutputDataChannel( ) { 
            return m_trFileData.ReadScaled((uint)comboBox1.SelectedIndex, 0,m_trFileData.BurstCount,false);
        }

        public static double[] CalcuateSinePeriod(double AISamplerate, double SineFreq, double SineAmp) { 
            double SamplesPerPeriod = AISamplerate/SineFreq;
            List<double> ret = new List<double>();

            for (int i = 0; i < SamplesPerPeriod; i++) {
                double sin = Math.Sin((i * Math.PI * 2.0) / SamplesPerPeriod);
                ret.Add(sin * SineAmp);
            }
            return ret.ToArray();
        
        }

        private void trackBarAMp_Scroll(object sender, EventArgs e) {
            labelFreq.Text = trackBarAMp.Value.ToString();
            SineAmplitude = (uint)trackBarAMp.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            TMChannelindex=  comboBox1.SelectedIndex;
        }
    }
}
