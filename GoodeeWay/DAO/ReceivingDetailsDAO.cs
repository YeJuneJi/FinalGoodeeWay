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
    }
}