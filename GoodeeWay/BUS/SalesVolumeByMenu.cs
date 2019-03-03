using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GoodeeWay.VO;
using Newtonsoft.Json;

namespace GoodeeWay.BUS
{
    public partial class SalesVolumeByMenu : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;
        public SalesVolumeByMenu()
        {
            InitializeComponent();
        }
        ToolTip toolTipColumn = new ToolTip();
        Point? previousPosition = null;
        List<SaleRecordsVO> saleRecordsLst;
        Hashtable hashtableForMenu;
        Division divisionMenu;

        private void SalesVolumeByMenu_Load(object sender, EventArgs e)
        {
            
            btnClose.BackgroundImage = Properties.Resources.Close_Window_32px.ToImage();
            crtSalesVolumeByDate.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            crtSalesVolumeByDate.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            crtSalesVolumeByDate.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            
            dgvRank.AllowUserToAddRows = false;
            panelImage.BringToFront();
            panelImage.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "NewGooDeeWay.png");

            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); //이번달 1일부터 검색하기위해
            dtpEndDate.Value = DateTime.Now;

            saleRecordsLst = new DAO.SaleRecordsDAO().SelectSaleRacordsByPeriod(dtpStartDate.Value, dtpEndDate.Value);

            #region Division에 RadioButton에 체크된 값을 넣음
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
            #endregion


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

        /// <summary>
        /// hash테이블의 값을 data테이블 값으로 변경시켜준다.
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        private DataTable SelectMenuForTable(Hashtable hash)
        {
            DataTable data;
            data = new DataTable();
            data.Columns.Add("메뉴 명",typeof(string));
            data.Columns.Add("판매량",typeof(int));

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
            crtAllMenuPercent.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            crtAllMenuPercent.Series[0].Points.DataBindXY(hash.Keys, hash.Values);
            crtAllMenuPercent.Legends[0].Alignment = StringAlignment.Center;
            crtAllMenuPercent.Series[0].LabelForeColor = Color.White;
            crtAllMenuPercent.Series[0].Label = "#VALY \n (#PERCENT)";
            crtAllMenuPercent.Series[0].LegendText = "#VALX :#VALY (#PERCENT)";

        }

        /// <summary>
        /// 리스트를 hashTable화 시킨다. Key : MenuName, Values :  Sales volume by menu
        /// </summary>
        /// <param name="saleRecordsLst"></param>
        /// <returns></returns>
        private Hashtable HashtableForMenuCount(List<SaleRecordsVO> saleRecordsLst, Division divisionMenu)
        {//HashTable을 만들고 메뉴별 판매량을 count시킨다.
            
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

        /// <summary>
        /// 상위 5개의 값을 뽑아 hash table로 반환시켜준다.
        /// </summary>
        /// <param name="selectedMenu"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 날짜 설정후 검색click 부분
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// 창이동 
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

        /// <summary>
        /// 창 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 막대그래프의 툴팁생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crtSalesVolumeByDate_MouseMove(object sender, MouseEventArgs e)
        {
            Point currentPosition = e.Location;
            if (previousPosition.HasValue && currentPosition == previousPosition)
            {
                return;
            }
            toolTipColumn.RemoveAll();
            previousPosition = currentPosition;
            var hit = crtSalesVolumeByDate.HitTest(currentPosition.X, currentPosition.Y, System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint);
            if (hit.ChartElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint)
            {
                var yValue = String.Format("{0:#,###}개", Convert.ToInt32((hit.Object as System.Windows.Forms.DataVisualization.Charting.DataPoint).YValues[0]));
                toolTipColumn.Show(yValue, crtSalesVolumeByDate, new Point(currentPosition.X + 10, currentPosition.Y + 15));
            }
        }
    }

}
