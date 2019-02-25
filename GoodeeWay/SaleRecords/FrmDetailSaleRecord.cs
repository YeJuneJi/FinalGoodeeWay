using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.DAO;
using GoodeeWay.VO;

namespace GoodeeWay.SaleRecords
{
    public partial class FrmDetailSaleRecord : Form
    {
        private int salesNo;
        private DateTime salesDate;
        private RealMenuVO realMenuVO;
        private decimal totalPrice;

        public FrmDetailSaleRecord()
        {
            InitializeComponent();
        }

        public FrmDetailSaleRecord(int salesNo, DateTime salesDate, RealMenuVO realMenuVO, decimal totalPrice) : this()
        {
            this.salesNo = salesNo;
            this.salesDate = salesDate;
            this.realMenuVO = realMenuVO;
            this.totalPrice = totalPrice;
        }

        private void FrmDetailSaleRecord_Load(object sender, EventArgs e)
        {
            lblSalesNo.Text = "주문번호 : " + salesNo.ToString();
            lblSalesDate.Text = "판매날짜 : " + salesDate.ToString();
            lblTotalPrice.Text = "금액 : " + totalPrice.ToString();

            textBox1.Text += "================주문 내역========================\r\n";

            int i = 0;

            foreach (var rmv in realMenuVO.RealMenu)
            {
                if (rmv.Menu.Division.Equals(Convert.ToString((int)Division.샌드위치)))
                {
                    textBox1.Text += "\r\n\r\n<<" + Enum.GetName(typeof(Division), int.Parse(rmv.Menu.Division)) + ">>\r\n" + rmv.Menu.MenuName;
                    //textBox1.Text += "\r\n\r\n재료 : ==>";
                    //foreach (var mdl in rmv.MenuDetailList)
                    //{
                    //    textBox1.Text += "\t" + mdl.InventoryName + ", ";
                    //}
                }
                else
                {
                    textBox1.Text += "\r\n\r\n<<" + Enum.GetName(typeof(Division), int.Parse(rmv.Menu.Division)) + ">>\r\n" + rmv.Menu.MenuName;
                }
            }

            MakingFormVO makingFormVO = new MakingFormVO();

            // 제조 대기 상태이면 환불 가능 다른경우 전부 x
            try
            {
                makingFormVO = new MakingDAO().SelectMakingBySaleNo(salesNo);

                if (makingFormVO != null && makingFormVO.Division.Equals("대기"))
                {
                    btnRefund.Enabled = true;
                    lblRefund.Text = "환불 가능 합니다.";
                }
                else
                {
                    btnRefund.Enabled = false;
                    lblRefund.Text = "환불 불가 합니다.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {

        }
    }
}
