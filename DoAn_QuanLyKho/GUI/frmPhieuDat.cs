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
    public partial class frmPhieuDat : Form
    {
        PhieuDat_BLL_DAL phieuDat = new PhieuDat_BLL_DAL();
        public int idPD;
        public frmPhieuDat()
        {
            InitializeComponent();
        }

        private void frmPhieuDat_Load(object sender, EventArgs e)
        {
            Load_DL(phieuDat.get_PD_TheoKho(Program.main.nd.ID_KHO));
        }
        public void Load_DL(IQueryable dspd)
        {
            gridPD.Rows.Clear();
            gridPD.Refresh();
            foreach(PHIEUDAT pd in dspd)
            {
                gridPD.Rows.Add(pd.ID_PD, pd.NHACUNGCAP.TENNCC, pd.NGUOIDUNG.TEN, pd.NGAYLAP, pd.TONGTIEN, pd.TINHTRANG);
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            DateTime date = bunifuDatepicker1.Value.Date;
            Load_DL(phieuDat.get_PD_date(Program.main.nd.ID_KHO, date));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keysearch = txtSearch.Text;
            Load_DL(phieuDat.get_PD_search(Program.main.nd.ID_KHO, keysearch));
        }

        private void gridPD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPD = int.Parse(gridPD.CurrentRow.Cells[0].Value.ToString());
            fromCTPD frm = new fromCTPD();
            frm.phieudat = phieuDat.getPD(idPD);
            Program.main.openSubForm(frm);
        }
    }
}
