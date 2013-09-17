using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Goldammer;
using System.Windows.Forms.DataVisualization.Charting;

namespace MAIRecorder {
    public partial class AudioCardWindow : Form {

        #region private

        #region fields

        private MAIDevice m_maiDevice;
        private IDataSinkTarget m_dsTarget = null;
        private SignalEdge m_ct0SignalEdge;
        private SignalEdge m_ct1SignalEdge;
        private CounterResolution m_ct0Resolution;
        private CounterResolution m_ct1Resolution;

        private bool m_Out0Sinus = true;
        private bool m_Out1Sinus = true;
        private int m_Out0TMChannel = -1;
        private int m_Out1TMChannel = -1;

        private string m_Out0TMHeaderfile = "";
        private string m_Out1TMHeaderfile = "";
        private double m_Out0SineFreq = 440;
        private double m_Out1SineFreq = 440;
        private double m_Out0SineAmplitude = 5;
        private double m_Out1SineAmplitude = 5;

        private double[] m_Out0Buffer = null;
        private double[] m_Out1Buffer = null;

        #endregion

        #region ui_event_handlers

        private void AudioCardWindow_Load(object sender, EventArgs e) {
            ucAudioCard4ChannelSettings1.MyDevice = m_maiDevice;      
            ucAudioCard4ChannelSettings1.RefreshUsercontrolsWithDeviceSettings();
        }

        private void ADCheckChanged(object sender, EventArgs e) {
            if (checkBoxAD3.Checked)
                checkBoxDA1.Checked = false;
            if (checkBoxAD2.Checked)
                checkBoxDA0.Checked = false;

        }

        private void DaCheckChanged(object sender, EventArgs e) {
            if (checkBoxDA0.Checked)
                checkBoxAD2.Checked = false;
            if (checkBoxDA1.Checked)
                checkBoxAD3.Checked = false;

        }

        private void CTChackChanged(object sender, EventArgs e) {

        }

