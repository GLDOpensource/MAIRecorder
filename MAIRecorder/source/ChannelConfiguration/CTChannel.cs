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
        public CTChannel() {
            InitializeComponent();
        }
        MAIMeasurementChannelCT m_measchan;
        MAIChannelCT m_channel;
        internal CardWindow m_ParentForm;
        public MAIChannelCT Channel {
            get {
                return m_channel;
            }
            set {
                m_channel = value;
                labelChannel.Text = "CT" + string.Format("{0:00}", m_channel.HardwareChannelNumber);
            }
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
                else if(Channel.IsIncrementalExtension)
                    Mode = CounterMode.INCEEXTTIMESTAMP;

            }
            else 
                Mode = CounterMode.IMPULSECOUNTER;
            CreateTmpMeaschan();
           //Channel.Mode
           
            
        }

        public CounterMode Mode {
            get;
            set;
        }
         public SignalEdge Edge {
            get;
            set;
        }
        public FrequencyCounterResolution FCResolution {
            get;
            set;
        }
          public CounterResolution Resolution {
            get;
            set;
        }
        public bool SoftwareReset {
            get;
            set;
        }
         public bool SynchronizedToADChannellist {
            get;
            set;
        }
        public uint PresetValue {
            get;
            set;
        }

        public ImpulseDirection UpOrDown {
            get;
            set;
        }

        public IncrementalCounterTimestampResolution IncTimestampResolution {
            get;
            set;
        }
            
        public HardwareResetMode HWResetMode {
            get;
            set;
        }
            
        public IncrementalCounterHardwareResetEdge HWResetEdge {
            get;
            set;
        }

        public IncrementalCounterInterpolationMode InterpolationMode {
            get;
            set;
        }

        public bool ADSync {
            get;
            set;
        }


        internal void Update() {
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
        string m_MeasurementType = "None";
        public String GetMeasurementType() {
            return m_MeasurementType;
        }
        public String GetMeasurementChannelCaption() {
            return labelChannel.Text;
        }

        private void CTChannel_MouseClick(object sender, MouseEventArgs e) {
            ShowConfig();

        }
        CTSetup myConfi;

        internal MAIMeasurementChannelCT MChan {
            get {
                return m_measchan;
            }
        }

        internal void ShowConfig() {
            myConfi = new CTSetup(this);

            myConfi.Location = new Point(Cursor.Position.X-100,Cursor.Position.Y -myConfi.Height / 2);
            myConfi.gbCTMode.Text = labelChannel.Text + " Mode";
          
            myConfi.Show();
           
          
          
        }
    }
}
