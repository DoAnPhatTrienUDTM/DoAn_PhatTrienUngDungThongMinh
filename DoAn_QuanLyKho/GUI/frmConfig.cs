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
using System.IO;
using System.Configuration;
using System.Threading;
using System.Data.Sql;

namespace GUI
{
    public partial class frmConfig : DevExpress.XtraEditors.XtraForm
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if(rs == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};", cboServername.selectedValue, txtDataname.Text, txtUsername.Text, txtPass.Text);
            try
            {
                SQLHelper helper = new SQLHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            //Add server name to combobox
            cboServername.AddItem(".");
            cboServername.AddItem("(local)");
            cboServername.AddItem(@".\SQLEXPRESS");
            cboServername.AddItem(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboServername.selectedIndex = 3;
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};", cboServername.selectedValue, txtDataname.Text, txtUsername.Text, txtPass.Text);
            try
            {
                SQLHelper helper = new SQLHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    //MyDllConfig config = new MyDllConfig();
                    //setting.GetConnectionString("DoAn_QuanLyKhoConnectionString");
                    setting.SaveConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString", connectionString);
                    using(WaitForm1 frm = new WaitForm1(setting.SaveData))
                    {
                        frm.ShowDialog(this);
                    }
                    MessageBox.Show("Your connection string has been successfully save.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //frmSetupCompany frmSetup = new frmSetupCompany();
                    //frmSetup.Show();
                    //frmLogin frmlogin = new frmLogin();
                    //frmlogin.Show();
                    //this.Hide();

                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboServername_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}