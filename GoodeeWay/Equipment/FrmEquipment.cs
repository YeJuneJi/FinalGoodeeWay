using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.DAO;
using GoodeeWay.VO;

namespace GoodeeWay.Equipment
{
    public partial class FrmEquipment : Form
    {
        public FrmEquipment()
        {
            InitializeComponent();
        }
        EquipmentVO tempEquipment;//선택된 비품임시저장

        private void FrmEquipment_Load(object sender, EventArgs e)
        {
            EquipmentDAO dAO = new EquipmentDAO();
            chbDate.CheckState = CheckState.Unchecked;
            dgvEquipmentList.DataSource = dAO.AllequipmentVOsList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EquipmentDAO dAO = new EquipmentDAO();

            if (chbDate.Checked)
            {
                if (!(dtpStartDate.Value < dtpEndDate.Value))
                {
                    DateTime temp = dtpEndDate.Value;
                    dtpEndDate.Value = dtpStartDate.Value;
                    dtpStartDate.Value = temp;
                }

                EquipmentVO equipment = new EquipmentVO()
                {
                    DetailName = txtSearchForName.Text,
                    Location = txtSearchForLocation.Text,
                    PurchaseDate = dtpStartDate.Value,
                    PurchasePrice = float.Parse(txtSearchForPrice.Text)
                };
                DateTime endDate = dtpEndDate.Value;
                dgvEquipmentList.DataSource = dAO.SelectSearch(equipment, endDate);
            }
            else
            {
                EquipmentVO equipment = new EquipmentVO()
                {
                    DetailName = txtSearchForName.Text,
                    Location = txtSearchForLocation.Text,
                    PurchaseDate = DateTime.Parse("1753-1-1"),
                    PurchasePrice = float.Parse(txtSearchForPrice.Text)
                };
                dgvEquipmentList.DataSource = dAO.SelectSearch(equipment, DateTime.Parse("1753-1-1"));
            }
        }

            private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            FrmAddEquipment frmAddEquipment = new FrmAddEquipment();
            frmAddEquipment.ShowDialog();
        }

        private void chbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDate.CheckState == CheckState.Checked)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
            }
            else
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
            }
        }

        private void dgvEquipmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDetailName.Text = dgvEquipmentList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLocation.Text = dgvEquipmentList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = dgvEquipmentList.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNote.Text = dgvEquipmentList.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbState.Text = dgvEquipmentList.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dgvEquipmentList.Rows[e.RowIndex].Cells[5].Value.ToString() != "")
            {
                dtpPurchaseDate.Value =DateTime.Parse( dgvEquipmentList.Rows[e.RowIndex].Cells[5].Value.ToString());
            }

            tempEquipment = new EquipmentVO()
            {
                EQUCode = dgvEquipmentList.Rows[e.RowIndex].Cells[0].Value.ToString(),
                DetailName = dgvEquipmentList.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Location = dgvEquipmentList.Rows[e.RowIndex].Cells[2].Value.ToString(),
                State = dgvEquipmentList.Rows[e.RowIndex].Cells[3].Value.ToString(),
                PurchasePrice =float.Parse(dgvEquipmentList.Rows[e.RowIndex].Cells[4].Value.ToString()),
                PurchaseDate = dtpPurchaseDate.Value = DateTime.Parse(dgvEquipmentList.Rows[e.RowIndex].Cells[5].Value.ToString()),
                Note = dgvEquipmentList.Rows[e.RowIndex].Cells[6].Value.ToString()
        };

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EquipmentDAO dAO = new EquipmentDAO();
            DialogResult mbResult = MessageBox.Show("정말로 삭제하시겠습니까? 삭제하면 기록에 남지 않습니다.", "비품삭제", MessageBoxButtons.YesNo);

            if (mbResult == DialogResult.Yes)
            {
                dAO.DeleteEquipment(tempEquipment);
            }   
            
        }

        private void txtSearchForPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) || txtPrice.Text.Length > 8)
            {
                e.Handled = true;
            }
        }

        private void txtSearchForPrice_Leave(object sender, EventArgs e)
        {
            if (txtSearchForPrice.Text == "")
            {
                txtSearchForPrice.Text = "0";
            }
        }

        private void txtSearchForPrice_Enter(object sender, EventArgs e)
        {
            if (txtSearchForPrice.Text == "0")
            {
                txtSearchForPrice.Text = "";
            }
        }
    }
}
