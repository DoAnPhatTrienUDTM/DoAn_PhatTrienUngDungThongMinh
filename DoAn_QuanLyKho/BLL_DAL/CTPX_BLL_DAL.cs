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

        public bool insert_CTPX(int idpx, int idsp, int soluong, int gianhap, int thanhtien)
        {
            try
            {
                CHITIETPHIEUXUAT insert = new CHITIETPHIEUXUAT();
                SANPHAM sp = quanLyKho.SANPHAMs.SingleOrDefault(t => t.ID_SP.Equals(idsp));
                insert.ID_PX = idpx;
                insert.ID_SP = idsp;
                insert.SOLUONG = soluong;
                insert.DONGIA = (float)gianhap;
                insert.THANHTIEN = (float)thanhtien;
                quanLyKho.CHITIETPHIEUXUATs.InsertOnSubmit(insert);
                sp.SOLUONG = sp.SOLUONG - soluong;
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
    }
}
