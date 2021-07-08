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

        //Liên kết bảng phân quyền và màn hình
        public List<PhanQuyen_Join> loadPhanQuyen_Join()
        {
            var PhanQuyen = from manhinh in quanLyKho.MANHINHs
                            join phanquyen in quanLyKho.PHANQUYENs on manhinh.ID_MANHINH equals phanquyen.ID_MANHINH
                            select new PhanQuyen_Join()
                            {
                                IntIDManHinh = manhinh.ID_MANHINH,
                                StrTenManHinh = manhinh.TENMANHINH,
                                BolCoQuyen = phanquyen.COQUYEN
                            };
            return PhanQuyen.ToList();
        }

        //Lưu phân quyền
        public bool luuPhanQuyen(string idNhom, int idManHinh, bool coQuyen)
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
    }
}
