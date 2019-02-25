using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class InventorySalesForChartVO
    {
        private string xAxis;

        public string XAxis
        {
            get { return xAxis; }
            set { xAxis = value; }
        }
        private float inventoryNum;

        public float InventoryNum
        {
            get { return inventoryNum; }
            set { inventoryNum = value; }
        }
        private float salesNum;

        public float SalesNum
        {
            get { return salesNum; }
            set { salesNum = value; }
        }

    }
}
