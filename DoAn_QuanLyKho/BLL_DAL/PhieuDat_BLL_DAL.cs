using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PhieuDat_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public IQueryable get_PD_TheoKho(int Id_Kho)
        {
            var phieudat = from pd in quanLyKho.PHIEUDATs where pd.NGUOIDUNG.ID_KHO == Id_Kho select (pd);
            return phieudat;
        }
        public IQueryable get_PD_search(int Id_kho, string tenncc)
        {
            var phieudat = from pd in quanLyKho.PHIEUDATs where pd.NHACUNGCAP.TENNCC.Contains(tenncc) && pd.NGUOIDUNG.ID_KHO == Id_kho select (pd);
            return phieudat;
        }
        public IQueryable get_PD_date(int Id_kho ,DateTime date)
        {
            var phieudat = from pd in quanLyKho.PHIEUDATs where pd.NGAYLAP == date && pd.NGUOIDUNG.ID_KHO == Id_kho select (pd);
            return phieudat;
        }
        public IQueryable get_PD_CTPD(int idkho)
        {
            var phieudat = quanLyKho.PHIEUDATs.Where(n => n.NGUOIDUNG.ID_KHO == idkho).Select(n => new {Id = n.ID_PD, tenncc = n.NHACUNGCAP.TENNCC});
            return phieudat;
        }
        public PHIEUDAT getPD(int id)
        {
            return quanLyKho.PHIEUDATs.SingleOrDefault(n => n.ID_PD == id);
        }
        public bool insert_PhieuDat(int idncc, string idnv, DateTime ngaynhap, int tongtien)
        {
            try
            {
                PHIEUDAT insert = new PHIEUDAT();
                insert.ID_NCC = idncc;
                insert.ID_DN = idnv;
                insert.NGAYLAP = ngaynhap;
                insert.TONGTIEN = tongtien;
                insert.TINHTRANG = false;
                quanLyKho.PHIEUDATs.InsertOnSubmit(insert);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

       
    }
}
