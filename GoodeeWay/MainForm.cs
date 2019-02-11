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
using GoodeeWay.SaleRecords;
using GoodeeWay.Sales;

namespace GoodeeWay
{
    enum Division { 샌드위치, 찹샐러드, 사이드, 음료 };
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalesMenu_Click(object sender, EventArgs e)
        {
            FrmSalesMenu salesMenu = new FrmSalesMenu();
            salesMenu.Show();
        }

        private void btnSaleRecords_Click(object sender, EventArgs e)
        {
            FrmSaleRecords saleRecords = new FrmSaleRecords();
            saleRecords.Show();
        }
    }
}
