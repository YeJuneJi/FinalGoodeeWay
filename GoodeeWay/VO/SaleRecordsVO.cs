using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class SaleRecordsVO
    {
        private int salesNo;

        public int SalesNo
        {
            get { return salesNo; }
            set { salesNo = value; }
        }
        private DateTime salesDate;

        public DateTime SalesDate
        {
            get { return salesDate; }
            set { salesDate = value; }
        }

        private string salesitemName;

        public string SalesitemName
        {
            get { return salesitemName; }
            set { salesitemName = value; }
        }

        private float salesPrice;

        public float SalesPrice
        {
            get { return salesPrice; }
            set { salesPrice = value; }
        }

        private float discount;

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private float duty;

        public float Duty
        {
            get { return duty; }
            set { duty = value; }
        }

        private float salesTotal;

        public float SalesTotal
        {
            get { return salesTotal; }
            set { salesTotal = value; }
        }

        private string paymentPlan;

        public string PaymentPlan
        {
            get { return paymentPlan; }
            set { paymentPlan = value; }
        }
    }
}
