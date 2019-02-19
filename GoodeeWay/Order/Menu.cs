using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.Order
{
    public class Menu
    {
        enum Divi{ Main, Side, Drink };        

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

        private string menuImage;

        public string MenuImage
        {
            get { return menuImage; }
            set { menuImage = value; }
        }

        private string division;

        public string Division
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

        public Menu Clone()
        {
            Menu menu = new Menu();
            menu.menuCode = this.menuCode;
            menu.MenuName = this.MenuName;
            menu.Price = this.Price;
            menu.kcal = this.kcal;
            menu.menuImage = this.menuImage;
            menu.division = this.division;
            menu.additionalContext = this.additionalContext;

            return menu;
        }

        private float discountRatio;

        public float DiscountRatio
        {
            get { return discountRatio; }
            set { discountRatio = value; }
        }

    }
}
