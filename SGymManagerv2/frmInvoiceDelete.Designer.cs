
namespace SGymManagerv2
{
    partial class frmInvoiceDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceDelete));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.DragControlPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.btntoClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.cbbInvoicelist = new Bunifu.UI.WinForms.BunifuDropdown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnNo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.DragControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select Invoice ID";
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
            this.DragControlPanel.Controls.Add(this.txtDate);
            this.DragControlPanel.Controls.Add(this.btntoClose);
            this.DragControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragControlPanel.Location = new System.Drawing.Point(0, 0);
            this.DragControlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DragControlPanel.Name = "DragControlPanel";
            this.DragControlPanel.ShowBorders = true;
            this.DragControlPanel.Size = new System.Drawing.Size(503, 42);
            this.DragControlPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 92;
            this.label2.Text = "Are you sure ?";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(1025, 58);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(214, 28);
            this.txtDate.TabIndex = 5;
            this.txtDate.Text = "Fri, 16 May 2015 05:50:06";
            // 
            // btntoClose
            // 
            this.btntoClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntoClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btntoClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btntoClose.HoveredState.FillColor = System.Drawing.Color.Red;
            this.btntoClose.HoveredState.Parent = this.btntoClose;
            this.btntoClose.IconColor = System.Drawing.Color.White;
            this.btntoClose.Location = new System.Drawing.Point(446, 2);
            this.btntoClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntoClose.Name = "btntoClose";
            this.btntoClose.ShadowDecoration.Parent = this.btntoClose;
            this.btntoClose.Size = new System.Drawing.Size(53, 38);
            this.btntoClose.TabIndex = 2;
            // 
            // cbbInvoicelist
            // 
            this.cbbInvoicelist.BackColor = System.Drawing.Color.Transparent;
            this.cbbInvoicelist.BackgroundColor = System.Drawing.Color.Transparent;
            this.cbbInvoicelist.BorderColor = System.Drawing.Color.Silver;
            this.cbbInvoicelist.BorderRadius = 5;
            this.cbbInvoicelist.Color = System.Drawing.Color.Silver;
            this.cbbInvoicelist.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbInvoicelist.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbInvoicelist.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbInvoicelist.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbInvoicelist.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbInvoicelist.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbInvoicelist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbInvoicelist.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbInvoicelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbInvoicelist.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbInvoicelist.FillDropDown = true;
            this.cbbInvoicelist.FillIndicator = false;
            this.cbbInvoicelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbInvoicelist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbInvoicelist.ForeColor = System.Drawing.Color.White;
            this.cbbInvoicelist.FormattingEnabled = true;
            this.cbbInvoicelist.Icon = null;
            this.cbbInvoicelist.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbInvoicelist.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbInvoicelist.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbInvoicelist.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbbInvoicelist.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbbInvoicelist.ItemForeColor = System.Drawing.Color.White;
            this.cbbInvoicelist.ItemHeight = 24;
            this.cbbInvoicelist.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.cbbInvoicelist.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbInvoicelist.ItemTopMargin = 3;
            this.cbbInvoicelist.Location = new System.Drawing.Point(133, 128);
            this.cbbInvoicelist.Name = "cbbInvoicelist";
            this.cbbInvoicelist.Size = new System.Drawing.Size(228, 30);
            this.cbbInvoicelist.TabIndex = 72;
            this.cbbInvoicelist.Text = null;
            this.cbbInvoicelist.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbInvoicelist.TextLeftMargin = 5;
            this.cbbInvoicelist.SelectedIndexChanged += new System.EventHandler(this.cbbInvoicelist_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDelete
            // 
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowMouseEffects = true;
            this.btnDelete.AllowToggling = false;
            this.btnDelete.AnimationSpeed = 200;
            this.btnDelete.AutoGenerateColors = false;
            this.btnDelete.AutoRoundBorders = false;
            this.btnDelete.AutoSizeLeftIcon = true;
            this.btnDelete.AutoSizeRightIcon = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.ButtonTextMarginLeft = 0;
            this.btnDelete.ColorContrastOnClick = 45;
            this.btnDelete.ColorContrastOnHover = 45;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDelete.CustomizableEdges = borderEdges1;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDelete.IconMarginLeft = 11;
            this.btnDelete.IconPadding = 10;
            this.btnDelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDelete.IconSize = 25;
            this.btnDelete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDelete.IdleBorderRadius = 5;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDelete.IdleIconLeftImage = null;
            this.btnDelete.IdleIconRightImage = null;
            this.btnDelete.IndicateFocus = false;
            this.btnDelete.Location = new System.Drawing.Point(78, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.OnDisabledState.BorderRadius = 5;
            this.btnDelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnDisabledState.BorderThickness = 1;
            this.btnDelete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.OnDisabledState.IconLeftImage = null;
            this.btnDelete.OnDisabledState.IconRightImage = null;
            this.btnDelete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDelete.onHoverState.BorderRadius = 5;
            this.btnDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.onHoverState.BorderThickness = 1;
            this.btnDelete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDelete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.onHoverState.IconLeftImage = null;
            this.btnDelete.onHoverState.IconRightImage = null;
            this.btnDelete.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDelete.OnIdleState.BorderRadius = 5;
            this.btnDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnIdleState.BorderThickness = 1;
            this.btnDelete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDelete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnIdleState.IconLeftImage = null;
            this.btnDelete.OnIdleState.IconRightImage = null;
            this.btnDelete.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDelete.OnPressedState.BorderRadius = 5;
            this.btnDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnPressedState.BorderThickness = 1;
            this.btnDelete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDelete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnPressedState.IconLeftImage = null;
            this.btnDelete.OnPressedState.IconRightImage = null;
            this.btnDelete.Size = new System.Drawing.Size(128, 39);
            this.btnDelete.TabIndex = 91;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.TextMarginLeft = 0;
            this.btnDelete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDelete.UseDefaultRadiusAndThickness = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.DragControlPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnNo
            // 
            this.btnNo.AllowAnimations = true;
            this.btnNo.AllowMouseEffects = true;
            this.btnNo.AllowToggling = false;
            this.btnNo.AnimationSpeed = 200;
            this.btnNo.AutoGenerateColors = false;
            this.btnNo.AutoRoundBorders = false;
            this.btnNo.AutoSizeLeftIcon = true;
            this.btnNo.AutoSizeRightIcon = true;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNo.BackgroundImage")));
            this.btnNo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.ButtonText = "Cancel";
            this.btnNo.ButtonTextMarginLeft = 0;
            this.btnNo.ColorContrastOnClick = 45;
            this.btnNo.ColorContrastOnHover = 45;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnNo.CustomizableEdges = borderEdges2;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNo.IconMarginLeft = 11;
            this.btnNo.IconPadding = 10;
            this.btnNo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNo.IconSize = 25;
            this.btnNo.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNo.IdleBorderRadius = 5;
            this.btnNo.IdleBorderThickness = 1;
            this.btnNo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNo.IdleIconLeftImage = null;
            this.btnNo.IdleIconRightImage = null;
            this.btnNo.IndicateFocus = false;
            this.btnNo.Location = new System.Drawing.Point(271, 195);
            this.btnNo.Name = "btnNo";
            this.btnNo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNo.OnDisabledState.BorderRadius = 5;
            this.btnNo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnDisabledState.BorderThickness = 1;
            this.btnNo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNo.OnDisabledState.IconLeftImage = null;
            this.btnNo.OnDisabledState.IconRightImage = null;
            this.btnNo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNo.onHoverState.BorderRadius = 5;
            this.btnNo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.onHoverState.BorderThickness = 1;
            this.btnNo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNo.onHoverState.IconLeftImage = null;
            this.btnNo.onHoverState.IconRightImage = null;
            this.btnNo.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNo.OnIdleState.BorderRadius = 5;
            this.btnNo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnIdleState.BorderThickness = 1;
            this.btnNo.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNo.OnIdleState.IconLeftImage = null;
            this.btnNo.OnIdleState.IconRightImage = null;
            this.btnNo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNo.OnPressedState.BorderRadius = 5;
            this.btnNo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnPressedState.BorderThickness = 1;
            this.btnNo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNo.OnPressedState.IconLeftImage = null;
            this.btnNo.OnPressedState.IconRightImage = null;
            this.btnNo.Size = new System.Drawing.Size(128, 39);
            this.btnNo.TabIndex = 92;
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNo.TextMarginLeft = 0;
            this.btnNo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNo.UseDefaultRadiusAndThickness = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmInvoiceDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(503, 270);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbbInvoicelist);
            this.Controls.Add(this.DragControlPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInvoiceDelete";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInvoiceDelete";
            this.Load += new System.EventHandler(this.frmInvoiceDelete_Load);
            this.DragControlPanel.ResumeLayout(false);
            this.DragControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel DragControlPanel;
        private System.Windows.Forms.Label txtDate;
        private Siticone.UI.WinForms.SiticoneControlBox btntoClose;
        private Bunifu.UI.WinForms.BunifuDropdown cbbInvoicelist;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelete;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNo;
        private System.Windows.Forms.Timer timer2;
    }
}