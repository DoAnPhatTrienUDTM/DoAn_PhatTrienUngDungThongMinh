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
    public partial class frmThemNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        NCC_BLL_DAL ncc = new NCC_BLL_DAL();
        public frmThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmThemNhaCungCap_Load(object sender, EventArgs e)
        {
            grvNhaCungCap.DataSource = ncc.get_NCC_GridCon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenNCC = txtTenNhaCungCap.Text;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSoDienThoai.Text;
            if (ncc.themNhaCungCap(tenNCC, diaChi, sdt) == true)
            {
                grvNhaCungCap.DataSource = ncc.get_NCC_GridCon();
                this.Alert("Thêm thành công!", frmNotificationCustom.enmType.Success);
            }
            else
            {
                this.Alert("Thêm thất bại!", frmNotificationCustom.enmType.Error);
            }
        }
    }
}