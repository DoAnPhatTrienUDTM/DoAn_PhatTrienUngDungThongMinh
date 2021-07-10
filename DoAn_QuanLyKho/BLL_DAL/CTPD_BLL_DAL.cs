using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CTPD_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public IQueryable get_CTPD(int idpd)
        {
            var chitiet = from ct in quanLyKho.CHITIETPHIEUDATs where ct.ID_PD == idpd select (ct);
            return chitiet;
        }
        public IQueryable get_SP_NCC(int idncc)
        {
            var dssp = quanLyKho.DANHMUCSANPHAMs.Where(n => n.ID_NCC == idncc);
            return dssp;
        }
        public IQueryable get_SPCL(IQueryable ctpd, IQueryable dssp)
        {
            List<SANPHAM> dsspcl = new List<SANPHAM>();
            foreach (DANHMUCSANPHAM item in dssp)
            {
                bool kt = false;
                foreach (CHITIETPHIEUDAT items in ctpd)
                {
                    if (item.ID_SP == items.ID_SP)
                    {
                        kt = true;
                        break;
                    }

                }
                if (!kt)
                {
                    dsspcl.Add(quanLyKho.SANPHAMs.SingleOrDefault(n => n.ID_SP == item.ID_SP));
                }
            }
            return dsspcl as IQueryable;
        }
        public bool insert_CTPD(int idpd, int idsp, int soluong, int thanhtien)
        {
            try
            {
                CHITIETPHIEUDAT insert = new CHITIETPHIEUDAT();
                insert.ID_PD = idpd;
                insert.ID_SP = idsp;
                insert.SOLUONG = soluong;
                insert.THANHTIEN = thanhtien;
                quanLyKho.CHITIETPHIEUDATs.InsertOnSubmit(insert);
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
