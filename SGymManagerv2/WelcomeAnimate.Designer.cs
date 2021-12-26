
namespace SGymManagerv2
{
    partial class WelcomeAnimate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.txtCon = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Fadein = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.ForeColor = System.Drawing.Color.White;
            this.txtWelcome.Location = new System.Drawing.Point(201, 141);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(199, 30);
            this.txtWelcome.TabIndex = 0;
            this.txtWelcome.Text = "Welcome to S Gym";
            // 
            // txtCon
            // 
            this.txtCon.AutoSize = true;
            this.txtCon.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCon.Location = new System.Drawing.Point(561, 303);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(67, 20);
            this.txtCon.TabIndex = 1;
            this.txtCon.Text = "Continue";
            this.txtCon.Click += new System.EventHandler(this.txtCon_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Fadein
            // 
            this.Fadein.Enabled = true;
            this.Fadein.Interval = 50;
            this.Fadein.Tick += new System.EventHandler(this.Fadein_Tick);
            // 
            // WelcomeAnimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(640, 332);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeAnimate";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeAnimate";
            this.Load += new System.EventHandler(this.WelcomeAnimate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Label txtCon;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer Fadein;
    }
}