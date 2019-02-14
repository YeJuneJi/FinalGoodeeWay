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
            
            //txtNum.Text = emp.dataGridView1.SelectedCells[0].Value.ToString();
            //txtName.Text = emp.dataGridView1.SelectedCells[1].Value.ToString();
            //cbJob.Text = emp.dataGridView1.SelectedCells[2].Value.ToString();
            //txtSalary.Text = emp.dataGridView1.SelectedCells[3].Value.ToString();
            //txtDepartment.Text = emp.dataGridView1.SelectedCells[4].Value.ToString();
            //txtPhone.Text = emp.dataGridView1.SelectedCells[5].Value.ToString();
            //dtpJoin.Value = DateTime.Parse(emp.dataGridView1.SelectedCells[6].Value.ToString());
            //dtpLeave.Value = DateTime.Parse(emp.dataGridView1.SelectedCells[7].Value.ToString());
            //txtBankAccountNo.Text = emp.dataGridView1.SelectedCells[8].Value.ToString();
            //cbBank.Text = emp.dataGridView1.SelectedCells[9].Value.ToString();
            //txtEmail.Text = emp.dataGridView1.SelectedCells[10].Value.ToString();
            //txtNote.Text = emp.dataGridView1.SelectedCells[11].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
        }

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
