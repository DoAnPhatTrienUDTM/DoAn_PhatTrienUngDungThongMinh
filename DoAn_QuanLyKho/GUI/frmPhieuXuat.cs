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
    public partial class frmPhieuXuat : Form
    {
        PhieuXuat_BLL_DAL phieuxuat_bll = new PhieuXuat_BLL_DAL();
        PHIEUXUAT phieuxuat = new PHIEUXUAT();
        public bool vitri = false;
        public frmPhieuXuat()
        {
            InitializeComponent();
        }
        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            DateTime date = bunifuDatepicker1.Value.Date;
            if (vitri)
            {
                Load_DL(phieuxuat_bll.get_ALL_PX_date(date));
            }
            else
            {
                Load_DL(phieuxuat_bll.get_PX_date(Program.main.nd.ID_KHO, date));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keysearch = txtSearch.Text;
            if (vitri)
            {
                Load_DL(phieuxuat_bll.get_All_PX_search(keysearch));
            }
            else
            {
                Load_DL(phieuxuat_bll.get_PX_search(Program.main.nd.ID_KHO, keysearch));
            }

        }

        private void gridPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gridPX.CurrentRow.Cells[0].Value.ToString());
            frmCTPX frm = new frmCTPX();
            if (vitri)
            {
                frm.vitri = true;
                frm.phieuxuat = phieuxuat_bll.getPX(id);
                frm.Load_PX_CTPX();
                Program.frmquanly.openSubForm(frm);
            }
            else
            {
                frm.vitri = false;
                frm.phieuxuat = phieuxuat_bll.getPX(id);
                frm.Load_PX_CTPX();
                Program.main.openSubForm(frm);
            }
        }



        public void Load_DL(IQueryable dspd)
        {
            gridPX.Rows.Clear();
            gridPX.Refresh();
            foreach (PHIEUXUAT pd in dspd)
            {
                gridPX.Rows.Add(pd.ID_PX, pd.NGUOIDUNG.TEN, pd.NGAYLAP, pd.TONGTIEN);
            }
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            if (vitri)
            {
                Load_DL(phieuxuat_bll.get_ALL());
            }
            else
            {
                Load_DL(phieuxuat_bll.get_PX_TheoKho(Program.main.nd.ID_KHO));
            }
                
            
        }

        

       
    }
}
