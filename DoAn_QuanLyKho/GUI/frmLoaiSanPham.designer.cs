
namespace GUI
{
    partial class frmLoaiSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSanPham));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridloaisp = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenLoai = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSualsp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoalsp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThemlsp = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gridloaisp)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.gridloaisp;
            // 
            // gridloaisp
            // 
            this.gridloaisp.AllowUserToAddRows = false;
            this.gridloaisp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridloaisp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridloaisp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridloaisp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridloaisp.BackgroundColor = System.Drawing.Color.White;
            this.gridloaisp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridloaisp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridloaisp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridloaisp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridloaisp.ColumnHeadersHeight = 50;
            this.gridloaisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridloaisp.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridloaisp.DoubleBuffered = true;
            this.gridloaisp.EnableHeadersVisualStyles = false;
            this.gridloaisp.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.gridloaisp.HeaderForeColor = System.Drawing.Color.White;
            this.gridloaisp.Location = new System.Drawing.Point(3, 2);
            this.gridloaisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridloaisp.Name = "gridloaisp";
            this.gridloaisp.ReadOnly = true;
            this.gridloaisp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridloaisp.RowHeadersVisible = false;
            this.gridloaisp.RowHeadersWidth = 51;
            this.gridloaisp.RowTemplate.DividerHeight = 1;
            this.gridloaisp.RowTemplate.Height = 30;
            this.gridloaisp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridloaisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridloaisp.Size = new System.Drawing.Size(468, 684);
            this.gridloaisp.TabIndex = 9;
            this.gridloaisp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridloaisp_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_LSP";
            this.Column1.HeaderText = "Mã loại sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENLOAISANPHAM";
            this.Column2.HeaderText = "Tên loại sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "Nhập tại đây để tìm kiếm";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(63, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(425, 37);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 70;
            this.bunifuElipse3.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridloaisp, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 688);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenLoai.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenLoai.HintText = "";
            this.txtTenLoai.isPassword = false;
            this.txtTenLoai.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtTenLoai.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtTenLoai.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtTenLoai.LineThickness = 3;
            this.txtTenLoai.Location = new System.Drawing.Point(21, 137);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(339, 31);
            this.txtTenLoai.TabIndex = 58;
            this.txtTenLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(17, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "&Tên loại sản phẩm:";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.HintForeColor = System.Drawing.Color.Empty;
            this.txtID.HintText = "";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtID.LineThickness = 3;
            this.txtID.Location = new System.Drawing.Point(21, 40);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(339, 31);
            this.txtID.TabIndex = 56;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "&Mã loại sản phẩm:";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 30;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.bunifuThinButton21);
            this.bunifuCards1.Controls.Add(this.txtTenLoai);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.txtID);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(532, 70);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(910, 670);
            this.bunifuCards1.TabIndex = 59;
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
            this.bunifuThinButton21.ButtonText = "Quản lý danh mục sản phẩm";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(21, 210);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(339, 48);
            this.bunifuThinButton21.TabIndex = 60;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(17, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 37);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 20;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            // 
            // btnSualsp
            // 
            this.btnSualsp.ActiveBorderThickness = 1;
            this.btnSualsp.ActiveCornerRadius = 35;
            this.btnSualsp.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSualsp.ActiveForecolor = System.Drawing.Color.White;
            this.btnSualsp.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSualsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSualsp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSualsp.BackgroundImage")));
            this.btnSualsp.ButtonText = "Sửa";
            this.btnSualsp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSualsp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSualsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSualsp.IdleBorderThickness = 1;
            this.btnSualsp.IdleCornerRadius = 20;
            this.btnSualsp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSualsp.IdleForecolor = System.Drawing.Color.White;
            this.btnSualsp.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSualsp.Location = new System.Drawing.Point(1347, 3);
            this.btnSualsp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSualsp.Name = "btnSualsp";
            this.btnSualsp.Size = new System.Drawing.Size(95, 48);
            this.btnSualsp.TabIndex = 23;
            this.btnSualsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSualsp.Click += new System.EventHandler(this.btnSualsp_Click);
            // 
            // btnXoalsp
            // 
            this.btnXoalsp.ActiveBorderThickness = 1;
            this.btnXoalsp.ActiveCornerRadius = 35;
            this.btnXoalsp.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoalsp.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoalsp.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoalsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnXoalsp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoalsp.BackgroundImage")));
            this.btnXoalsp.ButtonText = "Xóa";
            this.btnXoalsp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoalsp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnXoalsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoalsp.IdleBorderThickness = 1;
            this.btnXoalsp.IdleCornerRadius = 20;
            this.btnXoalsp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoalsp.IdleForecolor = System.Drawing.Color.White;
            this.btnXoalsp.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoalsp.Location = new System.Drawing.Point(1249, 3);
            this.btnXoalsp.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoalsp.Name = "btnXoalsp";
            this.btnXoalsp.Size = new System.Drawing.Size(95, 48);
            this.btnXoalsp.TabIndex = 22;
            this.btnXoalsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoalsp.Click += new System.EventHandler(this.btnXoalsp_Click);
            // 
            // btnThemlsp
            // 
            this.btnThemlsp.ActiveBorderThickness = 1;
            this.btnThemlsp.ActiveCornerRadius = 35;
            this.btnThemlsp.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemlsp.ActiveForecolor = System.Drawing.Color.White;
            this.btnThemlsp.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemlsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThemlsp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemlsp.BackgroundImage")));
            this.btnThemlsp.ButtonText = "Thêm";
            this.btnThemlsp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemlsp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThemlsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemlsp.IdleBorderThickness = 1;
            this.btnThemlsp.IdleCornerRadius = 20;
            this.btnThemlsp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemlsp.IdleForecolor = System.Drawing.Color.White;
            this.btnThemlsp.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemlsp.Location = new System.Drawing.Point(1151, 3);
            this.btnThemlsp.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemlsp.Name = "btnThemlsp";
            this.btnThemlsp.Size = new System.Drawing.Size(95, 48);
            this.btnThemlsp.TabIndex = 21;
            this.btnThemlsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemlsp.Click += new System.EventHandler(this.btnThemlsp_Click);
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 971);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSualsp);
            this.Controls.Add(this.btnXoalsp);
            this.Controls.Add(this.btnThemlsp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridloaisp)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridloaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSualsp;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoalsp;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThemlsp;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenLoai;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}