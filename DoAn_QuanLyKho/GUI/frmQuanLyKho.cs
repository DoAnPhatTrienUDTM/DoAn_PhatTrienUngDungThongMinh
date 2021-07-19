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
    public partial class frmQuanLyKho : DevExpress.XtraEditors.XtraForm
    {
        private UserControl.UseControl_Kho[] userControlArray;
        KhoBLL_DAL kho = new KhoBLL_DAL();
        public frmQuanLyKho()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            TestMapControl testMapControl = new TestMapControl();
            testMapControl.Show();
        }

        public void initializeData()
        {
            grvQuanLyKho.DataSource = kho.loadDataKHo();
        }

        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            initializeData();
            int xPos = 8;
            int yPos = 8;
            int number = grvQuanLyKho.Rows.Count;
            addUserControl(number);
            int n = 0;
            while(n < number)
            {
                userControlArray[n].Width = 240;
                userControlArray[n].Height = 240;

                if(yPos > 720)
                {
                    yPos = 8;
                    xPos = xPos + userControlArray[n].Width + 8;
                }


                userControlArray[n].lbl_idKho.Text = grvQuanLyKho.Rows[n].Cells[0].Value.ToString();
                userControlArray[n].lblSLNV.Text = kho.get_SoLuongNhanVien(int.Parse(grvQuanLyKho.Rows[n].Cells[0].Value.ToString())).ToString();
                userControlArray[n].Left = xPos;
                userControlArray[n].Top = yPos;
                yPos = yPos + userControlArray[n].Height + 8;
                panelDynamic.Controls.Add(userControlArray[n]); //Let panel hold the User Control

                n++;
            }    
        }

        private void addUserControl(int number)
        {
            userControlArray = new UserControl.UseControl_Kho[number + 1];
            for(int i = 0; i < number + 1; i++)
            {
                userControlArray[i] = new UserControl.UseControl_Kho();
            }    
        }

        private void panelDynamic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            frmThemKho frm = new frmThemKho();
            frm.Show();
        }

        public void Alert(string msg, frmNotificationCustom.enmType type)
        {
            Custom_Control.frmNotificationCustom frm = new frmNotificationCustom();
            frm.showAlert(msg, type);
        }

        private void btnXoaKho_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grvQuanLyKho.CurrentRow.Cells[0].Value.ToString());
            if (kho.xoaKho(id) == true)
            {
                grvQuanLyKho.DataSource = kho.loadDataKHo();
                this.Alert("Xóa thành công!", frmNotificationCustom.enmType.Success);
            }
            else
            {
                this.Alert("Xóa thất bại!", frmNotificationCustom.enmType.Error);
            }
        }

        private void btnSuaKho_Click(object sender, EventArgs e)
        {
            frmSuaKho frm = new frmSuaKho();
            frm.Show();
        }

        public static void FadeIn(Form frm)
        {
            float FadeIn;
            for (FadeIn = 0.0f; FadeIn <= 1.1; FadeIn += 0.1f)
            {
                frm.Opacity = FadeIn;
                frm.Refresh();
                System.Threading.Thread.Sleep(100);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //frmQuanLyKho frm = new frmQuanLyKho();
            //FadeIn(frm);
            this.Controls.Clear();
            this.InitializeComponent();
            grvQuanLyKho.DataSource = kho.loadDataKHo();
            grvQuanLyKho.Refresh();
            panelDynamic.Refresh();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            grvQuanLyKho.DataSource = kho.searchKho(txtSearch.Text);
        }
    }
}