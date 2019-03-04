using GoodeeWay.DAO;
using GoodeeWay.VO;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System;
using Newtonsoft.Json;
using System.Drawing;
using System.Data.SqlClient;

namespace GoodeeWay.BUS
{
    public enum Period { Date, Month, Year };
    /// <summary>
    /// 매출현황 및 그래프를 출력하기위한 <C>ResourceMain</C> 클래스
    /// </summary>
    public partial class ResourceMain : UserControl
    {
        ///<value>총 매출현황 출력을 위한 Datatable</value>
        DataTable totRsrcTab;
        DataColumn[] dataColumns;
        ///<value>총 비품내역 검색내용을 저장할 equipmentList</value>
        List<EquipmentVO> equipmentList;
        ///<value>총 판매기록 검색내용을 저장할 saleRecordList</value>
        List<SaleRecordsVO> saleRecordList;
        ///<value>총 인사급여 검색내용을 저장할 salaryList</value>
        List<SalaryVO> salaryList;
        ///<value>총 재고종류 검색내용을 저장할 convertInventoryTypetoList</value>
        List<InventoryTypeVO> convertInventoryTypetoList;
        ///<value>총 입고내역 검색내용을 저장할 receivingDetailList</value>
        List<ReceivingDetailsVO> receivingDetailList;

        DataTable inventoryTypeList;
        List<ResourceManagementVO> totInvestList;
        List<ResourceManagementVO> equipList;
        List<ResourceManagementVO> salList;
        List<ResourceManagementVO> mergeList;
        ///<value>총 매출현황을 차트로 나타내기 위한 frmResourceChart </value>
        FrmResourceChart frmResourceChart;

