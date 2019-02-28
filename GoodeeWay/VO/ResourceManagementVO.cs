using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class ResourceManagementVO
    {
        //기간
        private DateTime resourceDate;

        public DateTime ResourceDate
        {
            get { return resourceDate; }
            set { resourceDate = value; }
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

        private float employeePrice;

        public float EmployeePrice
        {
            get { return employeePrice; }
            set { employeePrice = value; }
        }



        //public override bool Equals(object obj)
        //{
        //    ResourceManagementVO resource = obj as ResourceManagementVO;
        //    if (resource == null)
        //    {
        //        return false;
        //    }
        //    if (resource.ResourceDate.Equals(resource))
        //    {
        //        employeePrice = resource.EmployeePrice;
        //        equipPrice = resource.EquipPrice;
        //    }
        //    return resourceDate == resource.ResourceDate;
        //}

        //public override int GetHashCode()
        //{
        //    return 1119966897 + resourceDate.GetHashCode();
        //}
    }
}
