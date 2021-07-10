using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NhanVienBLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public NhanVienBLL_DAL()
        {
            
        }

        //Load gridView
        public IQueryable loadDataNguoiDung()
        {
            var data = quanLyKho.NGUOIDUNGs.Select(s => new
            {
                ID_DN = s.ID_DN,
                TEN = s.TEN
            }
            );
            return data as IQueryable;
        }

        //Bindings gridView
        //Lấy tên
        public string gridViewCellClick_TenNhanVien(string id_dn)
        {
            NGUOIDUNG nd = quanLyKho.NGUOIDUNGs.FirstOrDefault(s => s.ID_DN == id_dn);
            return nd.TEN;
        }

        //Lấy số điện thoại
        public string gridViewCellClick_SoDT(string id_dn)
        {
            NGUOIDUNG nd = quanLyKho.NGUOIDUNGs.FirstOrDefault(s => s.ID_DN == id_dn);
            return nd.SDT;
        }

        //Lấy địa chỉ
        public string gridViewCellClick_DiaChi(string id_dn)
        {
            NGUOIDUNG nd = quanLyKho.NGUOIDUNGs.FirstOrDefault(s => s.ID_DN == id_dn);
            return nd.DIACHI;
        }

        //Lấy giới tính
        public string gridViewCellClick_GioiTinh(string id_dn)
        {
            NGUOIDUNG nd = quanLyKho.NGUOIDUNGs.FirstOrDefault(s => s.ID_DN == id_dn);
            return nd.GIOITINH;
        }

        //Lấy ngày sinh
        public string gridViewCellClick_NgaySinh(string id_dn)
        {
            NGUOIDUNG nd = quanLyKho.NGUOIDUNGs.FirstOrDefault(s => s.ID_DN == id_dn);
            return nd.NGAYSINH.Value.ToString("dd/MM/yyyy");
        }

        //Lấy tình trạng tài khoản
        public bool? gridViewCellClick_TinhTrangTaiKhoan(string id_dn)
        {
            NGUOIDUNG nd = quanLyKho.NGUOIDUNGs.FirstOrDefault(s => s.ID_DN == id_dn);
            return nd.TINHTRANG;
        }

        //Lấy id kho làm việc
        public int gridViewCellClick_IDKho(string id_dn)
        {
            NGUOIDUNG nd = quanLyKho.NGUOIDUNGs.FirstOrDefault(s => s.ID_DN == id_dn);
            return nd.ID_KHO;
        }

        //Lấy địa chỉ kho làm việc
        public string gridViewCellClick_DiaChiKho(int id_kho)
        {
            THONGTINKHO kho = quanLyKho.THONGTINKHOs.FirstOrDefault(s => s.ID_KHO == id_kho);
            return kho.DIACHI;
        }

        //Cập nhật
        public bool updateInfo(string id, string ten, string sdt, string diachi, DateTime ngaysinh, string gioitinh, string pass)
        {
            try
            {
                NGUOIDUNG nguoidung = quanLyKho.NGUOIDUNGs.SingleOrDefault(t => t.ID_DN.Equals(id));
                if (nguoidung != null)
                {
                    nguoidung.TEN = ten;
                    nguoidung.SDT = sdt;
                    nguoidung.DIACHI = diachi;
                    nguoidung.NGAYSINH = ngaysinh;
                    nguoidung.GIOITINH = gioitinh;
                    nguoidung.MATKHAU = pass;
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

        //Lấy info người dùng
        public NGUOIDUNG get_Info(string id)
        {
            return quanLyKho.NGUOIDUNGs.SingleOrDefault(t => t.ID_DN.Equals(id));
        }

        //Thêm người dùng
        public bool themNguoiDung(int id_kho, string id, string ten, string sdt, string diachi, DateTime ngaysinh, string gioitinh, string pass)
        {
            try
            {
                NGUOIDUNG nd = new NGUOIDUNG();
                nd.ID_KHO = id_kho;
                nd.ID_DN = id;
                nd.TEN = ten;
                nd.SDT = sdt;
                nd.DIACHI = diachi;
                nd.NGAYSINH = ngaysinh;
                nd.GIOITINH = gioitinh;
                nd.MATKHAU = pass;
                quanLyKho.NGUOIDUNGs.InsertOnSubmit(nd);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Xóa người dùng
        public bool xoaNguoiDung(string id)
        {
            try
            {
                NGUOIDUNG nd = quanLyKho.NGUOIDUNGs.Where(s => s.ID_DN == id).FirstOrDefault();
                quanLyKho.NGUOIDUNGs.DeleteOnSubmit(nd);
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
