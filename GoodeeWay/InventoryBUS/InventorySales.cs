using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.InventoryBUS
{
    
    public partial class InventorySales : Form
    {
        List<InventoryTypeSalesVO> lst;
        List<InventoryTypeSalesVO> avgList;
        string[] type1 = new string[] { "Bread", "Cheese", "Vegetable", "Sauce", "Additional", "Topping", "Side" };
        public InventorySales()
        {
            InitializeComponent();
            dtpStartDate.Value = dtpStartDate.Value.AddDays(-1);
            InventorySalesChart.Series.Add("종류기준");
            InventorySalesChart.Series.Add("평균");
            rdoMonth.Checked = rdoYear.Checked = rdoMonth.Visible = rdoYear.Visible = false;
            cmbType.Items.AddRange(type1);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var displayChart = new Display();
            if (rdoInventoryType.Checked == true)
            {
                lst = displayChart.DisplayChart(new InventoryTypeChart()
                { StartDate = dtpStartDate.Value, EndDate = dtpEndDate.Value }, cmbType.Text);
                
                InventorySalesChart.Series["종류기준"].Points.DataBind(lst, "InventoryName", "UseInventory", null);
                dgvData.DataSource = lst;
                avgList = new List<InventoryTypeSalesVO>();
                foreach (var item in lst)
                {
                    InventoryTypeSalesVO inventoryTypeSalesVO = new InventoryTypeSalesVO()
                    {
                        InventoryName = item.InventoryName,
                        UseInventory = (int)(from avgList in lst select avgList.UseInventory).Average()
                    };

                    
                    avgList.Add(inventoryTypeSalesVO);
                }
                InventorySalesChart.Series["평균"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                InventorySalesChart.Series["평균"].Points.DataBind(avgList, "InventoryName", "UseInventory", null);
            }
            else
            {
                displayChart.DisplayChart(new InventoryChart(), cmbType.Text);
            }
            lblStartDate.Text = dtpStartDate.Value.ToShortDateString();
            lblEndDate.Text = dtpEndDate.Value.ToShortDateString();
            


        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value>dtpEndDate.Value)
            {
                MessageBox.Show("종료날짜보다 클 수 없습니다.");
                dtpStartDate.Value= dtpEndDate.Value.AddDays(-1);
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value>dtpEndDate.Value)
            {
                dtpStartDate.Value=dtpEndDate.Value.AddDays(-1);
            }
        }

        #region 최근기간 설정
        private void btn1Week_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpEndDate.Value.AddDays(-7);
        }

        private void btn2Week_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpEndDate.Value.AddDays(-14);
        }

        private void btn3Week_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpEndDate.Value.AddDays(-21);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpEndDate.Value.AddMonths(-1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpEndDate.Value.AddMonths(-2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpEndDate.Value.AddMonths(-3);
        }

        private void btn1Year_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpEndDate.Value.AddYears(-1);
        }

        private void btn2Year_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpEndDate.Value.AddYears(-2);
        }

        private void btn3Year_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpEndDate.Value.AddYears(-3);
        }
        #endregion


        private void rdoInventoryType_CheckedChanged(object sender, EventArgs e)
        {
            rdoMonth.Checked = rdoYear.Checked = rdoMonth.Visible=rdoYear.Visible= false;
            cmbType.Items.Clear();
            cmbType.Items.AddRange(type1);
            cmbType.Text = cmbType.Items[0].ToString();

        }

        private void rdoInventory_CheckedChanged(object sender, EventArgs e)
        {
            rdoMonth.Checked=rdoMonth.Visible=rdoYear.Visible= true;
            cmbType.Items.Clear();

            foreach (var item in new InventoryTypeDAO().InventoryNameSelect())
            {
                cmbType.Items.Add(item);
            }
            cmbType.Text = cmbType.Items[0].ToString();
        }
    }
    class Display
    {
        private IChart chart;
        public List<InventoryTypeSalesVO> DisplayChart(IChart chart, string type)
        {
            this.chart = chart;
            return this.chart.Chart(type, this.chart);
        }
    }
    interface IChart
    {
        List<InventoryTypeSalesVO> Chart(string type, IChart chart);
    }
    class InventoryTypeChart : IChart
    {
        private DateTime startDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private DateTime endDate;
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public List<InventoryTypeSalesVO> Chart(string type, IChart chart)
        {
            return new InventorySalesDAO().InventorySalesSelect(type, chart);
        }
    }
    class InventoryChart : IChart
    {
        public List<InventoryTypeSalesVO> Chart(string type, IChart chart)
        {
            throw new NotImplementedException();
        }
    }
    

}
