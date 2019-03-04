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
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class Update_Emp : Form
    {
        //드래그 가능하게 해주는 코드
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        public EmpVO bo = new EmpVO();

        public Update_Emp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 수정할 데이터를 인사관리 클래스에서 가져옴
        /// </summary>
        /// <param name="vo"></param>
        public Update_Emp(EmpVO vo) : this()
        {
            bo = vo;
        }
        /// <summary>
        /// 폼이 로드되면 수정하려는 데이터 보여줌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Emp_Load(object sender, EventArgs e)
        {
            txtNum.Text = bo.Empno;
            txtName.Text = bo.Name;
            cbJob.Text = bo.Job;
            txtSalary.Text = bo.Pay.ToString();
            txtDepartment.Text = bo.Department;
            txtPhone.Text = bo.Mobile;
            dtpJoin.Text = bo.JoinDate.ToString();
            dtpLeave.Text = bo.LeaveDate.ToString();
            txtBankAccountNo.Text = bo.BankAccountNo;
            cbBank.Text = bo.Bank;
            txtEmail.Text = bo.Email;
            txtNote.Text = bo.Note;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 수정하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(dtpLeave.Text == "1900-01-01") && dtpLeave.Value < dtpJoin.Value) // 퇴사일이 입사일보다 빠르면 서로 교체
            {
                DateTime temp = dtpLeave.Value;
                dtpLeave.Value = dtpJoin.Value;
                dtpJoin.Value = temp;
                MessageBox.Show("퇴사일이 입사일보다 빨라 치환되었습니다.");
            }
            
                EmpVO vo = new EmpVO()
                {
                    Empno = txtNum.Text,
                    Job = cbJob.Text,
                    Pay = float.Parse(txtSalary.Text),
                    Name = txtName.Text,
                    Department = txtDepartment.Text,
                    Mobile = txtPhone.Text,
                    JoinDate = DateTime.Parse(dtpJoin.Text),
                    LeaveDate = DateTime.Parse(dtpLeave.Text),
                    BankAccountNo = txtBankAccountNo.Text,
                    Bank = cbBank.Text,
                    Email = txtEmail.Text,
                    Note = txtNote.Text
                };

                if (new EmpDAO().Update(vo))
                {
                    MessageBox.Show("수정 성공");
                }
                else
                {
                    MessageBox.Show("수정 실패");
                }
        }
        /// <summary>
        /// 필수입력란 bool로 확인
        /// </summary>
        /// <returns>결과값</returns>
        private bool check()
        {
            bool result = false;

            if (!(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSalary.Text) || string.IsNullOrEmpty(txtBankAccountNo.Text) || string.IsNullOrEmpty(cbBank.Text)))
            {
                result = true;
            }
            else
            {
                MessageBox.Show("필수입력란을 모두 입력해주세요");
            }
            return result;
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
        /// 계좌번호 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBankAccountNo_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(txtBankAccountNo.Text, @"[0-9]|[-]", "");
            if (str.Length > 0)
            {
                txtBankAccountNo.Text = bo.BankAccountNo;
            }
        }
        /// <summary>
        /// 급여 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(this.txtSalary.Text, @"[0-9]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("숫자만 입력가능합니다");
                txtSalary.Text = bo.Pay.ToString();
            }
        }
        /// <summary>
        /// 폰번호 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(txtPhone.Text, @"[0-9]|[-]", "");
            if (txtPhone.Text.Length > 13 || str.Length > 0)
            {
                txtPhone.Text = bo.Mobile;
            }
        }
        /// <summary>
        /// 부서명 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDepartment_Leave(object sender, EventArgs e)
        {
            string str = Regex.Replace(this.txtDepartment.Text, @"[가-힣]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("부서명은 한글만 입력가능합니다");
                txtDepartment.Text = bo.Department;
                txtDepartment.Focus();
            }
        }
        /// <summary>
        /// 직급 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbJob_Leave(object sender, EventArgs e)
        {
            if (!(cbJob.Text == "알바" || cbJob.Text == "매니저" || cbJob.Text == "점장" || cbJob.Text == ""))
            {
                MessageBox.Show(cbJob.Text + "는 존재하지 않는 직급입니다");
                cbJob.Text = "";
            }
        }
        /// <summary>
        /// 은행명 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBank_Leave(object sender, EventArgs e)
        {
            bool b = true;

            for (int i = 0; i < cbBank.Items.Count; i++)
            {
                if ((cbBank.Items[i].ToString() == cbBank.Text)) // 콤보에 있으면
                {
                    b = false;
                }
            }

            if (b)
            {
                MessageBox.Show(cbBank.Text + "는 존재하지 않는 은행명입니다");
                cbBank.Text = "";
            }
        }
    }
}
