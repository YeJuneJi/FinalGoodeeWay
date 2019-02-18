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

        AttendanceDAO atd = new AttendanceDAO();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Attendance_SearchEmpno ase = new Attendance_SearchEmpno();
            ase.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var at = new AttendanceVO()
            {
                Empno = txtEmpno.Text,
                Date = DateTime.Parse(dtpDate.Text),
                TotalPay = float.Parse(txtTotalpay.Text),
                TimeIn = DateTime.Parse(dtpIn.Text),
                TimeOut = DateTime.Parse(dtpOut.Text),
                OverTime = DateTime.Parse(dtpOvertime.Text),
                TotalTime = DateTime.Parse(dtpTotaltime.Text),
                Note = txtNote.Text,
            };
            if (atd.InsertAttendance(at))
            {
                MessageBox.Show("입력 성공");
            }
            else
            {
                MessageBox.Show("입력 실패");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpno.Text = "";
            txtTotalpay.Text = "";
            txtNote.Text = "";
        }

        private void Insert_Attendance_Load(object sender, EventArgs e)
        {

        }
    }
}
