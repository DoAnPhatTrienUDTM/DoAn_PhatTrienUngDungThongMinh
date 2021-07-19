using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CTPX_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public bool insert_CTPX(int idkho, int idpx, int idsp, int soluong, int gianhap, int thanhtien)
        {
            try
            {
                CHITIETPHIEUXUAT insert = new CHITIETPHIEUXUAT();
                TONKHO tonkho = quanLyKho.TONKHOs.SingleOrDefault(n => n.ID_KHO == idkho && n.ID_SP == idsp);
                insert.ID_PX = idpx;
                insert.ID_SP = idsp;
                insert.SOLUONG = soluong;
                insert.DONGIA = (float)gianhap;
                insert.THANHTIEN = (float)thanhtien;
                quanLyKho.CHITIETPHIEUXUATs.InsertOnSubmit(insert);
                tonkho.SOLUONGTON = tonkho.SOLUONGTON - soluong;
                quanLyKho.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public IQueryable get_CTPX(int idpx)
        {
            return quanLyKho.CHITIETPHIEUXUATs.Where(n => n.ID_PX == idpx);
        }
        public float get_TB_Xuat(int idkho, int idsp)
        {
            DateTime now = DateTime.Now.Date;
            int tong = 0;
            for (int i = 0; i <= 7; i++)
            {
                try
                {
                    int k = (int)quanLyKho.CHITIETPHIEUXUATs.Where(n => n.PHIEUXUAT.NGUOIDUNG.ID_KHO == idkho && n.ID_SP == idsp && n.PHIEUXUAT.NGAYLAP == now.AddDays(-i)).Sum(n => n.SOLUONG);
                    tong += k;
                }
                catch
                {
                    tong += 0;
                }
            }
            return (float)tong / 7;
        }
    }
}
