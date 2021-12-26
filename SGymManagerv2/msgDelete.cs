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
    public partial class msgDelete : Form
    {
        public msgDelete()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {

                timer1.Stop();

            }
            Opacity += .2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Opacity <= 0)
            {
                this.Close();
            }
            Opacity -= .2;
        }
    }
}
