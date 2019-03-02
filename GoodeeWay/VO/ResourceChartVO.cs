using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    /// <summary>
    /// 매출현황의 데이터를 저장해 차트로 표현하기위한 ResourceChartVO
    /// </summary>
    class ResourceChartVO
    {
        /// <value>
        /// 기간
        /// </value>
        private string period;

        public string Period
        {
            get { return period; }
            set { period = value; }
        }
        /// <value>
        /// 총 매출액
        /// </value>
        private float totInvestPrice;

        public float TotInvestPrice
        {
            get { return totInvestPrice; }
            set { totInvestPrice = value; }
        }

        /// <value>
        /// 원재료비
        /// </value>
        private float rawMaterialCost;

        public float RawMaterialCost
        {
            get { return rawMaterialCost; }
            set { rawMaterialCost = value; }
        }
        /// <value>
        /// 비품비
        /// </value>
        private float equipPrice;

        public float EquipPrice
        {
            get { return equipPrice; }
            set { equipPrice = value; }
        }

        /// <value>
        /// 인사비
        /// </value>
        private float employeePrice;

        public float EmployeePrice
        {
            get { return employeePrice; }
            set { employeePrice = value; }
        }

    }
}
