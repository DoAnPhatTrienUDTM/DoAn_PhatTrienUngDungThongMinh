using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class TonKho_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public int get_SL(int idkho, int idsp)
        {
            var tonkho = quanLyKho.TONKHOs.SingleOrDefault(n => n.ID_KHO == idkho && n.ID_SP == idsp);
            return (int)tonkho.SOLUONGTON;
        }
        public void insertSL(int idsp)
        {
            foreach (THONGTINKHO item in quanLyKho.THONGTINKHOs)
            {
                TONKHO tonkho = new TONKHO();
                tonkho.ID_KHO = item.ID_KHO;
                tonkho.ID_SP = idsp;
                tonkho.SOLUONGTON = 0;
                quanLyKho.TONKHOs.InsertOnSubmit(tonkho);
            }
            quanLyKho.SubmitChanges();
        }
        public bool updateSL(int idkho, int idsl, int sl)
        {
            try
            {
                TONKHO tonkho = quanLyKho.TONKHOs.SingleOrDefault(n => n.ID_KHO == idkho && n.ID_SP == idsl);
                if (tonkho != null)
                {
                    tonkho.SOLUONGTON = tonkho.SOLUONGTON + sl;
                    quanLyKho.SubmitChanges();

                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public IQueryable get_SLTon_Chuyen(int idsp, int soluong,int idkho)
        {
            return quanLyKho.TONKHOs.Where(n => n.ID_SP == idsp && n.SOLUONGTON > soluong && n.ID_KHO != idkho);
        }

        NCC_BLL_DAL ncc = new NCC_BLL_DAL();
        //Lấy tồn kho <= 10
        public IQueryable get_TonKho()
        {
            var data = quanLyKho.TONKHOs.Where(s => s.SOLUONGTON <= 10).Select(s => new ThongBaoTonKho()
            {
                IntKho = s.ID_KHO,
                StrSanPham = ncc.layTenSanPham(s.ID_SP),
                IntSoLuongTon = s.SOLUONGTON
            });
            return data as IQueryable;
        }
    }
}
