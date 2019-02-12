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
    public partial class Insert_Emp : Form
    {
        public Insert_Emp()
        {
            InitializeComponent();
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
                    //if (dtpLeave.Value < dtpJoin.Value) // 퇴사일이 입사일보다 빠르면 서로 교체
                    //{
                    //    DateTime temp = dtpLeave.Value;
                    //    dtpLeave.Value = dtpJoin.Value;
                    //    dtpJoin.Value = temp;
                    //}
                    //if (dtpLeave.Enabled)
                    //{
                    var emp = new EmpVO()
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

                    try
                    {
                        if (new EmpDAO().InsertBoard(emp))
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
            catch (Exception ex)
            {
                MessageBox.Show("오류" + ex);
            }
        }

        

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
    }
}
