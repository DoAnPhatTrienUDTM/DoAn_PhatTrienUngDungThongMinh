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
    public partial class frmXemPhieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        ChuyenHang_BLL_DAL chuyenhang = new ChuyenHang_BLL_DAL();
        public frmXemPhieuChuyen()
        {
            InitializeComponent();
        }

        private void frmXemPhieuChuyen_Load(object sender, EventArgs e)
        {
            grvPhieuChuyen.DataSource = chuyenhang.loadDataPhieuChuyen();
        }

        private void grvPhieuChuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grvChiTietPhieuChuyen.DataSource = chuyenhang.loadDataChiTietPhieuChuyen(int.Parse(grvPhieuChuyen.CurrentRow.Cells[0].Value.ToString()));
        }
    }
}