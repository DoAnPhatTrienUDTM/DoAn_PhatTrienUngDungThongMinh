using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NCC_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public NCC_BLL_DAL()
        {

        }

        public IQueryable get_NCC()
        {
            var data = quanLyKho.NHACUNGCAPs.Select(s => new
            {
                ID_NCC = s.ID_NCC,
                TENNCC = s.TENNCC
            });

            return data as IQueryable;
        }


        public IQueryable get_NCC_GridCon()
        {
            var data = quanLyKho.NHACUNGCAPs.Select(s => new
            {
                ID_NCC = s.ID_NCC,
                TENNCC = s.TENNCC,
                DIACHI = s.DIACHI,
                SDT = s.SDT
            });

            return data as IQueryable;
        }

        //Lấy địa chỉ nhà cung cấp
        public string gridViewCellClick_DiaChi(int id_ncc)
        {
            NHACUNGCAP ncc = quanLyKho.NHACUNGCAPs.FirstOrDefault(s => s.ID_NCC == id_ncc);
            return ncc.DIACHI;
        }

        //Lấy số điện thoại
        public string gridViewCellClick_SoDT(int id_ncc)
        {
            NHACUNGCAP ncc = quanLyKho.NHACUNGCAPs.FirstOrDefault(s => s.ID_NCC == id_ncc);
            return ncc.SDT;
        }

        //Thêm nhà cung cấp
        public bool themNhaCungCap(string tenNCC, string diaChi, string sdt)
        {
            try
            {
                NHACUNGCAP ncc = new NHACUNGCAP();
                ncc.TENNCC = tenNCC;
                ncc.DIACHI = diaChi;
                ncc.SDT = sdt;
                quanLyKho.NHACUNGCAPs.InsertOnSubmit(ncc);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Xóa nhà cung cấp
        public bool xoaNhaCungCap(int id)
        {
            try
            {
                NHACUNGCAP ncc = quanLyKho.NHACUNGCAPs.Where(s => s.ID_NCC == id).FirstOrDefault();
                quanLyKho.NHACUNGCAPs.DeleteOnSubmit(ncc);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Sửa nhà cung cấp
        public bool suaNhaCungCap(int id, string tenNCC, string diaChi, string sdt)
        {
            try
            {
                NHACUNGCAP ncc = quanLyKho.NHACUNGCAPs.Where(s => s.ID_NCC == id).FirstOrDefault();
                ncc.TENNCC = tenNCC;
                ncc.DIACHI = diaChi;
                ncc.SDT = sdt;
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Lấy sản phẩm trong nhà cung cấp(Danh mục sản phẩm)
        public int SanPham_NCC(int id_ncc)
        {
            DANHMUCSANPHAM sp = quanLyKho.DANHMUCSANPHAMs.FirstOrDefault(s => s.ID_NCC == id_ncc);
            return sp.ID_SP;
        }

        public List<SanPham_IDNCC> get_SanPham_NCC(int id_ncc)
        {
            var data = quanLyKho.DANHMUCSANPHAMs.Where(s => s.ID_NCC == id_ncc).Select(s => new SanPham_IDNCC()
            {
                IntID_SP = s.ID_SP,
                StrTenSP = layTenSanPham(s.ID_SP)
            });
            return data.ToList();
        }

        //Lấy tên sản phẩm
        public string layTenSanPham(int id_sp)
        {
            SANPHAM sp = quanLyKho.SANPHAMs.FirstOrDefault(s => s.ID_SP == id_sp);
            return sp.TENSP;
        }

        public IQueryable searchNhaCungCap(string search)
        {
            var data = quanLyKho.NHACUNGCAPs.Select(s => new
            {
                ID_NCC = s.ID_NCC,
                TENNCC = s.TENNCC
            }
            );
            data = data.Where(s => s.TENNCC.Contains(search));
            return data as IQueryable;
        }

        //Đếm nhà cung cấp
        public int count_NhaCungCap()
        {
            var demNCC = from ncc in quanLyKho.NHACUNGCAPs select ncc;
            return demNCC.Count();
        }
    }
}
