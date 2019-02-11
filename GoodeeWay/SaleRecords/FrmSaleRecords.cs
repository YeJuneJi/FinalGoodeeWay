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
            foreach (var item in searchlist)
            {
                searchRecords.Rows.Add(item.SalesNo, item.SalesDate, item.SalesitemName, item.SalesPrice, item.Discount, item.Duty,item.SalesTotal, item.PaymentPlan);
            }
            salesRecordsGView.DataSource = searchRecords;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchlist.Clear();
            salesRecordsGView.DataSource = null;
            if (rdoTotalSearch.Checked)
            {
                searchlist = new SaleRecordsDAO().OutPutAllSaleRecords();
                ListToGridView(searchlist);
                
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
                
                DateTime periodStart = dtpPeriodStart.Value;
                DateTime periodEnd = dtpPeriodEnd.Value;
                if (DateTime.Parse(periodStart.ToLongDateString()) > DateTime.Parse(periodEnd.ToLongDateString()))
                {
                    MessageBox.Show("시작날이 전날보다 이후 일 수 없습니다.");
                    return;
                }
                else
                {
                    searchlist = new SaleRecordsDAO().SelectSaleRacordsByPeriod(periodStart, periodEnd);
                    ListToGridView(searchlist);
                }
            }
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

        private void btnInsert_Click(object sender, EventArgs e)
        {

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
    }
}
