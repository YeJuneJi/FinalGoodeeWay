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

        internal void InventoryUseDetailsInsert(int InventoryQuantity, string receivingDetailsID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0]=new SqlParameter("ReceivingDetailsID", receivingDetailsID);
            SqlDataReader dr =new DBConnection().Select("SelectInventoryDetailsForInsert", sqlParameters);

            SqlParameter[] InsertSqlParameters = new SqlParameter[5];

            while(dr.Read())
            {
                InsertSqlParameters[0] = new SqlParameter("InventoryQuantity", InventoryQuantity);
                InsertSqlParameters[1] = new SqlParameter("DateOfUse", DateTime.Now);
                InsertSqlParameters[2] = new SqlParameter("DateOfDisposal", DateTime.Parse(dr["DateOfDisposal"].ToString()));
                InsertSqlParameters[3] = new SqlParameter("ReceivingDetailsID", receivingDetailsID);
                InsertSqlParameters[4] = new SqlParameter("InventoryTypeCode", dr["InventoryTypeCode"].ToString());
            }
            new DBConnection().Insert("InsertInventoryUseDetails", InsertSqlParameters);
        }

        /// <summary>
        /// 재고사용내역 select
        /// </summary>
        /// <param name="receivingDetailsID">입고번호</param>
        /// <returns></returns>
        internal DataTable InventoryUseDetails(string receivingDetailsID)
        {
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@ReceivingDetailsID", receivingDetailsID);

            SqlDataReader dr= new DBConnection().Select("SelectInventoryDetails", sqlParameter);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("재고명", typeof(string));
            dataTable.Columns.Add("사용구분", typeof(string));
            dataTable.Columns.Add("수량", typeof(int));
            dataTable.Columns.Add("사용날짜", typeof(string));

            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["재고명"] = dr["InventoryName"].ToString();
                row["사용구분"] = dr["InventoryID"].ToString();
                row["수량"] = dr["InventoryQuantity"].ToString();
                string s = dr["DateOfUse"].ToString();
                if (s != "")
                {
                    row["사용날짜"] = dr["DateOfUse"].ToString().Substring(0, 10);
                }
                else
                {
                    row["사용날짜"] = null;
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

        internal DataTable InventoryTableSelect()
        {
            SqlDataReader dr =  new DBConnection().Select("SelectInventory_InventoryType", null);
            DataTable inventoryDataTable = new DataTable();
            inventoryDataTable.Columns.Add("재고번호", typeof(string));
            inventoryDataTable.Columns.Add("재고명", typeof(string));
            inventoryDataTable.Columns.Add("재고량", typeof(int));
            inventoryDataTable.Columns.Add("남은수량", typeof(int));
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
                row["남은수량"] = Int32.Parse(dr["RemainingQuantity"].ToString());
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
