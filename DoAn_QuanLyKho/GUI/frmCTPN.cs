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
            gridPNhap.DataSource = phieunhnap_bll.get_PN_CTPN(Program.main.nd.ID_KHO);
            lblmapn.Text = phieunhap.ID_PD.ToString();
            lblngaylap.Text = phieunhap.NGAYLAP.Value.Date.ToShortDateString();
            lblnv.Text = phieunhap.NGUOIDUNG.TEN;
            Load_CTPD(ctpn.get_CTPN(phieunhap.ID_PN));
        }

        private void gridPNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            phieunhap = phieunhnap_bll.get_PN(int.Parse(gridPNhap.CurrentRow.Cells[0].Value.ToString()));
            Load_CTPD(ctpn.get_CTPN(phieunhap.ID_PN));
            lblmapn.Text = phieunhap.ID_PN.ToString();
            lblngaylap.Text = phieunhap.NGAYLAP.Value.Date.ToShortDateString();
            lblnv.Text = phieunhap.NGUOIDUNG.TEN;
        }
    }
}
