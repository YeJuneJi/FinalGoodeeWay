using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.VO
{
    /// <summary>
    /// 이미지의 정보를 가지고 있는 ImageVO 클래스
    /// </summary>
    class ImageVO
    {
        ///<value>
        /// 이미지번호
        ///</value>
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        ///<value>
        /// 이미지명
        ///</value>
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        ///<value>
        /// 이미지고유데이터
        ///</value>
        private byte[] image;

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
