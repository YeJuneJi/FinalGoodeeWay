using GoodeeWay.BUS;
using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.DAO
{
    class EmpDAO : IEmp
    {

        public bool InsertBoard(EmpVO emp)
        {
            string sp = "proc_emp_insert";
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("job", emp.Job);
            sqlParameters[1] = new SqlParameter("Pay", emp.Pay);
            sqlParameters[2] = new SqlParameter("name", emp.Name);
            sqlParameters[3] = new SqlParameter("Department", emp.Department);
            sqlParameters[4] = new SqlParameter("Mobile", emp.Mobile);
            sqlParameters[5] = new SqlParameter("JoinDate", emp.JoinDate);
            sqlParameters[6] = new SqlParameter("BankAccountNo", emp.BankAccountNo);
            sqlParameters[7] = new SqlParameter("Bank", emp.Bank);
            sqlParameters[8] = new SqlParameter("Email", emp.Email);
            sqlParameters[9] = new SqlParameter("Note", emp.Note);
            bool result = false;
            if (new DBConnection().Insert(sp, sqlParameters))
            {
                result = true;
            }
            return result;
        }

        public List<EmpVO> OutputAllBoard()
        {
            List<EmpVO> lst = new List<EmpVO>();
            string sp = "Display";
            SqlDataReader sr = new DBConnection().Select(sp,null);
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
                    Bank = sr["Bank"].ToString(),
                    BankAccountNo = sr["BankAccountNo"].ToString(),
                    Email = sr["Email"].ToString(),
                    Note = sr["Note"].ToString(),
                });
            }
            return lst;
        }

        


    }
}
