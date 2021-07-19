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
    public partial class frmSuaKho : DevExpress.XtraEditors.XtraForm
    {
        KhoBLL_DAL kho = new KhoBLL_DAL();
        public frmSuaKho()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id_kho = int.Parse(grvKho.CurrentRow.Cells[0].Value.ToString());
            string diaChi = txtDiaChi.Text;
            string tinhTrang = txtTinhTrang.Text;
            int slnv = int.Parse(txtSoLuongNV.Text);
            if (kho.suaKho(id_kho, diaChi, tinhTrang, slnv) == true)
            {
                grvKho.DataSource = kho.loadDataKHo();
                this.Alert("Sửa thành công!", frmNotificationCustom.enmType.Success);
            }
            else
            {
                this.Alert("Sửa thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void frmSuaKho_Load(object sender, EventArgs e)
        {
            grvKho.DataSource = kho.loadDataKHo();
        }

        private void grvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDiaChi.Text = grvKho.CurrentRow.Cells[1].Value.ToString();
            txtTinhTrang.Text = grvKho.CurrentRow.Cells[2].Value.ToString();
            txtSoLuongNV.Text = grvKho.CurrentRow.Cells[3].Value.ToString();
        }
    }
}