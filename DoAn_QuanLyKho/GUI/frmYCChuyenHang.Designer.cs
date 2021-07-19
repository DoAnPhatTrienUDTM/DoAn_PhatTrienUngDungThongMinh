
namespace GUI
{
    partial class frmYCChuyenHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYCChuyenHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblidKho = new System.Windows.Forms.Label();
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnxoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnthem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSLD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCTCH = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gridSPCanChuyen = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxLoaiSp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSPCanChuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidKho
            // 
            this.lblidKho.AutoSize = true;
            this.lblidKho.Location = new System.Drawing.Point(140, 60);
            this.lblidKho.Name = "lblidKho";
            this.lblidKho.Size = new System.Drawing.Size(16, 13);
            this.lblidKho.TabIndex = 19;
            this.lblidKho.Text = "...";
            // 
            // btnLuu
            // 
            this.btnLuu.ActiveBorderThickness = 1;
            this.btnLuu.ActiveCornerRadius = 20;
            this.btnLuu.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.ActiveForecolor = System.Drawing.Color.White;
            this.btnLuu.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.IdleBorderThickness = 1;
            this.btnLuu.IdleCornerRadius = 20;
            this.btnLuu.IdleFillColor = System.Drawing.Color.Coral;
            this.btnLuu.IdleForecolor = System.Drawing.Color.White;
            this.btnLuu.IdleLineColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(256, 228);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 40);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.62882F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.37118F));
            this.tableLayoutPanel1.Controls.Add(this.gridSPCanChuyen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridCTCH, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1025, 662);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblidKho);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.txtSLD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblnv);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 325);
            this.panel2.TabIndex = 3;
            // 
            // btnsua
            // 
            this.btnsua.ActiveBorderThickness = 1;
            this.btnsua.ActiveCornerRadius = 20;
            this.btnsua.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsua.ActiveForecolor = System.Drawing.Color.White;
            this.btnsua.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsua.BackColor = System.Drawing.Color.White;
            this.btnsua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsua.BackgroundImage")));
            this.btnsua.ButtonText = "Sửa";
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.IdleBorderThickness = 1;
            this.btnsua.IdleCornerRadius = 20;
            this.btnsua.IdleFillColor = System.Drawing.Color.Coral;
            this.btnsua.IdleForecolor = System.Drawing.Color.White;
            this.btnsua.IdleLineColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(143, 228);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 40);
            this.btnsua.TabIndex = 17;
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ActiveBorderThickness = 1;
            this.btnxoa.ActiveCornerRadius = 20;
            this.btnxoa.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.ActiveForecolor = System.Drawing.Color.White;
            this.btnxoa.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.BackColor = System.Drawing.Color.White;
            this.btnxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.BackgroundImage")));
            this.btnxoa.ButtonText = "Xóa";
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.IdleBorderThickness = 1;
            this.btnxoa.IdleCornerRadius = 20;
            this.btnxoa.IdleFillColor = System.Drawing.Color.Coral;
            this.btnxoa.IdleForecolor = System.Drawing.Color.White;
            this.btnxoa.IdleLineColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(256, 171);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 40);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.ActiveBorderThickness = 1;
            this.btnthem.ActiveCornerRadius = 20;
            this.btnthem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnthem.ActiveForecolor = System.Drawing.Color.White;
            this.btnthem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnthem.BackColor = System.Drawing.Color.White;
            this.btnthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthem.BackgroundImage")));
            this.btnthem.ButtonText = "Thêm";
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.IdleBorderThickness = 1;
            this.btnthem.IdleCornerRadius = 20;
            this.btnthem.IdleFillColor = System.Drawing.Color.Coral;
            this.btnthem.IdleForecolor = System.Drawing.Color.White;
            this.btnthem.IdleLineColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(143, 171);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 40);
            this.btnthem.TabIndex = 11;
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtSLD
            // 
            this.txtSLD.Location = new System.Drawing.Point(143, 134);
            this.txtSLD.Name = "txtSLD";
            this.txtSLD.Size = new System.Drawing.Size(211, 20);
            this.txtSLD.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng Cần Chuyển:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kho ";
            // 
            // lblnv
            // 
            this.lblnv.AutoSize = true;
            this.lblnv.Location = new System.Drawing.Point(140, 20);
            this.lblnv.Name = "lblnv";
            this.lblnv.Size = new System.Drawing.Size(35, 13);
            this.lblnv.TabIndex = 1;
            this.lblnv.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân Viên:";
            // 
            // gridCTCH
            // 
            this.gridCTCH.AllowUserToAddRows = false;
            this.gridCTCH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridCTCH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCTCH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCTCH.BackgroundColor = System.Drawing.Color.White;
            this.gridCTCH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCTCH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCTCH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCTCH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCTCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCTCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.SLNhap});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCTCH.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridCTCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTCH.DoubleBuffered = true;
            this.gridCTCH.EnableHeadersVisualStyles = false;
            this.gridCTCH.GridColor = System.Drawing.Color.White;
            this.gridCTCH.HeaderBgColor = System.Drawing.Color.White;
            this.gridCTCH.HeaderForeColor = System.Drawing.Color.Black;
            this.gridCTCH.Location = new System.Drawing.Point(409, 334);
            this.gridCTCH.Name = "gridCTCH";
            this.gridCTCH.ReadOnly = true;
            this.gridCTCH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCTCH.Size = new System.Drawing.Size(613, 325);
            this.gridCTCH.TabIndex = 4;
            // 
            // gridSPCanChuyen
            // 
            this.gridSPCanChuyen.AllowUserToAddRows = false;
            this.gridSPCanChuyen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridSPCanChuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSPCanChuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSPCanChuyen.BackgroundColor = System.Drawing.Color.White;
            this.gridSPCanChuyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSPCanChuyen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSPCanChuyen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSPCanChuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSPCanChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSPCanChuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.cbxLoaiSp,
            this.Column4});
            this.tableLayoutPanel1.SetColumnSpan(this.gridSPCanChuyen, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSPCanChuyen.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSPCanChuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSPCanChuyen.DoubleBuffered = true;
            this.gridSPCanChuyen.EnableHeadersVisualStyles = false;
            this.gridSPCanChuyen.GridColor = System.Drawing.Color.White;
            this.gridSPCanChuyen.HeaderBgColor = System.Drawing.Color.White;
            this.gridSPCanChuyen.HeaderForeColor = System.Drawing.Color.Black;
            this.gridSPCanChuyen.Location = new System.Drawing.Point(3, 3);
            this.gridSPCanChuyen.Name = "gridSPCanChuyen";
            this.gridSPCanChuyen.ReadOnly = true;
            this.gridSPCanChuyen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSPCanChuyen.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gridSPCanChuyen.RowTemplate.Height = 70;
            this.gridSPCanChuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSPCanChuyen.Size = new System.Drawing.Size(1019, 325);
            this.gridSPCanChuyen.TabIndex = 2;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã Sản Phẩm";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tên Sản Phẩm";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // SLNhap
            // 
            this.SLNhap.HeaderText = "Số Lượng Đặt";
            this.SLNhap.Name = "SLNhap";
            this.SLNhap.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số Lượng Tồn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cbxLoaiSp
            // 
            this.cbxLoaiSp.HeaderText = "Loại Sản Phẩm";
            this.cbxLoaiSp.Name = "cbxLoaiSp";
            this.cbxLoaiSp.ReadOnly = true;
            this.cbxLoaiSp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbxLoaiSp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hình Ảnh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmYCChuyenHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmYCChuyenHang";
            this.Text = "frmYCChuyenHang";
            this.Load += new System.EventHandler(this.frmYCChuyenHang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSPCanChuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblidKho;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsua;
        private Bunifu.Framework.UI.BunifuThinButton2 btnxoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthem;
        private System.Windows.Forms.TextBox txtSLD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnv;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridCTCH;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridSPCanChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxLoaiSp;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}