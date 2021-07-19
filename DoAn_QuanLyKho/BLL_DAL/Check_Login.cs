using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Check_Login
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));
        DefendPassword pass = new DefendPassword();

        public Check_Login()
        {

        }

        public bool IsvalidUser(string strUser, string strPass)
        {
            try
            {
                var loginEnable = from p in quanLyKho.NGUOIDUNGs where p.ID_DN == strUser && p.MATKHAU == strPass && p.TINHTRANG == true select p;
                if (loginEnable.Any())
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

        //Get id
        public string getIDUser(string strUser, string strPass)
        {
            string manv;
            NGUOIDUNG nv = quanLyKho.NGUOIDUNGs.Where(t => t.ID_DN == strUser && t.MATKHAU == strPass).FirstOrDefault();
            if (nv == null)
            {
                return null; //No ID User
            }
            else
            {
                manv = nv.ID_DN;
                return manv;
            }
        }

        //Get pass
        public string getPassUser(string strUser)
        {
            string matkhau;
            NGUOIDUNG nv = quanLyKho.NGUOIDUNGs.Where(t => t.ID_DN == strUser).FirstOrDefault();
            if (nv == null)
            {
                return null; //No ID User
            }
            else
            {
                matkhau = nv.MATKHAU;
                return matkhau;
            }
        }

        //Lấy tên
        public string getTenNhanVien(string id_dn)
        {
            NGUOIDUNG nd = quanLyKho.NGUOIDUNGs.FirstOrDefault(s => s.ID_DN == id_dn);
            return nd.TEN;
        }
    }
}
