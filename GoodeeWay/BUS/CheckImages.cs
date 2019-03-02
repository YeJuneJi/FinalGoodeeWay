using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    /// <summary>
    /// 이미지를 검사하고, 결과내용을 기반으로 업로드와 다운로드를 하기위한 <c>CheckImages</c> 클래스
    /// </summary>
    class CheckImages
    {
       ///<value>DB의에 담긴 이미지명을 가져오기위한 List of nameList</value>
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
        /// <summary>
        /// DB에 담긴 이미지를 체크하여 지정된 경로의 이미지와 비교판단 후 다운로드 해야하는 파일과 업로드 해야하는 파일을 구분하기 위한 메서드
        /// </summary>
        private void CheckImage()
        {
            try
            {
                nameList = new ImagesDAO().SelectImagesName();
            }
            catch (SqlException except)
            {
                MessageBox.Show(except.StackTrace);
            }
            hasImageList = new List<string>();
            needsToUpload = new List<string>();
            needsToDownload = new List<string>();

            try
            {
                //이미지 폴더안의 모든 파일명을 가져온다.
                DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "\\images");
                foreach (var fileName in di.GetFiles())
                {
                    //이미지 폴더안의 모든 파일명을 컬렉션에 저장
                    hasImageList.Add(fileName.Name);
                }
            }
            catch (ArgumentException except)
            {
                MessageBox.Show(except.StackTrace);
            }

            //DB에 있는 모든 이미지명을 가져와반복한다.
            foreach (var name in nameList) // 다운로드 해야 되는 파일
            {
                //만약  이미지 폴더안의 파일명과 DB에있는 파일명중 동일하지않은것이 있다면
                if (!hasImageList.Contains(name))
                {//다운로드가 필요한 리스트에 파일명을 저장한다.
                    needsToDownload.Add(name);
                }
            }
            //가지고있는 이미지명을 반복한다.
            foreach (var file in hasImageList) // 업로드 해야되는 파일
            {
                //만약 DB의 이미지 이름과 폴더내의 이미지 이름과 다르다면
                if (!nameList.Contains(file))
                {//업로드가 필요한 리스트에 파일명을 저장한다.
                    needsToUpload.Add(file);
                }
            }
        }

        /// <summary>
        /// 이미지 폴더내의 새로운 이미지를 DB에 저장하기위한 메서드
        /// </summary>
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

                try
                {
                    new ImagesDAO().InsertImage(imgVO);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }
        /// <summary>
        /// DB에 저장된 이미지를 이미지 폴더 내에 저장하기 위한 메서드.
        /// </summary>
        private void DownloadImage()
        {
            string downloadImage = string.Empty;
            foreach (var name in needsToDownload)
            {
                try
                {
                    ImageVO imgVO = new ImagesDAO().SelectImagesByName(name);
                    downloadImage += imgVO.Name + Environment.NewLine;
                    File.WriteAllBytes(Application.StartupPath + "\\images\\" + imgVO.Name, imgVO.Image);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
            MessageBox.Show("현재 폴더에없는" + Environment.NewLine+downloadImage +"가 다운로드 되었습니다");
        }
    }
}
