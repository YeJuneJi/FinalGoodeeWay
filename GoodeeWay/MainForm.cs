using GoodeeWay.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.DB;

namespace GoodeeWay
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        bool on_off = false;
        float time = 0f;

        private void button1_Click(object sender, EventArgs e)
        {
            OderVIew oView = new OderVIew();
            oView.ShowDialog();

            //if (on_off == true)
            //{
            //    timer1.Stop();
            //    on_off = false;
            //    textBox1.Text = time.ToString() + "초";
            //}
            //else if (on_off == false)
            //{
            //    time = 0f;
            //    timer1.Start();
            //    on_off = true;
            //}

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 0.1f;
        }
    }
}
