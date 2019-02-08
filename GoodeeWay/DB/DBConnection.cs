using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.DB
{
    class DBConnection
    {
        SqlConnection con;
         
        public DBConnection()
        {
             con = new SqlConnection(new Properties.Settings().connectionStr);
            
        }
        /// <summary>
        /// 싱글톤 패턴으로 만들어 Open 객체를 하나만 만들기 위해 만들어진 메서드
        /// </summary>
        /// <returns>연결한 SqlConnection 객체</returns>
        private SqlConnection OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed || con.State == System.Data.ConnectionState.Broken)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException)
                {

                    throw;//예외를 처리하지않고 그대로 나를 호출한 곳으로 넘김
                }
            }
            return con;
        }

        /// <summary>
        /// 트렌젝션을 시작하는 메서드
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <returns>sqlConnection에 대한 sqlTransaction</returns>
        private SqlTransaction GetTransaction(SqlConnection sqlConnection)
        {
            return sqlConnection.BeginTransaction();
        }

        /// <summary>
        /// command 객체를 만들어주는 메서드
        /// </summary>
        /// <param name="sqlCon"></param>
        /// <param name="procedure">사용하는 프로시져 명</param>
        /// <param name="transaction"></param>
        /// <param name="sqlParameters">null값 사용가능</param>
        /// <returns> SqlCommand 타입 객체</returns>
        private SqlCommand GetCommand(SqlConnection sqlCon, string procedure, SqlTransaction transaction, SqlParameter[] sqlParameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = procedure;
            cmd.Transaction = transaction;
            if (sqlParameters !=null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }

            return cmd;
        }

        /// <summary>
        /// select하기 위한 메서드
        /// </summary>
        /// <param name="procedure">사용하는 프로시져 명</param>
        /// <param name="parameters"></param>
        /// <returns>SqlDataReader 타입객체</returns>
        public SqlDataReader Select(string procedure , SqlParameter[] parameters)
        {
            SqlConnection sqlConnection = OpenConnection();
            SqlTransaction transaction = GetTransaction(sqlConnection);
            SqlCommand sqlCommand = GetCommand(sqlConnection,procedure,transaction,parameters);

            try
            {
                return sqlCommand.ExecuteReader();
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Update 하기 위한 메서드
        /// </summary>
        /// <param name="procedure">사용하는 프로시져 명</param>
        /// <param name="parameters"></param>
        /// <returns> Update에 의해 영향 받은 Row들의 수 </returns>
        public int Update(string procedure, SqlParameter[] parameters)
        {

            SqlConnection sqlConnection = OpenConnection();
            SqlTransaction transaction = GetTransaction(sqlConnection);

            using (transaction)
            {
                SqlCommand sqlCommand = GetCommand(sqlConnection, procedure, transaction, parameters);

                try
                {
                   int updateRow = sqlCommand.ExecuteNonQuery();
                    transaction.Commit();
                    return updateRow;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        /// <summary>
        ///  테이블에 insert시키는 메서드
        /// </summary>
        /// <param name="procedure">사용하는 프로시져 명</param>
        /// <param name="parameters"></param>
        /// <returns>데이터 삽입 성공여부 반환</returns>
        public bool Insert(string procedure, SqlParameter[] parameters)
        {
            bool result = false;
            SqlConnection sqlConnection = OpenConnection();
            SqlTransaction transaction = GetTransaction(sqlConnection);

            using (transaction)
            {
                SqlCommand sqlCommand = GetCommand(sqlConnection, procedure, transaction, parameters);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            return result;
        }
        /// <summary>
        /// Delete 사용 메서드
        /// </summary>
        /// <param name="procedure">사용하는 프로시져 명</param>
        /// <param name="parameters"></param>
        /// <returns>Delete 성공 여부</returns>
        public bool Delete(string procedure, SqlParameter[] parameters)
        {
            bool result = false;
            SqlConnection sqlConnection = OpenConnection();
            SqlTransaction transaction = GetTransaction(sqlConnection);

            using (transaction)
            {
                SqlCommand sqlCommand = GetCommand(sqlConnection, procedure, transaction, parameters);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            return result;
        }
    }
}
