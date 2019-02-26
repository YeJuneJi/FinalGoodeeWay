using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GoodeeWay.Sales
{
    public partial class FrmSalesMenuSearch : Form
    {
        List<SalesMenuVO> searchlist;
        DataTable searchMenu;
        DataColumn[] dataColoumns;
        public FrmSalesMenuSearch()
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
                new DataColumn("이미지", typeof(byte[])),
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
                searchMenu.Rows.Add(item.MenuCode, item.MenuName, item.Price, item.Kcal, Image.FromFile(Application.StartupPath + item.MenuImageLocation).ImageToByteArray(), item.Division, item.AdditionalContext);
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
            if (ExcelSaveFileDlg.ShowDialog() != DialogResult.Cancel)
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

                for (int i = 1; i < dataColoumns.Length + 1; i++)
                {
                    workSheet.Cells[1, i] = dataColoumns[i - 1].ColumnName;
                }

                for (int i = 2; i < menuSearchGView.Rows.Count + 2; i++)
                {
                    Clipboard.Clear();
                    workSheet.Cells[i, 1] = menuSearchGView.Rows[i - 2].Cells[0].Value.ToString();
                    workSheet.Cells[i, 2] = menuSearchGView.Rows[i - 2].Cells[1].Value.ToString();
                    workSheet.Cells[i, 3] = float.Parse(menuSearchGView.Rows[i - 2].Cells[2].Value.ToString());
                    workSheet.Cells[i, 4] = int.Parse(menuSearchGView.Rows[i - 2].Cells[3].Value.ToString());
                    Excel.Range pictureRange = workSheet.Cells[i, 5];
                    MemoryStream ms = new MemoryStream((byte[])menuSearchGView.Rows[i - 2].Cells[4].Value);
                    Image img = Image.FromStream(ms);
                    img = (Image)new Bitmap(img, new Size(100, 100));
                    pictureRange.ColumnWidth = 11.88;
                    pictureRange.RowHeight = 75.00;
                    Clipboard.SetDataObject(img, true); //Ctrl + C
                    workSheet.Paste(pictureRange, img); //Ctrl + V     
                    workSheet.Cells[i, 6] = Convert.ToInt32(menuSearchGView.Rows[i - 2].Cells[5].Value);
                    workSheet.Cells[i, 7] = menuSearchGView.Rows[i - 2].Cells[6].Value.ToString();
                    ms.Close();
                }

                try
                {
                    workBook.SaveAs(ExcelSaveFileDlg.FileName, Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingValue, missingValue, missingValue, missingValue);
                }
                catch (Exception)
                {
                    throw;
                }
                excelApp.Quit();
                Marshal.FinalReleaseComObject(workSheet);
                Marshal.FinalReleaseComObject(workBook);
                Marshal.FinalReleaseComObject(excelApp);
            }
        }
    }
}