        private void tDMSToolStripMenuItem_Click(object sender, EventArgs e) {

            string recTarget = "";
            m_dsTarget = FormDSTargetConfigBase.ShowAsDialog((sender as ToolStripMenuItem).Text, out recTarget);
            if (m_dsTarget == null)
                return;
         
            tbRecTarget.Text = recTarget;

            if ((sender as ToolStripMenuItem).Checked)
                return;

            foreach (ToolStripMenuItem mi in fileToolStripMenuItem.DropDownItems) {
                mi.Checked = false;
            }
            (sender as ToolStripMenuItem).Checked = true;
            foreach (ToolStripMenuItem mi in fileToolStripMenuItem.DropDownItems) {
                if (mi.Checked)
                    checkBoxRECORD.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            try {
                int i = 0;
                m_maiDevice.ADChannels.DataSink.Preview.Update();    // Preview aktualisieren
              
                foreach(MAIMeasurementChannelCT ctc in m_maiDevice.CTChannels.GetMeasurementChannels()){
                    uint tmpVal;
                    DateTime tmpDT;
                    ctc.GetLastValue(out tmpVal,  out tmpDT);
                    if (ctc.HardwareChannelNumber == 0)
                        textBoxCT0.Text = String.Format("{0,8:X8}", tmpVal);
                    if (ctc.HardwareChannelNumber == 1)
                        textBoxCT1.Text = String.Format("{0,8:X8}", tmpVal);
                }

                if (radioButtonCharts.Checked)
                    foreach (Series s in chart1.Series) {  // für alle Graphen
                        s.Points.DataBindXY(m_maiDevice.ADChannels.DataSink.Preview.Timestamps, m_maiDevice.ADChannels.DataSink.Preview[s.Name+" []"]); // Setze die Punkte aus dem Datasink Preview
                        i++;
                    }
                else {
                    List<string> ADColums  = new List<string>();
                    List<double> RmsValues = new List<double>();
                    for (int iDCT = 0; iDCT < m_maiDevice.ADChannels.DataSink.Preview.DataColumnTypes.Count(); iDCT++) {
                        if (m_maiDevice.ADChannels.DataSink.Preview.DataColumnTypes[iDCT] == typeof(double)) { 
                            ADColums.Add(m_maiDevice.ADChannels.DataSink.Preview.DataColumnNames[iDCT].Replace(" []",""));
                            RmsValues.Add(m_maiDevice.ADChannels.DataSink.Preview.RootMeanSquares[iDCT]);
                        }
                    }
                    chart1.Series["RMS"].Points.DataBindXY(ADColums, RmsValues);
                }

            }
            catch {
            }
        }

        private void checkBoxRECORD_CheckedChanged(object sender, EventArgs e) {
       

            //timer1.Enabled = !checkBoxRECORD.Checked;
            //m_maiDevice.ADChannels.DataSink.Preview.Enabled  = !checkBoxRECORD.Checked;
            if (checkBoxRECORD.Checked) {
                if (!CheckADDatasinkPerformance()) {
                    checkBoxRECORD.Checked = false;
                    return;

                }
                if (!m_maiDevice.HasDatasinkLicense)
                    MessageBox.Show(Messages.NoLicenseFoundText, Messages.NoLicenseFoundCaption);
                menuStrip1.Enabled = false;

            }
            else {
                menuStrip1.Enabled = true;
            }

            m_maiDevice.ADChannels.DataSink.OutputEnabled = checkBoxRECORD.Checked;
            Color tmp = checkBoxRECORD.ForeColor;
            checkBoxRECORD.ForeColor = checkBoxRECORD.BackColor;
            checkBoxRECORD.BackColor = tmp;
        }

       

        private void rAWToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {

        }

        private void checkBoxPREV_CheckedChanged(object sender, EventArgs e) {
            timer1.Enabled = false;
            Color tmp = checkBoxPREV.ForeColor;
            checkBoxPREV.ForeColor = checkBoxPREV.BackColor;
            checkBoxPREV.BackColor = tmp;
            textBoxCT0.Text = "";
            textBoxCT1.Text = "";
            StopMeasAndClear();
            if (checkBoxPREV.Checked) {
                if (ConfigIsOK()) {
                    ConfigAndStartMeas();
                    SetUpChart();
                }
                else{
                    checkBoxPREV.Checked = false;
                    return;
                }
            }
            timer1.Enabled = checkBoxPREV.Checked;
            checkBoxLoopBack.Enabled = !checkBoxPREV.Checked;
            groupBoxChannelConfig.Enabled = !checkBoxPREV.Checked;
            radioButtonCharts.Enabled = !checkBoxPREV.Checked;
            radioButtonRMS.Enabled = !checkBoxPREV.Checked;
            fileToolStripMenuItem.Enabled =  !checkBoxPREV.Checked;
        }

       
        private void checkBoxLoopBack_CheckedChanged(object sender, EventArgs e) {
            Color tmp = checkBoxLoopBack.ForeColor;
            checkBoxLoopBack.ForeColor = checkBoxLoopBack.BackColor;
            checkBoxLoopBack.BackColor = tmp;
            if (checkBoxLoopBack.Checked) {
                checkBoxDA0.Checked = true;
                checkBoxDA1.Checked = true;
            }
            checkBoxDA0.Enabled = !checkBoxLoopBack.Checked;
            checkBoxDA1.Enabled = !checkBoxLoopBack.Checked;
            checkBoxAD2.Enabled = !checkBoxLoopBack.Checked;
            checkBoxAD3.Enabled = !checkBoxLoopBack.Checked;
            m_maiDevice.DAChannels.SetADLoopBackMode(checkBoxLoopBack.Checked);
        }

        private void radioButtonRMS_CheckedChanged(object sender, EventArgs e) {
            SetUpChart();
            SetUpPrevPresets();

        }

        private void buttonConfigCT0_Click(object sender, EventArgs e) {
            FormConfigPeriodCounter fcpc = new FormConfigPeriodCounter();
            fcpc.Text = "Counter Channel 0 Configuration";
            fcpc.SingalEdge = (int)m_ct0SignalEdge;
            fcpc.Reslution = (int)m_ct0Resolution;
            if (fcpc.ShowDialog() != DialogResult.OK)
                return;
             m_ct0SignalEdge = (SignalEdge)fcpc.SingalEdge; 
             m_ct0Resolution = (CounterResolution)fcpc.Reslution ; 

        }

        private void buttonConfigCT1_Click(object sender, EventArgs e) {
            FormConfigPeriodCounter fcpc = new FormConfigPeriodCounter();
            fcpc.Text = "Counter Channel 1 Configuration";
            fcpc.SingalEdge = (int)m_ct1SignalEdge;
            fcpc.Reslution = (int)m_ct1Resolution;
            if (fcpc.ShowDialog() != DialogResult.OK)
                return;
            m_ct1SignalEdge = (SignalEdge)fcpc.SingalEdge;
            m_ct1Resolution = (CounterResolution)fcpc.Reslution; 

        }
         
        private void buttonConfigDA0_Click(object sender, EventArgs e) {
            FormChooseOutputWave fcow = new FormChooseOutputWave();

            fcow.SineFrequency = (uint) m_Out0SineFreq;
            fcow.SineAmplitude = (uint)m_Out0SineAmplitude;

            fcow.UseSine = m_Out0Sinus;
            fcow.TMHeaderfile = m_Out0TMHeaderfile;
            fcow.TMChannelindex = m_Out0TMChannel;

            fcow.Text = "Output Channel 0 Configuration";
            if (fcow.ShowDialog() != DialogResult.OK)
                return;

            m_Out0SineFreq =  fcow.SineFrequency ;
            m_Out0Sinus = fcow.UseSine;
            m_Out0TMHeaderfile = fcow.TMHeaderfile ;
            m_Out0Buffer = null;
            m_Out0SineAmplitude =fcow.SineAmplitude;
            m_Out0TMChannel  = fcow.TMChannelindex;

            if (!m_Out0Sinus)
                m_Out0Buffer = fcow.GetOutputDataChannel();
          
        }

        private void buttonConfigDA1_Click(object sender, EventArgs e) {
            FormChooseOutputWave fcow = new FormChooseOutputWave();

            fcow.SineFrequency = (uint)m_Out1SineFreq;
            fcow.SineAmplitude = (uint)m_Out1SineAmplitude;
            fcow.UseSine = m_Out1Sinus;
            fcow.TMHeaderfile = m_Out1TMHeaderfile;
            fcow.TMChannelindex = m_Out1TMChannel;

            fcow.Text = "Output Channel 0 Configuration";
            if (fcow.ShowDialog() != DialogResult.OK)
                return;

            m_Out1SineFreq = (uint)fcow.SineFrequency;
            m_Out1Sinus = fcow.UseSine;
            m_Out1TMHeaderfile = fcow.TMHeaderfile;
            m_Out1SineAmplitude = fcow.SineAmplitude;
            m_Out1TMChannel = fcow.TMChannelindex;

            m_Out1Buffer = null;
            if (!m_Out1Sinus)
                m_Out1Buffer = fcow.GetOutputDataChannel();

        }

        #endregion

        #region methods

        private void ConfigAndStartMeas() {
            if (checkBoxAD0.Checked) {
                MAIMeasurementChannelAD c = m_maiDevice.ADChannels[0].CreateMeasurementChannel(OversamplingMode.Disabled, GainFactor.Disabled, true);
                c.Name = "AD0";
            }
            if (checkBoxAD1.Checked) {
                MAIMeasurementChannelAD c = m_maiDevice.ADChannels[1].CreateMeasurementChannel(OversamplingMode.Disabled, GainFactor.Disabled, true);
                c.Name = "AD1";
            }
            if (checkBoxAD2.Checked) {
                MAIMeasurementChannelAD c = m_maiDevice.ADChannels[2].CreateMeasurementChannel(OversamplingMode.Disabled, GainFactor.Disabled, true);
                c.Name = "AD2";
            }
            if (checkBoxAD3.Checked) {
                MAIMeasurementChannelAD c = m_maiDevice.ADChannels[3].CreateMeasurementChannel(OversamplingMode.Disabled, GainFactor.Disabled, true);
                c.Name = "AD3";
            }

            if (checkBoxCT0.Checked) {
                MAIMeasurementChannelCT c = m_maiDevice.CTChannels[0].CreatePeriodCounter(m_ct0SignalEdge, m_ct0Resolution, true);

            }
            if (checkBoxCT1.Checked) {
                MAIMeasurementChannelCT c = m_maiDevice.CTChannels[1].CreatePeriodCounter(m_ct1SignalEdge, m_ct1Resolution, true);

            }

            if (!checkBoxLoopBack.Checked) {
                if (checkBoxDA0.Checked) {
                    if (m_Out0Buffer == null) {
                        m_Out0Buffer = FormChooseOutputWave.CalcuateSinePeriod(Convert.ToDouble(comboBoxOutputRate.Text), (double)m_Out0SineFreq, (double)m_Out0SineAmplitude);
                    }
                    MAIMeasurementChannelDA c = m_maiDevice.DAChannels[0].CreateAutomaticOutputChannel(m_Out0Buffer);


                }
                if (checkBoxDA1.Checked) {

                    if (m_Out1Buffer == null) {
                        m_Out1Buffer = FormChooseOutputWave.CalcuateSinePeriod(Convert.ToDouble(comboBoxOutputRate.Text), (double)m_Out1SineFreq, (double)m_Out1SineAmplitude);

                    }
                    MAIMeasurementChannelDA c = m_maiDevice.DAChannels[1].CreateAutomaticOutputChannel(m_Out1Buffer);


                }
            }

            double sr = (double)Convert.ToUInt32(comboBoxSamplerate.Text);
            m_maiDevice.ADChannels.SetSampleRate(sr);
            m_maiDevice.ADChannels.DataSink.Target = m_dsTarget;

            m_maiDevice.ConfigMeasure();

            if (m_maiDevice.DAChannels.MeasurementChannelsCount > 0) {
                m_maiDevice.DAChannels.SetMeasurementBufferNotificationLevel(1);
                m_maiDevice.DAChannels.StartNotificationThread();
                m_maiDevice.DAChannels.StartOutput();
            }
            m_maiDevice.ADChannels.DataSink.Enable(DateTime.Now);  // Datasink starten
            SetUpPrevPresets();
            m_maiDevice.StartMeasure();

        }


        private bool ConfigIsOK() {
            double sr; 
            double or; 
            int inChannels = 0;
            int outChannels = 0;

            GetMeasureProperties(out inChannels, out outChannels, out sr, out or);
            if ((sr < 96000) && (or < 96000))
                return true;

            if ((outChannels == 0) && (inChannels < 3))
                return true;


            if ((outChannels == 0) && (sr < 100000))
                return true;

            string msboxtext = Messages.AudioPerformanceCritical;


            if (MessageBox.Show(msboxtext, Messages.AudioPerformanceWarningCaption, MessageBoxButtons.OKCancel) == DialogResult.OK)
                return true;

            return false;
        }

        private void GetMeasureProperties(out int inChannels, out int outChannels, out double Samplerate, out double OutputRate) {
            inChannels = 0;
            outChannels = 0;

            Samplerate = (double)Convert.ToUInt32(comboBoxSamplerate.Text);
            OutputRate = (double)Convert.ToUInt32(comboBoxOutputRate.Text);

            if (checkBoxAD0.Checked)
                inChannels++;
            if (checkBoxAD1.Checked)
                inChannels++;
            if (checkBoxAD2.Checked)
                inChannels++;
            if (checkBoxAD3.Checked)
                inChannels++;
            if (checkBoxCT0.Checked)
                inChannels++;
            if (checkBoxCT1.Checked)
                inChannels++;
            if (checkBoxDA0.Checked)
                outChannels++;
            if (checkBoxDA1.Checked)
                outChannels++;
        }

        private bool CheckADDatasinkPerformance() {
            double sr;
            double or;
            int inChannels = 0;
            int outChannels = 0;

            GetMeasureProperties(out inChannels, out outChannels, out sr, out or);

            if ((sr < 50000) && (or < 50000))
                return true;

            if ((outChannels == 0) && (inChannels < 3))
                return true;

            string msboxtext = Messages.AudioPerformanceRecCritical;


            if (MessageBox.Show(msboxtext, Messages.AudioPerformanceWarningCaption, MessageBoxButtons.OKCancel) == DialogResult.OK)
                return true;

            return false;
        }

        private void StopMeasAndClear() {
            m_maiDevice.DAChannels.StopNotificationThread();
            m_maiDevice.DAChannels.StopOutput();

            m_maiDevice.ADChannels.DataSink.Disable();
            m_maiDevice.StopMeasure();
            m_maiDevice.ClearAllChannelLists();
        }

        private void SetUpPrevPresets() {
            double sr = (double)Convert.ToUInt32(comboBoxSamplerate.Text);
            double prevR = sr / 10;
            int initialPrevBufSize = 200;
            if (!radioButtonCharts.Checked) {
                prevR = sr - prevR;
                initialPrevBufSize = 20;
            }

            // jetzt das Preview konfigurieren:
            m_maiDevice.ADChannels.DataSink.Preview.Enabled = false;

            m_maiDevice.ADChannels.DataSink.Preview.MaxTickCount = (uint)initialPrevBufSize;
            m_maiDevice.ADChannels.DataSink.Preview.TickFrequency = prevR;
            m_maiDevice.ADChannels.DataSink.Preview.Enabled = true;
            // und nur Daten aufzeichnen, wenn "Recording" im UI aktiviert ist:
            m_maiDevice.ADChannels.DataSink.OutputEnabled = checkBoxRECORD.Checked;
            timer1.Enabled = true;

        }

        private void SetUpChart() {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();
            ChartArea na;
            if (radioButtonCharts.Checked) {
                Series ns;
                foreach (MAIMeasurementChannelAD c in m_maiDevice.ADChannels.GetMeasurementChannels()) {
                    ns = chart1.Series.Add(c.Name);
                    ns.ChartType = SeriesChartType.FastLine;
                    ns.Color = Color.Red;
                    na = chart1.ChartAreas.Add(c.Name);
                    ns.ChartArea = na.Name;
                    Title t = new Title(c.Name, Docking.Top, new Font("Verdana", 8), Color.Black);
                    t.DockedToChartArea = na.Name;
                    t.DockingOffset = -5;
                    chart1.Titles.Add(t);
                    ns.Points.Add(2.9);
                    na.AxisX.LabelStyle.Enabled = false;
                    na.AxisX.MajorTickMark.Enabled = false;
                    na.AxisX.Enabled = AxisEnabled.False;
                    na.AxisY.Maximum = 5;
                    na.AxisY.Minimum = -5;
                    na.AxisY.MajorGrid.Interval = 5;
                    na.AxisY.MinorGrid.Interval = 1;
                    na.AxisY.MinorGrid.Enabled = true;
                    na.AxisY.MinorGrid.LineColor = Color.LightGray;
                    na.AxisY.MinorTickMark.Enabled = true;
                    na.AxisY.MajorTickMark.Interval = 5;
                    na.AxisY.LabelStyle.Interval = 5;
                }
            }
            else {
                Series ns = chart1.Series.Add("RMS");
                ns.ChartType = SeriesChartType.Column;
                ns.Color = Color.Red;
                na = chart1.ChartAreas.Add("RMS");
                ns.ChartArea = na.Name;
                Title t = new Title("RMS", Docking.Top, new Font("Verdana", 12), Color.Black);
                chart1.Titles.Add(t);

                t.DockedToChartArea = "RMS";
                //             na.AxisX.LabelStyle.Enabled = false;
                na.AxisX.MajorTickMark.Enabled = false;
                na.AxisY.MajorGrid.Interval = 1;
                na.AxisY.MinorGrid.Interval = 1;
                na.AxisX.LabelStyle.Angle = 90;
                na.AxisX.LabelStyle.Interval = 1;
                na.AxisY.Maximum = 10;
                na.AxisY.Minimum = 0;
            }
        }

        #endregion

        #endregion

        #region internal

        internal static void Show(MAIDevice AIDevice) {
            AudioCardWindow me = new AudioCardWindow();
            me.m_maiDevice = AIDevice;
            me.ShowDialog();
            me.Dispose();
        }

        #endregion

        #region public

        public AudioCardWindow() {
            InitializeComponent();
        }

        #endregion

    }
}
