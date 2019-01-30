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
    }
}
