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
    public partial class frmSuaNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        NCC_BLL_DAL ncc = new NCC_BLL_DAL();
        public frmSuaNhaCungCap()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void frmSuaNhaCungCap_Load(object sender, EventArgs e)
        {
            grvNhaCungCap.DataSource = ncc.get_NCC_GridCon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idncc = int.Parse(grvNhaCungCap.CurrentRow.Cells[0].Value.ToString());
            string tenNCC = txtTenNhaCungCap.Text;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSoDienThoai.Text;
            if (ncc.suaNhaCungCap(idncc, tenNCC, diaChi, sdt) == true)
            {
                grvNhaCungCap.DataSource = ncc.get_NCC_GridCon();
                this.Alert("Sửa thành công!", frmNotificationCustom.enmType.Success);
            }
            else
            {
                this.Alert("Sửa thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void grvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNhaCungCap.Text = grvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = grvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
            txtSoDienThoai.Text = grvNhaCungCap.CurrentRow.Cells[3].Value.ToString();
        }
    }
}