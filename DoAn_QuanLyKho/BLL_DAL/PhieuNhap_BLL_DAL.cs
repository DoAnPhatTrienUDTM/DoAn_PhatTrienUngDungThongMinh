using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PhieuNhap_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public bool insert_PhieuNhap(int idpd, int idncc, string idnv, DateTime ngaynhap, int tongtien)
        {
            try
            {
                PHIEUNHAP insert = new PHIEUNHAP();
                insert.ID_PD = idpd;
                insert.ID_NCC = idncc;
                insert.ID_DN = idnv;
                insert.NGAYLAP = ngaynhap;
                insert.TONGTIEN = tongtien;
                quanLyKho.PHIEUNHAPs.InsertOnSubmit(insert);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public int countpn()
        {
            int i = 0;
            var dspn = quanLyKho.PHIEUNHAPs.OrderByDescending(n => n.ID_PN).Take(1);
            foreach (PHIEUNHAP pn in dspn)
                i = pn.ID_PN;
            return i;
        }
        public IQueryable get_PN_TheoKho(int Id_Kho)
        {
            var phieudat = from pd in quanLyKho.PHIEUNHAPs where pd.NGUOIDUNG.ID_KHO == Id_Kho select (pd);
            return phieudat;
        }
        public IQueryable get_PN_search(int Id_kho, string tenncc)
        {
            var phieudat = from pd in quanLyKho.PHIEUNHAPs where pd.NHACUNGCAP.TENNCC.Contains(tenncc) && pd.NGUOIDUNG.ID_KHO == Id_kho select (pd);
            return phieudat;
        }
        public IQueryable get_PN_date(int Id_kho, DateTime date)
        {
            var phieudat = from pd in quanLyKho.PHIEUNHAPs where pd.NGAYLAP == date && pd.NGUOIDUNG.ID_KHO == Id_kho select (pd);
            return phieudat;
        }
        public PHIEUNHAP get_PN(int idpn)
        {
            return quanLyKho.PHIEUNHAPs.SingleOrDefault(n => n.ID_PN == idpn);
        }
        public IQueryable get_PN_CTPN(int idkho)
        {
            var phieudat = quanLyKho.PHIEUNHAPs.Where(n => n.NGUOIDUNG.ID_KHO == idkho).Select(n => new { Id = n.ID_PN, tenncc = n.NHACUNGCAP.TENNCC });
            return phieudat;
        }
    }
}
