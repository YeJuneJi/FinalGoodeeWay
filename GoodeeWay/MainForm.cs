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
using GoodeeWay.Equipment;

namespace GoodeeWay
{
    enum Division { 샌드위치, 찹샐러드, 사이드, 음료 };
    public partial class MainForm : Form
    {
        OderVIew oderVIew;
        inventory inventory;
        FrmSalesMenu salesMenu;
        FrmSaleRecords saleRecords;
        FrmEquipment frmEquipment;
        Employee employee;
        ResourceManagemanet resourceManagemanet;
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
            if (inventory == null)
            {
                inventory = new inventory();
                inventory.MdiParent = this;
                inventory.Show();
            }
            else if (inventory.IsDisposed)
            {
                inventory = new inventory();
                inventory.MdiParent = this;
                inventory.Show();
            }
            else
            {
                inventory.BringToFront();
            }
        }

        private void 메뉴관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (salesMenu == null)
            {
                salesMenu = new FrmSalesMenu();
                salesMenu.MdiParent = this;
                salesMenu.Show();
            }
            else if (salesMenu.IsDisposed)
            {
                salesMenu = new FrmSalesMenu();
                salesMenu.MdiParent = this;
                salesMenu.Show();
            }
            else
            {
                salesMenu.BringToFront();
            }
        }

        private void 판매기록관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saleRecords == null)
            {
                saleRecords = new FrmSaleRecords();
                saleRecords.MdiParent = this;
                saleRecords.Show();
            }
            else if (saleRecords.IsDisposed)
            {
                saleRecords = new FrmSaleRecords();
                saleRecords.MdiParent = this;
                saleRecords.Show();
            }
            else
            {
                saleRecords.BringToFront();
            }
            
        }

        private void 비품관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEquipment == null)
            {
                frmEquipment = new Equipment.FrmEquipment();
                frmEquipment.MdiParent = this;
                frmEquipment.Show();
            }
            else if (frmEquipment.IsDisposed)
            {
                frmEquipment = new Equipment.FrmEquipment();
                frmEquipment.MdiParent = this;
                frmEquipment.Show();
            }
            else
            {
                frmEquipment.BringToFront();
            }
        }

        private void 인사관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employee == null)
            {
                employee = new Employee();
                employee.MdiParent = this;
                employee.Show();
            }
            else if (employee.IsDisposed)
            {
                employee = new Employee();
                employee.MdiParent = this;
                employee.Show();
            }
            else
            {
                employee.BringToFront();
            }
            
        }

        private void 매출관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resourceManagemanet == null)
            {
                resourceManagemanet = new ResourceManagemanet();
                resourceManagemanet.MdiParent = this;
                resourceManagemanet.Show();
            }
            else if (resourceManagemanet.IsDisposed)
            {
                resourceManagemanet = new ResourceManagemanet();
                resourceManagemanet.MdiParent = this;
                resourceManagemanet.Show();
            }
            else
            {
                resourceManagemanet.BringToFront();
            }
            
        }

        private void godnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            godns gd = new godns();
            gd.Show();
        }
    }
}
