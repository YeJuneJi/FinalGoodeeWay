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
        DataTable totRsrcTab;
        DataColumn[] dataColumns;
        List<EquipmentVO> equipmentList;
        List<SaleRecordsVO> saleRecordList;
        List<InventoryTypeVO> convertInventoryTypetoList;
        List<ReceivingDetailsVO> receivingDetailList;
        DataTable inventoryTypeList;
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
                new DataColumn("비품비"),
                new DataColumn("관리비"),
                new DataColumn("인사급여"),
                new DataColumn("기타"),
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
                //var dayPerRealTot = from records in (from saleRecord in saleRecordList
                //                                     let salesDate = saleRecord.SalesDate.Date
                //                                     where saleRecord.SalesDate >= periodStart && saleRecord.SalesDate <= periodEnd
                //                                     select new { salesDate, saleRecord.SalesTotal, saleRecord.SalesitemName })
                //                    group records by records.salesDate;



                var dayPerEquipPriceTot = from equips in (from equipment in equipmentList
                                                          let equipDate = equipment.PurchaseDate.Date
                                                          where equipment.PurchaseDate >= periodStart && equipment.PurchaseDate <= periodEnd
                                                          select new { equipDate, equipment.PurchasePrice })
                                          group equips by equips.equipDate;

                var dayPerRealTot = from records in (from saleRecord in saleRecordList
                                            where saleRecord.SalesDate >= periodStart && saleRecord.SalesDate <= periodEnd
                                            select new { SalesDate = saleRecord.SalesDate.Date, Stotal = saleRecord.SalesTotal, SitemName = saleRecord.SalesitemName })
                           group records by records.SalesDate;

                var calUnitPrice = from inven in convertInventoryTypetoList
                                   join rcv in receivingDetailList
                                   on inven.InventoryTypeCode equals rcv.InventoryTypeCode
                                   select new
                                   {
                                       InventoryTypeCode = inven.InventoryTypeCode,
                                       UnitPrice = rcv.UnitPrice
                                   };

                //foreach (var item in test2)
                //{
                //    tbxResult.Text ="===================================\r\n\r\n" + item.SitemName;
                //    JObject realMenu = JObject.Parse(item.SitemName);
                //    JArray realArray = JArray.Parse(realMenu.SelectToken("RealMenu").ToString());
                //    foreach (JObject realarr in realArray)
                //    {
                //        string menu = realarr["Menu"].ToString();
                //        string recipeMenu = realarr["MenuDetailList"].ToString();
                //        JArray recipeJarr = JArray.Parse(recipeMenu);
                //        foreach (var recipArr in recipeJarr)
                //        {
                //            new MenuDetail()
                //            {
                //                RecipeCode = recipArr["RecipeCode"].ToString()
                //            };
                //        }
                //    }
                //}

                //foreach (var item in test2)
                //{
                //    RealMenuVO rv = JsonConvert.DeserializeObject<RealMenuVO>(item.SitemName);
                //    foreach (var real in rv.RealMenu)
                //    {
                //        tbxResult.Text += "메뉴이름 : " + real.Menu.MenuName + "\r\n";
                //        foreach (var item2 in real.MenuDetailList)
                //        {
                //            tbxResult.Text += "재료이름 : " + item2.InventoryName + "\r\n";
                //        }
                //    }
                //}

                foreach (var item in dayPerRealTot)
                {
                    float rawMaterialCost = 0;
                    float investSum = 0;
                    foreach (var group in item)
                    {
                        investSum += group.Stotal;
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
                                            rawMaterialCost += gazua.UnitPrice;
                                            tbxResult.Text += "재료이름 : " + item2.InventoryName + "재고코드 : " + item2.InventoryTypeCode + " 단가 : " + gazua.UnitPrice + "\r\n";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                //tbxResult.Text += "메뉴이름 : " + real.Menu.MenuName + "\r\n";
                            }
                        }
                        totInvestList.Add(new ResourceManagementVO() { ResourceDate = item.Key, RawMaterialCost = rawMaterialCost, TotInvestPrice = investSum });
                    }
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

                var mergeList = totInvestList.Union(equipList).OrderBy(mlist => mlist.ResourceDate).ToList();

                float fixedCost = 0;//고정비
                float variableCost = 0; ; //변동비
                float totalInvesetPrice = 0;
                foreach (var item in mergeList)
                {

                    totRsrcTab.Rows.Add(item.ResourceDate.ToShortDateString(), item.TotInvestPrice, item.RawMaterialCost, item.EquipPrice, /*관리비*/0, /*인사급여*/0, /*기타*/0, /*순이익*/0);
                    variableCost += item.EquipPrice;
                    //fixedCost += 
                    totalInvesetPrice += item.TotInvestPrice;
                }

                var netIncome = fixedCost / (1 - (variableCost - totalInvesetPrice)); //손익 분기점 매출액 = 고정비/(1-(변동비/매출액))
                resourceDataGView.DataSource = totRsrcTab;

            }
        }

    }

    public static partial class JsonExtensions
    {
        public static IEnumerable<T> FromDelimitedJson<T>(TextReader reader, JsonSerializerSettings settings = null)
        {
            using (var jsonReader = new JsonTextReader(reader) { CloseInput = false, SupportMultipleContent = true })
            {
                var serializer = JsonSerializer.CreateDefault(settings);

                while (jsonReader.Read())
                {
                    if (jsonReader.TokenType == JsonToken.Comment)
                        continue;
                    yield return serializer.Deserialize<T>(jsonReader);
                }
            }
        }
    }
}
