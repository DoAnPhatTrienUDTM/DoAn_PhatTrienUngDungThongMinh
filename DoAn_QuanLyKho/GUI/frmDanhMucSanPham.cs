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
    public partial class frmDanhMucSanPham : DevExpress.XtraEditors.XtraForm
    {
        NCC_BLL_DAL ncc = new NCC_BLL_DAL();
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();
        DanhMucSP_BLL_DAL danhmucsp = new DanhMucSP_BLL_DAL();
        public frmDanhMucSanPham()
        {
            InitializeComponent();
        }
        public void loadCBXNCC()
        {
            cbxncc.DataSource = ncc.get_NCC();
            cbxncc.DisplayMember = "TENNCC";
            cbxncc.ValueMember = "ID_NCC";
        }
        public void loadCBXSP()
        {
            cbxSP.DataSource = hanghoa.LoadHangHoa();
            cbxSP.DisplayMember = "TENSP";
            cbxSP.ValueMember = "ID_SP";
        }
        public void LoadDL()
        {
            gridDMSP.Rows.Clear();
            gridDMSP.Refresh();
            loadCBXNCC();
            loadCBXSP();
            foreach (DANHMUCSANPHAM item in danhmucsp.get_DM_SP())
            {
                gridDMSP.Rows.Add(item.ID_NCC, item.ID_SP, item.GIABAN);
            }
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void frmDanhMucSanPham_Load(object sender, EventArgs e)
        {
            cboNhaCungCap.DataSource = ncc.get_NCC();
            cboNhaCungCap.DisplayMember = "TENNCC";
            cboNhaCungCap.ValueMember = "ID_NCC";
            cboSanPham.DataSource = hanghoa.LoadHangHoa();
            cboSanPham.DisplayMember = "TENSP";
            cboSanPham.ValueMember = "ID_SP";
            LoadDL();
        }

        private void gridDMSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idncc = int.Parse(gridDMSP.CurrentRow.Cells[0].Value.ToString());
            int idsp = int.Parse(gridDMSP.CurrentRow.Cells[1].Value.ToString());
            int gia = int.Parse(gridDMSP.CurrentRow.Cells[2].Value.ToString());
            cboNhaCungCap.SelectedValue = idncc;
            cboSanPham.SelectedValue = idsp;
            txtGiaBan.Text = gia.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboNhaCungCap.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnluu.Enabled = true;
            txtGiaBan.Text = "";
            cboNhaCungCap.SelectedIndex = -1;
            cboSanPham.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridDMSP.Rows.Count == 0)
            {
                return;
            }
            else
            {
                int idncc = int.Parse(gridDMSP.CurrentRow.Cells[0].Value.ToString());
                int idsp = int.Parse(gridDMSP.CurrentRow.Cells[1].Value.ToString());
                if (danhmucsp.delete_DMSP(idncc, idsp))
                {
                    this.Alert("Xóa thành công!", frmNotificationCustom.enmType.Success);
                    LoadDL();
                }
                else
                {
                    this.Alert("Xóa thất bại!", frmNotificationCustom.enmType.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridDMSP.Rows.Count == 0)
            {
                return;
            }
            else
            {
                int idncc = int.Parse(gridDMSP.CurrentRow.Cells[0].Value.ToString());
                int idsp = int.Parse(gridDMSP.CurrentRow.Cells[1].Value.ToString());
                int idspmoi = int.Parse(cboSanPham.SelectedValue.ToString());
                int gia = int.Parse(txtGiaBan.Text);
                if (danhmucsp.update_DMSP(idncc, idsp,idspmoi,gia))
                {
                    this.Alert("Sửa thành công!", frmNotificationCustom.enmType.Success);
                    LoadDL();
                }
                else
                {
                    this.Alert("Sửa thất bại!", frmNotificationCustom.enmType.Error);
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            int idncc = int.Parse(cboNhaCungCap.SelectedValue.ToString());
            int idspmoi = int.Parse(cboSanPham.SelectedValue.ToString());
            int gia = int.Parse(txtGiaBan.Text);
            if (danhmucsp.insert_DMSP(idncc, idspmoi, gia))
            {
                this.Alert("Thêm thành công!", frmNotificationCustom.enmType.Success);
                LoadDL();
            }
            else
            {
                this.Alert("Thêm thất bại!", frmNotificationCustom.enmType.Error);
            }
            cboNhaCungCap.Enabled = false;
            btnluu.Enabled = false;
            btnSua.Enabled =true;
            btnXoa.Enabled = true;
            txtGiaBan.Text = "";
        }
    }
}