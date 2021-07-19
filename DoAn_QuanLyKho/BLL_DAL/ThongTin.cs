using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ThongTin
    {
        int idkho;
        float slx_tb,khoangcach, soluongton,kq;
        string DiaChi;

        
       
       
        public float Slx_tb { get => slx_tb; set => slx_tb = value; }
        public float Khoangcach { get => khoangcach; set => khoangcach = value; }
        public float Soluongton { get => soluongton; set => soluongton = value; }
        public float Kq { get => kq; set => kq = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public int Idkho { get => idkho; set => idkho = value; }
    }
}
