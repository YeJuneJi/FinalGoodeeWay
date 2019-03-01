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
using Excel = Microsoft.Office.Interop.Excel;

namespace GoodeeWay.BUS
{
    public partial class Salary : Form
    {
        SalaryDAO sd = new SalaryDAO();
        List<SalaryVO> lst;
        List<SalaryVO> ev = new List<SalaryVO>();

        public Salary()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert_Salary ins = new Insert_Salary();
            ins.FormClosed += new FormClosedEventHandler(Salary_Load); // 닫으면 폼이 새로고침됨
            ins.Show();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("일련번호 '" + dataGridView1.SelectedCells[0].Value + "'의 기록을 정말로 삭제하시겠습니까?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    sd.DeleteSalary(dataGridView1.SelectedCells[0].Value.ToString());
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
            Salary_Load(null, null);
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
                worksheet.Cells[1, 5] = "월 급여 대장";
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
                    workbook.SaveAs(@"C:\Users\llsw1\Desktop\Salary.xls", Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingValue, missingValue, missingValue, missingValue);
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

        private void Salary_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "2018"; comboBox3.Text = "2019";
            comboBox2.Text = "1"; comboBox4.Text = "12";
            
            lst = sd.SelectAll();
            dataGridView1.DataSource = lst;
            ColumnSetKor();
        }

        private void ColumnSetKor()
        {
            dataGridView1.Columns["no"].HeaderText = "일련번호";
            dataGridView1.Columns["empno"].HeaderText = "사원번호";
            dataGridView1.Columns["salary"].HeaderText = "정산금액";
            dataGridView1.Columns["tax"].HeaderText = "세금";
            dataGridView1.Columns["bonus"].HeaderText = "보너스";
            dataGridView1.Columns["totalsalary"].HeaderText = "총 지급금액";
            dataGridView1.Columns["payday"].HeaderText = "지급 날짜";
            dataGridView1.Columns["name"].HeaderText = "사원명";
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";

            DateTime temp1 = DateTime.Parse(comboBox1.Text + "-" + comboBox2.Text + "-01");
            DateTime temp2 = DateTime.Parse(comboBox3.Text + "-" + comboBox4.Text + "-01");
            
            if (temp1 > temp2)
            {
                DateTime temp3;
                temp3 = temp1;
                temp1 = temp2;
                temp2 = temp3;

                string temp = "";
                string strtemp ="";
                temp = comboBox1.Text;
                strtemp = comboBox2.Text;
                comboBox1.Text = comboBox3.Text;
                comboBox2.Text = comboBox4.Text;
                comboBox3.Text = temp;
                comboBox4.Text = strtemp;
            }

            temp1 = DateTime.Parse(comboBox1.Text + "-" + comboBox2.Text + "-01");
            temp2 = DateTime.Parse(comboBox3.Text + "-" + comboBox4.Text + "-31");
            lst = sd.Search(temp1, temp2);
            dataGridView1.DataSource = lst;
            ColumnSetKor();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate_Click(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SalaryVO sv = new SalaryVO()
            {
                No = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                Empno = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                Name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                Salary = float.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()),
                Tax = float.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()),
                Bonus = float.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()),
                TotalSalary = float.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()),
                Payday = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString()),
            };

            Update_Salary us = new Update_Salary();
            us.sv.No = sv.No;
            us.sv.Empno = sv.Empno;
            us.sv.Name = sv.Name;
            us.sv.Salary = sv.Salary;
            us.sv.Tax = sv.Tax;
            us.sv.Bonus = sv.Bonus;
            us.sv.TotalSalary = sv.TotalSalary;
            us.sv.Payday = sv.Payday;

            us.FormClosed += new FormClosedEventHandler(Salary_Load);
            us.Show();
        }
    }
}
