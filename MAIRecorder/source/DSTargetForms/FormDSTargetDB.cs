using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Goldammer.MAIExtensions.DAQ;
using System.Data.Sql;
using System.IO;

using System.Data.SqlClient;

namespace MAIRecorder {
    public partial class FormDSTargetDB : MAIRecorder.FormDSTargetConfigBase {

        #region private

        #region fields
        private SqlConnection m_conn = null; 
        #endregion

        #region ui_event_handlers

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

            textBoxSqlCeFile.Enabled = radioButtonCE.Checked;
            textBoxServer.Enabled = radioButtonServer.Checked;
            textBoxDBName.Enabled = radioButtonServer.Checked;
            buttonCE.Enabled = radioButtonCE.Checked;
            buttonServerTest.Enabled = radioButtonServer.Checked;
        }

        private void FormDSTargetDB_Load(object sender, EventArgs e) {

        }

        private void buttonCE_Click(object sender, EventArgs e) {
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(textBoxSqlCeFile.Text);
            saveFileDialog1.FileName = Path.GetFileName(textBoxSqlCeFile.Text);
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            textBoxSqlCeFile.Text = saveFileDialog1.FileName;
        }

        private void buttonServer_Click(object sender, EventArgs e) {
            CreateConnectionAndDB();
            if (m_conn != null)
                MessageBox.Show(Messages.DBConnectionEstablishedText, Messages.DBConnectionEstablishedCaption);
        } 

        #endregion

        #region methods

        private void CreateConnectionAndDB() {
            try {
                m_conn = new SqlConnection(textBoxServer.Text);
                m_conn.Open();
                SqlCommand exists = m_conn.CreateCommand();
                string dbname = textBoxDBName.Text.Replace(" ", "").Trim();
                exists.CommandText = "if not exists(select * from sys.databases where name = '" + dbname + "') create database " + dbname + ";";

                exists.ExecuteNonQuery();
                m_conn.ChangeDatabase(dbname);
            }
            catch (Exception x) {
                m_conn = null;
                MessageBox.Show(x.Message);
            }

        }

        private string GetTableNameForNOW(DateTime jetzt) {
            string tablename = jetzt.ToLongDateString() + "_" + jetzt.ToLongTimeString() + "_" + jetzt.Millisecond.ToString();

            tablename = tablename.Replace(' ', '_');
            tablename = tablename.Replace('.', '_');
            tablename = tablename.Replace(':', '_');
            tablename = tablename.Replace(',', '_');
            tablename = tablename.Replace("__", "_");
            return tablename;
        }

        #endregion

        #endregion

        #region protected

        protected override void CreateTarget() {
            m_target = null;

            if (radioButtonCE.Checked) {
                if (File.Exists(textBoxSqlCeFile.Text))
                    File.Delete(textBoxSqlCeFile.Text);
                m_target = MAIDataSinkTarget.CreateTargetSQLCeFile(textBoxSqlCeFile.Text);
                m_TargetFileName = Path.GetFileName(textBoxSqlCeFile.Text) + " (SQLCeFile)";
            }
            else {
                DateTime NOW = DateTime.Now;
                string MDTable = "MD_" + GetTableNameForNOW(NOW);
                string CITable = "CI_" + GetTableNameForNOW(NOW);
                CreateConnectionAndDB();
                if (m_conn != null) {
                    m_TargetFileName = m_conn.Database + " on " + m_conn.DataSource + " (SQL DB)";
                    m_target = MAIDataSinkTarget.CreateTargetSQLServer(m_conn, "Measurements", MDTable, CITable, false);
                }
            }

        }

        #endregion

        #region public

        public FormDSTargetDB() {
            InitializeComponent();
            textBoxSqlCeFile.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TestOutput.mdf";
        } 

        #endregion

    }
}
