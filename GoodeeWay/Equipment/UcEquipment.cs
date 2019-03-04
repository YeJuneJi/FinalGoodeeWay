using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using GoodeeWay.VO;
using GoodeeWay.DAO;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace GoodeeWay.Equipment
{
    public partial class UcEquipment : UserControl
    {
        public UcEquipment()
        {
            InitializeComponent();
        }
        private EquipmentVO tempEquipment;//선택된 비품임시저장
        private DataTable dataTable; //그리드뷰에 연결시킬 데이터 테이블

        const int pageRows = 15; //한 page에 보여줄 row의 수
        int currentPage = 1; //현재 페이지를 저장시킬 변수
        int firstNumLocationLength = 15; //페이지 번호 맨앞 숫자 위치정보(panel중간 지점으로 부터 떨어진 길이)
        int totalPage = 0;

        List<EquipmentVO> baseEquipmentLst = new List<EquipmentVO>(); //넘겨받은 전체 데이터
        List<EquipmentVO> tempEquipmentLst = new List<EquipmentVO>(); //페이지당 담을 데이터


        private void UcEquipment_Load(object sender, EventArgs e)
        {
            EquipmentDAO dAO = new EquipmentDAO();
            dgvEquipmentList.AllowUserToAddRows = false;
            chbDate.CheckState = CheckState.Unchecked;
            dgvEquipmentList.DataSource = SetDataTable(dAO.AllequipmentVOsList());
            Paging();
        }

        /// <summary>
        /// 그리드뷰에 들어갈 리스트를 형식에 맞는datatable로 반환
        /// </summary>
        /// <param name="equipmentLst"></param>
        /// <returns></returns>
        private DataTable SetDataTable(List<EquipmentVO> equipmentLst)
        {
            dataTable = new DataTable("Equipment");
            baseEquipmentLst = equipmentLst;
            TempListAdd();


            dataTable.Columns.Add("비품코드", typeof(string));
            dataTable.Columns.Add("상세명칭", typeof(string));
            dataTable.Columns.Add("위치", typeof(string));
            dataTable.Columns.Add("상태", typeof(string));
            dataTable.Columns.Add("구매가격", typeof(float));
            dataTable.Columns.Add("구매날짜", typeof(DateTime));
            dataTable.Columns.Add("비고", typeof(string));
            foreach (var item in tempEquipmentLst)
            {
                dataTable.Rows.Add(item.EQUCode, item.DetailName, item.Location, item.State, item.PurchasePrice, item.PurchaseDate, item.Note);
            }
            return dataTable;
        }

        /// <summary>
        /// 비품등록하는 폼열기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            FrmAddEquipment frmAddEquipment = new FrmAddEquipment();
            frmAddEquipment.ShowDialog();
        }

        /// <summary>
        /// 날짜를 포함하는 데이터인지를 판별
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDate.CheckState == CheckState.Checked)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
            }
            else
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
            }
        }

        /// <summary>
        /// 그리드뷰에 셀을클릭할시 수정,삭제 할 수 있는 곤간에 데이터 삽입
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEquipmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtDetailName.Text = dgvEquipmentList.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLocation.Text = dgvEquipmentList.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dgvEquipmentList.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNote.Text = dgvEquipmentList.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbState.Text = dgvEquipmentList.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dgvEquipmentList.Rows[e.RowIndex].Cells[5].Value.ToString() != "")
                {
                    dtpPurchaseDate.Value = DateTime.Parse(dgvEquipmentList.Rows[e.RowIndex].Cells[5].Value.ToString());
                }

                tempEquipment = new EquipmentVO()
                {
                    EQUCode = dgvEquipmentList.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    DetailName = dgvEquipmentList.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Location = dgvEquipmentList.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    State = dgvEquipmentList.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    PurchasePrice = float.Parse(dgvEquipmentList.Rows[e.RowIndex].Cells[4].Value.ToString()),
                    PurchaseDate = dtpPurchaseDate.Value = DateTime.Parse(dgvEquipmentList.Rows[e.RowIndex].Cells[5].Value.ToString()),
                    Note = dgvEquipmentList.Rows[e.RowIndex].Cells[6].Value.ToString()
                };
                btnModification.Enabled = true;
            }
        }

        /// <summary>
        /// 선택된 데이터 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tempEquipment is null)
            {
                return;
            }
            EquipmentDAO dAO = new EquipmentDAO();
            DialogResult mbResult = MessageBox.Show("정말로 삭제하시겠습니까? 삭제하면 기록에 남지 않습니다.", "비품삭제", MessageBoxButtons.YesNo);

            if (mbResult == DialogResult.Yes)
            {
                try
                {
                    dAO.DeleteEquipment(tempEquipment);
                }
                catch (Exception)
                {

                    MessageBox.Show("삭제하는데 실패 하였습니다", "삭제 실패", MessageBoxButtons.OK);
                }
            }
            btnSearch_Click(null, null);
        }

        /// <summary>
        /// textboxPrice의 format값을 검사하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearchForPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) || txtPrice.Text.Length > 8)
            {
                e.Handled = true;
            }
        }


        #region price textbox의 기본 format값을 지정하는 이벤트
        private void txtSearchForPrice_Leave(object sender, EventArgs e)
        {
            if (txtSearchForPrice.Text == "")
            {
                txtSearchForPrice.Text = "0";
            }
        }

        private void txtSearchForPrice_Enter(object sender, EventArgs e)
        {
            if (txtSearchForPrice.Text == "0")
            {
                txtSearchForPrice.Text = "";
            }
        }
        #endregion


        /// <summary>
        /// 비품 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModification_Click(object sender, EventArgs e)
        {
            DialogResult mbResult = MessageBox.Show("정말로 수정하시겠습니까? 수정기록은 남지 않습니다.", "비품수정", MessageBoxButtons.YesNo);
            if (mbResult == DialogResult.Yes)
            {
                if (tempEquipment.DetailName != txtDetailName.Text || tempEquipment.Location != txtLocation.Text || tempEquipment.PurchasePrice != float.Parse(txtPrice.Text) || tempEquipment.PurchaseDate != dtpPurchaseDate.Value.Date || tempEquipment.Note != txtNote.Text
                || tempEquipment.State != cbState.Text)
                {
                    EquipmentDAO dAO = new EquipmentDAO();
                    tempEquipment.DetailName = txtDetailName.Text;
                    tempEquipment.Location = txtLocation.Text;
                    tempEquipment.PurchasePrice = float.Parse(txtPrice.Text);
                    tempEquipment.PurchaseDate = dtpPurchaseDate.Value.Date;
                    tempEquipment.Note = txtNote.Text;
                    tempEquipment.State = cbState.Text;

                    if (dAO.UpdateEquipment(tempEquipment))
                    {
                        MessageBox.Show("성공적으로 업데이트 했습니다.");
                    }
                    else
                    {
                        MessageBox.Show("업데이트에 실패했습니다.");
                    }
                }
            }
            btnSearch_Click(null, null);
        }


        /// <summary>
        /// 그리드뷰에 있는 파일을 execel로 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportAsExcel_Click(object sender, EventArgs e)
        {
            string fileName = "EQ" + DateTime.Now.ToLongDateString(); //기본 파일이름, 가공되어 saveAs에 들어갈 변수 이름

            sfdExcel.FileName = fileName;
            sfdExcel.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\AppData\GoodeeWay\";
            sfdExcel.Title = "Excel 저장위치 설정";
            sfdExcel.DefaultExt = "xls";
            sfdExcel.Filter = "Xls files(*.xls)|*xls";
            sfdExcel.CreatePrompt = false;
            sfdExcel.OverwritePrompt = false;
            DialogResult address = sfdExcel.ShowDialog();
            if (address == DialogResult.OK)
            {
                fileName = sfdExcel.FileName;
            }
            fileName = FileNameCreate(fileName);


            try
            {
                Excel.Application excelApp = new Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Excel응용 프로그램을 찾을수 없거나, 설치되지 않았습니다.");
                    return;
                }

                Excel.Workbook workbook;
                Excel.Worksheet sheets;

                object missingVlaue = System.Reflection.Missing.Value;
                DirectoryInfo directory = new DirectoryInfo(Application.StartupPath);


                workbook = excelApp.Workbooks.Open(directory.Parent.Parent.Parent.FullName + @"\Equipments\EquipmentExcel.xls");


                sheets = workbook.Sheets.Item[1];

                int writeNum = 0;

                for (int i = 0; i < baseEquipmentLst.Count; i++)
                {

                    sheets.Cells[i + 5, 1] = baseEquipmentLst[i].EQUCode;
                    sheets.Cells[i + 5, 2] = baseEquipmentLst[i].DetailName;
                    sheets.Cells[i + 5, 3] = baseEquipmentLst[i].Location;
                    sheets.Cells[i + 5, 4] = baseEquipmentLst[i].State;
                    sheets.Cells[i + 5, 5] = baseEquipmentLst[i].PurchasePrice.ToString();
                    sheets.Cells[i + 5, 6] = baseEquipmentLst[i].Note;
                    sheets.Cells[3, 9] = DateTime.Now.ToShortDateString();
                    writeNum++;
                }

                try
                {
                    workbook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingVlaue, missingVlaue, missingVlaue, missingVlaue);
                    MessageBox.Show("저장 성공");
                }
                catch (Exception saveExeption)
                {
                    MessageBox.Show(saveExeption.Message);
                    
                }

                workbook.Close(false, missingVlaue, missingVlaue);
                excelApp.Quit();

                Marshal.FinalReleaseComObject(sheets);
                Marshal.FinalReleaseComObject(workbook);
                Marshal.FinalReleaseComObject(excelApp);
            }
            catch (Exception)
            {
                MessageBox.Show("엑셀프로그램이 없습니다. 엑셀을 설치해주세요.");
                throw;
            }

        }


        /// <summary>
        /// 중복된 파일이름을 count하여 이름을 바꿔주는 메서드
        /// </summary>
        /// <param name="pathWithfileName">경로가 포함된 파일이름</param>
        /// <returns></returns>
        public string FileNameCreate(string pathWithfileName)
        {
            string path = Path.GetDirectoryName(pathWithfileName);
            string strname = Path.GetFileNameWithoutExtension(pathWithfileName);
            string extentionName = Path.GetExtension(pathWithfileName);

            bool exist = true;
            int count = 0;
            MessageBox.Show(pathWithfileName);
            while (exist)
            {
                string pathCombine = pathWithfileName; //Path.Combine(path, fileName);

                if (File.Exists(pathCombine))
                {
                    count++;
                    pathWithfileName = path + @"\" + strname + "(" + count + ")" + extentionName;
                }
                else
                {
                    exist = false;
                }
            }
            return pathWithfileName;
        }

        /// <summary>
        /// 동적으로 만들어준 paging link label의  click event
        /// click시 label의 숫자만 뽑아 현재 페이지에 맞게 temp리스트에 넣고 그리드뷰에 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LikButton(object sender, EventArgs e)
        {
            string senderStr = sender.ToString();
            string pageNumber = senderStr.Substring(senderStr.IndexOf("[") + 1, (senderStr.Length) - senderStr.IndexOf("[") - 2);
            currentPage = Int32.Parse(pageNumber);
            TempListAdd();
            dgvEquipmentList.DataSource = SetDataTable(baseEquipmentLst);
        }

        /// <summary>
        /// 보여줘야할 page별 list들을 페이지리스트(tempEquipmentLst)에 넣어준다
        /// </summary>
        private void TempListAdd()
        {
            int datasourcestartIndex = (currentPage - 1) * pageRows;
            tempEquipmentLst = new List<EquipmentVO>();
            for (int i = datasourcestartIndex; i < datasourcestartIndex + pageRows; i++)
            {
                if (i >= baseEquipmentLst.Count)
                    break;

                tempEquipmentLst.Add(baseEquipmentLst[i]);
            }

        }

        /// <summary>
        /// panel의 최대 5개까지 link label을 동적으로 생성시켜준다.
        /// </summary>
        private void Paging()
        {
            pnlPage.Controls.Clear();
            totalPage = baseEquipmentLst.Count % pageRows != 0 ? baseEquipmentLst.Count / pageRows + 1 : baseEquipmentLst.Count / pageRows;
            if (totalPage - currentPage < 5)
            {
                btnNextPage.Enabled = false;
            }
            else
            {
                btnNextPage.Enabled = true;
            }
            if (currentPage < 6)
            {
                btnFrontPage.Enabled = false;
            }
            else
            {
                btnFrontPage.Enabled = true;
            }

            if (totalPage - currentPage >= 4)
            {
                for (int i = 0; i < 5; i++)
                {
                    pnlPage.Controls.Add(new LinkLabel() { Name = "lik" + (i + 1), Text = "[" + (currentPage + i) + "]", LinkColor = Color.DimGray });
                    pnlPage.Controls[i].Location = new Point(pnlPage.Size.Width / 2 - firstNumLocationLength * (5 - i * 2), 5);
                    pnlPage.Controls[i].Size = new Size(30, 12);
                    pnlPage.Controls[i].Click += new EventHandler(LikButton);

                }
            }
            else if (totalPage - currentPage == 3)
            {
                for (int i = 0; i < 4; i++)
                {
                    pnlPage.Controls.Add(new LinkLabel() { Name = "lik" + (i + 1), Text = "[" + (currentPage + i) + "]", LinkColor = Color.DimGray });
                    pnlPage.Controls[i].Location = new Point(pnlPage.Size.Width / 2 - firstNumLocationLength * (4 - i * 2), 5);
                    pnlPage.Controls[i].Size = new Size(30, 12);
                    pnlPage.Controls[i].Click += new EventHandler(LikButton);
                }
            }
            else if (totalPage - currentPage == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    pnlPage.Controls.Add(new LinkLabel() { Name = "lik" + (i + 1), Text = "[" + (currentPage + i) + "]", LinkColor = Color.DimGray });
                    pnlPage.Controls[i].Location = new Point(pnlPage.Size.Width / 2 - firstNumLocationLength * (3 - i * 2), 5);
                    pnlPage.Controls[i].Size = new Size(30, 12);
                    pnlPage.Controls[i].Click += new EventHandler(LikButton);

                }
            }
            else if (totalPage - currentPage == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    pnlPage.Controls.Add(new LinkLabel() { Name = "lik" + (i + 1), Text = "[" + (currentPage + i) + "]", LinkColor = Color.DimGray });
                    pnlPage.Controls[i].Location = new Point(pnlPage.Size.Width / 2 - firstNumLocationLength * (2 - i * 2), 5);
                    pnlPage.Controls[i].Size = new Size(30, 12);
                    pnlPage.Controls[i].Click += new EventHandler(LikButton);
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    pnlPage.Controls.Add(new LinkLabel() { Name = "lik" + (i + 1), Text = "[" + (currentPage + i) + "]", LinkColor = Color.DimGray });
                    pnlPage.Controls[i].Location = new Point(pnlPage.Size.Width / 2 - firstNumLocationLength * (1 - i * 2), 5);
                    pnlPage.Controls[i].Size = new Size(30, 12);
                    pnlPage.Controls[i].Click += new EventHandler(LikButton);
                }
            }
        }

        #region paging버튼 클릭 이벤트
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;

            dgvEquipmentList.DataSource = SetDataTable(baseEquipmentLst);
            Paging();
            if (currentPage + 4 < totalPage)
            {
                btnNextPage.Enabled = true;
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPage = totalPage % 5 != 0 ? (6 - (totalPage % 5)) + totalPage - 5 : totalPage - 4;
            Paging();
            currentPage = totalPage;
            dgvEquipmentList.DataSource = SetDataTable(baseEquipmentLst);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage = currentPage % 5 != 0 ? (6 - (currentPage % 5)) + currentPage : currentPage + 1;
            dgvEquipmentList.DataSource = SetDataTable(baseEquipmentLst);
            Paging();
        }

        private void btnFrontPage_Click(object sender, EventArgs e)
        {
            currentPage = currentPage % 5 != 0 ? currentPage - (4 + (currentPage % 5)) : currentPage - 9;
            dgvEquipmentList.DataSource = SetDataTable(baseEquipmentLst);
            Paging();
        }
        #endregion

        /// <summary>
        /// 검색 기능 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            EquipmentDAO dAO = new EquipmentDAO();
            string tempState = "";
            if (rbDiscard.Checked)
            {
                tempState = "폐기";
            }
            else if (rbUsing.Checked)
            {
                tempState = "사용중";
            }
            else if (rbReplacementRequest.Checked)
            {
                tempState = "교체요망";
            }

            if (chbDate.Checked)
            {
                if (!(dtpStartDate.Value < dtpEndDate.Value))
                {
                    DateTime temp = dtpEndDate.Value;
                    dtpEndDate.Value = dtpStartDate.Value;
                    dtpStartDate.Value = temp;

                }

                EquipmentVO equipment = new EquipmentVO()
                {
                    DetailName = txtSearchForName.Text,
                    Location = txtSearchForLocation.Text,
                    PurchaseDate = dtpStartDate.Value,
                    PurchasePrice = float.Parse(txtSearchForPrice.Text),
                    State = tempState
                };

                DateTime endDate = dtpEndDate.Value;
                try
                {
                    dgvEquipmentList.DataSource = SetDataTable(dAO.SelectSearch(equipment, endDate));
                }
                catch (Exception)
                {

                    MessageBox.Show("검색오류");
                }
            }
            else
            {
                EquipmentVO equipment = new EquipmentVO()
                {
                    DetailName = txtSearchForName.Text,
                    Location = txtSearchForLocation.Text,
                    PurchaseDate = DateTime.Parse("1753-1-1"),
                    PurchasePrice = float.Parse(txtSearchForPrice.Text),
                    State = tempState
                };
                dgvEquipmentList.DataSource = SetDataTable(dAO.SelectSearch(equipment, DateTime.Parse("1753-1-1")));

            }
            Paging();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
