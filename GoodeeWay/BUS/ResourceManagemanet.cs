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
        private ResourceMain resourceMain;

        public ResourceManagemanet()
        {
            InitializeComponent();
        }

        private void ResourceManagemanet_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            resourceMain = new ResourceMain();
            resourceMain.Size = new Size(Size.Width, Size.Height - resourceMenuStrip.Height);
            resourceMain.Location = new Point(0, 0);
            this.resourceMain.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom| AnchorStyles.Left| AnchorStyles.Right);
            this.Controls.Add(resourceMain);
        }

        private void 비품구매통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsingOfEquipment usingOfEquipment = new FrmUsingOfEquipment();
            usingOfEquipment.Show();
        }   
        private void 메뉴별판매량ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesVolumeByMenu salesVolumeByMenu = new SalesVolumeByMenu();
            salesVolumeByMenu.Show();
        }
        private void 재고별판매량ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventorySales inventorySales = new InventorySales();
            inventorySales.Show();
        }
    }
}
