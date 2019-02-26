using GoodeeWay.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    public class RealMenuVO
    {
        private MenuAndDetails[] realMenu;

        public MenuAndDetails[] RealMenu
        {
            get { return realMenu; }
            set { realMenu = value; }
        }

    }
}
