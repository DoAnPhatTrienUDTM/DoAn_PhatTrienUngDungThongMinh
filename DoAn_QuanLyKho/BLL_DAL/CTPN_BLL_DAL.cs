using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CTPN_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public int get_SP_DANHAP(int idpd, int idsp)
        {
            int tong = 0;
            try
            {
                tong = (int)quanLyKho.CHITIETPHIEUNHAPs.Where(n => n.PHIEUNHAP.ID_PD == idpd && n.ID_SP == idsp).Sum(n => n.SOLUONG);
            }
            catch
            {
            }
            return tong;
        }
        public bool insert_CTPN(int idkho, int idpn, int idsp, int soluong, int gianhap, int thanhtien)
        {
            try
            {
                CHITIETPHIEUNHAP insert = new CHITIETPHIEUNHAP();
                TONKHO tonkho = quanLyKho.TONKHOs.SingleOrDefault(n => n.ID_KHO == idkho && n.ID_SP == idsp);
                insert.ID_PN = idpn;
                insert.ID_SP = idsp;
                insert.SOLUONG = soluong;
                insert.DONGIANHAP = (float)gianhap;
                insert.THANHTIEN = (float)thanhtien;
                quanLyKho.CHITIETPHIEUNHAPs.InsertOnSubmit(insert);
                tonkho.SOLUONGTON = tonkho.SOLUONGTON + soluong;
                quanLyKho.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public IQueryable get_CTPN(int idpn)
        {
            return quanLyKho.CHITIETPHIEUNHAPs.Where(n => n.ID_PN == idpn);
        }
    }
}
