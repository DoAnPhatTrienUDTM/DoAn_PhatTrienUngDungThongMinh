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
    public partial class frmPhieuChuyen : Form
    {
        YCChuyenHang_BLL_DAL ycch = new YCChuyenHang_BLL_DAL();
        public frmPhieuChuyen()
        {
            InitializeComponent();
        }

        public void Load_DL()
        {
            gridPC.Rows.Clear();
            gridPC.Refresh();
            foreach (YEUCAUCHUYENHANG item in ycch.get_PC())
            {
                gridPC.Rows.Add(item.ID_PC, item.ID_KHO, item.NGUOIDUNG.TEN, item.NGAYLAP,item.TINHTRANG);
            }
        }

        private void frmPhieuChuyen_Load(object sender, EventArgs e)
        {
            Load_DL();
        }

        private void btnChuyenHang_Click(object sender, EventArgs e)
        {
            if (gridPC.Rows.Count == 0)
            {
                return;
            }
            else
            {
                YEUCAUCHUYENHANG yc = ycch.get_PC(int.Parse(gridPC.CurrentRow.Cells[0].Value.ToString()));
                frmChuyenHang frm = new frmChuyenHang();
                frm.ycch = yc;
                Program.main.openSubForm(frm);
            }
        }
    }
}
