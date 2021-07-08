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
            return quanLyKho.NGUOIDUNGNHOMNGUOIDUNGs.Select(t => t.ID_NHOM == id_nhom);
        }

        public IQueryable loadDataNguoiDungNhomNguoiDung()
        {
            return quanLyKho.NGUOIDUNGNHOMNGUOIDUNGs.Select(t => t);
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
    }
}
