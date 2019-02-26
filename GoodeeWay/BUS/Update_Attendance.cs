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
    public partial class Update_Attendance : Form
    {
        public AttendanceVO av = new AttendanceVO();

        public Update_Attendance()
        {
            InitializeComponent();
        }

        public Update_Attendance(AttendanceVO vo) : this()
        {
            av = vo;
        }

        private void Update_Attendance_Load(object sender, EventArgs e)
        {
            txtNo.Text = av.No.ToString();
            txtName.Text = av.Name;
            txtEmpno.Text = av.Empno;
            dtpIn.Text = av.TimeIn.ToString();
            dtpOut.Text = av.TimeOut.ToString();
            dtpTotaltime.Text = av.TotalTime.ToString();
            dtpDate.Text = av.Date.ToString();
            txtTotalpay.Text = av.TotalPay.ToString();
            dtpOvertime.Text = av.OverTime.ToString();
            txtNote.Text = av.Note;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AttendanceVO vo = new AttendanceVO()
            {
                No = Int32.Parse(txtNo.Text),
                Date = DateTime.Parse(dtpDate.Text),
                TimeIn = DateTime.Parse(dtpIn.Text),
                TimeOut = DateTime.Parse(dtpOut.Text),
                OverTime = DateTime.Parse(dtpOvertime.Text),
                TotalTime = DateTime.Parse(dtpTotaltime.Text),
                TotalPay = float.Parse(txtTotalpay.Text),
                Note = txtNote.Text
            };

            if (new AttendanceDAO().UpdateAttendance(vo))
            {
                MessageBox.Show("수정 성공");
            }
            else
            {
                MessageBox.Show("수정 실패");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
