using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.InventoryBUS
{
    public partial class InventoryTypeAdd : Form
    {
        public InventoryTypeAdd()
        {
            InitializeComponent();
        }
        int a = 0;
        int b = 0;
        /// <summary>
        /// 창 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// 완료 시 재고종류 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComplete_Click(object sender, EventArgs e)
        {
            string inventoryTypeCode = "";
            if (a < 1000 && a >= 100)
            {
                inventoryTypeCode = "0" + a;
            }
            else if (a < 100 && a >= 10)
            {
                inventoryTypeCode = "00" + a;
            }
            else if (a < 10 && a > 0)
            {
                inventoryTypeCode = "000" + a;
            }
            else if(a>=1000)
            {
                inventoryTypeCode = a+"";
            }
            bool temp = false;
            if (cmbClassification.Text=="Bread"|| cmbClassification.Text == "Cheese" || cmbClassification.Text == "Vegetable" || cmbClassification.Text == "Sauce" || cmbClassification.Text == "Topping" || cmbClassification.Text == "Additional" || cmbClassification.Text == "Side")
            {
                temp = true;
            }
            if (txtInventoryName.Text!="" && txtReceivingQuantity.Text!= "" && inventoryTypeCode != "" && temp)
            {
                try
                {
                    new InventoryTypeDAO().InventoryTypeInsert(new InventoryTypeVO(inventoryTypeCode, txtReceivingQuantity.Text, txtInventoryName.Text, cmbClassification.Text));
                    this.DialogResult = DialogResult.OK;
                }
                catch (SqlException)
                {
                    MessageBox.Show("재고종류코드 중복입니다. 다시 입력해주세요.");
                    txtInventoryTypeCode.Text = "";
                }


            }
            else
            {
                MessageBox.Show("모두 입력해주세요");

            }
        }

        /// <summary>
        /// 재고종류코드 입력창에 텍스트 변경 시 숫자 제한
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInventoryTypeCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = Int32.Parse(txtInventoryTypeCode.Text);
            }
            catch (Exception)
            {
                txtInventoryTypeCode.Text = "";
                a = 0;
            }
            if (a>10000)
            {
                MessageBox.Show("재고종류코드는 10000 이상이 될수 없습니다.");
                txtInventoryTypeCode.Text = "";
            }
            
        }

        /// <summary>
        /// 입고정량 설정 시 숫자 입력과 범위설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtReceivingQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = Int32.Parse((txtReceivingQuantity.Text));
            }
            catch (Exception)
            {
                txtReceivingQuantity.Text = "";
                b = 0;
            }
            if (b>=10000)
            {
                MessageBox.Show("입고정량 범위를 넘었습니다.");
                txtReceivingQuantity.Text = "";
            }
        }

        /// <summary>
        /// 분류구분에 해당하는 분류인지 확인
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbClassification_TextChanged(object sender, EventArgs e)
        {
            if (!(cmbClassification.Text == "Bread" || cmbClassification.Text == "Cheese" || cmbClassification.Text == "Vegetable" || cmbClassification.Text == "Sauce" || cmbClassification.Text == "Topping" || cmbClassification.Text == "Additional"|| cmbClassification.Text =="Side"))
            {
                cmbClassification.Text = "Bread";
            }
        }
    }
}
