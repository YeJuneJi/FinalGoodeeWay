﻿using System;
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
        /// <summary>
        /// 모든 비품리스트들을 불러온다
        /// </summary>
        /// <returns></returns>
        public List<EquipmentVO> AllequipmentVOsList()
        {
            List<EquipmentVO> equipmentLst = new List<EquipmentVO>();

            DBConnection dBConnection = new DBConnection();
            string procedureName = "dbo.SerchEquipment";
            try
            {
                SqlDataReader dataReader = dBConnection.Select(procedureName, null);

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
            catch (SqlException)
            {

                throw;
            }
        }

        /// <summary>
        /// 비품 데이터 삭제
        /// </summary>
        /// <param name="equipment"></param>
        /// <returns></returns>
        public bool DeleteEquipment(EquipmentVO equipment)
        {
            bool isComplete = false;
            string procedureName = "DeleteEquipment_PROC";

            var dbCon = new DBConnection();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("EQUCode", equipment.EQUCode);


            try
            {
                isComplete = dbCon.Delete(procedureName, sqlParameters);
            }
            catch (SqlException)
            {

                throw;
            }
            return isComplete;
        }

        /// <summary>
        /// 비품 데이터 추가
        /// </summary>
        /// <param name="equipment"></param>
        /// <returns></returns>
        public bool InsertEquipment(EquipmentVO equipment)
        {
            string procedureName = "InsertEquipment_PROC";//저장프로시져 이름
            bool isComplete = false;
            var dbCon = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("detailName", equipment.DetailName);
            sqlParameters[1] = new SqlParameter("location", equipment.Location);
            sqlParameters[2] = new SqlParameter("purchasePrice", equipment.PurchasePrice);
            sqlParameters[3] = new SqlParameter("purchaseDate", equipment.PurchaseDate);
            sqlParameters[4] = new SqlParameter("note", equipment.Note);
            isComplete = dbCon.Insert(procedureName, sqlParameters);

            return isComplete;
        }

        /// <summary>
        /// 비품 데이터 찾기
        /// </summary>
        /// <param name="equipment"></param>
        /// <param name="anotherDate"></param>
        /// <returns></returns>
        public List<EquipmentVO> SelectSearch(EquipmentVO equipment, DateTime anotherDate)
        {
            List<EquipmentVO> equipmentLst = new List<EquipmentVO>();

            DBConnection dBConnection = new DBConnection();
            string procedureName = "dbo.SelectDitalsByEquipment_PROC";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("detailName", equipment.DetailName);
            sqlParameters[1] = new SqlParameter("location", equipment.Location);
            sqlParameters[2] = new SqlParameter("state", equipment.State);
            sqlParameters[3] = new SqlParameter("purchasePrice", equipment.PurchasePrice);
            sqlParameters[4] = new SqlParameter("purchaseDate", equipment.PurchaseDate);
            sqlParameters[5] = new SqlParameter("anotherDate", anotherDate);

            try
            {
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
            }
            catch (SqlException)
            {
                throw;
            }
            return equipmentLst;
        }

        /// <summary>
        /// 비품 수정(업데이트)
        /// </summary>
        /// <param name="equipment"></param>
        /// <returns></returns>
        public bool UpdateEquipment(EquipmentVO equipment)
        {
            DBConnection dBConnection = new DBConnection();
            string procedureName = "dbo.UpdateEquipment_PROC";

            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("EQUCode", equipment.EQUCode);
            sqlParameters[1] = new SqlParameter("detailName", equipment.DetailName);
            sqlParameters[2] = new SqlParameter("location", equipment.Location);
            sqlParameters[3] = new SqlParameter("state", equipment.State);
            sqlParameters[4] = new SqlParameter("purchasePrice", equipment.PurchasePrice);
            sqlParameters[5] = new SqlParameter("purchaseDate", equipment.PurchaseDate);

            try
            {
                if (dBConnection.Update(procedureName, sqlParameters) != 1)
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
           
            return true;
        }

        /// <summary>
        /// 날짜 별로 구입날짜, 구매 가격 찾기
        /// </summary>
        /// <param name="startDate">시작 일</param>
        /// <param name="endDate">종료 일</param>
        /// <returns></returns>
        public List<EquipmentVO> GroupingDateEquipment(DateTime startDate, DateTime endDate)
        {
            List<EquipmentVO> equipmentLst = new List<EquipmentVO>();
            DBConnection dBConnection = new DBConnection();
            string procedureName = "dbo.GroupingDateEquipment_PROC";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("startDate", startDate);
            sqlParameters[1] = new SqlParameter("endDate", endDate);

            try
            {
                SqlDataReader dataReader = dBConnection.Select(procedureName, sqlParameters);

                while (dataReader.Read())
                {
                    EquipmentVO equipmentVO = new EquipmentVO()
                    {
                        PurchasePrice = float.Parse(dataReader["purchasePrice"].ToString()),
                        PurchaseDate = DateTime.Parse(dataReader["purchaseDate"].ToString()),
                    };
                    equipmentLst.Add(equipmentVO);
                }
                return equipmentLst;
            }
            catch (SqlException)
            {

                throw;
            }

        }

        /// <summary>
        /// 날짜 별로 비품데이터 찾기
        /// </summary>
        /// <param name="startDate">시작 일</param>
        /// <param name="endDate">종료 일</param>
        /// <returns></returns>
        public List<EquipmentVO> EquipmentByDate(DateTime startDate, DateTime endDate)
        {
            List<EquipmentVO> equipmentLst = new List<EquipmentVO>();
            DBConnection dBConnection = new DBConnection();
            string procedureName = "dbo.EquipmentBYDate_PROC";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("startDate", startDate);
            sqlParameters[1] = new SqlParameter("endDate", endDate);

            try
            {
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
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
