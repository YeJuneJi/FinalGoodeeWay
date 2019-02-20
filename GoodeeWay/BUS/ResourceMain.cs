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

namespace GoodeeWay.BUS
{
    public partial class ResourceMain : UserControl
    {
        private bool mainDragging = false;
        private int mainPanelOffsetX, mainPanelOffsetY;
        float netIncome;
        DataTable totRsrcTab;
        DataColumn[] dataColumns;
        List<EquipmentVO> equipmentList;
        List<SaleRecordsVO> saleRecordList;
        List<InventoryTypeVO> convertInventoryTypetoList;
        List<ReceivingDetailsVO> receivingDetailList;
        DataTable inventoryTypeList;
        List<ResourceManagementVO> totInvestList;
        List<ResourceManagementVO> equipList;
        List<ResourceManagementVO> mergeList;

        public ResourceMain()
        {
            InitializeComponent();
            totInvestList = new List<ResourceManagementVO>();
            equipList = new List<ResourceManagementVO>();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            totRsrcTab.Rows.Clear();
            lbltotalInvesetPrice.Text = "총매출 : ";
            lblRawMaterialCost.Text = "총 원재료비: ";
            lblEquipPrice.Text = "총 비품비: ";
            lblEmployeeCost.Text = "총 인사비 : ";

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

                var dayPerRealTot = from records in (from saleRecord in saleRecordList
                                                     where saleRecord.SalesDate >= periodStart && saleRecord.SalesDate <= periodEnd
                                                     select new { SalesDate = saleRecord.SalesDate.Date, Stotal = saleRecord.SalesTotal, SitemName = saleRecord.SalesitemName })
                                    group records by records.SalesDate;

                var dayPerEquipPriceTot = from equips in (from equipment in equipmentList
                                                          let equipDate = equipment.PurchaseDate.Date
                                                          where equipment.PurchaseDate >= periodStart && equipment.PurchaseDate <= periodEnd
                                                          select new { equipDate, equipment.PurchasePrice })
                                          group equips by equips.equipDate;

                var calUnitPrice = from inven in convertInventoryTypetoList
                                   join rcv in receivingDetailList
                                   on inven.InventoryTypeCode equals rcv.InventoryTypeCode
                                   select new
                                   {
                                       InventoryTypeCode = inven.InventoryTypeCode,
                                       UnitPrice = rcv.UnitPrice
                                   };

                //총 매출과 원 재료비 계산을 위한 반복문
                foreach (var item in dayPerRealTot)
                {
                    float rawMaterialCost = 0;
                    float investSum = 0;
                    foreach (var group in item)
                    {
                        investSum += group.Stotal;
                        #region jsonParsing 분석
                        RealMenuVO rv = JsonConvert.DeserializeObject<RealMenuVO>(group.SitemName);
                        foreach (var real in rv.RealMenu)
                        {
                            if (real.Menu.Division.Equals(Convert.ToString((int)Division.샌드위치)))
                            {
                                foreach (var item2 in real.MenuDetailList)
                                {
                                    foreach (var gazua in calUnitPrice)
                                    {
                                        if (item2.InventoryTypeCode.Equals(gazua.InventoryTypeCode))
                                        {
                                            //tbxResult.Text += "재료이름 : " + item2.InventoryName + "\r\n";
                                            rawMaterialCost += gazua.UnitPrice;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                rawMaterialCost += real.Menu.Price;
                                //tbxResult.Text += "메뉴이름 : " + real.Menu.MenuName + "\r\n" + real.Menu.Price;
                            }
                        }
                        #endregion
                    }
                    totInvestList.Add(new ResourceManagementVO() { ResourceDate = item.Key, RawMaterialCost = rawMaterialCost, TotInvestPrice = investSum });
                }

                //비품비 계산을 위한 반복문
                foreach (var item in dayPerEquipPriceTot)
                {
                    float sum = 0;
                    foreach (var group in item)
                    {
                        sum += group.PurchasePrice;
                    }
                    equipList.Add(new ResourceManagementVO() { ResourceDate = item.Key, EquipPrice = sum });
                }

                mergeList = totInvestList.Union(equipList).OrderBy(mlist => mlist.ResourceDate).ToList();


                float totalInvesetPrice = 0; //매출액
                float RawMaterialCost = 0;//원재료비
                float EquipPrice = 0;//비품비
                float EmployeePrice = 0;//직원급여
                foreach (var item in mergeList)
                {
                    float netProfit = item.TotInvestPrice - item.RawMaterialCost - item.EquipPrice;
                    var tempEmployee = 50000;
                    totRsrcTab.Rows.Add(item.ResourceDate.ToShortDateString(), (decimal)item.TotInvestPrice, (decimal)item.RawMaterialCost, (decimal)item.EquipPrice, /*인사급여*/(decimal)tempEmployee, (decimal)netProfit);
                    EquipPrice += item.EquipPrice;
                    RawMaterialCost += item.RawMaterialCost;
                    EmployeePrice += tempEmployee;
                    totalInvesetPrice += item.TotInvestPrice;
                }

                if (rdoDate.Checked)
                {
                    lbltotalInvesetPrice.Text += ((decimal)totalInvesetPrice).ToString();
                    lblRawMaterialCost.Text += ((decimal)RawMaterialCost).ToString();
                    lblEquipPrice.Text += ((decimal)EquipPrice).ToString();
                    lblEmployeeCost.Text += ((decimal)EmployeePrice).ToString();
                    resourceDataGView.DataSource = totRsrcTab;
                }
                else if (rdoMonth.Checked)
                {
                    resourceDataGView.DataSource = null;
                }
                
                
                
            }
        }
    }
}
