using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GoodeeWay.SaleRecords
{
    public partial class FrmSaleRecords : Form
    {
        List<SaleRecordsVO> searchlist;
        DataTable searchRecords;
        DataColumn[] dataColoumns;
        SaleRecordsVO saleRecords;
        public FrmSaleRecords()
        {
            InitializeComponent();
        }

        private void FrmSaleRecords_Load(object sender, EventArgs e)
        {
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
                searchRecords.Rows.Add(item.SalesNo, item.SalesDate, item.SalesitemName, item.SalesPrice, item.Discount, item.Duty,item.SalesTotal, item.PaymentPlan);
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
                TimeSpan breakingDawn = new TimeSpan(00, 00 ,01);
                TimeSpan eclipse = new TimeSpan(23, 59 ,59);
                DateTime periodStart = dtpPeriodStart.Value;
                DateTime periodEnd = dtpPeriodEnd.Value;
                periodStart =  periodStart.Date + breakingDawn;
                periodEnd =  periodEnd.Date + eclipse;

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
                MessageBox.Show("검색 조건을 입력 해 주세요");
                return false;
            }
            if (int.TryParse(salesNo, out int isalesNo))
            {
                typeResult = true;
            }
            else
            {
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
    }
}
