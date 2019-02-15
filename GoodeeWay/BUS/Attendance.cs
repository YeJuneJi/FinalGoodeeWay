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
    public partial class Attendance : Form
    {

        public Attendance()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value > dateTimePicker2.Value)
            {
                var temp = dateTimePicker1.Value;
                dateTimePicker1.Value = dateTimePicker2.Value;
                dateTimePicker2.Value = temp;
            }
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new AttendanceDAO().SelectAttendance();
            dataGridView1.Columns["no"].HeaderText = "일련번호";
            dataGridView1.Columns["Empno"].HeaderText = "사원번호";
            dataGridView1.Columns["TimeIn"].HeaderText = "출근시간";
            dataGridView1.Columns["TimeOut"].HeaderText = "퇴근시간";
            dataGridView1.Columns["TotalTime"].HeaderText = "총 시간";
            dataGridView1.Columns["Date"].HeaderText = "날짜";
            dataGridView1.Columns["TotalPay"].HeaderText = "급여";
            dataGridView1.Columns["OverTime"].HeaderText = "초과시간";
            dataGridView1.Columns["Note"].HeaderText = "비고";
            dataGridView1.Columns["ename"].HeaderText = "사원명";
        }
    }
}
