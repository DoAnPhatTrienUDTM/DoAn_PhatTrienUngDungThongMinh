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
        QL_NguoiDungNhomNguoiDung_BLL_DAL nguoiDung = new QL_NguoiDungNhomNguoiDung_BLL_DAL();
        PhanQuyen_BLL_DAL phanQuyen = new PhanQuyen_BLL_DAL();
        string MaNhanVien;
        public frmMain(string manv)
        {
            MaNhanVien = manv;
            InitializeComponent();
        }

        public void openSubForm(Form form)
        {
            panelMenu.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(form);
            panelMenu.Tag = form;
            panelMenu.BringToFront();
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


        private void frmMain_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "Trang chủ";
            frmTrangChu frm = new frmTrangChu();
            openSubForm(frm);
            NGUOIDUNG nd = new NGUOIDUNG();
            try
            {
                nd = nv.get_Info(MaNhanVien);
                lblTen.Text = "Xin chào " + nd.TEN.ToString() + "!";
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
            if (nguoiDung.getRole(MaNhanVien) == null)
            {
                lblChucVu.Text = "Chưa có chức vụ";
            }
            else
            {
                lblChucVu.Text = nguoiDung.getRole(MaNhanVien);
            }
            loadPhanQuyen();
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

        public void loadPhanQuyen()
        {
            foreach(NGUOIDUNGNHOMNGUOIDUNG item in nguoiDung.loadDataNguoiDungNhomNguoiDung_id(MaNhanVien))
            {
                foreach(PHANQUYEN item1 in phanQuyen.load_PhanQuyenFull(item.ID_NHOM))
                {
                    CheckAllButtonChildVisiable(item1.ID_MANHINH);
                }    
            }    
        }

        private void CheckAllButtonChildVisiable(int tag)
        {
            foreach (Control bt in panelMenu1.Controls)
            {
                if (bt.GetType().ToString() == "System.Windows.Forms.Button")
                {
                    if (bt.Tag != null)
                    {
                        if (bt.Tag.Equals(tag.ToString()))
                        {
                            bt.Visible = true;
                        }
                    }
                }
            }
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            lblHeader.Text = "Trang chủ";
            indicator.Top = ((Control)sender).Top;
            frmTrangChu frm = new frmTrangChu();
            openSubForm(frm);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Nhân viên";
            indicator.Top = ((Control)sender).Top;
            frmNhanVien frm = new frmNhanVien();
            openSubForm(frm);
        }

        private void btnNhaCungCap_Click_1(object sender, EventArgs e)
        {
            lblHeader.Text = "Nhà cung cấp";
            indicator.Top = ((Control)sender).Top;
            frmNhaCungCap frm = new frmNhaCungCap();
            openSubForm(frm);
        }

        private void btnKho_Click_1(object sender, EventArgs e)
        {
            lblHeader.Text = "Quản lý kho";
            indicator.Top = ((Control)sender).Top;
            frmQuanLyKho frm = new frmQuanLyKho();
            openSubForm(frm);
        }

        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            lblHeader.Text = "Sản phẩm";
            indicator.Top = ((Control)sender).Top;
            frmHangHoa n = new frmHangHoa();
            openSubForm(n);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Báo cáo";
            indicator.Top = ((Control)sender).Top;
        }
    }
}