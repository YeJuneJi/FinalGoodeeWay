using GoodeeWay.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    /// <summary>
    /// 판매기록의 Json형식의 판매물품명을 Deserialize한 정보를 담는 RealMenuVO객체
    /// </summary>
    public class RealMenuVO
    {
        /// <value>
        /// 판매물품과 레시피의 정보를 담는 realMenu
        /// </value>
        private MenuAndDetails[] realMenu;

        public MenuAndDetails[] RealMenu
        {
            get { return realMenu; }
            set { realMenu = value; }
        }

    }
}
