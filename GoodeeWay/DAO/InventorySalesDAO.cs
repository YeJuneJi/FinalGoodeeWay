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
        /// <summary>
        /// 종류 기준 차트 내용 select
        /// </summary>
        /// <param name="type">종류 기준 : bread,sauce 등등</param>
        /// <param name="chart">시작,종료</param>
        /// <returns></returns>
        internal List<InventoryTypeSalesVO> InventoryTypeSelect(string type, IChart chart)
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
                    UseInventory = (float)Math.Round((float.Parse(dr["UseInventory"].ToString()) / 1000), 2)
                };
                lst.Add(inventoryTypeSales);
            }
            return lst;
        }
        /// <summary>
        /// 재고기준 차트 내용 select
        /// </summary>
        /// <param name="InventoryName">재고기준 : 하티,화이트,칩,치즈 등등</param>
        /// <param name="chart">시작, 종료</param>
        /// <param name="monthYear">월인지 년인지 선택</param>
        /// <returns></returns>
        internal List<InventoryTypeSalesVO> InventorySalesSelect(string InventoryName, IChart chart, bool monthYear)
        {
            lst=new List<InventoryTypeSalesVO>();

            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("InventoryName", InventoryName);
            sqlParameters[1] = new SqlParameter("StartDate", ((InventoryChart)chart).StartDate);
            sqlParameters[2] = new SqlParameter("EndDate", ((InventoryChart)chart).EndDate);
            sqlParameters[3] = new SqlParameter("MonthYear", (monthYear)?0:1);
            SqlDataReader dr = new DBConnection().Select("SelectInventorySalesChart", sqlParameters);
            while (dr.Read())
            {
                InventoryTypeSalesVO inventoryTypeSalesVO = new InventoryTypeSalesVO();
                inventoryTypeSalesVO.InventoryName = dr["DateOfUse"].ToString();
                inventoryTypeSalesVO.UseInventory = (float)Math.Round((float.Parse(dr["InventoryQuantity"].ToString()) / 1000), 2);
                lst.Add(inventoryTypeSalesVO);
            }
            return lst;
             
        }

        internal int InventorySalesCountSelect(DateTime startDate, DateTime endDate, string type)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("StartDate", startDate);
            sqlParameters[1] = new SqlParameter("EndDate", endDate);
            sqlParameters[2] = new SqlParameter("Type", type);

            SqlDataReader dr = new DBConnection().Select("SelectInventorySalesCount", sqlParameters);
            int i = 0;
            while (dr.Read())
            {
                i = Int32.Parse(dr["Count"].ToString());
            }
            return i;
        }
    }
}
