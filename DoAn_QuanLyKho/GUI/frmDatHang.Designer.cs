
namespace GUI
{
    partial class frmDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDSChuyenHang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.circularButton2 = new Custom_Control.CircularButton();
            this.circularButton1 = new Custom_Control.CircularButton();
            this.gridSPCanDat = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxloaisp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnluu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnxoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbltongiten = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnthem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbxSPNCC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSLD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxNCC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCTDH = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSPCanDat)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTDH)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.939F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.061F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridSPCanDat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridCTDH, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 635);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDSChuyenHang);
            this.panel1.Controls.Add(this.circularButton2);
            this.panel1.Controls.Add(this.circularButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(893, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 311);
            this.panel1.TabIndex = 1;
            // 
            // btnDSChuyenHang
            // 
            this.btnDSChuyenHang.ActiveBorderThickness = 1;
            this.btnDSChuyenHang.ActiveCornerRadius = 20;
            this.btnDSChuyenHang.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDSChuyenHang.ActiveForecolor = System.Drawing.Color.White;
            this.btnDSChuyenHang.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDSChuyenHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnDSChuyenHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDSChuyenHang.BackgroundImage")));
            this.btnDSChuyenHang.ButtonText = "Chuyển";
            this.btnDSChuyenHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDSChuyenHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSChuyenHang.ForeColor = System.Drawing.Color.White;
            this.btnDSChuyenHang.IdleBorderThickness = 1;
            this.btnDSChuyenHang.IdleCornerRadius = 20;
            this.btnDSChuyenHang.IdleFillColor = System.Drawing.Color.Coral;
            this.btnDSChuyenHang.IdleForecolor = System.Drawing.Color.White;
            this.btnDSChuyenHang.IdleLineColor = System.Drawing.Color.White;
            this.btnDSChuyenHang.Location = new System.Drawing.Point(14, 94);
            this.btnDSChuyenHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnDSChuyenHang.Name = "btnDSChuyenHang";
            this.btnDSChuyenHang.Size = new System.Drawing.Size(100, 40);
            this.btnDSChuyenHang.TabIndex = 19;
            this.btnDSChuyenHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDSChuyenHang.Click += new System.EventHandler(this.btnDSChuyenHang_Click);
            // 
            // circularButton2
            // 
            this.circularButton2.BackColor = System.Drawing.Color.Coral;
            this.circularButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.circularButton2.ForeColor = System.Drawing.Color.White;
            this.circularButton2.Location = new System.Drawing.Point(26, 51);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(75, 36);
            this.circularButton2.TabIndex = 1;
            this.circularButton2.Text = "Danh Sách";
            this.circularButton2.UseVisualStyleBackColor = false;
            this.circularButton2.Click += new System.EventHandler(this.circularButton2_Click);
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.Coral;
            this.circularButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.circularButton1.ForeColor = System.Drawing.Color.White;
            this.circularButton1.Location = new System.Drawing.Point(26, 9);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(75, 36);
            this.circularButton1.TabIndex = 0;
            this.circularButton1.Text = "import...";
            this.circularButton1.UseVisualStyleBackColor = false;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // gridSPCanDat
            // 
            this.gridSPCanDat.AllowUserToAddRows = false;
            this.gridSPCanDat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridSPCanDat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSPCanDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSPCanDat.BackgroundColor = System.Drawing.Color.White;
            this.gridSPCanDat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSPCanDat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSPCanDat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSPCanDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSPCanDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSPCanDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.cbxloaisp,
            this.Column4,
            this.Column5,
            this.Column6});
            this.tableLayoutPanel1.SetColumnSpan(this.gridSPCanDat, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSPCanDat.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSPCanDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSPCanDat.DoubleBuffered = true;
            this.gridSPCanDat.EnableHeadersVisualStyles = false;
            this.gridSPCanDat.GridColor = System.Drawing.Color.White;
            this.gridSPCanDat.HeaderBgColor = System.Drawing.Color.White;
            this.gridSPCanDat.HeaderForeColor = System.Drawing.Color.Black;
            this.gridSPCanDat.Location = new System.Drawing.Point(3, 3);
            this.gridSPCanDat.Name = "gridSPCanDat";
            this.gridSPCanDat.ReadOnly = true;
            this.gridSPCanDat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSPCanDat.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gridSPCanDat.RowTemplate.Height = 50;
            this.gridSPCanDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSPCanDat.Size = new System.Drawing.Size(884, 311);
            this.gridSPCanDat.TabIndex = 2;
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
            this.Column3.HeaderText = "Đơn Vị Tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cbxloaisp
            // 
            this.cbxloaisp.HeaderText = "Loại Sản Phẩm";
            this.cbxloaisp.Name = "cbxloaisp";
            this.cbxloaisp.ReadOnly = true;
            this.cbxloaisp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbxloaisp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Lượng Tồn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đơn Giá";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hình Ảnh";
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnluu);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.lbltongiten);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.cbxSPNCC);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSLD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cbxNCC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblnv);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(3, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 312);
            this.panel2.TabIndex = 3;
            // 
            // btnluu
            // 
            this.btnluu.ActiveBorderThickness = 1;
            this.btnluu.ActiveCornerRadius = 20;
            this.btnluu.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnluu.ActiveForecolor = System.Drawing.Color.White;
            this.btnluu.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnluu.BackColor = System.Drawing.SystemColors.Control;
            this.btnluu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnluu.BackgroundImage")));
            this.btnluu.ButtonText = "Lưu";
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.White;
            this.btnluu.IdleBorderThickness = 1;
            this.btnluu.IdleCornerRadius = 20;
            this.btnluu.IdleFillColor = System.Drawing.Color.Coral;
            this.btnluu.IdleForecolor = System.Drawing.Color.White;
            this.btnluu.IdleLineColor = System.Drawing.Color.White;
            this.btnluu.Location = new System.Drawing.Point(254, 230);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(100, 40);
            this.btnluu.TabIndex = 18;
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.ActiveBorderThickness = 1;
            this.btnsua.ActiveCornerRadius = 20;
            this.btnsua.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsua.ActiveForecolor = System.Drawing.Color.White;
            this.btnsua.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsua.BackColor = System.Drawing.SystemColors.Control;
            this.btnsua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsua.BackgroundImage")));
            this.btnsua.ButtonText = "Sửa";
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.IdleBorderThickness = 1;
            this.btnsua.IdleCornerRadius = 20;
            this.btnsua.IdleFillColor = System.Drawing.Color.Coral;
            this.btnsua.IdleForecolor = System.Drawing.Color.White;
            this.btnsua.IdleLineColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(143, 230);
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
            this.btnxoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.BackgroundImage")));
            this.btnxoa.ButtonText = "Xóa";
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.IdleBorderThickness = 1;
            this.btnxoa.IdleCornerRadius = 20;
            this.btnxoa.IdleFillColor = System.Drawing.Color.Coral;
            this.btnxoa.IdleForecolor = System.Drawing.Color.White;
            this.btnxoa.IdleLineColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(254, 197);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 40);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // lbltongiten
            // 
            this.lbltongiten.AutoSize = true;
            this.lbltongiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltongiten.ForeColor = System.Drawing.Color.Red;
            this.lbltongiten.Location = new System.Drawing.Point(140, 274);
            this.lbltongiten.Name = "lbltongiten";
            this.lbltongiten.Size = new System.Drawing.Size(44, 13);
            this.lbltongiten.TabIndex = 15;
            this.lbltongiten.Text = "0 VNĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tổng Tiền:";
            // 
            // btnthem
            // 
            this.btnthem.ActiveBorderThickness = 1;
            this.btnthem.ActiveCornerRadius = 20;
            this.btnthem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnthem.ActiveForecolor = System.Drawing.Color.White;
            this.btnthem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnthem.BackColor = System.Drawing.SystemColors.Control;
            this.btnthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthem.BackgroundImage")));
            this.btnthem.ButtonText = "Thêm";
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.IdleBorderThickness = 1;
            this.btnthem.IdleCornerRadius = 20;
            this.btnthem.IdleFillColor = System.Drawing.Color.Coral;
            this.btnthem.IdleForecolor = System.Drawing.Color.White;
            this.btnthem.IdleLineColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(143, 197);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 40);
            this.btnthem.TabIndex = 11;
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthem.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // cbxSPNCC
            // 
            this.cbxSPNCC.FormattingEnabled = true;
            this.cbxSPNCC.Location = new System.Drawing.Point(143, 100);
            this.cbxSPNCC.Name = "cbxSPNCC";
            this.cbxSPNCC.Size = new System.Drawing.Size(211, 21);
            this.cbxSPNCC.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sản Phẩm:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSLD
            // 
            this.txtSLD.Location = new System.Drawing.Point(143, 170);
            this.txtSLD.Name = "txtSLD";
            this.txtSLD.Size = new System.Drawing.Size(211, 20);
            this.txtSLD.TabIndex = 7;
            this.txtSLD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSLD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng Đặt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cbxNCC
            // 
            this.cbxNCC.FormattingEnabled = true;
            this.cbxNCC.Location = new System.Drawing.Point(143, 57);
            this.cbxNCC.Name = "cbxNCC";
            this.cbxNCC.Size = new System.Drawing.Size(211, 21);
            this.cbxNCC.TabIndex = 3;
            this.cbxNCC.SelectedIndexChanged += new System.EventHandler(this.cbxNCC_SelectedIndexChanged);
            this.cbxNCC.DropDownClosed += new System.EventHandler(this.cbxNCC_DropDownClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà Cung Cấp:";
            // 
            // lblnv
            // 
            this.lblnv.AutoSize = true;
            this.lblnv.Location = new System.Drawing.Point(140, 20);
            this.lblnv.Name = "lblnv";
            this.lblnv.Size = new System.Drawing.Size(35, 13);
            this.lblnv.TabIndex = 1;
            this.lblnv.Text = "label2";
            this.lblnv.Click += new System.EventHandler(this.lblnv_Click);
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
            // gridCTDH
            // 
            this.gridCTDH.AllowUserToAddRows = false;
            this.gridCTDH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridCTDH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCTDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCTDH.BackgroundColor = System.Drawing.Color.White;
            this.gridCTDH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCTDH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCTDH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCTDH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCTDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.SLDat,
            this.Column10});
            this.tableLayoutPanel1.SetColumnSpan(this.gridCTDH, 2);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCTDH.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridCTDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTDH.DoubleBuffered = true;
            this.gridCTDH.EnableHeadersVisualStyles = false;
            this.gridCTDH.GridColor = System.Drawing.Color.White;
            this.gridCTDH.HeaderBgColor = System.Drawing.Color.White;
            this.gridCTDH.HeaderForeColor = System.Drawing.Color.Black;
            this.gridCTDH.Location = new System.Drawing.Point(376, 320);
            this.gridCTDH.Name = "gridCTDH";
            this.gridCTDH.ReadOnly = true;
            this.gridCTDH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCTDH.Size = new System.Drawing.Size(641, 312);
            this.gridCTDH.TabIndex = 4;
            this.gridCTDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCTDH_CellContentClick);
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
            // SLDat
            // 
            this.SLDat.HeaderText = "Số Lượng Đặt";
            this.SLDat.Name = "SLDat";
            this.SLDat.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Thành Tiền";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDatHang";
            this.Text = "frmDatHang";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSPCanDat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Custom_Control.CircularButton circularButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridSPCanDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxloaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSLD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnv;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridCTDH;
        private System.Windows.Forms.ComboBox cbxSPNCC;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthem;
        private System.Windows.Forms.Label lbltongiten;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuThinButton2 btnluu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsua;
        private Bunifu.Framework.UI.BunifuThinButton2 btnxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private Custom_Control.CircularButton circularButton2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDSChuyenHang;
    }
}