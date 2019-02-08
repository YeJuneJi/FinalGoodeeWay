using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

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
            if (cmbClassification.Text=="Bread"|| cmbClassification.Text == "Cheese" || cmbClassification.Text == "Vegetable" || cmbClassification.Text == "Sauce" || cmbClassification.Text == "Topping" || cmbClassification.Text == "Additional")
            {
                temp = true;
            }
            if (txtInventoryName.Text!="" && txtReceivingQuantity.Text!= "" && inventoryTypeCode != "" && temp)
            {
                new InventoryTypeDAO().InventoryTypeInsert(new InventoryTypeVO(inventoryTypeCode, txtReceivingQuantity.Text, txtInventoryName.Text, cmbClassification.Text));
                
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("모두 입력해주세요");

            }
        }

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
            if (a>=10000)
            {
                MessageBox.Show("재고종류코드는 10000 이상이 될수 없습니다.");
                txtInventoryTypeCode.Text = "";
            }
            
        }

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

        private void cmbClassification_TextChanged(object sender, EventArgs e)
        {
            if (!(cmbClassification.Text == "Bread" || cmbClassification.Text == "Cheese" || cmbClassification.Text == "Vegetable" || cmbClassification.Text == "Sauce" || cmbClassification.Text == "Topping" || cmbClassification.Text == "Additional"))
            {
                cmbClassification.Text = "Bread";
            }
        }
    }
}
