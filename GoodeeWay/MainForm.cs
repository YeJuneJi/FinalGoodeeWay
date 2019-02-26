using GoodeeWay.Order;
using System;
using System.Windows.Forms;
using GoodeeWay.SaleRecords;
using GoodeeWay.Sales;
using GoodeeWay.BUS;
using GoodeeWay.SandwichMakingBus;
using GoodeeWay.Equipment;
using System.Data.SqlClient;

namespace GoodeeWay
{
    enum Division { 샌드위치, 찹샐러드, 사이드, 음료 };
    public partial class MainForm : Form
    {
        //OderVIew oderVIew;
        FrmOrderView fov;

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
            try
            {
                new CheckImages().DoAllCheck();
            }
            catch (SqlException ect)
            {
                MessageBox.Show(ect.Message);
            }
        }

        private void 주문ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fov == null || fov.IsDisposed)
            {
                fov = new FrmOrderView();
                panelTest.Controls.Add(fov);
                fov.BringToFront();
                //CheckOpenClose(oderVIew);
            }
            else
            {
                fov.BringToFront();
            }
        }

        private void 재고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inventory == null )
            {
                inventory = new inventory();
                inventory.MdiParent = this;
                inventory.Show();
                CheckOpenClose(inventory);
            }
            else if (inventory.IsDisposed)
            {
                inventory = new inventory();
                inventory.MdiParent = this;
                inventory.Show();
                CheckOpenClose(inventory);
            }
            else
            {
                inventory.BringToFront();
            }
        }

        private void 메뉴관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (salesMenu == null || salesMenu.IsDisposed)
            {
                
                salesMenu = new FrmSalesMenu();
                salesMenu.MdiParent = this;
                salesMenu.Show();
                CheckOpenClose(salesMenu);
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
                CheckOpenClose(saleRecords);
            }
            else if (saleRecords.IsDisposed)
            {
                saleRecords = new FrmSaleRecords();
                saleRecords.MdiParent = this;
                saleRecords.Show();
                CheckOpenClose(saleRecords);
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
                CheckOpenClose(frmEquipment);
            }
            else if (frmEquipment.IsDisposed)
            {
                frmEquipment = new Equipment.FrmEquipment();
                frmEquipment.MdiParent = this;
                frmEquipment.Show();
                CheckOpenClose(frmEquipment);
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
                CheckOpenClose(employee);
            }
            else if (employee.IsDisposed)
            {
                employee = new Employee();
                employee.MdiParent = this;
                employee.Show();
                CheckOpenClose(employee);
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
                CheckOpenClose(resourceManagemanet);
            }
            else if (resourceManagemanet.IsDisposed)
            {
                resourceManagemanet = new ResourceManagemanet();
                resourceManagemanet.MdiParent = this;
                resourceManagemanet.Show();
                CheckOpenClose(resourceManagemanet);
            }
            else
            {
                resourceManagemanet.BringToFront();
            }
        }

        private void 제조현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSandwichMaking == null)
            {
                frmSandwichMaking = new FrmSandwichMaking();
                //frmSandwichMaking.MdiParent = this;
                frmSandwichMaking.Show();
            }
            else if (frmSandwichMaking.IsDisposed)
            {
                frmSandwichMaking = new FrmSandwichMaking();
                //frmSandwichMaking.MdiParent = this;
                frmSandwichMaking.Show();
            }
            else
            {
                frmSandwichMaking.BringToFront();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tsLblTime.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
        }

        private void CheckOpenClose(Form formName)
        {
            foreach (var item in this.MdiChildren)
            {
                try
                {
                    Form mf = (Form)item;

                    if (!mf.Name.Equals(formName.Name) && !mf.Name.Equals("FrmSandwichMaking") && !mf.Name.Equals("ResourceManagemanet"))
                    {
                        mf.Close();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
