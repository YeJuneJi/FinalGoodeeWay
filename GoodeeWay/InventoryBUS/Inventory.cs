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
using GoodeeWay.InventoryBUS;
using GoodeeWay.VO;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace GoodeeWay
{
    public partial class Inventory : Form
    {

        List<ReceivingDetailsVO> receivingDetailsList;
        public ReceivingDetailsVO ReceivingDetailsVOReturn;

        public Inventory()
        {
            InitializeComponent();
            InventoryTypeSelect();
            ReceivingDetailsListSelect();
            InventoryTableSelect();
            btnReturnAdd.Enabled = btnReceivingDetailsSave.Enabled = false;

        }
        /// <summary>
        /// 재고 테이블
        /// </summary>
        private void InventoryTableSelect()
        {
            dgvInventoryTable.DataSource = new InventoryDAO().InventoryTableSelect();
            #region 재고테이블 컬럼명 변경
            dgvInventoryTable.Columns["InventoryID"].HeaderText = "재고번호";
            dgvInventoryTable.Columns["InventoryName"].HeaderText = "재고명";
            dgvInventoryTable.Columns["InventoryQuantity"].HeaderText = "재고량";
            dgvInventoryTable.Columns["DateOfUse"].HeaderText = "사용날짜";
            dgvInventoryTable.Columns["DateOfDisposal"].HeaderText = "유통기한";
            dgvInventoryTable.Columns["ReceivingDetailsID"].HeaderText = "입고번호";
            dgvInventoryTable.Columns["InventoryTypeCode"].HeaderText = "재고종류코드"; 
            #endregion
        }
        /// <summary>
        /// '가져오기' 버튼 클릭하여 입고내역 상세뷰 띄우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadingFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\GD4\Desktop\FinalProject";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string filePath =openFileDialog1.FileName;
                receivingDetailsList = ExcelLoading(filePath);


                dgvReceivingDetails.DataSource= receivingDetailsList;
                #region 입고내역 상세테이블 컬럼명 변경
                dgvReceivingDetails.Columns["ReceivingDetailsID"].HeaderText = "입고번호";
                dgvReceivingDetails.Columns["ReceivingDetailsDate"].HeaderText = "입고날짜";
                dgvReceivingDetails.Columns["ExpirationDate"].HeaderText = "유통기한";
                dgvReceivingDetails.Columns["Quantity"].HeaderText = "수량";
                dgvReceivingDetails.Columns["UnitPrice"].HeaderText = "단가";
                dgvReceivingDetails.Columns["ReturnStatus"].HeaderText = "반품여부";
                dgvReceivingDetails.Columns["InventoryTypeCode"].HeaderText = "재고종류코드"; 
                dgvReceivingDetails.Columns["InventoryName"].HeaderText = "입고명";
                #endregion
                btnReturnAdd.Enabled = btnReceivingDetailsSave.Enabled = true;
            }
            
            
        }

        /// <summary>
        /// 입고내역서(Excel) 파일 가져오기
        /// </summary>
        /// <param name="filePath">엑셀파일의 경로</param>
        /// <returns>입고내역서에 대한 List파일</returns>
        private List<ReceivingDetailsVO> ExcelLoading(string filePath)
        {
            receivingDetailsList = new List<ReceivingDetailsVO>();

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
                ReceivingDetailsVO rd = new ReceivingDetailsVO();

                rd.ReceivingDetailsID=worksheet.Cells[row, 2].Value.ToString();
                rd.ReceivingDetailsDate = DateTime.Parse(worksheet.Cells[2, 6].Value.ToString());
                rd.ExpirationDate = DateTime.Parse(worksheet.Cells[row, 6].Value.ToString());
                rd.Quantity = Int32.Parse(worksheet.Cells[row, 5].Value.ToString());
                rd.UnitPrice = float.Parse(worksheet.Cells[row, 4].Value.ToString());
                rd.ReturnStatus = worksheet.Cells[row, 7].Value.ToString();
                rd.InventoryTypeCode = worksheet.Cells[row, 8].Value.ToString();
                for (int i = 0; i < dgvInventoryType.Rows.Count; i++)
                {
                    if (dgvInventoryType["InventoryTypeCode", i].Value.ToString() == rd.InventoryTypeCode)
                    {
                        rd.InventoryName = dgvInventoryType["InventoryName", i].Value.ToString();
                        break;
                    }
                }
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

        /// <summary>
        /// ‘입고내역 적용' 버튼 클릭 시 입고내역서를 입고내역과 재고내역에 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceivingDetailsSave_Click(object sender, EventArgs e)
        {
            receivingDetailsList = new List<ReceivingDetailsVO>();

            for (int i = 0; i < dgvReceivingDetails.Rows.Count; i++)
            {
                ReceivingDetailsVO rd = new ReceivingDetailsVO();
                rd.ReceivingDetailsID= dgvReceivingDetails["ReceivingDetailsID", i].Value.ToString();
                rd.ReceivingDetailsDate = DateTime.Parse(dgvReceivingDetails["ReceivingDetailsDate", i].Value.ToString());
                rd.ExpirationDate = DateTime.Parse(dgvReceivingDetails["ExpirationDate", i].Value.ToString());
                rd.Quantity = Int32.Parse(dgvReceivingDetails["Quantity", i].Value.ToString());
                rd.UnitPrice = float.Parse(dgvReceivingDetails["UnitPrice", i].Value.ToString());
                rd.ReturnStatus = dgvReceivingDetails["ReturnStatus", i].Value.ToString();
                rd.InventoryTypeCode = dgvReceivingDetails["InventoryTypeCode", i].Value.ToString();
                receivingDetailsList.Add(rd);
            }
            try
            {
                new InventoryDAO().InventoryInsert(receivingDetailsList);
                ReceivingDetailsListSelect();
                MessageBox.Show("저장되었습니다.");
            }
            catch (SqlException)
            {
                MessageBox.Show("이미 저장되었습니다.");
            }
        }

        /// <summary>
        /// 재고종류 추가폼 띄우는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventoryTypeAdd_Click(object sender, EventArgs e)
        {
            InventoryTypeAdd ita = new InventoryTypeAdd();
            if(ita.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show("저장완료");
                InventoryTypeSelect();
            }
        }

        /// <summary>
        /// 재고종류 테이블 새로고침
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewTable_Click(object sender, EventArgs e)
        {
            InventoryTypeSelect();
        }

        /// <summary>
        /// 재고종류 테이블
        /// </summary>
        private void InventoryTypeSelect()
        {
            dgvInventoryType.DataSource = new InventoryTypeDAO().InventoryTypeSelect();
            #region 재고종류테이블 컬럼명 변경
            dgvInventoryType.Columns["InventoryTypeCode"].HeaderText = "재고종류코드";
            dgvInventoryType.Columns["ReceivingQuantity"].HeaderText = "입고정량";
            dgvInventoryType.Columns["InventoryName"].HeaderText = "재고명";
            dgvInventoryType.Columns["MaterialClassification"].HeaderText = "재료구분";
            #endregion
        }

        /// <summary>
        /// 입고내역리스트 테이블
        /// </summary>
        private void ReceivingDetailsListSelect()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("입고날짜");
            foreach (var item in new ReceivingDetailsDAO().ReceivingDetailsList())
            {
                DataRow row = dataTable.NewRow();
                row["입고날짜"] = item.ReceivingDetailsDate.ToShortDateString();
                dataTable.Rows.Add(row);
            }
            dgvReceivingDetailsList.DataSource = dataTable;
        }
        /// <summary>
        /// 입고내역리스트 더블클릭->입고내역상세뷰
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReceivingDetailsList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvReceivingDetails.DataSource = new ReceivingDetailsDAO().ReceivingDetailsDetailView(dgvReceivingDetailsList.SelectedRows[0].Cells["입고날짜"].Value.ToString());
            dgvReceivingDetails.Columns["ReceivingDetailsID"].HeaderText = "입고번호";
            dgvReceivingDetails.Columns["InventoryName"].HeaderText = "입고명";
            dgvReceivingDetails.Columns["ExpirationDate"].HeaderText = "유통기한";
            dgvReceivingDetails.Columns["Quantity"].HeaderText = "수량";
            dgvReceivingDetails.Columns["UnitPrice"].HeaderText = "단가";
            dgvReceivingDetails.Columns["ReturnStatus"].HeaderText = "반품여부";
            dgvReceivingDetails.Columns["InventoryTypeCode"].HeaderText = "재고종류코드";
            btnReturnAdd.Enabled = btnReceivingDetailsSave.Enabled = false;

        }

        private void btnInventoryNewTable_Click(object sender, EventArgs e)
        {
            InventoryTableSelect();
        }


        private void dgvInventoryTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvInventoryType.ClearSelection();


            for (int i = 0; i < dgvInventoryType.Rows.Count; i++)
            {
                if (dgvInventoryType["InventoryTypeCode", i].Value.ToString() == dgvInventoryTable.SelectedRows[0].Cells["InventoryTypeCode"].Value.ToString())
                {

                    dgvInventoryType["InventoryTypeCode", i].Selected = true;
                    break;
                }
            }
            
        }

        private void btnReturnAdd_Click(object sender, EventArgs e)
        {
            if (dgvReceivingDetails.SelectedRows[0].Cells["ReturnStatus"].Value.ToString() == "정상")
            {


                ReceivingDetailsVOReturn = new ReceivingDetailsVO()
                {
                    ReceivingDetailsID = dgvReceivingDetails.SelectedRows[0].Cells["ReceivingDetailsID"].Value.ToString(),
                    InventoryName = dgvReceivingDetails.SelectedRows[0].Cells["InventoryName"].Value.ToString(),
                    ReceivingDetailsDate = DateTime.Parse(dgvReceivingDetails.SelectedRows[0].Cells["ReceivingDetailsDate"].Value.ToString()),
                    ExpirationDate = DateTime.Parse(dgvReceivingDetails.SelectedRows[0].Cells["ExpirationDate"].Value.ToString()),
                    Quantity = Int32.Parse(dgvReceivingDetails.SelectedRows[0].Cells["Quantity"].Value.ToString()),
                    UnitPrice = float.Parse(dgvReceivingDetails.SelectedRows[0].Cells["UnitPrice"].Value.ToString()),
                    ReturnStatus = dgvReceivingDetails.SelectedRows[0].Cells["ReturnStatus"].Value.ToString(),
                    InventoryTypeCode = dgvReceivingDetails.SelectedRows[0].Cells["InventoryTypeCode"].Value.ToString()
                };
                ReceivingDetailsReturn receivingDetailsReturn = new ReceivingDetailsReturn(ReceivingDetailsVOReturn);
                receivingDetailsReturn.Owner = this;
                if (receivingDetailsReturn.ShowDialog() == DialogResult.OK)
                {
                    dgvReceivingDetails.DataSource = null;

                    
                    foreach (var item in receivingDetailsList)
                    {
                        if (item.ReceivingDetailsID.Contains("IN"))
                        {

                            if (ReceivingDetailsVOReturn.ReceivingDetailsID.Substring(2, 8) == item.ReceivingDetailsID.Substring(2, 8))
                            {
                                item.Quantity = item.Quantity - ReceivingDetailsVOReturn.Quantity;
                                if (item.Quantity == 0)
                                {
                                    receivingDetailsList.Remove(item);
                                    //receivingDetailsList.Sort();
                                }
                            }
                        }
                    }
                    foreach (var item in receivingDetailsList)
                    {
                        if (item.ReceivingDetailsID.Contains(ReceivingDetailsVOReturn.ReceivingDetailsID))
                        {
                            ReceivingDetailsVOReturn.Quantity = item.Quantity + ReceivingDetailsVOReturn.Quantity;
                            receivingDetailsList.Remove(item);
                            //receivingDetailsList.Sort();
                        }
                    }
                    receivingDetailsList.Add(ReceivingDetailsVOReturn);
                    dgvReceivingDetails.DataSource = receivingDetailsList;
                    dgvReceivingDetails.Columns["ReceivingDetailsID"].HeaderText = "입고번호";
                    dgvReceivingDetails.Columns["ReceivingDetailsDate"].HeaderText = "입고날짜";
                    dgvReceivingDetails.Columns["ExpirationDate"].HeaderText = "유통기한";
                    dgvReceivingDetails.Columns["Quantity"].HeaderText = "수량";
                    dgvReceivingDetails.Columns["UnitPrice"].HeaderText = "단가";
                    dgvReceivingDetails.Columns["ReturnStatus"].HeaderText = "반품여부";
                    dgvReceivingDetails.Columns["InventoryTypeCode"].HeaderText = "재고종류코드";
                    dgvReceivingDetails.Columns["InventoryName"].HeaderText = "입고명";

                }
            }
            else
            {
                MessageBox.Show("정상제품에 대해서만 반품내역 추가할 수 있습니다.");
            }
        }
    }
}
