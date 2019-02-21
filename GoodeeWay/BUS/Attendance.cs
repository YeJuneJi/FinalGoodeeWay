using GoodeeWay.DAO;
using GoodeeWay.DB;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GoodeeWay.BUS
{
    public partial class Attendance : Form
    {
        AttendanceDAO ad = new AttendanceDAO();

        public Attendance()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";

            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                var temp = dateTimePicker1.Value;
                dateTimePicker1.Value = dateTimePicker2.Value;
                dateTimePicker2.Value = temp;
            }

            ad = new AttendanceDAO();
            dataGridView1.DataSource = ad.Select2Attendance(dateTimePicker1.Value, dateTimePicker2.Value);
            ColumnSetKorean();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            List<AttendanceVO> lst = ad.SelectAttendance();
            dataGridView1.DataSource = lst;
            ColumnSetKorean();
            lblTotalCount.Text = "현재 인원: " + dataGridView1.RowCount.ToString() + "명";
        }

        private void ColumnSetKorean()
        {
            dataGridView1.Columns["no"].HeaderText = "번호";
            dataGridView1.Columns["Empno"].HeaderText = "사번";
            dataGridView1.Columns["TimeIn"].HeaderText = "출근시간";
            dataGridView1.Columns["TimeOut"].HeaderText = "퇴근시간";
            dataGridView1.Columns["TotalTime"].HeaderText = "총 시간";
            dataGridView1.Columns["Date"].HeaderText = "날짜";
            dataGridView1.Columns["TotalPay"].HeaderText = "급여";
            dataGridView1.Columns["OverTime"].HeaderText = "초과시간";
            dataGridView1.Columns["Note"].HeaderText = "비고";
            dataGridView1.Columns["name"].HeaderText = "사원명";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert_Attendance ia = new Insert_Attendance();
            ia.FormClosed += Ia_FormClosed;
            ia.Show();
        }

        private void Ia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Attendance_Load(null, null);
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("수정할 직원을 화면에서 더블클릭하세요.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("일련번호 " + dataGridView1.SelectedCells[0].Value + "번 기록을 정말로 삭제하시겠습니까?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ad.DeleteAttendance(Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
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
            Attendance_Load(null, null);
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
                    workbook.SaveAs(@"C:\Users\llsw1\Desktop\Attendance.xls", Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingValue, missingValue, missingValue, missingValue);
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
    }
}
