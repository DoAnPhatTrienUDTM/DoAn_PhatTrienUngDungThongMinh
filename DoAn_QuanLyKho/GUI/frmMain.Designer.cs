
namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblChucVu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhanVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBaoCao_5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSanPham_4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKho_3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLienHe_2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTrangChu_1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picNhanVien = new Custom_Control.CircularPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnPD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(39, 123);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(160, 19);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Xin chào, Bill Gates!";
            this.lblTen.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(112, 159);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(53, 19);
            this.lblChucVu.TabIndex = 2;
            this.lblChucVu.Text = "Admin";
            this.lblChucVu.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.btnPD);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.bunifuFlatButton6);
            this.panel1.Controls.Add(this.btnBaoCao_5);
            this.panel1.Controls.Add(this.btnSanPham_4);
            this.panel1.Controls.Add(this.btnKho_3);
            this.panel1.Controls.Add(this.btnLienHe_2);
            this.panel1.Controls.Add(this.btnTrangChu_1);
            this.panel1.Controls.Add(this.indicator);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 968);
            this.panel1.TabIndex = 2;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Activecolor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhanVien.BorderRadius = 0;
            this.btnNhanVien.ButtonText = "    Nhân viên";
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.DisabledColor = System.Drawing.Color.Gray;
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNhanVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Iconimage")));
            this.btnNhanVien.Iconimage_right = null;
            this.btnNhanVien.Iconimage_right_Selected = null;
            this.btnNhanVien.Iconimage_Selected = null;
            this.btnNhanVien.IconMarginLeft = 0;
            this.btnNhanVien.IconMarginRight = 0;
            this.btnNhanVien.IconRightVisible = true;
            this.btnNhanVien.IconRightZoom = 0D;
            this.btnNhanVien.IconVisible = true;
            this.btnNhanVien.IconZoom = 60D;
            this.btnNhanVien.IsTab = false;
            this.btnNhanVien.Location = new System.Drawing.Point(13, 369);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNhanVien.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnNhanVien.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnNhanVien.selected = false;
            this.btnNhanVien.Size = new System.Drawing.Size(272, 59);
            this.btnNhanVien.TabIndex = 20;
            this.btnNhanVien.Text = "    Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Textcolor = System.Drawing.Color.White;
            this.btnNhanVien.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "    Đăng xuất";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 60D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 909);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(285, 59);
            this.bunifuFlatButton6.TabIndex = 19;
            this.bunifuFlatButton6.Text = "    Đăng xuất";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBaoCao_5
            // 
            this.btnBaoCao_5.Activecolor = System.Drawing.Color.Transparent;
            this.btnBaoCao_5.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoCao_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoCao_5.BorderRadius = 0;
            this.btnBaoCao_5.ButtonText = "    Báo cáo";
            this.btnBaoCao_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao_5.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaoCao_5.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaoCao_5.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBaoCao_5.Iconimage")));
            this.btnBaoCao_5.Iconimage_right = null;
            this.btnBaoCao_5.Iconimage_right_Selected = null;
            this.btnBaoCao_5.Iconimage_Selected = null;
            this.btnBaoCao_5.IconMarginLeft = 0;
            this.btnBaoCao_5.IconMarginRight = 0;
            this.btnBaoCao_5.IconRightVisible = true;
            this.btnBaoCao_5.IconRightZoom = 0D;
            this.btnBaoCao_5.IconVisible = true;
            this.btnBaoCao_5.IconZoom = 60D;
            this.btnBaoCao_5.IsTab = false;
            this.btnBaoCao_5.Location = new System.Drawing.Point(10, 842);
            this.btnBaoCao_5.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCao_5.Name = "btnBaoCao_5";
            this.btnBaoCao_5.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBaoCao_5.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnBaoCao_5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBaoCao_5.selected = false;
            this.btnBaoCao_5.Size = new System.Drawing.Size(268, 59);
            this.btnBaoCao_5.TabIndex = 18;
            this.btnBaoCao_5.Text = "    Báo cáo";
            this.btnBaoCao_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao_5.Textcolor = System.Drawing.Color.White;
            this.btnBaoCao_5.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao_5.Click += new System.EventHandler(this.btnBaoCao_5_Click);
            // 
            // btnSanPham_4
            // 
            this.btnSanPham_4.Activecolor = System.Drawing.Color.Transparent;
            this.btnSanPham_4.BackColor = System.Drawing.Color.Transparent;
            this.btnSanPham_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSanPham_4.BorderRadius = 0;
            this.btnSanPham_4.ButtonText = "   Sản phẩm";
            this.btnSanPham_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham_4.DisabledColor = System.Drawing.Color.Gray;
            this.btnSanPham_4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham_4.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSanPham_4.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSanPham_4.Iconimage")));
            this.btnSanPham_4.Iconimage_right = null;
            this.btnSanPham_4.Iconimage_right_Selected = null;
            this.btnSanPham_4.Iconimage_Selected = null;
            this.btnSanPham_4.IconMarginLeft = 0;
            this.btnSanPham_4.IconMarginRight = 0;
            this.btnSanPham_4.IconRightVisible = true;
            this.btnSanPham_4.IconRightZoom = 0D;
            this.btnSanPham_4.IconVisible = true;
            this.btnSanPham_4.IconZoom = 60D;
            this.btnSanPham_4.IsTab = false;
            this.btnSanPham_4.Location = new System.Drawing.Point(9, 775);
            this.btnSanPham_4.Margin = new System.Windows.Forms.Padding(4);
            this.btnSanPham_4.Name = "btnSanPham_4";
            this.btnSanPham_4.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSanPham_4.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSanPham_4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSanPham_4.selected = false;
            this.btnSanPham_4.Size = new System.Drawing.Size(269, 59);
            this.btnSanPham_4.TabIndex = 16;
            this.btnSanPham_4.Text = "   Sản phẩm";
            this.btnSanPham_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham_4.Textcolor = System.Drawing.Color.White;
            this.btnSanPham_4.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham_4.Click += new System.EventHandler(this.btnSanPham_4_Click);
            // 
            // btnKho_3
            // 
            this.btnKho_3.Activecolor = System.Drawing.Color.Transparent;
            this.btnKho_3.BackColor = System.Drawing.Color.Transparent;
            this.btnKho_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKho_3.BorderRadius = 0;
            this.btnKho_3.ButtonText = "    Kho";
            this.btnKho_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKho_3.DisabledColor = System.Drawing.Color.Gray;
            this.btnKho_3.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKho_3.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKho_3.Iconimage")));
            this.btnKho_3.Iconimage_right = null;
            this.btnKho_3.Iconimage_right_Selected = null;
            this.btnKho_3.Iconimage_Selected = null;
            this.btnKho_3.IconMarginLeft = 0;
            this.btnKho_3.IconMarginRight = 0;
            this.btnKho_3.IconRightVisible = true;
            this.btnKho_3.IconRightZoom = 0D;
            this.btnKho_3.IconVisible = true;
            this.btnKho_3.IconZoom = 60D;
            this.btnKho_3.IsTab = false;
            this.btnKho_3.Location = new System.Drawing.Point(13, 501);
            this.btnKho_3.Margin = new System.Windows.Forms.Padding(4);
            this.btnKho_3.Name = "btnKho_3";
            this.btnKho_3.Normalcolor = System.Drawing.Color.Transparent;
            this.btnKho_3.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnKho_3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnKho_3.selected = false;
            this.btnKho_3.Size = new System.Drawing.Size(270, 59);
            this.btnKho_3.TabIndex = 14;
            this.btnKho_3.Text = "    Kho";
            this.btnKho_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKho_3.Textcolor = System.Drawing.Color.White;
            this.btnKho_3.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho_3.Click += new System.EventHandler(this.btnKho_3_Click);
            // 
            // btnLienHe_2
            // 
            this.btnLienHe_2.Activecolor = System.Drawing.Color.Transparent;
            this.btnLienHe_2.BackColor = System.Drawing.Color.Transparent;
            this.btnLienHe_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLienHe_2.BorderRadius = 0;
            this.btnLienHe_2.ButtonText = "    Nhà cung cấp";
            this.btnLienHe_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLienHe_2.DisabledColor = System.Drawing.Color.Gray;
            this.btnLienHe_2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLienHe_2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLienHe_2.Iconimage")));
            this.btnLienHe_2.Iconimage_right = null;
            this.btnLienHe_2.Iconimage_right_Selected = null;
            this.btnLienHe_2.Iconimage_Selected = null;
            this.btnLienHe_2.IconMarginLeft = 0;
            this.btnLienHe_2.IconMarginRight = 0;
            this.btnLienHe_2.IconRightVisible = true;
            this.btnLienHe_2.IconRightZoom = 0D;
            this.btnLienHe_2.IconVisible = true;
            this.btnLienHe_2.IconZoom = 60D;
            this.btnLienHe_2.IsTab = false;
            this.btnLienHe_2.Location = new System.Drawing.Point(13, 436);
            this.btnLienHe_2.Margin = new System.Windows.Forms.Padding(4);
            this.btnLienHe_2.Name = "btnLienHe_2";
            this.btnLienHe_2.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLienHe_2.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnLienHe_2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLienHe_2.selected = false;
            this.btnLienHe_2.Size = new System.Drawing.Size(272, 59);
            this.btnLienHe_2.TabIndex = 12;
            this.btnLienHe_2.Text = "    Nhà cung cấp";
            this.btnLienHe_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLienHe_2.Textcolor = System.Drawing.Color.White;
            this.btnLienHe_2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLienHe_2.Click += new System.EventHandler(this.btnLienHe_2_Click);
            // 
            // btnTrangChu_1
            // 
            this.btnTrangChu_1.Activecolor = System.Drawing.Color.Transparent;
            this.btnTrangChu_1.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrangChu_1.BorderRadius = 0;
            this.btnTrangChu_1.ButtonText = "    Trang chủ";
            this.btnTrangChu_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu_1.DisabledColor = System.Drawing.Color.Gray;
            this.btnTrangChu_1.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu_1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTrangChu_1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTrangChu_1.Iconimage")));
            this.btnTrangChu_1.Iconimage_right = null;
            this.btnTrangChu_1.Iconimage_right_Selected = null;
            this.btnTrangChu_1.Iconimage_Selected = null;
            this.btnTrangChu_1.IconMarginLeft = 0;
            this.btnTrangChu_1.IconMarginRight = 0;
            this.btnTrangChu_1.IconRightVisible = true;
            this.btnTrangChu_1.IconRightZoom = 0D;
            this.btnTrangChu_1.IconVisible = true;
            this.btnTrangChu_1.IconZoom = 60D;
            this.btnTrangChu_1.IsTab = false;
            this.btnTrangChu_1.Location = new System.Drawing.Point(13, 302);
            this.btnTrangChu_1.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrangChu_1.Name = "btnTrangChu_1";
            this.btnTrangChu_1.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTrangChu_1.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnTrangChu_1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTrangChu_1.selected = false;
            this.btnTrangChu_1.Size = new System.Drawing.Size(272, 59);
            this.btnTrangChu_1.TabIndex = 10;
            this.btnTrangChu_1.Text = "    Trang chủ";
            this.btnTrangChu_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu_1.Textcolor = System.Drawing.Color.White;
            this.btnTrangChu_1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu_1.Click += new System.EventHandler(this.btnTrangChu_1_Click);
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.Orchid;
            this.indicator.Location = new System.Drawing.Point(0, 302);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(10, 59);
            this.indicator.TabIndex = 7;
            this.indicator.TabStop = false;
            this.indicator.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Controls.Add(this.picNhanVien);
            this.panel2.Controls.Add(this.lblTen);
            this.panel2.Controls.Add(this.lblChucVu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 238);
            this.panel2.TabIndex = 9;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Cập nhật ";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(43, 183);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(194, 41);
            this.bunifuThinButton21.TabIndex = 4;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // picNhanVien
            // 
            this.picNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("picNhanVien.Image")));
            this.picNhanVien.Location = new System.Drawing.Point(87, 6);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(100, 100);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanVien.TabIndex = 0;
            this.picNhanVien.TabStop = false;
            this.picNhanVien.Click += new System.EventHandler(this.circularPictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::GUI.Properties.Resources.wms_logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.Controls.Add(this.lblClose);
            this.headerPanel.Controls.Add(this.pictureBox4);
            this.headerPanel.Controls.Add(this.pictureBox3);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.lblHeader);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(285, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1613, 64);
            this.headerPanel.TabIndex = 4;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblClose.Location = new System.Drawing.Point(1576, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 30);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1495, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1445, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1395, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(33, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(85, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "DauBuoi";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(285, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1613, 968);
            this.mainPanel.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnPD
            // 
            this.btnPD.Activecolor = System.Drawing.Color.Transparent;
            this.btnPD.BackColor = System.Drawing.Color.Transparent;
            this.btnPD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPD.BorderRadius = 0;
            this.btnPD.ButtonText = "Phiếu Đặt";
            this.btnPD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPD.DisabledColor = System.Drawing.Color.Gray;
            this.btnPD.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPD.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPD.Iconimage")));
            this.btnPD.Iconimage_right = null;
            this.btnPD.Iconimage_right_Selected = null;
            this.btnPD.Iconimage_Selected = null;
            this.btnPD.IconMarginLeft = 0;
            this.btnPD.IconMarginRight = 0;
            this.btnPD.IconRightVisible = true;
            this.btnPD.IconRightZoom = 0D;
            this.btnPD.IconVisible = true;
            this.btnPD.IconZoom = 60D;
            this.btnPD.IsTab = false;
            this.btnPD.Location = new System.Drawing.Point(13, 568);
            this.btnPD.Margin = new System.Windows.Forms.Padding(4);
            this.btnPD.Name = "btnPD";
            this.btnPD.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPD.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPD.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPD.selected = false;
            this.btnPD.Size = new System.Drawing.Size(270, 59);
            this.btnPD.TabIndex = 21;
            this.btnPD.Text = "Phiếu Đặt";
            this.btnPD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPD.Textcolor = System.Drawing.Color.White;
            this.btnPD.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPD.Click += new System.EventHandler(this.btnPD_Click);
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(1898, 968);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình làm việc";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox indicator;
        private Bunifu.Framework.UI.BunifuCustomLabel lblChucVu;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTen;
        private Custom_Control.CircularPictureBox picNhanVien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnTrangChu_1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaoCao_5;
        private Bunifu.Framework.UI.BunifuFlatButton btnSanPham_4;
        private Bunifu.Framework.UI.BunifuFlatButton btnKho_3;
        private Bunifu.Framework.UI.BunifuFlatButton btnLienHe_2;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuFlatButton btnNhanVien;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnPD;
    }
}