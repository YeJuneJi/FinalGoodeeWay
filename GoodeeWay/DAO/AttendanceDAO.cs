using GoodeeWay.BUS;
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
        List<AttendanceVO> lst = new List<AttendanceVO>();

        public List<AttendanceVO> SelectAttendance()
        {
            string sp = "proc_attendance_select";
            SqlDataReader sdr = new DBConnection().Select(sp, null);
            while (sdr.Read())
            {
                lst.Add(new AttendanceVO()
                {
                    No = Int32.Parse(sdr["No"].ToString()),
                    Name = sdr["name"].ToString(),
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
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("empno", ad.Empno);
            sqlParameters[1] = new SqlParameter("TimeIn", ad.TimeIn);
            sqlParameters[2] = new SqlParameter("TimeOut", ad.TimeOut);
            sqlParameters[3] = new SqlParameter("TotalTime", ad.TotalTime);
            sqlParameters[4] = new SqlParameter("Date", ad.Date);
            sqlParameters[5] = new SqlParameter("TotalPay", ad.TotalPay);
            sqlParameters[6] = new SqlParameter("OverTime", ad.OverTime);
            sqlParameters[7] = new SqlParameter("note", ad.Note);
            bool result = false;
            if (new DBConnection().Insert(sp, sqlParameters))
            {
                result = true;
            }
            return result;
        }

        public List<AttendanceVO> Select2Attendance(DateTime date1, DateTime date2)
        {
            string sp = "proc_attendance_select2";//저장프로시져 이름
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("date1", date1);
            sqlParameters[1] = new SqlParameter("date2", date2);

            SqlDataReader sdr = new DBConnection().Select(sp, sqlParameters);
            while (sdr.Read())
            {
                lst.Add(new AttendanceVO()
                {
                    No = Int32.Parse(sdr["No"].ToString()),
                    Name = sdr["name"].ToString(),
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

        public bool DeleteAttendance(int no)
        {
            string sp = "proc_attendance_delete";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("no", no);
            bool result = false;
            if (new DBConnection().Delete(sp, sqlParameters))
            {
                result = true;
            }
            return result;
        }

        public bool UpdateAttendance(AttendanceVO ad)
        {
            string sp = "proc_attendance_update";//저장프로시져 이름
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("no", ad.No);
            sqlParameters[1] = new SqlParameter("TimeIn", ad.TimeIn);
            sqlParameters[2] = new SqlParameter("TimeOut", ad.TimeOut);
            sqlParameters[3] = new SqlParameter("TotalTime", ad.TotalTime);
            sqlParameters[4] = new SqlParameter("Date", ad.Date);
            sqlParameters[5] = new SqlParameter("TotalPay", ad.TotalPay);
            sqlParameters[6] = new SqlParameter("OverTime", ad.OverTime);
            sqlParameters[7] = new SqlParameter("Note", ad.Note);
            bool result = true;
            try
            {
                new DBConnection().Update(sp, sqlParameters);
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}