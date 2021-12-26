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
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet(); // Create ds
        public static string connection = @"Data Source=SURAT-PC\SQLEXPRESS;Initial Catalog=sgym_db;Integrated Security=True";

        msgUpdate msgupdate = new msgUpdate();
        msgSave msgsave = new msgSave();
        msgDelete msgdelete = new msgDelete();


        public void MessageBox_Save()
        {
            if (msgsave.IsDisposed == true)
            {
                msgsave = new msgSave();
            }

            msgsave.ShowDialog();
        }

        public void MessageBox_Update()
        {
            if (msgupdate.IsDisposed == true)
            {
                msgupdate = new msgUpdate();
            }

            msgupdate.ShowDialog();
        }

        public void MessageBox_Delete()
        {
            if (msgdelete.IsDisposed == true)
            {
                msgdelete = new msgDelete();
            }

            msgdelete.ShowDialog();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "INSERT INTO tblCourse(CourseID,Name,Price,Trainer) " +
                    "VALUES('"+txtCourseID.Text+"','"+txtCourseName.Text+"','"+txtCoursePrice.Text+"','"+cbbTrainer.Text+"')";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                da.SelectCommand.ExecuteNonQuery();


                MessageBox_Save();

                //MessageBox.Show("Course Added Successfully...", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sgym_dbDataSet.tblEmployee' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'sgym_dbDataSetEmployee_useCourse.tblEmployee' table. You can move, or remove it, as needed.
            //this.tblEmployeeTableAdapter.Fill(this.sgym_dbDataSetEmployee_useCourse.tblEmployee);

            //Load Form
            string sql = "SELECT * FROM tblCourse";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "Course"); //Datatable
            gridCourse.DataSource = ds.Tables["Course"];


            //Load data to cbbTranner
            SqlConnection con = new SqlConnection(connection);
            string sql1 = "SELECT ID FROM tblEmployee";
            SqlCommand sc = new SqlCommand(sql1, con);
            con.Open();
            SqlDataReader dr1 = sc.ExecuteReader();
            while (dr1.Read())
            {
                cbbTrainer.Items.Add(dr1.GetValue(0).ToString());
            }
            con.Close();

        }

        private void gridCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // ไม่เลือก
                return; // จบการทำงาน
            else
            {
                gridCourse.Rows[e.RowIndex].Selected = true;

                //Method 1 Getdata form DataTable
                DataRow dr = ds.Tables["Course"].Rows[e.RowIndex];
                txtCourseID.Text = dr["CourseID"].ToString();
                txtCourseName.Text = dr["Name"].ToString();
                txtCoursePrice.Text = dr["Price"].ToString();
                cbbTrainer.SelectedItem = dr["Trainer"].ToString();



                gridCourse.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "UPDATE tblCourse SET CourseID ='"+txtCourseID.Text+"',Name ='"+txtCourseName.Text+"'," +
                    "Price ='"+txtCoursePrice.Text+"',Trainer ='"+cbbTrainer.Text+"' WHERE CourseID = '"+txtCourseID.Text+"'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);



                con.Open();
                da.SelectCommand.ExecuteNonQuery();

                MessageBox_Update();

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
                gridCourse.Update();
                gridCourse.Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (MessageBox.Show("Do you want to Delete ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string query = "DELETE FROM tblCourse WHERE CourseID = '" + gridCourse.CurrentRow.Cells[0].Value + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);


                    con.Open();
                    da.SelectCommand.ExecuteNonQuery();

                    MessageBox_Delete();

                    //MessageBox.Show("Delete Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            gridCourse.Update();
            gridCourse.Refresh();
        }

        
    }
}
