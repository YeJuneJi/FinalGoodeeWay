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
        EmpVO emp = new EmpVO();
        
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lst = new EmpDAO().OutputAllBoard();
            this.dataGridView1.DataSource = lst;

            try
            {
                var t = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString().Substring(3)) + 1;
                switch (t / 10)
                {
                    case 0:
                        txtNum.Text = "EMP00000" + t.ToString();
                        break;
                    case 1:
                        txtNum.Text = "EMP0000" + t.ToString();
                        break;
                    case 10:
                        txtNum.Text = "EMP000" + t.ToString();
                        break;
                    case 100:
                        txtNum.Text = "EMP00" + t.ToString();
                        break;
                    case 1000:
                        txtNum.Text = "EMP0" + t.ToString();
                        break;
                    case 10000:
                        txtNum.Text = "EMP" + t.ToString();
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert_Emp ie = new Insert_Emp();
            ie.FormClosed += new FormClosedEventHandler(newForm_FormClosed);
            ie.Show();
        }

        private void newForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Employee_Load(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
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
                    string sp = "proc_emp_update";
                    SqlParameter[] sqlParameters = new SqlParameter[12];
                    sqlParameters[0] = new SqlParameter("empno", txtNum.Text);
                    sqlParameters[1] = new SqlParameter("job", cbJob.Text);
                    sqlParameters[2] = new SqlParameter("Pay", txtSalary.Text);
                    sqlParameters[3] = new SqlParameter("name", txtName.Text);
                    sqlParameters[4] = new SqlParameter("Department", txtDepartment.Text);
                    sqlParameters[5] = new SqlParameter("Mobile", txtPhone.Text);
                    sqlParameters[6] = new SqlParameter("JoinDate", dtpJoin.Value);
                    sqlParameters[7] = new SqlParameter("LeaveDate", dtpLeave.Value);
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

            Employee_Load(null, null);
        }
        /// <summary>
        /// 필수입력란 bool로 확인
        /// </summary>
        /// <returns>결과값</returns>
        private bool check()
        {
            bool result = false;

            if (!(string.IsNullOrEmpty(txtNum.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSalary.Text) || string.IsNullOrEmpty(txtBankAccountNo.Text) || string.IsNullOrEmpty(cbBank.Text)))
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
                    MessageBox.Show("올바르지 않은 이메일 주소입니다");
                    txtEmail.Text = "";
                }
            }
        }

        private void cbJob_Leave(object sender, EventArgs e)//직급 유효성 검사
        {
            if (!(cbJob.Text == "알바" || cbJob.Text == "매니저" || cbJob.Text == "점장"))
            {
                MessageBox.Show("존재하지 않는 직급입니다");
                cbJob.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("정말 삭제하시겠습니까?", "",btn);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sp = "proc_emp_delete";
                    SqlParameter[] sqlParameters = new SqlParameter[1];
                    sqlParameters[0] = new SqlParameter("empno", txtNum.Text);
                    new DBConnection().Delete(sp, sqlParameters);
                    MessageBox.Show("삭제 성공");
                }
                catch (Exception)
                {
                    MessageBox.Show("삭제 실패");
                }
            }
            else
            {
                MessageBox.Show("취소되었습니다");
            }
            Employee_Load(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            lst.Clear();
            if (txtSearch.Text == "")
            {
                Employee_Load(null, null);
            }
            else
            {
                string sp = "proc_emp_select";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("name", txtSearch.Text);
              
                SqlDataReader sr= new DBConnection().Select(sp, sqlParameters);

                while (sr.Read())
                {
                    lst.Add(new EmpVO()
                    {
                        Empno = sr["empno"].ToString(),
                        Name = sr["name"].ToString(),
                        Job = sr["job"].ToString(),
                        Pay = float.Parse(sr["pay"].ToString()),
                        Department = sr["Department"].ToString(),
                        Mobile = sr["Mobile"].ToString(),
                        JoinDate = DateTime.Parse(sr["JoinDate"].ToString()),
                        LeaveDate = DateTime.Parse(sr["LeaveDate"].ToString()),
                        BankAccountNo = sr["BankAccountNo"].ToString(),
                        Bank = sr["Bank"].ToString(),
                        Email = sr["Email"].ToString(),
                        Note = sr["Note"].ToString(),
                    });
                }

                dataGridView1.DataSource = lst;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}