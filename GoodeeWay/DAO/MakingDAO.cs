using GoodeeWay.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.DAO
{
    class MakingDAO
    {
        internal bool InsertMaking(string toMaking)
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "InsertMaking";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("tomaking", toMaking),
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
