-- Sales ���̺� �������� ��������
use GoodeeWay;
create table dbo.Sales
(
menuCode nvarchar(10) constraint sales_mcode_nn not null,
menuName nvarchar(30) constraint sales_mname_nn not null,
price float constraint sales_price_nn not null default 0,
kCal int constraint sales_kcal_nn not null,
menuImage image constraint sales_mImage_nn not null default 0x00,
division nvarchar(10) constraint sales_div_nn not null,
additionalContext nvarchar(200) constraint sales_addcon_nn not null,
constraint sales_mcode_pk primary key(menuCode),
constraint sales_mname_uk unique(menuName),
);
GO

-- Recipes ���̺� �������� ��������
create table dbo.Recipes
(
recipeNo nvarchar(10) constraint recipe_rNo_nn not null,
ingredientAmount int constraint recipe_ingredamount_nn not null,
menuCode nvarchar(10) constraint recipe_mcode_nn not null default 0,
InventoryTypeCode nvarchar(6) constraint recipe_inventorytypecode_nn not null,
necessary bit constraint recipe_necessary_nn not null default 0,
constraint recipe_recipeNo_pk primary key(recipeNo),
constraint recipe_inventorytypecode_fk foreign key(InventoryTypeCode) references dbo.InventoryType(InventoryTypeCode) on delete cascade on update cascade,
constraint recipe_menuCode_fk foreign key(menucode) references dbo.Sales(menuCode) on delete cascade on update cascade
);
GO

--SaleRecord ���̺� �������� ��������
create table dbo.SaleRecords
(
salesNo int constraint saleRecords_sNo_nn not null,
salesDate datetime constraint saleRecords_sDate_nn not null,
salesitemName nvarchar(max) constraint saleRecords_salesitem_nn not null default getdate(),
discount float constraint saleRecords_discount_chk check (discount >= 0 AND discount<=101) default 0,
duty float constraint saleRecords_duty_nn not null default 0,
salesTotal float constraint saleRecords_total_nn not null default 0,
paymentPlan nvarchar(10) constraint saleRecords_paymentPlan_nn not null,
menuCode nvarchar(10) constraint saleRecords_menucode_nn not null,
constraint saleRecords_sNo_pk primary key(salesNo),
constraint saleRecords_menuCode_fk foreign key(menuCode) references dbo.Sales(menuCode)
);
GO


