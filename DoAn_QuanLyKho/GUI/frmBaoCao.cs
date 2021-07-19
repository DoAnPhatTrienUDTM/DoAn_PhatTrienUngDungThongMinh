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
    public partial class frmBaoCao : DevExpress.XtraEditors.XtraForm
    {
        PhieuNhap_BLL_DAL phieunhap = new PhieuNhap_BLL_DAL();
        PhieuXuat_BLL_DAL phieuxuat = new PhieuXuat_BLL_DAL();
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();

        public frmBaoCao()
        {
            InitializeComponent();
        }

        public void load_Data(int idkho)
        {
            int dem = 1;
            DateTime now = DateTime.Now.Date;
            int songay = (int)DateTime.Now.DayOfWeek;
            for (int i = songay - 1; i >= 0; i--)
            {
                DateTime now1 = now.AddDays(-i);
                int tongnhap = phieunhap.get_tongtienngay(Program.main.nd.ID_KHO, now1);
                int tongxuat = phieuxuat.get_tongtienngay(Program.main.nd.ID_KHO, now1);
                chart1.Series["tongtienxuat"].Points.AddXY(now1.ToShortDateString(), tongxuat);
                chart1.Series["tongtiennhap"].Points.AddXY("", tongnhap);
            }
            while (songay < 7)
            {

                DateTime now1 = now.AddDays(dem);
                chart1.Series["tongtienxuat"].Points.AddXY(now1.ToShortDateString(), 0);
                chart1.Series["tongtiennhap"].Points.AddXY("", 0);
                songay++;
                dem++;
            }
        }

        public void Load_gridsp(int idkho)
        {
            gridmostSP.Rows.Clear();
            gridmostSP.Refresh();
            var dssp = hanghoa.get_SPXuatNhieu(idkho);
            sapxepgiam(dssp);
            if (dssp.Count <= 10)
            {
                foreach (SPXuatNhieu item in dssp)
                {
                    SANPHAM sp = hanghoa.get_sp(item.Id);
                    gridmostSP.Rows.Add(sp.TENSP, item.Soluong);
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    SANPHAM sp = hanghoa.get_sp(dssp[i].Id);
                    gridmostSP.Rows.Add(sp.TENSP, dssp[i].Soluong);
                }
            }

        }

        public void sapxepgiam(List<SPXuatNhieu> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j].Soluong > list[i].Soluong)
                    {
                        SPXuatNhieu sp = new SPXuatNhieu();
                        sp = list[i];
                        list[i] = list[j];
                        list[j] = sp;
                    }
                }
            }
        }
        public void load_Data_Label(int idkho)
        {
            int month = DateTime.Now.Month;
            lblsoPN.Text = phieunhap.get_Count(Program.main.nd.ID_KHO, month).ToString() + " Phiếu";
            lblsoPX.Text = phieuxuat.get_Count(Program.main.nd.ID_KHO, month).ToString() + " Phiếu";
            lblTongTienNhap.Text = phieunhap.get_SumTongTien(Program.main.nd.ID_KHO, month).ToString() + " VNĐ";
            lblTongTienXuat.Text = phieuxuat.get_SumTongTien(Program.main.nd.ID_KHO, month).ToString() + " VNĐ";

        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            load_Data(Program.main.nd.ID_KHO);
            Load_gridsp(Program.main.nd.ID_KHO);
            load_Data_Label(Program.main.nd.ID_KHO);
        }
    }
}