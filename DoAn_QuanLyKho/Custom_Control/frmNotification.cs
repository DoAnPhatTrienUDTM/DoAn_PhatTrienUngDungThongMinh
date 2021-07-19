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
using Newtonsoft.Json.Linq;
using Bunifu.Framework.Firebase;


namespace Custom_Control
{
    public partial class frmNotification : DevExpress.XtraEditors.XtraForm
    {
        //Global variables
        firebaseRef root, todos;
        public frmNotification()
        {
            InitializeComponent();
            Firebase.initialize(@"{
                                    apiKey: 'AIzaSyD1GmB3fzMLhgvxLXyv1A7lzYgkd7FawHY',
                                    authDomain: 'thongbaotonkho.firebaseapp.com',
                                    databaseURL: 'https://thongbaotonkho-default-rtdb.asia-southeast1.firebasedatabase.app',
                                    projectId: 'thongbaotonkho',
                                    storageBucket: 'thongbaotonkho.appspot.com',
                                    messagingSenderId: '52548240184',
                                    appId: '1:52548240184:web:7f34533be07895bf94b7cd',
                                    measurementId: 'G-VKE8XEY5NP'
                                  };", this);
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        private frmNotification.enmAction action;

        private int x, y;



        int poss = 10;
        public void addItem(string Text, string Key, bool Checked)
        {
            todo_item item = new todo_item(Text, Key, Checked);
            panel2.Controls.Add(item);
            item.onChange += Item_onChange;
            item.onDelete += Item_onDelete;
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (txt.Text.Trim().Length == 0)
            {
                //this.Alert("Không có dữ liệu!", frmNotificationCustom.enmType.Warning);
                MessageBox.Show("Không có dữ liệu!", "Thông báo!");
            }

            JObject todo = new JObject();
            todo["checked"] = false;
            todo["text"] = txt.Text;
            Firebase.set("todos/" + index, todo.ToString());
        }

        private void frmNotification_Load(object sender, EventArgs e)
        {
            //Load data
            root = Firebase.database();
            todos = root.child("todos");
            todos.onValue += Todos_onValue;
            todos.onChildAdded += Todos_onChildAdded;
            todos.onChildRemoved += Todos_onChildRemoved;

            Firebase.Listen();
        }

        private void Item_onDelete(object sender, EventArgs e)
        {
            Firebase.remove("todos/" + ((todo_item)sender).key);
            index--;
        }

        private void Item_onChange(object sender, EventArgs e)
        {
            Firebase.set("todos/" + ((todo_item)sender).key + "/checked", ((todo_item)sender).check.Checked.ToString());
            //this.Alert("On change test", frmNotificationCustom.enmType.Info);
        }

        private void Todos_onValue(object sender, EventArgs e)
        {
            //MessageBox.Show(((firebaseRef)sender).Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 500000;
                    action = enmAction.close;
                    break;

                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;

                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void Todos_onChildRemoved(object sender, EventArgs e)
        {

        }

        int index = 0;

        public void showAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                frmNotification frm = (frmNotification)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            this.txt.Text = msg;

            this.Show();

            this.action = enmAction.start;

            this.timer1.Interval = 1000;
            timer1.Start();
        }

        private void Todos_onChildAdded(object sender, EventArgs e)
        {
            txt.Text = "";
            JObject jo = new JObject();
            try
            {
                try
                {
                    jo = JObject.Parse(((firebaseRef)sender).Value);
                    addItem(jo["text"].ToString(), index.ToString(), Boolean.Parse(jo["checked"].ToString()));
                    index++;
                    return;
                }
                catch (Exception)
                {

                }

                MessageBox.Show(((firebaseRef)sender).Value);
                JArray ja = JArray.Parse(((firebaseRef)sender).Value);
                jo = (JObject)ja[1];
                addItem(jo["text"].ToString(), index.ToString(), Boolean.Parse(jo["checked"].ToString()));
                index++;
                return;
            }
            catch (Exception)
            {

            }
        }
    }
}