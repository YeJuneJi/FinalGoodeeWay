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

        private DataGridViewButtonColumn startButton;

        public DataGridViewButtonColumn StartButton
        {
            get { return startButton; }
            set { startButton = value; }
        }

        private DataGridViewButtonColumn endButton;

        public DataGridViewButtonColumn EndButto
        {
            get { return endButton; }
            set { endButton = value; }
        }

    }
}
