using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CT_YCXH
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));
        public bool insert_CT(int idpc, int idsp, int soluong)
        {
            try
            {
                CHITTIETCHUYENHANG insert = new CHITTIETCHUYENHANG();
                insert.ID_PC = idpc;
                insert.ID_SP = idsp;
                insert.SOLUONG = soluong;
                quanLyKho.CHITTIETCHUYENHANGs.InsertOnSubmit(insert);
                quanLyKho.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public IQueryable get_CTYC(int idpc)
        {
            return quanLyKho.CHITTIETCHUYENHANGs.Where(n => n.ID_PC == idpc);
        }
    }
}
