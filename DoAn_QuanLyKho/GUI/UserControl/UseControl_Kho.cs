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

namespace GUI.UserControl
{
    public partial class UseControl_Kho : DevExpress.XtraEditors.XtraUserControl
    {
        public UseControl_Kho()
        {
            InitializeComponent();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            int n = int.Parse(lbl_idKho.Text);
            frmXemChiTietKho frm = new frmXemChiTietKho(n);
            frm.Show();
        }
    }
}
