using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class InventoryTypeSalesVO
    {
        private string inventoryName;

        public string InventoryName
        {
            get { return inventoryName; }
            set { inventoryName = value; }
        }
        private int useInventory;

        public int UseInventory
        {
            get { return useInventory; }
            set { useInventory = value; }
        }

    }
}
