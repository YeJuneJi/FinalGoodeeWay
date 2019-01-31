using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodeeWay.Order;

namespace GoodeeWay.DAO
{
    class OrderDetailDAO
    {
        internal List<MenuDetail> getRecipe(string menuName)
        {
            string sp = "SelectRecipe"; // 저장 프로시져 이름                        

            try
            {
                return new List<MenuDetail>();// new DBConnection().Select(sp);
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
