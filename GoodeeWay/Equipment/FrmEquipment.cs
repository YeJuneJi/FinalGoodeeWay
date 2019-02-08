using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.DAO;
using GoodeeWay.VO;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace GoodeeWay.Equipment
{
    public partial class FrmEquipment : Form
    {
        public FrmEquipment()
        {
            InitializeComponent();
        }
        private EquipmentVO tempEquipment;//선택된 비품임시저장
        private DataTable dataTable; //그리드뷰에 연결시킬 데이터 테이블
        private DataRow dataRow;


        private DataTable SetDataTable(List<EquipmentVO> equipmentLst)
        {
            dataTable = new DataTable("Equipment");

            //dataTable.Columns.Add("EQUCode", typeof(string), "비품코드");
            //dataTable.Columns.Add("detailName", typeof(string), "상세명칭");
            //dataTable.Columns.Add("location", typeof(string), "위치");
            //dataTable.Columns.Add("state", typeof(string), "상태");
            //dataTable.Columns.Add("purchasePrice", typeof(float), "구매가격");
            //dataTable.Columns.Add("purchaseDate", typeof(DateTime), "구매날짜");
            //dataTable.Columns.Add("note", typeof(string), "비고");
            
            dataTable.Columns.Add("비품코드", typeof(string));
            dataTable.Columns.Add("상세명칭", typeof(string));
            dataTable.Columns.Add("위치", typeof(string));
            dataTable.Columns.Add("상태", typeof(string));
            dataTable.Columns.Add("구매가격", typeof(float));
            dataTable.Columns.Add("구매날짜", typeof(DateTime));
            dataTable.Columns.Add("비고", typeof(string));
            foreach (var item in equipmentLst)
            {
                dataTable.Rows.Add(item.EQUCode, item.DetailName, item.Location, item.State, item.PurchasePrice, item.PurchaseDate, item.Note);
            }
            return dataTable;
        }
        private void FrmEquipment_Load(object sender, EventArgs e)
        {
            EquipmentDAO dAO = new EquipmentDAO();
            dgvEquipmentList.AllowUserToAddRows = false;
            chbDate.CheckState = CheckState.Unchecked;
            //dgvEquipmentList.DataSource = dAO.AllequipmentVOsList();
            dgvEquipmentList.DataSource = SetDataTable(dAO.AllequipmentVOsList());


            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
                dgvEquipmentList.DataSource = SetDataTable(dAO.SelectSearch(equipment, endDate));
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
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            FrmAddEquipment frmAddEquipment = new FrmAddEquipment();
            frmAddEquipment.ShowDialog();
        }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EquipmentDAO dAO = new EquipmentDAO();
            DialogResult mbResult = MessageBox.Show("정말로 삭제하시겠습니까? 삭제하면 기록에 남지 않습니다.", "비품삭제", MessageBoxButtons.YesNo);

            if (mbResult == DialogResult.Yes)
            {
                dAO.DeleteEquipment(tempEquipment);
            }
            btnSearch_Click(null, null);

        }

        private void txtSearchForPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) || txtPrice.Text.Length > 8)
            {
                e.Handled = true;
            }
        }

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

        private void btnExportAsExcel_Click(object sender, EventArgs e)
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

            for (int i = 0; i < dgvEquipmentList.Rows.Count; i++)
            {
                sheets.Cells[i + 5, 1] = dgvEquipmentList.Rows[i].Cells[0].Value.ToString();
                sheets.Cells[i + 5, 2] = dgvEquipmentList.Rows[i].Cells[1].Value.ToString();
                sheets.Cells[i + 5, 3] = dgvEquipmentList.Rows[i].Cells[2].Value.ToString();
                sheets.Cells[i + 5, 4] = dgvEquipmentList.Rows[i].Cells[3].Value.ToString();
                sheets.Cells[i + 5, 5] = dgvEquipmentList.Rows[i].Cells[4].Value.ToString();
                sheets.Cells[i + 5, 6] = dgvEquipmentList.Rows[i].Cells[6].Value.ToString();
                sheets.Cells[3, 9] = DateTime.Now.ToShortDateString();

            }

            //@"C:\Users\" + Environment.UserName + @"\AppData\GoodeeWay\"
            //FileNameCreate(@"C:\GoodeeWay\", "EQ" + DateTime.Now.ToLongDateString() + ".xls")
            try
            {
                workbook.SaveAs(FileNameCreate(@"C:\Users\" + Environment.UserName + @"\AppData\GoodeeWay\", "EQ" + DateTime.Now.ToLongDateString() + ".xls"), Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingVlaue, missingVlaue, missingVlaue, missingVlaue);
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
            //Marshal.ReleaseComObject(sheets);
            //Marshal.ReleaseComObject(workbook);
            //Marshal.ReleaseComObject(excelApp);
        }
        public string FileNameCreate(string path, string fileName)
        {
            string saveFileName =path+ fileName;


            int dotIndex = fileName.LastIndexOf(".");
            string strname = fileName.Substring(0, dotIndex);
            string extentionName = fileName.Substring(dotIndex);

            bool exist = true;
            int count = 0;

            while (exist)
            {
                string pathCombine = saveFileName; //Path.Combine(path, fileName);
                
                if (File.Exists(pathCombine))

                {
                    count++;
                    saveFileName = path+ strname + "(" + count + ")" + extentionName;
                }
                else
                {
                    exist = false;
                }
            }
            MessageBox.Show(saveFileName);
            return saveFileName;
        }
    }

}
