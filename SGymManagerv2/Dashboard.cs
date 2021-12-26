using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGymManagerv2
{
    public partial class Dashboard : Form
    {
        Login_Form login;   

        public Dashboard(Login_Form lgin)
        {
            InitializeComponent();
            this.login = lgin;
        }

        


        private void btntoClose_Click(object sender, EventArgs e)
        {
            DialogResult result_exit = MessageBox.Show("Do you want to exit", "Are you Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result_exit == DialogResult.Yes)
            {
                Application.Exit();

            }
            else if(result_exit == DialogResult.No)
            {
                
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Userlogin
            txtUsername_login.Text = login.txtUsername.Text;

            //Date
            //txtDate.Text = DateTime.Now.ToString("dddd ,dd MMM yyyy,hh:mm:ss");




            this.frmload.Controls.Clear();
            frmDashboard frmdash1 = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmdash1.FormBorderStyle = FormBorderStyle.None;
            this.frmload.Controls.Add(frmdash1);
            frmdash1.Show();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dddd, dd MMM yyy HH:mm:ss");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            //pnlNav.Height = btnDashboard.Height;
            //pnlNav.Top = btnDashboard.Top;
            //pnlNav.Left = btnDashboard.Left;
            //btnDashboard.BackColor = Color.FromArgb(62, 87, 112);

            labelDashboard.Text = "Dashboard";
            this.frmload.Controls.Clear();
            frmDashboard frmdash1 = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmdash1.FormBorderStyle = FormBorderStyle.None;
            this.frmload.Controls.Add(frmdash1);
            frmdash1.Show();


        }

        
        private void btnMenbership_Click(object sender, EventArgs e)
        {

            //pnlNav.Height = btnMembership.Height;
            //pnlNav.Top = btnMembership.Top;
            //btnMembership.BackColor = Color.FromArgb(52, 73, 94);


            
            labelDashboard.Text = "Membership";

            this.frmload.Controls.Clear();
            frmMembership frmMembership = new frmMembership() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMembership.FormBorderStyle = FormBorderStyle.None;
            this.frmload.Controls.Add(frmMembership);
            frmMembership.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            //btnDashboard.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void btnMembership_Leave(object sender, EventArgs e)
        {
            //btnMembership.BackColor = Color.FromArgb(21, 48, 74);
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            labelDashboard.Text = "Employee";

            this.frmload.Controls.Clear();
            frmEmployee frmEmployee = new frmEmployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEmployee.FormBorderStyle = FormBorderStyle.None;
            this.frmload.Controls.Add(frmEmployee);
            frmEmployee.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logout Successfully\nThank you", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login_Form backtologin = new Login_Form();
            backtologin.Show();

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            //Title
            labelDashboard.Text = "Room";

            //Formload

            this.frmload.Controls.Clear();
            frmRoom frmRoom = new frmRoom() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmRoom.FormBorderStyle = FormBorderStyle.None;
            this.frmload.Controls.Add(frmRoom);
            frmRoom.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            //Title
            labelDashboard.Text = "Course";

            //Formload

            this.frmload.Controls.Clear();
            frmCourse frmCourse = new frmCourse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCourse.FormBorderStyle = FormBorderStyle.None;
            this.frmload.Controls.Add(frmCourse);
            frmCourse.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //Title
            labelDashboard.Text = "Course";

            //Formload

            this.frmload.Controls.Clear();
            frmCourse frmCourse = new frmCourse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCourse.FormBorderStyle = FormBorderStyle.None;
            this.frmload.Controls.Add(frmCourse);
            frmCourse.Show();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Title
            labelDashboard.Text = "Apply";

            //Formload

            this.frmload.Controls.Clear();
            frmApply frmApply = new frmApply() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmApply.FormBorderStyle = FormBorderStyle.None;
            this.frmload.Controls.Add(frmApply);
            frmApply.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Titile
            labelDashboard.Text = "Report";


            //Formload
            this.frmload.Controls.Clear();
            frmReport frmReport = new frmReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmReport.FormBorderStyle = FormBorderStyle.None;
            this.frmload.Controls.Add(frmReport);
            frmReport.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            //Title
            labelDashboard.Text = "Invoice";


            //Formload
            this.frmload.Controls.Clear();
            frmInvoice frmInvoice = new frmInvoice() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInvoice.FormBorderStyle = FormBorderStyle.None;
            this.frmload.Controls.Add(frmInvoice);
            frmInvoice.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
                    
                if (Opacity == 1)
                {
                    timer2.Stop();
                }
                Opacity += .2;
            
        }

        private void pnlNav_Click(object sender, EventArgs e)
        {

        }
    }
}
