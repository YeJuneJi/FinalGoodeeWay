using GoodeeWay.DAO;
using GoodeeWay.VO;
using Newtonsoft.Json;
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

namespace GoodeeWay.Order
{
    public partial class Order : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        private List<MenuAndDetails> bucketMenuAndDetailList;
        DataTable orderRecords;
        DataColumn[] dataColoumns;
        string menuList;

        public Order()
        {
            InitializeComponent();
        }

        public Order(List<MenuAndDetails> bucketMenuAndDetailList) : this()
        {
            this.bucketMenuAndDetailList = bucketMenuAndDetailList;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            List<Menu> menuList = new List<Menu>();
            decimal price = 0;
            decimal discount = 0;
            decimal tax = 0;

            txtPrice.Text = "0";
            txtSale.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";
            txtPaid.Text = "0"; // 받은 금액 입력
            txtChange.Text = "0";

            foreach (var item in bucketMenuAndDetailList)
            {
                price += (decimal)item.Menu.Price; // 구입한 메뉴들 가격 총 계산
                discount += (decimal)((item.Menu.Price * item.Menu.DiscountRatio) / 100);
                tax += (decimal)(item.Menu.Price * 10) / 100;

                menuList.Add(item.Menu);
            }

            txtPrice.Text = price.ToString(); // 가격 입력
            txtSale.Text = discount.ToString(); // 할인 입력
            txtTax.Text = tax.ToString(); // 세금 입력
            txtTotal.Text = (price - discount).ToString();

            // DataTable
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.AllowUserToAddRows = false;
            dataColoumns = new DataColumn[]
            {
                new DataColumn("메뉴번호"),
                new DataColumn("이름"),
                new DataColumn("가격"),
                new DataColumn("칼로리")
            };
            orderRecords = new DataTable("searchRecords");
            orderRecords.Columns.AddRange(dataColoumns);
            
            ListToGridView(menuList);

            //dataGridView1.DataSource = menuList;
        }

        private void ListToGridView(List<Menu> menulist)
        {
            foreach (var item in menulist)
            {
                menuList = string.Empty;
                                
                orderRecords.Rows.Add(item.MenuCode, item.MenuName, item.Price, item.Kcal);
            }
            dataGridView1.DataSource = orderRecords;
        }

        public bool result = false;

        private void btnOk_Click(object sender, EventArgs e) // 결제 버튼 클릭시 작동
        {
            if (MessageBox.Show("결제하시겠습니까?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (float.Parse(txtTotal.Text) > float.Parse(txtPaid.Text))
                {
                    MessageBox.Show("결제 금액이 부족합니다");
                }
                else
                {
                    if (cbReceipt.Checked)
                    {
                        // 영수중 체크시 출력 기능 구현
                        MessageBox.Show("영수증 출력");
                    }

                    string toMaking = String.Empty;

                    RealMenuVO rm = new RealMenuVO();
                    MenuAndDetails[] bb = new MenuAndDetails[bucketMenuAndDetailList.Count];

                    int i = 0;
                    foreach (var item in bucketMenuAndDetailList)
                    {
                        bb[i] = item;
                        i++;                        
                    }

                    rm.RealMenu = bb;

                    toMaking += JsonConvert.SerializeObject(rm, Formatting.Indented);

                    // 판매기록 테이블에 기입할 내용 넘겨줌
                    SaleRecordsVO saleRecord = new SaleRecordsVO();
                    saleRecord.SalesDate = DateTime.Now;
                    saleRecord.SalesitemName = toMaking;
                    saleRecord.SalesPrice = float.Parse(txtPrice.Text);
                    saleRecord.Discount = float.Parse(txtSale.Text);
                    saleRecord.Duty = float.Parse(txtTax.Text);
                    saleRecord.SalesTotal = float.Parse(txtTotal.Text);
                    saleRecord.PaymentPlan = "null";

                    try
                    {
                        new SaleRecordsDAO().InsertSaleRecords(saleRecord);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.StackTrace);
                    }

                    // making 테이블에 넘겨줄때
                    try
                    {
                        SaleRecordsVO saleRecordsVO = new MakingDAO().SelectSaleRecordNumForMaking(saleRecord.SalesDate, saleRecord.SalesitemName);

                        new MakingDAO().InsertMaking(saleRecordsVO.SalesNo, toMaking);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.StackTrace);
                    }

                    result = true;
                    this.Close();
                }
            }
        }

        /// <summary>
        /// 취소 버튼 클릭시 작동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Num 버튼 클릭시 작동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtPaid.Text.Length > 0)
            {
                if (txtPaid.Text.ElementAt(0).ToString().Equals("0"))
                {
                    txtPaid.Text = b.Text;
                }
                else
                {
                    txtPaid.Text += b.Text;
                }
            }
            else
            {
                txtPaid.Text += b.Text;
            }

            CommaSet(txtPaid.Text.Replace(",", ""));
        }

        /// <summary>
        /// Won 단위 버튼 클릭시 작동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWon_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtPaid.Text.Length > 0)
            {
                txtPaid.Text = (decimal.Parse(txtPaid.Text.Replace(",", "")) + decimal.Parse(b.Text)).ToString();
            }
            else
            {
                txtPaid.Text = decimal.Parse(b.Text).ToString();
            }            

            CommaSet(txtPaid.Text);
        }

        /// <summary>
        /// C 버튼 클릭시 작동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPaid.Text = String.Empty;
            txtChange.Text = String.Empty;
        }

        /// <summary>
        /// BackSpace 버튼 클릭시 작동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtPaid.Text.Length > 0)
            {
                txtPaid.Text = txtPaid.Text.Replace(",", "").Remove(txtPaid.Text.Replace(",", "").Length - 1);
            }

            CommaSet(txtPaid.Text);
        }

        /// <summary>
        /// comma 찍어주는 메서드
        /// </summary>
        /// <param name="txt"></param>
        private void CommaSet(string txt)
        {
            txtPaid.Text = String.Empty;
            for (int i = txt.Length - 3; i > 1; i = i - 3)
            {
                txt = txt.Insert(i, ",");
            }
            txtPaid.Text = txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker dt = new DateTimePicker();
            DateTimePicker dt2 = new DateTimePicker();
            DateTime d = dt.Value;
            DateTime d2 = dt2.Value;
            TimeSpan tt = new TimeSpan(0, 0, 0);

            d = d.Date + tt;

            MessageBox.Show(d.ToLongDateString() + d.ToLongTimeString());
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtPaid.Text.Length > 0)
            {
                txtChange.Text = (decimal.Parse(txtPaid.Text) - decimal.Parse(txtTotal.Text)).ToString();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
