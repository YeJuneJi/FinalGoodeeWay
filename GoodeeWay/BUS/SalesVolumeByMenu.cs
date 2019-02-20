using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GoodeeWay.VO;
using Newtonsoft.Json;

namespace GoodeeWay.BUS
{
    public partial class SalesVolumeByMenu : Form
    {
        public SalesVolumeByMenu()
        {
            InitializeComponent();
        }

        List<SaleRecordsVO> saleRecordsLst;
        Hashtable hashtableForMenu;


        private void SalesVolumeByMenu_Load(object sender, EventArgs e)
        {
            
            var firstDayOfMonth_year = DateTime.Now.Year;
            var firstDayOfMonth_month = DateTime.Now.Month;
            dtpStartDate.Value = new DateTime(firstDayOfMonth_year, firstDayOfMonth_month, 1);

            var tempdate = new DateTime(2000, 1, 1);

            saleRecordsLst = new DAO.SaleRecordsDAO().SelectSaleRacordsByPeriod(dtpStartDate.Value, dtpEndDate.Value);
            crtSalesVolumeByDate.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            var hash = HashtableForMenuCount(saleRecordsLst);

            foreach (var item in hash)
            {
                DictionaryEntry de = (DictionaryEntry)item;
                textBox1.Text += de.Key + " : " + de.Value+ "\r\n";
            }

            crtSalesVolumeByDate.Series[0].Points.DataBindXY(hash.Keys, hash.Values);
            crtSalesVolumeByDate.Series[0].Points[0].Color = Color.Red;

            crtAllMenuPercent.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            crtAllMenuPercent.Series[0].Points.DataBindXY(hash.Keys, hash.Values);
            //crtAllMenuPercent.Series[0].IsValueShownAsLabel = false;
            crtAllMenuPercent.Legends[0].Alignment = StringAlignment.Center;
            crtAllMenuPercent.Series[0].Label = "#VALY (#PERCENT)";
            //crtAllMenuPercent.Series[0]["PieLabelStyle"] = "Outside";
            crtAllMenuPercent.Series[0].LegendText = "#VALX";


            //crtSalesVolumeByDate.Series[0].Points.DataBind(saleRecordsLst,)
            
        }
        /// <summary>
        /// 리스트를 hashTable화 시킨다. Key : MenuName, Values :  Sales volume by menu
        /// </summary>
        /// <param name="saleRecordsLst"></param>
        /// <returns></returns>
        private Hashtable HashtableForMenuCount(List<SaleRecordsVO> saleRecordsLst)
        {//HashTable을 만들고 메뉴별 판매량을 count시킨다.

            List<SalesMenuVO> salesMenus;
            salesMenus = new DAO.SalesMenuDAO().OutPutAllMenus();

            hashtableForMenu = new Hashtable();
            foreach (var item in salesMenus) //hashTable에 메뉴를 등록하고 count수를 초기화 시킨다.
            {
                hashtableForMenu.Add(item.MenuName, (int)0);
            }
            
            //foreach (var item in hashtableForMenu)
            //{
            //    DictionaryEntry de = (DictionaryEntry)item;
            //    textBox1.Text += de.Key + " : " + de.Value+ "\r\n";
            //}
            foreach (var item in saleRecordsLst)
            {
                //textBox1.Text += item.SalesNo + "\t" + item.SalesDate + "\t" + item.SalesitemName + "\t" + item.SalesPrice;
                var itemJson = JsonConvert.DeserializeObject<RealMenuVO>(item.SalesitemName);
                foreach (var byMenu in itemJson.RealMenu)
                {
                    //textBox1.Text += byMenu.Menu.MenuName + "\t";
                    hashtableForMenu[byMenu.Menu.MenuName] = (int)hashtableForMenu[byMenu.Menu.MenuName] + 1;
                }
                //foreach (var item in test2)
                //{
                //    RealMenuVO rv = JsonConvert.DeserializeObject<RealMenuVO>(item.SitemName);
                //    foreach (var real in rv.RealMenu)
                //    {
                //        tbxResult.Text += "메뉴이름 : " + real.Menu.MenuName + "\r\n";
                //        foreach (var item2 in real.MenuDetailList)
                //        {
                //            tbxResult.Text += "재료이름 : " + item2.InventoryName + "\r\n";
                //        }
                //    }
                //}
            }

            return hashtableForMenu;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            saleRecordsLst = new DAO.SaleRecordsDAO().SelectSaleRacordsByPeriod(dtpStartDate.Value, dtpEndDate.Value);
            var hash = HashtableForMenuCount(saleRecordsLst);
            crtSalesVolumeByDate.Series[0].Points.DataBindXY(hash.Keys, hash.Values);
        }

        private void crtAllMenuPercent_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            if (crtAllMenuPercent.HitTest(e.X, e.Y).ChartElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint)
            {
                //var result = Math.Round((quizCourse[crtAllMenuPercent.HitTest(e.X, e.Y).PointIndex].Respondent / 150.0 * 100), 2);
                //MessageBox.Show(hashtableForMenu[crtAllMenuPercent.HitTest(e.X, e.Y).ChartArea.Name]);
                //MessageBox.Show(crtAllMenuPercent.HitTest(e.X, e.Y).Series.());
                //MessageBox.Show(crtAllMenuPercent.Series[0].); 
                //var re = Math.Round();
                //toolTip.Show(result + "%", crtAllMenuPercent, new Point(e.X, e.Y));
            }
        }
    }
}
