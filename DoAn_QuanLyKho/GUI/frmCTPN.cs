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
    public partial class frmCTPN : Form
    {
        PhieuNhap_BLL_DAL phieunhnap_bll = new PhieuNhap_BLL_DAL();
        CTPN_BLL_DAL ctpn = new CTPN_BLL_DAL();
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();
        public PHIEUNHAP phieunhap = new PHIEUNHAP();
        public bool vitri = false;
        public frmCTPN()
        {
            InitializeComponent();
        }
        public void Load_CTPD(IQueryable dsctpd)
        {
            gridCTPN.Rows.Clear();
            gridCTPN.Refresh();
            int dem = 1;
            foreach (CHITIETPHIEUNHAP ctpd in dsctpd)
            {
                gridCTPN.Rows.Add(dem.ToString(), ctpd.SANPHAM.TENSP, ctpd.SOLUONG, ctpd.SANPHAM.DONGIA,ctpd.THANHTIEN);
                dem++;
            }
        }

        private void frmCTPN_Load(object sender, EventArgs e)
        {
            
            lblmapn.Text = phieunhap.ID_PD.ToString();
            lblngaylap.Text = phieunhap.NGAYLAP.Value.Date.ToShortDateString();
            lblnv.Text = phieunhap.NGUOIDUNG.TEN;
            Load_CTPD(ctpn.get_CTPN(phieunhap.ID_PN));
        }
        public void Load_PN_CTPN()
        {
            if (vitri)
            {
                gridPNhap.DataSource = phieunhnap_bll.get_ALL_PN_CTPN(); ;
            }
            else
            {
                gridPNhap.DataSource = phieunhnap_bll.get_PN_CTPN(Program.main.nd.ID_KHO);
            }
        }
        private void gridPNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            phieunhap = phieunhnap_bll.get_PN(int.Parse(gridPNhap.CurrentRow.Cells[0].Value.ToString()));
            Load_CTPD(ctpn.get_CTPN(phieunhap.ID_PN));
            lblmapn.Text = phieunhap.ID_PN.ToString();
            lblngaylap.Text = phieunhap.NGAYLAP.Value.Date.ToShortDateString();
            lblnv.Text = phieunhap.NGUOIDUNG.TEN;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keysearch = txtSearch.Text;
            gridPNhap.Rows.Clear();
            gridPNhap.Refresh();
            if (vitri)
            {
                gridPNhap.DataSource = phieunhnap_bll.get_ALL_PN_CTPN_search(keysearch);
            }
            else
            {
                gridPNhap.DataSource = phieunhnap_bll.get_PN_CTPN_search(Program.main.nd.ID_KHO,keysearch);
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            DateTime date = bunifuDatepicker1.Value.Date;
            gridPNhap.Rows.Clear();
            gridPNhap.Refresh();
            if (vitri)
            {
                gridPNhap.DataSource = phieunhnap_bll.get_ALL_PN_CTPN_date(date);
            }
            else
            {
                gridPNhap.DataSource = phieunhnap_bll.get_PN_CTPN_date(Program.main.nd.ID_KHO, date);
            }
        }
    }
}
