using System;
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
        string manv;
        public frmLogin()
        {
            InitializeComponent();
            txtPass.isPassword = true;
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
            if(txtUsername.Text == "")
            {
                MessageBox.Show("User name không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPass.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            else if(login.IsvalidUser(txtUsername.Text, txtPass.Text))
            {
                //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (WaitForm1 frm = new WaitForm1(setting.SaveData))
                {
                    frm.ShowDialog(this);
                }
                manv = login.getIDUser(txtUsername.Text, txtPass.Text);
                frmMain frmQuanLyKho = new frmMain(manv);
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
            txtUsername.Text = "Username";
            txtPass.Text = "Password";
            txtPass.isPassword = true;
            ReadSettings();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doubleBitmapControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
