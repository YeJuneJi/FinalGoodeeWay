
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GoodeeWay.VO
{
    class ByMenuVO
    {
        private string menuName;

        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private double percent;

        public double Percent
        {
            get { return percent; }
            set { percent = value; }
        }


    }
}