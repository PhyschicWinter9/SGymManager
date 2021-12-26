using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGymManagerv2
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet(); // Create ds
        public static string connection = @"Data Source=SURAT-PC\SQLEXPRESS;Initial Catalog=sgym_db;Integrated Security=True";



        private void frmReport_Load(object sender, EventArgs e)
        {
            //Cbb Invoice
            SqlConnection con = new SqlConnection(connection);
            string sql1 = "SELECT InvoiceID FROM tblInvoice";
            SqlCommand sc1 = new SqlCommand(sql1, con);
            con.Open();
            SqlDataReader dr1 = sc1.ExecuteReader();
            while (dr1.Read())
            {
                //string fname = dr2.GetString(0);
                //string lname = dr2.GetString(1);
                //string fullname = ""+fname+" "+lname+"";

                cbbInvoice.Items.Add(dr1.GetValue(0).ToString());

            }
            con.Close();
            this.reportInvoice.RefreshReport();
            this.reportInvoice.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query = "SELECT * FROM tblInvoice WHERE InvoiceID = '"+cbbInvoice.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);



            ReportDataSource rds = new ReportDataSource("Invoice",dt);
            reportInvoice.LocalReport.ReportPath = @"C:\Users\surat\source\repos\SGymManagerv2\SGymManagerv2\Invoice.rdlc";
            reportInvoice.LocalReport.DataSources.Clear();
            reportInvoice.LocalReport.DataSources.Add(rds);
            reportInvoice.RefreshReport();
        }
    }
}
