using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class ResourceChartVO
    {
        //기간
        private string period;

        public string Period
        {
            get { return period; }
            set { period = value; }
        }
        //총매출액
        private float totInvestPrice;

        public float TotInvestPrice
        {
            get { return totInvestPrice; }
            set { totInvestPrice = value; }
        }

        //원재료비
        private float rawMaterialCost;

        public float RawMaterialCost
        {
            get { return rawMaterialCost; }
            set { rawMaterialCost = value; }
        }
        //비품비
        private float equipPrice;

        public float EquipPrice
        {
            get { return equipPrice; }
            set { equipPrice = value; }
        }

        //인사비
        private float employeePrice;

        public float EmployeePrice
        {
            get { return employeePrice; }
            set { employeePrice = value; }
        }

    }
}
