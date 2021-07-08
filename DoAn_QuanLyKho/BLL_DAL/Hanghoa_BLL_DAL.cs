using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Hanghoa_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public IQueryable LoadHangHoa()
        {
            return quanLyKho.SANPHAMs.Select(n => n);
        }
        public bool insert_SanPham(string tensp, string dvt, int id_lsp, string hinh,int dongia)
        {
            try
            {
                SANPHAM d = quanLyKho.SANPHAMs.SingleOrDefault(t => t.TENSP.Equals(tensp));

                if (d == null)
                {
                    SANPHAM insert = new SANPHAM();
                    insert.TENSP = tensp;
                    insert.DVT = dvt;
                    insert.ID_LSP = id_lsp;
                    insert.HINHANH = hinh;
                    insert.DONGIA = dongia;
                    insert.SOLUONG = 0;
                    quanLyKho.SANPHAMs.InsertOnSubmit(insert);
                    quanLyKho.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool update_SanPham(int id, string tensp, string dvt, string hinh, int dongia,int loaisp)
        {
            try
            {
                SANPHAM d = quanLyKho.SANPHAMs.SingleOrDefault(t => t.ID_SP.Equals(id));

                if (d != null)
                {
                    d.TENSP = tensp;
                    d.DVT = dvt;
                    d.HINHANH = hinh;
                    d.DONGIA = dongia;
                    d.ID_LSP = loaisp;
                    quanLyKho.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public IQueryable get_DataSP_Search(string tensp)
        {
            var sanpham = from sp in quanLyKho.SANPHAMs
                          where sp.TENSP.Contains(tensp)
                          select (sp);
            return sanpham;
        }
        public IQueryable get_DataSP_LSP(int idlsp)
        {
            var sanpham = from sp in quanLyKho.SANPHAMs
                          where sp.ID_LSP == idlsp
                          select (sp);
            return sanpham;
        }
        public IQueryable get_DataSP_NN(DateTime date)
        {
            var sanpham = from sp in quanLyKho.SANPHAMs
                          where sp.NGAYNHAP == date
                          select (sp);
            return sanpham;
        }
    }
}
