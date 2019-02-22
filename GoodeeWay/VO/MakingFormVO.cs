using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.VO
{
    class MakingFormVO
    {
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        private string toMaking;

        public string ToMaking
        {
            get { return toMaking; }
            set { toMaking = value; }
        }


        private string sandwichRecipe;

        public string SandwichRecipe
        {
            get { return sandwichRecipe; }
            set { sandwichRecipe = value; }
        }

        private string salad;

        public string Salad
        {
            get { return salad; }
            set { salad = value; }
        }

        private string drink;

        public string Drink
        {
            get { return drink; }
            set { drink = value; }
        }

        private string side;

        public string Side
        {
            get { return side; }
            set { side = value; }
        }

        private string division;

        public string Division
        {
            get { return division; }
            set { division = value; }
        }
    }
}
