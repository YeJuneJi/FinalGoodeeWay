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
            foreach (var item in bucketMenuAndDetailList)
            {
                //item.Menu
                
            }            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // 판매 테이블에 넘겨줄 내용 작성 후 넘겨줌
            
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
