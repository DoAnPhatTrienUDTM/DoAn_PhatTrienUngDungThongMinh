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
    public partial class frmCTPX : Form
    {
        PhieuXuat_BLL_DAL phieuxuat_bll = new PhieuXuat_BLL_DAL();
        CTPX_BLL_DAL ctpx = new CTPX_BLL_DAL();
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();
        public PHIEUXUAT phieuxuat = new PHIEUXUAT();
        public bool vitri = false;
        public frmCTPX()
        {
            InitializeComponent();
        }
        public void Load_CTPD(IQueryable dsctpd)
        {
            gridCTPX.Rows.Clear();
            gridCTPX.Refresh();
            int dem = 1;
            foreach (CHITIETPHIEUXUAT ctpd in dsctpd)
            {
                gridCTPX.Rows.Add(dem.ToString(), ctpd.SANPHAM.TENSP, ctpd.SOLUONG, ctpd.SANPHAM.DONGIA, ctpd.THANHTIEN);
                dem++;
            }
        }

        private void frmCTPX_Load(object sender, EventArgs e)
        {
            
            lblmapx.Text = phieuxuat.ID_PX.ToString();
            lblngaylap.Text = phieuxuat.NGAYLAP.Value.Date.ToShortDateString();
            lblnv.Text = phieuxuat.NGUOIDUNG.TEN;
            Load_CTPD(ctpx.get_CTPX(phieuxuat.ID_PX));
        }
        public void Load_PX_CTPX()
        {
            if (vitri)
            {
                gridPXuat.DataSource = phieuxuat_bll.get_ALL_PX_CTPX();
            }
            else
            {
                gridPXuat.DataSource = phieuxuat_bll.get_PX_CTPX(Program.main.nd.ID_KHO);
            }
        }
        private void gridPXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            phieuxuat = phieuxuat_bll.getPX(int.Parse(gridPXuat.CurrentRow.Cells[0].Value.ToString()));
            Load_CTPD(ctpx.get_CTPX(phieuxuat.ID_PX));
            lblmapx.Text = phieuxuat.ID_PX.ToString();
            lblngaylap.Text = phieuxuat.NGAYLAP.Value.Date.ToShortDateString();
            lblnv.Text = phieuxuat.NGUOIDUNG.TEN;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keysearch = txtSearch.Text;
            gridPXuat.Rows.Clear();
            gridPXuat.Refresh();
            if (vitri)
            {
                gridPXuat.DataSource = phieuxuat_bll.get_ALL_PX_CTPX_search(keysearch);
            }
            else
            {
                gridPXuat.DataSource = phieuxuat_bll.get_PX_CTPX_search(Program.main.nd.ID_KHO, keysearch);
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            DateTime date = bunifuDatepicker1.Value.Date;
            gridPXuat.Rows.Clear();
            gridPXuat.Refresh();
            if (vitri)
            {
                gridPXuat.DataSource = phieuxuat_bll.get_ALL_PX_CTPX_date(date);
                
            }
            else
            {
                gridPXuat.DataSource = phieuxuat_bll.get_PX_CTPX_date(Program.main.nd.ID_KHO, date);
            }
        }
    }
}
