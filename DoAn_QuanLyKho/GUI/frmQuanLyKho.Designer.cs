
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
            this.grvQuanLyKho = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelDynamic = new System.Windows.Forms.Panel();
            this.btnLamMoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSuaKho = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoaKho = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThemKho = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuanLyKho)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.grvQuanLyKho;
            // 
            // grvQuanLyKho
            // 
            this.grvQuanLyKho.AllowUserToAddRows = false;
            this.grvQuanLyKho.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grvQuanLyKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvQuanLyKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvQuanLyKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvQuanLyKho.BackgroundColor = System.Drawing.Color.White;
            this.grvQuanLyKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvQuanLyKho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grvQuanLyKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvQuanLyKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvQuanLyKho.ColumnHeadersHeight = 50;
            this.grvQuanLyKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.grvQuanLyKho.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvQuanLyKho.DoubleBuffered = true;
            this.grvQuanLyKho.EnableHeadersVisualStyles = false;
            this.grvQuanLyKho.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.grvQuanLyKho.HeaderForeColor = System.Drawing.Color.White;
            this.grvQuanLyKho.Location = new System.Drawing.Point(3, 2);
            this.grvQuanLyKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvQuanLyKho.Name = "grvQuanLyKho";
            this.grvQuanLyKho.ReadOnly = true;
            this.grvQuanLyKho.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvQuanLyKho.RowHeadersVisible = false;
            this.grvQuanLyKho.RowHeadersWidth = 51;
            this.grvQuanLyKho.RowTemplate.DividerHeight = 1;
            this.grvQuanLyKho.RowTemplate.Height = 30;
            this.grvQuanLyKho.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvQuanLyKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvQuanLyKho.Size = new System.Drawing.Size(468, 684);
            this.grvQuanLyKho.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_KHO";
            this.Column1.HeaderText = "ID Kho";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DIACHI";
            this.Column2.HeaderText = "Địa chỉ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TINHTRANG";
            this.Column3.HeaderText = "Tình trạng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SLNV";
            this.Column4.HeaderText = "Số lượng nhân viên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            this.txtSearch.Location = new System.Drawing.Point(67, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(425, 37);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.txtSearch_OnValueChanged);
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
            this.tableLayoutPanel1.Controls.Add(this.grvQuanLyKho, 0, 0);
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
            this.tableLayoutPanel2.Controls.Add(this.panelDynamic, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(514, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(900, 900);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // panelDynamic
            // 
            this.panelDynamic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDynamic.Location = new System.Drawing.Point(3, 3);
            this.panelDynamic.Name = "panelDynamic";
            this.panelDynamic.Size = new System.Drawing.Size(894, 894);
            this.panelDynamic.TabIndex = 0;
            this.panelDynamic.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDynamic_Paint);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ActiveBorderThickness = 1;
            this.btnLamMoi.ActiveCornerRadius = 35;
            this.btnLamMoi.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLamMoi.ActiveForecolor = System.Drawing.Color.White;
            this.btnLamMoi.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.BackgroundImage")));
            this.btnLamMoi.ButtonText = "Có thay đổi? Làm mới danh sách ngay!";
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLamMoi.IdleBorderThickness = 1;
            this.btnLamMoi.IdleCornerRadius = 20;
            this.btnLamMoi.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLamMoi.IdleForecolor = System.Drawing.Color.White;
            this.btnLamMoi.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLamMoi.Location = new System.Drawing.Point(833, 13);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(319, 48);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(21, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 37);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 11;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            // 
            // btnSuaKho
            // 
            this.btnSuaKho.ActiveBorderThickness = 1;
            this.btnSuaKho.ActiveCornerRadius = 35;
            this.btnSuaKho.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaKho.ActiveForecolor = System.Drawing.Color.White;
            this.btnSuaKho.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaKho.BackColor = System.Drawing.Color.White;
            this.btnSuaKho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaKho.BackgroundImage")));
            this.btnSuaKho.ButtonText = "Sửa";
            this.btnSuaKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaKho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSuaKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaKho.IdleBorderThickness = 1;
            this.btnSuaKho.IdleCornerRadius = 20;
            this.btnSuaKho.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaKho.IdleForecolor = System.Drawing.Color.White;
            this.btnSuaKho.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaKho.Location = new System.Drawing.Point(1351, 12);
            this.btnSuaKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaKho.Name = "btnSuaKho";
            this.btnSuaKho.Size = new System.Drawing.Size(95, 48);
            this.btnSuaKho.TabIndex = 15;
            this.btnSuaKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuaKho.Click += new System.EventHandler(this.btnSuaKho_Click);
            // 
            // btnXoaKho
            // 
            this.btnXoaKho.ActiveBorderThickness = 1;
            this.btnXoaKho.ActiveCornerRadius = 35;
            this.btnXoaKho.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaKho.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoaKho.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaKho.BackColor = System.Drawing.Color.White;
            this.btnXoaKho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaKho.BackgroundImage")));
            this.btnXoaKho.ButtonText = "Xóa";
            this.btnXoaKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnXoaKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaKho.IdleBorderThickness = 1;
            this.btnXoaKho.IdleCornerRadius = 20;
            this.btnXoaKho.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaKho.IdleForecolor = System.Drawing.Color.White;
            this.btnXoaKho.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaKho.Location = new System.Drawing.Point(1253, 12);
            this.btnXoaKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaKho.Name = "btnXoaKho";
            this.btnXoaKho.Size = new System.Drawing.Size(95, 48);
            this.btnXoaKho.TabIndex = 14;
            this.btnXoaKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoaKho.Click += new System.EventHandler(this.btnXoaKho_Click);
            // 
            // btnThemKho
            // 
            this.btnThemKho.ActiveBorderThickness = 1;
            this.btnThemKho.ActiveCornerRadius = 35;
            this.btnThemKho.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemKho.ActiveForecolor = System.Drawing.Color.White;
            this.btnThemKho.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemKho.BackColor = System.Drawing.Color.White;
            this.btnThemKho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemKho.BackgroundImage")));
            this.btnThemKho.ButtonText = "Thêm";
            this.btnThemKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThemKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemKho.IdleBorderThickness = 1;
            this.btnThemKho.IdleCornerRadius = 20;
            this.btnThemKho.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemKho.IdleForecolor = System.Drawing.Color.White;
            this.btnThemKho.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemKho.Location = new System.Drawing.Point(1155, 12);
            this.btnThemKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.Size = new System.Drawing.Size(95, 48);
            this.btnThemKho.TabIndex = 13;
            this.btnThemKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemKho.Click += new System.EventHandler(this.btnThemKho_Click);
            // 
            // frmQuanLyKho
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 1003);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSuaKho);
            this.Controls.Add(this.btnXoaKho);
            this.Controls.Add(this.btnThemKho);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyKho";
            this.Text = "frmQuanLyKho";
            this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvQuanLyKho)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSuaKho;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoaKho;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThemKho;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grvQuanLyKho;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panelDynamic;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLamMoi;
    }
}