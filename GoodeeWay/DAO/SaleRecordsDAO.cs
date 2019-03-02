using GoodeeWay.DB;
using GoodeeWay.VO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.DAO
{
    /// <summary>
    /// 판매기록 테이블의 데이터베이스에 접근하기위한 SaleRecordsDAO 클래스
    /// </summary>
    class SaleRecordsDAO
    {
        /// <summary>
        /// 지정된 판매번호를삭제하기위한 DeleteSaleRecordsbySalesNo 메서드
        /// </summary>
        /// <param name="salesNo">삭제할 판매번호</param>
        /// <returns>삭제 성공여부 반환</returns>
        public bool DeleteSaleRecordsbysalesNo(string salesNo)
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "DeleteSaleRecordsbysalesNo";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("salesNo", salesNo),
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
        /// 판매기록 환불을 위한 RefundSaleRecords메서드
        /// </summary>
        /// <param name="salesNo">환불할 판매번호</param>
        /// <returns>성공 여부 반환</returns>
        internal int RefundSaleRecords(int salesNo)
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "RefundSaleRecords";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("salesNo", salesNo)
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
        /// <summary>
        /// 판매기록 수정을 위한 UpdateSaleRecords
        /// </summary>
        /// <param name="saleRecordsVO"> 판매기록 데이터가 담긴 saleRecordsVO 객체</param>
        /// <returns>성공 여부 반환</returns>
        internal int UpdateSaleRecords(SaleRecordsVO saleRecordsVO)
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "UpdateSaleRecords";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("salesNo", saleRecordsVO.SalesNo),
                new SqlParameter("salesDate", saleRecordsVO.SalesDate),
                new SqlParameter("salesitemName", saleRecordsVO.SalesitemName),
                new SqlParameter("salesPrice", saleRecordsVO.SalesPrice),
                new SqlParameter("discount", saleRecordsVO.Discount),
                new SqlParameter("duty", saleRecordsVO.Duty),
                new SqlParameter("salesTotal", saleRecordsVO.SalesTotal),
                new SqlParameter("paymentPlan", saleRecordsVO.PaymentPlan)
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

        

        /// <summary>
        /// 판매기록 Insert 메서드
        /// </summary>
        /// <param name="saleRecordsVO">판매기록의 데이터가 담긴 saleRecords객체</param>
        /// <returns>성공 여부 반환</returns>
        public bool InsertSaleRecords(SaleRecordsVO saleRecordsVO) 
        {
            DBConnection connection = new DBConnection();
            string storedProcedure = "InsertSaleRecords";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("salesDate", saleRecordsVO.SalesDate),
                new SqlParameter("salesitemName", saleRecordsVO.SalesitemName),
                new SqlParameter("salesPrice", saleRecordsVO.SalesPrice),
                new SqlParameter("discount", saleRecordsVO.Discount),
                new SqlParameter("duty", saleRecordsVO.Duty),
                new SqlParameter("salesTotal", saleRecordsVO.SalesTotal),
                new SqlParameter("paymentPlan", saleRecordsVO.PaymentPlan)
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
        /// 기간별 판매기록을 검색하기 위한 SelectSaleRacordsByPeriod 메서드
        /// </summary>
        /// <param name="periodStart">시작기간</param>
        /// <param name="periodEnd">종료기간</param>
        /// <returns>검색결과를 컬렉션으로 반환</returns>
        public List<SaleRecordsVO> SelectSaleRacordsByPeriod(DateTime periodStart, DateTime periodEnd)
        {
            List<SaleRecordsVO> lst = new List<SaleRecordsVO>();
            string sp = "SelectSaleRacordsByPeriod";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("periodStart", periodStart),
                new SqlParameter("periodEnd", periodEnd)
            };
            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
                while (sdr.Read())
                {
                    SaleRecordsVO saleRecordsVO = new SaleRecordsVO();
                    saleRecordsVO.SalesNo = Convert.ToInt32(sdr["salesNo"]);
                    saleRecordsVO.SalesDate = Convert.ToDateTime(sdr["salesDate"]);
                    saleRecordsVO.SalesitemName = sdr["salesitemName"].ToString();
                    saleRecordsVO.SalesPrice = float.Parse(sdr["salesPrice"].ToString());
                    saleRecordsVO.Discount = float.Parse(sdr["discount"].ToString());
                    saleRecordsVO.Duty = float.Parse(sdr["duty"].ToString());
                    saleRecordsVO.SalesTotal = float.Parse(sdr["salesTotal"].ToString());
                    saleRecordsVO.PaymentPlan = sdr["paymentPlan"].ToString();
                    lst.Add(saleRecordsVO);
                }
                return lst;

            }
            catch (SqlException)
            {
                throw;
            }
        }
        /// <summary>
        /// 판매번호별 판매기록을 검색하기 위한 SelectSaleRecordsBysalesNo 메서드
        /// </summary>
        /// <param name="salesNo">검색할 판매번호</param>
        /// <returns>검색 결과를 컬렉션으로 반환한다</returns>
        public List<SaleRecordsVO> SelectSaleRecordsBysalesNo(string salesNo)
        {
            List<SaleRecordsVO> lst = new List<SaleRecordsVO>();
            string sp = "SelectSaleRecordsBysalesNo";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("salesNo", salesNo)
            };
            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
                while (sdr.Read())
                {
                    SaleRecordsVO saleRecordsVO = new SaleRecordsVO();
                    saleRecordsVO.SalesNo = Convert.ToInt32(sdr["salesNo"]);
                    saleRecordsVO.SalesDate = Convert.ToDateTime(sdr["salesDate"]);
                    saleRecordsVO.SalesitemName = sdr["salesitemName"].ToString();
                    saleRecordsVO.SalesPrice = float.Parse(sdr["salesPrice"].ToString());
                    saleRecordsVO.Discount = float.Parse(sdr["discount"].ToString());
                    saleRecordsVO.Duty = float.Parse(sdr["duty"].ToString());
                    saleRecordsVO.SalesTotal = float.Parse(sdr["salesTotal"].ToString());
                    saleRecordsVO.PaymentPlan = sdr["paymentPlan"].ToString();
                    lst.Add(saleRecordsVO);
                }
                return lst;

            }
            catch (SqlException)
            {
                throw;
            }
        }
        /// <summary>
        /// 모든 판매기록을 검색하기위한 메서드
        /// </summary>
        /// <returns> 검색결과를 컬렉션으로 반환</returns>
        public List<SaleRecordsVO> OutPutAllSaleRecords()
        {
            List<SaleRecordsVO> lst = new List<SaleRecordsVO>();
            string sp = "SelectSaleRecords";
            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, null);
                while (sdr.Read())
                {
                    SaleRecordsVO saleRecordsVO = new SaleRecordsVO();
                    saleRecordsVO.SalesNo = Convert.ToInt32(sdr["salesNo"]);
                    saleRecordsVO.SalesDate = Convert.ToDateTime(sdr["salesDate"]);
                    saleRecordsVO.SalesitemName = sdr["salesitemName"].ToString();
                    saleRecordsVO.SalesPrice = float.Parse(sdr["salesPrice"].ToString());
                    saleRecordsVO.Discount = float.Parse(sdr["discount"].ToString());
                    saleRecordsVO.Duty = float.Parse(sdr["duty"].ToString());
                    saleRecordsVO.SalesTotal = float.Parse(sdr["salesTotal"].ToString());
                    saleRecordsVO.PaymentPlan = sdr["paymentPlan"].ToString();
                    lst.Add(saleRecordsVO);
                }
                return lst;
            }
            catch (SqlException)
            {
                throw;
            }
        }



        /// <summary>
        /// 재고별판매량 실 판매량 데이터 추출
        /// </summary>
        /// <param name="startDate">시작기간</param>
        /// <param name="endDate">종료기간</param>
        /// <param name="cmbType">구분</param>
        /// <returns>검색결과를 컬렉션으로 반환</returns>
        internal List<InventoryTypeSalesVO> InventorySaleRecordsTypeSelect(DateTime startDate, DateTime endDate, string cmbType)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            List<InventoryTypeSalesVO> List = new List<InventoryTypeSalesVO>() ;
            sqlParameters[0] = new SqlParameter("StartDate", startDate);
            sqlParameters[1] = new SqlParameter("EndDate", endDate);

            SqlDataReader dr = new DBConnection().Select("SelectSaleRecordsType", sqlParameters);
            while (dr.Read())
            {
                JObject jObject=JObject.Parse(dr["salesitemName"].ToString());
                JArray jArray = JArray.Parse(jObject["RealMenu"].ToString());
                foreach (var item in jArray)
                {
                    JArray jArray1=null;
                    try
                    {
                        jArray1 = JArray.Parse(item["MenuDetailList"].ToString());
                        foreach (var item1 in jArray1)
                        {
                            if (item1["Division"].ToString() == cmbType)
                            {
                                InventoryTypeSalesVO inventoryTypeSalesVO = new InventoryTypeSalesVO()
                                {
                                    XAxis = item1["InventoryName"].ToString(),
                                    UseInventory = float.Parse(item1["Amount"].ToString())
                                };
                                List.Add(inventoryTypeSalesVO);
                            }
                        }
                    }
                    catch (JsonReaderException )
                    {
                    }
 
                }
            }

            return List;
        }

        /// <summary>
        /// 판매기록별타입 검색
        /// </summary>
        /// <param name="startDate">시작기간</param>
        /// <param name="endDate">종료기간</param>
        /// <param name="cmbType">구분</param>
        /// <returns>검색결과를 컬렉션으로 반환</returns>
        internal List<InventoryTypeSalesVO> TypeSaleRecordsTypeSelect(DateTime startDate, DateTime endDate, string cmbType)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            List<InventoryTypeSalesVO> List = new List<InventoryTypeSalesVO>();
            sqlParameters[0] = new SqlParameter("StartDate", startDate);
            sqlParameters[1] = new SqlParameter("EndDate", endDate);
            SqlDataReader dr = new DBConnection().Select("SelectTypeSaleRecordsType", sqlParameters);
            while (dr.Read())
            {
                JObject jObject = JObject.Parse(dr["salesitemName"].ToString());
                JArray jArray = JArray.Parse(jObject["RealMenu"].ToString());
                foreach (var item in jArray)
                {
                    JArray jArray1 = null;
                    try
                    {
                        jArray1 = JArray.Parse(item["MenuDetailList"].ToString());
                        foreach (var item1 in jArray1)
                        {
                            if (item1["InventoryName"].ToString() == cmbType)
                            {
                                InventoryTypeSalesVO inventoryTypeSalesVO = new InventoryTypeSalesVO()
                                {
                                    XAxis = dr["salesDate"].ToString(),
                                    UseInventory = float.Parse(item1["Amount"].ToString())
                                };
                                List.Add(inventoryTypeSalesVO);
                            }
                        }
                    }
                    catch (JsonReaderException)
                    {
                    }


                }
            }
            return List;

        }
    }
}
