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
using GoodeeWay.InventoryBUS;
using GoodeeWay.Properties;

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
        FrmSaleRecord frmSaleRecord;
        //OderVIew oderVIew;
        FrmInventory fi;
        USalesMenu salesMenu;
        UcEquipment frmEquipment;
        EmployeeControl employee;
        ResourceManagemanet resourceManagemanet;

        public static FrmSandwichMaking frmSandwichMaking;
        public MainForm()
        {
            InitializeComponent();
            this.Icon = Resources.C_Sharp_Logo_2_1;
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
            if (fi == null)
            {
                fi = new FrmInventory();
                MainPanel.Controls.Add(fi);
                fi.BringToFront();
                CheckOpenClose(fi);
            }
            else if (fi.IsDisposed)
            {
                fi = new FrmInventory();
                MainPanel.Controls.Add(fi);
                fi.BringToFront();
            }
            else
            {
                fi.BringToFront();
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

            if (frmSaleRecord == null || frmSaleRecord.IsDisposed)
            {
                frmSaleRecord = new FrmSaleRecord();
                frmSaleRecord.Size = MainPanel.Size;
                MainPanel.Controls.Add(frmSaleRecord);
                frmSaleRecord.BringToFront();
                CheckOpenClose(frmSaleRecord);
            }
            else
            {
                frmSaleRecord.BringToFront();
            }

        }

        private void 비품관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEquipment == null || frmEquipment.IsDisposed)
            {
                frmEquipment = new UcEquipment();
                MainPanel.Controls.Add(frmEquipment);
                frmEquipment.BringToFront();
                CheckOpenClose(frmEquipment);
            }
            else
            {
                frmEquipment.BringToFront();
            }
        }

        private void 인사관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employee == null || employee.IsDisposed)
            {
                employee = new EmployeeControl();
                MainPanel.Controls.Add(employee);
                employee.BringToFront();
                //CheckOpenClose(employee);
            }
            else if (employee.IsDisposed)
            {
                employee = new EmployeeControl();
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

        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                if (salesMenu != null)
                {
                    salesMenu.Size = MainPanel.Size;
                }
                if (frmSaleRecord != null)
                {
                    frmSaleRecord.Size = MainPanel.Size;
                }
               
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                if (salesMenu != null)
                {
                    salesMenu.Size = MainPanel.Size;
                }
                if (frmSaleRecord != null)
                {
                    frmSaleRecord.Size = MainPanel.Size;
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
