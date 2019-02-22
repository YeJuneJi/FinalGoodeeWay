using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.VO;

namespace GoodeeWay.SaleRecords
{
    public partial class FrmDetailSaleRecord : Form
    {
        private RealMenuVO realMenuVO;

        public FrmDetailSaleRecord()
        {
            InitializeComponent();
        }

        public FrmDetailSaleRecord(RealMenuVO realMenuVO) : this()
        {
            this.realMenuVO = realMenuVO;
        }

        private void FrmDetailSaleRecord_Load(object sender, EventArgs e)
        {
            textBox1.Text += "================주문 내역========================\r\n";

            int i = 0;

            foreach (var rmv in realMenuVO.RealMenu)
            {
                if (rmv.Menu.Division.Equals(Convert.ToString((int)Division.샌드위치)))
                {
                    textBox1.Text += "\r\n\r\n<<" + Enum.GetName(typeof(Division), int.Parse(rmv.Menu.Division)) + ">>" + rmv.Menu.MenuName;
                    textBox1.Text += "\r\n\r\n재료 : ==>";
                    foreach (var mdl in rmv.MenuDetailList)
                    {
                        textBox1.Text += "\t" + mdl.InventoryName + ", ";
                    }
                }
                else
                {
                    textBox1.Text += "\r\n\r\n<<" + Enum.GetName(typeof(Division), int.Parse(rmv.Menu.Division)) + ">>\r\n" + rmv.Menu.MenuName;
                }
            }
        }
    }
}
