using GoodeeWay.DAO;
using GoodeeWay.Properties;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.InventoryBUS
{
    
    public partial class InventorySales : Form
    {
        List<InventoryTypeSalesVO> InventoryTypeList;
        List<InventoryTypeSalesVO> inventoryTypeSalesList;
        List<InventoryTypeSalesVO> InventoryList;
        List<InventoryTypeSalesVO> avgList;
        List<InventoryTypeSalesVO> avgList1;
        List<InventorySalesForChartVO> inventorySalesForChartVOs;
        string[] type1 = new string[] { "Bread", "Cheese", "Vegetable", "Sauce", "Additional", "Topping", "Side" };

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        public InventorySales()
        {
            this.Icon = Resources.C_Sharp_Logo_2_1;
            InitializeComponent();
            dtpStartDate.Value = dtpStartDate.Value.AddDays(-1);
            
            rdoMonth.Checked = rdoYear.Checked = rdoMonth.Visible = rdoYear.Visible = false;
            cmbType.Items.AddRange(type1);
            InventorySalesChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //panelImage.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "GWMain2.png");
        }

        /// <summary>
        /// 재고별판매량 검색버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var displayChart = new Display();
            InventorySalesChart.Series.Clear();

            #region 종류기준 검색
            if (rdoInventoryType.Checked == true)
            {

                #region 재고량
                InventorySalesChart.Series.Add(cmbType.Text + " 재고량");

                InventoryTypeList = displayChart.DisplayChart(new InventoryTypeChart()
                {
                    StartDate = new DateTime(dtpStartDate.Value.Year, dtpStartDate.Value.Month, dtpStartDate.Value.Day, 0, 0, 0),
                    EndDate = new DateTime(dtpEndDate.Value.Year, dtpEndDate.Value.Month, dtpEndDate.Value.Day, 23, 59, 59)
                }, cmbType.Text, false);

                InventorySalesChart.Series[cmbType.Text + " 재고량"].Points.DataBind(InventoryTypeList, "XAxis", "UseInventory", null);
                InventorySalesChart.Series[cmbType.Text + " 재고량"].Label = "#VALY";
                foreach (var item in InventorySalesChart.Series[cmbType.Text + " 재고량"].Points)
                {
                    item.Label = Math.Round(double.Parse(item.YValues[0].ToString()), 2) + "kg";
                }
                #endregion


                #region 판매량
                InventorySalesChart.Series.Add(cmbType.Text + " 판매량");

                this.inventoryTypeSalesList = new SaleRecordsDAO().InventorySaleRecordsTypeSelect(
                    new DateTime(dtpStartDate.Value.Year, dtpStartDate.Value.Month, dtpStartDate.Value.Day, 0, 0, 0),
                    new DateTime(dtpEndDate.Value.Year, dtpEndDate.Value.Month, dtpEndDate.Value.Day, 23, 59, 59), cmbType.Text);

                var result = from o in this.inventoryTypeSalesList
                             group o by o.XAxis into g
                             select new InventoryTypeSalesVO { XAxis = g.Key, UseInventory = g.Sum(c => c.UseInventory) };


                List<InventoryTypeSalesVO> inventoryTypeSalesList = new List<InventoryTypeSalesVO>();

                foreach (var item in InventoryTypeList)
                {
                    InventoryTypeSalesVO inventoryTypeSalesVO = new InventoryTypeSalesVO();
                    inventoryTypeSalesVO.XAxis = item.XAxis;
                    var i = from o in result where item.XAxis == o.XAxis select o.UseInventory;
                    if (i != null)
                    {
                        foreach (var item1 in i)
                        {
                            inventoryTypeSalesVO.UseInventory = item1;
                        }
                    }
                    else
                    {
                        inventoryTypeSalesVO.UseInventory = 0;
                    }
                    inventoryTypeSalesList.Add(inventoryTypeSalesVO);
                }


                InventorySalesChart.Series[cmbType.Text + " 판매량"].Points.DataBind(inventoryTypeSalesList, "XAxis", "UseInventory", null);
                InventorySalesChart.Series[cmbType.Text + " 판매량"].Label = "#VALY";
                foreach (var item in InventorySalesChart.Series[cmbType.Text + " 판매량"].Points)
                {
                    item.Label = Math.Round(double.Parse(item.YValues[0].ToString()), 2) + "kg";
                }
                #endregion

                var totInventoryTypeSalesList = from i1 in InventoryTypeList.AsEnumerable()
                                                join i2 in inventoryTypeSalesList.AsEnumerable()
                                                on i1.XAxis equals i2.XAxis
                                                select new InventorySalesForChartVO { XAxis = i1.XAxis, InventoryNum = i1.UseInventory, SalesNum = i2.UseInventory };
                inventorySalesForChartVOs = new List<InventorySalesForChartVO>(totInventoryTypeSalesList);
                AverageDisplay(inventorySalesForChartVOs);
                dgvDisplay(inventorySalesForChartVOs, rdoInventoryType.Checked);
            } 
            #endregion
            else//재고기준으로 검색할때
            {

                #region 재고량
                InventorySalesChart.Series.Add(cmbType.Text+ " 재고량");
                InventoryList = displayChart.DisplayChart(new InventoryChart()
                {
                    StartDate = new DateTime(dtpStartDate.Value.Year, dtpStartDate.Value.Month, dtpStartDate.Value.Day, 0, 0, 0),
                    EndDate = new DateTime(dtpEndDate.Value.Year, dtpEndDate.Value.Month, dtpEndDate.Value.Day, 23, 59, 59)
                }, cmbType.Text, rdoMonth.Checked);
                InventorySalesChart.Series[cmbType.Text + " 재고량"].Points.DataBind(InventoryList, "XAxis", "UseInventory", null);
                InventorySalesChart.Series[cmbType.Text + " 재고량"].Label = "#VALY";
                foreach (var item in InventorySalesChart.Series[cmbType.Text + " 재고량"].Points)
                {
                    item.Label = Math.Round(double.Parse(item.YValues[0].ToString()), 2) + "kg";
                }
                
                #endregion


                #region 판매량
                InventorySalesChart.Series.Add(cmbType.Text + " 판매량");
                IEnumerable<InventoryTypeSalesVO> result = null;
                if (rdoMonth.Checked)
                {
                    this.inventoryTypeSalesList = new SaleRecordsDAO().TypeSaleRecordsTypeSelect(
                                new DateTime(dtpStartDate.Value.Year, dtpStartDate.Value.Month, dtpStartDate.Value.Day, 0, 0, 0),
                                new DateTime(dtpEndDate.Value.Year, dtpEndDate.Value.Month, dtpEndDate.Value.Day, 23, 59, 59), cmbType.Text);

                    result = from o in this.inventoryTypeSalesList
                                 group o by o.XAxis.Substring(2, 5) into g
                                 select new InventoryTypeSalesVO { XAxis = g.Key, UseInventory = g.Sum(c => c.UseInventory) };
                    
                }
                else
                {
                    this.inventoryTypeSalesList = new SaleRecordsDAO().TypeSaleRecordsTypeSelect(
                                new DateTime(dtpStartDate.Value.Year, dtpStartDate.Value.Month, dtpStartDate.Value.Day, 0, 0, 0),
                                new DateTime(dtpEndDate.Value.Year, dtpEndDate.Value.Month, dtpEndDate.Value.Day, 23, 59, 59), cmbType.Text);

                    result = from o in this.inventoryTypeSalesList
                                 group o by o.XAxis.Substring(2, 2) into g
                                 select new InventoryTypeSalesVO { XAxis = g.Key, UseInventory = g.Sum(c => c.UseInventory) };
                    
                    
                }

                List<InventoryTypeSalesVO> inventoryTypeSalesList = new List<InventoryTypeSalesVO>();

                foreach (var item in InventoryList)
                {
                    InventoryTypeSalesVO inventoryTypeSalesVO = new InventoryTypeSalesVO();
                    inventoryTypeSalesVO.XAxis = item.XAxis;
                    var i = from o in result where item.XAxis == o.XAxis select o.UseInventory;
                    if (i != null)
                    {
                        foreach (var item1 in i)
                        {
                            inventoryTypeSalesVO.UseInventory = item1;
                        }
                    }
                    else
                    {
                        inventoryTypeSalesVO.UseInventory = 0;
                    }
                    inventoryTypeSalesList.Add(inventoryTypeSalesVO);
                }


                InventorySalesChart.Series[cmbType.Text + " 판매량"].Points.DataBind(inventoryTypeSalesList, "XAxis", "UseInventory", null);
                InventorySalesChart.Series[cmbType.Text + " 판매량"].Label = "#VALY";
                foreach (var item in InventorySalesChart.Series[cmbType.Text + " 판매량"].Points)
                {
                    item.Label = Math.Round(double.Parse(item.YValues[0].ToString()), 2) + "kg";
                }
                #endregion
                var totInventoryTypeSalesList = from i1 in InventoryList.AsEnumerable()
                                                join i2 in inventoryTypeSalesList.AsEnumerable()
                                                on i1.XAxis equals i2.XAxis
                                                select new InventorySalesForChartVO { XAxis = i1.XAxis, InventoryNum = i1.UseInventory, SalesNum = i2.UseInventory };
                inventorySalesForChartVOs = new List<InventorySalesForChartVO>(totInventoryTypeSalesList);
                AverageDisplay(inventorySalesForChartVOs);
                dgvDisplay(inventorySalesForChartVOs, rdoInventoryType.Checked);

            }



            lblStartDate.Text = dtpStartDate.Value.ToShortDateString();
            lblEndDate.Text = dtpEndDate.Value.ToShortDateString();
            


        }

        /// <summary>
        /// 각 값들의 평균값을 표시하는 메서드
        /// </summary>
        /// <param name="List">조회 시 각 x축 값을 얻어오기 위한 List</param>
        private void AverageDisplay(List<InventorySalesForChartVO> List)
        {
            InventorySalesChart.Series.Add("재고량평균");
            InventorySalesChart.Series.Add("판매량평균");
            avgList = new List<InventoryTypeSalesVO>();
            avgList1 = new List<InventoryTypeSalesVO>();
            
            foreach (var item in List)//평균 라인을 긋기 위해 x 값은 재고명을 다 넣어주고, y값은 모두 평균값으로 입력
            {
                double inventoryNum = (double)((from avgList in List select avgList.InventoryNum).Sum());
                double inventoryNumCount = (double)((from avgList in List where avgList.InventoryNum != 0 select avgList.InventoryNum).Count());
                InventoryTypeSalesVO inventoryTypeSalesVO = new InventoryTypeSalesVO()
                {
                    XAxis = item.XAxis,
                    UseInventory = (float)Math.Round(inventoryNum/ inventoryNumCount, 2)
                };
                avgList.Add(inventoryTypeSalesVO);
            }
            InventorySalesChart.Series["재고량평균"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            InventorySalesChart.Series["재고량평균"].Points.DataBind(avgList, "XAxis", "UseInventory", null);
            try
            {
                InventorySalesChart.Series["재고량평균"].Points[0].Label = "재고량 평균 : "+avgList[0].UseInventory+"kg";
                InventorySalesChart.Series["재고량평균"].Points[0].LabelForeColor = Color.Black;
                InventorySalesChart.Series["재고량평균"].Color = Color.FromArgb(65,140,240);
            }
            catch (ArgumentOutOfRangeException)
            {
            }




            foreach (var item in List)//평균 라인을 긋기 위해 x 값은 재고명을 다 넣어주고, y값은 모두 평균값으로 입력
            {
                double salesNum = (double)((from avgList1 in List select avgList1.SalesNum).Sum());
                double salesNumCount = (double)((from avgList1 in List where avgList1.SalesNum !=0 select avgList1.SalesNum).Count());

                InventoryTypeSalesVO inventoryTypeSalesVO = new InventoryTypeSalesVO()
                {
                    XAxis = item.XAxis,
                    UseInventory = (float)Math.Round(salesNum/salesNumCount, 2)
                };
                avgList1.Add(inventoryTypeSalesVO);
            }
            InventorySalesChart.Series["판매량평균"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            InventorySalesChart.Series["판매량평균"].Points.DataBind(avgList1, "XAxis", "UseInventory", null);
            try
            {
                InventorySalesChart.Series["판매량평균"].Points[avgList1.Count-1].Label = "판매량평균 : " + avgList1[0].UseInventory + "kg";
                InventorySalesChart.Series["판매량평균"].Points[avgList1.Count-1].LabelForeColor = Color.Black;
                InventorySalesChart.Series["판매량평균"].Color = Color.FromArgb(252, 180, 65);

            }
            catch (ArgumentOutOfRangeException)
            {
            }

        }

        /// <summary>
        /// 기준에 따른 데이터를 DataGridView 에 표시함.
        /// </summary>
        /// <param name="List">종류,재고 기준에 따라 표시할 데이터에 대한 List </param>
        /// <param name="checked">종류, 재고 체크여부</param>
        private void dgvDisplay(List<InventorySalesForChartVO> List, bool @checked)
        {
            double inventoryNum = (double)((from avgList in List select avgList.InventoryNum).Sum());
            double inventoryNumCount = (double)((from avgList in List where avgList.InventoryNum != 0 select avgList.InventoryNum).Count());
            double salesNum = (double)((from avgList1 in List select avgList1.SalesNum).Sum());
            double salesNumCount = (double)((from avgList1 in List where avgList1.SalesNum != 0 select avgList1.SalesNum).Count());

            if (List.Count >0)
            {
                List.Add(new InventorySalesForChartVO()
                {
                    XAxis = "평균",
                    InventoryNum = (float)Math.Round((inventoryNum / inventoryNumCount), 2),
                    SalesNum = (float)Math.Round((salesNum / salesNumCount), 2)
                });
                List.Add(new InventorySalesForChartVO()
                {
                    XAxis = "총합",
                    InventoryNum = (float)inventoryNum,
                    SalesNum= (float)salesNum
                });
            }
            dgvData.DataSource = List;
            if (@checked)
            {
                dgvData.Columns["XAxis"].HeaderText = "재고명";
                dgvData.Columns["InventoryNum"].HeaderText = "재고량";
                dgvData.Columns["SalesNum"].HeaderText = "판매량";
                
            }
            else
            {
                dgvData.Columns["XAxis"].HeaderText = "날짜";
                dgvData.Columns["InventoryNum"].HeaderText = "재고량"; 
                dgvData.Columns["SalesNum"].HeaderText = "판매량"; 
            }
        }
        /// <summary>
        /// 날짜 선택 시 시작날짜가 종료날짜보다 작게 만드는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value>dtpEndDate.Value)
            {
                MessageBox.Show("종료날짜보다 클 수 없습니다.");
                dtpStartDate.Value= dtpEndDate.Value.AddDays(-1);
            }
        }
        /// <summary>
        /// 날짜 선택 시 종료날짜가 시작날짜보다 작아질 때 시작날짜를 종료날짜 전날로 바꾸는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 종류 선택 시 연월 라디오 버튼 숨기기, 종류 기준 콤보박스 내용 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoInventoryType_CheckedChanged(object sender, EventArgs e)
        {
            rdoMonth.Checked = rdoYear.Checked = rdoMonth.Visible = rdoYear.Visible = false;
            cmbType.Items.Clear();
            cmbType.Items.AddRange(type1);
            cmbType.Text = cmbType.Items[0].ToString();

        }
        /// <summary>
        /// 재고 선택시 연월 라디오 버튼 보이기, 재고 기준 콤보박스 내용 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 종료 버튼 클릭 시 차트 폼 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 패널 클릭 다운 시 창 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 다른 컨트롤에 묶여있을 수 있을 수 있으므로 마우스캡쳐 해제
                ReleaseCapture();

                // 타이틀 바의 다운 이벤트처럼 보냄
                SendMessage(this.Handle, WM_NLBUTTONDOWN, HT_CAPTION, 0);
            }

            base.OnMouseDown(e);
        }
    }

    #region 차트 interface 구조
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
            return new InventorySalesDAO().InventorySalesSelect(InventoryName, chart, monthYear);
        }
    }

    #endregion

}
