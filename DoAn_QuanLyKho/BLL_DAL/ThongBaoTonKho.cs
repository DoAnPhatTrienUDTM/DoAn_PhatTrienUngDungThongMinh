using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ThongBaoTonKho
    {
        private string _strSanPham;
        private int _intKho;
        private int? _intSoLuongTon;

        public int IntKho { get => _intKho; set => _intKho = value; }
        public string StrSanPham { get => _strSanPham; set => _strSanPham = value; }
        public int? IntSoLuongTon { get => _intSoLuongTon; set => _intSoLuongTon = value; }
    }
}
