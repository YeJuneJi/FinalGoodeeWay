using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay
{
    public static class ImageConverter
    {
        public static byte[] ImageToByteArray(this Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, image.RawFormat);
            byte[] imageBytes = memoryStream.ToArray();
            memoryStream.Close();
            return imageBytes;
        }

        public static Image ByteArrayToImage(this byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream(bytes);
            Image image = Image.FromStream(memoryStream);
            memoryStream.Close();
            return image;
        }
    }
}
