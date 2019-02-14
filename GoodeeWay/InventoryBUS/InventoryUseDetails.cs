using GoodeeWay.DAO;
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
    public partial class InventoryUseDetails : Form
    {
        string receivingDetailsID;
        public InventoryUseDetails(string receivingDetailsID)
        {
            InitializeComponent();
            this.receivingDetailsID = receivingDetailsID;
            txtInventoryQuantity.Text = "";
            InventoryUseDetailsSelect();
        }
        public void InventoryUseDetailsSelect()
        {
            DataTable dataTable = new InventoryDAO().InventoryUseDetails(receivingDetailsID);
            lblInventoryName.Text = dataTable.Rows[0]["재고명"].ToString();

            dataTable.Columns.Remove("재고명");
            dgvInventoryUseDetails.DataSource = dataTable;
            dgvInventoryUseDetails.AllowUserToAddRows = false;
            dgvInventoryUseDetails.ReadOnly = true;
            //dgvInventoryUseDetails
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtInventoryQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int InventoryQuantity = Int32.Parse(txtInventoryQuantity.Text);
            }
            catch (Exception)
            {
                txtInventoryQuantity.Text = "";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int maximun = Int32.Parse(dgvInventoryUseDetails["수량", 0].Value.ToString());
            int useQuantity = 0;

            if (dgvInventoryUseDetails.Rows.Count>0)
            {
                for (int i = 1; i < dgvInventoryUseDetails.Rows.Count; i++)
                {
                    useQuantity += Int32.Parse(dgvInventoryUseDetails["수량", i].Value.ToString());
                } 
            }

            
                if (!((maximun - useQuantity - Int32.Parse(txtInventoryQuantity.Text)) < 0))
                {
                    new InventoryDAO().InventoryUseDetailsInsert(Int32.Parse(txtInventoryQuantity.Text),receivingDetailsID);
                    MessageBox.Show("추가완료");
                    InventoryUseDetailsSelect();
                }
                else
                {
                    MessageBox.Show("수량한도를 초과했습니다.");
                }
            
        }
    }
}
