using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.VO;

namespace GoodeeWay.InventoryBUS
{
    public partial class ReceivingDetailsReturn : Form
    {
        private ReceivingDetailsVO rdvo;
        private FrmInventory frmInventory;
        public ReceivingDetailsVO Rdvo
        {
            get { return rdvo; }
            set { rdvo = value; }
        }
        /// <summary>
        /// 입고내역반품 생산자
        /// </summary>
        /// <param name="rdvo">입고내역에 대한 VO</param>
        /// <param name="frmInventory">재고내역 메인 폼에 대한 개체</param>
        public ReceivingDetailsReturn(ReceivingDetailsVO rdvo,FrmInventory frmInventory)
        {
            this.rdvo = rdvo;
            InitializeComponent();
            lblItemName.Text = rdvo.InventoryName;
            txtItemQuantity.Text = rdvo.Quantity+"";
            this.frmInventory = frmInventory;
        }

        /// <summary>
        /// 창닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// 입고내역 반품수량 제한 걸기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtItemQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtItemQuantity.Text) <= rdvo.Quantity && Int32.Parse(txtItemQuantity.Text) > 0)
                {
                    
                    btnApply.Enabled = true;
                }
                else
                {
                    MessageBox.Show("범위 내 값을 입력해주세요.");
                    txtItemQuantity.Text = "";
                    btnApply.Enabled = false;
                }
                lbl.Text = "";
            }
            catch (Exception)
            {
                lbl.Text = "숫자만 입력";
                txtItemQuantity.Text = "";
                btnApply.Enabled = false;
            }

        }
        /// <summary>
        /// 반품 or 교환 내역 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            Rdvo.Quantity = Int32.Parse(txtItemQuantity.Text);
            if (rdoReturn.Checked)
            {
                Rdvo.ReturnStatus = "반품";
                Rdvo.ReceivingDetailsID=Rdvo.ReceivingDetailsID.Replace("I", "R");
            }
            else
            {
                Rdvo.ReturnStatus = "교환";
                Rdvo.ReceivingDetailsID=Rdvo.ReceivingDetailsID.Replace("I", "E");
            }
            
            this.DialogResult = DialogResult.OK;
        }

        
    }
}
