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
    public partial class frmThemKho : DevExpress.XtraEditors.XtraForm
    {
        KhoBLL_DAL kho = new KhoBLL_DAL();
        public frmThemKho()
        {
            InitializeComponent();
        }

        public void initializeData()
        {
            grvKho.DataSource = kho.loadDataKHo();
        }

        private void frmThemKho_Load(object sender, EventArgs e)
        {
            initializeData();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string diaChi = txtDiaChi.Text;
            string tinhTrang = txtTinhTrang.Text;
            int slnv = int.Parse(txtSoLuongNV.Text);
            if (kho.themKho(diaChi, tinhTrang, slnv) == true)
            {
                grvKho.DataSource = kho.loadDataKHo();
                this.Alert("Thêm thành công!", frmNotificationCustom.enmType.Success);
            }
            else
            {
                this.Alert("Thêm thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void txtSoLuongNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}