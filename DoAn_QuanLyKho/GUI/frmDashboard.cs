﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}