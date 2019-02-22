using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class ResourceManagemanet : Form
    {
        private ResourceMain resourceMain = new ResourceMain();

        public ResourceManagemanet()
        {
            InitializeComponent();
            

        }

        private void ResourceManagemanet_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            resourceMain.Size = new Size(Size.Width, Size.Height - resourceMenuStrip.Height*2);
            resourceMain.Location = new Point(0, 0);
            this.mainPanel.Controls.Add(resourceMain);
        }

        private void mainPanel_SizeChanged(object sender, EventArgs e)
        {
            resourceMain.Size = new Size(Size.Width, Size.Height - resourceMenuStrip.Height * 2);
        }

        private void ResourceManagemanet_SizeChanged(object sender, EventArgs e)
        {
            mainPanel.Size = this.Size;
        }
    }
}
