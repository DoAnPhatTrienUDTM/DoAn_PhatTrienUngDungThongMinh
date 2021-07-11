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
using Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class frmXuatHang : Form
    {
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();
        LoaiSanPham_BLL_DAL loaisp = new LoaiSanPham_BLL_DAL();
        NCC_BLL_DAL ncc = new NCC_BLL_DAL();
        PhieuXuat_BLL_DAL phieuxuat = new PhieuXuat_BLL_DAL();
        CTPX_BLL_DAL ctpx = new CTPX_BLL_DAL();
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        NGUOIDUNG ng = new NGUOIDUNG();
        public frmXuatHang()
        {
            InitializeComponent();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Load_DS_SP_XUAT();
            panel2.Enabled = true;
        }
        public void Load_DS_SP_XUAT()
        {
            gridSPCanDat.Rows.Clear();
            gridSPCanDat.Refresh();
            _Application fileimport;
            _Workbook workbook;
            _Worksheet worksheet;
            Range range;
            load_loaiSP();
            try
            {
                fileimport = new Microsoft.Office.Interop.Excel.Application();

                OpenFileDialog opf = new OpenFileDialog();
                //Dialog Box Title
                opf.Title = "Import Excel File To DataGridView";
                //filter Excel Files Only
                opf.Filter = "Choose Excel File | *.xlsx;*.xls;*.xlm";
                //If Open Button Is Clicked
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    workbook = fileimport.Workbooks.Open(opf.FileName);
                    worksheet = workbook.ActiveSheet;
                    range = worksheet.UsedRange;

                    //Start Importing from the second row. Since the first row is column header
                    for (int i = 2; i < range.Rows.Count + 1; i++)
                    {
                        int a = int.Parse(worksheet.Cells[i, 4].Value.ToString());
                        Image img = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\img\\img_sp\\" + worksheet.Cells[i, 7].Value);
                        gridSPCanDat.Rows.Add(worksheet.Cells[i, 1].Value, worksheet.Cells[i, 2].Value, worksheet.Cells[i, 3].Value, a, worksheet.Cells[i, 5].Value, worksheet.Cells[i, 6].Value, img);
                    }
                }
            }
            catch
            {

            }
        }
        public void load_loaiSP()
        {

            cbxloaisp.DataSource = loaisp.loadLoaiSP();
            cbxloaisp.DisplayMember = "TENLOAISANPHAM";
            cbxloaisp.ValueMember = "ID_LSP";
        }

        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            ng = nv.get_Info(Program.main.MaNhanVien);
            lblnv.Text = ng.TEN;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SANPHAM sp = hanghoa.get_sp(int.Parse(gridSPCanDat.CurrentRow.Cells[0].Value.ToString()));
            int slx = int.Parse(gridSPCanDat.CurrentRow.Cells[4].Value.ToString());
            int thanhtien = 0;
            int sl = 0;
            if (txtSLD.Text.Equals(""))
            {
                MessageBox.Show("Phải Nhập Số Lượng");
                return;
            }
            else
            {
                sl = int.Parse(txtSLD.Text);
            }
            if (sl > slx || sl > sp.SOLUONG)
            {
                MessageBox.Show("Không được nhập quá số lượng");
                return;
            }
            if (gridCTDH.Rows.Count == 0)
            {
                thanhtien = (int)sp.DONGIA * int.Parse(txtSLD.Text);
                gridCTDH.Rows.Add(sp.ID_SP, sp.TENSP, txtSLD.Text, (thanhtien));
                cbxNCC.Enabled = false;
            }
            else
            {
                for (int i = 0; i < gridCTDH.Rows.Count; i++)
                {
                    int id = int.Parse(gridCTDH.Rows[i].Cells[0].Value.ToString().Trim());
                    if (id == sp.ID_SP)
                    {
                        MessageBox.Show("sản phẩm đã có trong danh sách đặt hàng");
                        return;
                    }
                }
                thanhtien = (int)sp.DONGIA * int.Parse(txtSLD.Text);
                gridCTDH.Rows.Add(sp.ID_SP, sp.TENSP, txtSLD.Text, (thanhtien));
                cbxNCC.Enabled = false;
            }
            string[] cat = lbltongiten.Text.Split(' ');
            int tongtien = int.Parse(cat[0]) + thanhtien;
            lbltongiten.Text = tongtien.ToString() + " VNĐ";
        }

        private void gridSPCanDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblsanpham.Text = gridSPCanDat.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (gridCTDH.Rows.Count == 0)
            {
                cbxNCC.Enabled = true;
                return;
            }

            int ttcu = int.Parse(gridCTDH.CurrentRow.Cells[3].Value.ToString());
            gridCTDH.Rows.Remove(gridCTDH.CurrentRow);
            string[] cat = lbltongiten.Text.Split(' ');
            int tongtien = int.Parse(cat[0]) - ttcu;
            lbltongiten.Text = tongtien.ToString() + " VNĐ";
            if (gridCTDH.Rows.Count == 0)
            {
                cbxNCC.Enabled = true;
                return;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (gridCTDH.Rows.Count == 0)
                return;
            SANPHAM sp = hanghoa.get_sp(int.Parse(gridSPCanDat.CurrentRow.Cells[0].Value.ToString()));
            int thanhtien = 0;
            int ttcu = int.Parse(gridCTDH.CurrentRow.Cells[3].Value.ToString());
            int idcu = int.Parse(gridCTDH.CurrentRow.Cells[0].Value.ToString());
            if (gridCTDH.Rows.Count == 1 || sp.ID_SP == idcu)
            {

                thanhtien = (int)sp.DONGIA * int.Parse(txtSLD.Text);
                gridCTDH.CurrentRow.Cells[0].Value = sp.ID_SP;
                gridCTDH.CurrentRow.Cells[1].Value = sp.TENSP;
                gridCTDH.CurrentRow.Cells[2].Value = txtSLD.Text;
                gridCTDH.CurrentRow.Cells[3].Value = thanhtien;
                MessageBox.Show("Sửa Thành công");
            }
            else
            {
                for (int i = 0; i < gridCTDH.Rows.Count; i++)
                {
                    int id = int.Parse(gridCTDH.Rows[i].Cells[0].Value.ToString().Trim());
                    if (id == sp.ID_SP)
                    {
                        MessageBox.Show("sản phẩm đã có trong danh sách đặt hàng");
                        return;
                    }
                }
                thanhtien = (int)sp.DONGIA * int.Parse(txtSLD.Text);
                gridCTDH.CurrentRow.Cells[0].Value = sp.ID_SP;
                gridCTDH.CurrentRow.Cells[1].Value = sp.TENSP;
                gridCTDH.CurrentRow.Cells[2].Value = txtSLD.Text;
                gridCTDH.CurrentRow.Cells[3].Value = thanhtien;
                MessageBox.Show("Sửa Thành công");
            }
            string[] cat = lbltongiten.Text.Split(' ');
            int tongtien = int.Parse(cat[0]) + thanhtien - ttcu;
            lbltongiten.Text = tongtien.ToString() + " VNĐ";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string[] ds = lbltongiten.Text.Split(' ');
            phieuxuat.insert_PhieuXuat(ng.ID_DN,cbxNCC.SelectedItem.ToString(), dateTimePicker1.Value.Date, int.Parse(ds[0]));
            int idpd = phieuxuat.countpx();
            for (int i = 0; i < gridCTDH.Rows.Count; i++)
            {
                int idsp = int.Parse(gridCTDH.Rows[i].Cells[0].Value.ToString());
                int sld = int.Parse(gridCTDH.Rows[i].Cells[2].Value.ToString());
                int thannhtien = int.Parse(gridCTDH.Rows[i].Cells[3].Value.ToString());
                ctpx.insert_CTPX(idpd, idsp, sld,thannhtien/sld,thannhtien);
            }
            MessageBox.Show("Xuất hàng Thành Công");
            for (int i = 0; i < gridCTDH.Rows.Count; i++)
            {
                for (int j = 0; j < gridSPCanDat.Rows.Count; j++)
                {
                    if (gridCTDH.Rows[i].Cells[0].Value.ToString().Equals(gridSPCanDat.Rows[j].Cells[0].Value.ToString()))
                    {
                        gridSPCanDat.Rows.RemoveAt(j);
                    }
                }
            }
            gridCTDH.Rows.Clear();
            gridCTDH.Refresh();
            cbxNCC.Enabled = true;
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            frmPhieuXuat frm = new frmPhieuXuat();
            Program.main.openSubForm(frm);
        }
    }
    
}
