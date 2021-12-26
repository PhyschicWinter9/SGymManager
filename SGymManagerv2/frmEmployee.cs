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
using System.IO;

namespace SGymManagerv2
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet(); // Create ds
        public static string connection = @"Data Source=SURAT-PC\SQLEXPRESS;Initial Catalog=sgym_db;Integrated Security=True";

        msgUpdate msgupdate = new msgUpdate();
        msgSave msgsave = new msgSave();
        msgDelete msgdelete = new msgDelete();

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "INSERT INTO tblEmployee(ID,Name,Nickname,Gender,Age,Salary,Phone,Picture) " +
                    "VALUES('"+txtEmpID.Text+"','" +txtName.Text+ "','" + txtNickname.Text + "','" + cbGender.Text + "','" + txtAge.Text + "','"+txtSalary.Text+"','"+txtPhone.Text+"',@Pic)";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                MemoryStream stream = new MemoryStream();
                picboxup.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                da.SelectCommand.Parameters.AddWithValue("@Pic", pic);

                con.Open();
                da.SelectCommand.ExecuteNonQuery();

                if (msgsave.IsDisposed == true)
                {
                    msgsave = new msgSave();
                }

                msgsave.ShowDialog();


                //MessageBox.Show("Account Create Successfully...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                gridEmp.Update();
                gridEmp.Refresh();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            /*

            //old veriosn
            /*if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                byte[] bytes = File.ReadAllBytes(fileName);
                string content_type;
                //Set the contenttype based on File Extension

                switch (Path.GetExtension(fileName))
                {
                    case ".jpg":
                        content_type = "image/jpeg";
                        break;
                    case ".png":
                        content_type = "image/png";
                        break;
                    case ".gif":
                        content_type = "image/gif";
                        break;
                    case ".bmp":
                        content_type = "image/bmp";
                        break;
                }
            }*/
            //}


            Stream mystream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPEG|*.jpg;*jpeg;*jpe;*jfif|PNG|*.png|BMP|*.bmp|all files|*.*";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {

                try
                {
                    if ((mystream = openFileDialog1.OpenFile()) != null)
                    {
                        string FileName = openFileDialog1.FileName;
                        if (mystream.Length > 512000)
                        {
                            MessageBox.Show("File Size Limit");
                        }
                        else
                        {
                            picboxup.Load(FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            string sql = "SELECT ID,Name,Nickname,Gender,Age,Salary,Phone,Picture FROM tblEmployee";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "Employee"); //Datatable
            gridEmp.DataSource = ds.Tables["Employee"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "UPDATE tblEmployee SET Name = '"+txtName.Text+"',Nickname = '"+txtNickname.Text+"',Gender = '"+cbGender.Text+"'," +
                    "Age = '"+txtAge.Text+"',Salary = '"+txtSalary.Text+"',Phone = '"+txtPhone.Text+"',Picture = @Pic WHERE ID = '"+txtEmpID.Text+"'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                MemoryStream stream = new MemoryStream();
                picboxup.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                da.SelectCommand.Parameters.AddWithValue("@Pic", pic);

                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                
                if(msgupdate.IsDisposed == true)
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
                gridEmp.Update();
                gridEmp.Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (MessageBox.Show("Do you want to Delete ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string query = "DELETE FROM tblEmployee WHERE ID = '" + gridEmp.CurrentRow.Cells[0].Value + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    da.SelectCommand.ExecuteNonQuery();

                    if (msgdelete.IsDisposed == true)
                    {
                        msgdelete = new msgDelete();
                    }

                    msgdelete.ShowDialog();


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
            gridEmp.Update();
            gridEmp.Refresh();
        }

        private void gridEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] ImageArray = (byte[])gridEmp.CurrentRow.Cells[7].Value;


            if (e.RowIndex == -1) // ไม่เลือก
                return; // จบการทำงาน
            else
            {
                gridEmp.Rows[e.RowIndex].Selected = true;

                //Method 1 Getdata form DataTable
                DataRow dr = ds.Tables["Employee"].Rows[e.RowIndex];
                txtEmpID.Text = dr["ID"].ToString();
                txtName.Text = dr["Name"].ToString();
                txtNickname.Text = dr["Nickname"].ToString();
                cbGender.SelectedItem = dr["Gender"].ToString();
                txtAge.Text = dr["Age"].ToString();
                txtSalary.Text = dr["Salary"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                picboxup.Image = Image.FromStream(new MemoryStream(ImageArray));



                gridEmp.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
