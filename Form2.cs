using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarryAndForwardAgent
{
    public partial class Form2 : Form
    {
        MyConnection conn = new MyConnection();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'CarryandForwardAgentDataSet.Temp_Table' table. You can move, or remove it, as needed.
            //this.Temp_TableTableAdapter.Fill(this.CarryandForwardAgentDataSet.Temp_Table);

            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();


             this.reportViewer1.RefreshReport();

                string str;
                str = "SELECT * from Temp_Table where ID='1'";
                SqlCommand cmd = new SqlCommand(str, conn.mycon);
                SqlDataAdapter myadr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                myadr.Fill(ds);

                reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                reportViewer1.LocalReport.ReportEmbeddedResource = "CarryAndForwardAgent.Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[0]));

                this.reportViewer1.RefreshReport();  
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
