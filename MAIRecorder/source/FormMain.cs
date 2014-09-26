using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Goldammer;
using Goldammer.Controls;
using System.Reflection;

namespace MAIRecorder {
    public partial class Form1 : Form {

        #region private

        #region fields

        private MAIDevice m_selected;
        private DataTable m_dtCardProperties;

        #endregion

        #region ui_event_handler

        private void button1_Click(object sender, EventArgs e) {
            GetDevices();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {


            m_selected = MAI.Devices[listBox1.SelectedItem.ToString()];
           
            panel1.Visible =  !m_selected.HasDatasinkLicense;
          
            m_dtCardProperties = new DataTable();
            m_dtCardProperties.Columns.Add("Property", typeof(string));
            m_dtCardProperties.Columns.Add("Value", typeof(string));
          //  textBox1.Text = m_selected.Info.GetCompleteDescriptionString();

            m_dtCardProperties.Rows.Add("I am MAIRecorder Version", Application.ProductVersion );
            m_dtCardProperties.Rows.Add("and using MAIv2 Version", MAI.GetAssemblyVersion());
            m_dtCardProperties.Rows.Add("Card Series", m_selected.Info.CardName);
            m_dtCardProperties.Rows.Add("Model", m_selected.Info.ManufactureName);
            m_dtCardProperties.Rows.Add("SerialNumber", m_selected.Info.SerialNumber);
            m_dtCardProperties.Rows.Add("CardProducer", m_selected.Info.CardProducer);
            m_dtCardProperties.Rows.Add("CardSeller", m_selected.Info.CardSeller);
            m_dtCardProperties.Rows.Add("Customer", m_selected.Info.CustomerNumber+" ("+ m_selected.Info.CustomerName+")");
            m_dtCardProperties.Rows.Add("DateOfPurchase", m_selected.Info.DateOfPurchase);

            m_dtCardProperties.Rows.Add("ADChannels", m_selected.Info.ADChannels);
            m_dtCardProperties.Rows.Add("ADSampleRate", m_selected.Info.ADSampleRate);
            m_dtCardProperties.Rows.Add("ADSampleWidth", m_selected.Info.ADSampleWidth); 
            m_dtCardProperties.Rows.Add("DAChannels", m_selected.Info.DAChannels);
            m_dtCardProperties.Rows.Add("DASampleRate", m_selected.Info.DASampleRate);
            m_dtCardProperties.Rows.Add("DASampleWidth", m_selected.Info.DASampleWidth);
            m_dtCardProperties.Rows.Add("CTChannels", m_selected.Info.CTChannels);
            m_dtCardProperties.Rows.Add("CTSampleRate", m_selected.Info.CTSampleRate);
            m_dtCardProperties.Rows.Add("CTSampleWidth", m_selected.Info.CTSampleWidth);

            m_dtCardProperties.Rows.Add("TTLChannels", m_selected.Info.TTLChannels);
            m_dtCardProperties.Rows.Add("TTLSampleRate", m_selected.Info.TTLSampleRate);
            m_dtCardProperties.Rows.Add("TTLSampleWidth", m_selected.Info.TTLSampleWidth);
            m_dtCardProperties.Rows.Add("PWMChannels", m_selected.Info.PWMChannels);
            m_dtCardProperties.Rows.Add("PWMSampleRate", m_selected.Info.PWMSampleRate);
            m_dtCardProperties.Rows.Add("PWMSampleWidth", m_selected.Info.PWMSampleWidth);

            m_dtCardProperties.Rows.Add("DSP RTFunctions", m_selected.Info.OnlineFunctionsPossible);
            int hwxcounter = 1;
            foreach (HWExtension hwx in Enum.GetValues(typeof(HWExtension)))
                if (m_selected.HasHardwareExtension(hwx)) {
                    m_dtCardProperties.Rows.Add("HardwareExtension " + hwxcounter.ToString(), hwx.ToString().Replace("_", " ").Trim());
                    hwxcounter++;
                }

            int swxcounter = 1;
            foreach (SWExtension swx in Enum.GetValues(typeof(SWExtension)))
                if (m_selected.HasSoftwareExtension(swx)) {
                    m_dtCardProperties.Rows.Add("SoftwareExtension " + swxcounter.ToString(), swx.ToString().Replace("_", " ").Trim());
                    swxcounter++;
                }
            m_dtCardProperties.Rows.Add("Altera Version", String.Format("{0:X}",m_selected.Info.MeasureProcessorVersion));
            m_dtCardProperties.Rows.Add("Firmware ", ((m_selected.Info.ControllerVersion & 0xFF00)>>8) + "." + (m_selected.Info.ControllerVersion & 0xFF));
            m_dtCardProperties.Rows.Add("has DSP ", m_selected.IsDSPDevice);
            m_dtCardProperties.Rows.Add("WDMDriverVersion", m_selected.GetWDMDriverVersion());
            if (m_selected.DeviceType == MeasurementDeviceType.MULTICHOICE_USB_BASIC) {
                m_dtCardProperties.Rows.Add("Frontend ID", m_selected.Info.BasicFrontendID);
                m_dtCardProperties.Rows.Add("Digital Ext ID", m_selected.Info.BasicDigitalExtensionID);
            }
            

            dgvCardProperties.DataSource = m_dtCardProperties;
            MAIDeviceImage img = MAIDeviceImage.GetMAIDeviceImagesBySerial(listBox1.SelectedItem.ToString());
            pictureBox1.Image = img.Large;
        //    UpdateAnalogChannels(m_selected);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e) {
            try {
                ShowMeasureform(MAI.Devices[listBox1.SelectedItem.ToString()]);
            }
            catch (Exception x){
                MessageBox.Show(x.Message);
            }
        }

        private void buttonMeasure_Click(object sender, EventArgs e) {
            try {
                ShowMeasureform(MAI.Devices[listBox1.SelectedItem.ToString()]);
            }
            catch (Exception x){
                MessageBox.Show(x.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            FormAddETH.Show();


        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e) {
            //DataGridPrinter dgp = new DataGridPrinter(dgvCardProperties);

            //dgp.HeaderText = "Some text";
            //dgp.HeaderHeightPercent = 10;
            //dgp.FooterHeightPercent = 5;
            //dgp.InterSectionSpacingPercent = 2;

            //printPreviewDialog1.Document = dgp.PrintDocument;
            //if(printPreviewDialog1.ShowDialog() == DialogResult.OK) 
            //    dgp.Print();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://www.goldammer.de/?langid=0&top=home&left=sdk_dotnetDAQ");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string order = "mailto:info@goldammer.de?subject=Angebot für MAIExtensionDAQ Lizenzen&body=Sehr geehrete Damen und Herren,%0A%0A";
            order += "ich interessiere mich für Ihre Datenerfassungs Erweiterung der MAIv2DotNet Schnittstelle.%0A%0A";
            order += "Ich verwende die folgenden Geräte:%0A";
            foreach (string ser in MAI.GetSerialNumbersOfAllInstalledDevices()) {
                order += ser + "%0A";
            }
            order += Environment.NewLine;
            order += "%0A%0ABitte senden sie mir ein Angebot, das  MAIExtensionDAQ Lizenzen für diese Geräte umfasst.%0A%0A";
            order += "Mit freundlichen Grüßen %0A%0A";
            System.Diagnostics.Process.Start(order);
        }
     
        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            var dataObject = new System.Windows.Forms.DataObject();
            dataObject.SetData(DataFormats.Text, ToText(m_dtCardProperties,"\t"));
            Clipboard.SetDataObject(dataObject, true);
        }

        #endregion
         
        #region methods

        private void ShowMeasureform(MAIDevice AIDevice) {
            if(AIDevice.IsAudioDevice)
                AudioCardWindow.Show(AIDevice);     
            else        
                CardWindow.Show(AIDevice);
        }

        private void GetDevices() {
            listBox1.Items.Clear();
            List<MAIDevice> tmp = MAI.GetDeviceList();
            listBox1.Items.AddRange(MAI.GetSerialNumbersOfAllInstalledDevices().ToArray());
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
        }
 
        private string ToText(DataTable AITable, string AIColumnSeparator) {
            StringBuilder sb = new StringBuilder();
            if (AITable == null)
                return "";
            foreach (DataRow r in AITable.Rows) {

                for (int i = 0; i < AITable.Columns.Count; i++) {
                    sb.Append(r[i].ToString());
                    sb.Append(AIColumnSeparator);
                }

                sb.AppendLine();
            }
            return sb.ToString();
        }

        #endregion

        #endregion

        #region public

        public Form1() {
            InitializeComponent();
            GetDevices();
        }

        #endregion

    }
}
