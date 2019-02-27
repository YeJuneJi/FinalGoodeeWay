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
    public partial class OrderDetailsAdd : Form
    {
        DataTable OrderDetailsListDataTable;
        /// <summary>
        /// 발주내역 생산자
        /// </summary>
        /// <param name="OrderDetailsListDataTable">발주내역테이블</param>
        public OrderDetailsAdd(DataTable OrderDetailsListDataTable)
        {
            InitializeComponent();
            this.OrderDetailsListDataTable = OrderDetailsListDataTable;
            dgvOrderDetailsAdd.AllowUserToAddRows = false;
            dgvOrderDetailsAdd.DataSource = new InventoryTypeDAO().selectOrderDetailsAdd(OrderDetailsListDataTable);
            dgvOrderDetailsAdd.Columns["재고명"].ReadOnly = true;
            dgvOrderDetailsAdd.Columns["재고종류코드"].ReadOnly = true;
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
        /// 발주내역 추가하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<OrderDetailsVO> orderDetailsVOList = new List<OrderDetailsVO>();
            string s = OrderDetailsListDataTable.Rows[0]["발주번호"].ToString().Substring(2, 6);
            s="20" + s.Substring(0, 2) + "-" + s.Substring(2, 2) + "-" + s.Substring(4, 2);
            for (int i = 0; i < dgvOrderDetailsAdd.Rows.Count; i++)
            {
                if (Int32.Parse(dgvOrderDetailsAdd["수량", i].Value.ToString()) > 0)
                {
                    orderDetailsVOList.Add(new OrderDetailsVO()
                    {
                        OrderID = "OR" + OrderDetailsListDataTable.Rows[0]["발주번호"].ToString().Substring(2, 6) + dgvOrderDetailsAdd["재고종류코드", i].Value.ToString().Substring(4, 2),
                        OrderDate = DateTime.Parse(s),
                        InventoryTypeCode = dgvOrderDetailsAdd["재고종류코드", i].Value.ToString(),
                        Quantity = Int32.Parse(dgvOrderDetailsAdd["수량", i].Value.ToString())
                    });
                }
            }
            new OrderDetailsDAO().InsertOrderDetails(orderDetailsVOList);
            this.DialogResult = DialogResult.OK;
        }
    }
}
