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

        private float resourcePrice;

        public float ResourcePrice
        {
            get { return resourcePrice; }
            set { resourcePrice = value; }
        }


    }
}
