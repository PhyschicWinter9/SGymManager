using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGymManagerv2
{
    public partial class frmInvoiceDelete : Form
    {
        public frmInvoiceDelete()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet(); // Create ds
        public static string connection = @"Data Source=SURAT-PC\SQLEXPRESS;Initial Catalog=sgym_db;Integrated Security=True";

        msgDelete msgdelete = new msgDelete();
        public void MessageBox_Delete()
        {
            if (msgdelete.IsDisposed == true)
            {
                msgdelete = new msgDelete();
            }

            msgdelete.ShowDialog();
        }

        private void cbbInvoicelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInvoiceDelete_Load(object sender, EventArgs e)
        {
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

                cbbInvoicelist.Items.Add(dr1.GetValue(0).ToString());

            }
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {

                timer1.Stop();

            }
            Opacity += .5;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                
                    string query = "DELETE FROM tblInvoice WHERE InvoiceID = '"+ cbbInvoicelist.Text+ "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    da.SelectCommand.ExecuteNonQuery();
                    MessageBox_Delete();
                //MessageBox.Show("Delete Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {

                this.Close();

            }
            Opacity -= .5;
        }
    }
}
