using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Goldammer;
using System.Threading;

namespace MAIRecorder {
    public partial class CTChannel : UserControl {

        #region private

        #region fields

        private MAIMeasurementChannelCT m_measchan;
        private MAIChannelCT m_channel;
        private string m_MeasurementType = "None";
        private CardWindow m_ParentForm;
        private CTSetup myConfi;
        #endregion

        #region ui_event_handlers

        private void CTChannel_MouseClick(object sender, MouseEventArgs e) {
            ShowConfig();
        }

        #endregion

        #endregion

        #region internal
        
        #region properties

        internal CardWindow ParentForm {
            get {
                return m_ParentForm;
            }
        }

        internal MAIChannelCT Channel {
            get {
                return m_channel;
            }
            set {
                m_channel = value;
                labelChannel.Text = "CT" + string.Format("{0:00}", m_channel.HardwareChannelNumber);
            }
        }

        internal CounterMode Mode {
            get;
            set;
        }

        internal SignalEdge Edge {
            get;
            set;
        }

        internal FrequencyCounterResolution FCResolution {
            get;
            set;
        }

        internal CounterResolution Resolution {
            get;
            set;
        }

        internal bool SoftwareReset {
            get;
            set;
        }

        internal bool SynchronizedToADChannellist {
            get;
            set;
        }

        internal uint PresetValue {
            get;
            set;
        }

        internal ImpulseDirection UpOrDown {
            get;
            set;
        }

        internal IncrementalCounterTimestampResolution IncTimestampResolution {
            get;
            set;
        }

        internal HardwareResetMode HWResetMode {
            get;
            set;
        }

        internal IncrementalCounterHardwareResetEdge HWResetEdge {
            get;
            set;
        }

        internal IncrementalCounterInterpolationMode InterpolationMode {
            get;
            set;
        }

        internal bool ADSync {
            get;
            set;
        }

        internal MAIMeasurementChannelCT MChan {
            get {
                return m_measchan;
            }
        }

        #endregion

        #region methods

        internal void ShowConfig() {

            myConfi = new CTSetup(this);

            myConfi.Location = new Point(Cursor.Position.X - 100, Cursor.Position.Y - myConfi.Height / 2);
            myConfi.gbCTMode.Text = labelChannel.Text + " Mode";

            myConfi.Show();

        }

        internal void UpdateText() {
            try {
                textBox1.Text = m_measchan.ReadSingleValue().ToString();
                //Channel.MyDevice.ClearAllChannelLists();
            }
            catch (Exception x) {
                textBox1.Text = x.Message;
            }
        }

        internal MAIMeasurementChannelCT CreateTmpMeaschan() {
            switch (Mode) {
                case CounterMode.IMPULSECOUNTER:
                m_measchan = Channel.CreateImpulseCounter(PresetValue, UpOrDown, Edge, ADSync);
                m_MeasurementType = "Impulse";
                break;
                case CounterMode.FREQUENCYCOUNTER:
                m_measchan = Channel.CreateFrequencyCounter(Edge, FCResolution, ADSync);
                m_MeasurementType = "Frequency";

                break;
                case CounterMode.PULSEWIDTHCOUNTER:
                m_measchan = Channel.CreatePulswidthCounter(Edge, Resolution, ADSync);
                m_MeasurementType = "Pulsewidth";

                break;
                case CounterMode.PERIODCOUNTER:
                m_measchan = Channel.CreatePeriodCounter(Edge, Resolution, ADSync);
                m_MeasurementType = "Period";

                break;
                case CounterMode.UPDOWNCOUNTER:
                m_measchan = Channel.CreateUpDownCounter(PresetValue, UpOrDown, Edge, SoftwareReset, ADSync);
                m_MeasurementType = "UpDown";

                break;
                case CounterMode.INCREMENTALCOUNTER:
                m_measchan = Channel.CreateIncrementalCounter(Edge, SoftwareReset, HWResetMode, HWResetEdge, InterpolationMode, ADSync);
                m_MeasurementType = "Incremental";
                break;
                case CounterMode.INCEEXTTIMESTAMP:
                m_measchan = Channel.CreateIncrementalExtensionTimestamp(IncTimestampResolution);
                m_MeasurementType = "IncrementalExtensionTimestamp";

                break;
                case CounterMode.INCEEXTFLOWRATE:
                m_measchan = Channel.CreateIncrementalExtensionFlowRate(IncTimestampResolution);
                m_MeasurementType = "IncrementalExtensionFlowRate";

                break;



            }
            return m_measchan;
        }

        internal String GetMeasurementType() {
            return m_MeasurementType;
        }

        internal String GetMeasurementChannelCaption() {
            return labelChannel.Text;
        }


        #endregion

        #endregion

        #region public

        public CTChannel() {
            InitializeComponent();
        }

        public CTChannel(MAIChannelCT AIChannel, CardWindow AIParentForm) {
            m_ParentForm = AIParentForm;
            // AIChannel.MyDevice.Properties.CTChannels[AIChannel.HardwareChannelNumber].CounterType
            InitializeComponent();
            Channel = AIChannel;
            ADSync = true;
            if (!Channel.IsUniversal) {
                if (Channel.IsIncremental)
                    Mode = CounterMode.INCREMENTALCOUNTER;
                else if (Channel.IsIncrementalExtension)
                    Mode = CounterMode.INCEEXTTIMESTAMP;

            }
            else
                Mode = CounterMode.IMPULSECOUNTER;
            CreateTmpMeaschan();
            //Channel.Mode


        }
        
        #endregion


    }
}
