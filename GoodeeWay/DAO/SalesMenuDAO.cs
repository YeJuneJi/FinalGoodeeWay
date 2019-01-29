using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.DAO
{
    class SalesMenuDAO
    {

        /// <summary>
        /// 메뉴를 등록 시키는 메서드입니다.
        /// </summary>
        /// <param name="salesMenuVO"> SalesMenuVO클래스의 객체</param>
        /// <returns>DBConnection의 InsertMethod를 가져온다.</returns>
        public bool InsertMenu(SalesMenuVO salesMenuVO)
        {
            MemoryStream memoryStream = new MemoryStream();
            salesMenuVO.MenuImage.Save(memoryStream, salesMenuVO.MenuImage.RawFormat);
            byte[] imageBytes = memoryStream.ToArray();
            DBConnection connection = new DBConnection();
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
    }
}
