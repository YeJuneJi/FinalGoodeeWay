using GoodeeWay.Order;
using System;
using System.Windows.Forms;
using GoodeeWay.SaleRecords;
using GoodeeWay.Sales;
using GoodeeWay.BUS;
using GoodeeWay.SandwichMakingBus;
using GoodeeWay.Equipment;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace GoodeeWay
{
    enum Division { 샌드위치, 찹샐러드, 사이드, 음료 };
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;


        FrmOrderView fov;
        FrmSaleRecord fsr;
        inventory inventory;
        USalesMenu salesMenu;        
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
                MainPanel.Controls.Add(fov);
                fov.BringToFront();
                CheckOpenClose(fov);
            }
            else
            {
                fov.BringToFront();
            }
        }

        private void 재고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inventory == null)
            {
                inventory = new inventory();
                inventory.MdiParent = this;
                inventory.Show();
                //CheckOpenClose(inventory);
            }
            else if (inventory.IsDisposed)
            {
                inventory = new inventory();
                inventory.MdiParent = this;
                inventory.Show();
                //CheckOpenClose(inventory);
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
                salesMenu = new USalesMenu();
                salesMenu.Size = MainPanel.Size;
                MainPanel.Controls.Add(salesMenu);
                salesMenu.BringToFront();
                CheckOpenClose(salesMenu);
            }
            else
            {
                salesMenu.BringToFront();
            }
        }

        private void 판매기록관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fsr == null || fsr.IsDisposed)
            {
                fsr = new FrmSaleRecord();
                MainPanel.Controls.Add(fsr);
                fsr.BringToFront();
                CheckOpenClose(fsr);
            }
            else
            {
                fsr.BringToFront();
            }

        }

        private void 비품관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEquipment == null)
            {
                frmEquipment = new Equipment.FrmEquipment();
                frmEquipment.MdiParent = this;
                frmEquipment.Show();
                //CheckOpenClose(frmEquipment);
            }
            else if (frmEquipment.IsDisposed)
            {
                frmEquipment = new Equipment.FrmEquipment();
                frmEquipment.MdiParent = this;
                frmEquipment.Show();
                //CheckOpenClose(frmEquipment);
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
                //CheckOpenClose(employee);
            }
            else if (employee.IsDisposed)
            {
                employee = new Employee();
                employee.MdiParent = this;
                employee.Show();
                //CheckOpenClose(employee);
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
                resourceManagemanet.Show();
                //CheckOpenClose(resourceManagemanet);
            }
            else if (resourceManagemanet.IsDisposed)
            {
                resourceManagemanet = new ResourceManagemanet();
                resourceManagemanet.Show();
                //CheckOpenClose(resourceManagemanet);
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

        private void CheckOpenClose(UserControl formName)
        {
            foreach (var item in MainPanel.Controls)
            {   
                if (item.GetType() != typeof(PictureBox))
                {                    
                    UserControl mf = (UserControl)item;

                    if (!mf.Name.Equals(formName.Name))
                    {
                        mf.Dispose();
                    }
                }
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 다른 컨트롤에 묶여있을 수 있을 수 있으므로 마우스캡쳐 해제
                ReleaseCapture();

                // 타이틀 바의 다운 이벤트처럼 보냄
                SendMessage(this.Handle, WM_NLBUTTONDOWN, HT_CAPTION, 0);
            }

            base.OnMouseDown(e);
        }
    }
}
