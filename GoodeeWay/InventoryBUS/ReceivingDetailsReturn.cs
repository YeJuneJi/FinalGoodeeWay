﻿using System;
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

        public ReceivingDetailsVO Rdvo
        {
            get { return rdvo; }
            set { rdvo = value; }
        }

        public ReceivingDetailsReturn(ReceivingDetailsVO rdvo)
        {
            this.rdvo = rdvo;
            InitializeComponent();
            lblItemName.Text = rdvo.InventoryName;
            txtItemQuantity.Text = rdvo.Quantity+"";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

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

        private void btnApply_Click(object sender, EventArgs e)
        {
            Rdvo.Quantity = Int32.Parse(txtItemQuantity.Text);
            if (rdoReturn.Checked)
            {
                Rdvo.ReturnStatus = "반품";
                Rdvo.ReceivingDetailsID=Rdvo.ReceivingDetailsID.Replace("I", "O");
            }
            else
            {
                Rdvo.ReturnStatus = "교환";
                Rdvo.ReceivingDetailsID=Rdvo.ReceivingDetailsID.Replace("I", "E");
            }
            Inventory i = (Inventory)Owner;
            i.ReceivingDetailsVOReturn = Rdvo;
            this.DialogResult = DialogResult.OK;
        }
    }
}
