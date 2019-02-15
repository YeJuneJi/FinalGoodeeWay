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

        List<VO.EquipmentVO> equipment = new List<VO.EquipmentVO>();

        private void FrmUsingOfEquipment_Load(object sender, EventArgs e)
        {
            crtEquipment.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd"; //"dd.MM-hh:mm";
            crtEquipment.ChartAreas[0].AxisY.LabelStyle.Format = "0,000원";
            crtEquipment.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = true;
            DAO.EquipmentDAO dAO = new DAO.EquipmentDAO();
            equipment = dAO.AllequipmentVOsList();
            crtEquipment.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            crtEquipment.Series[0].Points.DataBind(equipment, "purchaseDate", "purchasePrice", null);
            crtEquipment.Series[0].LegendText = "총액";



            //crtCircle.Series[0].IsValueShownAsLabel = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crtEquipment.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd"; //"dd.MM-hh:mm";
            crtEquipment.ChartAreas[0].AxisY.LabelStyle.Format = "0,000원";
            crtEquipment.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = true;
            crtEquipment.ChartAreas[0].AxisY.LabelAutoFitMinFontSize = 5;
            DAO.EquipmentDAO dAO = new DAO.EquipmentDAO();
            equipment = dAO.GroupingDateEquipment(dtpStartDate.Value, dtpEndDate.Value);
            crtEquipment.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            crtEquipment.Series[0].Points.DataBind(equipment, "purchaseDate", "purchasePrice", null);
            crtEquipment.Series[0].LegendText = "총액";

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


            // lblTotalExpenditure.Text = totalE.ToString();

            //var dateOf = from equip in equipment
            //             group equip by equip.PurchaseDate;



            // IEnumerable<VO.EquipmentVO> equi = from ew in equipment
            //                                  group ew by ew.PurchaseDate

            //foreach (var itemGroup in dateOf)
            //{
            //    DateTime date;
            //    float price =0;
            //    foreach (var item in itemGroup)
            //    {
            //        price += item.PurchasePrice;
            //    }

            //    var dates = from ee in itemGroup
            //                where ee.PurchaseDate = itemGroup.Key
            //                select 
            //crtCircle.Series[0].Points.AddXY(itemGroup.Key, price);

            //}


            // crtCircle.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            // crtCircle.Series[0].Points.DataBind(equipment, "purchaseDate", "purchasePrice", null);

            //crtCircle.Series[0].IsValueShownAsLabel = true;
        }
    }
}
