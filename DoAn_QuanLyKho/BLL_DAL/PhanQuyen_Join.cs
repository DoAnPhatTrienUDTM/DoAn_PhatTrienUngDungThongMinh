using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PhanQuyen_Join
    {
        //private string _strIDNhom;
        private int _intIDManHinh;
        private string _strTenManHinh;
        private bool? _bolCoQuyen;

        //public string StrIDNhom { get => _strIDNhom; set => _strIDNhom = value; }
        public int IntIDManHinh { get => _intIDManHinh; set => _intIDManHinh = value; }
        public string StrTenManHinh { get => _strTenManHinh; set => _strTenManHinh = value; }
        public bool? BolCoQuyen { get => _bolCoQuyen; set => _bolCoQuyen = value; }
    }
}
