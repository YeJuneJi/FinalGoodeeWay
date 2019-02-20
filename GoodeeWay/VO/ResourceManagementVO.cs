using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class ResourceManagementVO
    {
        private DateTime resourceDate;

        public DateTime ResourceDate
        {
            get { return resourceDate; }
            set { resourceDate = value; }
        }

        private float totInvestPrice;

        public float TotInvestPrice
        {
            get { return totInvestPrice; }
            set { totInvestPrice = value; }
        }

        private float equipPrice;

        public float EquipPrice
        {
            get { return equipPrice; }
            set { equipPrice = value; }
        }

        public override bool Equals(object obj)
        {
            ResourceManagementVO resource = obj as ResourceManagementVO;
            if (resource == null)
            {
                return false;
            }
            equipPrice = resource.EquipPrice;
            return resourceDate == resource.resourceDate;
        }

        public override int GetHashCode()
        {
            return 1119966897 + resourceDate.GetHashCode();
        }
    }
}
