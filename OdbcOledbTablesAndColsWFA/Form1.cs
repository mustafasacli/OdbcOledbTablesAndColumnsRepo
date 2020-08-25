using System;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OdbcOledbTablesAndColsWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetTablesAndCols_Click(object sender, EventArgs e)
        {
            GetTablesAndCols();
        }

        private void GetTablesAndCols()
        {
            try
            {
                grdColumns.DataSource = null;
                grdTables.DataSource = null;
                if (txtConnStr.Text.Length > 0)
                {
                    //Oledb
                    if (chkIsOdbc.Checked)
                    {
                        using (OleDbConnection oledbConn = new OleDbConnection(txtConnStr.Text))
                        {
                            oledbConn.Open();
                            grdTables.DataSource = oledbConn.GetSchema("TABLES");
                            grdColumns.DataSource = oledbConn.GetSchema("COLUMNS");
                            oledbConn.Close();
                        }
                    }
                    //Odbc
                    else
                    {
                        using (OdbcConnection odbcConn = new OdbcConnection(txtConnStr.Text))
                        {
                            odbcConn.Open();
                            grdTables.DataSource = odbcConn.GetSchema("TABLES");
                            grdColumns.DataSource = odbcConn.GetSchema("COLUMNS");
                            odbcConn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}\nStack Trace : {1}", ex.Message, ex.StackTrace));
            }
            finally
            {
                grdColumns.Refresh();
                grdTables.Refresh();
            }
        }

        private void chkIsOdbc_CheckedChanged(object sender, EventArgs e)
        {
            chkIsOdbc.Text = chkIsOdbc.Checked ? "Oledb" : "Odbc";
        }
    }
}