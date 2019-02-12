using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Windows.Forms;

namespace GoodeeWay.SaleRecords
{
    public partial class FrmUpdateSaleRecords : Form
    {
        SaleRecordsVO saleRecords;
        public FrmUpdateSaleRecords(VO.SaleRecordsVO saleRecords)
        {
            this.saleRecords = saleRecords;
            InitializeComponent();
        }

        private void FrmUpdateSaleRecords_Load(object sender, EventArgs e)
        {
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
                    SalesitemName = name,
                    SalesPrice = float.Parse(price),
                    Discount = float.Parse(discount),
                    Duty = float.Parse(duty),
                    SalesTotal = float.Parse(total),
                    PaymentPlan = plan
                };
                new SaleRecordsDAO().UpdateSaleRecords(saleRecords);
                MessageBox.Show("기록 수정 성공");
                Close();
            }
        }

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
    }
}
