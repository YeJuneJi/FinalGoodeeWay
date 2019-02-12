using GoodeeWay.DAO;
using GoodeeWay.VO;
﻿using GoodeeWay.Order;
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
using GoodeeWay.BUS;

namespace GoodeeWay
{
    enum Division { 샌드위치, 찹샐러드, 사이드, 음료 };
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 재고ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            inventory.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            GoodeeWay.Equipment.FrmEquipment frmEquipment = new Equipment.FrmEquipment();
            frmEquipment.Show();

            GoodeeWay.SandwichMakingBus.FrmSandwichMaking frmSandwichMaking = new SandwichMakingBus.FrmSandwichMaking();
            frmSandwichMaking.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();

        }

        private void btnJoomoon_Click(object sender, EventArgs e)
        {
            OderVIew oderVIew = new OderVIew();
            oderVIew.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ResourceManagemanet resourceManagemanet = new ResourceManagemanet();
            resourceManagemanet.Show();
        }
    }
}
