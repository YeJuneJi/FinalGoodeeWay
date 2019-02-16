using GoodeeWay.DAO;
using GoodeeWay.VO;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System;

namespace GoodeeWay.BUS
{
    public partial class ResourceMain : UserControl
    {
        private bool mainDragging = false;
        private int mainPanelOffsetX, mainPanelOffsetY;
        DataTable totRsrcTab;
        DataColumn[] dataColumns;
        List<EquipmentVO> equipmentList;
        List<SaleRecordsVO> saleRecordList;
        List<ResourceManagementVO> totInvestList;
        List<ResourceManagementVO> equipList;

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
                new DataColumn("관리비"),
                new DataColumn("인사급여"),
                new DataColumn("기타"),
                new DataColumn("순이익"),
            };

            totRsrcTab = new DataTable("totRsrcTab");
            totRsrcTab.Columns.AddRange(dataColumns);

            equipmentList = new EquipmentDAO().AllequipmentVOsList();
            saleRecordList = new SaleRecordsDAO().OutPutAllSaleRecords();

            //MessageBox.Show(Convert.ToDateTime(equipmentList[0].PurchaseDate).ToLongDateString());


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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            totRsrcTab.Rows.Clear();
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
                                                     let salesDate = saleRecord.SalesDate.Date
                                                     where saleRecord.SalesDate >= periodStart && saleRecord.SalesDate <= periodEnd
                                                     select new { salesDate, saleRecord.SalesTotal })
                                    group records by records.salesDate;

                var dayPerEquipPriceTot = from equips in (from equipment in equipmentList
                                                          let equipDate = equipment.PurchaseDate.Date
                                                          where equipment.PurchaseDate >= periodStart && equipment.PurchaseDate <= periodEnd
                                                          select new { equipDate, equipment.PurchasePrice })
                                          group equips by equips.equipDate;


                foreach (var item in dayPerRealTot)
                {
                    float sum = 0;
                    foreach (var group in item)
                    {
                        sum += group.SalesTotal;
                    }
                    totInvestList.Add(new ResourceManagementVO() { ResourceDate = item.Key, TotInvestPrice = sum });
                }
                foreach (var item in dayPerEquipPriceTot)
                {
                    float sum = 0;
                    foreach (var group in item)
                    {
                        sum += group.PurchasePrice;
                    }
                    equipList.Add(new ResourceManagementVO() { ResourceDate = item.Key, EquipPrice = sum });
                }

                var mergeList = totInvestList.Union(equipList).OrderBy(x => x.ResourceDate).ToList();
                float fixedCost = 0;//고정비
                float variableCost = 0; ; //변동비
                float totalInvesetPrice = 0;
                foreach (var item in mergeList)
                {
                    
                    totRsrcTab.Rows.Add(item.ResourceDate.ToShortDateString(), item.TotInvestPrice, item.EquipPrice, /*관리비*/0, /*인사급여*/0, /*기타*/0, /*순이익*/0);
                    variableCost += item.EquipPrice;
                    fixedCost += 
                    totalInvesetPrice += item.TotInvestPrice;
                }

                var netIncome = fixedCost/(1 - (variableCost - totalInvesetPrice)); //손익 분기점 매출액 = 고정비/(1-(변동비/매출액))
                resourceDataGView.DataSource = totRsrcTab;

            }
        }
        private void ResourceMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.mainDragging = false;
        }
    }
}
