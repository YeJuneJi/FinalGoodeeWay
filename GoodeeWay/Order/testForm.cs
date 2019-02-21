using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.Order
{
    public partial class testForm : Form
    {
        List<string> nameList;
        List<string> hasImageList;
        List<string> needsToUpload;
        List<string> needsToDownload;

        public testForm()
        {
            InitializeComponent();
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            //CheckImages();
            //UploadImage();

            //textBox1.Text = String.Empty;
            //textBox2.Text = String.Empty;
            //textBox3.Text = String.Empty;
            //textBox4.Text = String.Empty;

            //MessageBox.Show("잠시 멈춤");

            //CheckImages();
        }

        //private void CheckImages()
        //{
        //    nameList = new ImagesDAO().SelectImagesName();
        //    hasImageList = new List<string>();
        //    needsToUpload = new List<string>();
        //    needsToDownload = new List<string>();

        //    DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "\\images");

        //    foreach (var fileName in di.GetFiles())
        //    {
        //        hasImageList.Add(fileName.Name);
        //        textBox1.Text += "파일 이름 : " + fileName + "\r\n";
        //    }

        //    foreach (var name in nameList) // 다운로드 해야 되는 파일
        //    {
        //        textBox2.Text += "DB 파일 이름 : " + name + "\r\n";

        //        if (!hasImageList.Contains(name))
        //        {
        //            needsToDownload.Add(name);
        //        }
        //    }

        //    foreach (var file in hasImageList) // 업로드 해야되는 파일
        //    {
        //        if (!nameList.Contains(file))
        //        {
        //            needsToUpload.Add(file);
        //        }
        //    }

        //    foreach (var item in needsToDownload)
        //    {
        //        textBox4.Text += "다운로드 해야되는 파일 이름 : " + item + "\r\n";
        //    }

        //    foreach (var item in needsToUpload)
        //    {
        //        textBox3.Text += "업로드해야되는 파일 이름 : " + item + "\r\n";
        //    }
        //}

        //private void UploadImage()
        //{
        //    foreach (var fileName in needsToUpload)
        //    {
        //        ImageVO imgVO = new ImageVO();
        //        imgVO.Name = fileName;

        //        MemoryStream ms = new MemoryStream();
        //        Image img = Image.FromFile(Application.StartupPath + "\\images\\" + fileName);
        //        img.Save(ms, img.RawFormat);

        //        imgVO.Image = ms.ToArray();

        //        new ImagesDAO().InsertImage(imgVO);
        //    }
        //}

        //private void DownloadImage()
        //{
        //    foreach (var name in needsToDownload)
        //    {
        //        ImageVO imgVO = new ImagesDAO().SelectImagesByName(name);

        //        File.WriteAllBytes(Application.StartupPath + "\\images\\" + imgVO.Name, imgVO.Image);

        //    }
        //}
    }
}
