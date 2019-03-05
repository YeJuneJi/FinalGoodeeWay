using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    /// <summary>
    /// 판매메뉴의 모든 정보를 담고있는 SalesMenuVO
    /// </summary>
    public class SalesMenuVO
    {
        /// <value>
        /// 메뉴코드
        /// </value>
        private string menuCode;
        /// <value>
        /// 메뉴코드 Getter와 Settrt
        /// </value>
        public string MenuCode
        {
            get { return menuCode; }
            set { menuCode = value; }
        }

        /// <value>
        /// 메뉴명
        /// </value>
        private string menuName;
        /// <value>
        /// 메뉴 명 Getter와 Settrt
        /// </value>
        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }
        /// <value>
        /// 가격
        /// </value>
        private float price;
        /// <value>
        /// 가격 Getter와 Settrt
        /// </value>
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        /// <value>
        /// Kcal
        /// </value>
        private int kcal;
        /// <value>
        /// Kcal Getter와 Settrt
        /// </value>
        public int Kcal
        {
            get { return kcal; }
            set { kcal = value; }
        }

        /// <value>
        /// 이미지경로
        /// </value>
        private string menuImageLocation;
        /// <value>
        /// 이미지경로 Getter와 Settrt
        /// </value>
        public string MenuImageLocation
        {   
            get { return menuImageLocation; }
            set { menuImageLocation = value; }
        }

        /// <value>
        /// 구분
        /// </value>
        
        private int division;
        /// <value>
        /// 구분 Getter와 Settrt
        /// </value>
        public int Division
        {
            get { return division; }
            set { division = value; }
        }

        /// <value>
        /// 부가내용
        /// </value>
        
        private string additionalContext;
        /// <value>
        /// 부가내용 Getter와 Settrt
        /// </value>
        public string AdditionalContext
        {
            get { return additionalContext; }
            set { additionalContext = value; }
        }

        /// <value>
        /// 할인율
        /// </value>
        private float discountRatio;

        /// <value>
        /// 할인율Getter와 Settrt
        /// </value>
        public float DiscountRatio
        {
            get { return discountRatio; }
            set { discountRatio = value; }
        }

    }
}
