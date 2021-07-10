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
    public partial class frmCapNhatTT : DevExpress.XtraEditors.XtraForm
    {
        Check_Login login = new Check_Login();
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
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
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtPass.Enabled = true;
            txtHoVaTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            dateNgaySinh.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtHoVaTen.Text.ToString();
            string sdt = txtSoDT.Text.ToString();
            DateTime ngaysinh = dateNgaySinh.Value;
            string diachi = txtDiaChi.Text.ToString();
            string pass = txtPass.Text.ToString();
            string gioitinh = "Nam";
            if (rdoNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
                gioitinh = "Nữ";


            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtUsername.Text.Length != 0)
                {
                    if (txtHoVaTen.Text.Length != 0 && txtDiaChi.Text.Length != 0 && txtSoDT.Text.Length != 0)
                    {
                        bool check = nv.updateInfo(maNV, ten, sdt, diachi, ngaysinh, gioitinh, pass);
                        if (check)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                        }
                        else
                            MessageBox.Show("Cập nhật không thành công!");
                    }
                }
                else
                    MessageBox.Show("Lỗi cập nhật!");
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

            if(tinhTrang == true)
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
                img = Image.FromFile(Application.StartupPath + "\\img\\user_32x322.png");
                picNhanVien.Image = img;
            }
            if (String.Compare(nd.GIOITINH.ToString(), "NAM", true) == 0)
            {
                rdoNam.Checked = true;
            }
            else
                rdoNu.Checked = true;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}