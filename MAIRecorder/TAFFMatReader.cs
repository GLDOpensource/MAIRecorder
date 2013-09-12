using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace MAIRecorder {
    public class TAFFMatReader {

       
        private string m_sDataPath;


        public TAFFMatReader(string AIPath) {
            Filename = AIPath;
            m_sDataPath = Path.GetDirectoryName(AIPath);
            using (TextReader reader = File.OpenText(AIPath)) {
                string line = reader.ReadLine();
                while (line != null) {
                    double extraD = 0;
                    string[] token = line.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (token.Length > 1) {
                        if (token[0].ToUpper().Contains("DATASET"))
                            m_sDataPath += "\\" + token[1].Trim() + ".dat";
                        if (token[0].ToUpper().Contains("FILE_TYPE")) {
                            if (token[1].ToUpper().Contains("INTEGER"))
                                Is16Bit = true;
                            else
                                Is16Bit = false;

                        }
                        if (token[0].ToUpper().Contains("NUM_SERIES"))
                            ChannelCount = Convert.ToUInt32(token[1]);
                        if (token[0].ToUpper().Contains("NUM_SAMPS"))
                            BurstCount = Convert.ToUInt32(token[1]);
                        if (token[0].ToUpper().Contains("RATE"))
                            Samplerate = Convert.ToDouble(token[1], new CultureInfo("en-US"));
                        if (token[0].ToUpper().Contains("SLOPE")) {
                            Slope = new double[token.Length - 1];
                            for (int i = 1; i < token.Length; i++) {
                                string value = token[i].ToUpper().Trim();
                                Double.TryParse(value, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out extraD);
                                Slope[i - 1] = extraD;
                            }
                        }
                        if (token[0].ToUpper().Contains("Y_OFFSET")) {
                            YOffset = new double[token.Length - 1];
                            for (int i = 1; i < token.Length; i++) {
                                string value = token[i].ToUpper().Trim();
                                Double.TryParse(value, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out extraD);
                                YOffset[i - 1] = extraD;
                            }
                        }

                    }
                    line = reader.ReadLine();
                }

            }
        }

        public void ReadRaw(Int64 AIStartBurst, Int64 AINumberOfBursts, ref Array AROutputArray) {
            Int64 startByte = ChannelCount * AIStartBurst * 2;
            Int64 numberOfBytes = ChannelCount * AINumberOfBursts * 2;
            if (!Is16Bit) {
                startByte *= 2;
                numberOfBytes *= 2;
            }
            using (BinaryReader br = new BinaryReader((File.Open(m_sDataPath, FileMode.Open)))) {
                if (startByte >= br.BaseStream.Length)
                    return;
                if ((numberOfBytes + startByte) >= br.BaseStream.Length)
                    numberOfBytes = br.BaseStream.Length - startByte;
                br.BaseStream.Position = startByte;
                byte[] bytes = br.ReadBytes((int)numberOfBytes);
                Buffer.BlockCopy(bytes, 0, AROutputArray, 0, (int)numberOfBytes);
            }
        }

        public double[] ReadScaled(uint AIChannelNumber, Int64 AIStartBurst, Int64 AINumberOfBursts,  bool AIHalveAmplitude) {
            if (AIChannelNumber >= ChannelCount)
                return null;
            Array Intermediate;
            if (Is16Bit) {
                Intermediate = new Int16[AINumberOfBursts, ChannelCount];
            }
            else {
                Intermediate = new int[AINumberOfBursts, ChannelCount];
            }
            ReadRaw(AIStartBurst, AINumberOfBursts, ref Intermediate);
            List<double> retVal = new List<double>();
            for (int iKanal = 0; iKanal < ChannelCount; iKanal++) {
         
         
                for (int iWert = 0; iWert < AINumberOfBursts; iWert++) {

                    object o = Intermediate.GetValue(iWert, iKanal);
                    double val = Convert.ToDouble(o);
                    double slope = Slope[iKanal];
                    if (AIHalveAmplitude)
                        slope /= 2.0;
                    retVal.Add( val * slope + YOffset[iKanal]);
                }

            }
            return retVal.ToArray();
        }



        public uint BurstCount {
            private set;
            get;
        }

        public uint ChannelCount {
            private set;
            get;
        }

        public bool Is16Bit {
            private set;
            get;
        }
        public double Samplerate {
            private set;
            get;
        }
        public double[] Slope {
            private set;
            get;
        }
        public double[] YOffset {
            private set;
            get;
        }
        public string Filename {
            private set;
            get;  
        }
    }
}
