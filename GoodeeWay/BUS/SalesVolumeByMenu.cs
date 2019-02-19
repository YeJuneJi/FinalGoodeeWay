using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.VO;

namespace GoodeeWay.BUS
{
    public partial class SalesVolumeByMenu : Form
    {
        public SalesVolumeByMenu()
        {
            InitializeComponent();
        }

        List<SaleRecordsVO> saleRecordsLst;

        private void SalesVolumeByMenu_Load(object sender, EventArgs e)
        {
            var firstDayOfMonth_year = DateTime.Now.Year;
            var firstDayOfMonth_month = DateTime.Now.Month;
            dtpStartDate.Value = new DateTime(firstDayOfMonth_year, firstDayOfMonth_month, 1);

            saleRecordsLst = new DAO.SaleRecordsDAO().SelectSaleRacordsByPeriod(dtpStartDate.Value, dtpEndDate.Value);


            crtSalesVolumeByDate.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (var item in saleRecordsLst)
            {
                textBox1.Text += item.SalesNo + "\t" + item.SalesDate + "\t" + item.SalesitemName + "\t" + item.SalesPrice;
            }
            //crtSalesVolumeByDate.Series[0].Points.DataBind(saleRecordsLst,)
        }
    }
}
