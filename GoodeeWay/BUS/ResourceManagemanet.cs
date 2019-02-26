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
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;
        private ResourceMain resourceMain;
        
        public ResourceManagemanet()
        {
            InitializeComponent();
        }

        private void ResourceManagemanet_Load(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.Close_Window_32px.ToImage();
            pbxImages.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "NewGooDeeWay.png");
            resourceMain = new ResourceMain();
            resourceMain.Size = mainPanel.Size;
            resourceMain.Location = new Point(0, 0);
            this.resourceMain.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom| AnchorStyles.Left| AnchorStyles.Right);
            mainPanel.Controls.Add(resourceMain);
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            SalesVolumeByMenu salesVolumeByMenu = new SalesVolumeByMenu();
            salesVolumeByMenu.Show();
        }

        private void btnInven_Click(object sender, EventArgs e)
        {
            InventorySales inventorySales = new InventorySales();
            inventorySales.Show();
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            FrmUsingOfEquipment usingOfEquipment = new FrmUsingOfEquipment();
            usingOfEquipment.Show();
        }

        private void movePanel_MouseDown(object sender, MouseEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
