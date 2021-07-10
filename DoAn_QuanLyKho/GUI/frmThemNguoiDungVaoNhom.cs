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
    public partial class frmThemNguoiDungVaoNhom : DevExpress.XtraEditors.XtraForm
    {
        QL_NhomNguoiDung nhomNguoiDung = new QL_NhomNguoiDung();
        NhanVienBLL_DAL nhanVien = new NhanVienBLL_DAL();
        QL_NguoiDungNhomNguoiDung_BLL_DAL nhom = new QL_NguoiDungNhomNguoiDung_BLL_DAL();
        public frmThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadData()
        {
            cboNhomNguoiDung.DataSource = nhomNguoiDung.loadDataNhomNguoiDung();
            cboNhomNguoiDung.ValueMember = "ID_NHOM";
            cboNhomNguoiDung.DisplayMember = "TENNHOM";

            grvNguoiDung.DataSource = nhanVien.loadNguoiDung_True();

            //grvNhomND.DataSource = nhom.loadDataNguoiDungNhomNguoiDung_id(cboNhomNguoiDung.SelectedValue.ToString());

            grvNhomND.DataSource = nhom.loadDataNguoiDungNhomNguoiDung();
        }

        private void frmThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id_dn = grvNguoiDung.CurrentRow.Cells[0].Value.ToString();
            string id_nhom = cboNhomNguoiDung.SelectedValue.ToString();
            if (nhom.themNDVaoNhom(id_dn, id_nhom) == true)
            {
                grvNhomND.DataSource = nhom.loadDataNguoiDungNhomNguoiDung();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id_dn = grvNhomND.CurrentRow.Cells[1].Value.ToString();
            string id_nhom = grvNhomND.CurrentRow.Cells[0].Value.ToString();
            if (nhom.xoaNhomNguoiDung(id_dn, id_nhom) == true)
            {
                grvNhomND.DataSource = nhom.loadDataNguoiDungNhomNguoiDung();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNhomNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            grvNhomND.DataSource = nhom.loadDataNguoiDungNhomNguoiDung_id(cboNhomNguoiDung.SelectedValue.ToString());
        }
    }
}