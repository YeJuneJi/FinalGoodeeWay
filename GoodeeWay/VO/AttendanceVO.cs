using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class AttendanceVO
    {
        private int no;

        public int No
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
        private DateTime timeIn;

        public DateTime TimeIn
        {
            get { return timeIn; }
            set { timeIn = value; }
        }
        private DateTime timeOut;

        public DateTime TimeOut
        {
            get { return timeOut; }
            set { timeOut = value; }
        }
        private DateTime totalTime;

        public DateTime TotalTime
        {
            get { return totalTime; }
            set { totalTime = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private float totalPay;

        public float TotalPay
        {
            get { return totalPay; }
            set { totalPay = value; }
        }
        private DateTime overTime;

        public DateTime OverTime
        {
            get { return overTime; }
            set { overTime = value; }
        }
        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

    }
}
