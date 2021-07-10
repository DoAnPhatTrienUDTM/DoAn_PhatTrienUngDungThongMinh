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
    public partial class frmDatHang : Form
    {
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();
        LoaiSanPham_BLL_DAL loaisp = new LoaiSanPham_BLL_DAL();
        public frmDatHang()
        {
            InitializeComponent();
        }

        private void circularButton1_Click(object sender, EventArgs e)
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
        //public void load_SP(IQueryable HangHoas)
        //{
            
        //    Image img = null;
        //    foreach (SANPHAM item in HangHoas)
        //    {
        //        try
        //        {
        //            if (item.HINHANH != null)
        //            {
        //                string imgpath = Application.StartupPath + "\\img\\img_sp\\" + item.HINHANH;
        //                img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\" + item.HINHANH);
        //                lstimg.Add(imgpath);
        //            }
        //            else
        //            {
        //                img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");
        //                lstimg.Add(Application.StartupPath + "\\img\\img_sp\\product.png");
        //            }

        //        }
        //        catch (Exception)
        //        {

        //            img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");
        //            lstimg.Add(Application.StartupPath + "\\img\\img_sp\\product.png");
        //        }
        //        gridHangHoa.Rows.Add(item.ID_SP, item.TENSP, item.DVT, item.SOLUONG, img, item.DONGIA, item.NGAYNHAP, item.ID_LSP);
        //    }
        //}
    }
}
