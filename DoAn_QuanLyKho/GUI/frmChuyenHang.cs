using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraMap;
using BLL_DAL;
using Custom_Control;

namespace GUI
{
    public partial class frmChuyenHang : Form
    {
        List<float> list = new List<float>();
        KhoBLL_DAL kho = new KhoBLL_DAL();
        public YEUCAUCHUYENHANG ycch = new YEUCAUCHUYENHANG();
        CT_YCXH ctpc = new CT_YCXH();
        LoaiSanPham_BLL_DAL loaisp = new LoaiSanPham_BLL_DAL();
        KNN mode = new KNN();
        ChuyenHang_BLL_DAL chuyenhang = new ChuyenHang_BLL_DAL();
        YCChuyenHang_BLL_DAL yeucau = new YCChuyenHang_BLL_DAL();
        TonKho_BLL_DAL tonkho = new TonKho_BLL_DAL();
        string bingKey = "AfZfySbZHoncdc1eVAof~GtnslxluK2HzjJJcD74jmA~AjjuvKu5PtgxKMpqgvkY-O6n_7AVw82zkzsHXr434lumQ45H9Kx1oFq9U9NlMLOK";

        public frmChuyenHang()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        public void AddWayPoint(string address1, string address2)
        {
            try
            {
                BingRouteDataProvider provider = new BingRouteDataProvider
                {
                    BingKey = bingKey
                };
                mapControl1.Layers.Add(new InformationLayer
                {
                    DataProvider = provider
                });
                mapControl1.Layers.Add(new ImageLayer()
                {
                    DataProvider = new BingMapDataProvider()
                    {
                        BingKey = bingKey
                    }
                });

                //this event will generate later
                provider.RouteCalculated += OnRouteCalculated;

                List<RouteWaypoint> waypoints = new List<RouteWaypoint>();
                //Add waypoint means Address
                waypoints.Add(new RouteWaypoint("From Address", address1));
                waypoints.Add(new RouteWaypoint("To Address", address2));
                provider.CalculateRoute(waypoints);
                

                provider.LayerItemsGenerating += routeLayerItemGenerating;
                System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            }
            catch
            {

            }
        }

        public void OnRouteCalculated(object sender, BingRouteCalculatedEventArgs e)
        {
            SearchBoundingBox box = e.CalculationResult.RouteResults[0].BoundingBox;
            GeoPoint topleft = new GeoPoint
            {
                Latitude = box.NorthLatitude,
                Longitude = box.WestLongitude,
            };
            GeoPoint bottomRight = new GeoPoint
            {
                Latitude = box.SouthLatitude,
                Longitude = box.EastLongitude,
            };

            //Add devpress.map.core.dll
            mapControl1.ZoomToRegion(topleft, bottomRight, 0.4);
            RouteCalculationResult result = e.CalculationResult;
            if ((result.RouteResults != null) & (result.ResultCode == RequestResultCode.Success))
            {
                for (int rnum = 0; rnum < e.CalculationResult.RouteResults.Count; rnum++)
                {
                    if (e.CalculationResult.RouteResults[rnum].Legs != null)
                    {
                        //int legNum = 1;
                        foreach (BingRouteLeg leg in e.CalculationResult.RouteResults[rnum].Legs)
                            list.Add(float.Parse(leg.Distance.ToString("0.00")));
                    }
                }
            }
        }
        private void routeLayerItemGenerating(object sender, LayerItemsGeneratingEventArgs e)
        {
            if (e.Cancelled || (e.Error != null)) return;

            //Char PushPin Marker = 'A';
            foreach (MapItem item in e.Items)
            {
                MapPolyline polyline = item as MapPolyline;
                if (polyline != null)
                {
                    polyline.Stroke = Color.FromArgb(0xFF, 0x00, 0x72, 0xC6);
                    polyline.StrokeWidth = 4;
                }
            }
        }
        public void Load_DL()
        {
            gridSPCanChuyen.Rows.Clear();
            gridSPCanChuyen.Refresh();
            load_loaiSP();
            foreach (CHITTIETCHUYENHANG item in ctpc.get_CTYC(ycch.ID_PC))
            {
                Image img = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\img\\img_sp\\" + item.SANPHAM.HINHANH);
                gridSPCanChuyen.Rows.Add(item.ID_SP, item.SANPHAM.TENSP, item.SANPHAM.DVT, item.SANPHAM.ID_LSP, item.SOLUONG, img);
            }
        }
        public void load_loaiSP()
        {

            cbxloaisp.DataSource = loaisp.loadLoaiSP();
            cbxloaisp.DisplayMember = "TENLOAISANPHAM";
            cbxloaisp.ValueMember = "ID_LSP";
        }

        private void frmChuyenHang_Load(object sender, EventArgs e)
        {
            Load_DL();
            lblnv.Text = ycch.NGUOIDUNG.TEN;
            lblmakho.Text = ycch.ID_KHO.ToString();
            lblDC.Text = ycch.THONGTINKHO.DIACHI;
        }

