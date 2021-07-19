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
    public partial class frmPhieuNhap : Form
    {
        PhieuNhap_BLL_DAL phieunhap_bll = new PhieuNhap_BLL_DAL();
        PHIEUNHAP phieunhap = new PHIEUNHAP();
        public bool vitri = false;
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            DateTime date = bunifuDatepicker1.Value.Date;
            if (vitri)
            {
                Load_DL(phieunhap_bll.get_ALL_PN_date(date));
            }
            else
            {
                Load_DL(phieunhap_bll.get_PN_date(Program.main.nd.ID_KHO, date));
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keysearch = txtSearch.Text;
            if (vitri)
            {
                Load_DL(phieunhap_bll.get_All_PN_search(keysearch));
            }
            else
            {
                Load_DL(phieunhap_bll.get_PN_search(Program.main.nd.ID_KHO, keysearch));
            }
           
        }

        private void gridPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gridPN.CurrentRow.Cells[0].Value.ToString());
            frmCTPN frm = new frmCTPN();
            if (vitri)
            {
                frm.vitri = true;
                frm.phieunhap = phieunhap_bll.get_PN(id);
                frm.Load_PN_CTPN();
                Program.frmquanly.openSubForm(frm);
            }
            else
            {
                frm.vitri = false;
                frm.phieunhap = phieunhap_bll.get_PN(id);
                frm.Load_PN_CTPN();
                Program.main.openSubForm(frm);
            }
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            if (vitri)
            {
                Load_DL(phieunhap_bll.get_ALL());
            }
            else
            {
                Load_DL(phieunhap_bll.get_PN_TheoKho(Program.main.nd.ID_KHO));
            }
           
        }
        public void Load_DL(IQueryable dspd)
        {
            gridPN.Rows.Clear();
            gridPN.Refresh();
            foreach (PHIEUNHAP pd in dspd)
            {
                gridPN.Rows.Add(pd.ID_PN,pd.ID_PD, pd.NHACUNGCAP.TENNCC, pd.NGUOIDUNG.TEN, pd.NGAYLAP, pd.TONGTIEN);
            }
        }

    }
}
