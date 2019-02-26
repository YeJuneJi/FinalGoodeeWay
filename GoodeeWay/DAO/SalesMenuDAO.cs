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
        DBConnection connection;
        /// <summary>
        /// 메뉴 삭제 메서드
        /// </summary>
        /// <param name="menuCode"></param>
        /// <returns></returns>
        public bool DeleteMenu(string menuCode)
        {
            connection = new DBConnection();
            string storedProcedure = "DeleteSalesMenu";
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
            
            connection = new DBConnection();
            string storedProcedure = "InsertMenu";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("menuCode", salesMenuVO.MenuCode),
                new SqlParameter("menuName", salesMenuVO.MenuName),
                new SqlParameter("price", salesMenuVO.Price),
                new SqlParameter("kCal", salesMenuVO.Kcal),
                new SqlParameter("menuImageLocation", salesMenuVO.MenuImageLocation),
                new SqlParameter("division", salesMenuVO.Division),
                new SqlParameter("additionalContext", salesMenuVO.AdditionalContext),
                new SqlParameter("discountRatio", salesMenuVO.DiscountRatio)
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
        /// 메뉴를 업데이트하는 메서드
        /// </summary>
        /// <param name="salesMenuVO"></param>
        /// <returns></returns>
        public int UpdateMenu(SalesMenuVO salesMenuVO, string oldeMenuCode)
        {
            connection = new DBConnection();
            string storedProcedure = "UpdateSalesMenu";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("menuCode", salesMenuVO.MenuCode),
                new SqlParameter("menuName", salesMenuVO.MenuName),
                new SqlParameter("price", salesMenuVO.Price),
                new SqlParameter("kCal", salesMenuVO.Kcal),
                new SqlParameter("menuImageLocation", salesMenuVO.MenuImageLocation),
                new SqlParameter("division", salesMenuVO.Division),
                new SqlParameter("additionalContext", salesMenuVO.AdditionalContext),
                new SqlParameter("discountRatio", salesMenuVO.DiscountRatio),
                new SqlParameter("oldMenuCode", oldeMenuCode)
            };
            try
            {
                return connection.Update(storedProcedure, sqlParameters);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        internal List<SalesMenuVO> SelectMenuByAdditional(string additional, int division)
        {
            List<SalesMenuVO> lst = new List<SalesMenuVO>();
            string sp = "SelectMenuByAdditional";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("additional", additional),
                new SqlParameter("division", division)
            };
            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
                while (sdr.Read())
                {
                    SalesMenuVO salesMenu = new SalesMenuVO();
                    salesMenu.MenuCode = sdr["menuCode"].ToString();
                    salesMenu.MenuName = sdr["menuName"].ToString();
                    salesMenu.AdditionalContext = sdr["additionalContext"].ToString();
                    salesMenu.Division = int.Parse(sdr["division"].ToString());
                    salesMenu.Kcal = Convert.ToInt32(sdr["kCal"]);
                    salesMenu.MenuImageLocation = sdr["menuImageLocation"].ToString();
                    salesMenu.Price = float.Parse(sdr["price"].ToString());
                    salesMenu.DiscountRatio = float.Parse(sdr["discountRatio"].ToString());
                    lst.Add(salesMenu);
                }
                return lst;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        internal List<SalesMenuVO> SelectMenuByMenuName(string menuName, int division)
        {
            List<SalesMenuVO> lst = new List<SalesMenuVO>();
            string sp = "SelectMenuByMenuName";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("menuName", menuName),
                new SqlParameter("division", division)
            };
            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
                while (sdr.Read())
                {
                    SalesMenuVO salesMenu = new SalesMenuVO();
                    salesMenu.MenuCode = sdr["menuCode"].ToString();
                    salesMenu.MenuName = sdr["menuName"].ToString();
                    salesMenu.AdditionalContext = sdr["additionalContext"].ToString();
                    salesMenu.Division = int.Parse(sdr["division"].ToString());
                    salesMenu.Kcal = Convert.ToInt32(sdr["kCal"]);
                    salesMenu.MenuImageLocation = sdr["menuImageLocation"].ToString();
                    salesMenu.Price = float.Parse(sdr["price"].ToString());
                    salesMenu.DiscountRatio = float.Parse(sdr["discountRatio"].ToString());
                    lst.Add(salesMenu);
                }
                return lst;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<SalesMenuVO> SelectMenuByMenuCode(string menuCode, int division)
        {
            List<SalesMenuVO> lst = new List<SalesMenuVO>();
            string sp = "SelectMenuByMenuCode";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("menuCode", menuCode),
                new SqlParameter("division", division)
            };
            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
                while (sdr.Read())
                {
                    SalesMenuVO salesMenu = new SalesMenuVO();
                    salesMenu.MenuCode = sdr["menuCode"].ToString();
                    salesMenu.MenuName = sdr["menuName"].ToString();
                    salesMenu.AdditionalContext = sdr["additionalContext"].ToString();
                    salesMenu.Division = int.Parse(sdr["division"].ToString());
                    salesMenu.Kcal = Convert.ToInt32(sdr["kCal"]);
                    salesMenu.MenuImageLocation = sdr["menuImageLocation"].ToString();
                    salesMenu.Price = float.Parse(sdr["price"].ToString());
                    salesMenu.DiscountRatio = float.Parse(sdr["discountRatio"].ToString());
                    lst.Add(salesMenu);
                }
                return lst;
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
                    salesMenu.MenuImageLocation = sdr["menuImageLocation"].ToString();
                    salesMenu.Price = float.Parse(sdr["price"].ToString());
                    salesMenu.DiscountRatio = float.Parse(sdr["discountRatio"].ToString());
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
