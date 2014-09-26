using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Goldammer;
using Goldammer.MAIExtensions.DAQ;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace MAIRecorder {
    public partial class FormMeasureAD : Form {

        #region private

        #region fields

        private CardWindow m_ParentWindow;

        #endregion

        #region ui_event_handler

        bool m_bReconfigureLater = false;

        private void ni_CheckStateChanged(object sender, EventArgs e) {
            if(!m_bReconfigureLater)
                Reconfigure(m_ParentWindow.MAIDevice.ADChannels.DataSink.Target);
        }

        private void ni_invertSelectedChannels_Click(object sender, EventArgs e) {
            m_bReconfigureLater = true;
            try {
                ToolStripMenuItem it = (ToolStripMenuItem)menuStrip1.Items["channelsToolStripMenuItem"];
                foreach (ToolStripMenuItem mi in it.DropDownItems) {
                    if(mi.Tag != null)
                        mi.Checked = !mi.Checked;
                }
            }
            finally {
                m_bReconfigureLater = false;
            }
            Reconfigure(m_ParentWindow.MAIDevice.ADChannels.DataSink.Target);

        }

        private void numericUpDownADSamplerate_ValueChanged(object sender, EventArgs e) {
            if (!m_bReconfigureLater)
                Reconfigure(m_ParentWindow.MAIDevice.ADChannels.DataSink.Target);
        }

        private void numericUpDownADSamplerate_KeyUp(object sender, KeyEventArgs e) {
            if (!m_bReconfigureLater)
                Reconfigure(m_ParentWindow.MAIDevice.ADChannels.DataSink.Target);
        }


        private void timer1_Tick(object sender, EventArgs e) {
            try {
                int i = 0;
                m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.Update();    // Preview aktualisieren
                if (chartsToolStripMenuItem.Checked)
                    foreach (Series s in chart1.Series) {  // für alle Graphen
                        s.Points.DataBindXY(m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.Timestamps, m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview[i/*s.Name+" [Volt]"*/]); // Setze die Punkte aus dem Datasink Preview
                        i++;
                    }
                else {

                    chart1.Series["RMS"].Points.DataBindXY(m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.DataColumnNames, m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.RootMeanSquares);
                }

            }
            catch {
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                if (!m_ParentWindow.MAIDevice.HasDatasinkLicense)
                    MessageBox.Show("license file not found. Will record invalid data !!", "license file not fond");
                menuStrip1.Enabled = false;

            }
            else {
                menuStrip1.Enabled = true;
            }
            numericUpDownADSamplerate.Enabled = !checkBox1.Checked;

            m_ParentWindow.MAIDevice.ADChannels.DataSink.OutputEnabled = checkBox1.Checked;
            Color tmp = checkBox1.ForeColor;
            checkBox1.ForeColor = checkBox1.BackColor;
            checkBox1.BackColor = tmp;
        }

        private void rAWToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {

        }

        private void tDMSToolStripMenuItem_Click(object sender, EventArgs e) {
            string recTarget = "";
            IDataSinkTarget t = FormDSTargetConfigBase.ShowAsDialog((sender as ToolStripMenuItem).Text, out recTarget);
            if (t == null)
                return;
            Reconfigure(t);
            tbRecTarget.Text = recTarget;

            if ((sender as ToolStripMenuItem).Checked)
                return;

            foreach (ToolStripMenuItem mi in fileToolStripMenuItem.DropDownItems) {
                mi.Checked = false;
            }
            (sender as ToolStripMenuItem).Checked = true;
            foreach (ToolStripMenuItem mi in fileToolStripMenuItem.DropDownItems) {
                if (mi.Checked)
                    checkBox1.Enabled = true;
            }
        }

        private void trBaPreviewBufSize_Scroll(object sender, EventArgs e) {
            try {
                m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.Enabled = false;
                m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.MaxTickCount = (uint)trBaPreviewBufSize.Value;
                m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.Enabled = true;
                labelPrevSize.Text = trBaPreviewBufSize.Value.ToString();
                SetPrevTimeLabel();

            }
            catch (Exception x) {
                MessageBox.Show(x.Message);
            }

        }

        private void trBaPrevSampleRate_Scroll(object sender, EventArgs e) {
            try {
                m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.Enabled = false;
                m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.TickFrequency = (double)trBaPrevSampleRate.Value;
                m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.Enabled = true;
                labelPrevRate.Text = trBaPrevSampleRate.Value.ToString();
                SetPrevTimeLabel();

            }
            catch (Exception x) {
                MessageBox.Show(x.Message);
            }
        }

        private void valuesRMSToolStripMenuItem_Click(object sender, EventArgs e) {
            if (valuesRMSToolStripMenuItem.Checked)
                return;
            timer1.Enabled = false;
            try {
                chartsToolStripMenuItem.Checked = false;
                valuesRMSToolStripMenuItem.Checked = true;
                SetUpChart();
                SetUpPrevPresets();
            }
            finally {
                timer1.Enabled = true;
            }
        }

        private void chartsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (chartsToolStripMenuItem.Checked)
                return;
            timer1.Enabled = false;
            try {
                chartsToolStripMenuItem.Checked = true;
                valuesRMSToolStripMenuItem.Checked = false;
                SetUpChart();
                SetUpPrevPresets();
            }
            finally {
                timer1.Enabled = true;
            }
        }

        #endregion


        #region methods

        private void Reconfigure(IDataSinkTarget AITarget) {
            timer1.Enabled = false;
            try {
                m_ParentWindow.MAIDevice.ADChannels.DataSink.Disable();
                m_ParentWindow.MAIDevice.StopMeasure();
             
                m_ParentWindow.MAIDevice.ClearAllChannelLists();
               
                uint ActiveChannelCount = 0;
                ToolStripMenuItem it = (ToolStripMenuItem)menuStrip1.Items["channelsToolStripMenuItem"];
                foreach (ToolStripMenuItem mi in it.DropDownItems) {
                    if (mi.Checked) {
                        if (mi.Tag != null) {
                            (mi.Tag as ADChannelSmall).CreateMeasurementChannel();
                            ActiveChannelCount++;
                        }
                    }
                }

                mi_invertSelection.Enabled = (ActiveChannelCount < m_ParentWindow.MAIDevice.Info.ADChannels);

                SetSamplerateBoundaries(ActiveChannelCount);

                SetUpChart();

                double sr = (double)numericUpDownADSamplerate.Value;
                m_ParentWindow.MAIDevice.ADChannels.SetSampleRate(sr);
                m_ParentWindow.MAIDevice.ADChannels.DataSink.Target = AITarget;

                m_ParentWindow.MAIDevice.ConfigMeasure();
                m_ParentWindow.MAIDevice.ADChannels.DataSink.Enable(DateTime.Now);  // Datasink starten
               
                m_ParentWindow.MAIDevice.StartMeasure();
                SetUpPrevPresets();
            }
            finally {
                timer1.Enabled = true;
            }

        }

        private void SetSamplerateBoundaries(uint ActiveChannelCount) {
            int maxSR = m_ParentWindow.MAIDevice.Info.ADSampleRate * 1000 / (int)ActiveChannelCount;
            if (m_ParentWindow.MAIDevice.Info.SerialNumber.Contains("G0M")) {
                if (maxSR > 300000)
                    maxSR = 300000;
            }
            else if ((m_ParentWindow.MAIDevice.Info.SerialNumber.Contains("G0S") || (m_ParentWindow.MAIDevice.Info.SerialNumber.Contains("GES")))) {
                if (maxSR > 225000)
                    maxSR = 225000;          
            }
            m_bReconfigureLater = true;
            try {
                numericUpDownADSamplerate.Maximum = maxSR;
                if(numericUpDownADSamplerate.Value > maxSR)
                    numericUpDownADSamplerate.Value = maxSR;
            }
            finally {
                m_bReconfigureLater = false;
            }
        }

  

        private void SetUpPrevPresets() {
            double sr = (double)numericUpDownADSamplerate.Value;
            double prevR = sr / 10;
            int initialPrevBufSize = 200;
            if (!chartsToolStripMenuItem.Checked) {
                prevR = sr - prevR;
                initialPrevBufSize = 20;
            }
            trBaPrevSampleRate.Maximum = (int)sr;

            // jetzt das Preview konfigurieren:
            m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.Enabled = false;

            m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.MaxTickCount = (uint)initialPrevBufSize;
            m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.TickFrequency = prevR;
            m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.Enabled = true;
            // und nur Daten aufzeichnen, wenn "Recording" im UI aktiviert ist:
            m_ParentWindow.MAIDevice.ADChannels.DataSink.OutputEnabled = checkBox1.Checked;
           
            trBaPreviewBufSize.Value = initialPrevBufSize;
            trBaPrevSampleRate.Value = (int)prevR;
            labelPrevSize.Text = initialPrevBufSize.ToString();
            labelPrevRate.Text = ((int)prevR).ToString();
            SetPrevTimeLabel();
        }

        private void SetPrevTimeLabel() {
            labelPrevTime.Text = (m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.MaxTickCount / m_ParentWindow.MAIDevice.ADChannels.DataSink.Preview.TickFrequency).ToString();
        }

        private void SetUpChart() {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();
            ChartArea na;
            if (chartsToolStripMenuItem.Checked) {
                Series ns;
                foreach (MAIMeasurementChannelAD c in m_ParentWindow.MAIDevice.ADChannels.GetMeasurementChannels()) {
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
                    na.AxisY.Maximum = 10;
                    na.AxisY.Minimum = -10;
                    na.AxisY.MajorGrid.Interval = 10;
                    na.AxisY.MinorGrid.Interval = 1;
                    na.AxisY.MinorGrid.Enabled = true;
                    na.AxisY.MinorGrid.LineColor = Color.LightGray;
                    na.AxisY.MinorTickMark.Enabled = true;
                    na.AxisY.MajorTickMark.Interval = 10;
                    na.AxisY.LabelStyle.Interval = 10;
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

        #region public

        public FormMeasureAD() {
            InitializeComponent();
        }

        public FormMeasureAD(CardWindow AIParentWindow) {

            InitializeComponent();
            m_ParentWindow = AIParentWindow;
            m_ParentWindow.checkBoxUpdate.Checked = false;
            foreach (ADChannelSmall a in m_ParentWindow.flpADChannels.Controls) {
                ToolStripMenuItem it = (ToolStripMenuItem)menuStrip1.Items["channelsToolStripMenuItem"];
                ToolStripMenuItem ni = (ToolStripMenuItem)it.DropDownItems.Add(a.labelChannel.Text);
                ni.Tag     = a;
                ni.Checked = true;
                ni.CheckOnClick = true;
                ni.CheckStateChanged += new EventHandler(ni_CheckStateChanged);
            }

            numericUpDownADSamplerate.Value   = m_ParentWindow.numericUpDownADSamplerate.Value;
            numericUpDownADSamplerate.Minimum = 2;
            Reconfigure(null);

        }

        #endregion

    

    




    }
}
