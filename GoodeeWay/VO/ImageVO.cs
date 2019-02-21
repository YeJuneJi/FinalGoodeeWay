using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    class ImageVO
    {
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private byte[] image;

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
