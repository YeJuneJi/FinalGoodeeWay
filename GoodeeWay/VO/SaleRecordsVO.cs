using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    /// <summary>
    /// 판매기록의 모든 정보를 담고있는 SalesRecordsVO
    /// </summary>
    public class SaleRecordsVO
    {
        /// <value>
        /// 판매기록번호
        /// </value>
        private int salesNo;

        public int SalesNo
        {
            get { return salesNo; }
            set { salesNo = value; }
        }
        /// <value>
        /// 판매일
        /// </value>
        private DateTime salesDate;

        public DateTime SalesDate
        {
            get { return salesDate; }
            set { salesDate = value; }
        }

        /// <value>
        /// 판매물품명
        /// </value>
        private string salesitemName;

        public string SalesitemName
        {
            get { return salesitemName; }
            set { salesitemName = value; }
        }

        /// <value>
        /// 판매가격
        /// </value>
        private float salesPrice;

        public float SalesPrice
        {
            get { return salesPrice; }
            set { salesPrice = value; }
        }
        /// <value>
        /// 할인
        /// </value>
        private float discount;

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        /// <value>
        /// 세금
        /// </value>
        private float duty;

        public float Duty
        {
            get { return duty; }
            set { duty = value; }
        }
        /// <value>
        /// 총판매액
        /// </value>
        private float salesTotal;

        public float SalesTotal
        {
            get { return salesTotal; }
            set { salesTotal = value; }
        }

        /// <value>
        /// 지불방법
        /// </value>
        private string paymentPlan;

        public string PaymentPlan
        {
            get { return paymentPlan; }
            set { paymentPlan = value; }
        }
    }
}
