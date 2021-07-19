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
    public partial class frmNhapHang : Form
    {
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();
        LoaiSanPham_BLL_DAL loaisp = new LoaiSanPham_BLL_DAL();
        NCC_BLL_DAL ncc = new NCC_BLL_DAL();
        PhieuDat_BLL_DAL phieudat = new PhieuDat_BLL_DAL();
        CTPD_BLL_DAL ctpd = new CTPD_BLL_DAL();
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        NGUOIDUNG ng = new NGUOIDUNG();
        PhieuNhap_BLL_DAL phieunhap = new PhieuNhap_BLL_DAL();
        CTPN_BLL_DAL ctpn = new CTPN_BLL_DAL();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            ng = nv.get_Info(Program.main.MaNhanVien);
            lblnv.Text = ng.TEN;
            Load_PD(phieudat.get_PD_false(ng.ID_KHO));
        }
        public void Load_PD(IQueryable dspd)
        {
            gridPDFalse.Rows.Clear();
            gridPDFalse.Refresh();
            foreach (PHIEUDAT pd in dspd)
            {
                gridPDFalse.Rows.Add(pd.ID_PD, pd.NHACUNGCAP.TENNCC, pd.NGUOIDUNG.TEN, pd.NGAYLAP, pd.TONGTIEN);
            }
        }
        public void load_CbxSP_Ncc(int idpd)
        {
            cbxsp.DataSource = hanghoa.get_SP_CHUAGIAO(idpd);
            cbxsp.DisplayMember = "TENSP";
            cbxsp.ValueMember = "ID_SP";
        }

        private void gridPDFalse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Enabled = true;
            lblncc.Text = gridPDFalse.CurrentRow.Cells[1].Value.ToString();
            load_CbxSP_Ncc(int.Parse(gridPDFalse.CurrentRow.Cells[0].Value.ToString()));
        }

        private void lbltongiten_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int idpd = int.Parse(gridPDFalse.CurrentRow.Cells[0].Value.ToString());
            SANPHAM sp = hanghoa.get_sp(int.Parse(cbxsp.SelectedValue.ToString()));
            int thanhtien = 0;
            int sldanhap = ctpn.get_SP_DANHAP(idpd, sp.ID_SP);
            int sl = 0;
            if (txtSLD.Text.Equals("") || txtDGN.Text.Equals(""))
            {
                this.Alert("Không được bỏ trống!", frmNotificationCustom.enmType.Warning);
                return;
            }
            else
            {
                sl = int.Parse(txtSLD.Text);
            }
            if (!ctpd.ktslnhap(idpd, sp.ID_SP, sldanhap + sl))
            {
                this.Alert("Không nhập quá số lượng đã đặt!", frmNotificationCustom.enmType.Warning);
                return;
            }

            if (gridCTNH.Rows.Count == 0)
            {
                thanhtien = int.Parse(txtDGN.Text) * int.Parse(txtSLD.Text);
                gridCTNH.Rows.Add(sp.ID_SP, sp.TENSP, txtSLD.Text, txtDGN.Text, (thanhtien));
                gridPDFalse.Enabled = false;
            }
            else
            {
                for (int i = 0; i < gridCTNH.Rows.Count; i++)
                {
                    int id = int.Parse(gridCTNH.Rows[i].Cells[0].Value.ToString().Trim());
                    if (id == sp.ID_SP)
                    {
                        this.Alert("Sản phẩm đã có trong danh sách đặt hàng!", frmNotificationCustom.enmType.Info);
                        return;
                    }
                }
                thanhtien = (int)sp.DONGIA * int.Parse(txtSLD.Text);
                gridCTNH.Rows.Add(sp.ID_SP, sp.TENSP, txtSLD.Text, txtDGN.Text, (thanhtien));

            }
            string[] cat = lbltongiten.Text.Split(' ');
            int tongtien = int.Parse(cat[0]) + thanhtien;
            lbltongiten.Text = tongtien.ToString() + " VNĐ";
            txtDGN.Text = "";
            txtSLD.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (gridCTNH.Rows.Count == 0)
                return;
            SANPHAM sp = hanghoa.get_sp(int.Parse(cbxsp.SelectedValue.ToString()));
            int thanhtien = 0;
            int ttcu = int.Parse(gridCTNH.CurrentRow.Cells[4].Value.ToString());
            int idcu = int.Parse(gridCTNH.CurrentRow.Cells[0].Value.ToString());
            if (gridCTNH.Rows.Count == 1 || sp.ID_SP == idcu)
            {

                thanhtien = int.Parse(txtDGN.Text) * int.Parse(txtSLD.Text);
                gridCTNH.CurrentRow.Cells[0].Value = sp.ID_SP;
                gridCTNH.CurrentRow.Cells[1].Value = sp.TENSP;
                gridCTNH.CurrentRow.Cells[2].Value = txtSLD.Text;
                gridCTNH.CurrentRow.Cells[3].Value = txtDGN.Text;
                gridCTNH.CurrentRow.Cells[4].Value = thanhtien;
            }
            else
            {
                for (int i = 0; i < gridCTNH.Rows.Count; i++)
                {
                    int id = int.Parse(gridCTNH.Rows[i].Cells[0].Value.ToString().Trim());
                    if (id == sp.ID_SP)
                    {
                        this.Alert("Sản phẩm đã có trong danh sách đặt hàng!", frmNotificationCustom.enmType.Info);
                        return;
                    }
                }
                thanhtien = int.Parse(txtDGN.Text) * int.Parse(txtSLD.Text);
                gridCTNH.CurrentRow.Cells[0].Value = sp.ID_SP;
                gridCTNH.CurrentRow.Cells[1].Value = sp.TENSP;
                gridCTNH.CurrentRow.Cells[2].Value = txtSLD.Text;
                gridCTNH.CurrentRow.Cells[3].Value = txtDGN.Text;
                gridCTNH.CurrentRow.Cells[4].Value = thanhtien;
            }
            string[] cat = lbltongiten.Text.Split(' ');
            int tongtien = int.Parse(cat[0]) + thanhtien - ttcu;
            lbltongiten.Text = tongtien.ToString() + " VNĐ";
        }

        private void gridCTNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (gridCTNH.Rows.Count == 0)
                return;
            int ttcu = int.Parse(gridCTNH.CurrentRow.Cells[4].Value.ToString());
            gridCTNH.Rows.Remove(gridCTNH.CurrentRow);
            string[] cat = lbltongiten.Text.Split(' ');
            int tongtien = int.Parse(cat[0]) - ttcu;
            lbltongiten.Text = tongtien.ToString() + " VNĐ";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load_PD(phieudat.get_PD_false_search(ng.ID_KHO, txtSearch.Text));
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            Load_PD(phieudat.get_PD_false_date(ng.ID_KHO, bunifuDatepicker1.Value.Date));
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string[] ds = lbltongiten.Text.Split(' ');
            PHIEUDAT pd = phieudat.getPD(int.Parse(gridPDFalse.CurrentRow.Cells[0].Value.ToString()));
            phieunhap.insert_PhieuNhap(pd.ID_PD, (int)pd.ID_NCC, ng.ID_DN, dateTimePicker1.Value.Date, int.Parse(ds[0]));
            int idpn = phieunhap.countpn();
            for (int i = 0; i < gridCTNH.Rows.Count; i++)
            {
                int idsp = int.Parse(gridCTNH.Rows[i].Cells[0].Value.ToString());
                int sld = int.Parse(gridCTNH.Rows[i].Cells[2].Value.ToString());
                int dongia = int.Parse(gridCTNH.Rows[i].Cells[3].Value.ToString());
                int thanhtien = int.Parse(gridCTNH.Rows[i].Cells[4].Value.ToString());
                if (!ctpn.insert_CTPN(ng.ID_KHO, idpn, idsp, sld, dongia, thanhtien))
                {
                    this.Alert("Lỗi nhập chi tiết phiếu nhập!", frmNotificationCustom.enmType.Warning);
                }
            }
            phieudat.update_TrangThai_PD(pd.ID_PD);
            this.Alert("Nhập hàng thành công!", frmNotificationCustom.enmType.Success);
            gridCTNH.Rows.Clear();
            gridCTNH.Refresh();
            Load_PD(phieudat.get_PD_false(ng.ID_KHO));
            gridPDFalse.Enabled = true;
        }

        private void btnds_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap();
            Program.main.openSubForm(frm);
        }

        private void txtSLD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDGN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
