using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.DAO
{
    class EmpDAO : IEmp
    {
        SqlConnection con;

        public List<EmpVO> OutputAllBoard()
        {
            List<EmpVO> lst = new List<EmpVO>();
            string sp = "select";
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            
            SqlDataReader sr = GetEntryBoard(sp);
            while (sr.Read())
            {
                lst.Add(new EmpVO()
                {
                    Empno = sr["empno"].ToString(),
                    Name = sr["name"].ToString(),
                    Job = sr["job"].ToString(),
                    Pay = float.Parse(sr["pay"].ToString()),
                    Department = sr["Department"].ToString(),
                    Mobile = sr["Mobile"].ToString(),
                    JoinDate = DateTime.Parse(sr["JoinDate"].ToString()),
                    LeaveDate = DateTime.Parse(sr["LeaveDate"].ToString()),
                    BankAccountNo = sr["BankAccountNo"].ToString(),
                    Bank = sr["Bank"].ToString(),
                    Email = sr["Email"].ToString(),
                    Note = sr["Note"].ToString(),
                });
            }
            return lst;
        }

        internal SqlDataReader GetEntryBoard(string sp)
        {
            SqlConnection sqlCon = OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = sp;


            try
            {

                return cmd.ExecuteReader();
            }
            catch (SqlException)
            {

                throw;
            }

        }
        private SqlConnection OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed || con.State == System.Data.ConnectionState.Broken)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException)
                {

                    throw;//예외를 처리하지않고 그대로 나를 호출한 곳으로 넘김
                }
            }
            return con;
        }

    }
}
