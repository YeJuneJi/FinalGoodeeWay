using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class EquipmentVO
    {
        private string equCode;

        public string EQUCode
        {
            get { return equCode; }
            set { equCode = value; }
        }
        private string detailName;

        public string DetailName
        {
            get { return detailName; }
            set { detailName = value; }
        }
        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private float purchasePrice;

        public float PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        private DateTime purchaseDate;

        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }
        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

    }
}
