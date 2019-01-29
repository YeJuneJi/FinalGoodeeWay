using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class InventoryTypeVO
    {
        private string inventoryTypeCode;

        public string InventoryTypeCode
        {
            get { return inventoryTypeCode; }
            set { inventoryTypeCode = value; }
        }

        private int receivingQuantity;

        public int ReceivingQuantity
        {
            get { return receivingQuantity; }
            set { receivingQuantity = value; }
        }

        private string inventoryName;

        public string InventoryName
        {
            get { return inventoryName; }
            set { inventoryName = value; }
        }

        private string materialClassification;

        public string MaterialClassification
        {
            get { return materialClassification; }
            set { materialClassification = value; }
        }


    }
}
