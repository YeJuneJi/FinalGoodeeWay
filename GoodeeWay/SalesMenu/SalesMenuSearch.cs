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
using Excel = Microsoft.Office.Interop.Excel;

namespace GoodeeWay.SalesMenu
{
    public partial class SalesMenuSearch : Form
    {
        List<SalesMenuVO> searchlist;
        DataTable searchMenu;
        DataColumn[] dataColoumns;
        public SalesMenuSearch()
        {
            InitializeComponent();
        }
        private void SalesMenuSearch_Load(object sender, EventArgs e)
        {
            searchlist = new List<SalesMenuVO>();
            menuSearchGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuSearchGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            menuSearchGView.AllowUserToAddRows = false;
            dataColoumns = new DataColumn[]
            {
                new DataColumn("메뉴코드"),
                new DataColumn("메뉴명"),
                new DataColumn("가격"),
                new DataColumn("Kcal"),
                new DataColumn("이미지",typeof(byte[])),
                new DataColumn("구분"),
                new DataColumn("부가설명"),
            };
            searchMenu = new DataTable("searchMenu");
            searchMenu.Columns.AddRange(dataColoumns);
            searchlist = new SalesMenuDAO().OutPutAllMenus();
            ListToGridView(searchlist);

            cbxDivision.Items.Add("전체");
            foreach (Division item in Enum.GetValues(typeof(Division)))
            {
                cbxDivision.Items.Add(item);
            }
            cbxDivision.SelectedItem = cbxDivision.Items[0];
        }

        /// <summary>
        /// List<SalesMenuVO>를 gridView에 출력해 주기 위한 메서드
        /// </summary>
        /// <param name="salesMenus"></param>
        private void ListToGridView(List<SalesMenuVO> salesMenus)
        {
            foreach (var item in salesMenus)
            {
                searchMenu.Rows.Add(item.MenuCode, item.MenuName, item.Price, item.Kcal, item.MenuImage.ImageToByteArray(), item.Division, item.AdditionalContext);
            }
            menuSearchGView.DataSource = searchMenu;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (rdoMenuCode.Checked)
            {
                string menuCode = tbxSearch.Text.Replace(" ", "").Trim();
                menuSearchGView.DataSource = null;
                searchlist.Clear();
                searchMenu.Rows.Clear();
                searchlist = new SalesMenuDAO().SelectMenuByMenuCode(menuCode, cbxDivision.SelectedIndex);
                ListToGridView(searchlist);
            }
            if (rdoMenuName.Checked)
            {
               string menuName = tbxSearch.Text.Replace(" ", "").Trim();
                menuSearchGView.DataSource = null;
                searchlist.Clear();
                searchMenu.Rows.Clear();
                searchlist = new SalesMenuDAO().SelectMenuByMenuName(menuName, cbxDivision.SelectedIndex);
                ListToGridView(searchlist);
            }
            if (rdoAdditional.Checked)
            {
                string additional = tbxSearch.Text.Trim();
                menuSearchGView.DataSource = null;
                searchlist.Clear();
                searchMenu.Rows.Clear();
                searchlist = new SalesMenuDAO().SelectMenuByAdditional(additional, cbxDivision.SelectedIndex);
                ListToGridView(searchlist);
            }
            lblTotal.Text = searchMenu.Rows.Count.ToString() + "개의 결과를 출력하였습니다.";
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel응용 프로그램을 찾을 수 없거나, 설치되지 않았습니다.");
                return;
            }
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            object missingValue = System.Reflection.Missing.Value;
            workBook = excelApp.Workbooks.Add(missingValue);
            workSheet = workBook.Worksheets.Item[1];

            for (int i = 1; i < dataColoumns.Length+1; i++)
            {
                workSheet.Cells[1, i] = dataColoumns[i - 1].ColumnName;
            }

            List<SalesMenuVO> list = new List<SalesMenuVO>();
            foreach (DataGridViewRow item in menuSearchGView.Rows)
            {
                list.Add(new SalesMenuVO()
                {
                    MenuCode = item.Cells[0].Value.ToString(),
                    MenuName = item.Cells[1].Value.ToString(),
                    Price = float.Parse(item.Cells[2].Value.ToString()),
                    Kcal = int.Parse(item.Cells[3].Value.ToString()),
                    MenuImage = ((byte[])menuSearchGView.Rows[0].Cells[4].Value).ByteArrayToImage(),
                    Division = Convert.ToInt32(item.Cells[5].Value),
                    AdditionalContext = item.Cells[6].Value.ToString()
                });
            }
        }
    }
}
