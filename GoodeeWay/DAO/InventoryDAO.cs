using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.DAO
{
    class InventoryDAO
    {
        /// <summary>
        /// 입고내역서-> 입고내역, 재고내역에 저장
        /// </summary>
        /// <param name="receivingDetailsList"></param>
        public void InventoryInsert(List<ReceivingDetailsVO> receivingDetailsList)
        {
            SqlParameter[] ReceivingDetailsParameters = new SqlParameter[7];
            SqlParameter[] InventoryParameters = new SqlParameter[4];

            foreach (var item in receivingDetailsList)
            {
                if (item.ReturnStatus=="정상")
                {
                    #region 입고내역서 -> 입고내역 저장
                    ReceivingDetailsParameters[0] = new SqlParameter("ReceivingDetailsID", item.ReceivingDetailsID);
                    ReceivingDetailsParameters[1] = new SqlParameter("ReceivingDetailsDate", item.ReceivingDetailsDate);
                    ReceivingDetailsParameters[2] = new SqlParameter("ExpirationDate", item.ExpirationDate);
                    ReceivingDetailsParameters[3] = new SqlParameter("Quantity", item.Quantity);
                    ReceivingDetailsParameters[4] = new SqlParameter("UnitPrice", item.UnitPrice);
                    ReceivingDetailsParameters[5] = new SqlParameter("ReturnStatus", item.ReturnStatus + "입");
                    ReceivingDetailsParameters[6] = new SqlParameter("InventoryTypeCode", item.InventoryTypeCode);
                    #endregion
                    new DBConnection().Insert("InsertReceivingDetails", ReceivingDetailsParameters);

                    #region 입고내역서 -> 재고내역 저장
                    InventoryParameters[0] = new SqlParameter("InventoryQuantity", item.Quantity);
                    InventoryParameters[1] = new SqlParameter("DateOfDisposal", item.ExpirationDate);
                    InventoryParameters[2] = new SqlParameter("ReceivingDetailsID", item.ReceivingDetailsID);
                    InventoryParameters[3] = new SqlParameter("InventoryTypeCode", item.InventoryTypeCode);
                    #endregion
                    new DBConnection().Insert("InsertInventory", InventoryParameters);

                }
                else if (item.ReturnStatus == "교환" || item.ReturnStatus == "환불")
                {
                    ReceivingDetailsParameters[0] = new SqlParameter("ReceivingDetailsID", item.ReceivingDetailsID);
                    ReceivingDetailsParameters[1] = new SqlParameter("ReceivingDetailsDate", item.ReceivingDetailsDate);
                    ReceivingDetailsParameters[2] = new SqlParameter("ExpirationDate", item.ExpirationDate);
                    ReceivingDetailsParameters[3] = new SqlParameter("Quantity", item.Quantity);
                    ReceivingDetailsParameters[4] = new SqlParameter("UnitPrice", item.UnitPrice);
                    ReceivingDetailsParameters[5] = new SqlParameter("ReturnStatus", item.ReturnStatus);
                    ReceivingDetailsParameters[6] = new SqlParameter("InventoryTypeCode", item.InventoryTypeCode);
                    new DBConnection().Insert("InsertReceivingDetails", ReceivingDetailsParameters);

                }
            }

        }
    }
}
