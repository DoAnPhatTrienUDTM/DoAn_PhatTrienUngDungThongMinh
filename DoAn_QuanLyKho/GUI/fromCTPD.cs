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
    public partial class fromCTPD : Form
    {
        PhieuDat_BLL_DAL phieudat_bll = new PhieuDat_BLL_DAL();
        CTPD_BLL_DAL ctpd = new CTPD_BLL_DAL();
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();
        public PHIEUDAT phieudat = new PHIEUDAT();
        public bool vitri;
        public fromCTPD()
        {
            InitializeComponent();
            
        }

        private void fromCTPD_Load(object sender, EventArgs e)
        {
            
            lblmapd.Text = phieudat.ID_PD.ToString();
            lblngaylap.Text = phieudat.NGAYLAP.Value.Date.ToShortDateString();
            lblnv.Text = phieudat.NGUOIDUNG.TEN;
            Load_CTPD(ctpd.get_CTPD(phieudat.ID_PD));
           
            
        }
        public void Load_PD_CTPD()
        {
            gridPDat.Rows.Clear();
            gridPDat.Refresh();
            if (vitri)
            {
                gridPDat.DataSource = phieudat_bll.get_ALL_PD_CTPD();
            }
            else
            {
                gridPDat.DataSource = phieudat_bll.get_PD_CTPD(Program.main.nd.ID_KHO);
            }
        }
        public void Load_CTPD(IQueryable dsctpd)
        {
            gridCTPD.Rows.Clear();
            gridCTPD.Refresh();
            int dem = 1;
            foreach (CHITIETPHIEUDAT ctpd in dsctpd)
            {
                gridCTPD.Rows.Add(dem.ToString(), ctpd.SANPHAM.TENSP, ctpd.SOLUONG, ctpd.SANPHAM.DONGIA, (ctpd.SOLUONG * ctpd.SANPHAM.DONGIA));
                dem++;
            }
        }
        //public void load_cbbsp(int idncc)
        //{
        //    cbbsp.DataSource = hanghoa.get_sp_ncc(idncc);
        //    cbbsp.DisplayMember = "tensp";
        //    cbbsp.ValueMember = "idsp";
        //}
        //public void load_cbbspcl()
        //{
        //    IQueryable dsspcl = ctpd.get_SPCL(ctpd.get_CTPD(phieudat.ID_PD),ctpd.get_SP_NCC((int)phieudat.ID_NCC));
        //    cbbsp.DataSource = null;
        //    cbbsp.DataSource = dsspcl;
        //    cbbsp.DisplayMember = "TENSP";
        //    cbbsp.ValueMember = "ID_SP";
        //}

        private void gridPDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            phieudat = phieudat_bll.getPD(int.Parse(gridPDat.CurrentRow.Cells[0].Value.ToString()));
            Load_CTPD(ctpd.get_CTPD(phieudat.ID_PD));
            lblmapd.Text = phieudat.ID_PD.ToString();
            lblngaylap.Text = phieudat.NGAYLAP.Value.Date.ToShortDateString();
            lblnv.Text = phieudat.NGUOIDUNG.TEN;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow row = (DataGridViewRow)gridCTPD.Rows[0].Clone();
            row.Cells[0].Value = (gridCTPD.Rows.Count + 1).ToString();
            gridCTPD.Rows.Add(row);
        }

        private void gridCTPD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keysearch = txtSearch.Text;
            gridPDat.Rows.Clear();
            gridPDat.Refresh();
            if (vitri)
            {
                gridPDat.DataSource = phieudat_bll.get_ALL_PD_CTPD_search(keysearch);
            }
            else
            {
                gridPDat.DataSource = phieudat_bll.get_PD_CTPD_search(Program.main.nd.ID_KHO,keysearch);
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            DateTime date = bunifuDatepicker1.Value.Date;

            if (vitri)
            {
                gridPDat.DataSource = phieudat_bll.get_ALL_PD_CTPD_date(date);
            }
            else
            {
                gridPDat.DataSource = phieudat_bll.get_PD_CTPD_date(Program.main.nd.ID_KHO,date);
            }
        }
    }
}
