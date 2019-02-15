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
    class AttendanceDAO
    {
        public List<AttendanceVO> SelectAttendance()
        {
            List<AttendanceVO> lst = new List<AttendanceVO>();

            string sp = "proc_attendance_select";
            SqlDataReader sdr = new DBConnection().Select(sp, null);
            while (sdr.Read())
            {
                lst.Add(
                    new AttendanceVO
                    {
                        No = Int32.Parse(sdr["No"].ToString()),
                        Empno = sdr["Empno"].ToString(),
                        TimeIn = DateTime.Parse(sdr["TimeIn"].ToString()),
                        TimeOut = DateTime.Parse(sdr["TimeOut"].ToString()),
                        TotalTime = DateTime.Parse(sdr["TotalTime"].ToString()),
                        Date = DateTime.Parse(sdr["Date"].ToString()),
                        TotalPay = float.Parse(sdr["TotalPay"].ToString()),
                        OverTime = DateTime.Parse(sdr["OverTime"].ToString()),
                        Note = sdr["Note"].ToString(),
                    });
            }
            return lst;
        }

        public bool InsertAttendance(AttendanceVO ad)
        {
            string sp = "proc_attendance_insert";//저장프로시져 이름

            var dbCon = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("empno", ad.Empno);
            sqlParameters[1] = new SqlParameter("TimeIn", ad.TimeIn);
            sqlParameters[2] = new SqlParameter("TimeOut", ad.TimeOut);
            sqlParameters[3] = new SqlParameter("TotalTime", ad.TotalTime);
            sqlParameters[4] = new SqlParameter("Date", ad.Date);
            sqlParameters[5] = new SqlParameter("TotalPay", ad.TotalPay);
            sqlParameters[6] = new SqlParameter("OverTime", ad.OverTime);
            sqlParameters[7] = new SqlParameter("note", ad.Note);

            return dbCon.Insert(sp, sqlParameters);
        }

    }
}
