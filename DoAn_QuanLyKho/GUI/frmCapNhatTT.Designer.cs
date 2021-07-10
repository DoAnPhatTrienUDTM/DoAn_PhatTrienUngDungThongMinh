
namespace GUI
{
    partial class frmCapNhatTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatTT));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoVaTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateNgaySinh = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblTen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblChucVu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTrangThai = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picNhanVien = new Custom_Control.CircularPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.panelLeft.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
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
            this.panelLeft.Size = new System.Drawing.Size(367, 606);
            this.panelLeft.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 564);
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
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblClose.Location = new System.Drawing.Point(1405, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 30);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1082, 445);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(339, 34);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Enabled = false;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtPass.HintText = "";
            this.txtPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPass.isPassword = true;
            this.txtPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPass.LineThickness = 3;
            this.txtPass.Location = new System.Drawing.Point(686, 199);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(339, 31);
            this.txtPass.TabIndex = 35;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(682, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "&Mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(686, 128);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(339, 31);
            this.txtUsername.TabIndex = 34;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.OnValueChanged += new System.EventHandler(this.txtUsername_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(682, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "&Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(389, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cập nhật thông tin tài khoản của bạn";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoVaTen.Enabled = false;
            this.txtHoVaTen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHoVaTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoVaTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtHoVaTen.HintText = "";
            this.txtHoVaTen.isPassword = false;
            this.txtHoVaTen.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtHoVaTen.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtHoVaTen.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtHoVaTen.LineThickness = 3;
            this.txtHoVaTen.Location = new System.Drawing.Point(686, 278);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(339, 31);
            this.txtHoVaTen.TabIndex = 38;
            this.txtHoVaTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(682, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "&Họ và tên:";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDT.Enabled = false;
            this.txtSoDT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDT.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoDT.HintText = "";
            this.txtSoDT.isPassword = false;
            this.txtSoDT.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoDT.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoDT.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoDT.LineThickness = 3;
            this.txtSoDT.Location = new System.Drawing.Point(686, 362);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(339, 31);
            this.txtSoDT.TabIndex = 40;
            this.txtSoDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(682, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "&Số điện thoại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label10.Location = new System.Drawing.Point(1078, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 46;
            this.label10.Text = "&Ngày sinh:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.dateNgaySinh.BorderRadius = 0;
            this.dateNgaySinh.Enabled = false;
            this.dateNgaySinh.ForeColor = System.Drawing.Color.White;
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNgaySinh.FormatCustom = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(1082, 308);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(339, 67);
            this.dateNgaySinh.TabIndex = 47;
            this.dateNgaySinh.Value = new System.DateTime(2021, 7, 6, 23, 35, 11, 359);
            this.dateNgaySinh.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(686, 445);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(339, 34);
            this.btnCapNhat.TabIndex = 48;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(1078, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 51;
            this.label8.Text = "&Giới tính:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiaChi.HintText = "";
            this.txtDiaChi.isPassword = false;
            this.txtDiaChi.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtDiaChi.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtDiaChi.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtDiaChi.LineThickness = 3;
            this.txtDiaChi.Location = new System.Drawing.Point(1082, 128);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(339, 31);
            this.txtDiaChi.TabIndex = 50;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(1078, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "&Địa chỉ:";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.bunifuCards1.BorderRadius = 25;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.lblTrangThai);
            this.bunifuCards1.Controls.Add(this.picNhanVien);
            this.bunifuCards1.Controls.Add(this.lblTen);
            this.bunifuCards1.Controls.Add(this.lblChucVu);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(374, 103);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(302, 483);
            this.bunifuCards1.TabIndex = 54;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(48, 142);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(160, 19);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Xin chào, Bill Gates!";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(123, 176);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(53, 19);
            this.lblChucVu.TabIndex = 5;
            this.lblChucVu.Text = "Admin";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.White;
            this.lblTrangThai.Location = new System.Drawing.Point(16, 219);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(265, 19);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng thái tài khoản: Đang hoạt động";
            // 
            // picNhanVien
            // 
            this.picNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("picNhanVien.Image")));
            this.picNhanVien.Location = new System.Drawing.Point(98, 25);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(100, 100);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanVien.TabIndex = 3;
            this.picNhanVien.TabStop = false;
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
            // rdoNu
            // 
            this.rdoNu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.Location = new System.Drawing.Point(1159, 209);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(44, 21);
            this.rdoNu.TabIndex = 36;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.Location = new System.Drawing.Point(1085, 209);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(54, 21);
            this.rdoNam.TabIndex = 35;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // frmCapNhatTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 606);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCapNhatTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatTT";
            this.Load += new System.EventHandler(this.frmCapNhatTT_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHoVaTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPass;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCapNhat;
        private Bunifu.Framework.UI.BunifuDatepicker dateNgaySinh;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoDT;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTrangThai;
        private Custom_Control.CircularPictureBox picNhanVien;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTen;
        private Bunifu.Framework.UI.BunifuCustomLabel lblChucVu;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
    }
}