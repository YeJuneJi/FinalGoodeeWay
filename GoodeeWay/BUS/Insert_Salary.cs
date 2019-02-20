using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class Insert_Salary : Form
    {
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ase = new Attendance_SearchEmpno();
            ase.FormClosed += new FormClosedEventHandler(aseForm_FormClosed);
            ase.Show();
        }

        private void aseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtEmpno.Text = ase.empno;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpno.Text = "";
            txtSalary.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";
            txtBonus.Text = "0";
        }

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
    }
}
