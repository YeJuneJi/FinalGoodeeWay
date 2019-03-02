using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    /// <summary>
    /// 메뉴레시피의 모든 데이터를 가지고있는 MenuRecipeVO 클래스
    /// </summary>
    public class MenuRecipeVO
    {
        /// <value>
        /// 레시피번호
        /// </value>
        private string recipeNo;

        public string RecipeNo
        {
            get { return recipeNo; }
            set { recipeNo = value; }
        }

        /// <value>
        /// 사용량
        /// </value>
        private int ingredientAmount;

        public int IngredientAmount
        {
            get { return ingredientAmount; }
            set { ingredientAmount = value; }
        }

        /// <value>
        /// 메뉴코드
        /// </value>
        private string menuCode;

        public string MenuCode
        {
            get { return menuCode; }
            set { menuCode = value; }
        }

        /// <value>
        /// 재고종류코드
        /// </value>
        private string inventoryTypeCode;

        public string InventoryTypeCode
        {
            get { return inventoryTypeCode; }
            set { inventoryTypeCode = value; }
        }

        /// <value>
        /// 필수여부
        /// </value>
        private bool necessary;

        public bool Necessary
        {
            get { return necessary; }
            set { necessary = value; }
        }
    }
}
