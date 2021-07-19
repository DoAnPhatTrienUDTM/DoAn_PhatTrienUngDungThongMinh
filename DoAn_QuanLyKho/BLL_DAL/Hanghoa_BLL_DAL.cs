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
        public SANPHAM get_sp(int idsp)
        {
            return quanLyKho.SANPHAMs.SingleOrDefault(n => n.ID_SP == idsp);
        }
        public IQueryable get_sp_ncc(int idncc)
        {
            var dssp = quanLyKho.DANHMUCSANPHAMs.Where(n => n.ID_NCC == idncc).Select(n => new { idsp = n.ID_SP, tensp = n.SANPHAM.TENSP });
            return dssp;
        }
        public bool insert_SanPham(string tensp, string dvt, int id_lsp, string hinh, int dongia)
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
                    insert.NGAYNHAP = DateTime.Today.Date;
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

        public bool update_SanPham(int id, string tensp, string dvt, string hinh, int dongia, int loaisp)
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
        public List<SANPHAM> get_SP_CHUAGIAO(int idpd)
        {
            List<SANPHAM> list = new List<SANPHAM>();
            CTPD_BLL_DAL ctpd = new CTPD_BLL_DAL();
            CTPN_BLL_DAL ctpn = new CTPN_BLL_DAL();
            var dsctpd = ctpd.get_CTPD(idpd);
            foreach (CHITIETPHIEUDAT ct in dsctpd)
            {
                if (ct.SOLUONG != ctpn.get_SP_DANHAP(idpd, ct.ID_SP))
                    list.Add(get_sp(ct.ID_SP));
            }
            return list;
        }
        public int getidspmoi()
        {
            int id = -1;
            var sp = quanLyKho.SANPHAMs.OrderByDescending(n => n.ID_SP).Take(1);
            foreach (SANPHAM item in sp)
            {
                id = item.ID_SP;
            }
            return id;
        }
        public List<SPXuatNhieu> get_SPXuatNhieu(int idkho)
        {
            List<SPXuatNhieu> list = new List<SPXuatNhieu>();

            var dsctpxGroupbyIDSP =
            from ctpx in quanLyKho.CHITIETPHIEUXUATs.Where(n => n.PHIEUXUAT.NGUOIDUNG.ID_KHO == idkho)
            group ctpx by ctpx.ID_SP into newGroup
            orderby newGroup.Key
            select newGroup;
            foreach (var idsp in dsctpxGroupbyIDSP)
            {
                int tong = 0;
                foreach (var ctpxidsp in idsp)
                {
                    tong += (int)ctpxidsp.SOLUONG;
                }
                SPXuatNhieu sp = new SPXuatNhieu(idsp.Key, tong);
                list.Add(sp);
            }

            return list;
        }
    }
}
