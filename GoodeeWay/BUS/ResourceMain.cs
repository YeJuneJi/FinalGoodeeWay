using GoodeeWay.DAO;
using GoodeeWay.VO;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using GoodeeWay.Order;
using System.Globalization;

namespace GoodeeWay.BUS
{
    public partial class ResourceMain : UserControl
    {
        decimal netIncome = 0;
        private bool mainDragging = false;
        private int mainPanelOffsetX, mainPanelOffsetY;
        DataTable totRsrcTab;
        DataColumn[] dataColumns;
        List<EquipmentVO> equipmentList;
        List<SaleRecordsVO> saleRecordList;
        List<SalaryVO> salaryList;
        List<InventoryTypeVO> convertInventoryTypetoList;
        List<ReceivingDetailsVO> receivingDetailList;
        DataTable inventoryTypeList;
        List<ResourceManagementVO> totInvestList;
        List<ResourceManagementVO> equipList;
        List<ResourceManagementVO> salList;
        List<ResourceManagementVO> mergeList;
        

        public ResourceMain()
        {
            InitializeComponent();
            totInvestList = new List<ResourceManagementVO>();
            equipList = new List<ResourceManagementVO>();
            salList = new List<ResourceManagementVO>();
            mergeList = new List<ResourceManagementVO>();
            resourceDataGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resourceDataGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            resourceDataGView.AllowUserToAddRows = false;
            dataColumns = new DataColumn[]
            {
                new DataColumn("기간"),
                new DataColumn("총 매출"),
                new DataColumn("원 재료비"),
                new DataColumn("비품비"),
                new DataColumn("인사급여"),
                new DataColumn("순이익"),
            };

            totRsrcTab = new DataTable("totRsrcTab");
            totRsrcTab.Columns.AddRange(dataColumns);

            equipmentList = new EquipmentDAO().AllequipmentVOsList();
            saleRecordList = new SaleRecordsDAO().OutPutAllSaleRecords();
            salaryList = new SalaryDAO().SelectAll();
            inventoryTypeList = new InventoryTypeDAO().InventoryTypeSelect();
            
            convertInventoryTypetoList = (from DataRow rows in inventoryTypeList.Rows
                                          select new InventoryTypeVO()
                                          {
                                              InventoryTypeCode = rows["재고종류코드"].ToString(),
                                          }).ToList();

            receivingDetailList = new ReceivingDetailsDAO().OutPutAllSaleRecords();


        }

        private void ResourceMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.mainDragging = true;
            this.mainPanelOffsetX = e.X;
            this.mainPanelOffsetY = e.Y;
        }

