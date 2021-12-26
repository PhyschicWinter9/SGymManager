using System;
using System.IO;
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
    public partial class frmMembership : Form
    {
        public frmMembership()
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



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

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


            //New Vesion
            Stream mystream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPEG|*.jpg;*jpeg;*jpe;*jfif|PNG|*.png|BMP|*.bmp|all files|*.*";
            if(openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {

                try
                {
                    if((mystream= openFileDialog1.OpenFile()) != null)
                    {
                        string FileName = openFileDialog1.FileName;
                        if(mystream.Length > 512000)
                        {
                            MessageBox.Show("File Size Limit");
                        }
                        else
                        {
                            picboxup.Load(FileName);
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "INSERT INTO tblMember(ID,Firstname,Lastname,Address,Gender,Age,Email,Phone,Weight,Height,Plann,Price,Picture) " +
                    "VALUES('"+txtMemID.Text+"','"+txtFirstname.Text+"','"+txtLastname.Text+"','"+txtAddress.Text+"','"+cbGender.Text+"','"+txtAge.Text+"'," +
                    "'"+txtEmail.Text+"','"+txtPhone.Text+"','"+txtWeight.Text+ "','"+txtHeight.Text+"','"+cbPlan.Text+"','"+txtPrice.Text+"',@Pic)";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                MemoryStream stream = new MemoryStream();
                picboxup.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                da.SelectCommand.Parameters.AddWithValue("@Pic", pic);

                con.Open();
                da.SelectCommand.ExecuteNonQuery();

                MessageBox_Save();

                //MessageBox.Show("Account Created Successfully...", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearData();
                this.Refresh();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void frmMembership_Load(object sender, EventArgs e)
        {
            string sql = "SELECT ID,Firstname,Lastname,Address,Gender,Age,Email,Phone,Weight,Height,Plann,Price,Picture FROM tblMember";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "Member"); //Datatable
            gridMem.DataSource = ds.Tables["Member"];
        }

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPlan.SelectedIndex == 0)
            {
                txtPrice.Text = "750";

            }else if(cbPlan.SelectedIndex == 1)
            {
                txtPrice.Text = "6500";
            }
        }

        private void gridMem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] ImageArray = (byte[])gridMem.CurrentRow.Cells[12].Value;


            if (e.RowIndex == -1) // ไม่เลือก
                return; // จบการทำงาน
            else
            {
                gridMem.Rows[e.RowIndex].Selected = true;

                //Method 1 Getdata form DataTable
                DataRow dr = ds.Tables["Member"].Rows[e.RowIndex];
                txtMemID.Text = dr["ID"].ToString();
                txtFirstname.Text = dr["Firstname"].ToString();
                txtLastname.Text = dr["Lastname"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                cbGender.SelectedItem = dr["Gender"].ToString();
                txtAge.Text = dr["Age"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtWeight.Text = dr["Weight"].ToString();
                txtHeight.Text = dr["Height"].ToString();
                cbPlan.SelectedItem = dr["Plann"].ToString();
                txtPrice.Text = dr["Price"].ToString();
                picboxup.Image = Image.FromStream(new MemoryStream(ImageArray));


                //picboxup.Image = Image.FromStream(pic);


                //picboxup.Image = Image.FromStream(new MemoryStream(pic));


                //Method 2 getdata form gridview
                /*DataGridViewRow dgr = gridEmp.Rows[e.RowIndex];
                txtEmpID.Text = dgr.Cells[0].Value.ToString();
                txtEmpName.Text = dgr.Cells[1].Value.ToString();
                cbbDept.SelectedValue = dgr.Cells[2].Value.ToString();*/





                gridMem.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);

            DialogResult rs;
            rs = MessageBox.Show("Do you want to edit the information?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {

                if (rs == DialogResult.Yes)
                {
                    string query = "UPDATE tblMember SET Firstname = '" + txtFirstname.Text + "',Lastname = '" + txtLastname.Text + "',Address = '" + txtAddress.Text + "'," +
                        "Gender = '" + cbGender.Text + "',Age = '" + txtAge.Text + "',Email = '" + txtEmail.Text + "',Phone = '" + txtPhone.Text + "'," +
                        "Weight = '" + txtWeight.Text + "',Height = '" + txtHeight.Text + "',Plann = '" + cbPlan.Text + "',Price = '" + txtPrice.Text + "',Picture = @Pic WHERE ID ='" + txtMemID.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    MemoryStream stream = new MemoryStream();
                    picboxup.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    da.SelectCommand.Parameters.AddWithValue("@Pic", pic);

                    con.Open();
                    da.SelectCommand.ExecuteNonQuery();

                    MessageBox_Update();

                    //MessageBox.Show("Update Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ClearData();
                    this.Refresh();

                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (MessageBox.Show("Do you want to delete Record ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string query = "DELETE FROM tblMember WHERE ID = '" + gridMem.CurrentRow.Cells[0].Value + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    da.SelectCommand.ExecuteNonQuery();


                    MessageBox_Delete();

                    //MessageBox.Show("Delete Successfully....", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Refresh();
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
    }
}
