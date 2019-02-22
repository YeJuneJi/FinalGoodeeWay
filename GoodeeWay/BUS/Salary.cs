﻿using GoodeeWay.DAO;
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
        int page = 1;
        int temp = 0;
        int totalcount = 1;
        SalaryDAO sd = new SalaryDAO();
        List<SalaryVO> lst = new List<SalaryVO>();
        List<SalaryVO> ev = new List<SalaryVO>();

        public Salary()
        {
            InitializeComponent();
            lst = sd.SelectAll();
            ev = lst;
            if (lst.Count % 10 == 0)
            {
                totalcount = lst.Count / 10;
            }
            else
            {
                totalcount = (lst.Count / 10) + 1;
            }
            lblLast.Text = totalcount.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert_Salary ins = new Insert_Salary();
            ins.FormClosed += new FormClosedEventHandler(newForm_FormClosed); // 닫으면 폼이 새로고침됨
            ins.Show();
        }

        private void newForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Salary_Load(null, null);
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
            dataGridView1.DataSource = "";
            lblFirst.Text = page.ToString();
            comboBox1.Text = comboBox3.Text = "2019";
            comboBox2.Text = comboBox4.Text = "2";

            if (totalcount > 1 && page > 1)
            {
                ev = new List<SalaryVO>();

                for (int i = (page * 10) - 10; i < (page * 10) - 1; i++) // page 2 : 10~19, 3 : 20~29
                {
                    ev.Add(new SalaryVO()
                    {
                        No = lst[i].No.ToString(),
                        Name = lst[i].Name.ToString(),
                        Empno = lst[i].Empno.ToString(),
                        Payday = lst[i].Payday,
                        Salary = lst[i].Salary,
                        Tax = lst[i].Tax,
                        TotalSalary = lst[i].TotalSalary,
                    });
                    //ev[temp].Name = lst[i].Name;
                    //ev[temp].Empno = lst[i].Empno;
                    //ev[temp].Payday = lst[i].Payday;
                    //ev[temp].Salary = lst[i].Salary;
                    //ev[temp].Tax = lst[i].Tax;
                    //ev[temp].TotalSalary = lst[i].TotalSalary;
                    //ev.Add(lst[i]);
                }
                dataGridView1.DataSource = ev;
            }
            else
            {
                dataGridView1.DataSource = lst;
            }

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (page == totalcount)
            {
                MessageBox.Show("마지막 페이지 입니다.");
            }
            else
            {
                page++;
                lblFirst.Text = page.ToString();
                Salary_Load(null, null);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                MessageBox.Show("첫번째 페이지 입니다.");
            }
            else
            {
                page--;
                lblFirst.Text = page.ToString();
                Salary_Load(null, null);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (page == totalcount)
            {
                MessageBox.Show("마지막 페이지 입니다.");
            }
            else
            {
                page = totalcount;
                lblFirst.Text = page.ToString();
                Salary_Load(null, null);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                MessageBox.Show("첫번째 페이지 입니다.");
            }
            else
            {
                page = 1;
                lblFirst.Text = page.ToString();
                Salary_Load(null, null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Update_Salary us = new Update_Salary();
            us.Show();
        }
    }
}
