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
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpLeave.Value < dtpJoin.Value)
                {
                    DateTime temp = dtpLeave.Value;
                    dtpLeave.Value = dtpJoin.Value;
                    dtpJoin.Value = temp;
                }
                var empvo = new EmpVO()
                {
                    Empno = txtNum.Text,
                    Name = txtName.Text,
                    Job = txtJob.Text,
                    Pay = float.Parse(txtSalary.Text),
                    Department = txtDepartment.Text,
                    Mobile = txtPhone.Text,
                    JoinDate = dtpJoin.Value,
                    LeaveDate = dtpLeave.Value,
                    BankAccountNo = txtBankAccountNo.Text,
                    Bank = txtBank.Text,
                    Email = txtEmail.Text,
                    Note = txtNote.Text
                };

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

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if ((txtSalary.Text == @"[0-9]"))
            {
                txtSalary.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNum.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtJob.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtSalary.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtDepartment.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtPhone.Text = dataGridView1.SelectedCells[5].Value.ToString();
            dtpJoin.Value = DateTime.Parse(dataGridView1.SelectedCells[6].Value.ToString());
            dtpLeave.Value = DateTime.Parse(dataGridView1.SelectedCells[7].Value.ToString());
            txtBankAccountNo.Text = dataGridView1.SelectedCells[8].Value.ToString();
            txtBank.Text = dataGridView1.SelectedCells[9].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedCells[10].Value.ToString();
            txtNote.Text = dataGridView1.SelectedCells[11].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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
                sqlParameters[7] = new SqlParameter("LeaveDate", emp.LeaveDate);
                sqlParameters[8] = new SqlParameter("BankAccountNo", emp.BankAccountNo);
                sqlParameters[9] = new SqlParameter("Bank", emp.Bank);
                sqlParameters[10] = new SqlParameter("Email", emp.Email);
                sqlParameters[11] = new SqlParameter("Note", emp.Note);

                new DBConnection().Update(sp, sqlParameters);

                MessageBox.Show("저장 성공");
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장 실패" + ex);
            }
            
            Employee_Load(null, null);
        }

    }
}
