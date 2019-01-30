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
    class MenuRecipeDAO
    {
        public bool InsertRecipe(MenuRecipeVO menuRecipeVO)
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "InsertRecipe";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("ingredientAmount", menuRecipeVO.IngredientAmount),
                new SqlParameter("menuCode", menuRecipeVO.MenuCode),
                new SqlParameter("InventoryTypeCode", menuRecipeVO.InventoryTypeCode),
                new SqlParameter("necessary", menuRecipeVO.Necessary)
                
            };
            try
            {
                return connection.Insert(storedProcedure, sqlParameters);

            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
