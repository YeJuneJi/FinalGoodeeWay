using GoodeeWay.DAO;
using GoodeeWay.Properties;
using GoodeeWay.VO;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GoodeeWay.SaleRecords
{
    /// <summary>
    /// 판매기록의 내용을 수정하기위한 <c>FrmUpdateSaleRecords</c> 클래스
    /// </summary>
    public partial class FrmUpdateSaleRecords : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        private SaleRecordsVO saleRecords;
        private string salesItemName;
        public FrmUpdateSaleRecords(SaleRecordsVO saleRecords, string salesItemName)
        {
            this.saleRecords = saleRecords;
            this.salesItemName = salesItemName;
            InitializeComponent();
            this.Icon = Resources.C_Sharp_Logo_2_1;
        }

        private void FrmUpdateSaleRecords_Load(object sender, EventArgs e)
        {
            pbxImages.BringToFront();
            pbxImages.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "NewGooDeeWay.png");

            lblSalesNo.Text += saleRecords.SalesNo.ToString();
            dtpUpdateDate.Value = saleRecords.SalesDate;
            tbxUpdateName.Text = saleRecords.SalesitemName;
            tbxUpdatePrice.Text = saleRecords.SalesPrice.ToString();
            tbxUpdateDiscount.Text = saleRecords.Discount.ToString();
            tbxUpdateduty.Text = saleRecords.Duty.ToString();
            tbxUpdateTotal.Text = saleRecords.SalesTotal.ToString();
            tbxUpadatePlan.Text = saleRecords.PaymentPlan;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int no = saleRecords.SalesNo;
            string name = tbxUpdateName.Text.Trim();
            string price = tbxUpdatePrice.Text.Replace(" ", "").Trim();
            string discount = tbxUpdateDiscount.Text.Replace(" ", "").Trim();
            string duty = tbxUpdateduty.Text.Replace(" ", "").Trim();
            string total = tbxUpdateTotal.Text.Replace(" ", "").Trim();
            string plan = tbxUpadatePlan.Text.Replace(" ", "").Trim();
            if (ValidateNull(name, price, discount, duty, total, plan) && ValidateType(price, discount, duty, total))
            {
                SaleRecordsVO saleRecords = new SaleRecordsVO()
                {
                    SalesNo = no,
                    SalesDate = dtpUpdateDate.Value,
                    SalesitemName = salesItemName,
                    SalesPrice = float.Parse(price),
                    Discount = float.Parse(discount),
                    Duty = float.Parse(duty),
                    SalesTotal = float.Parse(total),
                    PaymentPlan = plan
                };
                try
                {
                    new SaleRecordsDAO().UpdateSaleRecords(saleRecords);
                    MessageBox.Show("기록 수정 성공");
                }
                catch (SqlException)
                {
                    MessageBox.Show("기록을 수정 할 수 없습니다.");
                }
                
                Close();
            }
        }
        /// <summary>
        /// 수정하고자하는 판매기록들의 데이터들의 Type유효성검사를 위한 메서드
        /// </summary>
        /// <param name="price">가격</param>
        /// <param name="discount">할인</param>
        /// <param name="duty">세금</param>
        /// <param name="total">총액</param>
        /// <returns></returns>
        private bool ValidateType(string price, string discount, string duty, string total)
        {
            bool result = false;

            if (float.TryParse(price, out float fprice) && float.TryParse(discount, out float fdiscount) && float.TryParse(duty, out float fduty) && float.TryParse(total, out float ftotal))
            {
                result = true;
            }
            else
            {
                tbxUpdatePrice.Focus();
                MessageBox.Show("가격, 할인, 세금, 합계는 숫자로 입력해 주세요.");
            }
            return result;
        }

        /// <summary>
        /// 수정하고자하는 판매기록들의 데이터들의 Null유효성검사를 위한 메서드
        /// </summary>
        /// <param name="name">이름</param>
        /// <param name="price">가격</param>
        /// <param name="discount">할인</param>
        /// <param name="duty">세금</param>
        /// <param name="total">총액</param>
        /// <param name="plan">지불방법</param>
        /// <returns></returns>
        private bool ValidateNull(string name, string price, string discount, string duty, string total, string plan)
        {
            bool result = false;
            if (!(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(discount) || string.IsNullOrEmpty(duty) || string.IsNullOrEmpty(total) || string.IsNullOrEmpty(plan)))
            {
                result = true;
            }
            else
            {
                tbxUpdateName.Focus();
                MessageBox.Show("값을 모두 입력 해 주세요!");
            }
            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
