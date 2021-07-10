using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        public frmNhanVien()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmNhanVien_Load);
        }

        public BindingSource bindingSource1;
        private void InitializeData()
        {
            bindingSource1 = new System.Windows.Forms.BindingSource();
            bindingSource1.BindingComplete += new BindingCompleteEventHandler(bindingSource1_BindingComplete);
            bindingSource1.DataSource = nv.loadDataNguoiDung();
            grvNhanVien.DataSource = bindingSource1;
        }

        private void bindingSource1_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate
                && e.Exception == null)
            {

                e.Binding.BindingManagerBase.EndCurrentEdit();
            }
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNhanVien_Shown(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            frmShowPass frm = new frmShowPass();
            frm.Show();
        }

        private void grvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = grvNhanVien.CurrentRow.Cells[0].Value.ToString();
            lblDiaChi.Text = nv.gridViewCellClick_DiaChi(id);
            lblGioiTinh.Text = nv.gridViewCellClick_GioiTinh(id);
            lblNgaySinh.Text = nv.gridViewCellClick_NgaySinh(id);
            lblSDT.Text = nv.gridViewCellClick_SoDT(id);
            lblTenNV.Text = nv.gridViewCellClick_TenNhanVien(id);
            bool? tinhTrang = nv.gridViewCellClick_TinhTrangTaiKhoan(id);
            if(tinhTrang == true)
            {
                lblTinhTrang.Text = "Đang hoạt động";
            }
            else
            {
                lblTinhTrang.Text = "Tài khoản bị vô hiệu hóa!";
            }
            lblKho.Text = "Kho số " + nv.gridViewCellClick_IDKho(id);
            lblDiaChiKho.Text = nv.gridViewCellClick_DiaChiKho(nv.gridViewCellClick_IDKho(id));
        }

        private void btnDanhMucMH_Click(object sender, EventArgs e)
        {
            frmDanhMucMH frm = new frmDanhMucMH();
            frm.Show();
        }

        private void btnNhomNguoiDung_Click(object sender, EventArgs e)
        {
            frmQuanLyNhomNguoiDung frm = new frmQuanLyNhomNguoiDung();
            frm.Show();
        }

        private void btnThemNguoiDungVaoNhom_Click(object sender, EventArgs e)
        {
            frmThemNguoiDungVaoNhom frm = new frmThemNguoiDungVaoNhom();
            frm.Show();
        }

        private void btnPhanQuyenNhomNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.Show();
            btnLamMoi.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = grvNhanVien.CurrentRow.Cells[0].Value.ToString();
            if (nv.xoaNguoiDung(id) == true)
            {
                grvNhanVien.DataSource = nv.loadDataNguoiDung();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaNhanVien frm = new frmSuaNhanVien(bindingSource1);
            frm.Show();
            btnLamMoi.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            grvNhanVien.DataSource = nv.loadDataNguoiDung();
            grvNhanVien.Refresh();
        }
    }
}