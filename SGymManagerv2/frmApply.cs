using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SGymManagerv2
{
    public partial class frmApply : Form
    {
        public frmApply()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet(); // Create ds
        public static string connection = @"Data Source=SURAT-PC\SQLEXPRESS;Initial Catalog=sgym_db;Integrated Security=True";


        msgUpdate msgupdate = new msgUpdate();
        msgSave msgsave = new msgSave();
        msgDelete msgdelete = new msgDelete();


        private void frmApply_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connection);
            string sql1 = "SELECT CourseID FROM tblCourse";
            SqlCommand sc1 = new SqlCommand(sql1, con);
            con.Open();
            SqlDataReader dr1 = sc1.ExecuteReader();
            while (dr1.Read())
            {
                //string fname = dr2.GetString(0);
                //string lname = dr2.GetString(1);
                //string fullname = ""+fname+" "+lname+"";

                cbbCourseID.Items.Add(dr1.GetValue(0).ToString());

            }
            con.Close();


            //MemberList
            
            string sql2 = "SELECT ID FROM tblMember";
            SqlCommand sc = new SqlCommand(sql2, con);
            con.Open();
            SqlDataReader dr2 = sc.ExecuteReader();
            while (dr2.Read())
            {
                //string fname = dr2.GetString(0);
                //string lname = dr2.GetString(1);
                //string fullname = ""+fname+" "+lname+"";
               
                cbbMemberlist.Items.Add(dr2.GetValue(0).ToString());
                
            }
            con.Close();


            //Load Table
            string sql = "SELECT * FROM tblApply";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "Apply"); //Datatable
            gridApply.DataSource = ds.Tables["Apply"];



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "INSERT INTO tblApply(AppID,MemID,Firstname,Lastname,CourseID,CourseName,CoursePrice,Register,Expiration) " +
                    "VALUES('" + txtAppId.Text + "','" + cbbMemberlist.Text + "','" + txtFirstname.Text + "'," +
                    "'" + txtLastname.Text + "','"+cbbCourseID.Text+"','"+txtCoursename.Text+"','"+txtCoursePrice.Text+"','"+txtRegisterDate.Text+"','"+txtExpirationDate.Text+"')";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                da.SelectCommand.ExecuteNonQuery();

                if (msgsave.IsDisposed == true)
                {
                    msgsave = new msgSave();
                }

                msgsave.ShowDialog();



                //MessageBox.Show("Apply Success", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbbMemberlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "SELECT * FROM tblMember WHERE ID = '"+cbbMemberlist.Text+"';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sr;
            try
            {
                con.Open();
                sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    string fn = sr.GetString(1);
                    string ln = sr.GetString(2);

                    txtFirstname.Text = fn;
                    txtLastname.Text = ln;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbCourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "SELECT * FROM tblCourse WHERE CourseID = '" +cbbCourseID.Text+ "';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sr;
            try
            {
                con.Open();
                sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    string Coursenaem = sr.GetString(1);
                    string CoursePrice = sr.GetString(2);

                    txtCoursename.Text = Coursenaem;
                    txtCoursePrice.Text = CoursePrice;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "UPDATE tblApply SET Firstname = '" + txtFirstname.Text + "',Lastname = '" + txtLastname.Text + "',CourseID = '" + cbbCourseID.Text + "'," +
                    "CourseName = '" + txtCoursename.Text + "',CoursePrice = '" + txtCoursePrice.Text + "',Register = '" + txtRegisterDate.Text + "',Expiration = '"+txtExpirationDate.Text+"' WHERE AppID = '" + txtAppId.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                da.SelectCommand.ExecuteNonQuery();

                if (msgupdate.IsDisposed == true)
                {
                    msgupdate = new msgUpdate();
                }

                msgupdate.ShowDialog();


                //MessageBox.Show("Update Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (MessageBox.Show("Do you want to Delete ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string query = "DELETE FROM tblApply WHERE AppID = '" + gridApply.CurrentRow.Cells[0].Value + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    da.SelectCommand.ExecuteNonQuery();


                    if (msgdelete.IsDisposed == true)
                    {
                        msgdelete = new msgDelete();
                    }

                    msgdelete.ShowDialog();


                    MessageBox.Show("Delete Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // ไม่เลือก
                return; // จบการทำงาน
            else
            {
                gridApply.Rows[e.RowIndex].Selected = true;

                //Method 1 Getdata form DataTable
                DataRow dr = ds.Tables["Apply"].Rows[e.RowIndex];
                txtAppId.Text = dr["AppID"].ToString();
                cbbMemberlist.SelectedItem = dr["MemID"].ToString();
                txtFirstname.Text = dr["Firstname"].ToString();
                txtLastname.Text = dr["Lastname"].ToString();
                cbbCourseID.SelectedItem = dr["CourseID"].ToString();
                txtCoursename.Text = dr["Coursename"].ToString();
                txtCoursePrice.Text = dr["CoursePrice"].ToString();
                txtRegisterDate.Text = dr["Register"].ToString();
                txtExpirationDate.Text = dr["Expiration"].ToString();




                gridApply.Rows[e.RowIndex].Selected = true;
            }
        }

        private void txtAppId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
