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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        Check_Login login = new Check_Login();
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        QL_NguoiDungNhomNguoiDung_BLL_DAL nguoiDung = new QL_NguoiDungNhomNguoiDung_BLL_DAL();
        PhanQuyen_BLL_DAL phanQuyen = new PhanQuyen_BLL_DAL();
        public string MaNhanVien;

        public NGUOIDUNG nd = new NGUOIDUNG();
        public frmMain()
        {
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

        private void frmMain_Load(object sender, EventArgs e)
        {
           
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

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Trang chủ";
            indicator.Top = ((Control)sender).Top;
            frmTrangChu frm = new frmTrangChu();
            openSubForm(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Nhân viên";
            indicator.Top = ((Control)sender).Top;
            frmNhanVien frm = new frmNhanVien();
            openSubForm(frm);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Nhà cung cấp";
            indicator.Top = ((Control)sender).Top;
            frmNhaCungCap frm = new frmNhaCungCap();
            openSubForm(frm);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Quản lý kho";
            indicator.Top = ((Control)sender).Top;
            frmQuanLyKho frm = new frmQuanLyKho();
            openSubForm(frm);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Sản phẩm";
            indicator.Top = ((Control)sender).Top;
            frmHangHoaTheoKho n = new frmHangHoaTheoKho();
            openSubForm(n);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Báo cáo";
            indicator.Top = ((Control)sender).Top;
            frmBaoCao frm = new frmBaoCao();
            openSubForm(frm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Đặt Hàng";
            indicator.Top = ((Control)sender).Top;
            frmDatHang frm = new frmDatHang();
            openSubForm(frm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Nhập Hàng";
            indicator.Top = ((Control)sender).Top;
            frmNhapHang frm = new frmNhapHang();
            openSubForm(frm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Xuất Hàng";
            indicator.Top = ((Control)sender).Top;
            frmXuatHang frm = new frmXuatHang();
            openSubForm(frm);
        }

        public void loadPhanQuyen()
        {
            foreach (NGUOIDUNGNHOMNGUOIDUNG item in nguoiDung.loadDataNguoiDungNhomNguoiDung_id(MaNhanVien))
            {
                foreach (PHANQUYEN item1 in phanQuyen.load_PhanQuyenFull(item.ID_NHOM))
                {
                    CheckAllButtonChildVisiable(item1.ID_MANHINH);
                }
            }
        }

        private void CheckAllButtonChildVisiable(int tag)
        {
            foreach (System.Windows.Forms.Control bt in panelMenu.Controls)
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

        private void btnnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                //frmLogin frm = new frmLogin();
                //frm.Show();
                //this.Hide();
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Quản lý";
            indicator.Top = ((Control)sender).Top;
            openSubForm(Program.frmquanly);
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
           
        }

        private void mainPanel_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void frmMain_VisibleChanged(object sender, EventArgs e)
        {
            lblHeader.Text = "Trang chủ";
            frmTrangChu frm = new frmTrangChu();
            openSubForm(frm);
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
                Image img = Image.FromFile(Application.StartupPath + "\\img\\profile1.png");
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

        private void button6_Click(object sender, EventArgs e)
        {
            frmPhieuChuyen frm = new frmPhieuChuyen();
            Program.main.openSubForm(frm);
            lblHeader.Text = "Chuyển hàng";
        }

        public void Alert(string msg)
        {
            Custom_Control.frmNotification frm = new frmNotification();
            frm.showAlert(msg);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Alert(null);
        }
    }
}