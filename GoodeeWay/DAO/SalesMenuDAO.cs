using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace GoodeeWay.DAO
{
    class SalesMenuDAO
    {
        MemoryStream memoryStream;
        DBConnection connection;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuCode"></param>
        /// <returns></returns>
        public bool DeleteMenu(string menuCode)
        {
            connection = new DBConnection();
            string storedProcedure = "DeleteSales";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("menuCode", menuCode)
            };
            try
            {
                return connection.Delete(storedProcedure, sqlParameters);
            }
            catch (SqlException)
            {
                throw;
            }
        }


        /// <summary>
        /// 메뉴를 등록 시키는 메서드입니다.
        /// </summary>
        /// <param name="salesMenuVO"> SalesMenuVO클래스의 객체</param>
        /// <returns>DBConnection의 InsertMethod를 가져온다.</returns>
        public bool InsertMenu(SalesMenuVO salesMenuVO)
        {
            memoryStream = new MemoryStream();
            salesMenuVO.MenuImage.Save(memoryStream, salesMenuVO.MenuImage.RawFormat);
            byte[] imageBytes = memoryStream.ToArray();
            connection = new DBConnection();
            string storedProcedure = "InsertMenu";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("menuCode", salesMenuVO.MenuCode),
                new SqlParameter("menuName", salesMenuVO.MenuName),
                new SqlParameter("price", salesMenuVO.Price),
                new SqlParameter("kCal", salesMenuVO.Kcal),
                new SqlParameter("menuImage", imageBytes),
                new SqlParameter("division", salesMenuVO.Division),
                new SqlParameter("additionalContext", salesMenuVO.AdditionalContext)
            };
            memoryStream.Close();
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
        /// 메뉴를 업데이트하는 메서드
        /// </summary>
        /// <param name="salesMenuVO"></param>
        /// <returns></returns>
        public int UpdateMenu(SalesMenuVO salesMenuVO, string oldeMenuCode)
        {
            memoryStream = new MemoryStream();
            salesMenuVO.MenuImage.Save(memoryStream, salesMenuVO.MenuImage.RawFormat);
            byte[] imageBytes = memoryStream.ToArray();
            connection = new DBConnection();
            string storedProcedure = "UpdateSales";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("menuCode", salesMenuVO.MenuCode),
                new SqlParameter("menuName", salesMenuVO.MenuName),
                new SqlParameter("price", salesMenuVO.Price),
                new SqlParameter("kCal", salesMenuVO.Kcal),
                new SqlParameter("menuImage", imageBytes),
                new SqlParameter("division", salesMenuVO.Division),
                new SqlParameter("additionalContext", salesMenuVO.AdditionalContext),
                new SqlParameter("oldMenuCode", oldeMenuCode)
            };
            memoryStream.Close();
            try
            {
                return connection.Update(storedProcedure, sqlParameters);
            }
            catch (SqlException)
            {
                throw;
            }
        }


        /// <summary>
        /// 모든 메뉴를 검색하는OutPutAllMenus 메서드
        /// </summary>
        /// <returns>모든메뉴를 List<SalesMenuVO>화 시켜 반환</returns>
        public List<SalesMenuVO> OutPutAllMenus()
        {
            List<SalesMenuVO> lst = new List<SalesMenuVO>();
            string sp = "SelectMenu";
            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, null);
                while (sdr.Read())
                {
                    SalesMenuVO salesMenu =  new SalesMenuVO();
                    
                    salesMenu.MenuCode = sdr["menuCode"].ToString();
                    salesMenu.MenuName = sdr["menuName"].ToString();
                    salesMenu.AdditionalContext = sdr["additionalContext"].ToString();
                    salesMenu.Division = int.Parse(sdr["division"].ToString());
                    salesMenu.Kcal = Convert.ToInt32(sdr["kCal"]);
                    byte[] imgArr = sdr["menuImage"] as byte[];
                    memoryStream = new MemoryStream(imgArr);
                    Image image = Image.FromStream(memoryStream);
                    salesMenu.MenuImage = image;
                    salesMenu.Price = float.Parse(sdr["price"].ToString());
                    lst.Add(salesMenu);
                }
                return lst;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
