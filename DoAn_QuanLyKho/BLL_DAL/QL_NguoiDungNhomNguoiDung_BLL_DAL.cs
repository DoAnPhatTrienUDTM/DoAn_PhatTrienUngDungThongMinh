using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QL_NguoiDungNhomNguoiDung_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));
        public QL_NguoiDungNhomNguoiDung_BLL_DAL()
        {

        }


        //Load gridView
        public IQueryable loadDataNguoiDungNhomNguoiDung_id(string id_nhom)
        {
            return quanLyKho.NGUOIDUNGNHOMNGUOIDUNGs.Select(t => t).Where(s => s.ID_DN == id_nhom);
        }

        public IQueryable loadDataNguoiDungNhomNguoiDung_id_combobox(string id_nhom)
        {
            return quanLyKho.NGUOIDUNGNHOMNGUOIDUNGs.Where(s => s.ID_NHOM == id_nhom).Select(t => new {
                ID_NHOM = t.ID_NHOM,
                ID_DN = t.ID_DN,
                GHICHU = t.GHICHU
            });
        }

        public IQueryable loadDataNguoiDungNhomNguoiDung()
        {
            return quanLyKho.NGUOIDUNGNHOMNGUOIDUNGs.Select(t => new {
                ID_NHOM = t.ID_NHOM,
                ID_DN = t.ID_DN,
                GHICHU = t.GHICHU
            });
        }

        //Thêm
        public bool themNDVaoNhom(string id_dn, string id_nhom)
        {
            try
            {
                NGUOIDUNGNHOMNGUOIDUNG nd = new NGUOIDUNGNHOMNGUOIDUNG();
                nd.ID_DN = id_dn;
                nd.ID_NHOM = id_nhom;
                nd.GHICHU = "";
                quanLyKho.NGUOIDUNGNHOMNGUOIDUNGs.InsertOnSubmit(nd);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Xóa
        public bool xoaNhomNguoiDung(string id_dn, string id_nhom)
        {
            try
            {
                NGUOIDUNGNHOMNGUOIDUNG nd = quanLyKho.NGUOIDUNGNHOMNGUOIDUNGs.Where(s => s.ID_DN == id_dn && s.ID_NHOM == id_nhom).FirstOrDefault();
                quanLyKho.NGUOIDUNGNHOMNGUOIDUNGs.DeleteOnSubmit(nd);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Lấy role người dùng
        public string getRole(string id_dn)
        {
            try
            {
                NGUOIDUNGNHOMNGUOIDUNG nd = quanLyKho.NGUOIDUNGNHOMNGUOIDUNGs.FirstOrDefault(s => s.ID_DN == id_dn);
                NHOMNGUOIDUNG nhomND = quanLyKho.NHOMNGUOIDUNGs.FirstOrDefault(s => s.ID_NHOM == nd.ID_NHOM);
                return nhomND.TENNHOM;
            }
            catch
            {
                return null;
            }
        }
    }
}
