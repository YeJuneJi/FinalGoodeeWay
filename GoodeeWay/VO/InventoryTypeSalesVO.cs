using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class InventoryTypeSalesVO
    {
        private string xAxis;

        public string XAxis
        {
            get { return xAxis; }
            set { xAxis = value; }
        }
        private float useInventory;

        public float UseInventory
        {
            get { return useInventory; }
            set { useInventory = value; }
        }

    }
}
