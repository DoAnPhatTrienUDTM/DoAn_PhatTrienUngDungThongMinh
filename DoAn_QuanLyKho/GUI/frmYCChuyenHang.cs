using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using Custom_Control;

namespace GUI
{
    public partial class frmYCChuyenHang : Form
    {
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();
        public List<SANPHAM> list = new List<SANPHAM>();
        LoaiSanPham_BLL_DAL loaisp = new LoaiSanPham_BLL_DAL();
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        NGUOIDUNG ng = new NGUOIDUNG();
        CTPX_BLL_DAL ctpx = new CTPX_BLL_DAL();
        TonKho_BLL_DAL tonkho = new TonKho_BLL_DAL();
        YCChuyenHang_BLL_DAL YCCH = new YCChuyenHang_BLL_DAL();
        CT_YCXH ctpc = new CT_YCXH();
        public frmYCChuyenHang()
        {
            InitializeComponent();
        }
        public void Load_DL()
        {
            gridSPCanChuyen.Rows.Clear();
            gridSPCanChuyen.Refresh();
            load_loaiSP();
            foreach (SANPHAM item in list)
            {
                int soluong = tonkho.get_SL(Program.main.nd.ID_KHO, item.ID_SP);
                Image img = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\img\\img_sp\\" + item.HINHANH);
                gridSPCanChuyen.Rows.Add(item.ID_SP,item.TENSP,soluong,item.ID_LSP,img);
            }
        }
        public void load_loaiSP()
        {

            cbxLoaiSp.DataSource = loaisp.loadLoaiSP();
            cbxLoaiSp.DisplayMember = "TENLOAISANPHAM";
            cbxLoaiSp.ValueMember = "ID_LSP";
        }

        private void frmYCChuyenHang_Load(object sender, EventArgs e)
        {
            lblidKho.Text = Program.main.nd.ID_KHO.ToString();
            lblnv.Text = Program.main.nd.TEN;
            Load_DL();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtSLD.Text.Equals(""))
            {
                this.Alert("Phải nhập số lượng!", frmNotificationCustom.enmType.Warning);
                return;
            }
            SANPHAM sp = hanghoa.get_sp(int.Parse(gridSPCanChuyen.CurrentRow.Cells[0].Value.ToString()));
            
            if (gridCTCH.Rows.Count == 0)
            {
                gridCTCH.Rows.Add(sp.ID_SP, sp.TENSP, txtSLD.Text);
         ;
            }
            else
            {
                for (int i = 0; i < gridCTCH.Rows.Count; i++)
                {
                    int id = int.Parse(gridCTCH.Rows[i].Cells[0].Value.ToString().Trim());
                    if (id == sp.ID_SP)
                    {
                        this.Alert("Sản phẩm đã có trong danh sách đặt hàng!", frmNotificationCustom.enmType.Warning);
                        return;
                    }
                }
                gridCTCH.Rows.Add(sp.ID_SP, sp.TENSP, txtSLD.Text);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (gridCTCH.Rows.Count == 0)
            {
               
                return;
            }
            gridCTCH.Rows.Remove(gridCTCH.CurrentRow);
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (gridCTCH.Rows.Count == 0)
                return;
            SANPHAM sp = hanghoa.get_sp(int.Parse(gridSPCanChuyen.CurrentRow.Cells[0].Value.ToString()));
            int idcu = int.Parse(gridCTCH.CurrentRow.Cells[0].Value.ToString());
            if (gridCTCH.Rows.Count == 1 || sp.ID_SP == idcu)
            {


                gridCTCH.CurrentRow.Cells[0].Value = sp.ID_SP;
                gridCTCH.CurrentRow.Cells[1].Value = sp.TENSP;
                gridCTCH.CurrentRow.Cells[2].Value = txtSLD.Text;

                this.Alert("Sửa thành công!", frmNotificationCustom.enmType.Success);
            }
            else
            {
                for (int i = 0; i < gridCTCH.Rows.Count; i++)
                {
                    int id = int.Parse(gridCTCH.Rows[i].Cells[0].Value.ToString().Trim());
                    if (id == sp.ID_SP)
                    {
                        this.Alert("Sản phẩm đã có trong danh sách đặt hàng!", frmNotificationCustom.enmType.Warning); return;
                    }
                }
                gridCTCH.CurrentRow.Cells[0].Value = sp.ID_SP;
                gridCTCH.CurrentRow.Cells[1].Value = sp.TENSP;
                gridCTCH.CurrentRow.Cells[2].Value = txtSLD.Text;
                this.Alert("Sửa thành công!", frmNotificationCustom.enmType.Success);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (YCCH.insertYCCH(Program.main.nd.ID_KHO, Program.main.nd.ID_DN, dateTimePicker1.Value.Date))
            {
                int id = YCCH.get_ID_pC();
                for (int i = 0; i < gridCTCH.Rows.Count; i++)
                {
                    int idsp = int.Parse(gridCTCH.Rows[i].Cells[0].Value.ToString());
                    int sld = int.Parse(gridCTCH.Rows[i].Cells[2].Value.ToString());
                    ctpc.insert_CT(id, idsp, sld);
                }
                this.Alert("Yêu cầu chuyển hàng thành công!", frmNotificationCustom.enmType.Success);
                for (int i = 0; i < gridCTCH.Rows.Count; i++)
                {
                    for (int j = 0; j < gridSPCanChuyen.Rows.Count; j++)
                    {
                        if (gridCTCH.Rows[i].Cells[0].Value.ToString().Equals(gridSPCanChuyen.Rows[j].Cells[0].Value.ToString()))
                        {
                            gridSPCanChuyen.Rows.RemoveAt(j);
                        }
                    }
                }
                gridCTCH.Rows.Clear();
                gridCTCH.Refresh();
            }
        }
    }
}
