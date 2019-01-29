using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class EmpVO
    {
        private string empno;

        public string Empno
        {
            get { return empno; }
            set { empno = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string job;

        public string Job
        {
            get { return job; }
            set { job = value; }
        }
        private float pay;

        public float Pay
        {
            get { return pay; }
            set { pay = value; }
        }
       
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        private DateTime joindate;

        public DateTime JoinDate
        {
            get { return joindate; }
            set { joindate = value; }
        }
        private DateTime leavedate;
            
        public DateTime LeaveDate
        {
            get { return leavedate; }
            set { leavedate = value; }
        }
        private string bankaccountno;

        public string BankAccountNo
        {
            get { return bankaccountno; }
            set { bankaccountno = value; }
        }
        private string bank;

        public string Bank
        {
            get { return bank; }
            set { bank = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

    }
}
