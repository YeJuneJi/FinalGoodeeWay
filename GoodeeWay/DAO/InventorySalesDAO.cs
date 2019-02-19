using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodeeWay.DB;
using GoodeeWay.InventoryBUS;
using GoodeeWay.VO;

namespace GoodeeWay.DAO
{
    class InventorySalesDAO
    {
        List<InventoryTypeSalesVO> lst;

        internal List<InventoryTypeSalesVO> InventorySalesSelect(string type, IChart chart)
        {
            lst = new List<InventoryTypeSalesVO>();

            SqlParameter[] sqlParameter = new SqlParameter[3];
            sqlParameter[0] = new SqlParameter("MaterialClassification", type);
            sqlParameter[1] = new SqlParameter("StartDate", ((InventoryTypeChart)chart).StartDate);
            sqlParameter[2] = new SqlParameter("EndDate", ((InventoryTypeChart)chart).EndDate);

            SqlDataReader dr = new DBConnection().Select("SelectInventoryTypeChart", sqlParameter);
            while (dr.Read())
            {
                InventoryTypeSalesVO inventoryTypeSales = new InventoryTypeSalesVO()
                {
                    InventoryName = dr["InventoryName"].ToString(),
                    UseInventory = Int32.Parse(dr["UseInventory"].ToString())
                };
                lst.Add(inventoryTypeSales);
            }
            return lst;
        }
    }
}
