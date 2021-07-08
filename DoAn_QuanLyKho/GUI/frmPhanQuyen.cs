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
            grvPhanQuyen.DataSource = mh.loadDataDanhMucMH();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string idNhom = grvNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
            int idManHinh = int.Parse(grvPhanQuyen.CurrentRow.Cells[0].Value.ToString());
            bool coQuyen = (bool)grvPhanQuyen.CurrentRow.Cells[2].Value;
            if (phanQuyen.luuPhanQuyen(idNhom, idManHinh, coQuyen) == true)
            {
                //grvPhanQuyen.DataSource = phanQuyen.loadPhanQuyen_Join();
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}