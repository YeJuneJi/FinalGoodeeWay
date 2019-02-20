using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class CostOfRawMaterials
    {
        private List<SalesMenuVO> menus;

        public List<SalesMenuVO> Menus
        {
            get { return menus; }
            set { menus = value; }
        }

        private List<MenuRecipeVO> recipes;

        public List<MenuRecipeVO> Recipes
        {
            get { return recipes; }
            set { recipes = value; }
        }

    }
}
