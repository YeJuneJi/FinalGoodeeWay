using GoodeeWay.DAO;
using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class Attendance : Form
    {
        AttendanceDAO ad = new AttendanceDAO();

        public Attendance()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";

            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                var temp = dateTimePicker1.Value;
                dateTimePicker1.Value = dateTimePicker2.Value;
                dateTimePicker2.Value = temp;
            }

            ad = new AttendanceDAO();
            dataGridView1.DataSource = ad.Select2Attendance(dateTimePicker1.Value, dateTimePicker2.Value);
            ColumnSetKorean();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            List<AttendanceVO> lst = new AttendanceDAO().SelectAttendance();
            dataGridView1.DataSource = lst;
            ColumnSetKorean();
        }

        private void ColumnSetKorean()
        {
            dataGridView1.Columns["no"].HeaderText = "일련번호";
            dataGridView1.Columns["Empno"].HeaderText = "사원번호";
            dataGridView1.Columns["TimeIn"].HeaderText = "출근시간";
            dataGridView1.Columns["TimeOut"].HeaderText = "퇴근시간";
            dataGridView1.Columns["TotalTime"].HeaderText = "총 시간";
            dataGridView1.Columns["Date"].HeaderText = "날짜";
            dataGridView1.Columns["TotalPay"].HeaderText = "급여";
            dataGridView1.Columns["OverTime"].HeaderText = "초과시간";
            dataGridView1.Columns["Note"].HeaderText = "비고";
            dataGridView1.Columns["name"].HeaderText = "사원명";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert_Attendance ia = new Insert_Attendance();
            ia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Attendance_Load(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("일련번호 " + dataGridView1.SelectedCells[0].Value + "번 기록을 정말로 삭제하시겠습니까?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ad.DeleteAttendance(Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                    MessageBox.Show("삭제 성공");
                }
                catch (Exception)
                {
                    MessageBox.Show("삭제 실패");
                }
            }
            else
            {
                MessageBox.Show("취소되었습니다");
            }
            Attendance_Load(null, null);
        }
    }
}