        private void btnTimKho_Click(object sender, EventArgs e)
        {
            try
            {
                list.Add(0);
                int slCanChuyen = int.Parse(gridSPCanChuyen.CurrentRow.Cells[4].Value.ToString());
                int idsp = int.Parse(gridSPCanChuyen.CurrentRow.Cells[0].Value.ToString());
                string Ten = gridSPCanChuyen.CurrentRow.Cells[1].Value.ToString();
                int idkho = ycch.ID_KHO;
                List<float> slt = new List<float>();
                List<float> slx_tb = new List<float>();
                List<ThongTin> dsTT = mode.getTT(idkho, idsp, slCanChuyen, slx_tb, slt);

                List<float> slt_da_chuanhoa = new List<float>();
                List<float> slx_tb_da_chuanhoa = new List<float>();
                List<float> Khoangcach_chuanhoa = new List<float>();

                mode.chuanhoa(slt, slt_da_chuanhoa);
                mode.chuanhoa(slx_tb, slx_tb_da_chuanhoa);
                mode.chuanhoa(list, Khoangcach_chuanhoa);

                float slchuyen = slt_da_chuanhoa[slt_da_chuanhoa.Count - 1];
                float slx = slx_tb_da_chuanhoa[slx_tb_da_chuanhoa.Count - 1];
                int tong = 0;
                int tongcanchuyen = 0;
                for (int i = 0; i < dsTT.Count; i++)
                {
                    dsTT[i].Soluongton = slt_da_chuanhoa[i];
                    dsTT[i].Slx_tb = slx_tb_da_chuanhoa[i];
                    dsTT[i].Khoangcach = Khoangcach_chuanhoa[i];
                }
                List<float> KQ = mode.tinhkhoangcach(dsTT, slchuyen, slx);
                for (int i = 0; i < dsTT.Count; i++)
                {
                    dsTT[i].Kq = KQ[i];
                }
                mode.sapXepTang(dsTT);
                List<ThongTin> dsThoaDK = new List<ThongTin>();

                foreach (ThongTin item in dsTT)
                {
                    if (tong >= slCanChuyen)
                        break;
                    else
                    {
                        int sl = tonkho.get_SL(item.Idkho, idsp);
                        item.Soluongton = sl;
                        tong += (int)item.Soluongton;
                        dsThoaDK.Add(item);
                    }


                }
                if (tong < slCanChuyen)
                {
                    //MessageBox.Show("khong du hang de chuyen");
                    this.Alert("Không đủ hàng để chuyển!", frmNotificationCustom.enmType.Warning);
                    return;
                }
                foreach (ThongTin item in dsThoaDK)
                {
                    if (tongcanchuyen + item.Soluongton < slCanChuyen)
                    {
                        gridCTCH.Rows.Add(idsp, Ten, item.Idkho, item.Soluongton);
                        tongcanchuyen += (int)item.Soluongton;
                    }
                    else
                    {
                        gridCTCH.Rows.Add(idsp, Ten, item.Idkho, slCanChuyen - tongcanchuyen);
                    }
                }
                gridSPCanChuyen.Rows.Remove(gridSPCanChuyen.CurrentRow);
                btnTimKho.Enabled = false;
                if (gridSPCanChuyen.Rows.Count == 0)
                    btnxacnhan.Enabled = true;
            }
            catch
            {
                this.Alert("Vui lòng chọn!", frmNotificationCustom.enmType.Warning);
            }
        }

        private void gridSPCanChuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int slCanChuyen = int.Parse(gridSPCanChuyen.CurrentRow.Cells[4].Value.ToString());
            int idsp = int.Parse(gridSPCanChuyen.CurrentRow.Cells[0].Value.ToString());
            string Ten = gridSPCanChuyen.CurrentRow.Cells[1].Value.ToString();
            int idkho = ycch.ID_KHO;
            List<float> slt = new List<float>();
            List<float> slx_tb = new List<float>();
            List<ThongTin> dsTT = mode.getTT(idkho, idsp, slCanChuyen, slx_tb, slt);
            foreach (ThongTin item in dsTT)
            {
                AddWayPoint(ycch.THONGTINKHO.DIACHI, item.DiaChi1);
            }
            btnTimKho.Enabled = true;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < gridCTCH.Rows.Count; i++)
            {
                int idkho = int.Parse(gridCTCH.Rows[i].Cells[2].Value.ToString());
                int idsp = int.Parse(gridCTCH.Rows[i].Cells[0].Value.ToString());
                int sl = int.Parse(gridCTCH.Rows[i].Cells[3].Value.ToString());

                if (!chuyenhang.insertCH(ycch.ID_PC, idkho, idsp, sl))
                {
                    //MessageBox.Show("That Bai");
                    this.Alert("Thất bại!", frmNotificationCustom.enmType.Error);
                    return;
                }
            }
            //MessageBox.Show("ThanhCong");
            this.Alert("Thành công!", frmNotificationCustom.enmType.Success);
            gridCTCH.Rows.Clear();
            gridCTCH.Refresh();
            yeucau.updatetrngthai(ycch.ID_PC);
        }
    }
}
