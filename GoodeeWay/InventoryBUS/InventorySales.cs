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
        List<InventoryTypeSalesVO> InventoryTypeList;
        List<InventoryTypeSalesVO> InventoryList;
        List<InventoryTypeSalesVO> avgList;
        string[] type1 = new string[] { "Bread", "Cheese", "Vegetable", "Sauce", "Additional", "Topping", "Side" };
        public InventorySales()
        {
            InitializeComponent();
            dtpStartDate.Value = dtpStartDate.Value.AddDays(-1);
            
            rdoMonth.Checked = rdoYear.Checked = rdoMonth.Visible = rdoYear.Visible = false;
            cmbType.Items.AddRange(type1);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var displayChart = new Display();
            InventorySalesChart.Series.Clear();
            
            if (rdoInventoryType.Checked == true)
            {
                InventorySalesChart.Series.Add("종류기준");
                InventoryTypeList = displayChart.DisplayChart(new InventoryTypeChart()
                { StartDate = dtpStartDate.Value, EndDate = dtpEndDate.Value.AddHours(1) }, cmbType.Text, false);

                InventorySalesChart.Series["종류기준"].Points.DataBind(InventoryTypeList, "InventoryName", "UseInventory", null);
                InventorySalesChart.Series["종류기준"].Label = "#VALY";
                foreach (var item in InventorySalesChart.Series["종류기준"].Points)
                {
                    item.Label = Math.Round(double.Parse(item.YValues[0].ToString()), 2)+"kg";
                }


                AverageDisplay(InventoryTypeList);
                dgvDisplay(InventoryTypeList, rdoInventoryType.Checked);
            }
            else
            {
                InventorySalesChart.Series.Add(cmbType.Text);
                InventoryList = displayChart.DisplayChart(new InventoryChart()
                { StartDate = dtpStartDate.Value, EndDate = dtpEndDate.Value.AddHours(1) }, cmbType.Text, rdoMonth.Checked);
                InventorySalesChart.Series[cmbType.Text].Points.DataBind(InventoryList, "InventoryName", "UseInventory", null);
                InventorySalesChart.Series[cmbType.Text].Label = "#VALY";
                foreach (var item in InventorySalesChart.Series[cmbType.Text].Points)
                {
                    item.Label = Math.Round(double.Parse(item.YValues[0].ToString()), 2) + "kg";
                }
                AverageDisplay(InventoryList);
                dgvDisplay(InventoryList, rdoInventoryType.Checked);
            }
            lblStartDate.Text = dtpStartDate.Value.ToShortDateString();
            lblEndDate.Text = dtpEndDate.Value.ToShortDateString();
            


        }

        private void AverageDisplay(List<InventoryTypeSalesVO> List)
        {
            InventorySalesChart.Series.Add("평균");
            avgList = new List<InventoryTypeSalesVO>();
            //sum = 0;
            //count = 0;
            //foreach (var item in List)
            //{
            //    sum += item.UseInventory;
            //}
            //count = new InventorySalesDAO().InventorySalesCountSelect(dtpStartDate.Value, dtpEndDate.Value, cmbType.Text);
            
            foreach (var item in List)//평균 라인을 긋기 위해 x 값은 재고명을 다 넣어주고, y값은 모두 평균값으로 입력
            {
                double num = (double)((from avgList in List select avgList.UseInventory).Average());
                InventoryTypeSalesVO inventoryTypeSalesVO = new InventoryTypeSalesVO()
                {
                    InventoryName = item.InventoryName,
                    UseInventory = (float)Math.Round(num,2)
                };
                avgList.Add(inventoryTypeSalesVO);
            }
            InventorySalesChart.Series["평균"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            InventorySalesChart.Series["평균"].Points.DataBind(avgList, "InventoryName", "UseInventory", null);
            try
            {
                InventorySalesChart.Series["평균"].Points[0].Label = "평균 : "+avgList[0].UseInventory+"kg";
                InventorySalesChart.Series["평균"].Points[0].LabelForeColor = Color.Red;
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void dgvDisplay(List<InventoryTypeSalesVO> List, bool @checked)
        {
            float sum = 0;
            foreach (var item in List)
            {
                sum += item.UseInventory;
            }


            if (List.Count >0)
            {
                List.Add(new InventoryTypeSalesVO() { InventoryName = "평균", UseInventory = (float)Math.Round((sum / List.Count()),2) });
                List.Add(new InventoryTypeSalesVO() { InventoryName = "총합", UseInventory = sum }); 
            }
            dgvData.DataSource = List;
            if (@checked)
            {
                dgvData.Columns["InventoryName"].HeaderText = "재고명";
                dgvData.Columns["UseInventory"].HeaderText = "사용수량";
                
            }
            else
            {
                dgvData.Columns["InventoryName"].HeaderText = "날짜";
                dgvData.Columns["UseInventory"].HeaderText = "사용수량"; 
            }

            

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


        #region 종류,재고 기준 설정
        private void rdoInventoryType_CheckedChanged(object sender, EventArgs e)
        {
            rdoMonth.Checked = rdoYear.Checked = rdoMonth.Visible = rdoYear.Visible = false;
            cmbType.Items.Clear();
            cmbType.Items.AddRange(type1);
            cmbType.Text = cmbType.Items[0].ToString();

        }

        private void rdoInventory_CheckedChanged(object sender, EventArgs e)
        {
            rdoMonth.Checked = rdoMonth.Visible = rdoYear.Visible = true;
            cmbType.Items.Clear();

            foreach (var item in new InventoryTypeDAO().InventoryNameSelect())
            {
                cmbType.Items.Add(item);
            }
            cmbType.Text = cmbType.Items[0].ToString();
        } 
        #endregion
    }


    class Display
    {
        private IChart chart;
        public List<InventoryTypeSalesVO> DisplayChart(IChart chart, string type, bool monthYear)
        {
            this.chart = chart;
            return this.chart.Chart(this.chart, type, monthYear);
        }
    }
    interface IChart
    {

        List<InventoryTypeSalesVO> Chart(IChart chart, string type, bool monthYear);
    }
    //-----------------------------------------------------------------------
    class InventoryTypeChart : IChart//종류기준일 때 차트 출력을 위한 class
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

        public List<InventoryTypeSalesVO> Chart(IChart chart, string type, bool monthYear)
        {
            return new InventorySalesDAO().InventoryTypeSelect(type, chart);
        }
        
    }
    //-----------------------------------------------------------------------
    class InventoryChart : IChart//재고기준일 때 차트 출력을 위한 class
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
        public List<InventoryTypeSalesVO> Chart(IChart chart, string InventoryName, bool monthYear)
        {
            return new InventorySalesDAO().InventorySalesSelect(InventoryName, chart,monthYear);
        }
    }
    

}
