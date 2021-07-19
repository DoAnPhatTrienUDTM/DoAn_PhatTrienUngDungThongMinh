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
using System.IO;
using Custom_Control;

namespace GUI
{
    public partial class frmCapNhatTT : DevExpress.XtraEditors.XtraForm
    {
        Check_Login login = new Check_Login();
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        QL_NguoiDungNhomNguoiDung_BLL_DAL nguoiDung = new QL_NguoiDungNhomNguoiDung_BLL_DAL();
        //Initialize load file
        OpenFileDialog open = new OpenFileDialog();
        string maNV;
        public frmCapNhatTT(string manv)
        {
            maNV = manv;
            InitializeComponent();
        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCapNhatTT_Load(object sender, EventArgs e)
        {
            getData();
            lblChucVu.Text = nguoiDung.getRole(maNV);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtPass.Enabled = true;
            txtHoVaTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            dateNgaySinh.Enabled = true;
            btnLuu.Enabled = true;
            btnLoadAnh.Enabled = true;
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtHoVaTen.Text.ToString();
            string sdt = txtSoDT.Text.ToString();
            DateTime ngaysinh = dateNgaySinh.Value;
            string diachi = txtDiaChi.Text.ToString();
            string pass = txtPass.Text.ToString();
            string picture = "";
            if (lblTenFile.Text == "")
            {
                picture = null;
            }
            else
            {
                picture = lblTenFile.Text;
            }

            string gioitinh = "Nam";
            if (rdoNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {

                gioitinh = "Nữ";
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn lưu thay đổi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtUsername.Text.Length != 0)
                {
                    if (txtHoVaTen.Text.Length != 0 && txtDiaChi.Text.Length != 0 && txtSoDT.Text.Length != 0)
                    {
                        bool check = nv.updateInfo(maNV, ten, sdt, diachi, ngaysinh, gioitinh, pass, picture);
                        if (check)
                        {
                            this.Alert("Cập nhật thành công!", frmNotificationCustom.enmType.Success);
                            try
                            {
                                File.Copy(lblFullPath.Text, Application.StartupPath + "\\img\\" + lblTenFile.Text, true);
                            }
                            catch
                            {
                                //MessageBox.Show("Không thể lưu file ảnh này!");
                                this.Alert("Không thể lưu file ảnh này!", frmNotificationCustom.enmType.Error);
                            }
                        }
                        else
                        {

                            this.Alert("Cập nhật không thành công!", frmNotificationCustom.enmType.Error);
                        }
                    }
                }
                else
                {

                    this.Alert("Lỗi cập nhât!", frmNotificationCustom.enmType.Warning);
                }
            }
        }

        public void getData()
        {
            NGUOIDUNG nd = nv.get_Info(maNV);
            txtUsername.Text = maNV;
            txtDiaChi.Text = nd.DIACHI.ToString();
            txtHoVaTen.Text = nd.TEN.ToString();
            txtSoDT.Text = nd.SDT.ToString();
            txtPass.Text = nd.MATKHAU.ToString();
            dateNgaySinh.Value = (DateTime)nd.NGAYSINH;
            lblTen.Text = "Xin chào " + nd.TEN.ToString() + "!";
            bool? tinhTrang = nd.TINHTRANG;

            if (tinhTrang == true)
            {
                lblTrangThai.Text = "Trạng thái tài khoản: Đang hoạt động";
            }
            else
            {
                lblTrangThai.Text = "Trạng thái tài khoản: Không hoạt động";
            }

            Image img = null;
            if (nd.HINH != null)
            {
                img = Image.FromFile(Application.StartupPath + "\\img\\" + nd.HINH.ToString());
                picNhanVien.Image = img;
            }
            else
            {
                img = Image.FromFile(Application.StartupPath + "\\img\\profile1.png");
                picNhanVien.Image = img;
            }
            if (String.Compare(nd.GIOITINH.ToString(), "NAM", true) == 0)
            {
                rdoNam.Checked = true;
            }
            else
            {

                rdoNu.Checked = true;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            open.Filter = "Choose Image(*.jpg; *.png;*.gif)|*.jpg; *.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picNhanVien.Image = Image.FromFile(open.FileName);
                lblTenFile.Text = System.IO.Path.GetFileName(open.FileName);
                lblFullPath.Text = open.FileName;
            }
            else
            {
                return;
            }
        }
    }
}