using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class Insert_Attendance : Form
    {
        // 상단 창 드래그 가능하게 함
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;
        
        public Insert_Attendance()
        {
            InitializeComponent();
        }

        AttendanceDAO atd = new AttendanceDAO();
        Attendance_SearchEmpno ase = new Attendance_SearchEmpno();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 사원번호 검색시 새 폼 띄워서 보여주기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ase = new Attendance_SearchEmpno();
            ase.FormClosed += new FormClosedEventHandler(aseForm_FormClosed);
            ase.Show();
        }
        /// <summary>
        /// 폼 닫을때 선택된 사번이 폼에 입력됨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtEmpno.Text = ase.empno;
        }
        /// <summary>
        /// 근태기록 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //dtpTotaltime.Value = TimeSpan.FromHours.dtpTotaltime;

            var at = new AttendanceVO()
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

            if (atd.InsertAttendance(at))
            {
                MessageBox.Show("입력 성공");
            }
            else
            {
                MessageBox.Show("입력 실패");
            }
        }
        /// <summary>
        /// 다시 입력할 수 있게 텍스트 비움
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpno.Text = "";
            txtTotalpay.Text = "";
            txtNote.Text = "";
        }
        /// <summary>
        /// 마우스 드래그 가능하게 하는 메소드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insert_Attendance_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 다른 컨트롤에 묶여있을 수 있을 수 있으므로 마우스캡쳐 해제
                ReleaseCapture();

                // 타이틀 바의 다운 이벤트처럼 보냄
                SendMessage(this.Handle, WM_NLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /// <summary>
        /// 급여 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalpay_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(this.txtTotalpay.Text, @"[0-9]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("숫자만 입력가능합니다");
                txtTotalpay.Text = "";
            }
        }
    }
}
