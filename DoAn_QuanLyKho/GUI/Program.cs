using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        public static frmMain main = null;
        public static frmLogin login = null;
        public static frmPhieuDat frmphieudat = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            login = new frmLogin();
            main = new frmMain();
            frmphieudat = new frmPhieuDat();
            Application.Run(new frmLoading());
            //Application.Run(new TestMapControl());
            //Application.Run(new Form1());
        }
    }
}
