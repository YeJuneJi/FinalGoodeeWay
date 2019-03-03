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
    public partial class Update_Salary : Form
    {
        // 마우스 드래그 가능하게 함
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        public SalaryVO sv = new SalaryVO();

        public Update_Salary()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 수정할 데이터를 급여 메인 클래스에서 가져옴
        /// </summary>
        /// <param name="vo"></param>
        public Update_Salary(SalaryVO vo) : this()
        {
            sv = vo;
        }
        /// <summary>
        /// 폼이 로드될때 수정하려고했던 내용 보여줌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Salary_Load(object sender, EventArgs e)
        {
            txtNo.Text = sv.No;
            txtEmpno.Text = sv.Empno;
            txtName.Text = sv.Name;
            txtSalary.Text = sv.Salary.ToString();
            txtTax.Text = sv.Tax.ToString();
            txtBonus.Text = sv.Bonus.ToString();
            txtTotal.Text = sv.TotalSalary.ToString();
            dtpDate.Text = sv.Payday.ToString();
        }
        /// <summary>
        /// 수정하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var lst = new SalaryVO()
            {
                No = txtNo.Text,
                Salary = float.Parse(txtSalary.Text),
                Tax = float.Parse(txtTax.Text),
                Bonus = float.Parse(txtBonus.Text),
                TotalSalary = float.Parse(txtTotal.Text),
                Payday = DateTime.Parse(dtpDate.Text)
            };

            if (new SalaryDAO().UpdateSalary(lst))
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
                txtSalary.Text = sv.Salary.ToString();
            }
            changeTotal();
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
                txtTax.Text = sv.Tax.ToString();
            }
            changeTotal();
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
                txtBonus.Text = sv.Bonus.ToString();
            }
            changeTotal();
        }
        /// <summary>
        /// 보너스와 급여를 더하고 세금을 뺀 총 급여
        /// </summary>
        private void changeTotal()
        {
            txtTotal.Text = (float.Parse(txtBonus.Text) + float.Parse(txtSalary.Text) - float.Parse(txtTax.Text)).ToString();
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
    }
}
