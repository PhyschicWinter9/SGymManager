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
    public partial class Register : Form
    {

        //Connect DB


        public Register()
        {
            InitializeComponent();
           
        }

        

        private void btnControlClose_Click(object sender, EventArgs e)
        {
            /*DialogResult result_exit = MessageBox.Show("You haven't finished your registration yet", "Are you Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result_exit == DialogResult.Yes)
            {*/
                this.Hide();
                Login_Form Log1 = new Login_Form();
                Log1.ShowDialog();
                this.Close();
                //Application.Exit();
                

            /*}
            else
            {
                
            }*/
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            btnSignup.Enabled = false;
        }

        private void checkboxIagree_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (checkboxIagree.Checked == true)
            {
                btnSignup.Enabled = true;
            }
            else
            {
                btnSignup.Enabled = false;
            }
            
                
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=SURAT-PC\SQLEXPRESS;Initial Catalog=sgym_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "INSERT INTO tblCustumer(Firstname,Lastname,Age,Gender,Username,Password,Phone) " +
                    "VALUES('"+txtFirstname.Text+"','"+txtLastname.Text+"','"+txtAge.Text+"','"+cbGender.Text+"','"+txtUsername.Text+"','"+txtPassword.Text+"','"+txtPhone.Text+"')";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Account Created Successfully...", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();

            }
            catch
            {
                MessageBox.Show("Error occured....", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearData()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtAge.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            cbGender.Text = "";
            checkboxIagree.Checked = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
