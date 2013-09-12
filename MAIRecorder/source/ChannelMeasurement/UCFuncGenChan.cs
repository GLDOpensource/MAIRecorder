using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Goldammer;

namespace MAIRecorder {
    public partial class UCFuncGenChan : UserControl {

        #region private

        #region fields

        private List<Double> m_Points = new List<double>();
        private MouseEventHandler meh;
        private int LastMouseX;
        private int LastMouseY;
        private bool isDrawing = false;
        private int OutDataPointer = 0;

        #endregion

        #region methods

        private void InsertSine(int ps) {
            ResetChart();
            lock (m_Points) {
                m_Points.Clear();
                for (int i = 0; i < ps; i++) {
                    double newPoint = (double)numericUpDownOffset.Value + Math.Sin((i * 2 * Math.PI * (double)numericUpDownCycles.Value) / ps) * (double)numericUpDownAmplitude.Value;
                    newPoint = CheckIOBounds(newPoint);
                    m_Points.Add(newPoint);
                }
            }
            chart1.Series["Plot"].Points.DataBindY(m_Points);

        }

        private void ResetChart() {
            chart1.Series.Clear();
            Series p = chart1.Series.Add("Plot");
            p.ChartType = SeriesChartType.FastLine;
            chart1.ChartAreas[0].AxisY.Minimum = MinimumRange;
        }

        private void InsertRect(int ps) {
            ResetChart();
            double onePeriodrange = ps / (double)numericUpDownCycles.Value;
            double halvePeriodrange = onePeriodrange / 2;
            double Amplitude = (double)numericUpDownAmplitude.Value;
            double min = (double)numericUpDownOffset.Value + (-1.0 * Amplitude);
            double max = (double)numericUpDownOffset.Value + ( Amplitude);
            double scalePM10 = (max-min) / onePeriodrange;

            lock (m_Points) {
                m_Points.Clear();
                for (int i = 0; i < ps; i++) {
                    double periodval = i % onePeriodrange;
                    double newPoint = max;
                    if (periodval < halvePeriodrange)
                        newPoint = min;

                    newPoint = CheckIOBounds(newPoint);
                    m_Points.Add(newPoint);
                }
            }
            chart1.Series["Plot"].Points.DataBindY(m_Points);
        }

        private void InsertSaw(int ps) {
            ResetChart();
            double onePeriodrange = ps / (double)numericUpDownCycles.Value;
            double Amplitude = (double)numericUpDownAmplitude.Value;
            double min = (double)numericUpDownOffset.Value + (-1.0 * Amplitude);
            double max = (double)numericUpDownOffset.Value + (Amplitude);
            double scalePM10 = (max - min) / onePeriodrange;

            double incrementor = min;
            lock (m_Points) {
                m_Points.Clear();
                for (int i = 0; i < ps; i++) {
                    incrementor += scalePM10;
                    if (incrementor > max)
                        incrementor = min;
                    double newPoint = incrementor;
                    newPoint = CheckIOBounds(newPoint);
                    m_Points.Add(newPoint);
                }
            }
            chart1.Series["Plot"].Points.DataBindY(m_Points);
        }

        private double CheckIOBounds(double newPoint) {
            if (newPoint > 10)
                newPoint = 10;
            if (newPoint < MinimumRange)
                newPoint = MinimumRange;
            return newPoint;
        }

        #endregion

        #region ui_event_handlers

