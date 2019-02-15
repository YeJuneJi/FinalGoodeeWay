using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class Insert_Attendance : Form
    {
        public Insert_Attendance()
        {
            InitializeComponent();
        }

        AttendanceDAO atDao = new AttendanceDAO();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //List<AttendanceVO> lst = new List<AttendanceVO>();
            var at = new AttendanceVO
            {
                Empno = txtEmpno.Text,
                Date = DateTime.Parse(dtpDate.Text),
                TotalPay = float.Parse(txtTotalpay.Text),
                TimeIn = DateTime.Parse(dtpIn.Text),
                TimeOut = DateTime.Parse(dtpOut.Text),
                OverTime = DateTime.Parse(dtpOvertime.Text),
                TotalTime = DateTime.Parse(dtpTotaltime.Text),
                Note = txtNote.Text
            };
            if (atDao.InsertAttendance(at))
            {
                MessageBox.Show("입력 성공");
            }
            else
            {
                MessageBox.Show("입력 실패");
            }
        }
    }
}
