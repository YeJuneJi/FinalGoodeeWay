using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Data;
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
                else if (item.ReturnStatus == "교환" || item.ReturnStatus == "반품")
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

        internal DataTable InventoryTableSelect()
        {
            SqlDataReader dr =  new DBConnection().Select("SelectInventory_InventoryType", null);
            DataTable inventoryDataTable = new DataTable();
            inventoryDataTable.Columns.Add("재고번호", typeof(string));
            inventoryDataTable.Columns.Add("재고명", typeof(string));
            inventoryDataTable.Columns.Add("재고량", typeof(int));
            inventoryDataTable.Columns.Add("출고량", typeof(int));
            inventoryDataTable.Columns.Add("사용날짜", typeof(string));
            inventoryDataTable.Columns.Add("유통기한", typeof(string));
            inventoryDataTable.Columns.Add("입고번호", typeof(string));
            inventoryDataTable.Columns.Add("재고종류코드", typeof(string));
            while (dr.Read())
            {
                DataRow row = inventoryDataTable.NewRow();
                //DateTime dateOfUse=DateTime.Parse("2001-01-01");                                
                //DateTime dateOfDisposal=DateTime.Parse("2001-01-01");                           
                //try                                                                               
                //{                                                                                 
                //    dateOfUse = DateTime.Parse(dr["DateOfUse"].ToString());                       
                //}
                //catch (FormatException)
                //{
                //}
                //try
                //{
                //    dateOfDisposal = DateTime.Parse(dr["DateOfDisposal"].ToString());
                //}
                //catch (FormatException)
                //{
                //}

                row["재고번호"] = dr["InventoryID"].ToString();
                row["재고명"] = dr["InventoryName"].ToString();
                row["재고량"] = Int32.Parse(dr["InventoryQuantity"].ToString());
                row["출고량"] = 0;
                row["사용날짜"] = dr["DateOfUse"].ToString();
                row["유통기한"] = dr["DateOfDisposal"].ToString();
                row["입고번호"] = dr["ReceivingDetailsID"].ToString();
                row["재고종류코드"] = dr["InventoryTypeCode"].ToString();
                inventoryDataTable.Rows.Add(row);
                
            }
            return inventoryDataTable;
        }
    }
}
