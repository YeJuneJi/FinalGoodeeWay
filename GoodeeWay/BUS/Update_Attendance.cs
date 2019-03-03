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
    public partial class Update_Attendance : Form
    {
        //드래그 가능하게 해주는 코드
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        public AttendanceVO av = new AttendanceVO();

        public Update_Attendance()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 수정할 데이터를 근태관리 클래스에서 가져옴
        /// </summary>
        /// <param name="vo"></param>
        public Update_Attendance(AttendanceVO vo) : this()
        {
            av = vo;
        }
        /// <summary>
        /// 폼이 로드될때 수정하려고했던 내용 보여줌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 수정하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 마우스 드래그 가능하게 하는 메소드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_MouseDown(object sender, MouseEventArgs e)
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
        /// 총 급여 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalpay_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(txtTotalpay.Text, @"[0-9]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("숫자만 입력가능합니다");
                txtTotalpay.Text = av.TotalPay.ToString();
            }
        }
    }
}
