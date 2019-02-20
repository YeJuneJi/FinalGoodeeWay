using GoodeeWay.InventoryBUS;
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
            resourceMain.Size = mainPanel.Size;
            this.resourceMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            resourceMain.Location = new Point(0, 0);
            this.mainPanel.Controls.Add(resourceMain);

        }

        private void ResourceManagemanet_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void 재고별판매량ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventorySales inventorySales = new InventorySales();
            inventorySales.Show();
        }
    }
}
