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

        internal DataTable selectOrderDetailsAdd(DataTable orderDetailsListDataTable)
        {
            SqlParameter[] sqlParameters = null;
            SqlDataReader dr = new DBConnection().Select("SelectInventoryTypeNeed", sqlParameters);//재고종류에 있는 모든 내역을 가져옴
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("재고명", typeof(string));
            dataTable.Columns.Add("수량", typeof(int));
            dataTable.Columns.Add("재고종류코드", typeof(string));
            
            while (dr.Read())
            {
                DataRow dataRow = dataTable.NewRow();

                dataRow["재고종류코드"] = dr["InventoryTypeCode"].ToString();
                dataRow["수량"] = 0;
                dataRow["재고명"] = dr["InventoryName"].ToString();
                dataTable.Rows.Add(dataRow);
            }

            for (int i = 0; i < orderDetailsListDataTable.Rows.Count; i++)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    if(orderDetailsListDataTable.Rows[i]["재고종류코드"].ToString()==item["재고종류코드"].ToString() && orderDetailsListDataTable.Rows[i]["발주번호"].ToString().Substring(0,2)=="OR")
                    {
                        dataTable.Rows.Remove(item);
                        break;
                    }
                }
            }
            return dataTable;
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
            dataTable.Columns.Add("재고종류코드",typeof(string));
            dataTable.Columns.Add("재고명", typeof(string));
            dataTable.Columns.Add("입고정량",typeof(int));
            dataTable.Columns.Add("최소재고",typeof(int));
            dataTable.Columns.Add("재고합계",typeof(int));
            dataTable.Columns.Add("재고총량",typeof(int));
            dataTable.Columns.Add("재료구분",typeof(string));
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
                dataRow["입고정량"] = Int32.Parse(dr["ReceivingQuantity"].ToString());
                dataRow["최소재고"] = Int32.Parse(dr["MinimumQuantity"].ToString());
                dataRow["재고합계"] = Int32.Parse(dr["SumReceivingQuantuty"].ToString());
                dataRow["재고총량"] = Int32.Parse(dr["TotalReceivingQuantuty"].ToString());
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
            SqlParameter[] updateInventoryTypeParameter = new SqlParameter[5];
            updateInventoryTypeParameter[0] = new SqlParameter("InventoryTypeCode", inventoryTypeVO.InventoryTypeCode);
            updateInventoryTypeParameter[1] = new SqlParameter("ReceivingQuantity", inventoryTypeVO.ReceivingQuantity);
            updateInventoryTypeParameter[2] = new SqlParameter("InventoryName", inventoryTypeVO.InventoryName);
            updateInventoryTypeParameter[3] = new SqlParameter("MaterialClassification", inventoryTypeVO.MaterialClassification);
            updateInventoryTypeParameter[4] = new SqlParameter("MinimumQuantity", inventoryTypeVO.MinimumQuantity);
            new DBConnection().Update("UpdateInventoryType", updateInventoryTypeParameter);

        }

        internal DataTable InventoryTypeNeedSelect()
        { 
            SqlParameter[] sqlParameters = null;
            SqlDataReader dr = new DBConnection().Select("SelectInventoryTypeNeed", sqlParameters);//재고종류에 있는 모든 내역을 가져옴
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("재고명", typeof(string));
            dataTable.Columns.Add("현재수량", typeof(string));
            dataTable.Columns.Add("필요수량", typeof(string));
            dataTable.Columns.Add("발주종류", typeof(string));
            dataTable.Columns.Add("재고종류코드", typeof(string));

            while (dr.Read())
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["재고종류코드"] = dr["InventoryTypeCode"].ToString();
                dataRow["재고명"] = dr["InventoryName"].ToString();
                dataRow["현재수량"] = Int32.Parse(dr["SumReceivingQuantuty"].ToString());
                if (Int32.Parse(dr["NeedQuantity"].ToString())<0)
                {
                    dataRow["필요수량"] = 0;
                }
                else
                {
                    dataRow["필요수량"] = Int32.Parse(dr["NeedQuantity"].ToString());
                }
                
                dataRow["발주종류"] = "주문";

                dataTable.Rows.Add(dataRow);
            }

            SqlParameter[] RDITsqlParameters = null;
            SqlDataReader dr2 = new DBConnection().Select("SelectReceivingDetailsInventorytype", RDITsqlParameters);//입고내역에서 반품여부에 '정상입'이 아닌 경우만 가져옴
            while (dr2.Read())
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["재고종류코드"] = dr2["InventoryTypeCode"].ToString();
                dataRow["재고명"] = dr2["InventoryName"].ToString();
                dataRow["현재수량"] = Int32.Parse(dr2["SumReceivingQuantuty"].ToString());
                dataRow["필요수량"] = Int32.Parse(dr2["NeedQuantity"].ToString());
                if (dr2["ReturnStatus"].ToString()=="반품"){dataRow["발주종류"] = "반품"+dr2["ReceivingDetailsID"].ToString();}
                else if (dr2["ReturnStatus"].ToString() == "교환") { dataRow["발주종류"] = "교환"+dr2["ReceivingDetailsID"].ToString(); }
            
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }
    }
}
