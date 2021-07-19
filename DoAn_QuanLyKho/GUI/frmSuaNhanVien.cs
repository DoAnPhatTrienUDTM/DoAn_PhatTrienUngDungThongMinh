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
    public partial class frmSuaNhanVien : DevExpress.XtraEditors.XtraForm
    {

        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        KhoBLL_DAL kho = new KhoBLL_DAL();
        QL_NguoiDungNhomNguoiDung_BLL_DAL nguoiDung = new QL_NguoiDungNhomNguoiDung_BLL_DAL();
        //Initialize load file
        OpenFileDialog open = new OpenFileDialog();
        private BindingSource formDataSource;
        public frmSuaNhanVien(BindingSource dataSource)
        {
            InitializeComponent();
            formDataSource = dataSource;
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("Text", formDataSource, "ID_DN", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            string id = txtUsername.Text;
            string ten = txtHoVaTen.Text.ToString();
            string sdt = txtSoDT.Text.ToString();
            DateTime ngaysinh = dateNgaySinh.Value;
            string diachi = txtDiaChi.Text.ToString();
            string pass = txtPass.Text.ToString();
            string picture = "";
            if (lblFileAnh.Text == "")
            {
                picture = null;
            }
            else
            {
                picture = lblFileAnh.Text;
            }


            string gioitinh = "";
            if (rdoNam.Checked)
            {
                gioitinh = "Nam";
                if (nv.updateInfo(id, ten, sdt, diachi, ngaysinh, gioitinh, pass, picture) == true)
                {
                    frm.grvNhanVien.DataSource = nv.loadDataNguoiDung();
                    frm.grvNhanVien.Refresh();
                    this.Alert("Sửa thành công!", frmNotificationCustom.enmType.Success);
                    try
                    {
                        File.Copy(lblFullPath.Text, Application.StartupPath + "\\img\\" + lblFileAnh.Text, true);
                    }
                    catch
                    {
                        this.Alert("Không thể lưu file ảnh này!", frmNotificationCustom.enmType.Warning);
                    }
                }
                else
                {
                    this.Alert("Sửa thất bại!", frmNotificationCustom.enmType.Error);
                }
            }
            else
            {
                gioitinh = "Nữ";
                if (nv.updateInfo(id, ten, sdt, diachi, ngaysinh, gioitinh, pass, picture) == true)
                {
                    frm.grvNhanVien.DataSource = nv.loadDataNguoiDung();
                    frm.grvNhanVien.Refresh();
                    this.Alert("Sửa thành công!", frmNotificationCustom.enmType.Success);
                    try
                    {
                        File.Copy(lblFullPath.Text, Application.StartupPath + "\\img\\" + lblFileAnh.Text, true);
                    }
                    catch
                    {
                        this.Alert("Không thể lưu file ảnh này!", frmNotificationCustom.enmType.Warning);
                    }
                }
                else
                {
                    this.Alert("Sửa thất bại!", frmNotificationCustom.enmType.Error);
                }
            }
        }

        private void frmSuaNhanVien_Load(object sender, EventArgs e)
        {
            string id = txtUsername.Text;
            NGUOIDUNG nd = nv.get_Info(id);
            txtDiaChi.Text = nd.DIACHI.ToString();
            txtHoVaTen.Text = nd.TEN.ToString();
            txtSoDT.Text = nd.SDT.ToString();
            txtPass.Text = nd.MATKHAU.ToString();
            dateNgaySinh.Value = (DateTime)nd.NGAYSINH;
            bool? tinhTrang = nd.TINHTRANG;

            if (tinhTrang == true)
            {
                lblTrangThai.Text = "Trạng thái tài khoản: Đang hoạt động";
            }
            else
            {
                lblTrangThai.Text = "Trạng thái tài khoản: Không hoạt động";
            }

            lblTen.Text = txtHoVaTen.Text;

            if (String.Compare(nd.GIOITINH.ToString(), "Nam", true) == 0)
            {
                rdoNam.Checked = true;
            }
            else
                rdoNu.Checked = true;

            cboKho.DataSource = kho.loadDataKHo();
            cboKho.DisplayMember = "ID_KHO";
            cboKho.ValueMember = "ID_KHO";

            cboKho.SelectedValue = nd.ID_KHO;
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
    }
}