using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }
        public void openSubForm(Form form)
        {
            panelmain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelmain.Controls.Add(form);
            panelmain.Tag = form;
            panelmain.BringToFront();
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmPhieuDat frm = new frmPhieuDat();
            frm.vitri = true;
            openSubForm(frm);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            openSubForm(frm);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap();
            frm.vitri = true;
            openSubForm(frm);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmPhieuXuat frm = new frmPhieuXuat();
            frm.vitri = true;
            openSubForm(frm);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frm = new frmLoaiSanPham();
            openSubForm(frm);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            openSubForm(frm);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmDanhMucSanPham frm = new frmDanhMucSanPham();
            openSubForm(frm);
        }
    }
}
