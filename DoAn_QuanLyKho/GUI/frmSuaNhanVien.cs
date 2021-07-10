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
    public partial class frmSuaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        KhoBLL_DAL kho = new KhoBLL_DAL();
        private BindingSource formDataSource;
        public frmSuaNhanVien(BindingSource dataSource)
        {
            InitializeComponent();
            formDataSource = dataSource;
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("Text", formDataSource, "ID_DN", true, DataSourceUpdateMode.OnPropertyChanged);
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
            string gioitinh = "";
            if (rdoNam.Checked)
            {
                gioitinh = "Nam";
                if(nv.updateInfo(id, ten, sdt, diachi, ngaysinh, gioitinh, pass) == true)
                {
                    frm.grvNhanVien.DataSource = nv.loadDataNguoiDung();
                    frm.grvNhanVien.Refresh();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                gioitinh = "Nữ";
                if (nv.updateInfo(id, ten, sdt, diachi, ngaysinh, gioitinh, pass) == true)
                {
                    frm.grvNhanVien.DataSource = nv.loadDataNguoiDung();
                    frm.grvNhanVien.Refresh();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}