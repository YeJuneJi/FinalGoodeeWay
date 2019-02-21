using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.DAO
{
    class ImagesDAO
    {
        internal bool InsertImage(ImageVO imgVO)
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "InsertImages";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("name", imgVO.Name),
                new SqlParameter("image", imgVO.Image)
            };

            try
            {
                return connection.Insert(storedProcedure, sqlParameters);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        internal List<string> SelectImagesName() // 저장된 이미지들의 이름들을 가져오는 메서드
        {
            List<string> lst = new List<string>();
            string sp = "SelectImagesName";
            SqlParameter[] sqlParameters = null;

            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
                while (sdr.Read())
                {                    
                    string name = sdr["name"].ToString();                    

                    lst.Add(name);
                }

                return lst;
            }
            catch (SqlException ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.StackTrace);
                throw;
            }
        }

        internal List<ImageVO> SelectImages() // 저장된 이미지들을 가져오는 메서드
        {
            List<ImageVO> lst = new List<ImageVO>();
            string sp = "SelectImages";
            SqlParameter[] sqlParameters = null;

            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
                while (sdr.Read())
                {
                    ImageVO imageVO = new ImageVO();
                    imageVO.Num = int.Parse(sdr["num"].ToString());
                    imageVO.Name = sdr["name"].ToString();
                    byte[] b = (byte[])sdr["image"];
                    imageVO.Image = b;

                    lst.Add(imageVO);
                }

                return lst;
            }
            catch (SqlException ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.StackTrace);
                throw;
            }
        }

        internal ImageVO SelectImagesByName(string name) // 저장된 이미지들을 가져오는 메서드
        {            
            string sp = "SelectImagesByName";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("name", name)                
            };

            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
                ImageVO imageVO = new ImageVO();

                while (sdr.Read())
                {                    
                    imageVO.Num = int.Parse(sdr["num"].ToString());
                    imageVO.Name = sdr["name"].ToString();                    
                    imageVO.Image = (byte[])sdr["image"];
                }

                return imageVO;
            }
            catch (SqlException ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.StackTrace);
                throw;
            }
        }
    }
}
