﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        Check_Login login = new Check_Login();
        DefendPassword password = new DefendPassword();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReadSettings()
        {
            if (Properties.Settings.Default.RememberMe == "true")
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPass.Text = Properties.Settings.Default.Password;
                chkRememberMe.Checked = true;
            }
            else
            {
                txtUsername.Text = "User name";
                txtPass.Text = "Password";
                chkRememberMe.Checked = false;
            }
        }

        private void SaveSettings()
        {
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = this.txtUsername.Text;
                Properties.Settings.Default.Password = this.txtPass.Text;
                Properties.Settings.Default.RememberMe = "true";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = this.txtUsername.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = "false";
                Properties.Settings.Default.Save();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            SaveSettings();
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkShowPass_OnChange(object sender, EventArgs e)
        {
            if (chkShowPass.Checked == false)
            {
                txtPass.isPassword = true;
            }
            else
            {
                txtPass.isPassword = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AppSetting setting = new AppSetting();
            if(login.IsvalidUser(txtUsername.Text, txtPass.Text))
            {
                //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (WaitForm1 frm = new WaitForm1(setting.SaveData))
                {
                    frm.ShowDialog(this);
                }
                frmQuanLyKho frmQuanLyKho = new frmQuanLyKho();
                frmQuanLyKho.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void chkRememberMe_OnChange(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ReadSettings();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
