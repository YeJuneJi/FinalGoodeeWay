using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.Order
{
    public class MenuAndDetails
    {
        private Menu menu;

        public Menu Menu
        {
            get { return menu; }
            set { menu = value; }
        }

        private List<MenuDetail> menuDetailist;

        public List<MenuDetail> MenuDetailList
        {
            get { return menuDetailist; }
            set { menuDetailist = value; }
        }

    }
}
