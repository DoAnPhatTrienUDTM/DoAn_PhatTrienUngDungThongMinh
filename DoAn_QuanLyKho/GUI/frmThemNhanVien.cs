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
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        KhoBLL_DAL kho = new KhoBLL_DAL();
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
            string gioitinh = "";
            if(rdoNam.Checked)
            {
                gioitinh = "Nam";
                if(nv.themNguoiDung(id_kho, id, ten, sdt, diachi, ngaysinh, gioitinh, pass) == true)
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
            else
            {
                gioitinh = "Nữ";
                if (nv.themNguoiDung(id_kho, id, ten, sdt, diachi, ngaysinh, gioitinh, pass) == true)
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
    }
}