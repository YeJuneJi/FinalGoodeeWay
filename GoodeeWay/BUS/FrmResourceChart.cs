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
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{
    public partial class FrmResourceChart : Form
    {
        DataTable totRsrcTab;
        ArrayList periodList;
        ArrayList totInvestList;
        public FrmResourceChart(DataTable totRsrcTab)
        {
            InitializeComponent();
            this.totRsrcTab = totRsrcTab;
            periodList = new ArrayList();
            totInvestList = new ArrayList();
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
            }
            
            chartTotalInvest.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chartTotalInvest.Titles.Add("통계");
            chartTotalInvest.Titles[0].Font = new Font(new FontFamily(GenericFontFamilies.SansSerif), 20, FontStyle.Bold);
            chartTotalInvest.Series[0].IsValueShownAsLabel = false;
            chartTotalInvest.Series[0].IsVisibleInLegend = false;
            chartTotalInvest.Series[0].Points.DataBindXY(periodList, totInvestList);
            chartTotalInvest.Series[0].Color = Color.Orange;

        }
    }
}
