using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DanhMucSP_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public IQueryable get_DM_SP_NCC(int ncc)
        {
            return quanLyKho.DANHMUCSANPHAMs.Where(n => n.ID_NCC == ncc);
        }
        public IQueryable get_DM_SP()
        {
            return quanLyKho.DANHMUCSANPHAMs;
        }
        public bool insert_DMSP(int idncc, int idsp, int gianhap)
        {
            
            try
            {
                DANHMUCSANPHAM dmsp = new DANHMUCSANPHAM();
                dmsp.ID_NCC = idncc;
                dmsp.ID_SP = idsp;
                dmsp.GIABAN = gianhap;
                quanLyKho.DANHMUCSANPHAMs.InsertOnSubmit(dmsp);
                quanLyKho.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool update_DMSP(int idncc, int idsp,int idspmoi, int gianhap)
        {
            DANHMUCSANPHAM dmsp = quanLyKho.DANHMUCSANPHAMs.SingleOrDefault(n => n.ID_NCC == idncc && n.ID_SP == idsp);
            var kt = quanLyKho.CHITIETPHIEUDATs.Where(n => n.PHIEUDAT.TINHTRANG == false && n.PHIEUDAT.ID_NCC == idncc && n.ID_SP == idsp);
            if (kt.Count() == 0)
            {
                dmsp.ID_SP = idspmoi;
                dmsp.GIABAN = gianhap;
                try
                {
                    quanLyKho.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }
        public bool delete_DMSP(int idncc, int idsp)
        {
            DANHMUCSANPHAM dmsp = quanLyKho.DANHMUCSANPHAMs.SingleOrDefault(n => n.ID_NCC == idncc && n.ID_SP == idsp);
            var kt = quanLyKho.CHITIETPHIEUDATs.Where(n => n.PHIEUDAT.TINHTRANG == false && n.PHIEUDAT.ID_NCC == idncc && n.ID_SP == idsp);
            if (kt.Count() == 0)
            {
                quanLyKho.DANHMUCSANPHAMs.DeleteOnSubmit(dmsp);
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
