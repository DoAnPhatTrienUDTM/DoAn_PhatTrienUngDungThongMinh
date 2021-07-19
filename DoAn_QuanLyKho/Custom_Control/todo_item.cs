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

namespace Custom_Control
{
    public partial class todo_item : DevExpress.XtraEditors.XtraUserControl
    {
        public todo_item()
        {
            InitializeComponent();
        }

        public todo_item(string Text, string Key, bool Checked)
        {
            key = Key;
            value = Text;
            InitializeComponent();
            label.Text = Text;
            check.Checked = Checked;
        }

        //Event
        public event EventHandler onChange = null;
        public event EventHandler onDelete = null;
        public string key = null;
        public string value = null;

        private void check_OnChange(object sender, EventArgs e)
        {
            //Strikeout item if checked
            if (check.Checked)
            {
                label.Font = new Font(label.Font.Name, label.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                label.Font = new Font(label.Font.Name, label.Font.SizeInPoints, FontStyle.Regular);
            }

            if (onChange != null)
            {
                onChange.Invoke(this, new EventArgs());
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato;
            label.Text = "Deleted";
            check.Enabled = del.Enabled = false;
            if (onDelete != null)
            {
                onDelete.Invoke(this, new EventArgs());
            }
        }
    }
}
