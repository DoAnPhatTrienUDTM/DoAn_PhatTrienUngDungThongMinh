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

namespace GUI
{
    public partial class frmHangHoaTheoKho : Form
    {
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();
        LoaiSanPham_BLL_DAL loaisp = new LoaiSanPham_BLL_DAL();
        OpenFileDialog opf = new OpenFileDialog();
        List<string> lstimg = new List<string>();
        TonKho_BLL_DAL tonkho = new TonKho_BLL_DAL();
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        NGUOIDUNG nd = new NGUOIDUNG();
        public frmHangHoaTheoKho()
        {
            InitializeComponent();
        }
        public void loadCbbLoaiSP(DataGridViewComboBoxColumn cbo)
        {
            cbbLoaiSP.DataSource = loaisp.loadLoaiSP();
            cbbLoaiSP.DisplayMember = "TENLOAISANPHAM";
            cbbLoaiSP.ValueMember = "ID_LSP";
            cbbLoaiSP.DefaultCellStyle.BackColor = System.Drawing.Color.White;
        }

        private void cbxloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOAISANPHAM loai = (LOAISANPHAM)cbxloaisp.SelectedItem;
            IQueryable hanghoas = hanghoa.get_DataSP_LSP(loai.ID_LSP);
            load_SP(hanghoas);
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            DateTime date = bunifuDatepicker1.Value.Date;
            load_SP(hanghoa.get_DataSP_NN(date));
        }

        public void load_SP(IQueryable HangHoas)
        {
            lstimg.Clear();
            gridHangHoa.Rows.Clear();
            gridHangHoa.Refresh();
            loadCbbLoaiSP(cbbLoaiSP);
            Image img = null;
            foreach (SANPHAM item in HangHoas)
            {
                try
                {
                    if (item.HINHANH != null)
                    {
                        string imgpath = Application.StartupPath + "\\img\\img_sp\\" + item.HINHANH;
                        img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\" + item.HINHANH);
                        lstimg.Add(imgpath);
                    }
                    else
                    {
                        img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");
                        lstimg.Add(Application.StartupPath + "\\img\\img_sp\\product.png");
                    }

                }
                catch (Exception)
                {

                    img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");
                    lstimg.Add(Application.StartupPath + "\\img\\img_sp\\product.png");
                }
                int soluong = tonkho.get_SL(nd.ID_KHO, item.ID_SP);
                gridHangHoa.Rows.Add(item.ID_SP, item.TENSP, item.DVT, item.ID_LSP, soluong, item.DONGIA, img, item.NGAYNHAP);
            }
        }

        
        public string get_nameIMG()
        {
            string imagepath = "";

            string imagePath = opf.FileName.ToString();
            if (!imagePath.Equals(""))
            {
                imagepath = imagePath.ToString();
                imagepath = imagepath.Substring(imagepath.LastIndexOf("\\"));
                imagepath = imagepath.Remove(0, 1);
            }

            return imagepath;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IQueryable hanghoas = hanghoa.get_DataSP_Search(txtSearch.Text.ToString().Trim());
            load_SP(hanghoas);
        }

        private void gridHangHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gridHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridHangHoa.ReadOnly)
            {

            }
            else
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    opf.Reset();
                    opf.Filter = "Choose Image(*.jpg; *.png;*.gif)|*.jpg; *.png;*.gif";
                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        gridHangHoa.CurrentCell.Value = Image.FromFile(opf.FileName);

                    }
                }
            }
        }

        private void btnexprot_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);

            for (int i = 1; i <= gridHangHoa.Columns.Count; i++)
            {
                xcelApp.Cells[1, i] = gridHangHoa.Columns[i - 1].HeaderText;
            }
            int dem = 2;
            for (int i = 0; i < gridHangHoa.Rows.Count; i++)
            {
                int sl = int.Parse(gridHangHoa.Rows[i].Cells[4].Value.ToString());

                if (sl < 50)
                {
                    for (int j = 0; j < gridHangHoa.Columns.Count; j++)
                    {
                        if (j == 6)
                        {
                            string imgpath = lstimg[i];
                            string nameImage = imgpath.Substring(imgpath.LastIndexOf('\\') + 1);
                            xcelApp.Cells[dem, j + 1] = nameImage;
                        }
                        else
                        {
                            xcelApp.Cells[dem, j + 1] = gridHangHoa.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    dem++;
                }
            }

            xcelApp.Columns.AutoFit();
            xcelApp.Visible = true;
        }

        private void frmHangHoaTheoKho_Load(object sender, EventArgs e)
        {
            nd = nv.get_Info(Program.main.MaNhanVien);
            cbxloaisp.DataSource = loaisp.loadLoaiSP();
            cbxloaisp.DisplayMember = "TENLOAISANPHAM";
            cbxloaisp.ValueMember = "ID_LSP";
            load_SP(hanghoa.LoadHangHoa());
        }
    }
}
