using GoodeeWay.VO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class FrmResourceChart : Form
    {
        DataTable totRsrcTab;
        List<string> periodList;
        List<decimal> totInvestList;
        List<decimal> totRawMaterialList;
        List<decimal> EquipPriceList;
        List<decimal> totEmployeePriceList;
        List<decimal> totnetProfitList;
        ToolTip toolTipStackedColumn = new ToolTip();
        Point? previousPosition = null;
        public FrmResourceChart(DataTable totRsrcTab)
        {
            InitializeComponent();
            this.totRsrcTab = totRsrcTab;
            periodList = new List<string>();
            totInvestList = new List<decimal>();
            totRawMaterialList = new List<decimal>();
            EquipPriceList = new List<decimal>();
            totEmployeePriceList = new List<decimal>();
            totnetProfitList = new List<decimal>();
        }

        private void FrmResourceChart_Load(object sender, EventArgs e)
        {
            this.Text = "통계 차트";
            if (totRsrcTab.Rows.Count == 0)
            {
                MessageBox.Show("통계를 우선 출력해주세요!");
                this.Close();
                return;
            }

            foreach (DataRow item in totRsrcTab.Rows)
            {
                periodList.Add(item[0].ToString());
                totInvestList.Add(Convert.ToDecimal(item[1]));
                totRawMaterialList.Add(Convert.ToDecimal(item[2]));
                EquipPriceList.Add(Convert.ToDecimal(item[3]));
                totEmployeePriceList.Add(Convert.ToDecimal(item[4]));
                totnetProfitList.Add(Convert.ToDecimal(item[5]));
            }
            chartTotalInvest.Series.Clear();
            chartTotalInvest.Titles.Add("통계");
            chartTotalInvest.Titles[0].Font = new Font(new FontFamily(GenericFontFamilies.SansSerif), 20, FontStyle.Bold);
            chartTotalInvest.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chartTotalInvest.ChartAreas[0].AxisY.Interval = 250000;

            System.Windows.Forms.DataVisualization.Charting.Series seriesInvest = new System.Windows.Forms.DataVisualization.Charting.Series(totRsrcTab.Columns[1].ColumnName);
            System.Windows.Forms.DataVisualization.Charting.Series seriesRawMaterial = new System.Windows.Forms.DataVisualization.Charting.Series(totRsrcTab.Columns[2].ColumnName);
            System.Windows.Forms.DataVisualization.Charting.Series seriesEquipPrice = new System.Windows.Forms.DataVisualization.Charting.Series(totRsrcTab.Columns[3].ColumnName);
            System.Windows.Forms.DataVisualization.Charting.Series seriesEmployeePrice = new System.Windows.Forms.DataVisualization.Charting.Series(totRsrcTab.Columns[4].ColumnName);
            System.Windows.Forms.DataVisualization.Charting.Series seriesNetProfit = new System.Windows.Forms.DataVisualization.Charting.Series(totRsrcTab.Columns[5].ColumnName);

            seriesInvest.Points.DataBindXY(periodList, totInvestList); seriesInvest.Color = Color.FromArgb(17, 47, 65);
            seriesRawMaterial.Points.DataBindXY(periodList, totRawMaterialList); seriesRawMaterial.Color = Color.FromArgb(8, 148, 161);
            seriesEquipPrice.Points.DataBindXY(periodList, EquipPriceList); seriesEquipPrice.Color = Color.FromArgb(71, 171, 108);
            seriesEmployeePrice.Points.DataBindXY(periodList, totEmployeePriceList); seriesEmployeePrice.Color = Color.FromArgb(242, 177, 52);
            seriesNetProfit.Points.DataBindXY(periodList, totnetProfitList); seriesNetProfit.Color = Color.FromArgb(237, 85, 59);
            ChartFormatting(seriesInvest, seriesRawMaterial, seriesEquipPrice, seriesEmployeePrice, seriesNetProfit);

        }
        private void ChartFormatting(params System.Windows.Forms.DataVisualization.Charting.Series[] series)
        {
            foreach (var item in series)
            {
                item.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                chartTotalInvest.Series.Add(item);
            }
        }

        private void chartTotalInvest_MouseMove(object sender, MouseEventArgs e)
        {
            Point currentPosition = e.Location;
            if (previousPosition.HasValue && currentPosition == previousPosition)
            {
                return;
            }
            toolTipStackedColumn.RemoveAll();
            previousPosition = currentPosition;
            var hit = chartTotalInvest.HitTest(currentPosition.X, currentPosition.Y, System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint);
            if (hit.ChartElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint)
            {
                var yValue = (hit.Object as System.Windows.Forms.DataVisualization.Charting.DataPoint).YValues[0];
                toolTipStackedColumn.Show(hit.Series.Name + "\n"+ yValue, chartTotalInvest, new Point(currentPosition.X + 10, currentPosition.Y + 15));
            }
        }

    }
}
