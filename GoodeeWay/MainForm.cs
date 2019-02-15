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
using GoodeeWay.SandwichMakingBus;

namespace GoodeeWay
{
    enum Division { 샌드위치, 찹샐러드, 사이드, 음료 };
    public partial class MainForm : Form
    {
        OderVIew oderVIew;
        public static FrmSandwichMaking frmSandwichMaking;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmSandwichMaking = new FrmSandwichMaking();
            frmSandwichMaking.Show();
        }

        private void 주문ToolStripMenuItem_Click(object sender, EventArgs e)
        {                        
            if (oderVIew == null)
            {                
                oderVIew = new OderVIew();
                oderVIew.MdiParent = this;
                oderVIew.Show();
            }
            else if (oderVIew.IsDisposed)
            {
                oderVIew = new OderVIew();
                oderVIew.MdiParent = this;
                oderVIew.Show();
            }
            else
            {
                oderVIew.BringToFront();
            }
        }

        private void 재고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            inventory.MdiParent = this;
            inventory.Show();
        }

        private void 메뉴관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalesMenu salesMenu = new FrmSalesMenu();
            salesMenu.MdiParent = this;
            salesMenu.Show();
        }

        private void 판매기록관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaleRecords saleRecords = new FrmSaleRecords();
            saleRecords.MdiParent = this;
            saleRecords.Show();
        }

        private void 비품관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodeeWay.Equipment.FrmEquipment frmEquipment = new Equipment.FrmEquipment();
            frmEquipment.MdiParent = this;
            frmEquipment.Show();
        }

        private void 인사관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.MdiParent = this;
            employee.Show();
        }



        private void 매출관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResourceManagemanet resourceManagemanet = new ResourceManagemanet();
            resourceManagemanet.MdiParent = this;
            resourceManagemanet.Show();
        }
    }
}
