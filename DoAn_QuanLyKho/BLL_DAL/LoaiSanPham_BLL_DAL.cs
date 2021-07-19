using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class LoaiSanPham_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));
        public IQueryable loadLoaiSP()
        {
            return quanLyKho.LOAISANPHAMs.Select(n => n);
        }
        public IQueryable get_LoaiSP_Search(string keysearch)
        {
            return quanLyKho.LOAISANPHAMs.Where(n => n.TENLOAISANPHAM.Contains(keysearch));
        }
        public bool insert_LoaiSP(string tenloai)
        {
            var loai = quanLyKho.LOAISANPHAMs.SingleOrDefault(n => n.TENLOAISANPHAM.Equals(tenloai));
            if (loai == null)
            {
                LOAISANPHAM insert = new LOAISANPHAM();
                insert.TENLOAISANPHAM = tenloai;
                quanLyKho.LOAISANPHAMs.InsertOnSubmit(insert);
                quanLyKho.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool update_LoaiSP(int idloaisp, string tenloai)
        {
            LOAISANPHAM lsp = quanLyKho.LOAISANPHAMs.SingleOrDefault(n => n.ID_LSP == idloaisp);
            if (lsp != null)
            {
                LOAISANPHAM lsp1 = quanLyKho.LOAISANPHAMs.SingleOrDefault(n => n.TENLOAISANPHAM.Equals(tenloai));
                if (lsp1 != null)
                {
                    return false;
                }
                else
                {
                    lsp.TENLOAISANPHAM = tenloai;
                    quanLyKho.SubmitChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool delete_LoaiSP(int idloaisp)
        {
            LOAISANPHAM loaisp = quanLyKho.LOAISANPHAMs.SingleOrDefault(n => n.ID_LSP == idloaisp);
            var kt = quanLyKho.SANPHAMs.Where(n => n.ID_LSP == idloaisp);
            if (kt.Count() == 0)
            {
                quanLyKho.LOAISANPHAMs.DeleteOnSubmit(loaisp);
                quanLyKho.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
