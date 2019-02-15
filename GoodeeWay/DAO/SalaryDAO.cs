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
    class SalaryDAO
    {
        public List<SalaryVO> selectsalary()
        {
            List<SalaryVO> lst = new List<SalaryVO>();

            string sp = "proc_salary_select";
            //SqlParameter[] sqlParameters = null;
            //DataTable dt = con.ExecuteSelect(sp, sqlParameters);
            SqlDataReader sdr = new DBConnection().Select(sp, null);
            while (sdr.Read())
            {
                lst.Add(
                    new SalaryVO
                    {
                        //Empno
                        //Salary
                        //Tax
                        //Bonus
                        //TotalSalary
                        //Payday
                        //                    No = Int32.Parse(item["no"].ToString()),
                        //                    Name = item["name"].ToString(),
                        //                    Mobile = item["mobile"].ToString(),
                        //                    Address = item["address"].ToString()
                    });
            }


            return lst;
        }
    }
}
