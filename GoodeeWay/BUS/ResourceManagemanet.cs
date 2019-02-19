using GoodeeWay.InventoryBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class ResourceManagemanet : Form
    {
        public ResourceManagemanet()
        {
            InitializeComponent();
        }

        private void btnInventorySales_Click(object sender, EventArgs e)
        {
            InventorySales inventorySales = new InventorySales();
            inventorySales.Show();

        }
    }
}
