using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodeeWay.DB;
using GoodeeWay.Order;

namespace GoodeeWay.DAO
{
    class OrderDetailDAO
    {
        internal List<MenuDetail> getRecipe(string menuName, List<MenuDetail> menuDetailList)
        {
            string procedure = "SelectByRecipesJoinToInventryTypeNSales"; // 저장 프로시져 이름                        
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("menuName", menuName);

            try
            {
                SqlDataReader sdr = new DBConnection().Select(procedure, parameters);

                while (sdr.Read())
                {
                    MenuDetail menuDetail = new MenuDetail();
                    menuDetail.RecipeCode = sdr["recipeNo"].ToString();
                    menuDetail.Amount = int.Parse(sdr["ingredientAmount"].ToString());
                    menuDetail.MenuCode = sdr["menuCode"].ToString();
                    menuDetail.InventoryTypeCode = sdr["inventoryTypeCode"].ToString();
                    menuDetail.Compulsory = bool.Parse(sdr["necessary"].ToString());
                    menuDetail.InventoryName = sdr["InventoryName"].ToString();
                    menuDetail.Division = sdr["MaterialClassification"].ToString();
                    menuDetail.MenuName = sdr["menuName"].ToString();                    
                    menuDetail.DiscountRatio = float.Parse(sdr["discountRatio"].ToString());

                    menuDetailList.Add(menuDetail);
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return menuDetailList;
        }
    }
}
