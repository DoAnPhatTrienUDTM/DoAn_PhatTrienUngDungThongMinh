using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class frmHangHoa : Form
    {
        Hanghoa_BLL_DAL hanghoa = new Hanghoa_BLL_DAL();
        LoaiSanPham_BLL_DAL loaisp = new LoaiSanPham_BLL_DAL();
        OpenFileDialog opf = new OpenFileDialog();
        List<string> lstimg = new List<string>();
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            cbxloaisp.DataSource = loaisp.loadLoaiSP();
            cbxloaisp.DisplayMember = "TENLOAISANPHAM";
            cbxloaisp.ValueMember = "ID_LSP";
            load_SP(hanghoa.LoadHangHoa());
        }
        public void loadCbbLoaiSP(DataGridViewComboBoxColumn cbo)
        {
            cbbLoaiSP.DataSource = loaisp.loadLoaiSP();
            cbbLoaiSP.DisplayMember = "TENLOAISANPHAM";
            cbbLoaiSP.ValueMember = "ID_LSP";
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            gridHangHoa.Rows.Add();
            gridHangHoa.ReadOnly = false;
            for (int i = 0; i < gridHangHoa.Rows.Count; i++)
            {
                if (i == gridHangHoa.Rows.Count-1)
                {
                    gridHangHoa.Rows[i].ReadOnly = false;
                    gridHangHoa.Rows[i].Cells[0].ReadOnly = true;
                    gridHangHoa.Rows[i].Cells[0].Value = gridHangHoa.Rows.Count.ToString();
                    DataGridViewButtonCell btn = (DataGridViewButtonCell)gridHangHoa.Rows[i].Cells["btnsua"];
                    btn.UseColumnTextForButtonValue = false;
                    btn.Value = string.Empty;
                }
                else
                {
                    gridHangHoa.Rows[i].ReadOnly = true;
                }
            }
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
                gridHangHoa.Rows.Add(item.ID_SP, item.TENSP, item.DVT, item.SOLUONG,img, item.DONGIA,item.NGAYNHAP,item.ID_LSP);
            }
        }

        private void gridHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 8)
            {
                if (btnsua.Text.Equals("xóa"))
                {
                    
                }
                else
                {
                    gridHangHoa.ReadOnly = false;
                    for (int i = 0; i < gridHangHoa.Rows.Count; i++)
                    {
                        if (i == e.RowIndex)
                        {
                            gridHangHoa.Rows[e.RowIndex].ReadOnly = false;
                            gridHangHoa.Rows[i].Cells[0].ReadOnly = true;
                        }
                        else
                        {
                            gridHangHoa.Rows[i].ReadOnly = true;
                        }
                    }
                }

            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.ColumnIndex == 9)
            {
                DataGridViewButtonCell btn = (DataGridViewButtonCell)gridHangHoa.CurrentRow.Cells["btnsua"];
                gridHangHoa.ReadOnly = true;
                DataGridViewRow row = gridHangHoa.Rows[e.RowIndex];
                int idsp = int.Parse(row.Cells[0].Value.ToString());
                int idlsp = int.Parse(row.Cells[7].Value.ToString());
                int dongia = int.Parse(row.Cells[5].Value.ToString());
                
                if (btn.UseColumnTextForButtonValue)
                {
                    string imgpath = lstimg[e.RowIndex];
                    string nameImage = imgpath.Substring(imgpath.LastIndexOf('\\') + 1);
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin!", "Thông báo", MessageBoxButtons.YesNo);
                    if (get_nameIMG().Equals(""))
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (hanghoa.update_SanPham(idsp, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), nameImage, dongia, idlsp))
                            {
                                load_SP(hanghoa.LoadHangHoa());

                                MessageBox.Show("Cập nhật thành công!");
                            }
                            else
                                MessageBox.Show("Cập nhật không thành công!");
                        }
                    }
                    else
                    {
                        var filename = Path.GetFileName(opf.FileName);
                        var path = Path.Combine(Application.StartupPath + "\\img\\img_sp\\", filename);
                        File.Copy(opf.FileName,path,true);
                        if (hanghoa.update_SanPham(idsp, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), filename, dongia, idlsp))
                        {
                            load_SP(hanghoa.LoadHangHoa());

                            MessageBox.Show("Cập nhật thành công!");
                        }
                        else
                            MessageBox.Show("Cập nhật không thành công!");
                    }

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin!", "Thông báo", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var filename = Path.GetFileName(opf.FileName);
                        var path = Path.Combine(Application.StartupPath + "\\img\\img_sp\\", filename);
                        File.Copy(opf.FileName, path);
                        if (hanghoa.insert_SanPham(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(),idlsp,filename, dongia))
                        {
                            load_SP(hanghoa.LoadHangHoa());

                            MessageBox.Show("Cập nhật thành công!");
                        }
                        else
                            MessageBox.Show("Cập nhật không thành công!");
                    }


                }
                        

                    
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void gridHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.ColumnIndex == 4)
            {
                opf.Filter = "Choose Image(*.jpg; *.png;*.gif)|*.jpg; *.png;*.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    gridHangHoa.CurrentCell.Value = Image.FromFile(opf.FileName);
                    
                }
            }
        }
    }
}
