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
            string gioitinh = "";
            if (rdoNam.Checked)
            {
                gioitinh = "Nam";
                if (nv.themNguoiDung(id_kho, id, ten, sdt, diachi, ngaysinh, gioitinh, pass, picture) == true)
                {
                    frmNhanVien frm = new frmNhanVien();
                    frm.grvNhanVien.DataSource = nv.loadDataNguoiDung();
                    frm.grvNhanVien.Refresh();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        File.Copy(lblFullPath.Text, Application.StartupPath + "\\img\\" + lblFileAnh.Text, true);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể lưu file ảnh này!");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}