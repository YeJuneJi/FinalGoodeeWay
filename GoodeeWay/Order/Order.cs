﻿using GoodeeWay.DAO;
using GoodeeWay.VO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.Order
{
    public partial class Order : Form
    {
        private List<MenuAndDetails> bucketMenuAndDetailList;

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

            dataGridView1.DataSource = menuList;
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
                    MessageBox.Show(toMaking);

                    //MessageBox.Show(toMaking);

                    //MessageBox.Show(toMaking);
                    // 제조 테이블에 넘겨줄 string 내용 작성 후 넘겨줌
                    //foreach (MenuAndDetails item in bucketMenuAndDetailList)
                    //{
                    //    toMaking += "@";
                    //    if (item.Menu.Division.Equals(Convert.ToString((int)Division.샌드위치)))
                    //    {
                    //        toMaking += "샌드위치[" + item.Menu.MenuName + "]";
                    //        foreach (MenuDetail menuDetail in item.MenuDetailList)
                    //        {
                    //            toMaking += "|" + menuDetail.InventoryName;
                    //        }
                    //    }
                    //    else if (item.Menu.Division.Equals(Convert.ToString((int)Division.찹샐러드)))
                    //    {
                    //        toMaking += "찹샐러드" + item.Menu.MenuName;
                    //    }
                    //    else if (item.Menu.Division.Equals(Convert.ToString((int)Division.사이드)))
                    //    {
                    //        toMaking += "사이드" + item.Menu.MenuName;
                    //    }
                    //    else if (item.Menu.Division.Equals(Convert.ToString((int)Division.음료)))
                    //    {
                    //        toMaking += "음료" + item.Menu.MenuName;
                    //    }
                    //}                                        

                    //MainForm.frmSandwichMaking.CallMaking();
                    ////////////////////////////////////////

                    try
                    {
                        new MakingDAO().InsertMaking(toMaking);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.StackTrace);
                    }

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
    }
}
