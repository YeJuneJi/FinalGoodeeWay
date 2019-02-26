using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    class CheckImages
    {
        List<string> nameList;
        List<string> hasImageList;
        List<string> needsToUpload;
        List<string> needsToDownload;

        internal void DoAllCheck()
        {
            CheckImage();
            UploadImage();
            DownloadImage();
        }

        private void CheckImage()
        {
            nameList = new ImagesDAO().SelectImagesName();
            hasImageList = new List<string>();
            needsToUpload = new List<string>();
            needsToDownload = new List<string>();

            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "\\images");

            foreach (var fileName in di.GetFiles())
            {
                hasImageList.Add(fileName.Name);                
            }

            foreach (var name in nameList) // 다운로드 해야 되는 파일
            {
                if (!hasImageList.Contains(name))
                {
                    needsToDownload.Add(name);
                }
            }

            foreach (var file in hasImageList) // 업로드 해야되는 파일
            {
                if (!nameList.Contains(file))
                {
                    needsToUpload.Add(file);
                }
            }
        }

        private void UploadImage()
        {
            foreach (var fileName in needsToUpload)
            {
                ImageVO imgVO = new ImageVO();
                imgVO.Name = fileName;

                MemoryStream ms = new MemoryStream();
                Image img = Image.FromFile(Application.StartupPath + "\\images\\" + fileName);
                img.Save(ms, img.RawFormat);

                imgVO.Image = ms.ToArray();

                new ImagesDAO().InsertImage(imgVO);                
            }
        }

        private void DownloadImage()
        {
            foreach (var name in needsToDownload)
            {
                ImageVO imgVO = new ImagesDAO().SelectImagesByName(name);

                if (imgVO.Image != null)
                {
                    File.WriteAllBytes(Application.StartupPath + "\\images\\" + imgVO.Name, imgVO.Image);
                }

            }
        }
    }
}
