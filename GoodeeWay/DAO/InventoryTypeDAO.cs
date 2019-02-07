using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Data;
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
        internal DataTable InventoryTypeSelect()
        {
            SqlParameter[] selectInventoryTypeParameters = null;
            SqlDataReader dr = new DBConnection().Select("SelectInventoryType", selectInventoryTypeParameters);
            List<InventoryTypeVO> inventoryTypeVOList = new List<InventoryTypeVO>();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("재고종류코드");
            dataTable.Columns.Add("재고명");
            dataTable.Columns.Add("입고정량");
            dataTable.Columns.Add("재고합계");
            dataTable.Columns.Add("재고총량");
            dataTable.Columns.Add("재료구분");
            while (dr.Read())
            {
                //InventoryTypeVO inventoryTypeVO = new InventoryTypeVO();
                //inventoryTypeVO.InventoryTypeCode= dr["InventoryTypeCode"].ToString();
                //inventoryTypeVO.ReceivingQuantity = Int32.Parse(dr["ReceivingQuantity"].ToString());
                //inventoryTypeVO.InventoryName = dr["InventoryName"].ToString();
                //inventoryTypeVO.MaterialClassification = dr["MaterialClassification"].ToString();
                //inventoryTypeVOList.Add(inventoryTypeVO);
                
                DataRow dataRow = dataTable.NewRow();
                dataRow["재고종류코드"]=dr["InventoryTypeCode"].ToString();
                dataRow["재고명"] = dr["InventoryName"].ToString();
                dataRow["입고정량"] = dr["ReceivingQuantity"].ToString();
                dataRow["재고합계"] =dr["SumReceivingQuantuty"].ToString();
                dataRow["재고총량"] =dr["TotalReceivingQuantuty"].ToString();
                dataRow["재료구분"] = dr["MaterialClassification"].ToString();
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        internal void InventoryTypeDelete(string inventoryTypeCode)
        {
            SqlParameter[] deleteInventoryType = new SqlParameter[1];
            deleteInventoryType[0] = new SqlParameter("InventoryTypeCode", inventoryTypeCode);
            try
            {
                new DBConnection().Delete("InventoryTypeDelete", deleteInventoryType);
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void InventoryTypeUpdate(InventoryTypeVO inventoryTypeVO)
        {
            SqlParameter[] updateInventoryTypeParameter = new SqlParameter[4];
            updateInventoryTypeParameter[0] = new SqlParameter("InventoryTypeCode", inventoryTypeVO.InventoryTypeCode);
            updateInventoryTypeParameter[1] = new SqlParameter("ReceivingQuantity", inventoryTypeVO.ReceivingQuantity);
            updateInventoryTypeParameter[2] = new SqlParameter("InventoryName", inventoryTypeVO.InventoryName);
            updateInventoryTypeParameter[3] = new SqlParameter("MaterialClassification", inventoryTypeVO.MaterialClassification);
            new DBConnection().Update("UpdateInventoryType", updateInventoryTypeParameter);

        }
    }
}
