using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    public class SalesMenuVO
    {
        private string menuCode;

        public string MenuCode
        {
            get { return menuCode; }
            set { menuCode = value; }
        }

        private string menuName;

        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int kcal;

        public int Kcal
        {
            get { return kcal; }
            set { kcal = value; }
        }

        private string menuImageLocation;

        public string MenuImageLocation
        {   
            get { return menuImageLocation; }
            set { menuImageLocation = value; }
        }

        private int division;

        public int Division
        {
            get { return division; }
            set { division = value; }
        }

        private string additionalContext;

        public string AdditionalContext
        {
            get { return additionalContext; }
            set { additionalContext = value; }
        }

        private float discountRatio;

        public float DiscountRatio
        {
            get { return discountRatio; }
            set { discountRatio = value; }
        }

    }
}
