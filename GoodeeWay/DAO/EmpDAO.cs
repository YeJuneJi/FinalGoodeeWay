using GoodeeWay.BUS;
using GoodeeWay.DB;
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

        public bool InsertBoard(EmpVO emp)
        {
            //string name = txtName.Text;
            //string subject = txtTitle.Text;
            //string contents = txtContent.Text;

            //if (check(empno,pay,name,mobile,joindate,bankaccountno,bank))
            //{
            //}
            
            string sp = "proc_emp_insert";
            SqlParameter[] sqlParameters = new SqlParameter[12];
            sqlParameters[0] = new SqlParameter("empno", emp.Empno);
            sqlParameters[1] = new SqlParameter("job", emp.Job);
            sqlParameters[2] = new SqlParameter("Pay", emp.Pay);
            sqlParameters[3] = new SqlParameter("name", emp.Name);
            sqlParameters[4] = new SqlParameter("Department", emp.Department);
            sqlParameters[5] = new SqlParameter("Mobile", emp.Mobile);
            sqlParameters[6] = new SqlParameter("JoinDate", emp.JoinDate);
            sqlParameters[7] = new SqlParameter("LeaveDate", emp.LeaveDate);
            sqlParameters[8] = new SqlParameter("BankAccountNo", emp.BankAccountNo);
            sqlParameters[9] = new SqlParameter("Bank", emp.Bank);
            sqlParameters[10] = new SqlParameter("Email", emp.Email);
            sqlParameters[11] = new SqlParameter("Note", emp.Note);

            return new DBConnection().Insert(sp, sqlParameters);
        }
        //private bool check(string empno, string pay, string name, string mobile, DateTime joindate, string bankaccountno, string bank)
        //{
        //    bool result = false;
        //    return result;
        //}

        public List<EmpVO> OutputAllBoard()
        {
            List<EmpVO> lst = new List<EmpVO>();
            string sp = "Display";
            SqlDataReader sr = new DBConnection().Display(sp);
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


    }
}
