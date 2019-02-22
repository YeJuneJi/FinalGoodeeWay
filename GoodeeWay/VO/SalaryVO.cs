using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    public class SalaryVO
    {
        private string no;

        public string No
        {
            get { return no; }
            set { no = value; }
        }
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
        private float salary;

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        private float tax;

        public float Tax
        {
            get { return tax; }
            set { tax = value; }
        }
        private float bonus;

        public float Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        private float totalSalary;

        public float TotalSalary
        {
            get { return totalSalary; }
            set { totalSalary = value; }
        }
        private DateTime payday;

        public DateTime Payday
        {
            get { return payday; }
            set { payday = value; }
        }

        /*
         no str
         empno str
         salary flo
         tax flo
         bonus flot
         totalsalary flot
         payday datetime
         */
    }
}
