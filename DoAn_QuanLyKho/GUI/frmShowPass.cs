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
    public partial class frmShowPass : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource formDataSource;
        NhanVienBLL_DAL nv = new NhanVienBLL_DAL();
        public frmShowPass(BindingSource dataSource)
        {
            InitializeComponent();
            formDataSource = dataSource;
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("Text", formDataSource, "ID_DN", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtPass.isPassword = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPass_Load(object sender, EventArgs e)
        {
            txtPass.isPassword = true;
            string id = txtUsername.Text;
            NGUOIDUNG nd = nv.get_Info(id);
            txtPass.Text = nd.MATKHAU.ToString();
        }
    }
}