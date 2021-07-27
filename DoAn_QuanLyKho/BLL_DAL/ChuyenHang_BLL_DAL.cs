using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ChuyenHang_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));
        TonKho_BLL_DAL tonkho = new TonKho_BLL_DAL();
        public bool insertCH(int idpc, int idkho, int idsp, int sl)
        {
            try
            {
                CHUYENHANG insert = new CHUYENHANG();
                insert.ID_PC = idpc;
                insert.ID_KHO = idkho;
                insert.ID_SP = idsp;
                insert.SOLONG = sl;
                quanLyKho.CHUYENHANGs.InsertOnSubmit(insert);
                tonkho.updateSL(idkho, idsp, -sl);
                quanLyKho.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public string layTenSanPham(int id)
        {
            SANPHAM sp = quanLyKho.SANPHAMs.FirstOrDefault(s => s.ID_SP == id);
            return sp.TENSP;
        }

        public IQueryable loadDataPhieuChuyen()
        {
            var data = quanLyKho.CHUYENHANGs.Select(s => new
            {
                ID_PC = s.ID_PC,
                ID_KHO = s.ID_KHO,
                SanPham = layTenSanPham(s.ID_SP),
                SoLuong = s.SOLONG
            }
            );

            return data as IQueryable;
        }

        public IQueryable loadDataChiTietPhieuChuyen(int id_pc)
        {
            var data = quanLyKho.CHITTIETCHUYENHANGs.Where(s => s.ID_PC == id_pc).Select(s => new
            {
                ID_PC = s.ID_PC,
                SanPham = layTenSanPham(s.ID_SP),
                SoLuong = s.SOLUONG
            });
            return data as IQueryable;
        }
    }
}
