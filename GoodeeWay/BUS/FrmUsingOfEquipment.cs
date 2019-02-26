using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class FrmUsingOfEquipment : Form
    {
        public FrmUsingOfEquipment()
        {
            InitializeComponent();
        }
        private DataTable dataTable; //그리드뷰에 연결시킬 데이터 테이블
        List<VO.EquipmentVO> equipment = new List<VO.EquipmentVO>();

        private void FrmUsingOfEquipment_Load(object sender, EventArgs e)
        {
            dgvtotalList.AllowUserToAddRows = false;
            //초기화면 chart 설정 변경, x축 dot형식, y축 바탕과 같은 색으로, 축lable 형식 변경, 차이가 많은 데이터 짤라보기
            //crtEquipment.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            crtEquipment.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            crtEquipment.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            
            crtEquipment.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd"; //"dd.MM-hh:mm";
            crtEquipment.ChartAreas[0].AxisY.LabelStyle.Format = "0,000원";
            crtEquipment.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = true;
            DAO.EquipmentDAO dAO = new DAO.EquipmentDAO();

            var firstDayOfMonth_year = DateTime.Now.Year;
            var firstDayOfMonth_month = DateTime.Now.Month;
            dtpStartDate.Value = new DateTime(firstDayOfMonth_year, firstDayOfMonth_month, 1);

            equipment = dAO.EquipmentByDate(dtpStartDate.Value, DateTime.Now);//  dAO.AllequipmentVOsList();
            crtEquipment.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            crtEquipment.Series[0].Points.DataBind(equipment, "purchaseDate", "purchasePrice", null);
            crtEquipment.Series[0].LegendText = "총액";
            DetailInfo();

            dgvtotalList.DataSource = SetDataTable(dAO.EquipmentByDate(dtpStartDate.Value, dtpEndDate.Value));
            //crtCircle.Series[0].IsValueShownAsLabel = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DAO.EquipmentDAO dAO = new DAO.EquipmentDAO();
            equipment = dAO.GroupingDateEquipment(dtpStartDate.Value, dtpEndDate.Value);
            crtEquipment.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            crtEquipment.Series[0].Points.DataBind(equipment, "purchaseDate", "purchasePrice", null);
            // crtEquipment.Series[0].LegendText = "총액";

            DetailInfo();
            dgvtotalList.DataSource = SetDataTable(dAO.EquipmentByDate(dtpStartDate.Value, dtpEndDate.Value));
        }

        private void DetailInfo()
        {
            var totalE = from eq in equipment
                         select eq.PurchasePrice;

            var total = from eq in equipment
                        where eq.PurchasePrice == totalE.Max()
                        select eq;

            foreach (var item in total)
            {
                lblMaxDate.Text = String.Format("{0:#,###}원", Convert.ToInt32(item.PurchasePrice)) + " / " + item.PurchaseDate.ToLongDateString();
            }

            string lgsText;
            lgsText = totalE.Sum().ToString().Replace(",", ""); //숫자변환시 콤마로 발생하는 에러 방지
            lblTotalExpenditure.Text = String.Format("{0:#,###}원", Convert.ToInt32(lgsText));


            var monthMax = from eq in equipment
                           group eq by new
                           {
                               eq.PurchaseDate.Month,
                               eq.PurchaseDate.Year
                           };
            var monthToList = monthMax.ToList();

            List<VO.EquipmentVO> tempMonthPrice = new List<VO.EquipmentVO>();
            foreach (var item in monthToList)
            {
                float sumPrice = 0;
                foreach (var value in item)
                {
                    sumPrice += value.PurchasePrice;
                }
                tempMonthPrice.Add(new VO.EquipmentVO() { PurchaseDate = new DateTime(item.Key.Year, item.Key.Month, 1), PurchasePrice = sumPrice });
            }

            var maxMonth = from equip in tempMonthPrice
                           where equip.PurchasePrice == tempMonthPrice.Max(price => price.PurchasePrice)
                           select equip;

            foreach (var item in maxMonth)
            {
                lblMaxMonth.Text = String.Format("{0:#,###}원", Convert.ToInt32(item.PurchasePrice)) + " / " + item.PurchaseDate.ToLongDateString().Substring(0, 8);
            }


            List<VO.EquipmentVO> tempYearPrice = new List<VO.EquipmentVO>();
            var YearMax = from eq in tempMonthPrice
                          group eq by new { eq.PurchaseDate.Year };

            foreach (var item in YearMax)
            {
                float sumPrice = 0;
                foreach (var value in item)
                {
                    sumPrice += value.PurchasePrice;
                }
                tempYearPrice.Add(new VO.EquipmentVO() { PurchaseDate = new DateTime(item.Key.Year, 1, 1), PurchasePrice = sumPrice });
            }
            var maxYear = from equip in tempYearPrice
                          where equip.PurchasePrice == tempYearPrice.Max(price => price.PurchasePrice)
                          select equip;

            foreach (var item in maxYear)
            {
                lblMaxYear.Text = String.Format("{0:#,###}원", Convert.ToInt32(item.PurchasePrice)) + " / " + item.PurchaseDate.ToLongDateString().Substring(0, 5);
            }
            //EquipmentBYDate_PROC

            
        }

        private DataTable SetDataTable(List<VO.EquipmentVO> equipmentLst)
        {
               dataTable = new DataTable("Equipment");
         

            dataTable.Columns.Add("비품코드", typeof(string));
            dataTable.Columns.Add("상세명칭", typeof(string));
            dataTable.Columns.Add("위치", typeof(string));
            dataTable.Columns.Add("상태", typeof(string));
            dataTable.Columns.Add("구매가격", typeof(float));
            dataTable.Columns.Add("구매날짜", typeof(DateTime));
            dataTable.Columns.Add("비고", typeof(string));
            foreach (var item in equipmentLst)
            {
                dataTable.Rows.Add(item.EQUCode, item.DetailName, item.Location, item.State, item.PurchasePrice, item.PurchaseDate, item.Note);
            }
            return dataTable;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
