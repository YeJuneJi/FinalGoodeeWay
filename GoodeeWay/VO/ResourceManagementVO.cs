using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    /// <summary>
    /// 매출현황의 데이터를 담을 ResourceManagementVO
    /// </summary>
    class ResourceManagementVO
    {
        /// <value>
        /// 기간
        /// </value>
        private DateTime resourceDate;

        public DateTime ResourceDate
        {
            get { return resourceDate; }
            set { resourceDate = value; }
        }
        /// <value>
        /// 총매출액
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
        /// 인사급여
        /// </value>
        private float employeePrice;

        public float EmployeePrice
        {
            get { return employeePrice; }
            set { employeePrice = value; }
        }


    }
}
