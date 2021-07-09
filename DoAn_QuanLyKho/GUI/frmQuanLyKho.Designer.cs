
namespace GUI
{
    partial class frmQuanLyKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKho));
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.grvNhanVien = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picNhanVien = new Custom_Control.CircularPictureBox();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSuaNCC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoaNCC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThemNCC = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanVien)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.grvNhanVien;
            // 
            // grvNhanVien
            // 
            this.grvNhanVien.AllowUserToAddRows = false;
            this.grvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.grvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvNhanVien.ColumnHeadersHeight = 50;
            this.grvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvNhanVien.DoubleBuffered = true;
            this.grvNhanVien.EnableHeadersVisualStyles = false;
            this.grvNhanVien.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.grvNhanVien.HeaderForeColor = System.Drawing.Color.White;
            this.grvNhanVien.Location = new System.Drawing.Point(3, 2);
            this.grvNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvNhanVien.Name = "grvNhanVien";
            this.grvNhanVien.ReadOnly = true;
            this.grvNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvNhanVien.RowHeadersVisible = false;
            this.grvNhanVien.RowHeadersWidth = 51;
            this.grvNhanVien.RowTemplate.DividerHeight = 1;
            this.grvNhanVien.RowTemplate.Height = 30;
            this.grvNhanVien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvNhanVien.Size = new System.Drawing.Size(468, 684);
            this.grvNhanVien.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Kho";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Địa chỉ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tình trạng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng nhân viên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(200, 149);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(156, 20);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Thành phố Hồ Chí Minh";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(200, 103);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Đang hoạt động";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(200, 58);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(8, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(143, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(147, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "THÔNG TIN KHO";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 40;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(this.pictureBox4);
            this.bunifuCards2.Controls.Add(this.labelControl5);
            this.bunifuCards2.Controls.Add(this.bunifuThinButton21);
            this.bunifuCards2.Controls.Add(this.pictureBox3);
            this.bunifuCards2.Controls.Add(this.labelControl4);
            this.bunifuCards2.Controls.Add(this.pictureBox2);
            this.bunifuCards2.Controls.Add(this.labelControl3);
            this.bunifuCards2.Controls.Add(this.pictureBox1);
            this.bunifuCards2.Controls.Add(this.labelControl2);
            this.bunifuCards2.Controls.Add(this.labelControl1);
            this.bunifuCards2.Controls.Add(this.picNhanVien);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(3, 2);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(876, 680);
            this.bunifuCards2.TabIndex = 12;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(446, 48);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(502, 58);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(16, 19);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "20";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 35;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Xem địa chỉ trên bản đồ";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(143, 190);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(274, 48);
            this.bunifuThinButton21.TabIndex = 9;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(143, 139);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(143, 93);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // picNhanVien
            // 
            this.picNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("picNhanVien.Image")));
            this.picNhanVien.Location = new System.Drawing.Point(21, 20);
            this.picNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(86, 81);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanVien.TabIndex = 1;
            this.picNhanVien.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "Nhập tại đây để tìm kiếm";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(21, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(474, 37);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 70;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grvNhanVien, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 688);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bunifuCards2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(498, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(882, 684);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(501, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 37);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 11;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.ActiveBorderThickness = 1;
            this.btnSuaNCC.ActiveCornerRadius = 35;
            this.btnSuaNCC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.ActiveForecolor = System.Drawing.Color.White;
            this.btnSuaNCC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(182)))), ((int)(((byte)(194)))));
            this.btnSuaNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaNCC.BackgroundImage")));
            this.btnSuaNCC.ButtonText = "Sửa";
            this.btnSuaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNCC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSuaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.IdleBorderThickness = 1;
            this.btnSuaNCC.IdleCornerRadius = 20;
            this.btnSuaNCC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.IdleForecolor = System.Drawing.Color.White;
            this.btnSuaNCC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.Location = new System.Drawing.Point(1285, 11);
            this.btnSuaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(95, 48);
            this.btnSuaNCC.TabIndex = 15;
            this.btnSuaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.ActiveBorderThickness = 1;
            this.btnXoaNCC.ActiveCornerRadius = 35;
            this.btnXoaNCC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoaNCC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(182)))), ((int)(((byte)(194)))));
            this.btnXoaNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaNCC.BackgroundImage")));
            this.btnXoaNCC.ButtonText = "Xóa";
            this.btnXoaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNCC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnXoaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.IdleBorderThickness = 1;
            this.btnXoaNCC.IdleCornerRadius = 20;
            this.btnXoaNCC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.IdleForecolor = System.Drawing.Color.White;
            this.btnXoaNCC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.Location = new System.Drawing.Point(1189, 11);
            this.btnXoaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(95, 48);
            this.btnXoaNCC.TabIndex = 14;
            this.btnXoaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.ActiveBorderThickness = 1;
            this.btnThemNCC.ActiveCornerRadius = 35;
            this.btnThemNCC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.ActiveForecolor = System.Drawing.Color.White;
            this.btnThemNCC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(182)))), ((int)(((byte)(194)))));
            this.btnThemNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemNCC.BackgroundImage")));
            this.btnThemNCC.ButtonText = "Thêm";
            this.btnThemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNCC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThemNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.IdleBorderThickness = 1;
            this.btnThemNCC.IdleCornerRadius = 20;
            this.btnThemNCC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.IdleForecolor = System.Drawing.Color.White;
            this.btnThemNCC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.Location = new System.Drawing.Point(1093, 11);
            this.btnThemNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(95, 48);
            this.btnThemNCC.TabIndex = 13;
            this.btnThemNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuanLyKho
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(182)))), ((int)(((byte)(194)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 788);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSuaNCC);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyKho";
            this.Text = "frmQuanLyKho";
            this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanVien)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSuaNCC;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoaNCC;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThemNCC;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Custom_Control.CircularPictureBox picNhanVien;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}