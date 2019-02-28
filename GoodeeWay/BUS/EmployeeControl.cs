using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.VO;
using GoodeeWay.DAO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace GoodeeWay.BUS
{
    public partial class EmployeeControl : UserControl
    {
        List<EmpVO> lst;
        EmpVO emp = new EmpVO();
        EmpDAO empDAO = new EmpDAO();
        List<EmpVO> ev = new List<EmpVO>();
        //int page = 1;
        //int totalcount = 1;

        public EmployeeControl()
        {
            InitializeComponent();
        }

        private void TotalCount()
        {
            lblTotalCount.Text = "현재 인원: " + dataGridView1.RowCount.ToString() + "명";
            //lblLast.Text = totalcount.ToString();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            cbFilter.Text = "사원명";
            lst = empDAO.SelectAll();

            this.dataGridView1.DataSource = lst;
            ColumnSettingKorean();
            TotalCount();
        }

        private void ColumnSettingKorean() // 컬럼명 한글화
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

        private void btnInsert_Click(object sender, EventArgs e) // 추가
        {
            Insert_Emp ie = new Insert_Emp();
            ie.FormClosed += new FormClosedEventHandler(Employee_Load); // 닫으면 폼이 새로고침됨
            ie.Show();
        }

        private void btnClear_Click(object sender, EventArgs e) // 새로고침
        {
            Employee_Load(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e) // 수정버튼
        {
            EmpVO tempVO = new EmpVO()
            {
                Empno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                Name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                Job = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                Pay = float.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()),
                Department = dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                Mobile = dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                JoinDate = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()),
                LeaveDate = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString()),
                BankAccountNo = dataGridView1.SelectedRows[0].Cells[8].Value.ToString(),
                Bank = dataGridView1.SelectedRows[0].Cells[9].Value.ToString(),
                Email = dataGridView1.SelectedRows[0].Cells[10].Value.ToString(),
                Note = dataGridView1.SelectedRows[0].Cells[11].Value.ToString(),
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

            ue.FormClosed += new FormClosedEventHandler(Employee_Load);
            ue.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e) // 삭제
        {
            DialogResult result = MessageBox.Show("'" + dataGridView1.SelectedCells[1].Value + "' 직원을 정말로 삭제하시겠습니까?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    empDAO.Delete(dataGridView1.SelectedCells[0].Value.ToString());
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

            if (txtSearch.Text == "")
            {
                Employee_Load(null, null);
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
            ColumnSettingKorean();
            TotalCount();
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
            btnUpdate_Click(null, null);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.Show();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";

            if (cbFilter.Text == "사원번호")
            {
                txtSearch.Text = "EMP000000";
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("현재 내용을 파일로 저장하시겠습니까?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Excel.Application excelApp = new Excel.Application(); // Excel 응용프로그램 객체
                if (excelApp == null)
                {
                    MessageBox.Show("Excel 응용프로그램을 찾을 수 없거나, 설치되지 않았습니다");
                    return;
                }
                Excel.Workbook workbook; // 통합문서 객체
                Excel.Worksheet worksheet; // 워크시트 객체
                object missingValue = System.Reflection.Missing.Value;

                workbook = excelApp.Workbooks.Add(missingValue);
                worksheet = workbook.Worksheets.Item[1]; // 엑셀은 1부터 시작
                worksheet.Cells[1, 5] = "직원 목록";
                string a = "";
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[2, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                {
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        a = dataGridView1.Rows[j].Cells[i].Value.ToString();
                        worksheet.Cells[j + 3, i + 1] = a;
                    }
                }
                try
                {
                    workbook.SaveAs(@"C:\Users\llsw1\Desktop\Employee.xls", Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingValue, missingValue, missingValue, missingValue);
                }
                catch (Exception)
                {
                    return;
                }

                excelApp.Quit(); // 엑셀 프로그램 종료

                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);

                MessageBox.Show("엑셀 파일 저장 성공");
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendance ad = new Attendance();
            ad.Show();
        }
    }
}
