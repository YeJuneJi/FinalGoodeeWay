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

        internal List<MakingFormVO> SelectMaking()
        {
            List<MakingFormVO> lst = new List<MakingFormVO>();
            string sp = "SelectMaking";
            SqlParameter[] sqlParameters = null;

            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
                while (sdr.Read())
                {
                    MakingFormVO makingFormVO = new MakingFormVO();
                    makingFormVO.Num = int.Parse(sdr["num"].ToString());
                    makingFormVO.ToMaking = sdr["tomaking"].ToString();
                    makingFormVO.Division = sdr["division"].ToString();

                    lst.Add(makingFormVO);
                }

                return lst;
            }
            catch (SqlException ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.StackTrace);
                throw;
            }
        }

        internal bool DeleteMaking(int num)
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "DeleteMaking";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("num", num)
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

        internal int UpdateMaking(int num)
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "UpdateMaking";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("num", num)
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
    }
}
