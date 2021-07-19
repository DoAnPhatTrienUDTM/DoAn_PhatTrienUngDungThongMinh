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
using Custom_Control;

namespace GUI
{
    public partial class frmQuanLyNhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        QL_NhomNguoiDung nhonmNguoiDung = new QL_NhomNguoiDung();
        public frmQuanLyNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhomNguoiDung_Load(object sender, EventArgs e)
        {
            grvNhomNguoiDung.DataSource = nhonmNguoiDung.loadDataNhomNguoiDung();
        }

        private void grvNhomNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNhomNguoiDung.Text = grvNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
            txtTenNhom.Text = grvNhomNguoiDung.CurrentRow.Cells[1].Value.ToString();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtTenNhom.Enabled = true;
            txtNhomNguoiDung.Enabled = true;
            txtNhomNguoiDung.Focus();
            txtTenNhom.ResetText();
            txtNhomNguoiDung.ResetText();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            string tennhom = txtTenNhom.Text;
            string id = txtNhomNguoiDung.Text;
            if (nhonmNguoiDung.themNhomNguoiDung(id, tennhom) == true)
            {
                grvNhomNguoiDung.DataSource = nhonmNguoiDung.loadDataNhomNguoiDung();
                this.Alert("Thêm thành công!", frmNotificationCustom.enmType.Success);
                txtTenNhom.Enabled = false;
                txtNhomNguoiDung.Enabled = false;
            }
            else
            {
                this.Alert("Thêm thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            string id = grvNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
            if (nhonmNguoiDung.xoaNhomNguoiDung(id) == true)
            {
                grvNhomNguoiDung.DataSource = nhonmNguoiDung.loadDataNhomNguoiDung();
                this.Alert("Xóa thành công!", frmNotificationCustom.enmType.Success);
            }
            else
            {
                this.Alert("Xóa thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            string id = grvNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
            string tennhom = txtTenNhom.Text;
            if (nhonmNguoiDung.suaNhomNguoiDung(id, tennhom) == true)
            {
                grvNhomNguoiDung.DataSource = nhonmNguoiDung.loadDataNhomNguoiDung();
                this.Alert("Sửa thành công!", frmNotificationCustom.enmType.Success);
                txtTenNhom.Enabled = false;
                txtNhomNguoiDung.Enabled = false;
            }
            else
            {
                this.Alert("Sửa thất bại!", frmNotificationCustom.enmType.Error);
            }
        }
    }
}