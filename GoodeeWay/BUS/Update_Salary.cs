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
    public partial class Update_Salary : Form
    {
        public SalaryVO sv = new SalaryVO();

        public Update_Salary()
        {
            InitializeComponent();
        }
        public Update_Salary(SalaryVO vo) : this()
        {
            sv = vo;
        }

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

        private void Update_Salary_Activated(object sender, EventArgs e)
        {
        }

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

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            changeTotal();
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            changeTotal();
        }

        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            changeTotal();
        }

        private void changeTotal()
        {
            txtTotal.Text = (float.Parse(txtBonus.Text) + float.Parse(txtSalary.Text) - float.Parse(txtTax.Text)).ToString();
        }
    }
}
