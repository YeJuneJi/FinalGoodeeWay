using GoodeeWay.DAO;
using GoodeeWay.VO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GoodeeWay.SaleRecords
{
    public partial class FrmSaleRecords : Form
    {
        List<SaleRecordsVO> searchlist;
        DataTable searchRecords;
        DataColumn[] dataColoumns;
        SaleRecordsVO saleRecords;
        string salesItemList;
        public FrmSaleRecords()
        {
            InitializeComponent();
        }

        private void FrmSaleRecords_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tbxSalesNo.Enabled = false;
            dtpPeriodStart.Enabled = false;
            dtpPeriodEnd.Enabled = false;

            searchlist = new List<SaleRecordsVO>();
            salesRecordsGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesRecordsGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            salesRecordsGView.AllowUserToAddRows = false;
            dataColoumns = new DataColumn[]
            {
                new DataColumn("판매번호"),
                new DataColumn("판매일"),
                new DataColumn("판매물품명"),
                new DataColumn("가격"),
                new DataColumn("할인"),
                new DataColumn("세금"),
                new DataColumn("합계"),
                new DataColumn("결제방식")
            };
            searchRecords = new DataTable("searchRecords");
            searchRecords.Columns.AddRange(dataColoumns);
            searchlist = new SaleRecordsDAO().OutPutAllSaleRecords();
            ListToGridView(searchlist);
        }
        
        private void ListToGridView(List<SaleRecordsVO> saleRecords)
        {
            foreach (var item in saleRecords)
            {
                salesItemList = string.Empty;
                RealMenuVO rv = JsonConvert.DeserializeObject<RealMenuVO>(item.SalesitemName);
                foreach (var realMenu in rv.RealMenu)
                {
                    salesItemList += realMenu.Menu.MenuName + ", ";
                }
                searchRecords.Rows.Add(item.SalesNo, item.SalesDate, salesItemList.Remove(salesItemList.Length - 2, 1) , item.SalesPrice, item.Discount, item.Duty, item.SalesTotal, item.PaymentPlan);
            }
            salesRecordsGView.DataSource = searchRecords;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchlist.Clear();
            salesRecordsGView.DataSource = null;
            searchRecords.Rows.Clear();
            if (rdoTotalSearch.Checked)
            {
                OutputAllSaleRecords();

            }
            else if (rdoSalesNo.Checked)
            {
                string salesNo = tbxSalesNo.Text.Replace(" ", "").Trim();
                if (ValidateSalesNo(salesNo))
                {
                    searchlist = new SaleRecordsDAO().SelectSaleRecordsBysalesNo(salesNo);
                    ListToGridView(searchlist);
                }
            }
            else
            {
                TimeSpan breakingDawn = new TimeSpan(00, 00, 01);
                TimeSpan eclipse = new TimeSpan(23, 59, 59);
                DateTime periodStart = dtpPeriodStart.Value;
                DateTime periodEnd = dtpPeriodEnd.Value;
                periodStart = periodStart.Date + breakingDawn;
                periodEnd = periodEnd.Date + eclipse;

                if (DateTime.Parse(periodStart.ToLongDateString()) > DateTime.Parse(periodEnd.ToLongDateString()))
                {
                    MessageBox.Show("시작날이 전날보다 이후 일 수 없습니다.");
                    dtpPeriodStart.Value = dtpPeriodEnd.Value = DateTime.Now;
                    return;
                }
                else
                {
                    searchlist = new SaleRecordsDAO().SelectSaleRacordsByPeriod(periodStart, periodEnd);
                    ListToGridView(searchlist);
                }
            }
        }

        private void OutputAllSaleRecords()
        {
            searchlist.Clear();
            salesRecordsGView.DataSource = null;
            searchRecords.Rows.Clear();
            searchlist = new SaleRecordsDAO().OutPutAllSaleRecords();
            ListToGridView(searchlist);
        }

        private bool ValidateSalesNo(string salesNo)
        {
            bool result = false;
            bool nullResult = false;
            bool typeResult = false;
            if (!string.IsNullOrEmpty(salesNo))
            {
                nullResult = true;
            }
            else
            {
                tbxSalesNo.Focus();
                MessageBox.Show("검색 조건을 입력 해 주세요");
                return false;
            }
            if (int.TryParse(salesNo, out int isalesNo))
            {
                typeResult = true;
            }
            else
            {
                tbxSalesNo.Focus();
                MessageBox.Show("판매번호는 0이상의 정수만 입력 해주세요");
                return false;
            }
            if (nullResult && typeResult)
            {
                result = true;
            }
            return result;
        }


        private void rdoCheck_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Name == rdoTotalSearch.Name)
            {
                if (rdoTotalSearch.Checked)
                {
                    tbxSalesNo.Enabled = false;
                    dtpPeriodStart.Enabled = false;
                    dtpPeriodEnd.Enabled = false;
                }
            }
            else if (radioButton.Name == rdoSalesNo.Name)
            {
                if (rdoSalesNo.Checked)
                {
                    tbxSalesNo.Enabled = true;
                    dtpPeriodStart.Enabled = false;
                    dtpPeriodEnd.Enabled = false;
                }
            }
            else
            {
                if (rdoDate.Checked)
                {
                    tbxSalesNo.Enabled = false;
                    dtpPeriodStart.Enabled = true;
                    dtpPeriodEnd.Enabled = true;
                }
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (saleRecords == null)
            {
                MessageBox.Show("수정할 기록을 선택 해 주세요.");
            }
            else
            {
                FrmUpdateSaleRecords updateSaleRecords = new FrmUpdateSaleRecords(saleRecords);
                updateSaleRecords.ShowDialog();
                OutputAllSaleRecords();
            }

        }

        private void salesRecordsGView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                saleRecords = new SaleRecordsVO()
                {
                    SalesNo = int.Parse(salesRecordsGView.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    SalesDate = DateTime.Parse(salesRecordsGView.Rows[e.RowIndex].Cells[1].Value.ToString()),
                    SalesitemName = salesRecordsGView.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    SalesPrice = float.Parse(salesRecordsGView.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    Discount = float.Parse(salesRecordsGView.Rows[e.RowIndex].Cells[4].Value.ToString()),
                    Duty = float.Parse(salesRecordsGView.Rows[e.RowIndex].Cells[5].Value.ToString()),
                    SalesTotal = float.Parse(salesRecordsGView.Rows[e.RowIndex].Cells[6].Value.ToString()),
                    PaymentPlan = salesRecordsGView.Rows[e.RowIndex].Cells[7].Value.ToString()
                };
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (saleRecords == null)
            {
                MessageBox.Show("삭제할 기록을 선택 해 주세요.");
            }
            else
            {
                if (MessageBox.Show("정말로 삭제 하시겠습니까?", "", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    new SaleRecordsDAO().DeleteSaleRecordsbysalesNo(saleRecords.SalesNo.ToString());
                    MessageBox.Show("삭제 성공");
                }
                OutputAllSaleRecords();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (excelSaveFileDlg.ShowDialog() != DialogResult.Cancel)
            {
                Excel.Application excelApp = new Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Excel응용 프로그램을 찾을 수 없거나, 설치되지 않았습니다.");
                    return;
                }
                Excel.Workbook workBook;
                Excel.Worksheet workSheet;
                object missingValue = System.Reflection.Missing.Value;
                workBook = excelApp.Workbooks.Add(missingValue);
                workSheet = workBook.Worksheets.Item[1];

                for (int i = 1; i < dataColoumns.Length + 1; i++)
                {
                    workSheet.Cells[1, i] = dataColoumns[i - 1].ColumnName;
                }

                for (int i = 2; i < salesRecordsGView.Rows.Count + 2; i++)
                {
                    workSheet.Cells[i, 1] = int.Parse(salesRecordsGView.Rows[i - 2].Cells[0].Value.ToString());
                    workSheet.Cells[i, 2] = salesRecordsGView.Rows[i - 2].Cells[1].Value.ToString();
                    workSheet.Cells[i, 3] = salesRecordsGView.Rows[i - 2].Cells[2].Value.ToString();
                    workSheet.Cells[i, 4] = float.Parse(salesRecordsGView.Rows[i - 2].Cells[3].Value.ToString());
                    workSheet.Cells[i, 5] = float.Parse(salesRecordsGView.Rows[i - 2].Cells[4].Value.ToString());
                    workSheet.Cells[i, 6] = float.Parse(salesRecordsGView.Rows[i - 2].Cells[5].Value.ToString());
                    workSheet.Cells[i, 7] = float.Parse(salesRecordsGView.Rows[i - 2].Cells[6].Value.ToString());
                    workSheet.Cells[i, 8] = salesRecordsGView.Rows[i - 2].Cells[7].Value.ToString();
                }
                try
                {
                    workBook.SaveAs(excelSaveFileDlg.FileName, Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingValue, missingValue, missingValue, missingValue);
                }
                catch (Exception)
                {
                    throw;
                }
                excelApp.Quit();
                Marshal.FinalReleaseComObject(workSheet);
                Marshal.FinalReleaseComObject(workBook);
                Marshal.FinalReleaseComObject(excelApp);
            }
        }

        private void salesRecordsGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int salesNo = int.Parse(salesRecordsGView.SelectedRows[0].Cells[0].Value.ToString());
            DateTime salesDate = DateTime.Parse(salesRecordsGView.SelectedRows[0].Cells[1].Value.ToString());            
            RealMenuVO realMenuVO = JsonConvert.DeserializeObject<RealMenuVO>(salesRecordsGView.SelectedRows[0].Cells[2].Value.ToString());
            decimal totalPrice = decimal.Parse(salesRecordsGView.SelectedRows[0].Cells[6].Value.ToString());

            FrmDetailSaleRecord fdsr = new FrmDetailSaleRecord(salesNo, salesDate, realMenuVO, totalPrice);
            fdsr.ShowDialog();            

        }
    }
}
