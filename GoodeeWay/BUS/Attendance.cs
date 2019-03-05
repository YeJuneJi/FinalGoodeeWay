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
        /// <summary>
        /// 근태기록 날짜로 검색
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";

            if (dateTimePicker1.Value > dateTimePicker2.Value) // 뒤날짜가 앞날짜 보다 이르면 서로 날짜 교체
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
        /// <summary>
        /// 컬럼명 한글로 변환
        /// </summary>
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
        /// <summary>
        /// 추가하기 누르면 새 폼 띄우고 닫을때 이벤트 삽입
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 수정하기 누르면 새 폼 띄우고 닫을때 이벤트 삽입
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AttendanceVO av = new AttendanceVO()
            {
                No = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                Name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                Empno = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                TimeIn = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()),
                TimeOut = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()),
                TotalTime = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()),
                Date = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()),
                TotalPay = float.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString()),
                OverTime = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[8].Value.ToString()),
                Note = dataGridView1.SelectedRows[0].Cells[9].Value.ToString(),
            };

            Update_Attendance ua = new Update_Attendance();
            ua.av.No = av.No;
            ua.av.Name = av.Name;
            ua.av.Empno = av.Empno;
            ua.av.Date = av.Date;
            ua.av.TotalPay = av.TotalPay;
            ua.av.TimeIn = av.TimeIn;
            ua.av.TimeOut = av.TimeOut;
            ua.av.OverTime = av.OverTime;
            ua.av.TotalTime = av.TotalTime;
            ua.av.Note = av.Note;

            ua.FormClosed += new FormClosedEventHandler(Attendance_Load);
            ua.Show();
        }
        /// <summary>
        /// 선택된 행 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 엑셀 파일로 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    string fileName = "근태 기록 " + DateTime.Now.ToLongDateString();
                    saveFileDialog1.FileName = fileName;
                    saveFileDialog1.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\AppData\GoodeeWay\";
                    saveFileDialog1.Title = "Excel 저장위치 설정";
                    saveFileDialog1.DefaultExt = "xls";
                    saveFileDialog1.Filter = "Xls files(*.xls)|*xls";
                    saveFileDialog1.CreatePrompt = false;
                    saveFileDialog1.OverwritePrompt = false;
                    DialogResult address = saveFileDialog1.ShowDialog();
                    if (address == DialogResult.OK)
                    {
                        fileName = saveFileDialog1.FileName;

                        MessageBox.Show("엑셀 파일 저장 성공");
                    }
                    workbook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingValue, missingValue, missingValue, missingValue);
                }
                catch (Exception)
                {
                    return;
                }

                excelApp.Quit(); // 엑셀 프로그램 종료

                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }

        }
        /// <summary>
        /// 더블클릭해도 수정이랑 똑같이 되게함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate_Click(null, null);
        }
    }
}
