using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.Order
{
    public class MenuDetail
    {
        private string recipeCode;

        public string RecipeCode
        {
            get { return recipeCode; }
            set { recipeCode = value; }
        }

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

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

        private string inventoryTypeCOde;

        public string InventoryTypeCode
        {
            get { return inventoryTypeCOde; }
            set { inventoryTypeCOde = value; }
        }

        private bool compulsory;

        public bool Compulsory
        {
            get { return compulsory; }
            set { compulsory = value; }
        }

        // Join 부분
        private string inventoryName;

        public string InventoryName
        {
            get { return inventoryName; }
            set { inventoryName = value; }
        }


        private string division;

        public string Division
        {
            get { return division; }
            set { division = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private float discountRatio;

        public float DiscountRatio
        {
            get { return discountRatio; }
            set { discountRatio = value; }
        }

    }
}
