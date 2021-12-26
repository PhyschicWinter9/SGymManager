
namespace SGymManagerv2
{
    partial class msgDelete
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgDelete));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnOk = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MsgIcon = new System.Windows.Forms.PictureBox();
            this.DragControlPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.MsgIcon)).BeginInit();
            this.DragControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 100;
            this.label1.Text = "Delete Successfully";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 102;
            this.label3.Text = "Alert";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.DragControlPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnOk
            // 
            this.btnOk.AllowAnimations = true;
            this.btnOk.AllowMouseEffects = true;
            this.btnOk.AllowToggling = false;
            this.btnOk.AnimationSpeed = 200;
            this.btnOk.AutoGenerateColors = false;
            this.btnOk.AutoRoundBorders = false;
            this.btnOk.AutoSizeLeftIcon = true;
            this.btnOk.AutoSizeRightIcon = true;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.ButtonText = "OK";
            this.btnOk.ButtonTextMarginLeft = 0;
            this.btnOk.ColorContrastOnClick = 45;
            this.btnOk.ColorContrastOnHover = 45;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnOk.CustomizableEdges = borderEdges5;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOk.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOk.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOk.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOk.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOk.IconMarginLeft = 11;
            this.btnOk.IconPadding = 10;
            this.btnOk.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOk.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOk.IconSize = 25;
            this.btnOk.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnOk.IdleBorderRadius = 5;
            this.btnOk.IdleBorderThickness = 1;
            this.btnOk.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnOk.IdleIconLeftImage = null;
            this.btnOk.IdleIconRightImage = null;
            this.btnOk.IndicateFocus = false;
            this.btnOk.Location = new System.Drawing.Point(257, 129);
            this.btnOk.Name = "btnOk";
            this.btnOk.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOk.OnDisabledState.BorderRadius = 5;
            this.btnOk.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.OnDisabledState.BorderThickness = 1;
            this.btnOk.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOk.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOk.OnDisabledState.IconLeftImage = null;
            this.btnOk.OnDisabledState.IconRightImage = null;
            this.btnOk.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnOk.onHoverState.BorderRadius = 5;
            this.btnOk.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.onHoverState.BorderThickness = 1;
            this.btnOk.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnOk.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOk.onHoverState.IconLeftImage = null;
            this.btnOk.onHoverState.IconRightImage = null;
            this.btnOk.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnOk.OnIdleState.BorderRadius = 5;
            this.btnOk.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.OnIdleState.BorderThickness = 1;
            this.btnOk.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnOk.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOk.OnIdleState.IconLeftImage = null;
            this.btnOk.OnIdleState.IconRightImage = null;
            this.btnOk.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnOk.OnPressedState.BorderRadius = 5;
            this.btnOk.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.OnPressedState.BorderThickness = 1;
            this.btnOk.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnOk.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOk.OnPressedState.IconLeftImage = null;
            this.btnOk.OnPressedState.IconRightImage = null;
            this.btnOk.Size = new System.Drawing.Size(101, 39);
            this.btnOk.TabIndex = 101;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOk.TextMarginLeft = 0;
            this.btnOk.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOk.UseDefaultRadiusAndThickness = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // MsgIcon
            // 
            this.MsgIcon.Image = global::SGymManagerv2.Properties.Resources.icons8_delete_database_96;
            this.MsgIcon.Location = new System.Drawing.Point(37, 53);
            this.MsgIcon.Name = "MsgIcon";
            this.MsgIcon.Size = new System.Drawing.Size(69, 68);
            this.MsgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MsgIcon.TabIndex = 99;
            this.MsgIcon.TabStop = false;
            // 
            // DragControlPanel
            // 
            this.DragControlPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.DragControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragControlPanel.BackgroundImage")));
            this.DragControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DragControlPanel.BorderColor = System.Drawing.Color.Transparent;
            this.DragControlPanel.BorderRadius = 3;
            this.DragControlPanel.BorderThickness = 1;
            this.DragControlPanel.Controls.Add(this.label2);
            this.DragControlPanel.Controls.Add(this.siticoneControlBox1);
            this.DragControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragControlPanel.Location = new System.Drawing.Point(0, 0);
            this.DragControlPanel.Name = "DragControlPanel";
            this.DragControlPanel.ShowBorders = true;
            this.DragControlPanel.Size = new System.Drawing.Size(370, 34);
            this.DragControlPanel.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 93;
            this.label2.Text = "Alert";
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(315, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(55, 35);
            this.siticoneControlBox1.TabIndex = 1;
            // 
            // msgDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(370, 180);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MsgIcon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DragControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "msgDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "msgDelete";
            ((System.ComponentModel.ISupportInitialize)(this.MsgIcon)).EndInit();
            this.DragControlPanel.ResumeLayout(false);
            this.DragControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MsgIcon;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuPanel DragControlPanel;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}