        private void ResourceMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mainDragging)
            {
                this.Left = e.X + this.Left - mainPanelOffsetX;
                this.Top = e.Y + this.Top - mainPanelOffsetY;
            }
        }
        private void ResourceMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.mainDragging = false;
        }

        private void btnNetIncome_Click(object sender, EventArgs e)
        {
            if (netIncome == 0)
            {
                MessageBox.Show("먼저 검색을 해 주세요.");
            }
            else
            {
                lblNetIncome.Text = "약 " + Math.Round(netIncome).ToString() + " 원";
            }
        }

        private void rdobtn_CheckedChanged(object sender, EventArgs e)
        {
            resourceDataGView.DataSource = null;
            totInvestList.Clear();
            equipList.Clear();
            salList.Clear();
            mergeList.Clear();
            RadioButton rdo = sender as RadioButton;
            if (rdo.Name == rdoDate.Name)
            {
                resourceStart.Format = resourceEnd.Format = DateTimePickerFormat.Long;
            }
            else if (rdo.Name == rdoMonth.Name)
            {
                resourceStart.Format = resourceEnd.Format = DateTimePickerFormat.Custom;
                resourceStart.CustomFormat = resourceEnd.CustomFormat = "MMMM";
                resourceStart.ShowUpDown = resourceEnd.ShowUpDown = true;

            }
            else
            {
                resourceStart.Format = resourceEnd.Format = DateTimePickerFormat.Custom;
                resourceStart.CustomFormat = resourceEnd.CustomFormat = "yyyy";
                resourceStart.ShowUpDown = resourceEnd.ShowUpDown = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string totalInvestCost = (tbxTotInvest.Text).Replace(" ", "").Trim();
            string bEP = (tbxBEP.Text).Replace(" ", "").Trim();

            if (ValidateTotInvestandBEP(totalInvestCost, bEP))
            {
                totRsrcTab.Rows.Clear();
                totInvestList.Clear();
                equipList.Clear();
                lbltotalInvesetPrice.Text = "총매출 : ";
                lblRawMaterialCost.Text = "총 원재료비: ";
                lblEquipPrice.Text = "총 비품비: ";
                lblEmployeeCost.Text = "총 인사비 : ";
                bool datecheck = false;
                bool monthcheck = false;
                bool yearcheck = false;
                TimeSpan breakingDawn = new TimeSpan(00, 00, 01);
                TimeSpan eclipse = new TimeSpan(23, 59, 59);
                DateTime periodStart = resourceStart.Value;
                DateTime periodEnd = resourceEnd.Value;
                periodStart = periodStart.Date + breakingDawn;
                periodEnd = periodEnd.Date + eclipse;
                if (DateTime.Parse(periodStart.ToLongDateString()) > DateTime.Parse(periodEnd.ToLongDateString()))
                {
                    MessageBox.Show("시작날이 전날보다 이후 일 수 없습니다.");
                    resourceStart.Value = resourceEnd.Value = DateTime.Now;
                    return;
                }
                else
                {
                    //일별 총 판매액
                    var dayPerRealTot = from records in (from saleRecord in saleRecordList
                                                         where saleRecord.SalesDate >= periodStart && saleRecord.SalesDate <= periodEnd
                                                         select new { SalesDate = saleRecord.SalesDate.Date, Stotal = saleRecord.SalesTotal, SitemName = saleRecord.SalesitemName })
                                        group records by records.SalesDate;

                    //월별 총 판매액
                    var monthPerRealTot = from records in (from saleRecord in saleRecordList
                                                           where saleRecord.SalesDate.Month >= periodStart.Month && saleRecord.SalesDate.Month <= periodEnd.Month
                                                           select new { SalesDate = saleRecord.SalesDate.Month, Stotal = saleRecord.SalesTotal, SitemName = saleRecord.SalesitemName })
                                          group records by records.SalesDate;

                    //연별 총 판매액
                    var yearPerRealTot = from records in (from saleRecord in saleRecordList
                                                          where saleRecord.SalesDate.Year >= periodStart.Year && saleRecord.SalesDate.Year <= periodEnd.Year
                                                          select new { SalesDate = saleRecord.SalesDate.Year, Stotal = saleRecord.SalesTotal, SitemName = saleRecord.SalesitemName })
                                         group records by records.SalesDate;

                    //일별 비품비
                    var dayPerEquipPriceTot = from equips in (from equipment in equipmentList
                                                              let equipDate = equipment.PurchaseDate.Date
                                                              where equipment.PurchaseDate >= periodStart && equipment.PurchaseDate <= periodEnd
                                                              select new { equipDate, equipment.PurchasePrice })
                                              group equips by equips.equipDate;

                    //월별 비품비
                    var monthPerEquipPriceTot = from equips in (from equipment in equipmentList
                                                                where equipment.PurchaseDate.Month >= periodStart.Month && equipment.PurchaseDate.Month <= periodEnd.Month
                                                                select new { EquipDate = equipment.PurchaseDate.Month, PurchasePrice = equipment.PurchasePrice })
                                                group equips by equips.EquipDate;
                    //연별 비품비
                    var yearPerEquipPriceTot = from equips in (from equipment in equipmentList
                                                               where equipment.PurchaseDate.Year >= periodStart.Year && equipment.PurchaseDate.Year <= periodEnd.Year
                                                               select new { EquipDate = equipment.PurchaseDate.Year, PurchasePrice = equipment.PurchasePrice })
                                               group equips by equips.EquipDate;
                    //일별 인건비
                    var dayPerEmployeeSalaryTot = from sals in(from salary in salaryList
                                                               where salary.Payday >= periodStart && salary.Payday <= periodEnd
                                                               select new { Payday = salary.Payday, TotalSalary = salary.TotalSalary })
                                                  group sals by sals.Payday;
                    //월별 인건비
                    var monthPerEmployeeSalaryTot = from sals in (from salary in salaryList
                                                                  where salary.Payday.Month >= periodStart.Month && salary.Payday.Month <= periodEnd.Month
                                                                select new { Payday = salary.Payday.Month, TotalSalary = salary.TotalSalary })
                                                group sals by sals.Payday;
                    //연별 인건비
                    var yearPerEmployeeSalaryTot = from sals in (from salary in salaryList
                                                                  where salary.Payday.Year >= periodStart.Year && salary.Payday.Year <= periodEnd.Year
                                                                 select new { Payday = salary.Payday.Year, TotalSalary = salary.TotalSalary })
                                                    group sals by sals.Payday;

                    //단가 계산을 위한 InventoryType테이블과 ReceivingDetail 테이블의 Join 쿼리
                    var calUnitPrice = from inven in convertInventoryTypetoList
                                       join rcv in receivingDetailList
                                       on inven.InventoryTypeCode equals rcv.InventoryTypeCode
                                       select new
                                       {
                                           InventoryTypeCode = inven.InventoryTypeCode,
                                           UnitPrice = rcv.UnitPrice
                                       };

                    float rawMaterialCost = 0; //그룹별 원재료비 합을 저장할 변수
                    float investSum = 0; //그룹별 총 매출을 저장할 변수.
                    if (rdoDate.Checked)
                    {
                        datecheck = true;
                        lblBEPpredict.Text = Math.Round(Convert.ToDecimal(totalInvestCost) / (Convert.ToDecimal(bEP) * 30)).ToString();
                        ////일별 총 매출과 원 재료비 계산을 위한 반복문
                        foreach (var itemgroup in dayPerRealTot)
                        {
                            //float rawMaterialCost = 0; //그룹별 원재료비 합을 저장할 변수
                            //float investSum = 0; //그룹별 총 매출을 저장할 변수.
                            foreach (var group in itemgroup)
                            {
                                investSum += group.Stotal;
                                #region jsonParsing 분석
                                RealMenuVO rv = JsonConvert.DeserializeObject<RealMenuVO>(group.SitemName);
                                foreach (var realMenu in rv.RealMenu)
                                {
                                    if (realMenu.Menu.Division.Equals(Convert.ToString((int)Division.샌드위치)))
                                    {
                                        foreach (var menuDetail in realMenu.MenuDetailList)
                                        {
                                            foreach (var unitPrice in calUnitPrice)
                                            {
                                                if (menuDetail.InventoryTypeCode.Equals(unitPrice.InventoryTypeCode))
                                                {
                                                    rawMaterialCost += unitPrice.UnitPrice;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        rawMaterialCost += realMenu.Menu.Price;
                                    }
                                }
                                #endregion
                            }
                            totInvestList.Add(new ResourceManagementVO() { ResourceDate = itemgroup.Key, RawMaterialCost = rawMaterialCost, TotInvestPrice = investSum });
                        }

                        //일별 비품비 계산을 위한 반복문
                        foreach (var item in dayPerEquipPriceTot)
                        {
                            float sum = 0;
                            foreach (var group in item)
                            {
                                sum += group.PurchasePrice;
                            }
                            equipList.Add(new ResourceManagementVO() { ResourceDate = item.Key, EquipPrice = sum });
                        }

                        

                        foreach (var item in dayPerEmployeeSalaryTot)
                        {
                            float sum = 0;
                            foreach (var group in item)
                            {
                                sum += group.TotalSalary;
                            }
                            salList.Add(new ResourceManagementVO() { ResourceDate = item.Key, EmployeePrice = sum });
                        }
                        mergeList = totInvestList.Union(equipList).OrderBy(mlist => mlist.ResourceDate).ToList();
                        mergeList = mergeList.Union(salList).OrderBy(mlist => mlist.ResourceDate).ToList();
                    }
                    else if (rdoMonth.Checked)
                    {
                        monthcheck = true;
                        lblBEPpredict.Text = Math.Round(Convert.ToDecimal(totalInvestCost) / Convert.ToDecimal(bEP)).ToString();
                        foreach (var itemgroup in monthPerRealTot)
                        {
                            //float rawMaterialCost = 0; //그룹별 원재료비 합을 저장할 변수
                            //float investSum = 0; //그룹별 총 매출을 저장할 변수.
                            foreach (var group in itemgroup)
                            {
                                investSum += group.Stotal;
                                #region jsonParsing 분석
                                RealMenuVO rv = JsonConvert.DeserializeObject<RealMenuVO>(group.SitemName);
                                foreach (var realMenu in rv.RealMenu)
                                {
                                    if (realMenu.Menu.Division.Equals(Convert.ToString((int)Division.샌드위치)))
                                    {
                                        foreach (var menuDetail in realMenu.MenuDetailList)
                                        {
                                            foreach (var unitPrice in calUnitPrice)
                                            {
                                                if (menuDetail.InventoryTypeCode.Equals(unitPrice.InventoryTypeCode))
                                                {
                                                    //tbxResult.Text += "재료이름 : " + item2.InventoryName + "\r\n";
                                                    rawMaterialCost += unitPrice.UnitPrice;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        rawMaterialCost += realMenu.Menu.Price;
                                        //tbxResult.Text += "메뉴이름 : " + real.Menu.MenuName + "\r\n" + real.Menu.Price;
                                    }
                                }
                                #endregion
                            }
                            DateTime dt = default(DateTime);
                            dt = new DateTime(1, itemgroup.Key, 1) + new TimeSpan(00, 00, 00);
                            totInvestList.Add(new ResourceManagementVO() { ResourceDate = dt, RawMaterialCost = rawMaterialCost, TotInvestPrice = investSum });
                        }

                        foreach (var item in monthPerEquipPriceTot)
                        {
                            float sum = 0;
                            foreach (var group in item)
                            {
                                sum += group.PurchasePrice;
                            }
                            DateTime dt = default(DateTime);
                            dt = new DateTime(1, item.Key, 1) + new TimeSpan(00, 00, 00);
                            equipList.Add(new ResourceManagementVO() { ResourceDate = dt, EquipPrice = sum });
                        }
                        
                        foreach (var item in monthPerEmployeeSalaryTot)
                        {
                            float sum = 0;
                            foreach (var group in item)
                            {
                                sum += group.TotalSalary;
                            }
                            DateTime dt = default(DateTime);
                            dt = new DateTime(1, item.Key, 1) + new TimeSpan(00, 00, 00);
                            salList.Add(new ResourceManagementVO() { ResourceDate = dt, EmployeePrice = sum });
                        }

                        mergeList = totInvestList.Union(equipList).OrderBy(mlist => mlist.ResourceDate.Month).ToList();
                        mergeList = mergeList.Union(salList).OrderBy(mlist => mlist.ResourceDate.Month).ToList();
                        
                    }
                    else if (rdoYear.Checked)
                    {
                        yearcheck = true;
                        lblBEPpredict.Text = Math.Round(Convert.ToDecimal(totalInvestCost) / (Convert.ToDecimal(bEP) / (decimal)3)).ToString();
                        foreach (var itemgroup in yearPerRealTot)
                        {
                            //float rawMaterialCost = 0; //그룹별 원재료비 합을 저장할 변수
                            //float investSum = 0; //그룹별 총 매출을 저장할 변수.
                            foreach (var group in itemgroup)
                            {
                                investSum += group.Stotal;
                                #region jsonParsing 분석
                                RealMenuVO rv = JsonConvert.DeserializeObject<RealMenuVO>(group.SitemName);
                                foreach (var realMenu in rv.RealMenu)
                                {
                                    if (realMenu.Menu.Division.Equals(Convert.ToString((int)Division.샌드위치)))
                                    {
                                        foreach (var menuDetail in realMenu.MenuDetailList)
                                        {
                                            foreach (var unitPrice in calUnitPrice)
                                            {
                                                if (menuDetail.InventoryTypeCode.Equals(unitPrice.InventoryTypeCode))
                                                {
                                                    rawMaterialCost += unitPrice.UnitPrice;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        rawMaterialCost += realMenu.Menu.Price;
                                    }
                                }
                                #endregion
                            }
                            DateTime dt = default(DateTime);
                            dt = new DateTime(itemgroup.Key, 1, 1) + new TimeSpan(00, 00, 00);
                            totInvestList.Add(new ResourceManagementVO() { ResourceDate = dt, RawMaterialCost = rawMaterialCost, TotInvestPrice = investSum });
                        }

                        foreach (var item in yearPerEquipPriceTot)
                        {
                            float sum = 0;
                            foreach (var group in item)
                            {
                                sum += group.PurchasePrice;
                            }
                            DateTime dt = default(DateTime);
                            dt = new DateTime(item.Key, 1, 1) + new TimeSpan(00, 00, 00);

                            equipList.Add(new ResourceManagementVO() { ResourceDate = dt, EquipPrice = sum });
                        }
                        

                        foreach (var item in yearPerEmployeeSalaryTot)
                        {
                            float sum = 0;
                            foreach (var group in item)
                            {
                                sum += group.TotalSalary;
                            }
                            DateTime dt = default(DateTime);
                            dt = new DateTime(item.Key, 1, 1) + new TimeSpan(00, 00, 00);
                            salList.Add(new ResourceManagementVO() { ResourceDate = dt, EmployeePrice = sum });
                        }
                        mergeList = totInvestList.Union(equipList).OrderBy(mlist => mlist.ResourceDate.Year).ToList();
                        mergeList = mergeList.Union(salList).OrderBy(mlist => mlist.ResourceDate.Year).ToList();
                    }


                    //리스트를 총판매액 리스트와 비품비 리스트를 병합후 날짜로 정렬 => 리스트화


                    float totalInvesetPrice = 0; //매출액
                    float totRawMaterialCost = 0;//원재료비
                    float totEquipPrice = 0;//비품비
                    float totEmployeePrice = 0;//직원급여
                    foreach (var item in mergeList)
                    {
                        
                        float netProfit = item.TotInvestPrice - item.RawMaterialCost - item.EquipPrice - item.EmployeePrice;

                        string resourceDate = string.Empty;
                        if (datecheck)
                        {
                            resourceDate = item.ResourceDate.ToShortDateString();
                        }
                        else if (monthcheck)
                        {
                            resourceDate = item.ResourceDate.Month.ToString() + "월";
                        }
                        else if (yearcheck)
                        {
                            resourceDate = item.ResourceDate.Year.ToString() + "년";
                        }
                        totRsrcTab.Rows.Add(resourceDate, (decimal)item.TotInvestPrice, (decimal)item.RawMaterialCost, (decimal)item.EquipPrice, /*인사급여*/(decimal)item.EmployeePrice, (decimal)netProfit);
                        totEquipPrice += item.EquipPrice;
                        totRawMaterialCost += item.RawMaterialCost;
                        totEmployeePrice += item.EmployeePrice;
                        totalInvesetPrice += item.TotInvestPrice;
                    }
                    lbltotalInvesetPrice.Text += ((decimal)totalInvesetPrice).ToString();
                    lblRawMaterialCost.Text += ((decimal)totRawMaterialCost).ToString();
                    lblEquipPrice.Text += ((decimal)totEquipPrice).ToString();
                    lblEmployeeCost.Text += ((decimal)totEmployeePrice).ToString();
                    resourceDataGView.DataSource = totRsrcTab;
                }
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            FrmResourceChart frmResourceChart = new FrmResourceChart(totRsrcTab);
            frmResourceChart.Show();
        }

        private bool ValidateTotInvestandBEP(string totInvest, string bEP)
        {
            bool result = false;
            bool nullResult = false;
            bool typeResult = false;
            bool zeroResult = false;
            if (!(string.IsNullOrEmpty(totInvest) || string.IsNullOrEmpty(bEP)))
            {
                nullResult = true;
            }
            else
            {
                tbxTotInvest.Focus();
                MessageBox.Show("값을 모두 입력 해 주세요!");
                return false;
            }
            if (decimal.TryParse(totInvest, out decimal deciTotinvest) || decimal.TryParse(bEP, out decimal deciBEP))
            {
                typeResult = true;
            }
            else
            {
                tbxTotInvest.Focus();
                MessageBox.Show("숫자만 입력 해 주세요!");
                return false;
            }
            if (decimal.Parse(totInvest) != 0 || decimal.Parse(bEP) != 0)
            {
                zeroResult = true;
            }
            else
            {
                tbxTotInvest.Focus();
                MessageBox.Show("0이외의 숫자만 입력 해 주세요!");
                return false;
            }
            if (nullResult && typeResult && zeroResult)
            {
                result = true;
            }
            return result;
        }
    }
}
