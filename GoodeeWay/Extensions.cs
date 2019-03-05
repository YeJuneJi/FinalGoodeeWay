using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay
{
    /// <summary>
    /// 확장메서드를 모아둔 <c>Extensions</c> 클래스
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// 이미지를 바이트로 변경해주는 확장 메서드
        /// </summary>
        /// <param name="image">이미지</param>
        /// <returns>이미지 바이트를 반환</returns>
        public static byte[] ImageToByteArray(this Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, image.RawFormat);
            byte[] imageBytes = memoryStream.ToArray();
            memoryStream.Close();
            return imageBytes;
        }
        /// <summary>
        /// 바이트를 이미지로 변경해주는 확장 메서드
        /// </summary>
        /// <param name="bytes">이미지 바이트</param>
        /// <returns>이미지</returns>
        public static Image ByteArrayToImage(this byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream(bytes);
            Image image = Image.FromStream(memoryStream);
            memoryStream.Close();
            return image;
        }
        /// <summary>
        /// Icon을 Image로 변경해주는 확장메서드
        /// </summary>
        public static Image ToImage(this Icon icon)
        {
            return icon.ToBitmap();
        }

    }
}
