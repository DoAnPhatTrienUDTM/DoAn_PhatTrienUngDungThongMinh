using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{

    public class YCChuyenHang_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));
        public bool insertYCCH(int idkho, string idnv, DateTime NgayLap)
        {
            try
            {
                YEUCAUCHUYENHANG insert = new YEUCAUCHUYENHANG();
                insert.ID_KHO = idkho;
                insert.ID_DN = idnv;
                insert.NGAYLAP = NgayLap;
                insert.TINHTRANG = "Chưa xử lý";
                quanLyKho.YEUCAUCHUYENHANGs.InsertOnSubmit(insert);
                quanLyKho.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public YEUCAUCHUYENHANG get_PC(int idpc)
        {
            return quanLyKho.YEUCAUCHUYENHANGs.SingleOrDefault(n => n.ID_PC == idpc);
        }
        public int get_ID_pC()
        {
            int i = 0;
            var dspn = quanLyKho.YEUCAUCHUYENHANGs.OrderByDescending(n => n.ID_PC).Take(1);
            foreach (YEUCAUCHUYENHANG pn in dspn)
                i = pn.ID_PC;
            return i;
        }
        public IQueryable get_PC()
        {
            return quanLyKho.YEUCAUCHUYENHANGs.Where(n => n.TINHTRANG.Equals("Chua xu ly"));
        }
        public void update_TT(int idpc)
        {
            YEUCAUCHUYENHANG ycch = quanLyKho.YEUCAUCHUYENHANGs.SingleOrDefault(n => n.ID_PC == idpc);
            ycch.TINHTRANG = "Đã xử lý";
            quanLyKho.SubmitChanges();
        }
        public void updatetrngthai(int idpc)
        {
            var pc = quanLyKho.YEUCAUCHUYENHANGs.SingleOrDefault(n => n.ID_PC == idpc);
            pc.TINHTRANG = "Đã xử lý";
            quanLyKho.SubmitChanges();
        }
    }
}
