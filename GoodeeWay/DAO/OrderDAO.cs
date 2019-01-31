using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodeeWay.Order;

namespace GoodeeWay.DAO
{
    class OrderDAO
    {
        internal List<Menu> GetAllMenu()
        {
            string sp = "SelectMenu"; // 저장 프로시져 이름                        

            try
            {
                return new List<Menu>();//new DBConnection().Select(sp);
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
