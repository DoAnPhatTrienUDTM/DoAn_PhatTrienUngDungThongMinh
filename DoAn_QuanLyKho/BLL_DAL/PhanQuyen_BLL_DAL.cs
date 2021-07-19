using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PhanQuyen_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public PhanQuyen_BLL_DAL()
        {

        }

        //Load full bảng
        public IQueryable load_PhanQuyenFull(string id_nhom)
        {
            return quanLyKho.PHANQUYENs.Select(s => s).Where(s => s.ID_NHOM == id_nhom && s.COQUYEN == true);
        }

        //Liên kết bảng phân quyền và màn hình
        public List<PhanQuyen_Join> loadPhanQuyen()
        {
            var PhanQuyen = from manhinh in quanLyKho.MANHINHs
                            select new PhanQuyen_Join()
                            {
                                IntIDManHinh = manhinh.ID_MANHINH,
                                StrTenManHinh = manhinh.TENMANHINH,
                                BolCoQuyen = false
                            };
            return PhanQuyen.ToList();
        }

        public List<PhanQuyen_Join> loadphanQuyen_Join(string id_nhom)
        {
            var phanQuyen = from phanquyen in quanLyKho.PHANQUYENs
                            where phanquyen.ID_NHOM == id_nhom
                            join manhinh in quanLyKho.MANHINHs on phanquyen.ID_MANHINH equals manhinh.ID_MANHINH
                            select new PhanQuyen_Join()
                            {
                                IntIDManHinh = phanquyen.ID_MANHINH,
                                StrTenManHinh = manhinh.TENMANHINH,
                                BolCoQuyen = phanquyen.COQUYEN
                            };
            return phanQuyen.ToList();
        }

        //Thêm phân quyền
        public bool themPhanQuyen(string idNhom, int idManHinh, bool coQuyen)
        {
            try
            {
                PHANQUYEN phanQuyen = new PHANQUYEN();
                phanQuyen.ID_NHOM = idNhom;
                phanQuyen.ID_MANHINH = idManHinh;
                phanQuyen.GHICHU = "";
                phanQuyen.COQUYEN = coQuyen;
                quanLyKho.PHANQUYENs.InsertOnSubmit(phanQuyen);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Update phân quyền
        public bool updatePhanQuyen(string id_nhom, int id_manhinh, bool coQuyen)
        {
            try
            {
                PHANQUYEN phanQuyen = quanLyKho.PHANQUYENs.Where(s => s.ID_NHOM == id_nhom && s.ID_MANHINH == id_manhinh).FirstOrDefault();
                phanQuyen.COQUYEN = coQuyen;
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Kiểm tra get phân quyền
        public int kiemTraKhoaChinh_PhanQuyen(string id_nhom, int id_manhinh)
        {
            try
            {
                var phanQuyen = from phanquyen in quanLyKho.PHANQUYENs where phanquyen.ID_NHOM == id_nhom && phanquyen.ID_MANHINH == id_manhinh select phanquyen;
                if (phanQuyen.Count() == 0)
                {
                    return 0; //Chưa có, sử dụng hàm thêm phân quyền
                }
                else
                {
                    return 1; //Đã có, sử dụng hàm update phân quyền
                }
            }
            catch
            {
                return 2; //Có lỗi xảy ra
            }
        }

        //Kiểm tra khóa ID_NHOM trên bảng phân quyền
        public bool kiemTraID_Nhom(string id_nhom)
        {
            try
            {
                var khoaChinh = from phanquyen in quanLyKho.PHANQUYENs where phanquyen.ID_NHOM == id_nhom select phanquyen;
                if (khoaChinh.Count() == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
