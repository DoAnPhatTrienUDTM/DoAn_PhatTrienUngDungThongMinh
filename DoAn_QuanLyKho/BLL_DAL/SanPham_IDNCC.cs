using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class SanPham_IDNCC
    {
        private int _intID_SP;
        private string _strTenSP;

        public int IntID_SP { get => _intID_SP; set => _intID_SP = value; }
        public string StrTenSP { get => _strTenSP; set => _strTenSP = value; }
    }
}
