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
        public void InventoryInsert(List<ReceivingDetails> receivingDetailsList)
        {
            SqlParameter[] ReceivingDetailsParameters = new SqlParameter[7];
            SqlParameter[] InventoryParameters = new SqlParameter[6];
            
            


            foreach (var item in receivingDetailsList)
            {

                ReceivingDetailsParameters[0] = new SqlParameter("ReceivingDetailsID", item.ReceivingDetailsID);
                ReceivingDetailsParameters[1] = new SqlParameter("ReceivingDetailsDate", item.ReceivingDetailsDate);
                ReceivingDetailsParameters[2] = new SqlParameter("ExpirationDate", item.ExpirationDate);
                ReceivingDetailsParameters[3] = new SqlParameter("Quantity", item.Quantity);
                ReceivingDetailsParameters[4] = new SqlParameter("UnitPrice", item.UnitPrice);
                if (item.ReturnStatus == "정상") { ReceivingDetailsParameters[5] = new SqlParameter("ReturnStatus", item.ReturnStatus + "입"); }
                else { ReceivingDetailsParameters[5] = new SqlParameter("ReturnStatus", item.ReturnStatus); }
                ReceivingDetailsParameters[6] = new SqlParameter("InventoryTypeCode", item.InventoryTypeCode);

                if (item.ReturnStatus=="정상")
                {
                    InventoryParameters[0] = new SqlParameter("InventoryID", null);
                    InventoryParameters[1] = new SqlParameter("InventoryQuantity", item.Quantity);
                    InventoryParameters[2] = new SqlParameter("DateOfUse", null);
                    InventoryParameters[3] = new SqlParameter("DateOfDisposal", item.ExpirationDate);
                    InventoryParameters[4] = new SqlParameter("ReceivingDetailsID", item.ReceivingDetailsID);
                    InventoryParameters[5] = new SqlParameter("InventoryTypeCode", item.InventoryTypeCode);
                    new DBConnection().Insert("InsertInventory", InventoryParameters);

                }
                    new DBConnection().Insert("InsertReceivingDetails", ReceivingDetailsParameters);
            }

        }
    }
}
