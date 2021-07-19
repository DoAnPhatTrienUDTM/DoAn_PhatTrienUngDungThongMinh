using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PhieuXuat_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));
        public bool insert_PhieuXuat(string idnv, string loaixuat, DateTime ngaynhap, int tongtien)
        {
            try
            {
                PHIEUXUAT insert = new PHIEUXUAT();

                insert.ID_DN = idnv;
                insert.NGAYLAP = ngaynhap;
                insert.TONGTIEN = tongtien;
                insert.LOAIXUAT = loaixuat;
                quanLyKho.PHIEUXUATs.InsertOnSubmit(insert);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public IQueryable get_PX_TheoKho(int Id_Kho)
        {
            var phieuxuat = from pd in quanLyKho.PHIEUXUATs where pd.NGUOIDUNG.ID_KHO == Id_Kho select (pd);
            return phieuxuat;
        }
        public IQueryable get_PX_search(int Id_kho, string tennv)
        {
            var phieudat = from pd in quanLyKho.PHIEUXUATs where pd.NGUOIDUNG.TEN.Contains(tennv) && pd.NGUOIDUNG.ID_KHO == Id_kho select (pd);
            return phieudat;
        }
        public IQueryable get_PX_date(int Id_kho, DateTime date)
        {
            var phieudat = from pd in quanLyKho.PHIEUXUATs where pd.NGAYLAP == date && pd.NGUOIDUNG.ID_KHO == Id_kho select (pd);
            return phieudat;
        }
        public IQueryable get_PX_CTPX(int idkho)
        {
            var phieudat = quanLyKho.PHIEUXUATs.Where(n => n.NGUOIDUNG.ID_KHO == idkho).Select(n => new { Id = n.ID_PX, tenncc = n.NGUOIDUNG.TEN });
            return phieudat;
        }
        public PHIEUXUAT getPX(int id)
        {
            return quanLyKho.PHIEUXUATs.SingleOrDefault(n => n.ID_PX == id);
        }
        public int countpx()
        {
            int i = 0;
            var dspn = quanLyKho.PHIEUXUATs.OrderByDescending(n => n.ID_PX).Take(1);
            foreach (PHIEUXUAT pn in dspn)
                i = pn.ID_PX;
            return i;
        }
        public int get_tongtienngay(int idkho, DateTime date)
        {
            int tong = 0;
            try
            {
                tong = (int)quanLyKho.PHIEUXUATs.Where(n => n.NGUOIDUNG.THONGTINKHO.ID_KHO == idkho && n.NGAYLAP == date).Sum(n => n.TONGTIEN);
            }
            catch
            {
                return tong;
            }
            return tong;
        }
        public int get_Count(int idkho, int month)
        {
            return quanLyKho.PHIEUXUATs.Where(n => n.NGUOIDUNG.ID_KHO == idkho && n.NGAYLAP.Value.Month == month).Count();
        }
        public int get_SumTongTien(int idkho, int month)
        {
            int tong = 0;
            try
            {
                tong = (int)quanLyKho.PHIEUXUATs.Where(n => n.NGUOIDUNG.ID_KHO == idkho && n.NGAYLAP.Value.Month == month).Sum(n => n.TONGTIEN);
            }
            catch
            {
                return tong;
            }
            return tong;
        }
        public IQueryable get_ALL()
        {
            return quanLyKho.PHIEUXUATs;
        }
        public IQueryable get_ALL_PX_CTPX()
        {
            var phieudat = quanLyKho.PHIEUXUATs.Select(n => new { Id = n.ID_PX, tenncc = n.NGUOIDUNG.TEN });
            return phieudat;
        }
        public IQueryable get_All_PX_search(string tennv)
        {
            var phieudat = from pd in quanLyKho.PHIEUXUATs where pd.NGUOIDUNG.TEN.Contains(tennv) select (pd);
            return phieudat;
        }
        public IQueryable get_ALL_PX_date(DateTime date)
        {
            var phieudat = from pd in quanLyKho.PHIEUXUATs where pd.NGAYLAP == date select (pd);
            return phieudat;
        }
        public IQueryable get_ALL_PX_CTPX_search(string tennv)
        {
            var phieudat = quanLyKho.PHIEUXUATs.Where(pd => pd.NGUOIDUNG.TEN.Contains(tennv)).Select(n => new { Id = n.ID_PX, tenncc = n.NGUOIDUNG.TEN });
            return phieudat;
        }
        public IQueryable get_PX_CTPX_search(int idkho, string tennv)
        {
            var phieudat = quanLyKho.PHIEUXUATs.Where(pd => pd.NGUOIDUNG.TEN.Contains(tennv) && pd.NGUOIDUNG.ID_KHO == idkho).Select(n => new { Id = n.ID_PX, tenncc = n.NGUOIDUNG.TEN });
            return phieudat;
        }
        public IQueryable get_ALL_PX_CTPX_date(DateTime date)
        {
            var phieudat = quanLyKho.PHIEUXUATs.Where(pd => pd.NGAYLAP == date).Select(n => new { Id = n.ID_PX, tenncc = n.NGUOIDUNG.TEN });
            return phieudat;
        }
        public IQueryable get_PX_CTPX_date(int idkho, DateTime date)
        {
            var phieudat = quanLyKho.PHIEUXUATs.Where(pd => pd.NGAYLAP == date && pd.NGUOIDUNG.ID_KHO == idkho).Select(n => new { Id = n.ID_PX, tenncc = n.NGUOIDUNG.TEN });
            return phieudat;
        }
    }
}
