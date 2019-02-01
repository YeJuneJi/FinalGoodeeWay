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
        List<InventoryTypeVO> inventoryTypeVOList;
        public ReceivingDetailsVO ReceivingDetailsVOReturn;
        bool InventoryTableTemp = false;
        public Inventory()
        {
            InitializeComponent();
            InventoryTypeSelect();
            ReceivingDetailsListSelect();
            InventoryTableSelect();
            btnReturnAdd.Enabled = btnReceivingDetailsSave.Enabled = false;
            InventoryTableTemp = true;
        }

        #region 입고내역
        /// <summary>
        /// '가져오기' 버튼 클릭하여 입고내역 상세뷰 띄우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadingFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\GD4\Desktop\FinalProject";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                receivingDetailsList = ExcelLoading(filePath);


                dgvReceivingDetails.DataSource = receivingDetailsList;
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
                bool temp = true;
                for (int i = 0; i < dgvReceivingDetailsList.Rows.Count; i++)
                {

                    if (receivingDetailsList[0].ReceivingDetailsDate.ToShortDateString() == dgvReceivingDetailsList["입고날짜", i].Value.ToString())
                    {
                        MessageBox.Show("이미 저장된 입고내역서입니다.");
                        btnReturnAdd.Enabled = btnReceivingDetailsSave.Enabled = temp = false;
                    }

                }

                if (temp)
                {
                    btnReturnAdd.Enabled = btnReceivingDetailsSave.Enabled = true;
                }
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
            if (worksheet.Cells[1, 1].Value.ToString() != "입고내역서")
            {
                MessageBox.Show("입고내역서가 아닙니다.");
                return null;
            }
            int row = 4;

            string temp = worksheet.Cells[row, 2].Value.ToString();
            while (temp != null)
            {
                ReceivingDetailsVO rd = new ReceivingDetailsVO();

                rd.ReceivingDetailsID = worksheet.Cells[row, 2].Value.ToString();
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
                rd.ReceivingDetailsID = dgvReceivingDetails["ReceivingDetailsID", i].Value.ToString();
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
                btnReturnAdd.Enabled = btnReceivingDetailsSave.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("이미 저장되었습니다.");
                btnReturnAdd.Enabled = btnReceivingDetailsSave.Enabled = false;
            }
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
            dgvReceivingDetailsList.AllowUserToAddRows = false;
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

        /// <summary>
        /// 반품 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnAdd_Click(object sender, EventArgs e)
        {
            //반품 상태가 정상인 입고물품만 반품추가 가능
            if (dgvReceivingDetails.SelectedRows[0].Cells["ReturnStatus"].Value.ToString() == "정상")
            {
                //선택된 rows의 내용들 VO에 보냄
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
                //ReceivingDetailsReturn폼에 Vo를 보내줌
                ReceivingDetailsReturn receivingDetailsReturn = new ReceivingDetailsReturn(ReceivingDetailsVOReturn);
                receivingDetailsReturn.Owner = this;
                if (receivingDetailsReturn.ShowDialog() == DialogResult.OK)
                {
                    dgvReceivingDetails.DataSource = null;

                    for (int i = 0; i < receivingDetailsList.Count; i++)
                    {


                        //리스트에 입고(IN)으로 시작되는 내역만 검색함
                        if (receivingDetailsList[i].ReceivingDetailsID.Contains("IN"))
                        {

                            if (ReceivingDetailsVOReturn.ReceivingDetailsID.Substring(2, 8) == receivingDetailsList[i].ReceivingDetailsID.Substring(2, 8))
                            {
                                receivingDetailsList[i].Quantity = receivingDetailsList[i].Quantity - ReceivingDetailsVOReturn.Quantity;
                                if (receivingDetailsList[i].Quantity == 0)
                                {
                                    receivingDetailsList.Remove(receivingDetailsList[i]);
                                }
                            }
                        }
                    }
                    //선택된 row에 대한 반품내역 또는 교환내역이 이미 존재한다면 반품,교환내역에 수를 더해줌.

                    for (int i = 0; i < receivingDetailsList.Count; i++)
                    {
                        if (receivingDetailsList[i].ReceivingDetailsID.Contains(ReceivingDetailsVOReturn.ReceivingDetailsID))
                        {
                            ReceivingDetailsVOReturn.Quantity = receivingDetailsList[i].Quantity + ReceivingDetailsVOReturn.Quantity;
                            receivingDetailsList.Remove(receivingDetailsList[i]);
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
        #endregion

        #region 재고테이블

        /// <summary>
        /// 재고테이블 업데이트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventoryNewTable_Click(object sender, EventArgs e)
        {
            InventoryTableSelect();
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
        #endregion

        #region 재고종류 버튼 관련 메서드
        /// <summary>
        /// 재고종류 추가폼 띄우는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventoryTypeAdd_Click(object sender, EventArgs e)
        {
            InventoryTypeAdd ita = new InventoryTypeAdd();
            if (ita.ShowDialog() == DialogResult.OK)
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
            inventoryTypeVOList = new InventoryTypeDAO().InventoryTypeSelect();
            dgvInventoryType.DataSource = inventoryTypeVOList;

            #region 재고종류테이블 컬럼명 변경
            dgvInventoryType.Columns["InventoryTypeCode"].HeaderText = "재고종류코드";
            dgvInventoryType.Columns["ReceivingQuantity"].HeaderText = "입고정량";
            dgvInventoryType.Columns["InventoryName"].HeaderText = "재고명";
            dgvInventoryType.Columns["MaterialClassification"].HeaderText = "재료구분";
            #endregion
        }
        /// <summary>
        /// 재고종류 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                new InventoryTypeDAO().InventoryTypeDelete(dgvInventoryType.SelectedRows[0].Cells["InventoryTypeCode"].Value.ToString());
            }
            catch (SqlException)
            {
                MessageBox.Show("수정만 가능합니다.");
            }
            InventoryTypeSelect();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InventoryTypeVO inventoryTypeVO = new InventoryTypeVO()
            {
                InventoryTypeCode = dgvInventoryType.SelectedRows[0].Cells["InventoryTypeCode"].Value.ToString(),
                ReceivingQuantity = Int32.Parse(dgvInventoryType.SelectedRows[0].Cells["ReceivingQuantity"].Value.ToString()),
                InventoryName = dgvInventoryType.SelectedRows[0].Cells["InventoryName"].Value.ToString(),
                MaterialClassification = dgvInventoryType.SelectedRows[0].Cells["MaterialClassification"].Value.ToString(),
            };

            new InventoryTypeDAO().InventoryTypeUpdate(inventoryTypeVO);
            InventoryTypeSelect();

        } 
        #endregion

        #region 재고테이블 선택 시 재고종류 선택
        /// <summary>
        /// 재고테이블 row선택 시 해당 물품의 재고종류가 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInventoryTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            InventoryTableRowSelected();
        }

        private void InventoryTableRowSelected()
        {
            dgvInventoryType.ClearSelection();


            if (InventoryTableTemp)
            {
                for (int i = 0; i < dgvInventoryType.Rows.Count; i++)
                {
                    if (dgvInventoryType["InventoryTypeCode", i].Value.ToString() == dgvInventoryTable.SelectedRows[0].Cells["InventoryTypeCode"].Value.ToString())
                    {

                        dgvInventoryType["InventoryTypeCode", i].Selected = true;
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// 재고테이블 row선택 시 해당 물품의 재고종류가 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInventoryTable_KeyUp(object sender, KeyEventArgs e)
        {
            InventoryTableRowSelected();
        } 
        #endregion
    }
}
