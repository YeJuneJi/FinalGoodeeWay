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

        public Update_Emp(EmpVO vo) : this()
        {
            bo = vo;
        }

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

        private void txtBankAccountNo_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(txtBankAccountNo.Text, @"[0-9]|[-]", "");
            if (str.Length > 0)
            {
                txtBankAccountNo.Text = bo.BankAccountNo;
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(this.txtSalary.Text, @"[0-9]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("숫자만 입력가능합니다");
                txtSalary.Text = bo.Pay.ToString();
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(txtPhone.Text, @"[0-9]|[-]", "");
            if (txtPhone.Text.Length > 13 || str.Length > 0)
            {
                txtPhone.Text = bo.Mobile;
            }
        }

        private void txtDepartment_Leave(object sender, EventArgs e)
        {
            string str = Regex.Replace(this.txtDepartment.Text, @"[가-힣]+", "");
            if (str.Length > 0)
            {
                MessageBox.Show("부서명은 한글만 입력가능합니다");
                txtDepartment.Text = bo.Department;
            }
            txtDepartment.Focus();
        }
    }
}
