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
    class InventoryTypeDAO
    {
        /// <summary>
        /// 재고종류 추가하기
        /// </summary>
        /// <param name="inventoryTypeVO"></param>
        internal void InventoryTypeInsert(InventoryTypeVO inventoryTypeVO)
        {
            SqlParameter[] InventoryTypeInsertParameters = new SqlParameter[4];
            InventoryTypeInsertParameters[0] = new SqlParameter("InventoryTypeCode", inventoryTypeVO.InventoryTypeCode);
            InventoryTypeInsertParameters[1] = new SqlParameter("ReceivingQuantity", inventoryTypeVO.ReceivingQuantity);
            InventoryTypeInsertParameters[2] = new SqlParameter("InventoryName", inventoryTypeVO.InventoryName);
            InventoryTypeInsertParameters[3] = new SqlParameter("MaterialClassification", inventoryTypeVO.MaterialClassification);
            new DBConnection().Insert("InsertInventoryType", InventoryTypeInsertParameters);
        }

        /// <summary>
        /// 재고종류 전체 출력하기(select)
        /// </summary>
        /// <returns>재고종류 데이터 리스트</returns>
        internal List<InventoryTypeVO> InventoryTypeSelect()
        {
            SqlParameter[] selectInventoryTypeParameters = null;
            SqlDataReader dr = new DBConnection().Select("SelectInventoryType", selectInventoryTypeParameters);
            List<InventoryTypeVO> inventoryTypeVOList = new List<InventoryTypeVO>();
            while (dr.Read())
            {
                InventoryTypeVO inventoryTypeVO = new InventoryTypeVO();
                inventoryTypeVO.InventoryTypeCode= dr["InventoryTypeCode"].ToString();
                inventoryTypeVO.ReceivingQuantity = Int32.Parse(dr["ReceivingQuantity"].ToString());
                inventoryTypeVO.InventoryName = dr["InventoryName"].ToString();
                inventoryTypeVO.MaterialClassification = dr["MaterialClassification"].ToString();
                inventoryTypeVOList.Add(inventoryTypeVO);
            }
            return inventoryTypeVOList;
        }
    }
}
