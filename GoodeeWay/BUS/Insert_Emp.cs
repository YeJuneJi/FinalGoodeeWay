using GoodeeWay.DAO;
using GoodeeWay.DB;
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
    public partial class Insert_Emp : Form
    {
        // 드래그 가능하게 하는 코드
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        EmpDAO ed = new EmpDAO();

        public Insert_Emp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 사원 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) // insert
        {
            if (check())
            {
                var emp = new EmpVO()
                {
                    Name = txtName.Text,
                    Job = cbJob.Text,
                    Pay = float.Parse(txtSalary.Text),
                    Department = txtDepartment.Text,
                    Mobile = txtPhone.Text,
                    JoinDate = DateTime.Parse(dtpJoin.Text),
                    BankAccountNo = txtBankAccountNo.Text,
                    Bank = cbBank.Text,
                    Email = txtEmail.Text,
                    Note = txtNote.Text
                };

                if (ed.InsertBoard(emp))
                {
                    MessageBox.Show("저장 성공");
                }
                else
                {
                    MessageBox.Show("저장 실패");
                }
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
        /// 급여란 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(this.txtSalary.Text, @"[0-9]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("숫자만 입력가능합니다");
                txtSalary.Text = "";
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
        /// 이메일 형식 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!(txtEmail.Text == ""))
            {
                bool emailCheck = Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                if (!(emailCheck))
                {
                    MessageBox.Show("올바르지 않은 이메일 주소입니다");
                    txtEmail.Text = "";
                }
            }
        }
        /// <summary>
        /// 다시 입력하기 위한 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            cbBank.Text = "";
            txtBankAccountNo.Text = "";
            txtDepartment.Text = "";
            txtEmail.Text = "";
            cbJob.Text = "";
            txtNote.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            dtpJoin.Text = "";
        }
        /// <summary>
        /// 창 상단 마우스로 드래그가 가능하게 하는 메소드
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
        /// 폰번호 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(txtPhone.Text, @"[0-9]|[-]", "");
            if (txtPhone.Text.Length > 13 || str.Length > 0)
            {
                txtPhone.Text = "";
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
                txtBankAccountNo.Text = "";
            }
        }
        /// <summary>
        /// 부서명 유효성검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDepartment_Leave(object sender, EventArgs e)
        {
            string str = Regex.Replace(this.txtDepartment.Text, @"[가-힣]+", "");
            if (str.Length > 0)
            {
                MessageBox.Show("부서명은 한글만 입력가능합니다");
                txtDepartment.Text = "";
                txtDepartment.Focus();
            }
        }
    }
}
