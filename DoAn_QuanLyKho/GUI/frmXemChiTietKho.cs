using DevExpress.XtraEditors;
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
    public partial class frmXemChiTietKho : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        KhoBLL_DAL kho = new KhoBLL_DAL();
        int idKho;
        public frmXemChiTietKho(int maKho)
        {
            idKho = maKho;
            InitializeComponent();
        }

        public void initializeData()
        {
            grvNhanVienKho.DataSource = nv.get_NhanVien_idKho(idKho);
        }

        private void frmXemChiTietKho_Load(object sender, EventArgs e)
        {
            initializeData();
            txtIDKho.Text = idKho.ToString();
            txtDiaChi.Text = kho.get_DiaChiKho(idKho);
            txtTinhTrang.Text = kho.get_TinhTrangKho(idKho);
            txtSoLuongNV.Text = kho.get_SoLuongNhanVien(idKho).ToString();
        }
    }
}