        private void chart1_MouseMove(object sender, MouseEventArgs e) {
           
            chart1.ChartAreas[0].CursorX.SetCursorPixelPosition(new PointF(e.X, e.Y), false);
            chart1.ChartAreas[0].CursorY.IntervalType = DateTimeIntervalType.Number;
            chart1.ChartAreas[0].CursorY.Interval = 0.00001;
            chart1.ChartAreas[0].CursorY.SetCursorPixelPosition(new PointF(e.X, e.Y), false);
            if ((e.Button & MouseButtons.Left) != MouseButtons.Left) {
                isDrawing = false;
                LastMouseX = e.X;
                LastMouseY = e.Y;
                return;
            }
            int distSquare = 2;
            if (isDrawing) {
                distSquare = (int) Math.Sqrt((LastMouseX - e.X) * (LastMouseX - e.X) + (LastMouseY - e.Y) * (LastMouseY - e.Y));
            
            }
            if (distSquare < 2)
                distSquare = 2;
            LastMouseX = e.X;
            LastMouseY = e.Y;
            isDrawing = true;
            double pX = chart1.ChartAreas[0].CursorX.Position; //X Axis Coordinate of your mouse cursor
            double pY = chart1.ChartAreas[0].CursorY.Position; //Y Axis Coordinate of your mouse cursor
            double dpm = m_Points.Count / (chart1.Width-100);
            if (dpm == 0)
                dpm = 1;
            lock (m_Points) {
                for (int xi = 0; xi < dpm*distSquare; xi++) {
                    int xval = (int)pX + xi;
                    if (m_Points.Count > xval) {
                        m_Points[xval] = pY;
                        chart1.Series["Plot"].Points.Clear();
                        chart1.Series["Plot"].Points.DataBindY(m_Points);
                    }
                }
            }
           

        }
   
        private void button1_Click(object sender, EventArgs e) {

            switch (comboBox1.SelectedIndex) {
                case 0: InsertSine(SampleRate); break;
                case 1: InsertRect(SampleRate); break;
                case 2: InsertSaw(SampleRate); break;
            }

        }

        #endregion

        #endregion

        #region internal

        #region methods

        internal double[] Next(int AICount) {
            if (AICount < 1)
                return new double[]{};
            double[] tmp ;
             
            lock(m_Points)
                tmp = m_Points.ToArray();

            double[] ret = new double[AICount];
            int length = AICount;
            if (length + OutDataPointer> tmp.Length)
                length = tmp.Length- OutDataPointer;
            if (length  > ret.Length)
                length = ret.Length ;

            int destIndex = 0;
            while (length > 0) {
                Array.Copy(tmp, OutDataPointer, ret, destIndex, length);
                OutDataPointer += length;
                destIndex += length;
                if (OutDataPointer >= tmp.Length)
                    OutDataPointer = 0;
                if (destIndex < AICount) {
                    length = AICount - destIndex;
                    if (length > tmp.Length)
                        length = tmp.Length;
                    if (length > ret.Length)
                        length = ret.Length;
                }
                else
                    length = 0;
            }

            return ret;
        
        }

        internal void Init() {
            comboBox1.SelectedIndex = 0;
            if (MinimumRange == 0) {
                numericUpDownOffset.Value = 5;
                numericUpDownAmplitude.Value = 5;
            }
            InsertSine(SampleRate);
        }

        internal void SetNewWidth(int AINewWidth) {
            this.Width = AINewWidth;
            this.Height = AINewWidth / 3;
            if (this.Height > 250)
                this.Height = 250;
        }

        #endregion

        #region properties

        internal int MinimumRange {
            get;
            set;
        }

        internal string LabelName {
            get {
                return gbKanalName.Text;
            }
            set {
                gbKanalName.Text = value;
            }
        }

        internal bool Active {
            get {
                return checkBox1.Checked;
            }
            set {
                checkBox1.Checked = value;
            }
        }

        internal bool ActiveEnabled {
            get {
                return checkBox1.Enabled;
            }
            set {
                checkBox1.Enabled = value;
            }
        }

        internal int SampleRate {
            get;
            set;
        }

        internal MAIMeasurementChannelDA MChannel {
            get;
            set;
        }

        internal MAIChannelDA Channel {
            get;
            set;
        }

        #endregion

        #endregion

        #region public

        public UCFuncGenChan() {

            InitializeComponent();
            meh = new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart1.MouseMove += meh;
            SampleRate = 1000;
            MinimumRange = -10;

        } 

        #endregion
       
    }
}
