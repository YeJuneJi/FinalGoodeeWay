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
        List<SalaryVO> lst = new List<SalaryVO>();

        public List<SalaryVO> SelectAll()
        {
            string sp = "proc_salary_select";
            SqlDataReader sdr = new DBConnection().Select(sp, null);
            while (sdr.Read())
            {
                lst.Add(new SalaryVO()
                {
                    No = sdr["No"].ToString(),
                    Empno = sdr["Empno"].ToString(),
                    Name = sdr["Name"].ToString(),
                    Salary = float.Parse(sdr["Salary"].ToString()),
                    Tax = float.Parse(sdr["Tax"].ToString()),
                    Bonus = float.Parse(sdr["Bonus"].ToString()),
                    TotalSalary = float.Parse(sdr["TotalSalary"].ToString()),
                    Payday = DateTime.Parse(sdr["Payday"].ToString())
                });
            }
            return lst;
        }

        public bool InsertSalary(SalaryVO s)
        {
            string sp = "proc_salary_insert";//저장프로시져 이름
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("Empno", s.Empno);
            sqlParameters[1] = new SqlParameter("Salary", s.Salary);
            sqlParameters[2] = new SqlParameter("Tax", s.Tax);
            sqlParameters[3] = new SqlParameter("Bonus", s.Bonus);
            sqlParameters[4] = new SqlParameter("TotalSalary", s.TotalSalary);
            sqlParameters[5] = new SqlParameter("Payday", s.Payday);
            bool result = false;
            if (new DBConnection().Insert(sp, sqlParameters))
            {
                result = true;
            }
            return result;
        }

        public bool DeleteSalary(string no)
        {
            string sp = "proc_salary_delete";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("no", no);
            bool result = false;
            if (new DBConnection().Delete(sp, sqlParameters))
            {
                result = true;
            }
            return result;
        }

        public bool UpdateSalary(SalaryVO s)
        {
            string sp = "proc_salary_update";//저장프로시져 이름
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("Empno", s.Empno);
            sqlParameters[1] = new SqlParameter("Salary", s.Salary);
            sqlParameters[2] = new SqlParameter("Tax", s.Tax);
            sqlParameters[3] = new SqlParameter("Bonus", s.Bonus);
            sqlParameters[4] = new SqlParameter("TotalSalary", s.TotalSalary);
            sqlParameters[5] = new SqlParameter("Payday", s.Payday);
            bool result = false;
            if (new DBConnection().Update(sp, sqlParameters))
            {
                result = true;
            }
            return result;
        }
    }
}
