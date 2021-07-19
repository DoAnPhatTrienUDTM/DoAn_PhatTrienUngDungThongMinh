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
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        QL_NhomNguoiDung nhomNguoiDung = new QL_NhomNguoiDung();
        PhanQuyen_BLL_DAL phanQuyen = new PhanQuyen_BLL_DAL();
        DanhMucMH_BLL_DAL mh = new DanhMucMH_BLL_DAL();
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadData()
        {
            grvNhomNguoiDung.DataSource = nhomNguoiDung.loadDataNhomNguoiDung();
            //grvPhanQuyen.DataSource = phanQuyen.loadPhanQuyen_Join();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }


        public void loadData_Bindings()
        {
            string _strIDNhom = grvNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
            if (phanQuyen.kiemTraID_Nhom(_strIDNhom) == false)
            {
                grvPhanQuyen.DataSource = phanQuyen.loadphanQuyen_Join(_strIDNhom);
            }
            else
            {
                grvPhanQuyen.DataSource = phanQuyen.loadPhanQuyen();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _strIDNhom = grvNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
            try
            {
                foreach (DataGridViewRow item in grvPhanQuyen.Rows)
                {
                    if (phanQuyen.kiemTraKhoaChinh_PhanQuyen(_strIDNhom, int.Parse(item.Cells[0].Value.ToString())) == 0)
                    {
                        try
                        {
                            phanQuyen.themPhanQuyen(_strIDNhom, int.Parse(item.Cells[0].Value.ToString()), (bool)(item.Cells[2].Value));
                        }
                        catch
                        {
                            phanQuyen.themPhanQuyen(_strIDNhom, int.Parse(item.Cells[0].Value.ToString()), false);
                        }
                    }
                    else if (phanQuyen.kiemTraKhoaChinh_PhanQuyen(_strIDNhom, int.Parse(item.Cells[0].Value.ToString())) == 1)
                    {
                        phanQuyen.updatePhanQuyen(_strIDNhom, int.Parse(item.Cells[0].Value.ToString()), (bool)(item.Cells[2].Value));
                    }
                    else
                    {
                        return;
                    }
                }
                this.Alert("Lưu thành công!", frmNotificationCustom.enmType.Success);
            }
            catch
            {
                this.Alert("Lưu thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void grvNhomNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            loadData_Bindings();
        }
    }
}