using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class InventoryInventoryTypeVO
    {
        private string inventoryID;
        public string InventoryID
        {
            get { return inventoryID; }
            set { inventoryID = value; }
        }
        private string inventoryName;
        public string InventoryName
        {
            get { return inventoryName; }
            set { inventoryName = value; }
        }
        private int inventoryQuantity;
        public int InventoryQuantity
        {
            get { return inventoryQuantity; }
            set { inventoryQuantity = value; }
        }
        private DateTime? dateOfUse;
        public DateTime? DateOfUse
        {
            get { return dateOfUse; }
            set { dateOfUse = value; }
        }
        private DateTime? dateOfDisposal;
        public DateTime? DateOfDisposal
        {
            get { return dateOfDisposal; }
            set { dateOfDisposal = value; }
        }
        private string receivingDetailsID;
        public string ReceivingDetailsID
        {
            get { return receivingDetailsID; }
            set { receivingDetailsID = value; }
        }
        private string inventoryTypeCode;
        public string InventoryTypeCode
        {
            get { return inventoryTypeCode; }
            set { inventoryTypeCode = value; }
        }

    }
}
