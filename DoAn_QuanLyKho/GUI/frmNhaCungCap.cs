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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        NCC_BLL_DAL ncc = new NCC_BLL_DAL();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        public void initializeData()
        {
            grvNhaCungCap.DataSource = ncc.get_NCC();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            initializeData();
            int id = int.Parse(grvNhaCungCap.CurrentRow.Cells[0].Value.ToString());
            lblTenNCC.Text = grvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            lblDiaChi.Text = ncc.gridViewCellClick_DiaChi(id);
            lblSoDT.Text = ncc.gridViewCellClick_SoDT(id);

            grvSanPham.DataSource = ncc.get_SanPham_NCC(id);
        }

        private void grvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(grvNhaCungCap.CurrentRow.Cells[0].Value.ToString());
            lblTenNCC.Text = grvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            lblDiaChi.Text = ncc.gridViewCellClick_DiaChi(id);
            lblSoDT.Text = ncc.gridViewCellClick_SoDT(id);

            grvSanPham.DataSource = ncc.get_SanPham_NCC(id);
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grvNhaCungCap.CurrentRow.Cells[0].Value.ToString());
            if (ncc.xoaNhaCungCap(id) == true)
            {
                grvNhaCungCap.DataSource = ncc.get_NCC();
                this.Alert("Xóa thành công!", frmNotificationCustom.enmType.Success);
            }
            else
            {
                this.Alert("Xóa thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frm = new frmThemNhaCungCap();
            frm.Show();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            frmSuaNhaCungCap frm = new frmSuaNhaCungCap();
            frm.Show();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            grvNhaCungCap.DataSource = ncc.searchNhaCungCap(txtSearch.Text);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            TestMapControl control = new TestMapControl();
            control.txtFromAddress.Text = lblDiaChi.Text;
            control.txtToAddress.Text = lblDiaChi.Text;
            control.Show();
        }
    }
}