using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SGymManagerv2
{
    public partial class WelcomeAnimate : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRect
           (
               int leftRect,
               int topRect,
               int rightRect,
               int bottomRect,
               int widthEllipse,
               int heightEllipse
               );

        public WelcomeAnimate()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRect(0, 0, Width, Height, 7, 7));
        }


        int counter = 0;
        int len = 0;
        string text;

        private void WelcomeAnimate_Load(object sender, EventArgs e)
        {
            txtCon.Hide();
            text = txtWelcome.Text;
            len = text.Length;
            txtWelcome.Text = "";
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtWelcome.Text = text.Substring(0, counter);
            ++counter;
            if(counter > len)
            {
                txtCon.Show();
                timer1.Stop();


            }
        }

        private void txtCon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login = new Login_Form();
            login.ShowDialog();
            //btnSignup.Enabled = false;
            
        }

        private void Fadein_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                Fadein.Stop();
            }
            Opacity += .3;
        }
    }
}
