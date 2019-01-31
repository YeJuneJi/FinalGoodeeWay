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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class Employee : Form
    {
        List<EmpVO> lst;

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            lst = new EmpDAO().OutputAllBoard();
            this.dataGridView1.DataSource = lst;

            txtNum.Text = dataGridView1.SelectedCells[0].Value.ToString()+1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var empvo = new EmpVO();

            try
            {
                if (check())
                {
                    if (dtpLeave.Value < dtpJoin.Value) // 퇴사일이 입사일보다 빠르면 서로 교체
                    {
                        DateTime temp = dtpLeave.Value;
                        dtpLeave.Value = dtpJoin.Value;
                        dtpJoin.Value = temp;
                    }
                    if (dtpLeave.Enabled)
                    {
                        empvo = new EmpVO()
                        {
                            Empno = txtNum.Text,
                            Name = txtName.Text,
                            Job = cbJob.Text, //Job = txtJob.Text,
                            Pay = float.Parse(txtSalary.Text),
                            Department = txtDepartment.Text,
                            Mobile = txtPhone.Text,
                            JoinDate = dtpJoin.Value,
                            //LeaveDate = dtpLeave.Value,
                            BankAccountNo = txtBankAccountNo.Text,
                            Bank = cbBank.Text, // txtBank.Text,
                            Email = txtEmail.Text,
                            Note = txtNote.Text
                        };
                    }
                    
                    try
                    {
                        if (new EmpDAO().InsertBoard(empvo))
                        {
                            MessageBox.Show("저장 성공");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("저장 실패" + ex);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("오류");
            }

            Employee_Load(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txtName.Text = "";
            txtBank.Text = "";
            txtBankAccountNo.Text = "";
            txtDepartment.Text = "";
            txtEmail.Text = "";
            txtJob.Text = "";
            txtNote.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            dtpJoin.Text = "";
            dtpLeave.Text = "";

            Employee_Load(null, null);
        }

        private void txtSalary_TextChanged(object sender, EventArgs e) // 시급은 숫자만 입력 가능하게 하기
        {
            string str = Regex.Replace(this.txtSalary.Text, @"[0-9]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("시급은 숫자만 입력가능합니다");
                txtSalary.Text = "";
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNum.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedCells[1].Value.ToString();
            cbJob.Text = dataGridView1.SelectedCells[2].Value.ToString(); //txtJob.Text
            txtSalary.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtDepartment.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtPhone.Text = dataGridView1.SelectedCells[5].Value.ToString();
            dtpJoin.Value = DateTime.Parse(dataGridView1.SelectedCells[6].Value.ToString());
            dtpLeave.Value = DateTime.Parse(dataGridView1.SelectedCells[7].Value.ToString());
            txtBankAccountNo.Text = dataGridView1.SelectedCells[8].Value.ToString();
            cbBank.Text = dataGridView1.SelectedCells[9].Value.ToString(); //txtBank.Text
            txtEmail.Text = dataGridView1.SelectedCells[10].Value.ToString();
            txtNote.Text = dataGridView1.SelectedCells[11].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (check())
                {
                    EmpVO emp = new EmpVO();
                    string sp = "proc_emp_update";
                    SqlParameter[] sqlParameters = new SqlParameter[12];
                    sqlParameters[0] = new SqlParameter("empno", emp.Empno);
                    sqlParameters[1] = new SqlParameter("job", emp.Job);
                    sqlParameters[2] = new SqlParameter("Pay", emp.Pay);
                    sqlParameters[3] = new SqlParameter("name", emp.Name);
                    sqlParameters[4] = new SqlParameter("Department", emp.Department);
                    sqlParameters[5] = new SqlParameter("Mobile", emp.Mobile);
                    sqlParameters[6] = new SqlParameter("JoinDate", emp.JoinDate);
                    //sqlParameters[7] = new SqlParameter("LeaveDate", emp.LeaveDate);
                    sqlParameters[8] = new SqlParameter("BankAccountNo", emp.BankAccountNo);
                    sqlParameters[9] = new SqlParameter("Bank", emp.Bank);
                    sqlParameters[10] = new SqlParameter("Email", emp.Email);
                    sqlParameters[11] = new SqlParameter("Note", emp.Note);

                    new DBConnection().Update(sp, sqlParameters);
                }
                MessageBox.Show("수정 성공");
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장 실패" + ex);
            }

            Employee_Load(null, null);
        }
        /// <summary>
        /// 필수입력란 bool로 확인
        /// </summary>
        /// <returns>결과값</returns>
        private bool check()
        {
            bool result = false;

            if (!(string.IsNullOrEmpty(txtNum.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSalary.Text) || string.IsNullOrEmpty(txtBankAccountNo.Text) || string.IsNullOrEmpty(cbBank.Text) ))
            {
                result = true;
            }
            else
            {
                MessageBox.Show("필수입력란을 모두 입력해주세요");
            }
            return result;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e) 
        {
            
        }

        private void txtEmail_Leave(object sender, EventArgs e)// 이메일 유효성 검사
        {
            if (!(txtEmail.Text == ""))
            {
                bool emailCheck = Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                if (!(emailCheck))
                {
                    MessageBox.Show("올바르지않는 이메일 주소");
                }
            }
        }

        private void cbJob_Leave(object sender, EventArgs e)//직급 유효성 검사
        {
            if (!(cbJob.Text == "알바" || cbJob.Text == "매니저" || cbJob.Text == "점장"))
            {
                MessageBox.Show("직급이 올바르지 않습니다");
                cbJob.Text = "";
            }
        }
    }
}