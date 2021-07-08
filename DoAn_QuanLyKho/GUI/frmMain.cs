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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        Check_Login login = new Check_Login();
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        string MaNhanVien;
        public frmMain(string manv)
        {
            MaNhanVien = manv;
            InitializeComponent();
        }

        public void openSubForm(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            mainPanel.Tag = form;
            mainPanel.BringToFront();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_1_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Trang chủ";
            indicator.Top = ((Control)sender).Top;
            frmTrangChu frm = new frmTrangChu();
            openSubForm(frm);
        }

        private void btnLienHe_2_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Nhà cung cấp";
            indicator.Top = ((Control)sender).Top;
            frmNhaCungCap frm = new frmNhaCungCap();
            openSubForm(frm);
        }

        private void btnKho_3_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Quản lý kho";
            indicator.Top = ((Control)sender).Top;
            frmQuanLyKho frm = new frmQuanLyKho();
            openSubForm(frm);
        }

        private void btnSanPham_4_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Sản phẩm";
            indicator.Top = ((Control)sender).Top;
            frmHangHoa n = new frmHangHoa();
            openSubForm(n);
        }

        private void btnBaoCao_5_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Báo cáo";
            indicator.Top = ((Control)sender).Top;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "Trang chủ";
            frmTrangChu frm = new frmTrangChu();
            openSubForm(frm);
            NGUOIDUNG nd = new NGUOIDUNG();
            try
            {
                nd = nv.get_Info(MaNhanVien);
                lblTen.Text = "Xin chào " + nd.TEN.ToString() +"!";
                Image img = Image.FromFile(Application.StartupPath + "\\img\\" + nd.HINH);
                picNhanVien.Image = img;
            }
            catch
            {
                nd = nv.get_Info(MaNhanVien);
                lblTen.Text = "Xin chào " + nd.TEN.ToString() + "!";
                Image img = Image.FromFile(Application.StartupPath + "\\img\\user_32x322.png");
                picNhanVien.Image = img;
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Nhân viên";
            indicator.Top = ((Control)sender).Top;
            frmNhanVien frm = new frmNhanVien();
            openSubForm(frm);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            frmCapNhatTT frm = new frmCapNhatTT(MaNhanVien);
            frm.Show();
        }
    }
}