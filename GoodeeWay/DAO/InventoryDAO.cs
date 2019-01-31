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
                    try
                    {
                        new DBConnection().Insert("InsertReceivingDetails", ReceivingDetailsParameters);
                    }
                    catch (Exception)
                    {
                        throw;
                    }

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

        internal List<InventoryInventoryTypeVO> InventoryTableSelect()
        {
            SqlDataReader dr =  new DBConnection().Select("SelectInventory_InventoryType", null);
            List<InventoryInventoryTypeVO> inventoryInventoryTypeVOList = new List<InventoryInventoryTypeVO>();
            while (dr.Read())
            {
                //DateTime dateOfUse=DateTime.Parse("2001-01-01"); 
                DateTime? dateOfUse=null; 
                //DateTime dateOfDisposal=DateTime.Parse("2001-01-01");
                DateTime? dateOfDisposal=null;
                try
                {
                    dateOfUse = DateTime.Parse(dr["DateOfUse"].ToString());
                }
                catch (FormatException)
                {
                }
                try
                {
                    dateOfDisposal = DateTime.Parse(dr["DateOfDisposal"].ToString());
                }
                catch (FormatException)
                {
                }
                var inventoryInventoryTypeVO = new InventoryInventoryTypeVO()
                {
                    InventoryID = dr["InventoryID"].ToString(),
                    InventoryName = dr["InventoryName"].ToString(),
                    InventoryQuantity = Int32.Parse(dr["InventoryQuantity"].ToString()),
                    DateOfUse = dateOfUse,
                    DateOfDisposal = dateOfDisposal,
                    ReceivingDetailsID = dr["ReceivingDetailsID"].ToString(),
                    InventoryTypeCode = dr["InventoryTypeCode"].ToString(),
                    
                };
                inventoryInventoryTypeVOList.Add(inventoryInventoryTypeVO);
            }
            return inventoryInventoryTypeVOList;
        }
    }
}
