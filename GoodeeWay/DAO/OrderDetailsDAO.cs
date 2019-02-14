using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodeeWay.DB;
using GoodeeWay.VO;

namespace GoodeeWay.DAO
{
    class OrderDetailsDAO
    {
        internal void InsertOrderDetails(List<OrderDetailsVO> orderDetailsVOsList)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];
            foreach (var item in orderDetailsVOsList)
            {
                sqlParameters[0] = new SqlParameter("OrderID", item.OrderID);
                sqlParameters[1] = new SqlParameter("OrderDate", item.OrderDate);
                sqlParameters[2] = new SqlParameter("InventoryTypeCode", item.InventoryTypeCode);
                sqlParameters[3] = new SqlParameter("Quantity", item.Quantity);
                try
                {
                    new DBConnection().Insert("InsertOrderDetails", sqlParameters);
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        internal DataTable SelectOrderDetailsList()
        {
            SqlParameter[] sqlParameters = null;
            SqlDataReader dr = new DBConnection().Select("SelectOrderDetailsList", sqlParameters);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("발주날짜");
            while (dr.Read())
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["발주날짜"]= dr["OrderDate"].ToString().Substring(0,10);
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        internal DataTable SelectOrderDetails(string orderDate)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("OrderDate", orderDate);
            SqlDataReader dr = new DBConnection().Select("SelectOrderDetails", sqlParameters);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("발주번호", typeof(string));
            dataTable.Columns.Add("재고명", typeof(string));
            dataTable.Columns.Add("수량", typeof(int));
            dataTable.Columns.Add("재고종류코드", typeof(string));
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["발주번호"] = dr["OrderID"].ToString();
                row["재고명"] = dr["InventoryName"].ToString();
                row["수량"] = Int32.Parse(dr["Quantity"].ToString());
                row["재고종류코드"] = dr["InventoryTypeCode"].ToString();
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

        internal void UpdateOrderDetails(List<OrderDetailsVO> orderDetailsVOList)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            foreach (var item in orderDetailsVOList)
            {
                sqlParameters[0] = new SqlParameter("OrderID", item.OrderID);
                sqlParameters[1] = new SqlParameter("Quantity", item.Quantity);
                new DBConnection().Update("UpdateOrderDetails", sqlParameters);
            }
        }
    }
}
