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
using Custom_Control;

namespace GUI
{
    public partial class frmTrangChu : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        KhoBLL_DAL kho = new KhoBLL_DAL();
        NCC_BLL_DAL ncc = new NCC_BLL_DAL();
        TonKho_BLL_DAL tonkho = new TonKho_BLL_DAL();
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            lblSoNhanVien.Text = nv.count_NhanVien().ToString();
            lblNhanVien_True.Text = nv.count_NhanVien_True().ToString();
            lblKho.Text = kho.count_Kho().ToString();
            lblNhaCC.Text = ncc.count_NhaCungCap().ToString();

            grvTonKho.DataSource = tonkho.get_TonKho();
        }

        public void Alert(string msg)
        {
            Custom_Control.frmNotification frm = new frmNotification();
            frm.showAlert(msg);
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            string id = grvTonKho.CurrentRow.Cells[0].Value.ToString();
            string sanpham = grvTonKho.CurrentRow.Cells[1].Value.ToString();
            string thongbao = "Nhập sản phẩm " + sanpham + " vào kho " + id + " số lượng 100";
            this.Alert(thongbao);
        }
    }
}