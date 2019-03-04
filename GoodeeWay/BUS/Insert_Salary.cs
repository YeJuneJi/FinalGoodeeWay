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
    public partial class Insert_Salary : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        Attendance_SearchEmpno ase = new Attendance_SearchEmpno();
        SalaryDAO sal = new SalaryDAO();

        public Insert_Salary()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 사원번호 검색할 수 있게 새 폼 띄우고 닫힐때 입력
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
        /// 폼 닫힐때 선택된 사번을 폼에 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtEmpno.Text = ase.empno;
        }
        /// <summary>
        /// 다시입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpno.Text = "";
            txtSalary.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";
            txtBonus.Text = "0";
        }
        /// <summary>
        /// 급여대장 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var sv = new SalaryVO()
            {
                Empno = txtEmpno.Text,
                Salary = float.Parse(txtSalary.Text),
                Tax = float.Parse(txtTax.Text),
                Bonus = float.Parse(txtBonus.Text),
                TotalSalary = float.Parse(txtTotal.Text),
                Payday = DateTime.Parse(dtpDate.Text)
            };

            if (sal.InsertSalary(sv))
            {
                MessageBox.Show("입력 성공");
            }
            else
            {
                MessageBox.Show("입력 실패");
            }
        }
        /// <summary>
        /// 폼 여백 클릭시 총 급여를 계산해줌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insert_Salary_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                txtTotal.Text = "0";
            }
            else
            {
                txtTotal.Text = (float.Parse(txtBonus.Text) + float.Parse(txtSalary.Text) - float.Parse(txtTax.Text)).ToString();
            }
        }
        /// <summary>
        /// 마우스 드래그 가능
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

            base.OnMouseDown(e);
        }
        /// <summary>
        /// 급여 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(txtSalary.Text, @"[0-9]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("숫자만 입력가능합니다");
                txtSalary.Text = "0";
            }
            Insert_Salary_Click(null, null);
        }
        /// <summary>
        /// 세금 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(txtTax.Text, @"[0-9]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("숫자만 입력가능합니다");
                txtTax.Text = "0";
            }
            Insert_Salary_Click(null, null);
        }
        /// <summary>
        /// 보너스 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(txtBonus.Text, @"[0-9]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("숫자만 입력가능합니다");
                txtBonus.Text = "0";
            }
            Insert_Salary_Click(null, null);
        }
    }
}
