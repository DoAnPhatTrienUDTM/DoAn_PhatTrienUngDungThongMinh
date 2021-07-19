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
        public IQueryable get_PD_date(int Id_kho, DateTime date)
        {
            var phieudat = from pd in quanLyKho.PHIEUDATs where pd.NGAYLAP == date && pd.NGUOIDUNG.ID_KHO == Id_kho select (pd);
            return phieudat;
        }
        public IQueryable get_PD_CTPD(int idkho)
        {
            var phieudat = quanLyKho.PHIEUDATs.Where(n => n.NGUOIDUNG.ID_KHO == idkho).Select(n => new { Id = n.ID_PD, tenncc = n.NHACUNGCAP.TENNCC });
            return phieudat;
        }

        public PHIEUDAT getPD(int id)
        {
            return quanLyKho.PHIEUDATs.SingleOrDefault(n => n.ID_PD == id);
        }
       
        public IQueryable get_PD_false_search(int idkho, string tenncc)
        {
            return quanLyKho.PHIEUDATs.Where(n => n.TINHTRANG == false && n.NGUOIDUNG.ID_KHO == idkho && n.NHACUNGCAP.TENNCC.Contains(tenncc));
        }
        public IQueryable get_PD_false_date(int idkho, DateTime date)
        {
            return quanLyKho.PHIEUDATs.Where(n => n.TINHTRANG == false && n.NGUOIDUNG.ID_KHO == idkho && n.NGAYLAP == date);
        }
        public bool kt_trangthai_PD(int idpd)
        {
            bool kq = true;
            CTPD_BLL_DAL ctpd = new CTPD_BLL_DAL();
            CTPN_BLL_DAL ctpn = new CTPN_BLL_DAL();
            var dsctpd = ctpd.get_CTPD(idpd);
            foreach (CHITIETPHIEUDAT ct in dsctpd)
            {
                int sl = ctpn.get_SP_DANHAP(idpd, ct.ID_SP);
                if (ct.SOLUONG != sl)
                {
                    kq = false;
                    return kq;
                }

            }
            return kq;
        }
        public void update_TrangThai_PD(int idpd)
        {
            PHIEUDAT pd = getPD(idpd);
            if (kt_trangthai_PD(idpd))
            {
                pd.TINHTRANG = true;
            }
            quanLyKho.SubmitChanges();
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
        public int countpd()
        {
            int i = 0;
            var dspn = quanLyKho.PHIEUDATs.OrderByDescending(n => n.ID_PD).Take(1);
            foreach (PHIEUDAT pn in dspn)
                i = pn.ID_PD;
            return i;

        }
        public IQueryable get_ALL()
        {
            return quanLyKho.PHIEUDATs;
        }
        public IQueryable get_ALL_PD_CTPD()
        {
            var phieudat = quanLyKho.PHIEUDATs.Select(n => new { Id = n.ID_PD, tenncc = n.NHACUNGCAP.TENNCC });
            return phieudat;
        }
        public IQueryable get_All_PD_search(string tenncc)
        {
            var phieudat = from pd in quanLyKho.PHIEUDATs where pd.NHACUNGCAP.TENNCC.Contains(tenncc)  select (pd);
            return phieudat;
        }
        public IQueryable get_ALL_PD_date(DateTime date)
        {
            var phieudat = from pd in quanLyKho.PHIEUDATs where pd.NGAYLAP == date  select (pd);
            return phieudat;
        }
        public IQueryable get_ALL_PD_CTPD_search(string tenncc)
        {
            var phieudat = quanLyKho.PHIEUDATs.Where(pd => pd.NHACUNGCAP.TENNCC.Contains(tenncc)).Select(n => new { Id = n.ID_PD, tenncc = n.NHACUNGCAP.TENNCC });
            return phieudat;
        }
        public IQueryable get_PD_CTPD_search(int idkho, string tenncc)
        {
            var phieudat = quanLyKho.PHIEUDATs.Where(pd => pd.NHACUNGCAP.TENNCC.Contains(tenncc) && pd.NGUOIDUNG.ID_KHO == idkho).Select(n => new { Id = n.ID_PD, tenncc = n.NHACUNGCAP.TENNCC });
            return phieudat;
        }
        public IQueryable get_ALL_PD_CTPD_date(DateTime date)
        {
            var phieudat = quanLyKho.PHIEUDATs.Where(pd => pd.NGAYLAP == date).Select(n => new { Id = n.ID_PD, tenncc = n.NHACUNGCAP.TENNCC });
            return phieudat;
        }
        public IQueryable get_PD_CTPD_date(int idkho,DateTime date)
        {
            var phieudat = quanLyKho.PHIEUDATs.Where(pd => pd.NGAYLAP == date && pd.NGUOIDUNG.ID_KHO == idkho).Select(n => new { Id = n.ID_PD, tenncc = n.NHACUNGCAP.TENNCC });
            return phieudat;
        }
        public IQueryable get_PD_false(int idkho)
        {
            return quanLyKho.PHIEUDATs.Where(n => n.TINHTRANG == false && n.NGUOIDUNG.ID_KHO == idkho);
        }
        public IQueryable get_All_PD_false()
        {
            return quanLyKho.PHIEUDATs.Where(n => n.TINHTRANG == false);
        }
        public IQueryable get_PD_true(int idkho)
        {
            return quanLyKho.PHIEUDATs.Where(n => n.TINHTRANG == true && n.NGUOIDUNG.ID_KHO == idkho);
        }
        public IQueryable get_All_PD_true()
        {
            return quanLyKho.PHIEUDATs.Where(n => n.TINHTRANG == true );
        }
        public IQueryable get_PD_TrangThai(int idKho, string trangthai)
        {
            if (trangthai.Equals("true"))
            {
                return get_PD_true(idKho);
            }
            else
            {
                return get_PD_false(idKho);
            }
        }
        public IQueryable get_All_PD_TrangThai(string trangthai)
        {
            if (trangthai.Equals("true"))
            {
                return get_All_PD_true();
            }
            else
            {
                return get_All_PD_false();
            }
        }
    }
}
