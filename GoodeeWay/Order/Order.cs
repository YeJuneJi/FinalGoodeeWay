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
            // 메뉴테이블이 짜여지면 Table에서 가져와서 선택한 메뉴 이름을 기준으로 Count ++ 
            // -> datagridview에 추가 
            // -> 통해서 계산            

            List<Menu> menuList = new List<Menu>();
            float price = 0;

            foreach (var item in bucketMenuAndDetailList)
            {                
                price += item.Menu.Price;
                menuList.Add(item.Menu);
            }

            txtPrice.Text = price.ToString();
            txtPaid.Text = "0";
            dataGridView1.DataSource = menuList;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {                          
            if (cbReceipt.Checked)
            {
                // 영수중 체크시 출력 기능 구현
            }

            // 판매 테이블에 넘겨줄 내용 작성 후 넘겨줌
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btnWon_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            txtPaid.Text = (double.Parse(txtPaid.Text.Replace("," , "")) + double.Parse(b.Text)).ToString();

            CommaSet(txtPaid.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPaid.Text = String.Empty;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtPaid.Text.Length > 0)
            {
                txtPaid.Text = txtPaid.Text.Replace("," , "").Remove(txtPaid.Text.Replace("," , "").Length - 1);
            }

            CommaSet(txtPaid.Text);
        }

        private void CommaSet(string txt)
        {
            txtPaid.Text = String.Empty;
            for (int i = txt.Length - 3 ; i > 1; i = i-3)
            {
                txt = txt.Insert(i, ",");
            }
            txtPaid.Text = txt;
        }
    }
}
