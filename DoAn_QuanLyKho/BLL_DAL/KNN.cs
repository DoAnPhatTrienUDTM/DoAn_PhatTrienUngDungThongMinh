using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL_DAL
{
    public class KNN
    {
        TonKho_BLL_DAL tonkho = new TonKho_BLL_DAL();

        CTPX_BLL_DAL ctpx = new CTPX_BLL_DAL();
        public float timMax(List<float>  a)
        {
            float max = a[0];
            for (int i = 1; i < a.Count;i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
        public float timMin(List<float> a)
        {
            float min = a[0];
            for (int i = 1; i < a.Count; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }
        public List<ThongTin> getTT(int idkho,int idsp, int soluong,List<float> ds_slx_tb,List<float> ds_slt)
        {

            List<ThongTin> list = new List<ThongTin>();

            foreach (TONKHO item in tonkho.get_SLTon_Chuyen(idsp, soluong,idkho))
            {
                ThongTin tt = new ThongTin();
                tt.Idkho = item.ID_KHO;
                tt.DiaChi1 = item.THONGTINKHO.DIACHI;
                ds_slt.Add(item.SOLUONGTON.Value);
                ds_slx_tb.Add(ctpx.get_TB_Xuat(item.ID_KHO, idsp));
                list.Add(tt);
            }
            ds_slt.Add(soluong);
            ds_slx_tb.Add(soluong);
            return list;
        }
        public void chuanhoa(List<float> input, List<float> output)
        {
            float max = timMax(input);
            float min = timMin(input);
            for (int i = 0; i < input.Count; i++)
            {
                output.Add((input[i] - min) / (max - min));
            }
        }
        public List<float> tinhkhoangcach(List<ThongTin> ds, float soluongton,float slx_tb)
        {
            List<float> kq = new List<float>();
            foreach (ThongTin item in ds)
            {
                float khoangcach = (float)Math.Sqrt(Math.Pow(item.Khoangcach, 2) +Math.Pow((item.Soluongton-soluongton),2)+Math.Pow((item.Slx_tb-slx_tb),2));
                kq.Add(khoangcach);
            }
            return kq;
        }
        public ThongTin sapxepGiamVaLayKQ(List<ThongTin> a)
        {
            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[j].Kq > a[i].Kq)
                    {
                        ThongTin t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
            return a[0];
        }
    }
}
