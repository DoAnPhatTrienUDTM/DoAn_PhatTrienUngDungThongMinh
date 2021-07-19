using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class SPXuatNhieu
    {
        private int id;
        private int soluong;

        public int Id { get => id; set => id = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public SPXuatNhieu(int id, int soluong)
        {
            Id = id;
            Soluong = soluong;
        }

        public SPXuatNhieu()
        {
        }
    }
}
