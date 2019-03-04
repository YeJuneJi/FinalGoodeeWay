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
using Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;


namespace GoodeeWay.InventoryBUS
{
    public partial class FrmInventory : UserControl
    {
        List<ReceivingDetailsVO> receivingDetailsList;
        List<InventoryTypeVO> inventoryTypeVOList;
        List<OrderDetailsVO> orderDetailsVOsList;
        DataTable inventoryTypeDateTable;
        DataTable orderDetailsDataTable;
        DataTable OrderDetailsListDataTable;
        DataTable inventoryDataTable;
        string[] MaterialClassification = new string[7] { "Bread", "Cheese", "Additional", "Sauce", "Topping", "Vegetable", "Side" };

        public ReceivingDetailsVO ReceivingDetailsVOReturn;
        bool InventoryTableTemp = false;

        public FrmInventory()
        {
            InitializeComponent();
            InventoryTypeSelect();
            ReceivingDetailsListSelect();
            InventoryTableSelect();
            btnReturnAdd.Enabled = btnReceivingDetailsSave.Enabled = false;
            InventoryTableTemp = true;
            dgvNeedInventoryDetailView.AllowUserToAddRows = false;
            SelectOrderDetailsList();
            dgvOrderDetailsList.AllowUserToAddRows = false;
            btnSaveOrderDetails.Enabled = false;
            btnExcelExport.Enabled = false;

            MenuPanel.Dock = DockStyle.None;
            pnbReceiving.Dock = DockStyle.None;
            pnmInventory.Dock = DockStyle.None;
            MenuPanel.Dock = DockStyle.Top;
            pnbReceiving.Dock = DockStyle.Bottom;
            pnmReceiving.Dock = DockStyle.Fill;
            pnmReceiving.BringToFront();
            btnReturnAdd.Visible = btnLoadingFile.Visible = btnReceivingDetailsSave.Visible = true;
            btnNewTable.Visible = btnInventoryTypeAdd.Visible = btnUpdate.Visible = btnDelete.Visible = btnRelease.Visible = btnInventoryNewSelect.Visible = false;
            btnAddOrder.Visible = btnUpdateOrder.Visible = btnSaveOrderDetails.Visible = btnExcelExport.Visible = btnOrderDisplay.Visible = false;
            btnAddOrder.Enabled = btnUpdateOrder.Enabled=false;
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
                if (receivingDetailsList is null)
                {
                    return;
                }

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

            Excel.Application excelApp = new Excel.Application();

            if (excelApp == null)
            {
                MessageBox.Show("Excel 응용프로그램을 찾을 수 없거나, 설치되지 않았습니다.");
                return null;
            }
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
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
                    if (dgvInventoryType["재고종류코드", i].Value.ToString() == rd.InventoryTypeCode)
                    {
                        rd.InventoryName = dgvInventoryType["재고명", i].Value.ToString();
                        break;
                    }
                }
                row++;


