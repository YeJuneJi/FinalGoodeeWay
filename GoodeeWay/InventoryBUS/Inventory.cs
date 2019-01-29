using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.DAO;
using GoodeeWay.VO;
using Microsoft.Office.Interop.Excel;

namespace GoodeeWay
{
    public partial class Inventory : Form
    {

        List<ReceivingDetails> receivingDetailsList;
        InventoryDAO inventoryDAO;

        public Inventory()
        {
            InitializeComponent();
        }

        private void btnLoadingFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\GD4\Desktop\FinalProject";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string filePath =openFileDialog1.FileName;
                
                dgvReceivingDetails.DataSource=ExcelLoading(filePath);
                dgvReceivingDetails.Columns["ReceivingDetailsID"].HeaderText = "입고번호";
                dgvReceivingDetails.Columns["ReceivingDetailsDate"].HeaderText = "입고날짜";
                dgvReceivingDetails.Columns["ExpirationDate"].HeaderText = "유통기한";
                dgvReceivingDetails.Columns["Quantity"].HeaderText = "수량";
                dgvReceivingDetails.Columns["UnitPrice"].HeaderText = "단가";
                dgvReceivingDetails.Columns["ReturnStatus"].HeaderText = "반품여부";
                dgvReceivingDetails.Columns["InventoryTypeCode"].HeaderText = "재고종류코드";
            }
            
            
        }

        /// <summary>
        /// '가져오기' 버튼 클릭 시 입고내역서(Excel) 파일 가져오기
        /// </summary>
        /// <param name="filePath">엑셀파일의 경로</param>
        /// <returns>입고내역서에 대한 List파일</returns>
        private List<ReceivingDetails> ExcelLoading(string filePath)
        {
            receivingDetailsList = new List<ReceivingDetails>();

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            if (excelApp == null)
            {
                MessageBox.Show("Excel 응용프로그램을 찾을 수 없거나, 설치되지 않았습니다.");
                return null;
            }
            Workbook workbook;
            Worksheet worksheet;
            object missingValue = System.Reflection.Missing.Value;
            if (!filePath.Contains(".xls"))
            {
                MessageBox.Show("excel파일이 아닙니다.");
                return null;
            }
            workbook = excelApp.Workbooks.Open(filePath);
            
            worksheet = excelApp.Worksheets.Item[1];
            if (worksheet.Cells[1,1].Value.ToString()!="입고내역서")
            {
                MessageBox.Show("입고내역서가 아닙니다.");
                return null;
            }
            int row = 4;

            string temp = worksheet.Cells[row, 2].Value.ToString();
            while (temp!=null)
            {
                ReceivingDetails rd = new ReceivingDetails();

                rd.ReceivingDetailsID=worksheet.Cells[row, 2].Value.ToString();
                rd.ReceivingDetailsDate = DateTime.Parse(worksheet.Cells[2, 6].Value.ToString());
                rd.ExpirationDate = DateTime.Parse(worksheet.Cells[row, 6].Value.ToString());
                rd.Quantity = Int32.Parse(worksheet.Cells[row, 5].Value.ToString());
                rd.UnitPrice = float.Parse(worksheet.Cells[row, 4].Value.ToString());
                rd.ReturnStatus = worksheet.Cells[row, 7].Value.ToString();
                rd.InventoryTypeCode = worksheet.Cells[row, 8].Value.ToString();
                row++;

                receivingDetailsList.Add(rd);
                try
                {
                    temp = worksheet.Cells[row, 2].Value.ToString();
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException e)
                {
                    temp = null;
                }
            }
            workbook.Close(false, missingValue, missingValue);
            excelApp.Quit();

            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelApp);
            return receivingDetailsList;
        }

        private void btnReceivingDetailsSave_Click(object sender, EventArgs e)
        {
            receivingDetailsList = new List<ReceivingDetails>();

            for (int i = 0; i < dgvReceivingDetails.Rows.Count; i++)
            {
                ReceivingDetails rd = new ReceivingDetails();
                rd.ReceivingDetailsID= dgvReceivingDetails["ReceivingDetailsID", i].Value.ToString();
                rd.ReceivingDetailsDate = DateTime.Parse(dgvReceivingDetails["ReceivingDetailsDate", i].Value.ToString());
                rd.ExpirationDate = DateTime.Parse(dgvReceivingDetails["ExpirationDate", i].Value.ToString());
                rd.Quantity = Int32.Parse(dgvReceivingDetails["Quantity", i].Value.ToString());
                rd.UnitPrice = float.Parse(dgvReceivingDetails["UnitPrice", i].Value.ToString());
                rd.ReturnStatus = dgvReceivingDetails["ReturnStatus", i].Value.ToString();
                rd.InventoryTypeCode = dgvReceivingDetails["InventoryTypeCode", i].Value.ToString();
                receivingDetailsList.Add(rd);
            }
            inventoryDAO.InventoryInsert(receivingDetailsList);
        }
    }
}
