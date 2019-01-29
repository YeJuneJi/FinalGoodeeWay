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
        public void InventoryAdd(List<ReceivingDetails> receivingDetailsList)
        {
            List<SqlParameter> InventoryAddList = new List<SqlParameter>();
            List<SqlParameter> ReturnAddList = new List<SqlParameter>();
            
            foreach (var item in receivingDetailsList)
            {
                
                if (item.ReturnStatus=="정상")
                {
                    InventoryAddList.Add(new SqlParameter("ReceivingDetailsID", item.ReceivingDetailsID));
                    InventoryAddList.Add(new SqlParameter("ReceivingDetailsDate", item.ReceivingDetailsDate));
                    InventoryAddList.Add(new SqlParameter("ExpirationDate", item.ExpirationDate));
                    InventoryAddList.Add(new SqlParameter("Quantity", item.Quantity));
                    InventoryAddList.Add(new SqlParameter("UnitPrice", item.UnitPrice));
                    InventoryAddList.Add(new SqlParameter("ReturnStatus", item.ReturnStatus));
                    InventoryAddList.Add(new SqlParameter("InventoryTypeCode", item.InventoryTypeCode));
                }
                else
                {
                    ReturnAddList.Add(new SqlParameter("ReceivingDetailsID", item.ReceivingDetailsID));
                    ReturnAddList.Add(new SqlParameter("ReceivingDetailsDate", item.ReceivingDetailsDate));
                    ReturnAddList.Add(new SqlParameter("ExpirationDate", item.ExpirationDate));
                    ReturnAddList.Add(new SqlParameter("Quantity", item.Quantity));
                    ReturnAddList.Add(new SqlParameter("UnitPrice", item.UnitPrice));
                    ReturnAddList.Add(new SqlParameter("ReturnStatus", item.ReturnStatus));
                    ReturnAddList.Add(new SqlParameter("InventoryTypeCode", item.InventoryTypeCode));
                }
            }

        }
    }
}
