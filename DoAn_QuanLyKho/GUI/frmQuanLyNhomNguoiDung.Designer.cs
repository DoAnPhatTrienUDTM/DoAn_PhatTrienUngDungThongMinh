
namespace GUI
{
    partial class frmQuanLyNhomNguoiDung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhomNguoiDung));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtTenNhom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grvNhomNguoiDung = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClose = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSuaNCC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThemNCC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoaNCC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhomNguoiDung = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnTaoMoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelLeft.Controls.Add(this.label9);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(367, 760);
            this.panelLeft.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 729);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Beta Version 1.0 2021";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ KHO HÀNG";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhom.Enabled = false;
            this.txtTenNhom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenNhom.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenNhom.HintText = "";
            this.txtTenNhom.isPassword = false;
            this.txtTenNhom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtTenNhom.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtTenNhom.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtTenNhom.LineThickness = 3;
            this.txtTenNhom.Location = new System.Drawing.Point(775, 207);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(339, 31);
            this.txtTenNhom.TabIndex = 54;
            this.txtTenNhom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(771, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "&Tên nhóm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(373, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 30);
            this.label2.TabIndex = 50;
            this.label2.Text = "Quản lý nhóm người dùng";
            // 
            // grvNhomNguoiDung
            // 
            this.grvNhomNguoiDung.AllowUserToAddRows = false;
            this.grvNhomNguoiDung.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grvNhomNguoiDung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvNhomNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvNhomNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvNhomNguoiDung.BackgroundColor = System.Drawing.Color.White;
            this.grvNhomNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvNhomNguoiDung.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grvNhomNguoiDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvNhomNguoiDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvNhomNguoiDung.ColumnHeadersHeight = 50;
            this.grvNhomNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvNhomNguoiDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvNhomNguoiDung.DoubleBuffered = true;
            this.grvNhomNguoiDung.EnableHeadersVisualStyles = false;
            this.grvNhomNguoiDung.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.grvNhomNguoiDung.HeaderForeColor = System.Drawing.Color.White;
            this.grvNhomNguoiDung.Location = new System.Drawing.Point(378, 258);
            this.grvNhomNguoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvNhomNguoiDung.Name = "grvNhomNguoiDung";
            this.grvNhomNguoiDung.ReadOnly = true;
            this.grvNhomNguoiDung.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvNhomNguoiDung.RowHeadersVisible = false;
            this.grvNhomNguoiDung.RowHeadersWidth = 51;
            this.grvNhomNguoiDung.RowTemplate.DividerHeight = 1;
            this.grvNhomNguoiDung.RowTemplate.Height = 30;
            this.grvNhomNguoiDung.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvNhomNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvNhomNguoiDung.Size = new System.Drawing.Size(824, 493);
            this.grvNhomNguoiDung.TabIndex = 49;
            this.grvNhomNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvNhomNguoiDung_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_NHOM";
            this.Column1.HeaderText = "ID nhóm người dùng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENNHOM";
            this.Column2.HeaderText = "Tên nhóm người dùng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblClose.Location = new System.Drawing.Point(1179, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 30);
            this.lblClose.TabIndex = 48;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.grvNhomNguoiDung;
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.ActiveBorderThickness = 1;
            this.btnSuaNCC.ActiveCornerRadius = 35;
            this.btnSuaNCC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.ActiveForecolor = System.Drawing.Color.White;
            this.btnSuaNCC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSuaNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaNCC.BackgroundImage")));
            this.btnSuaNCC.ButtonText = "Sửa";
            this.btnSuaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.IdleBorderThickness = 1;
            this.btnSuaNCC.IdleCornerRadius = 20;
            this.btnSuaNCC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.IdleForecolor = System.Drawing.Color.White;
            this.btnSuaNCC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.Location = new System.Drawing.Point(1101, 43);
            this.btnSuaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(95, 48);
            this.btnSuaNCC.TabIndex = 57;
            this.btnSuaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.ActiveBorderThickness = 1;
            this.btnThemNCC.ActiveCornerRadius = 35;
            this.btnThemNCC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.ActiveForecolor = System.Drawing.Color.White;
            this.btnThemNCC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThemNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemNCC.BackgroundImage")));
            this.btnThemNCC.ButtonText = "Thêm";
            this.btnThemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.IdleBorderThickness = 1;
            this.btnThemNCC.IdleCornerRadius = 20;
            this.btnThemNCC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.IdleForecolor = System.Drawing.Color.White;
            this.btnThemNCC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.Location = new System.Drawing.Point(905, 43);
            this.btnThemNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(95, 48);
            this.btnThemNCC.TabIndex = 55;
            this.btnThemNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.ActiveBorderThickness = 1;
            this.btnXoaNCC.ActiveCornerRadius = 35;
            this.btnXoaNCC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoaNCC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnXoaNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaNCC.BackgroundImage")));
            this.btnXoaNCC.ButtonText = "Xóa";
            this.btnXoaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.IdleBorderThickness = 1;
            this.btnXoaNCC.IdleCornerRadius = 20;
            this.btnXoaNCC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.IdleForecolor = System.Drawing.Color.White;
            this.btnXoaNCC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.Location = new System.Drawing.Point(1003, 43);
            this.btnXoaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(95, 48);
            this.btnXoaNCC.TabIndex = 56;
            this.btnXoaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.wms_logo;
            this.pictureBox1.Location = new System.Drawing.Point(70, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(374, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "&ID Nhóm:";
            // 
            // txtNhomNguoiDung
            // 
            this.txtNhomNguoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhomNguoiDung.Enabled = false;
            this.txtNhomNguoiDung.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNhomNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNhomNguoiDung.HintForeColor = System.Drawing.Color.Empty;
            this.txtNhomNguoiDung.HintText = "";
            this.txtNhomNguoiDung.isPassword = false;
            this.txtNhomNguoiDung.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtNhomNguoiDung.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtNhomNguoiDung.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtNhomNguoiDung.LineThickness = 3;
            this.txtNhomNguoiDung.Location = new System.Drawing.Point(378, 207);
            this.txtNhomNguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhomNguoiDung.Name = "txtNhomNguoiDung";
            this.txtNhomNguoiDung.Size = new System.Drawing.Size(339, 31);
            this.txtNhomNguoiDung.TabIndex = 52;
            this.txtNhomNguoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.ActiveBorderThickness = 1;
            this.btnTaoMoi.ActiveCornerRadius = 35;
            this.btnTaoMoi.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTaoMoi.ActiveForecolor = System.Drawing.Color.White;
            this.btnTaoMoi.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTaoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTaoMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaoMoi.BackgroundImage")));
            this.btnTaoMoi.ButtonText = "Thao tác";
            this.btnTaoMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoMoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTaoMoi.IdleBorderThickness = 1;
            this.btnTaoMoi.IdleCornerRadius = 20;
            this.btnTaoMoi.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTaoMoi.IdleForecolor = System.Drawing.Color.White;
            this.btnTaoMoi.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTaoMoi.Location = new System.Drawing.Point(807, 43);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(95, 48);
            this.btnTaoMoi.TabIndex = 58;
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // frmQuanLyNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 760);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnSuaNCC);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNhomNguoiDung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grvNhomNguoiDung);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNhomNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyNhomNguoiDung";
            this.Load += new System.EventHandler(this.frmQuanLyNhomNguoiDung_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSuaNCC;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThemNCC;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoaNCC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenNhom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grvNhomNguoiDung;
        private System.Windows.Forms.Label lblClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNhomNguoiDung;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTaoMoi;
    }
}