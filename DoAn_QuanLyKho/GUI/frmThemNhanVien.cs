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
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        KhoBLL_DAL kho = new KhoBLL_DAL();
        DefendPassword mk = new DefendPassword();
        //Initialize load file
        OpenFileDialog open = new OpenFileDialog();
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        public bool kiemTraChuoiSo(string strChuoiSo)
        {
            try
            {
                Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
                return regex.IsMatch(strChuoiSo);
            }
            catch
            {
                return false;
            }
        }

        public bool kiemTraTuoi(DateTime birth)
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int ngaysinh = int.Parse(birth.ToString("yyyyMMdd"));
            int age = (now - ngaysinh) / 10000;

            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            int id_kho = int.Parse(cboKho.SelectedValue.ToString());
            string id = txtUsername.Text;
            string ten = txtHoVaTen.Text;
            string sdt = txtSoDT.Text;
            string diachi = txtDiaChi.Text;
            DateTime ngaysinh = dateNgaySinh.Value;
            string pass = txtPass.Text;
            string picture = "";
            if (lblFileAnh.Text == "")
            {
                picture = null;
            }
            else
            {
                picture = lblFileAnh.Text;
            }
            if (txtUsername.Text == "")
            {
                this.Alert("Không được để trống Username!", frmNotificationCustom.enmType.Warning);
                txtUsername.Focus();
            }
            else if (txtHoVaTen.Text == "")
            {
                this.Alert("Không được để trống họ và tên!", frmNotificationCustom.enmType.Warning);
                txtHoVaTen.Focus();
            }
            else if (txtSoDT.Text == "")
            {
                this.Alert("Không được để trống số điện thoại!", frmNotificationCustom.enmType.Warning);
                txtSoDT.Focus();
            }
            else if (txtDiaChi.Text == "")
            {
                this.Alert("Không được để trống địa chỉ!", frmNotificationCustom.enmType.Warning);
                txtDiaChi.Focus();
            }
            else if (txtPass.Text == "")
            {
                this.Alert("Không được để trống mật khẩu!", frmNotificationCustom.enmType.Warning);
                txtPass.Focus();
            }
            else
            {
                if (kiemTraTuoi(dateNgaySinh.Value) == false)
                {
                    this.Alert("Phải đủ 18 tuổi trở lên!", frmNotificationCustom.enmType.Warning);
                }
                else
                {
                    string gioitinh = "";
                    if (rdoNam.Checked)
                    {
                        gioitinh = "Nam";
                        if (nv.themNguoiDung(id_kho, id, ten, sdt, diachi, ngaysinh, gioitinh, pass, picture) == true)
                        {
                            frmNhanVien frm = new frmNhanVien();
                            frm.grvNhanVien.DataSource = nv.loadDataNguoiDung();
                            frm.grvNhanVien.Refresh();
                            this.Alert("Thêm thành công!", frmNotificationCustom.enmType.Success);
                            try
                            {
                                File.Copy(lblFullPath.Text, Application.StartupPath + "\\img\\" + lblFileAnh.Text, true);
                            }
                            catch
                            {
                                this.Alert("Không thể lưu file ảnh này!!", frmNotificationCustom.enmType.Warning);
                            }
                        }
                        else
                        {
                            this.Alert("Thêm thất bại!", frmNotificationCustom.enmType.Error);
                        }
                    }
                    else
                    {
                        gioitinh = "Nữ";
                        if (nv.themNguoiDung(id_kho, id, ten, sdt, diachi, ngaysinh, gioitinh, pass, picture) == true)
                        {
                            frmNhanVien frm = new frmNhanVien();
                            frm.grvNhanVien.DataSource = nv.loadDataNguoiDung();
                            frm.grvNhanVien.Refresh();
                            this.Alert("Thêm thành công!", frmNotificationCustom.enmType.Success);
                            try
                            {
                                File.Copy(lblFullPath.Text, Application.StartupPath + "\\img\\" + lblFileAnh.Text, true);
                            }
                            catch
                            {
                                this.Alert("Không thể lưu file ảnh này!!", frmNotificationCustom.enmType.Warning);
                            }
                        }
                        else
                        {
                            this.Alert("Thêm thất bại!", frmNotificationCustom.enmType.Error);
                        }
                    }
                }
            }
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            cboKho.DataSource = kho.loadDataKHo();
            cboKho.DisplayMember = "ID_KHO";
            cboKho.ValueMember = "ID_KHO";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNhanVien frm = new frmNhanVien();
            frm.Refresh();
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            open.Filter = "Choose Image(*.jpg; *.png;*.gif)|*.jpg; *.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picNhanVien.Image = Image.FromFile(open.FileName);
                lblFileAnh.Text = System.IO.Path.GetFileName(open.FileName);
                lblFullPath.Text = open.FileName;
            }
            else
            {
                return;
            }
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}