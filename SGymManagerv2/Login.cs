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
    public partial class Login_Form : Form
    {
        //Connect DB
        SqlCommand com = new SqlCommand();
        SqlConnection conn = new SqlConnection();



        public Login_Form()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=SURAT-PC\SQLEXPRESS;Initial Catalog=sgym_db;Integrated Security=True";
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            com.Connection = conn;
            com.CommandText = "SELECT * FROM tblAuth WHERE Username='" + txtUsername.Text.Trim() + "'";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (txtUsername.Text.Equals(dr["Username"].ToString()) && txtPassword.Text.Equals(dr["Password"].ToString()))
                {
                    MessageBox.Show("Login Successfully\n\nWelcome "+txtUsername.Text+"", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    Dashboard dashboard1 = new Dashboard(this);
                    dashboard1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            else
            {
                MessageBox.Show("Invalid Username\n\nPlease Sign Up or Contact Support\nadmin@relaxlike.xyz", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
            //btnSignup.Enabled = false;
            this.Hide();
                       

            
        }

        private void btnControlExit_Login_Click(object sender, EventArgs e)
        {
            DialogResult result_exit = MessageBox.Show("Do you want to exit", "Are you Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result_exit == DialogResult.Yes)
            {
                Application.Exit();
                
            }
            else
            {

            }
        }

        private void btnBypass_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "admin";
        }
    }
}
