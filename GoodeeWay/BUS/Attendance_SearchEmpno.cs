using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class Attendance_SearchEmpno : Form
    {
        List<EmpVO> lst;
        public string empno;

        public Attendance_SearchEmpno()
        {
            InitializeComponent();
        }

        private void Attendance_SearchEmpno_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new EmpDAO().SelectAll();
            cbFilter.Text = "사원명";
            ColumnSetKor();
        }
        /// <summary>
        /// 더블클릭하면 해당 사원번호가 데이터에 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            empno = dataGridView1.SelectedCells[0].Value.ToString();
            Close();
        }
        /// <summary>
        /// 사원또는 이름으로 검색
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmpDAO empDAO = new EmpDAO();

            dataGridView1.DataSource = "";

            if (txtSearch.Text == "")
            {
                Attendance_SearchEmpno_Load(null, null);
            }
            else
            {
                bool a = false;

                if (cbFilter.Text == "사원번호")
                {
                    a = true;
                }

                lst = empDAO.nameSelect(a, txtSearch.Text);
                dataGridView1.DataSource = lst;
            }
            ColumnSetKor();
        }
        /// <summary>
        /// 컬럼명 한글화
        /// </summary>
        private void ColumnSetKor()
        {
            dataGridView1.Columns["empno"].HeaderText = "사원번호";
            dataGridView1.Columns["name"].HeaderText = "사원명";
            dataGridView1.Columns["job"].HeaderText = "직급";
            dataGridView1.Columns["pay"].HeaderText = "시급";
            dataGridView1.Columns["Department"].HeaderText = "부서";
            dataGridView1.Columns["Mobile"].HeaderText = "휴대폰번호";
            dataGridView1.Columns["JoinDate"].HeaderText = "입사일";
            dataGridView1.Columns["LeaveDate"].HeaderText = "퇴사일";
            dataGridView1.Columns["BankAccountNo"].HeaderText = "계좌번호";
            dataGridView1.Columns["Bank"].HeaderText = "은행명";
            dataGridView1.Columns["Email"].HeaderText = "이메일주소";
            dataGridView1.Columns["Note"].HeaderText = "비고";
        }
        /// <summary>
        /// 엔터쳐도 검색가능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
