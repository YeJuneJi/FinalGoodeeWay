﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.SandwichMakingBus
{
    public partial class FrmSandwichMaking : Form
    {
        public FrmSandwichMaking()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString() +" "+ DateTime.Now.ToLongTimeString();
        }
    }
}
