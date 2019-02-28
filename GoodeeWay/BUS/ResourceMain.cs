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
using System.Drawing;
using System.Collections;

namespace GoodeeWay.BUS
{
    public enum Period { Date, Month, Year };

    public partial class ResourceMain : UserControl
    {
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
        FrmResourceChart frmResourceChart;

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

            try
            {
                equipmentList = new EquipmentDAO().AllequipmentVOsList();
                saleRecordList = new SaleRecordsDAO().OutPutAllSaleRecords();
                salaryList = new SalaryDAO().SelectAll();
                inventoryTypeList = new InventoryTypeDAO().InventoryTypeSelect();
                receivingDetailList = new ReceivingDetailsDAO().OutPutAllSaleRecords();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.StackTrace);
            }

            convertInventoryTypetoList = (from DataRow rows in inventoryTypeList.Rows
                                          select new InventoryTypeVO()
                                          {
                                              InventoryTypeCode = rows["재고종류코드"].ToString(),
                                          }).ToList();
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


        /// <summary>
        /// 기간별, 그룹별 매출현황을 출력하기 위한 메서드
        /// </summary>
        /// <param name="periodStart">시작 기간</param>
        /// <param name="periodEnd">종료 기간</param>
        /// <param name="period">일, 월, 년 그룹 단위 선택</param>
        public void SelectResourceList(DateTime periodStart, DateTime periodEnd, Period period)
        {
            float rawMaterialCost = 0; //그룹별 원재료비 합을 저장할 변수
            float investSum = 0; //그룹별 총 매출을 저장할 변수.

            //일별 총 매출과 원 재료비 계산을 위한 반복문
            var calUnitPrice = from inven in convertInventoryTypetoList
                               join rcv in receivingDetailList
                               on inven.InventoryTypeCode equals rcv.InventoryTypeCode
                               select new
                               {
                                   InventoryTypeCode = inven.InventoryTypeCode,
                                   UnitPrice = rcv.UnitPrice
                               };

            switch (period)
            {
                case Period.Date:

                    var dayPerRealTot = from records in (from saleRecord in saleRecordList
                                                         where saleRecord.SalesDate >= periodStart && saleRecord.SalesDate <= periodEnd
                                                         select new { SalesDate = saleRecord.SalesDate.Date, Stotal = saleRecord.SalesTotal, SitemName = saleRecord.SalesitemName })
                                        group records by records.SalesDate;

                    var dayPerEquipPriceTot = from equips in (from equipment in equipmentList
                                                              where equipment.PurchaseDate >= periodStart && equipment.PurchaseDate <= periodEnd
                                                              select new { PurchaseDate = equipment.PurchaseDate, PurchasePrice = equipment.PurchasePrice })
                                              group equips by equips.PurchaseDate;

                    var dayPerEmployeeSalaryTot = from sals in (from salary in salaryList
                                                                where salary.Payday >= periodStart && salary.Payday <= periodEnd
                                                                select new { Payday = salary.Payday, TotalSalary = salary.TotalSalary })
                                                  group sals by sals.Payday;

                    foreach (var itemgroup in dayPerRealTot)
                    {
                        rawMaterialCost = 0; //그룹별 원재료비 합을 저장할 변수
                        investSum = 0; //그룹별 총 매출을 저장할 변수.
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

                    //일별 인사급여 계산을 위한 반복문
                    foreach (var item in dayPerEmployeeSalaryTot)
                    {
                        float sum = 0;
                        foreach (var group in item)
                        {
                            sum += group.TotalSalary;
                        }
                        salList.Add(new ResourceManagementVO() { ResourceDate = item.Key, EmployeePrice = sum });
                    }

                    FetchMergeList();


                    break;

                case Period.Month:
                    var monthPerRealTot = from records in (from saleRecord in saleRecordList
                                                           where saleRecord.SalesDate.Month >= periodStart.Month && saleRecord.SalesDate.Month <= periodEnd.Month
                                                           select new { SalesDate = saleRecord.SalesDate.Month, Stotal = saleRecord.SalesTotal, SitemName = saleRecord.SalesitemName })
                                          group records by records.SalesDate;

                    var monthPerEquipPriceTot = from equips in (from equipment in equipmentList
                                                                where equipment.PurchaseDate.Month >= periodStart.Month && equipment.PurchaseDate.Month <= periodEnd.Month
                                                                select new { PurchaseDate = equipment.PurchaseDate.Month, PurchasePrice = equipment.PurchasePrice })
                                                group equips by equips.PurchaseDate;

                    var monthPerEmployeeSalaryTot = from sals in (from salary in salaryList
                                                                  where salary.Payday.Month >= periodStart.Month && salary.Payday.Month <= periodEnd.Month
                                                                  select new { Payday = salary.Payday.Month, TotalSalary = salary.TotalSalary })
                                                    group sals by sals.Payday;


                    foreach (var itemgroup in monthPerRealTot)
                    {
                        rawMaterialCost = 0; //그룹별 원재료비 합을 저장할 변수
                        investSum = 0; //그룹별 총 매출을 저장할 변수.
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

                    FetchMergeList();
                    break;

                case Period.Year:
                    var yearPerRealTot = from records in (from saleRecord in saleRecordList
                                                          where saleRecord.SalesDate.Year >= periodStart.Year && saleRecord.SalesDate.Year <= periodEnd.Year
                                                          select new { SalesDate = saleRecord.SalesDate.Year, Stotal = saleRecord.SalesTotal, SitemName = saleRecord.SalesitemName })
                                         group records by records.SalesDate;

                    var yearPerEquipPriceTot = from equips in (from equipment in equipmentList
                                                               where equipment.PurchaseDate.Year >= periodStart.Year && equipment.PurchaseDate.Year <= periodEnd.Year
                                                               select new { EquipDate = equipment.PurchaseDate.Year, PurchasePrice = equipment.PurchasePrice })
                                               group equips by equips.EquipDate;

                    var yearPerEmployeeSalaryTot = from sals in (from salary in salaryList
                                                                 where salary.Payday.Year >= periodStart.Year && salary.Payday.Year <= periodEnd.Year
                                                                 select new { Payday = salary.Payday.Year, TotalSalary = salary.TotalSalary })
                                                   group sals by sals.Payday;

                    foreach (var itemgroup in yearPerRealTot)
                    {
                        rawMaterialCost = 0; //그룹별 원재료비 합을 저장할 변수
                        investSum = 0; //그룹별 총 매출을 저장할 변수.
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

                    FetchMergeList();
                    break;
                default:
                    break;
            }
        }

        private void FetchMergeList()
        {
            mergeList.Clear();
            var unionTotList = totInvestList.Union(equipList).Union(salList).OrderBy(mlist => mlist.ResourceDate).ToList();

            foreach (ResourceManagementVO item in unionTotList)
            {
                bool pick = false;

                foreach (var item2 in mergeList)
                {
                    if (item2.ResourceDate == item.ResourceDate)
                    {
                        pick = true;
                        item2.TotInvestPrice += item.TotInvestPrice;
                        item2.RawMaterialCost += item.RawMaterialCost;
                        item2.EquipPrice += item.EquipPrice;
                        item2.EmployeePrice += item.EmployeePrice;
                    }
                }
                if (!pick)
                {
                    mergeList.Add(item);
                }
            }
        }

        /// <summary>
        /// 메서드의 기간 초과 확인 메서드
        /// </summary>
        /// <param name="periodStart">시간 기간</param>
        /// <param name="periodEnd">종료 기간</param>
        /// <returns>검사 성공유무를 반환</returns>
        private bool CheckPeriod(DateTime periodStart, DateTime periodEnd)
        {
            bool result = false;
            if (DateTime.Parse(periodStart.ToLongDateString()) > DateTime.Parse(periodEnd.ToLongDateString()))
            {
                MessageBox.Show("시작날이 전날보다 이후 일 수 없습니다.");
                resourceStart.Value = resourceEnd.Value = DateTime.Now;
                result = true;
                return result;
            }
            return result;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            totRsrcTab.Rows.Clear();
            totInvestList.Clear();
            equipList.Clear();
            salList.Clear();
            lbltotalInvesetPrice.Text = "총매출 : ";
            lblRawMaterialCost.Text = "총 원재료비: ";
            lblEquipPrice.Text = "총 비품비: ";
            lblEmployeeCost.Text = "총 인사비 : ";
            lbltotnetProfit.Text = "총 손익 : ";
            bool datecheck = false;
            bool monthcheck = false;
            bool yearcheck = false;
            TimeSpan breakingDawn = new TimeSpan(00, 00, 01);
            TimeSpan eclipse = new TimeSpan(23, 59, 59);
            DateTime periodStart = resourceStart.Value;
            DateTime periodEnd = resourceEnd.Value;
            periodStart = periodStart.Date + breakingDawn;
            periodEnd = periodEnd.Date + eclipse;

            if (!CheckPeriod(periodStart, periodEnd))
            {
                if (rdoDate.Checked)
                {
                    SelectResourceList(periodStart, periodEnd, Period.Date);
                    datecheck = true;
                }
                else if (rdoMonth.Checked)
                {
                    SelectResourceList(periodStart, periodEnd, Period.Month);
                    monthcheck = true;
                }
                else if (rdoYear.Checked)
                {
                    SelectResourceList(periodStart, periodEnd, Period.Year);
                    yearcheck = true;
                }


                float totalInvesetPrice = 0; //매출액
                float totRawMaterialCost = 0;//원재료비
                float totEquipPrice = 0;//비품비
                float totEmployeePrice = 0;//직원급여
                float totnetProfit = 0; //총 손익
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

                    totRsrcTab.Rows.Add(resourceDate, (decimal)item.TotInvestPrice, (decimal)item.RawMaterialCost, (decimal)item.EquipPrice, (decimal)item.EmployeePrice, (decimal)netProfit);

                    totEquipPrice += item.EquipPrice;
                    totRawMaterialCost += item.RawMaterialCost;
                    totEmployeePrice += item.EmployeePrice;
                    totalInvesetPrice += item.TotInvestPrice;
                    totnetProfit += netProfit;
                }

                lbltotalInvesetPrice.Text += ((decimal)totalInvesetPrice).ToString();
                lblRawMaterialCost.Text += ((decimal)totRawMaterialCost).ToString();
                lblEquipPrice.Text += ((decimal)totEquipPrice).ToString();
                lblEmployeeCost.Text += ((decimal)totEmployeePrice).ToString();
                lbltotnetProfit.Text += ((decimal)totnetProfit).ToString() + "원";
                lbltotnetProfit.ForeColor = Color.Red;
                resourceDataGView.DataSource = totRsrcTab;
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            if (frmResourceChart == null)
            {
                frmResourceChart = new FrmResourceChart(totRsrcTab);
                frmResourceChart.Show();
            }
            else if (frmResourceChart.IsDisposed)
            {
                frmResourceChart = new FrmResourceChart(totRsrcTab);
                frmResourceChart.Show();
            }
            else
            {
                frmResourceChart.BringToFront();
            }
        }
    }
}
