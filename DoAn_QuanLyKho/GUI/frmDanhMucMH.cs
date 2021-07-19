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
    public partial class frmDanhMucMH : DevExpress.XtraEditors.XtraForm
    {
        DanhMucMH_BLL_DAL dm = new DanhMucMH_BLL_DAL();
        public frmDanhMucMH()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhMucMH_Load(object sender, EventArgs e)
        {
            grvDanhMucManHinh.DataSource = dm.loadDataDanhMucMH();
        }

        private void grvDanhMucManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenManHinh.Text = grvDanhMucManHinh.CurrentRow.Cells[1].Value.ToString();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenmh = txtTenManHinh.Text;
            if (dm.themDanhMuc_MH(tenmh) == true)
            {
                grvDanhMucManHinh.DataSource = dm.loadDataDanhMucMH();
                this.Alert("Thêm thành công!", frmNotificationCustom.enmType.Success);
                txtTenManHinh.Enabled = false;
            }
            else
            {
                this.Alert("Thêm thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grvDanhMucManHinh.CurrentRow.Cells[0].Value.ToString());
            if (dm.xoaDanhMuc_MH(id) == true)
            {
                grvDanhMucManHinh.DataSource = dm.loadDataDanhMucMH();
                this.Alert("Xóa thành công!", frmNotificationCustom.enmType.Success);
            }
            else
            {
                this.Alert("Xóa thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grvDanhMucManHinh.CurrentRow.Cells[0].Value.ToString());
            string tenmh = txtTenManHinh.Text;
            if (dm.suaDanhMuc_MH(id, tenmh) == true)
            {
                grvDanhMucManHinh.DataSource = dm.loadDataDanhMucMH();
                this.Alert("Sửa thành công!", frmNotificationCustom.enmType.Success);
                txtTenManHinh.Enabled = false;
            }
            else
            {
                this.Alert("Sửa thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtTenManHinh.Enabled = true;
            txtTenManHinh.Focus();
            txtTenManHinh.ResetText();
        }
    }
}