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
        int receivingQuantity = 0;
        int inventoryQuantity = 0;
        int maximun = 0;
        int useQuantity = 0;
        int a = 0;
        DataTable dataTable;

        string receivingDetailsID;
        /// <summary>
        /// 재고사용내역 업로드
        /// </summary>
        /// <param name="receivingDetailsID">입고내역코드</param>
        /// <param name="dateOfDisposal">제품 유통기한</param>
        public InventoryUseDetails(string receivingDetailsID, string dateOfDisposal)
        {
            InitializeComponent();
            this.receivingDetailsID = receivingDetailsID;
            txtRealUseQuantity.Text = "0";
            InventoryUseDetailsSelect();
            NowCanUseQuantity();
            btnDisposal.Enabled = false;
            if (DateTime.Parse(dateOfDisposal)<DateTime.Parse(DateTime.Now.ToShortDateString()))
            {
                btnAdd.Enabled = false;

                if (lblUseQuantity.Text!="0")
                {
                    btnDisposal.Enabled = true; 
                }
            }


        }
        /// <summary>
        /// 재고사용내역 표에 출력하기
        /// </summary>
        public void InventoryUseDetailsSelect()
        {
            dataTable = new InventoryDAO().InventoryUseDetails(receivingDetailsID);
            lblInventoryName.Text = dataTable.Rows[0]["재고명"].ToString();
            receivingQuantity = Int32.Parse(dataTable.Rows[0]["입고정량"].ToString());
            inventoryQuantity = Int32.Parse(dataTable.Rows[0]["수량"].ToString());
            maximun = inventoryQuantity * receivingQuantity;
            dataTable.Columns.Remove("수량");
            dataTable.Columns.Remove("재고명");

            dgvInventoryUseDetails.DataSource = dataTable;
            
            dgvInventoryUseDetails.AllowUserToAddRows = false;
            dgvInventoryUseDetails.ReadOnly = true;
            dgvInventoryUseDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 64, 65);
        }

        /// <summary>
        /// 창 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// 재고사용량 입력 시 숫자제한
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInventoryQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int InventoryQuantity = Int32.Parse(txtRealUseQuantity.Text);
            }
            catch (Exception)
            {
                txtRealUseQuantity.Text = "";
            }

        }
        /// <summary>
        /// 재고사용 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NowCanUseQuantity();


            if (txtRealUseQuantity.Text!="0")
            {
                if (!(a < 0))
                {
                    new InventoryDAO().InventoryUseDetailsInsert(Int32.Parse(txtRealUseQuantity.Text), receivingDetailsID, dgvInventoryUseDetails["입고정량", 0].Value.ToString(), inventoryQuantity, useQuantity);//재고사용내역을 insert하여 추가시킴
                    MessageBox.Show("추가완료");
                    if (a == 0)
                    {
                        new InventoryDAO().InventoryUseDateUpdate(receivingDetailsID);//재고 사용 가능 수량이 0이 되면 총재고에 오늘 날짜를 표시
                    }
                    InventoryUseDetailsSelect();

                }
                else
                {
                    MessageBox.Show("수량한도를 초과했습니다.");
                    txtRealUseQuantity.Text = 0 + "";
                    NowCanUseQuantity();
                } 
            }
            else
            {
                MessageBox.Show("0이상의 숫자를 입력해주세요.");
                txtRealUseQuantity.Text = 0 + "";
            }

        }
        /// <summary>
        /// 현재 사용가능 수량 띄우기
        /// </summary>
        private void NowCanUseQuantity()
        {
            useQuantity = 0;
            if (lblUseQuantity.Text!="0")
            {
                if (dgvInventoryUseDetails.Rows.Count > 0)
                {
                    for (int i = 1; i < dgvInventoryUseDetails.Rows.Count; i++)
                    {
                        useQuantity += Int32.Parse(dgvInventoryUseDetails["실제사용수량", i].Value.ToString());
                    }
                }
                a = (maximun - useQuantity) - Int32.Parse(txtRealUseQuantity.Text);
                lblUseQuantity.Text = a + "";
                if (lblUseQuantity.Text == "0")
                {
                    btnAdd.Enabled = false;
                    btnDisposal.Enabled = false;
                }
            }
            
        }
        /// <summary>
        /// 제품 폐기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisposal_Click(object sender, EventArgs e)
        {
            NowCanUseQuantity();


            if (txtRealUseQuantity.Text != "0")
            {
                if (!(a < 0))
                {
                    new InventoryDAO().InventoryUseDetailsDisposalInsert(Int32.Parse(txtRealUseQuantity.Text), receivingDetailsID, dgvInventoryUseDetails["입고정량", 0].Value.ToString(), inventoryQuantity, useQuantity);
                    MessageBox.Show("폐기완료");
                    if (a == 0)
                    {
                        new InventoryDAO().InventoryUseDateUpdate(receivingDetailsID);
                    }
                    InventoryUseDetailsSelect();

                }
                else
                {
                    MessageBox.Show("수량한도를 초과했습니다.");
                    txtRealUseQuantity.Text = 0 + "";
                    NowCanUseQuantity();
                }
            }
            else
            {
                MessageBox.Show("0이상의 숫자를 입력해주세요.");
                txtRealUseQuantity.Text = 0 + "";
            }
        }
    }
}
