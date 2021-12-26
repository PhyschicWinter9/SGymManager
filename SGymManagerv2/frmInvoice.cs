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
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet(); // Create ds
        public static string connection = @"Data Source=SURAT-PC\SQLEXPRESS;Initial Catalog=sgym_db;Integrated Security=True";

        msgSave msgsave = new msgSave();
        msgDelete msgdelete = new msgDelete();


        public void MessageBox_save()
        {
            if (msgsave.IsDisposed == true)
            {
                msgsave = new msgSave();
            }

            msgsave.ShowDialog();
        }


        public void MessageBox_Delete()
        {
            if (msgdelete.IsDisposed == true)
            {
                msgdelete = new msgDelete();
            }

            msgdelete.ShowDialog();

        }

            private void frmInvoice_Load(object sender, EventArgs e)
        {
            //Load Table
            string sql = "SELECT * FROM tblInvoice";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "Invoice"); //Datatable
            //gridInvoice.DataSource = ds.Tables["Invoice"];



            //Cbb AppID
            SqlConnection con = new SqlConnection(connection);
            string sql1 = "SELECT AppID FROM tblApply";
            SqlCommand sc1 = new SqlCommand(sql1, con);
            con.Open();
            SqlDataReader dr1 = sc1.ExecuteReader();
            while (dr1.Read())
            {
                //string fname = dr2.GetString(0);
                //string lname = dr2.GetString(1);
                //string fullname = ""+fname+" "+lname+"";

               cbbAppID.Items.Add(dr1.GetValue(0).ToString());

            }
            con.Close();
        }

        private void cbbAppID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "SELECT * FROM tblApply WHERE AppID = '" + cbbAppID.Text + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sr;
            try
            {
                con.Open();
                sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    string memid = sr.GetString(1);
                    string fn = sr.GetString(2);
                    string ln = sr.GetString(3);
                    string cid = sr.GetString(4);
                    string cname = sr.GetString(5);
                    string cprice = sr.GetString(6);
                    string register = sr.GetString(7);
                    string expiration = sr.GetString(8);


                    txtMemID.Text = memid;
                    txtFirstname.Text = fn;
                    txtLastname.Text = ln;
                    txtCourseID.Text = cid;
                    txtCoursename.Text = cname;
                    txtCoursePrice.Text = cprice;
                    txtRegisterDate.Text = register;
                    txtExpirationDate.Text = expiration;
             
                }
            }






            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            string query1 = "SELECT * FROM tblMember WHERE ID = '" + txtMemID.Text + "'";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            try
            {
                con.Open();
                sr = cmd1.ExecuteReader();
                while (sr.Read())
                {
                    
                    
                    string address = sr.GetString(3);
                    string telphone = sr.GetString(7);


                    txtAddress.Text = address;
                    txtPhone.Text = telphone;



                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "INSERT INTO tblInvoice(InvoiceID,APID,MemID,Firstname,Lastname,Phone,Address,Register,Expiration,CourseID,CourseName,CoursePrice) " +
                    "VALUES('" + txtReciept.Text + "','" + cbbAppID.Text + "','"+txtMemID.Text+"','" + txtFirstname.Text + "'," +
                    "'" + txtLastname.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + txtRegisterDate.Text + "','" + txtExpirationDate.Text + "','" + txtCourseID.Text + "'," +
                    "'"+txtCoursename.Text+"','"+txtCoursePrice.Text+"')";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                da.SelectCommand.ExecuteNonQuery();

                MessageBox_save();


                //MessageBox.Show("Save Success", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmInvoiceDelete frmInvoiceDelete = new frmInvoiceDelete();
            frmInvoiceDelete.ShowDialog();
        }
    }
}
