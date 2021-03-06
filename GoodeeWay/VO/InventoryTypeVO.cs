﻿using System;
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
        private int minimumQuantity;
        public int MinimumQuantity
        {
            get { return minimumQuantity; }
            set { minimumQuantity = value; }
        }


        public InventoryTypeVO(string InventoryTypeCode, string ReceivingQuantity, string InventoryName, string MaterialClassification)
        {
            this.inventoryTypeCode = "ST" + InventoryTypeCode;
            this.receivingQuantity = Int32.Parse(ReceivingQuantity);
            this.inventoryName = InventoryName;
            this.materialClassification = MaterialClassification;
        }

        public InventoryTypeVO()
        {
        }
    }
}
