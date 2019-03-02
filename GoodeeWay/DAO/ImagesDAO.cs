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
    /// <summary>
    /// 데이터베이스에 접근하기 위한 ImageDAO 클래스
    /// </summary>
    class ImagesDAO
    {
        /// <summary>
        /// 이미지를 등록하기위한 InsertImage 메서드
        /// </summary>
        /// <param name="imgVO">이미지의 정보가 담겨있는 ImgVO객체</param>
        /// <returns>DB 등록여부를 반환</returns>
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

        /// <summary>
        /// // 저장된 이미지들의 이름들을 컬렉션으로 가져오는 메서드
        /// </summary>
        /// <returns>성공정으로 검색이 된다면 컬렉션을 반환</returns>
        internal List<string> SelectImagesName() 
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

        /// <summary>
        /// // 저장된 이미지값을 컬렉션으로 가져오는 메서드
        /// </summary>
        /// <returns>성공정으로 검색이 된다면 컬렉션을 반환</returns>
        internal List<ImageVO> SelectImages() 
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

        /// <summary>
        /// // 저장된 이미지들을 이름으로 검색해 객체로 가져오는 메서드
        /// </summary>
        /// <param name="name">검색할 이미지 명</param>
        /// <returns>이미지의 정보들을 imageVO객체로 반환한다.</returns>
        internal ImageVO SelectImagesByName(string name) 
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