                receivingDetailsList.Add(rd);
                try
                {
                    temp = worksheet.Cells[row, 2].Value.ToString();
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
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
            bool temp = false;
            for (int i = 0; i < dgvReceivingDetails.Rows.Count; i++)
            {
                if (dgvReceivingDetails["InventoryName", i].Value == null)
                {
                    temp = true;
                    MessageBox.Show("등록되지 않은 재고는 입고내역에 추가되지 않습니다.");
                }
                else
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

                if (temp == false)
                {
                    MessageBox.Show("이미 저장되었습니다.");
                }
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
                try
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
                    ReceivingDetailsReturn receivingDetailsReturn = new ReceivingDetailsReturn(ReceivingDetailsVOReturn, this);
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
                catch (NullReferenceException)
                {
                    MessageBox.Show("등록되지 않은 재고입니다.");
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
        private void btnInventoryNewSelect_Click(object sender, EventArgs e)
        {
            InventoryTableSelect();
        }

        /// <summary>                                                                               
        /// 재고 테이블                                                                             
        /// </summary>
        private void InventoryTableSelect()
        {
            dgvInventoryTable.DataSource = new InventoryDAO().InventoryTableSelect();
            dgvInventoryTable.AllowUserToAddRows = false;
        }

        /// <summary>
        /// 재고사용내역 폼 띄우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRelease_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryUseDetails inventoryUseDetails =
                    new InventoryUseDetails(dgvInventoryTable.SelectedRows[0].Cells["입고번호"].Value.ToString(),
                    dgvInventoryTable.SelectedRows[0].Cells["유통기한"].Value.ToString());
                inventoryUseDetails.ShowDialog();
                InventoryTableSelect();
                InventoryTypeSelect();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("먼저 재고내역을 선택해주세요");
            }
        }
        
        #endregion

        #region 재고종류
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
            //inventoryTypeVOList = new InventoryTypeDAO().InventoryTypeSelect();
            inventoryTypeDateTable = new InventoryTypeDAO().InventoryTypeSelect();
            dgvInventoryType.DataSource = inventoryTypeDateTable;
            dgvInventoryType.AllowUserToAddRows = false;
            dgvInventoryType.Columns["재고종류코드"].ReadOnly = true;
            dgvInventoryType.Columns["재고합계"].ReadOnly = true;
            dgvInventoryType.Columns["재고총량"].ReadOnly = true;

            dgvInventoryType.Columns["재고명"].HeaderText = "재고명*";
            dgvInventoryType.Columns["입고정량"].HeaderText = "입고정량*";
            dgvInventoryType.Columns["최소재고"].HeaderText = "최소재고*";
            dgvInventoryType.Columns["재료구분"].HeaderText = "재료구분*";

            #region 재고종류테이블 컬럼명 변경
            //dgvInventoryType.Columns["InventoryTypeCode"].HeaderText = "재고종류코드";
            //dgvInventoryType.Columns["ReceivingQuantity"].HeaderText = "입고정량";
            //dgvInventoryType.Columns["InventoryName"].HeaderText = "재고명";
            //dgvInventoryType.Columns["MaterialClassification"].HeaderText = "재료구분";
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
                new InventoryTypeDAO().InventoryTypeDelete(dgvInventoryType.SelectedRows[0].Cells["재고종류코드"].Value.ToString());
            }
            catch (SqlException)
            {
                MessageBox.Show("수정만 가능합니다.");
            }
            InventoryTypeSelect();
        }

        /// <summary>
        /// 재고종류 업데이트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InventoryTypeVO inventoryTypeVO = new InventoryTypeVO()
            {
                InventoryTypeCode = dgvInventoryType.SelectedRows[0].Cells["재고종류코드"].Value.ToString(),
                ReceivingQuantity = Int32.Parse(dgvInventoryType.SelectedRows[0].Cells["입고정량"].Value.ToString()),
                MinimumQuantity = Int32.Parse(dgvInventoryType.SelectedRows[0].Cells["최소재고"].Value.ToString()),
                InventoryName = dgvInventoryType.SelectedRows[0].Cells["재고명"].Value.ToString(),
                MaterialClassification = dgvInventoryType.SelectedRows[0].Cells["재료구분"].Value.ToString(),
            };

