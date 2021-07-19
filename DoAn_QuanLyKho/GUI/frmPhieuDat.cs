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
        public bool vitri = false;
        public frmPhieuDat()
        {
            InitializeComponent();
        }

        private void frmPhieuDat_Load(object sender, EventArgs e)
        {
            if (vitri)
            {
                Load_DL(phieuDat.get_ALL());
            }
            else
            {
                Load_DL(phieuDat.get_PD_TheoKho(Program.main.nd.ID_KHO));
            }
           
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
            
            if (vitri)
            {
                Load_DL(phieuDat.get_ALL_PD_date(date));
            }
            else
            {
                Load_DL(phieuDat.get_PD_date(Program.main.nd.ID_KHO, date));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keysearch = txtSearch.Text;
            if (vitri)
            {
                Load_DL(phieuDat.get_All_PD_search(keysearch));
            }
            else
            {
                Load_DL(phieuDat.get_PD_search(Program.main.nd.ID_KHO, keysearch));
            }
           
        }

        private void gridPD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPD = int.Parse(gridPD.CurrentRow.Cells[0].Value.ToString());
            fromCTPD frm = new fromCTPD();
            if (vitri)
            {
                frm.vitri = true;
                frm.phieudat = phieuDat.getPD(idPD);
                frm.Load_PD_CTPD();
                Program.frmquanly.openSubForm(frm);
            }
            else
            {
                frm.vitri = false;
                frm.phieudat = phieuDat.getPD(idPD);
                frm.Load_PD_CTPD();
                Program.main.openSubForm(frm);
            }
            
        }

        private void cbxloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangthai = cbxloaisp.SelectedItem.ToString();
            if (vitri)
            {
                Load_DL(phieuDat.get_All_PD_TrangThai(trangthai));
            }
            else
            {
                Load_DL(phieuDat.get_PD_TrangThai(Program.main.nd.ID_KHO,trangthai));
            }
        }
    }
}
