using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GoodeeWay.DAO;
using GoodeeWay.Properties;
using GoodeeWay.VO;

namespace GoodeeWay.SaleRecords
{
    /// <summary>
    /// 판매기록의 영수증과 환불상태를 나타내 주기 위한<c>FrmDetailSaleRecord</c> 클래스
    /// </summary>
    public partial class FrmDetailSaleRecord : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        private int salesNo;
        private DateTime salesDate;
        private RealMenuVO realMenuVO;
        private decimal totalPrice;

        /// <summary>
        /// 생성자
        /// </summary>
        public FrmDetailSaleRecord()
        {
            InitializeComponent();
            this.Icon = Resources.C_Sharp_Logo_2_1;
        }
        /// <summary>
        /// 생성자 오버로딩
        /// </summary>
        /// <param name="salesNo">판매 번호</param>
        /// <param name="salesDate">판매일</param>
        /// <param name="realMenuVO">판매물품명</param>
        /// <param name="totalPrice">총 가격</param>
        public FrmDetailSaleRecord(int salesNo, DateTime salesDate, RealMenuVO realMenuVO, decimal totalPrice) : this()
        {
            this.salesNo = salesNo;
            this.salesDate = salesDate;
            this.realMenuVO = realMenuVO;
            this.totalPrice = totalPrice;
        }

        private void FrmDetailSaleRecord_Load(object sender, EventArgs e)
        {
            pbxImages.BringToFront();
            pbxImages.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "NewGooDeeWay.png");
            myToolTip.SetToolTip(btnRefund, "환불");
            lblSalesNo.Text = "주문번호 : " + salesNo.ToString();
            lblSalesDate.Text = "판매날짜 : " + salesDate.ToString();
            lblTotalPrice.Text = "금액 : " + totalPrice.ToString();

            tbxMenus.Text += "================주문 내역========================\r\n";
            
            //매개변수로 전달받은 Json 형식의 판매물품명을 분석해
            foreach (var rmv in realMenuVO.RealMenu)
            {
                //구분별 판매물품명을 출력한다.
                if (rmv.Menu.Division.Equals(Convert.ToString((int)Division.샌드위치)))
                {
                    tbxMenus.Text += "\r\n\r\n<<" + Enum.GetName(typeof(Division), int.Parse(rmv.Menu.Division)) + ">>\r\n" + rmv.Menu.MenuName;
                }
                else
                {
                    tbxMenus.Text += "\r\n\r\n<<" + Enum.GetName(typeof(Division), int.Parse(rmv.Menu.Division)) + ">>\r\n" + rmv.Menu.MenuName;
                }
            }

            MakingFormVO makingFormVO = new MakingFormVO();

            // 제조 대기 상태이면 환불이 가능하며 그외의 상태는 환불이 불가능하다.
            try
            {
                makingFormVO = new MakingDAO().SelectMakingBySaleNo(salesNo);
                CheckMaikingDivision(makingFormVO.Division);
            }
            catch (SqlException)
            {
                MessageBox.Show("제조 현황을 가져올 수 없습니다.");
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        /// <summary>
        /// 제조현황을 파악하기 위한 메서드
        /// </summary>
        /// <param name="division">제조현황의 구분</param>
        private void CheckMaikingDivision(string division)
        {
            if (string.IsNullOrEmpty(division))
            {
                btnRefund.Enabled = false;
                lblRefund.Text = "환불 불가 합니다.";
            }
            else if (division.Equals("대기"))
            {
                btnRefund.Enabled = true;
                lblRefund.Text = "환불 가능 합니다.";
            }
            else if (division.Equals("제조"))
            {
                btnRefund.Enabled = false;
                lblRefund.Text = "환불 불가 합니다.";
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            try
            {
                new SaleRecordsDAO().RefundSaleRecords(salesNo);
                MessageBox.Show("환불성공");
                this.Close();
            }
            catch (SqlException except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
