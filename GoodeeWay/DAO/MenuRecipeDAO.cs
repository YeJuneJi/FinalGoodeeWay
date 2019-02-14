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

        public bool DeleteRecipesByMenuCode(string menuCode)
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "DeleteRecipesByMenuCode";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("menuCode", menuCode),
            };
            try
            {
                return connection.Delete(storedProcedure, sqlParameters);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        internal int UpdateRecipes(MenuRecipeVO menuRecipeVO)
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "UpdateRecipes";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("ingredientAmount", menuRecipeVO.IngredientAmount),
                new SqlParameter("menuCode", menuRecipeVO.MenuCode),
                new SqlParameter("InventoryTypeCode", menuRecipeVO.InventoryTypeCode),
                new SqlParameter("necessary", menuRecipeVO.Necessary)
            };
            try
            {
                return connection.Update(storedProcedure, sqlParameters);
                
            }
            catch (SqlException)
            {
                throw;
            }
            
        }


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

        public List<MenuRecipeVO> SelectRecipesByMenuCode(string menuCode)
        {
            List<MenuRecipeVO> lst = new List<MenuRecipeVO>();
            string sp = "SelectRecipesByMenuCode";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("menuCode", menuCode)
            };
            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
                while (sdr.Read())
                {
                    MenuRecipeVO menuRecipe = new MenuRecipeVO();
                    menuRecipe.RecipeNo = sdr["recipeNo"].ToString();
                    menuRecipe.IngredientAmount = Convert.ToInt32(sdr["ingredientAmount"]);
                    menuRecipe.MenuCode = sdr["menuCode"].ToString();
                    menuRecipe.InventoryTypeCode = sdr["InventoryTypeCode"].ToString();
                    menuRecipe.Necessary = Convert.ToBoolean(sdr["necessary"]);
                    lst.Add(menuRecipe);
                }
                return lst;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        
    }
}
