using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    public class MenuRecipeVO
    {
        private string recipeNo;

        public string RecipeNo
        {
            get { return recipeNo; }
            set { recipeNo = value; }
        }

        private int ingredientAmount;

        public int IngredientAmount
        {
            get { return ingredientAmount; }
            set { ingredientAmount = value; }
        }

        private string menuCode;

        public string MenuCode
        {
            get { return menuCode; }
            set { menuCode = value; }
        }

        private string inventoryTypeCode;

        public string InventoryTypeCode
        {
            get { return inventoryTypeCode; }
            set { inventoryTypeCode = value; }
        }

        private bool necessary;

        public bool Necessary
        {
            get { return necessary; }
            set { necessary = value; }
        }
    }
}