            new InventoryTypeDAO().InventoryTypeUpdate(inventoryTypeVO);
            InventoryTypeSelect();
        }
        #endregion

        #region 재고테이블 선택 시 재고종류 선택
        /// <summary>
        /// 재고테이블에서 마우스로 row선택 시 해당 물품의 재고종류가 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInventoryTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            InventoryTableRowSelected();
        }

        /// <summary>
        /// 재고테이블 선택 시 해당 재고종류 선택하기
        /// </summary>
        private void InventoryTableRowSelected()
        {
            dgvInventoryType.ClearSelection();


            if (InventoryTableTemp)
            {
                for (int i = 0; i < dgvInventoryType.Rows.Count; i++)
                {
                    if (dgvInventoryType["재고종류코드", i].Value.ToString() == dgvInventoryTable.SelectedRows[0].Cells["재고종류코드"].Value.ToString())
                    {

                        dgvInventoryType["재고종류코드", i].Selected = true;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 재고테이블에서 방향키로 row선택 시 해당 물품의 재고종류가 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInventoryTable_KeyUp(object sender, KeyEventArgs e)
        {
            InventoryTableRowSelected();
        }

        #endregion

        #region 발주내역

        /// <summary>
        /// 발주내역 산출 버튼으로 입고내역에 있는 반품,교환 내역과 재고종류의 모든 재고에 대한 내역을 산출한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderDisplay_Click(object sender, EventArgs e)
        {
            CalculationOrderDetails();
            dgvNeedInventoryDetailView.Columns["재고종류코드"].ReadOnly = true;
            dgvNeedInventoryDetailView.Columns["재고명"].ReadOnly = true;
            dgvNeedInventoryDetailView.Columns["현재수량"].ReadOnly = true;
            dgvNeedInventoryDetailView.Columns["발주종류"].ReadOnly = true;

            dgvNeedInventoryDetailView.Columns["필요수량"].HeaderText = "필요수량*";



            btnSaveOrderDetails.Enabled = true;
            btnExcelExport.Enabled = false;
            btnAddOrder.Enabled = btnUpdateOrder.Enabled = false;
        }
        /// <summary>
        /// 발주내역 산출
        /// </summary>
        public void CalculationOrderDetails()
        {
            dgvNeedInventoryDetailView.DataSource = null;
            dgvNeedInventoryDetailView.DataSource = new InventoryTypeDAO().InventoryTypeNeedSelect();
        }

        /// <summary>
        /// 발주내역을 DB에 저장 시키고 입고내역의 교환이나 반품은 교환완이나 반품완으로 수정한다. 그리고 발주내역 LIST에 날짜로 출력시켜준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveOrderDetails_Click(object sender, EventArgs e)
        {
            orderDetailsVOsList = new List<OrderDetailsVO>();
            string date = DateTime.Now.ToShortDateString().Replace("-", "").Substring(2, 6);
            for (int i = 0; i < dgvNeedInventoryDetailView.Rows.Count; i++)
            {
                if (Int32.Parse(dgvNeedInventoryDetailView["필요수량", i].Value.ToString()) > 0)
                {
                    OrderDetailsVO orderDetailsVO = new OrderDetailsVO();

                    if (dgvNeedInventoryDetailView["발주종류", i].Value.ToString() == "주문")
                    {
                        orderDetailsVO.OrderID = "OR" + date + (dgvNeedInventoryDetailView["재고종류코드", i].Value.ToString()).Substring(4, 2);
                    }
                    else if (dgvNeedInventoryDetailView["발주종류", i].Value.ToString().Contains("반품"))
                    {
                        orderDetailsVO.OrderID = "RE" + date + (dgvNeedInventoryDetailView["재고종류코드", i].Value.ToString()).Substring(4, 2);
                        new ReceivingDetailsDAO().UpdateReceivingDetails(dgvNeedInventoryDetailView["발주종류", i].Value.ToString().Substring(2, 10),
                            dgvNeedInventoryDetailView["발주종류", i].Value.ToString().Substring(0, 2));
                    }
                    else if (dgvNeedInventoryDetailView["발주종류", i].Value.ToString().Contains("교환"))
                    {
                        orderDetailsVO.OrderID = "EX" + date + (dgvNeedInventoryDetailView["재고종류코드", i].Value.ToString()).Substring(4, 2);
                        new ReceivingDetailsDAO().UpdateReceivingDetails(dgvNeedInventoryDetailView["발주종류", i].Value.ToString().Substring(2, 10),
                            dgvNeedInventoryDetailView["발주종류", i].Value.ToString().Substring(0, 2));
                    }
                    orderDetailsVO.OrderDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    orderDetailsVO.InventoryTypeCode = dgvNeedInventoryDetailView["재고종류코드", i].Value.ToString();
                    orderDetailsVO.Quantity = Int32.Parse(dgvNeedInventoryDetailView["필요수량", i].Value.ToString());
                    orderDetailsVOsList.Add(orderDetailsVO);
                }
            }
            bool temp = false;
            try
            {
                for (int i = 0; i < dgvOrderDetailsList.Rows.Count; i++)
                {
                    if (dgvOrderDetailsList["발주날짜", i].Value.ToString() == DateTime.Now.ToShortDateString())
                    {
                        temp = true;
                        MessageBox.Show("이미 발주처리되었습니다. 발주내역List에서 수정하시기 바랍니다.");
                    }
                }
                if (!temp)
                {
                    new OrderDetailsDAO().InsertOrderDetails(orderDetailsVOsList);
                    MessageBox.Show("발주내역 저장완료");
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("이미 발주처리되었습니다. 발주내역List에서 수정하시기 바랍니다.");
            }



            SelectOrderDetailsList();
        }

        /// <summary>
        /// 발주내역 List 출력
        /// </summary>
        private void SelectOrderDetailsList()
        {
            orderDetailsDataTable = new OrderDetailsDAO().SelectOrderDetailsList();
            dgvOrderDetailsList.DataSource = orderDetailsDataTable;
        }

        /// <summary>
        /// 발주내역 List Double Click 시 상세내역 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOrderDetailsList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderDetailsListSelect();
        }
        
        /// <summary>
        /// 발주내역 List 에서 상세내역 출력하기
        /// </summary>
        private void OrderDetailsListSelect()
        {
            btnSaveOrderDetails.Enabled = false;
            btnUpdateOrder.Enabled = btnAddOrder.Enabled = btnExcelExport.Enabled = true;

            //dgvNeedInventoryDetailView.DataSource = null;
            OrderDetailsListDataTable = new OrderDetailsDAO().SelectOrderDetails(dgvOrderDetailsList.SelectedRows[0].Cells["발주날짜"].Value.ToString());
            dgvNeedInventoryDetailView.DataSource = OrderDetailsListDataTable;
            dgvNeedInventoryDetailView.Columns["발주번호"].ReadOnly = true;
            dgvNeedInventoryDetailView.Columns["재고명"].ReadOnly = true;
            dgvNeedInventoryDetailView.Columns["재고종류코드"].ReadOnly = true;

            dgvNeedInventoryDetailView.Columns["수량"].HeaderText = "수량*";


        }

        /// <summary>
        /// 발주내역서 Excel로 추출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            OrderDetailsListDataTable = new OrderDetailsDAO().SelectOrderDetails(dgvOrderDetailsList.SelectedRows[0].Cells["발주날짜"].Value.ToString());
            dgvNeedInventoryDetailView.DataSource = OrderDetailsListDataTable;
            Excel.Application excelApp = null;
            try
            {
                excelApp = new Excel.Application();
            }
            catch (Exception)
            {
            }
            if (excelApp == null)
            {
                MessageBox.Show("Excel 응용 프로그램을 찾을 수 없거나, 설치되지 않았습니다.");
                return;
            }

            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            object missingValue = System.Reflection.Missing.Value;

            workbook = excelApp.Workbooks.Open(Application.StartupPath + "\\Excel\\OrderDetails.xlsx");
            worksheet = workbook.Sheets.Item[1];
            worksheet.Cells[2, 5] = dgvOrderDetailsList.SelectedRows[0].Cells["발주날짜"].Value.ToString();
            for (int i = 4; i < dgvNeedInventoryDetailView.Rows.Count + 4; i++)
            {
                if (Int32.Parse(dgvNeedInventoryDetailView["수량", i - 4].Value.ToString()) > 0)
                {
                    worksheet.Cells[i, 1] = i - 3;
                    worksheet.Cells[i, 2] = dgvNeedInventoryDetailView["발주번호", i - 4].Value.ToString();
                    worksheet.Cells[i, 3] = dgvNeedInventoryDetailView["재고명", i - 4].Value.ToString();
                    worksheet.Cells[i, 4] = dgvNeedInventoryDetailView["수량", i - 4].Value.ToString();
                    worksheet.Cells[i, 5] = dgvNeedInventoryDetailView["재고종류코드", i - 4].Value.ToString();

                    Excel.Range r = worksheet.get_Range((object)worksheet.Cells[i + 1, 1], (object)worksheet.Cells[i + 1, 5]).EntireRow;
                    r.Insert(Excel.XlInsertShiftDirection.xlShiftDown, missingValue);
                }
            }


            string s = dgvOrderDetailsList.SelectedRows[0].Cells["발주날짜"].Value.ToString().Replace("-", "");
            try
            {
                workbook.SaveAs(Application.StartupPath + @"\" + s + "발주내역서.xls", Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingValue, missingValue, missingValue, missingValue);
            }
            catch (Exception)
            {
                throw;
            }
            excelApp.Quit();
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelApp);
        }

        /// <summary>
        /// 발주내역 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            List<OrderDetailsVO> orderDetailsVOList = new List<OrderDetailsVO>();
            for (int i = 0; i < dgvNeedInventoryDetailView.Rows.Count; i++)
            {
                var orderDetailsVO = new OrderDetailsVO();
                orderDetailsVO.OrderID = dgvNeedInventoryDetailView["발주번호", i].Value.ToString();
                orderDetailsVO.Quantity = Int32.Parse(dgvNeedInventoryDetailView["수량", i].Value.ToString());
                orderDetailsVOList.Add(orderDetailsVO);
            }
            new OrderDetailsDAO().UpdateOrderDetails(orderDetailsVOList);
            dgvNeedInventoryDetailView.DataSource = new OrderDetailsDAO().SelectOrderDetails(dgvOrderDetailsList.SelectedRows[0].Cells["발주날짜"].Value.ToString());
            MessageBox.Show("발주내역이 수정되었습니다.");
        }

        /// <summary>
        /// 발주내역 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OrderDetailsAdd orderDetailsAdd = new OrderDetailsAdd(OrderDetailsListDataTable);
            if (orderDetailsAdd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("저장완료");
                OrderDetailsListSelect();
            }
        }
        #endregion

        /// <summary>
        /// 재고종류 테이블 데이터입력 에러 시 에러박스출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInventoryType_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("숫자를 입력해주세요");
        }
        /// <summary>
        /// 재고내역 테이블 데이터입력 에러 시 에러박스출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvNeedInventoryDetailView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("숫자를 입력해주세요");
        }

        /// <summary>
        /// 입고버튼 클릭 시 입고 창 띄우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceiving_Click(object sender, EventArgs e)
        {
            //MenuPanel.Dock = DockStyle.None;
            //pnbReceiving.Dock = DockStyle.None;
            //pnmInventory.Dock = DockStyle.None;
            //MenuPanel.Dock = DockStyle.Top;
            //pnbReceiving.Dock = DockStyle.Bottom;
            pnmReceiving.Dock = DockStyle.Fill;
            pnmReceiving.BringToFront();
            btnReturnAdd.Visible = btnLoadingFile.Visible = btnReceivingDetailsSave.Visible = true;
            btnNewTable.Visible = btnInventoryTypeAdd.Visible = btnUpdate.Visible = btnDelete.Visible = btnRelease.Visible= btnInventoryNewSelect.Visible= false;
            btnAddOrder.Visible = btnUpdateOrder.Visible = btnSaveOrderDetails.Visible = btnExcelExport.Visible = btnOrderDisplay.Visible = false;
        }

        /// <summary>
        /// 재고버튼 클릭 시 입고 창 띄우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventory_Click(object sender, EventArgs e)
        {
            //MenuPanel.Dock = DockStyle.None;
            //pnbReceiving.Dock = DockStyle.None;
            //pnmInventory.Dock = DockStyle.None;
            //MenuPanel.Dock = DockStyle.Top;
            //pnbReceiving.Dock = DockStyle.Bottom;
            pnmInventory.Dock = DockStyle.Fill;
            pnmInventory.BringToFront();
            btnReturnAdd.Visible = btnLoadingFile.Visible = btnReceivingDetailsSave.Visible = false;
            btnNewTable.Visible = btnInventoryTypeAdd.Visible = btnUpdate.Visible = btnDelete.Visible = btnRelease.Visible = btnInventoryNewSelect.Visible = true;
            btnAddOrder.Visible = btnUpdateOrder.Visible = btnSaveOrderDetails.Visible = btnExcelExport.Visible = btnOrderDisplay.Visible = false;
        }
        /// <summary>
        /// 발주버튼 클릭 시 입고 창 띄우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //MenuPanel.Dock = DockStyle.None;
            //pnbReceiving.Dock = DockStyle.None;
            //pnmInventory.Dock = DockStyle.None;
            //MenuPanel.Dock = DockStyle.Top;
            //pnbReceiving.Dock = DockStyle.Bottom;
            pnmOrder.Dock = DockStyle.Fill;
            pnmOrder.BringToFront();
            btnReturnAdd.Visible = btnLoadingFile.Visible = btnReceivingDetailsSave.Visible = false;
            btnNewTable.Visible = btnInventoryTypeAdd.Visible = btnUpdate.Visible = btnDelete.Visible = btnRelease.Visible = btnInventoryNewSelect.Visible = false;
            btnAddOrder.Visible = btnUpdateOrder.Visible = btnSaveOrderDetails.Visible = btnExcelExport.Visible = btnOrderDisplay.Visible = true;
        }
    }
}
