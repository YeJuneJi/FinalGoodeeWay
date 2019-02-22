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
    public partial class Update_Emp : Form
    {
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
            try
            {
                if (check())
                {
                    string sp = "proc_emp_update";
                    SqlParameter[] sqlParameters = new SqlParameter[12];
                    sqlParameters[0] = new SqlParameter("empno", txtNum.Text);
                    sqlParameters[1] = new SqlParameter("job", cbJob.Text);
                    sqlParameters[2] = new SqlParameter("Pay", txtSalary.Text);
                    sqlParameters[3] = new SqlParameter("name", txtName.Text);
                    sqlParameters[4] = new SqlParameter("Department", txtDepartment.Text);
                    sqlParameters[5] = new SqlParameter("Mobile", txtPhone.Text);
                    sqlParameters[6] = new SqlParameter("JoinDate", DateTime.Parse(dtpJoin.Text));
                    sqlParameters[7] = new SqlParameter("LeaveDate", DateTime.Parse(dtpLeave.Text));
                    sqlParameters[8] = new SqlParameter("BankAccountNo", txtBankAccountNo.Text);
                    sqlParameters[9] = new SqlParameter("Bank", cbBank.Text);
                    sqlParameters[10] = new SqlParameter("Email", txtEmail.Text);
                    sqlParameters[11] = new SqlParameter("Note", txtNote.Text);

                    new DBConnection().Update(sp, sqlParameters);

                    MessageBox.Show("수정 성공");
                }
            }
            catch (Exception)
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
    }
}
