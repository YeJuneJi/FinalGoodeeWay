using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodeeWay.DB;
using GoodeeWay.VO;

namespace GoodeeWay.DAO
{/// <summary>
/// BUS 부분과 DB부분을 이어주는 클래스
/// </summary>
    class EquipmentDAO : IEquipmentDAO
    {
        
        public List<EquipmentVO> AllequipmentVOsList()
        {
            List<EquipmentVO> equipmentLst = new List<EquipmentVO>();

            DBConnection dBConnection = new DBConnection();
            string procedureName = "dbo.SerchEquipment";
            SqlDataReader dataReader =  dBConnection.Select(procedureName, null);

            while (dataReader.Read())
            {
                EquipmentVO equipmentVO = new EquipmentVO()
                {
                    EQUCode = dataReader["EQUCode"].ToString(),
                    DetailName = dataReader["detailName"].ToString(),
                    Location = dataReader["location"].ToString(),
                    State = dataReader["state"].ToString(),
                    PurchasePrice = float.Parse(dataReader["purchasePrice"].ToString()),
                    PurchaseDate =DateTime.Parse(dataReader["purchaseDate"].ToString()),
                    Note = dataReader["note"].ToString()
                };
                equipmentLst.Add(equipmentVO);
            }
            return equipmentLst;
        }

        public bool DeleteEquipment(EquipmentVO equipment)
        {
            string procedureName = "DeleteEquipment_PROC";

            var dbCon = new DBConnection();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("EQUCode", equipment.EQUCode);
            return dbCon.Delete(procedureName, sqlParameters);
        }

        public bool InsertEquipment(EquipmentVO equipment)
        {
            string procedureName = "InsertEquipment_PROC";//저장프로시져 이름

            var dbCon = new DBConnection();
           
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("detailName", equipment.DetailName);
            sqlParameters[1] = new SqlParameter("location", equipment.Location);
            sqlParameters[2] = new SqlParameter("purchasePrice", equipment.PurchasePrice);
            sqlParameters[3] = new SqlParameter("purchaseDate", equipment.PurchaseDate);
            sqlParameters[4] = new SqlParameter("note", equipment.Note);
            
            return dbCon.Insert(procedureName , sqlParameters);
        }

        public List<EquipmentVO> SelectSearch(EquipmentVO equipment, DateTime? anotherDate)
        {
            List<EquipmentVO> equipmentLst = new List<EquipmentVO>();

            DBConnection dBConnection = new DBConnection();
            string procedureName = "dbo.SelectDitalsByEquipment_PROC";
            //equipment.State = "사용중";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("detailName", equipment.DetailName);
            sqlParameters[1] = new SqlParameter("location", equipment.Location);
            //sqlParameters[2] = new SqlParameter("state", equipment.State);
            sqlParameters[2] = new SqlParameter("purchasePrice", equipment.PurchasePrice);
            sqlParameters[3] = new SqlParameter("purchaseDate", equipment.PurchaseDate);
            sqlParameters[4] = new SqlParameter("anotherDate", anotherDate);
            SqlDataReader dataReader = dBConnection.Select(procedureName, sqlParameters);

            while (dataReader.Read())
            {
                EquipmentVO equipmentVO = new EquipmentVO()
                {
                    EQUCode = dataReader["EQUCode"].ToString(),
                    DetailName = dataReader["detailName"].ToString(),
                    Location = dataReader["location"].ToString(),
                    State = dataReader["state"].ToString(),
                    PurchasePrice = float.Parse(dataReader["purchasePrice"].ToString()),
                    PurchaseDate = DateTime.Parse(dataReader["purchaseDate"].ToString()),
                    Note = dataReader["note"].ToString()
                };
                equipmentLst.Add(equipmentVO);
            }
            return equipmentLst;
        }
    }
}
