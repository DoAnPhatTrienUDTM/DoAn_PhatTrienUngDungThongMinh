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
    public partial class frmLoaiSanPham : DevExpress.XtraEditors.XtraForm
    {
        LoaiSanPham_BLL_DAL loaisp = new LoaiSanPham_BLL_DAL();
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        public void loadDL()
        {
            gridloaisp.Rows.Clear();
            gridloaisp.Refresh();
            gridloaisp.DataSource = loaisp.loadLoaiSP();
        }


        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void btnThemlsp_Click(object sender, EventArgs e)
        {
            if (loaisp.insert_LoaiSP(txtTenLoai.Text))
            {
                this.Alert("Thêm thành công!", frmNotificationCustom.enmType.Success);
                loadDL();
            }
            else
            {
                this.Alert("Thêm thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void btnXoalsp_Click(object sender, EventArgs e)
        {
            if (gridloaisp.Rows.Count == 0)
            {
                return;
            }
            else
            {
                int id = int.Parse(gridloaisp.CurrentRow.Cells[0].Value.ToString());
                if (loaisp.delete_LoaiSP(id))
                {
                    this.Alert("Xóa thành công!", frmNotificationCustom.enmType.Success);
                    loadDL();
                }
                else
                {
                    this.Alert("Xóa thất bại!", frmNotificationCustom.enmType.Error);
                }
            }
        }

        private void btnSualsp_Click(object sender, EventArgs e)
        {
            if (gridloaisp.Rows.Count == 0)
            {
                return;
            }
            else
            {
                int id = int.Parse(gridloaisp.CurrentRow.Cells[0].Value.ToString());
                if (txtTenLoai.Text.Equals(""))
                {
                    this.Alert("Không được để trống tên sản phẩm!", frmNotificationCustom.enmType.Warning);
                    return;
                }
                if (loaisp.update_LoaiSP(id,txtTenLoai.Text))
                {
                    this.Alert("Sửa thành công!", frmNotificationCustom.enmType.Success);
                    loadDL();
                }
                else
                {
                    this.Alert("Sửa thất bại!", frmNotificationCustom.enmType.Error);
                }
            }
        }

        private void gridloaisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = gridloaisp.CurrentRow.Cells[0].Value.ToString();
            txtTenLoai.Text = gridloaisp.CurrentRow.Cells[1].Value.ToString();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            loadDL();
        }
    }
}