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
    public partial class msgUpdate : Form
    {
        public msgUpdate()
        {
            InitializeComponent();
        }

        

        
        private void msgUpdate_Load(object sender, EventArgs e)
        {
            FadeIn.Start();
        }



        private void FadeOut_Tick(object sender, EventArgs e)
        {
            if(Opacity <= 0)
            {
                this.Close();
                //FadeOut.Stop();
                //FadeOut.Dispose();
                
            }
            Opacity -= .2;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FadeOut.Start();
            
        }



        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                FadeIn.Stop();
            }
            Opacity += .2;
        }
    }
}