        public ResourceMain()
        {
            InitializeComponent();
            totInvestList = new List<ResourceManagementVO>();
            equipList = new List<ResourceManagementVO>();
            salList = new List<ResourceManagementVO>();
            mergeList = new List<ResourceManagementVO>();
            resourceDataGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            catch (SqlException except)
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
            //var calUnitPrice = from inven in convertInventoryTypetoList
            //                   join rcv in receivingDetailList
            //                   on inven.InventoryTypeCode equals rcv.InventoryTypeCode
            //                   select new
            //                   {
            //                       InventoryTypeCode = inven.InventoryTypeCode,
            //                       UnitPrice = rcv.UnitPrice
            //                   };
            var calUnitPrice = from inven in convertInventoryTypetoList
                               join rcv in receivingDetailList
                               on inven.InventoryTypeCode equals rcv.InventoryTypeCode
                               group rcv by rcv.InventoryTypeCode into temp
                               select new { InventoryTypeCode = temp.Key, Avg = temp.Average(a => a.UnitPrice) };


            //그룹(일별,월별,년별)에따라 총매출, 원재료비, 비품비, 인사비의 총합을 Linq를 사용하여그룹화한 값을 IEnumarable 타입으로 반환.
            switch (period)
            {
                case Period.Date:
                    //일별 총 매출액과 판매물품명을 기간으로 그룹화.
                    var dayPerRealTot = from records in (from saleRecord in saleRecordList
                                                         where saleRecord.SalesDate >= periodStart && saleRecord.SalesDate <= periodEnd && saleRecord.PaymentPlan != "환불"
                                                         select new { SalesDate = saleRecord.SalesDate.Date, Stotal = saleRecord.SalesTotal, SitemName = saleRecord.SalesitemName })
                                        group records by records.SalesDate;
                    //일별총 비품비를 기간으로 그룹화.
                    var dayPerEquipPriceTot = from equips in (from equipment in equipmentList
                                                              where equipment.PurchaseDate >= periodStart && equipment.PurchaseDate <= periodEnd
                                                              select new { PurchaseDate = equipment.PurchaseDate, PurchasePrice = equipment.PurchasePrice })
                                              group equips by equips.PurchaseDate;
                    //일별 인사급여를 기간으로 그룹화.
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
                            //json형식으로된 판매물품명을 매개변수로 받아NuGet 패키지로부터 NewtonSoft의 Json.NET 을 참조받아 Deserializing한다.
                            RealMenuVO rv = JsonConvert.DeserializeObject<RealMenuVO>(group.SitemName);
                            foreach (var realMenu in rv.RealMenu)
                            {//만약 판매메뉴의 구분이 샌드위치라면
                                if (realMenu.Menu.Division.Equals(Convert.ToString((int)Division.샌드위치)))
                                {//샌드위치의 레시피를 반복하며 재료를 찾아
                                    foreach (var menuDetail in realMenu.MenuDetailList)
                                    {//입고내역에 있는 재료단가를 반복시켜서
                                        foreach (var unitPrice in calUnitPrice)
                                        {//재료에 해당되는 단가를 일치시킨후
                                            if (menuDetail.InventoryTypeCode.Equals(unitPrice.InventoryTypeCode))
                                            {//원재료비에 단가를 종합한다.
                                                //rawMaterialCost += unitPrice.UnitPrice ;
                                                rawMaterialCost += unitPrice.Avg ;
                                            }
                                        }
                                    }
                                }
                                else
                                {//만약 판매메뉴의 구분이 샌드위치가 아니라면 판매메뉴 고유의 가격을 원재료비에 종합한다.
                                    rawMaterialCost += realMenu.Menu.Price * (1 - (40 / 100));
                                }
                            }
                            #endregion
                        }
                        //종합한 총매출과 원재료비를 리스트에 반환
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
                                                           where saleRecord.SalesDate.Month >= periodStart.Month && saleRecord.SalesDate.Month <= periodEnd.Month && saleRecord.PaymentPlan != "환불"
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
                                                rawMaterialCost += unitPrice.Avg;
                                                //rawMaterialCost += unitPrice.UnitPrice;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    rawMaterialCost += realMenu.Menu.Price * (1 - (40 / 100));
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
                                                          where saleRecord.SalesDate.Year >= periodStart.Year && saleRecord.SalesDate.Year <= periodEnd.Year && saleRecord.PaymentPlan != "환불"
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
                                               // rawMaterialCost += unitPrice.UnitPrice;
                                                rawMaterialCost += unitPrice.Avg;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    rawMaterialCost += realMenu.Menu.Price * (1 - (40 / 100));
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

        /// <summary>
        /// 통합된 컬렉션의 중복을 제거하기위한 메서드 
        /// </summary>
        private void FetchMergeList()
        {
            mergeList.Clear();
            ///<value>총매출과 원재료비, 비품비, 인사급여를 Union 시켜 리스트로 반환한다.</value>
            var unionTotList = totInvestList.Union(equipList).Union(salList).OrderBy(mlist => mlist.ResourceDate).ToList();
            //Union된 전체 리스트를 반복한다.
            foreach (ResourceManagementVO union in unionTotList)
            {
                bool pick = false;
                
                foreach (var merge in mergeList)
                {//만약 Union된 리스트의 일자와 병합시킬 리스트의 일자가 같다면
                    if (merge.ResourceDate == union.ResourceDate)
                    {
                        pick = true;
                        //병합시킬 리스트의 객체에 중복되는 속성들을 전부 더해 하나의 열로 병합시킨다.
                        merge.TotInvestPrice += union.TotInvestPrice;
                        merge.RawMaterialCost += union.RawMaterialCost;
                        merge.EquipPrice += union.EquipPrice;
                        merge.EmployeePrice += union.EmployeePrice;
                    }
                }
                if (!pick)
                {
                    //중복이 되지않는다면 병합시킬 리스트에 바로 추가한다.
                    mergeList.Add(union);
                }
            }
        }

        /// <summary>
        /// 매출현황별 금액에 3글자 단위 (콤마)','를 삽입하기 위한 메서드
        /// </summary>
        /// <param name="label">콤마를 삽입할 라벨</param>
        /// <param name="txt">콤마를 삽입할 정수의 string값</param>
        private void CommaSet(Label label, string txt)
        {
            for (int i = txt.Length - 3; i > 1; i = i - 3)
            {
                txt = txt.Insert(i, ",");
            }
            label.Text += txt + " 원";
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

                CommaSet(lbltotalInvesetPrice, ((decimal)totalInvesetPrice).ToString());
                CommaSet(lblRawMaterialCost, ((decimal)totRawMaterialCost).ToString());
                CommaSet(lblEquipPrice, ((decimal)totEquipPrice).ToString());
                CommaSet(lblEmployeeCost, ((decimal)totEmployeePrice).ToString());
                CommaSet(lbltotnetProfit, ((decimal)totnetProfit).ToString());
                lbltotnetProfit.ForeColor = Color.Red;
                
                resourceDataGView.DataSource = totRsrcTab;
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            if (frmResourceChart == null || frmResourceChart.IsDisposed)
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
