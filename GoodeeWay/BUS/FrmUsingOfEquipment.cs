using GoodeeWay.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace GoodeeWay.BUS
{

public partial class FrmUsingOfEquipment : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        public FrmUsingOfEquipment()
        {
            InitializeComponent();
            this.Icon = Resources.C_Sharp_Logo_2_1;
        }
        private DataTable dataTable; //그리드뷰에 연결시킬 데이터 테이블
        List<VO.EquipmentVO> equipment = new List<VO.EquipmentVO>();
        ToolTip toolTipColumn = new ToolTip();
        Point? previousPosition = null;

        private void FrmUsingOfEquipment_Load(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.Close_Window_32px.ToImage();
            dgvtotalList.AllowUserToAddRows = false;
            crtEquipment.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            crtEquipment.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            crtEquipment.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            //crtEquipment.ChartAreas[0].AxisY.Interval = 300000;
            //crtEquipment.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM-hh:mm"; //"dd.MM-hh:mm";
            crtEquipment.ChartAreas[0].AxisY.LabelStyle.Format = "0,000원";
            crtEquipment.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = true;
            crtEquipment.ChartAreas[0].AxisX.ScaleBreakStyle.Enabled = true;

            panelImage.BringToFront();
            panelImage.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "NewGooDeeWay.png");
            DAO.EquipmentDAO dAO = new DAO.EquipmentDAO();

            var firstDayOfMonth_year = DateTime.Now.Year;
            var firstDayOfMonth_month = DateTime.Now.Month;
            dtpStartDate.Value = new DateTime(firstDayOfMonth_year, firstDayOfMonth_month, 1);

            equipment = dAO.EquipmentByDate(dtpStartDate.Value, DateTime.Now);
            crtEquipment.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            crtEquipment.Series[0].Points.DataBind(equipment, "PurchaseDate", "purchasePrice", null);
            crtEquipment.Series[0].LegendText = "총액";
            DetailInfo();

            dgvtotalList.DataSource = SetDataTable(dAO.EquipmentByDate(dtpStartDate.Value, dtpEndDate.Value));
            

        }

        /// <summary>
        /// 검색하기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            DAO.EquipmentDAO dAO = new DAO.EquipmentDAO();
            equipment = dAO.GroupingDateEquipment(dtpStartDate.Value, dtpEndDate.Value);
            crtEquipment.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            crtEquipment.Series[0].Points.DataBind(equipment, "purchaseDate", "purchasePrice", null);
            

            DetailInfo();
            dgvtotalList.DataSource = SetDataTable(dAO.EquipmentByDate(dtpStartDate.Value, dtpEndDate.Value));
        }
        /// <summary>
        /// 디테일 정보를 출력해주는 메서드
        /// </summary>
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
        }

        /// <summary>
        /// 그리드뷰에 들어갈 datatable로 변형
        /// </summary>
        /// <param name="equipmentLst"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 윈도우 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_MouseDown(object sender, MouseEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 막대그래프 툴팁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crtEquipment_MouseMove(object sender, MouseEventArgs e)
        {
            Point currentPosition = e.Location;
            if (previousPosition.HasValue && currentPosition == previousPosition)
            {
                return;
            }
            toolTipColumn.RemoveAll();
            previousPosition = currentPosition;
            var hit = crtEquipment.HitTest(currentPosition.X, currentPosition.Y, System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint);
            if (hit.ChartElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint)
            {
                var yValue = String.Format("{0:#,###}원", Convert.ToInt32((hit.Object as System.Windows.Forms.DataVisualization.Charting.DataPoint).YValues[0]));
                toolTipColumn.Show( yValue, crtEquipment, new Point(currentPosition.X + 10, currentPosition.Y + 15));
            }
        }
    }
}
