using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.DAO
{
    class SaleRecordsDAO
    {

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
        /// <param name="saleRecordsVO"></param>
        /// <returns></returns>
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
    }
}
