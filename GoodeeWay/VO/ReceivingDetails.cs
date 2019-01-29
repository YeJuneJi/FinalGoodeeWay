using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class ReceivingDetails
    {
        private string receivingDetailsID;
        public string ReceivingDetailsID
        {
            get { return receivingDetailsID; }
            set { receivingDetailsID = value; }
        }
        private DateTime receivingDetailsDate;
        public DateTime ReceivingDetailsDate
        {
            get { return receivingDetailsDate; }
            set { receivingDetailsDate = value; }
        }
        private DateTime expirationDate;
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private float unitPrice;
        public float UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        private string returnStatus;
        public string ReturnStatus
        {
            get { return returnStatus; }
            set { returnStatus = value; }
        }
        private string inventoryTypeCode;
        public string InventoryTypeCode
        {
            get { return inventoryTypeCode; }
            set { inventoryTypeCode = value; }
        }


    }
}
