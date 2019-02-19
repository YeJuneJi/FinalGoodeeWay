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
    class ReceivingDetailsDAO
    {
        internal List<ReceivingDetailsVO> ReceivingDetailsList()
        {
            SqlParameter[] receivingDetailsParameters = null;
            List<ReceivingDetailsVO> receivingDetailsList = new List<ReceivingDetailsVO>();

            SqlDataReader dr = new DBConnection().Select("SelectReceivingDetailsList", receivingDetailsParameters);
            while (dr.Read())
            {
                receivingDetailsList.Add(new ReceivingDetailsVO(dr["ReceivingDetailsDate"].ToString()));
            }
            return receivingDetailsList;
        }

        internal List<ReceivingDetailsDetailViewVO> ReceivingDetailsDetailView(string receivingDetailsDate)
        {
            List<ReceivingDetailsDetailViewVO> ReceivingDetailsDetailViewVOList = new List<ReceivingDetailsDetailViewVO>();
            SqlParameter[] ReceivingDetailsDetailViewParameter = new SqlParameter[1];
            ReceivingDetailsDetailViewParameter[0] = new SqlParameter("receivingDetailsDate",receivingDetailsDate);
            SqlDataReader dr = new DBConnection().Select("SelectReceivingDetails_InventoryType_DetailView", ReceivingDetailsDetailViewParameter);

            while (dr.Read())
            {
                var a = new ReceivingDetailsDetailViewVO()
                {
                    ReceivingDetailsID = dr["ReceivingDetailsID"].ToString(),
                    InventoryName = dr["InventoryName"].ToString(),
                    ExpirationDate = DateTime.Parse(dr["ExpirationDate"].ToString()),
                    Quantity = Int32.Parse(dr["Quantity"].ToString()),
                    UnitPrice = float.Parse(dr["UnitPrice"].ToString()),
                    ReturnStatus = dr["ReturnStatus"].ToString(),
                    InventoryTypeCode = dr["InventoryTypeCode"].ToString()
                };
                ReceivingDetailsDetailViewVOList.Add(a);
            }
            return ReceivingDetailsDetailViewVOList;
        }

        internal void UpdateReceivingDetails(string receivingDetailsID, string returnStatus)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("ReceivingDetailsID", receivingDetailsID);
            sqlParameters[1] = new SqlParameter("ReturnStatus", returnStatus);
            new DBConnection().Update("UpdateReceivingDetails", sqlParameters);//입고내역 중 반품 또는 교환을 반품완 또는 교환완으로 수정하는 프로시져
        }

        internal List<ReceivingDetailsVO> OutPutAllSaleRecords()
        {
            List<ReceivingDetailsVO> lst = new List<ReceivingDetailsVO>();
            string sp = "OutPutAllReceiveingDetails";
            try
            {
                SqlDataReader sdr = new DBConnection().Select(sp, null);
                while (sdr.Read())
                {
                    ReceivingDetailsVO receivingDetailsVO = new ReceivingDetailsVO();
                    receivingDetailsVO.ReceivingDetailsID = sdr["ReceivingDetailsID"].ToString();
                    receivingDetailsVO.UnitPrice = float.Parse(sdr["UnitPrice"].ToString());
                    receivingDetailsVO.InventoryTypeCode = sdr["InventoryTypeCode"].ToString();
                    lst.Add(receivingDetailsVO);
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