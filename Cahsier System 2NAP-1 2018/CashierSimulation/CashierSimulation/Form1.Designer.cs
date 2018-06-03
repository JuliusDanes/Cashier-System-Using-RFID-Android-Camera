namespace CashierSimulation
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            AnimatorNS.Animation animation3 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.btnDelEmp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateEmp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddEmp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.icon = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.btnCloseForm = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEmp = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucAddEmp1 = new CashierSimulation.ucAddUpdateDelEmp();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LogoAnimator = new AnimatorNS.Animator(this.components);
            this.PanelAnimatorShow = new AnimatorNS.Animator(this.components);
            this.PanelAnimatorHide = new AnimatorNS.Animator(this.components);
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMenu.Controls.Add(this.btnDelEmp);
            this.sideMenu.Controls.Add(this.btnUpdateEmp);
            this.sideMenu.Controls.Add(this.btnAddEmp);
            this.sideMenu.Controls.Add(this.btnMenu);
            this.sideMenu.Controls.Add(this.icon);
            this.LogoAnimator.SetDecoration(this.sideMenu, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.sideMenu, AnimatorNS.DecorationType.None);
            this.PanelAnimatorHide.SetDecoration(this.sideMenu, AnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 40);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(280, 460);
            this.sideMenu.TabIndex = 0;
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDelEmp.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnDelEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDelEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelEmp.BorderRadius = 0;
            this.btnDelEmp.ButtonText = "          Remove Employee";
            this.btnDelEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatorHide.SetDecoration(this.btnDelEmp, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.btnDelEmp, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnDelEmp, AnimatorNS.DecorationType.None);
            this.btnDelEmp.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelEmp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelEmp.Iconimage = global::CashierSimulation.Properties.Resources.gitlogo5;
            this.btnDelEmp.Iconimage_right = null;
            this.btnDelEmp.Iconimage_right_Selected = null;
            this.btnDelEmp.Iconimage_Selected = null;
            this.btnDelEmp.IconMarginLeft = 20;
            this.btnDelEmp.IconMarginRight = 0;
            this.btnDelEmp.IconRightVisible = true;
            this.btnDelEmp.IconRightZoom = 0D;
            this.btnDelEmp.IconVisible = true;
            this.btnDelEmp.IconZoom = 90D;
            this.btnDelEmp.IsTab = true;
            this.btnDelEmp.Location = new System.Drawing.Point(0, 358);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDelEmp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDelEmp.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDelEmp.selected = false;
            this.btnDelEmp.Size = new System.Drawing.Size(280, 80);
            this.btnDelEmp.TabIndex = 4;
            this.btnDelEmp.Text = "          Remove Employee";
            this.btnDelEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelEmp.Textcolor = System.Drawing.Color.Silver;
            this.btnDelEmp.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUpdateEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUpdateEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateEmp.BorderRadius = 0;
            this.btnUpdateEmp.ButtonText = "          Update Employee";
            this.btnUpdateEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatorHide.SetDecoration(this.btnUpdateEmp, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.btnUpdateEmp, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnUpdateEmp, AnimatorNS.DecorationType.None);
            this.btnUpdateEmp.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateEmp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateEmp.Iconimage = global::CashierSimulation.Properties.Resources.redux_logo2;
            this.btnUpdateEmp.Iconimage_right = null;
            this.btnUpdateEmp.Iconimage_right_Selected = null;
            this.btnUpdateEmp.Iconimage_Selected = null;
            this.btnUpdateEmp.IconMarginLeft = 20;
            this.btnUpdateEmp.IconMarginRight = 0;
            this.btnUpdateEmp.IconRightVisible = true;
            this.btnUpdateEmp.IconRightZoom = 0D;
            this.btnUpdateEmp.IconVisible = true;
            this.btnUpdateEmp.IconZoom = 90D;
            this.btnUpdateEmp.IsTab = true;
            this.btnUpdateEmp.Location = new System.Drawing.Point(0, 252);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUpdateEmp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUpdateEmp.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUpdateEmp.selected = false;
            this.btnUpdateEmp.Size = new System.Drawing.Size(280, 80);
            this.btnUpdateEmp.TabIndex = 3;
            this.btnUpdateEmp.Text = "          Update Employee";
            this.btnUpdateEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmp.Textcolor = System.Drawing.Color.Silver;
            this.btnUpdateEmp.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddEmp.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEmp.BorderRadius = 0;
            this.btnAddEmp.ButtonText = "          Add Employee";
            this.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatorHide.SetDecoration(this.btnAddEmp, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.btnAddEmp, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnAddEmp, AnimatorNS.DecorationType.None);
            this.btnAddEmp.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddEmp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddEmp.Iconimage = global::CashierSimulation.Properties.Resources.gitlogo23;
            this.btnAddEmp.Iconimage_right = null;
            this.btnAddEmp.Iconimage_right_Selected = null;
            this.btnAddEmp.Iconimage_Selected = null;
            this.btnAddEmp.IconMarginLeft = 20;
            this.btnAddEmp.IconMarginRight = 0;
            this.btnAddEmp.IconRightVisible = true;
            this.btnAddEmp.IconRightZoom = 0D;
            this.btnAddEmp.IconVisible = true;
            this.btnAddEmp.IconZoom = 90D;
            this.btnAddEmp.IsTab = true;
            this.btnAddEmp.Location = new System.Drawing.Point(0, 146);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddEmp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddEmp.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddEmp.selected = true;
            this.btnAddEmp.Size = new System.Drawing.Size(280, 80);
            this.btnAddEmp.TabIndex = 2;
            this.btnAddEmp.Text = "          Add Employee";
            this.btnAddEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmp.Textcolor = System.Drawing.Color.Silver;
            this.btnAddEmp.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LogoAnimator.SetDecoration(this.btnMenu, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.btnMenu, AnimatorNS.DecorationType.None);
            this.PanelAnimatorHide.SetDecoration(this.btnMenu, AnimatorNS.DecorationType.None);
            this.btnMenu.Image = global::CashierSimulation.Properties.Resources._41_5121;
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(242, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // icon
            // 
            this.PanelAnimatorHide.SetDecoration(this.icon, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.icon, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.icon, AnimatorNS.DecorationType.None);
            this.icon.Image = global::CashierSimulation.Properties.Resources.ID_cards_cafeteria;
            this.icon.Location = new System.Drawing.Point(3, 35);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(246, 80);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.btnCloseForm);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.LogoAnimator.SetDecoration(this.header, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.header, AnimatorNS.DecorationType.None);
            this.PanelAnimatorHide.SetDecoration(this.header, AnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1000, 40);
            this.header.TabIndex = 1;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.LogoAnimator.SetDecoration(this.btnCloseForm, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.btnCloseForm, AnimatorNS.DecorationType.None);
            this.PanelAnimatorHide.SetDecoration(this.btnCloseForm, AnimatorNS.DecorationType.None);
            this.btnCloseForm.Image = global::CashierSimulation.Properties.Resources.symbol_cancel_cross_red_512;
            this.btnCloseForm.ImageActive = null;
            this.btnCloseForm.Location = new System.Drawing.Point(958, 3);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(30, 30);
            this.btnCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.TabStop = false;
            this.btnCloseForm.Zoom = 20;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pictureBox2
            // 
            this.PanelAnimatorHide.SetDecoration(this.pictureBox2, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.pictureBox2, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.pictureBox2, AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::CashierSimulation.Properties.Resources.icon_google_shopping_certified_uneomedia_1080_1080_1024x1024;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.PanelAnimatorHide.SetDecoration(this.bunifuCustomLabel1, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.bunifuCustomLabel1, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel1, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(299, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Master Employee - Cashier Simulation";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvEmp);
            this.panel2.Controls.Add(this.ucAddEmp1);
            this.panel2.Controls.Add(this.panel1);
            this.LogoAnimator.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.PanelAnimatorHide.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(280, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 460);
            this.panel2.TabIndex = 2;
            // 
            // dgvEmp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvEmp.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EID,
            this.NameEmp,
            this.Gender,
            this.POB,
            this.DOB,
            this.Position,
            this.Address,
            this.PhoneNum,
            this.Username,
            this.Password});
            this.PanelAnimatorHide.SetDecoration(this.dgvEmp, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.dgvEmp, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.dgvEmp, AnimatorNS.DecorationType.None);
            this.dgvEmp.DoubleBuffered = true;
            this.dgvEmp.EnableHeadersVisualStyles = false;
            this.dgvEmp.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvEmp.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvEmp.Location = new System.Drawing.Point(386, 46);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmp.Size = new System.Drawing.Size(322, 164);
            this.dgvEmp.TabIndex = 2;
            this.dgvEmp.Visible = false;
            this.dgvEmp.VisibleChanged += new System.EventHandler(this.bunifuCustomDataGrid1_VisibleChanged);
            // 
            // EID
            // 
            this.EID.HeaderText = "Employee ID";
            this.EID.Name = "EID";
            // 
            // NameEmp
            // 
            this.NameEmp.HeaderText = "Name";
            this.NameEmp.Name = "NameEmp";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // POB
            // 
            this.POB.HeaderText = "Place of Birth";
            this.POB.Name = "POB";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Date of Birth";
            this.DOB.Name = "DOB";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "Phone Number";
            this.PhoneNum.Name = "PhoneNum";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // ucAddEmp1
            // 
            this.ucAddEmp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimatorHide.SetDecoration(this.ucAddEmp1, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.ucAddEmp1, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ucAddEmp1, AnimatorNS.DecorationType.None);
            this.ucAddEmp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddEmp1.Location = new System.Drawing.Point(0, 0);
            this.ucAddEmp1.Name = "ucAddEmp1";
            this.ucAddEmp1.Size = new System.Drawing.Size(720, 460);
            this.ucAddEmp1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.LogoAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.PanelAnimatorHide.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(92, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 224);
            this.panel1.TabIndex = 0;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Show";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.bunifuThinButton22, AnimatorNS.DecorationType.None);
            this.PanelAnimatorHide.SetDecoration(this.bunifuThinButton22, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.bunifuThinButton22, AnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 40;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(285, 107);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(160, 50);
            this.bunifuThinButton22.TabIndex = 6;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Sign Up";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.bunifuThinButton21, AnimatorNS.DecorationType.None);
            this.PanelAnimatorHide.SetDecoration(this.bunifuThinButton21, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.bunifuThinButton21, AnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 40;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(119, 107);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(160, 50);
            this.bunifuThinButton21.TabIndex = 5;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.PanelAnimatorHide.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.PanelAnimatorShow.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(158, 62);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(247, 32);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Form to Add Employee";
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = AnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation3;
            // 
            // PanelAnimatorShow
            // 
            this.PanelAnimatorShow.AnimationType = AnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimatorShow.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimatorShow.DefaultAnimation = animation2;
            // 
            // PanelAnimatorHide
            // 
            this.PanelAnimatorHide.AnimationType = AnimatorNS.AnimationType.Particles;
            this.PanelAnimatorHide.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimatorHide.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.header);
            this.PanelAnimatorShow.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.PanelAnimatorHide.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox icon;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddEmp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton btnCloseForm;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelEmp;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateEmp;
        private System.Windows.Forms.Panel panel2;
        private AnimatorNS.Animator PanelAnimatorShow;
        private AnimatorNS.Animator LogoAnimator;
        private AnimatorNS.Animator PanelAnimatorHide;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        public ucAddUpdateDelEmp ucAddEmp1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn POB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}

