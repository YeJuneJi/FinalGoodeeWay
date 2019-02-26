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
        DataTable datatableForMenu;
        Division divisionMenu;
        private void SalesVolumeByMenu_Load(object sender, EventArgs e)
        {
            var firstDayOfMonth_year = DateTime.Now.Year;
            var firstDayOfMonth_month = DateTime.Now.Month;
            dtpStartDate.Value = new DateTime(firstDayOfMonth_year, firstDayOfMonth_month, 1);

            var tempdate = new DateTime(2000, 1, 1);

            saleRecordsLst = new DAO.SaleRecordsDAO().SelectSaleRacordsByPeriod(dtpStartDate.Value, dtpEndDate.Value);
            crtSalesVolumeByDate.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            crtSalesVolumeByDate.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            crtSalesVolumeByDate.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            dgvRank.AllowUserToAddRows = false;

            //

            if (rbSandwich.Checked)
            {
                divisionMenu = Division.샌드위치;
            }
            else if (rbSalad.Checked)
            {
                divisionMenu = Division.찹샐러드;
            }
            else if (rbSide.Checked)
            {
                divisionMenu = Division.사이드;
            }
            else
            {
                divisionMenu = Division.음료;
            }


            var hash = HashtableForMenuCount(saleRecordsLst, divisionMenu);
            crtSalesVolumeByDate.Series[0].Points.DataBindXY(hash.Keys, hash.Values);

            var top5 = Top5Hash(MenusSelect(divisionMenu));
            CircleChartDisplay(top5);

            dgvRank.DataSource = hash;
            DataTable data;
            data = SelectMenuForTable(hash);

            dgvRank.DataSource = SelectMenuForTable(hash);
            dgvRank.Sort(dgvRank.Columns[1], ListSortDirection.Descending);
        }

        private DataTable SelectMenuForTable(Hashtable hash)
        {
            DataTable data;
            data = new DataTable();
            data.Columns.Add("메뉴 명");
            data.Columns.Add("판매량");

            foreach (var item in hash)
            {
                DictionaryEntry de = (DictionaryEntry)item;
                data.Rows.Add(de.Key, de.Value);
            }
            return data;
        }

        /// <summary>
        /// pie chart에 기본 값과 datadinding 시켜준다
        /// </summary>
        /// <param name="hash">hashtable type</param>
        private void CircleChartDisplay(Hashtable hash)
        {

            //crtSalesVolumeByDate.Series[0].Points[0].Color = Color.Red;

            crtAllMenuPercent.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            crtAllMenuPercent.Series[0].Points.DataBindXY(hash.Keys, hash.Values);
            crtAllMenuPercent.Legends[0].Alignment = StringAlignment.Center;
            crtAllMenuPercent.Series[0].Label = "#VALX (#PERCENT)";
            crtAllMenuPercent.Series[0].LegendText = "#VALX :#VALY (#PERCENT)";

        }

        /// <summary>
        /// 리스트를 hashTable화 시킨다. Key : MenuName, Values :  Sales volume by menu
        /// </summary>
        /// <param name="saleRecordsLst"></param>
        /// <returns></returns>
        private Hashtable HashtableForMenuCount(List<SaleRecordsVO> saleRecordsLst, Division divisionMenu)
        {//HashTable을 만들고 메뉴별 판매량을 count시킨다.

            int totalSum = 0;
            IEnumerable<SalesMenuVO> selectedMenu;

            selectedMenu = MenusSelect(divisionMenu);

            hashtableForMenu = new Hashtable();

            foreach (var item in selectedMenu) //hashTable에 메뉴를 등록하고 count수를 초기화 시킨다.
            {
                hashtableForMenu.Add(item.MenuName, (int)0);
            }


            foreach (var item in saleRecordsLst)
            {
                var itemJson = JsonConvert.DeserializeObject<RealMenuVO>(item.SalesitemName);
                foreach (var byMenu in itemJson.RealMenu)
                {
                    if (int.Parse(byMenu.Menu.Division) == (int)divisionMenu)
                    {
                        if (hashtableForMenu.ContainsKey(byMenu.Menu.MenuName))
                        {
                            hashtableForMenu[byMenu.Menu.MenuName] = (int)hashtableForMenu[byMenu.Menu.MenuName] + 1;
                        }
                        
                        
                        totalSum += 1;
                    }
                }
            }
            

            //, Percent = Math.Round(((int)hashtableForMenu[item.MenuName] /(float)totalSum), 2)

            return hashtableForMenu;

        }
        /// <summary>
        /// 메뉴종류에따라 분류된 데이터
        /// </summary>
        /// <param name="divisionMenu"></param>
        /// <returns></returns>
        private IEnumerable<SalesMenuVO> MenusSelect(Division divisionMenu)
        {
            List<SalesMenuVO> salesMenus = new DAO.SalesMenuDAO().OutPutAllMenus();


            var selectedMenu = from menu in salesMenus
                               where menu.Division == (int)divisionMenu
                               select menu;
            return selectedMenu;
        }

        //
        private Hashtable Top5Hash(IEnumerable<SalesMenuVO> selectedMenu)
        {
            List<ByMenuVO> tempMenuLst = new List<ByMenuVO>();

            //gridView의 출력을 위해 List에 담음(top5를 위한 리스트이기도함)
            foreach (var item in selectedMenu)
            {
                tempMenuLst.Add(new ByMenuVO()
                {
                    MenuName = item.MenuName,
                    Amount = (int)hashtableForMenu[item.MenuName]
                });


                //  tempMenuLst.Add(new ByMenuVO() {MenuName = item.MenuName ,Amount = (int)hashtableForMenu[item.MenuName], Percent = Math.Round(((int)hashtableForMenu[item.MenuName] / (float)totalSum)*100, 2) });
            }

            var top5Rows = (from row in tempMenuLst
                            orderby row.Amount descending
                            select row).Take(5);
            Hashtable top5Hash = new Hashtable();
            foreach (var item in top5Rows)
            {
                // MessageBox.Show(item.MenuName+"\t"+item.Amount+ "\t" +item.Percent);
                top5Hash.Add(item.MenuName, item.Amount);
            }

            int etcAmount = 0;
            foreach (var item in tempMenuLst)
            {
                if (top5Hash.ContainsKey(item.MenuName))
                {
                    continue;
                }
                else
                {
                    etcAmount += item.Amount;
                }

            }
            if (etcAmount != 0)
            {
                top5Hash.Add("기타", etcAmount);
            }



            return top5Hash;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbSandwich.Checked)
            {
                divisionMenu = Division.샌드위치;
            }
            else if (rbSalad.Checked)
            {
                divisionMenu = Division.찹샐러드;
            }
            else if (rbSide.Checked)
            {
                divisionMenu = Division.사이드;
            }
            else
            {
                divisionMenu = Division.음료;
            }
            saleRecordsLst = new DAO.SaleRecordsDAO().SelectSaleRacordsByPeriod(dtpStartDate.Value, dtpEndDate.Value);
            var hash = HashtableForMenuCount(saleRecordsLst, divisionMenu);
            crtSalesVolumeByDate.Series[0].Points.DataBindXY(hash.Keys, hash.Values);
            var top5 = Top5Hash(MenusSelect(divisionMenu));
            CircleChartDisplay(top5);
            dgvRank.DataSource = SelectMenuForTable(hash);
            dgvRank.Sort(dgvRank.Columns[1], ListSortDirection.Descending);
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
