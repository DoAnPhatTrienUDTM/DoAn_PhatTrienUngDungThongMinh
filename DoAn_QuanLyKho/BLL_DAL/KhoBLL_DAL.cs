using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class KhoBLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public KhoBLL_DAL()
        {

        }
        public THONGTINKHO get_kho(int id)
        {
            return quanLyKho.THONGTINKHOs.SingleOrDefault(n => n.ID_KHO == id);
        }
        //Load gridView
        public IQueryable loadDataKHo()
        {
            return quanLyKho.THONGTINKHOs;
        }

        //Đếm số lượng kho
        public int count_Kho()
        {
            var demKho = from kho in quanLyKho.THONGTINKHOs select kho;
            return demKho.Count();
        }

        //Lấy số lượng nhân viên
        public int? get_SoLuongNhanVien(int idKho)
        {
            THONGTINKHO kho = quanLyKho.THONGTINKHOs.FirstOrDefault(s => s.ID_KHO == idKho);
            return kho.SLNV;
        }

        //Bindings textbox
        //Địa chỉ
        public string get_DiaChiKho(int idKho)
        {
            THONGTINKHO kho = quanLyKho.THONGTINKHOs.FirstOrDefault(s => s.ID_KHO == idKho);
            return kho.DIACHI;
        }

        //Tình trạng
        public string get_TinhTrangKho(int idKho)
        {
            THONGTINKHO kho = quanLyKho.THONGTINKHOs.FirstOrDefault(s => s.ID_KHO == idKho);
            return kho.TINHTRANG;
        }

        //Thêm kho
        public bool themKho(string diaChi, string tinhTrang, int slnv)
        {
            try
            {
                THONGTINKHO kho = new THONGTINKHO();
                kho.DIACHI = diaChi;
                kho.TINHTRANG = tinhTrang;
                kho.SLNV = slnv;
                quanLyKho.THONGTINKHOs.InsertOnSubmit(kho);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Xóa kho
        public bool xoaKho(int id)
        {
            try
            {
                THONGTINKHO kho = quanLyKho.THONGTINKHOs.Where(s => s.ID_KHO == id).FirstOrDefault();
                quanLyKho.THONGTINKHOs.DeleteOnSubmit(kho);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Sửa kho
        public bool suaKho(int id, string diaChi, string tinhTrang, int slnv)
        {
            try
            {
                THONGTINKHO kho = quanLyKho.THONGTINKHOs.Where(s => s.ID_KHO == id).FirstOrDefault();
                kho.DIACHI = diaChi;
                kho.TINHTRANG = tinhTrang;
                kho.SLNV = slnv;
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable searchKho(string search)
        {
            var data = quanLyKho.THONGTINKHOs.Select(s => new
            {
                ID_KHO = s.ID_KHO,
                DIACHI = s.DIACHI,
                TINHTRANG = s.TINHTRANG,
                SLNV = s.SLNV
            }
            );
            data = data.Where(s => s.DIACHI.Contains(search));
            return data as IQueryable;
        }
    }
}
