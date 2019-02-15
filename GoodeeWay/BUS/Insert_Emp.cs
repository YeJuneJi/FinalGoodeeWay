using GoodeeWay.DAO;
using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class Insert_Emp : Form
    {
        EmpDAO ed = new EmpDAO();

        public Insert_Emp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

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
            //try
            //{
            //    if (check())
            //    {
            //        var emp = new EmpVO()
            //        {
            //            Name = txtName.Text,
            //            Job = cbJob.Text,
            //            Pay = float.Parse(txtSalary.Text),
            //            Department = txtDepartment.Text,
            //            Mobile = txtPhone.Text,
            //            JoinDate = DateTime.Parse(dtpJoin.Text),
            //            BankAccountNo = txtBankAccountNo.Text,
            //            Bank = cbBank.Text,
            //            Email = txtEmail.Text,
            //            Note = txtNote.Text
            //        };

            //        try
            //        {
            //            if (new EmpDAO().InsertBoard(emp))
            //            {
            //                MessageBox.Show("저장 성공");
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("저장 실패" + ex);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("오류" + ex);
            //}
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

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            string str = Regex.Replace(this.txtSalary.Text, @"[0-9]", "");
            if (str.Length > 0)
            {
                MessageBox.Show("시급은 숫자만 입력가능합니다");
                txtSalary.Text = "";
            }
        }

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

        private void cbJob_Leave(object sender, EventArgs e)
        {
            if (!(cbJob.Text == "알바" || cbJob.Text == "매니저" || cbJob.Text == "점장" || cbJob.Text == ""))
            {
                MessageBox.Show(cbJob.Text + "는 존재하지 않는 직급입니다");
                cbJob.Text = "";
            }
        }

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
    }
}
