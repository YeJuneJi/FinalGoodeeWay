﻿using GoodeeWay.DAO;
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
            lst = new EmpDAO().OutputAllBoard();
            this.dataGridView1.DataSource = lst;
            lblTotalCount.Text = "현재 인원: "+dataGridView1.RowCount.ToString() + "명";
            //try
            //{
            //    var t = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString().Substring(3)) + 1;
            //    switch (t / 10)
            //    {
            //        case 0:
            //            txtNum.Text = "EMP00000" + t.ToString();
            //            break;
            //        case 1:
            //            txtNum.Text = "EMP0000" + t.ToString();
            //            break;
            //        case 10:
            //            txtNum.Text = "EMP000" + t.ToString();
            //            break;
            //        case 100:
            //            txtNum.Text = "EMP00" + t.ToString();
            //            break;
            //        case 1000:
            //            txtNum.Text = "EMP0" + t.ToString();
            //            break;
            //        case 10000:
            //            txtNum.Text = "EMP" + t.ToString();
            //            break;
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert_Emp ie = new Insert_Emp();
            ie.FormClosed += new FormClosedEventHandler(newForm_FormClosed); // 닫으면 폼이 새로고침됨
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
            //string str = Regex.Replace(this.txtSalary.Text, @"[0-9]", "");
            //if (str.Length > 0)
            //{
            //    MessageBox.Show("시급은 숫자만 입력가능합니다");
            //    txtSalary.Text = "";
            //}

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
            MessageBox.Show("수정할 직원을 화면에서 더블클릭하세요.");
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
            //if (!(txtEmail.Text == ""))
            //{
            //    bool emailCheck = Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            //    if (!(emailCheck))
            //    {
            //        MessageBox.Show("올바르지 않은 이메일 주소입니다");
            //        txtEmail.Text = "";
            //    }
            //}
        }

        private void cbJob_Leave(object sender, EventArgs e)//직급 유효성 검사
        {
            //if (!(cbJob.Text == "알바" || cbJob.Text == "매니저" || cbJob.Text == "점장"))
            //{
            //    MessageBox.Show("존재하지 않는 직급입니다");
            //    cbJob.Text = "";
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("'" + dataGridView1.SelectedCells[1].Value + "' 직원을 정말로 삭제하시겠습니까?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None,MessageBoxDefaultButton.Button2);

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

                SqlDataReader sr = new DBConnection().Select(sp, sqlParameters);

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpVO tempVO = new EmpVO()
            {
                Empno = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Job = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                Pay = float.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()),
                Department = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                Mobile = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),
                JoinDate = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()),
                LeaveDate = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()),
                BankAccountNo = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(),
                Bank = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString(),
                Email = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString(),
                Note = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString(),
            };

            Update_Emp ue = new Update_Emp();
            ue.bo.Empno = tempVO.Empno;
            ue.bo.Name = tempVO.Name;
            ue.bo.Job = tempVO.Job;
            ue.bo.Pay = tempVO.Pay;
            ue.bo.Department = tempVO.Department;
            ue.bo.Mobile = tempVO.Mobile;
            ue.bo.JoinDate = tempVO.JoinDate;
            ue.bo.LeaveDate = tempVO.LeaveDate;
            ue.bo.BankAccountNo = tempVO.BankAccountNo;
            ue.bo.Bank = tempVO.Bank;
            ue.bo.Email = tempVO.Email;
            ue.bo.Note = tempVO.Note;

            ue.FormClosed += new FormClosedEventHandler(newForm_FormClosed);
            ue.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.Show();
        }
    }
}