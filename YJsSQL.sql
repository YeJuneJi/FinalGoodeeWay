-- Sales 테이블 생성문과 제약조건
use GoodeeWay;
create table dbo.SalesMenu
(
menuCode nvarchar(10) constraint sales_mcode_nn not null,
menuName nvarchar(30) constraint sales_mname_nn not null,
price float constraint sales_price_nn not null default 0,
kCal int constraint sales_kcal_nn not null,
menuImageLocation nvarchar(max) constraint sales_mImageLoc_nn not null,
division int constraint sales_div_nn not null,
additionalContext nvarchar(200) constraint sales_addcon_nn not null,
discountRatio float constraint sales_disRatio_chk check(discountRatio >= 0 AND discountRatio<=101) default 0,
constraint sales_mcode_pk primary key(menuCode),
constraint sales_mname_uk unique(menuName),
);
GO

-- Recipes 테이블 생성문과 제약조건
create table dbo.Recipes
(
recipeNo nvarchar(10) constraint recipe_rNo_nn not null,
ingredientAmount int constraint recipe_ingredamount_nn not null,
menuCode nvarchar(10) constraint recipe_mcode_nn not null default 0,
InventoryTypeCode nvarchar(6) constraint recipe_inventorytypecode_nn not null,
necessary bit constraint recipe_necessary_nn not null default 0,
constraint recipe_recipeNo_pk primary key(recipeNo),
constraint recipe_inventorytypecode_fk foreign key(InventoryTypeCode) references dbo.InventoryType(InventoryTypeCode) on delete cascade on update cascade,
constraint recipe_menuCode_fk foreign key(menucode) references dbo.SalesMenu(menuCode) on delete cascade on update cascade
);
GO

--SaleRecord 테이블 생성문과 제약조건
create table dbo.SaleRecords
(
salesNo int constraint saleRecords_sNo_nn not null,
salesDate datetime constraint saleRecords_sDate_nn not null,
salesitemName nvarchar(max) constraint saleRecords_salesitem_nn not null default getdate(),
salesPrice float constraint saleRecords_sPrice_nn default 0,
discount float constraint saleRecords_discount_nn not null default 0,
duty float constraint saleRecords_duty_nn not null default 0,
salesTotal float constraint saleRecords_total_nn not null default 0,
paymentPlan nvarchar(10) constraint saleRecords_paymentPlan_nn not null,
--menuCode nvarchar(10) constraint saleRecords_menucode_nn not null,
constraint saleRecords_sNo_pk primary key(salesNo),
--constraint saleRecords_menuCode_fk foreign key(menuCode) references dbo.Sales(menuCode) on delete cascade on update cascade
);
GO

--이미지 테이블 생성
create table Images(
num int primary key,
name nvarchar(max) unique,
image Image not null
)

--
--
--
--select 
--
--
--


--ReceiveingDetails 테이블의 Select 프로시저
CREATE PROCEDURE OutPutAllReceiveingDetails
as
select ReceivingDetailsID,UnitPrice , InventoryTypeCode from ReceivingDetails;
GO
--Sales 테이블의 Select 프로시저
CREATE PROCEDURE dbo.SelectMenu
as
Select * from dbo.SalesMenu;
GO

--SaleRecords 테이블의 Select 프로시저
create procedure dbo.SelectSaleRecords
as
select * from SaleRecords;
GO

--SaleRecords 테이블의 SelectSaleRecordsBysalesNo 프로시저
create procedure dbo.SelectSaleRecordsBysalesNo
@salesNo int
as
select * from SaleRecords where salesNo = @salesNo;
GO

--SaleRecords 테이블의 SelectSaleRacordsByPeriod 프로시저
create procedure dbo.SelectSaleRacordsByPeriod
@periodStart datetime,
@periodEnd datetime
as
select * from SaleRecords where salesDate between @periodStart and @periodEnd
GO

-- Recipe 테이블과 InventoryType , Sales의 조합으로 만들어진 저장프로시저
create procedure dbo.SelectByRecipesJoinToInventryTypeNSalesMenu
@menuName nvarchar(30)
as
select r.recipeNo, r.ingredientAmount, r.menuCode, r.inventoryTypeCode, r.necessary, i.InventoryName, i.MaterialClassification, s.menuName
from Recipes r, InventoryType i, SalesMenu s
where r.InventoryTypeCode = i.InventoryTypeCode and r.menuCode = s.menuCode
and s.menuName = @menuName;
GO

--메뉴코드별 레시피 검색
create procedure SelectRecipesByMenuCode
@menuCode nvarchar(10)
as
select * from Recipes
where menuCode = @menuCode;
GO

--원래 만드려고 했던 메뉴코드별 정렬시킨 SelectmenuByMenuCode 
create procedure SelectmenuByMenuCode
@menuCode nvarchar(10),
@checkAscDesc bit,
@standard int
as
if(@checkAscDesc != 0)
begin
	select * from sales where menuCode = @menuCode order by (case @standard
																	when 1 then menuCode
																	when 2 then menuName
																	when 3 then price
																	when 4 then kCal
																	when 5 then menuImage
																	when 6 then division
																	when 7 then additionalContext
																	end) asc;
end
else
begin
	select * from sales where menuCode = @menuCode order by (case @standard
																	when 1 then menuCode
																	when 2 then menuName
																	when 3 then price
																	when 4 then kCal
																	when 5 then menuImage
																	when 6 then division
																	when 7 then additionalContext
																	end) desc;
end
GO


-- 변경 후 SelectmenuByMenuCode
create procedure SelectMenuByMenuCode
@menuCode nvarchar(10),
@division int
as
if(@division != 0)
begin
select * from SalesMenu where menuCode like '%' + @menuCode +'%' and division = @division-1; 
end
else
begin
select * from SalesMenu where menuCode like '%' + @menuCode +'%';
end
GO

create procedure SelectMenuByMenuName
@menuName nvarchar(30),
@division int
as
if(@division != 0)
begin
select * from SalesMenu where menuName like '%' + @menuName +'%' and division = @division-1; 
end
else
begin
select * from SalesMenu where menuName like '%' + @menuName +'%';
end
GO

create procedure SelectMenuByAdditional
@additional nvarchar(200),
@division int
as
if(@division != 0)
begin
select * from SalesMenu where additionalContext like '%' + @additional +'%' and division = @division-1; 
end
else
begin
select * from SalesMenu where additionalContext like '%' + @additional +'%';
end
GO


--
--
--
--insert
--
--
--


--Sales 테이블의 Insert 프로시저
CREATE PROCEDURE dbo.InsertMenu
@menuCode nvarchar(10),
@menuName nvarchar(30),
@price float,
@kCal int,
@menuImageLocation nvarchar(max) ,
@division int,
@additionalContext nvarchar(200),
@discountRatio float
as
insert into dbo.SalesMenu
values (@menuCode, @menuName, @price, @kCal, @menuImageLocation, @division, @additionalContext, @discountRatio);
GO

--SaleRecords 테이블의 Insert 프로시저
CREATE PROCEDURE dbo.InsertSaleRecords
@salesDate datetime,
@salesitemName nvarchar(max),
@salesPrice float,
@discount float,
@duty float,
@salesTotal float,
@paymentPlan nvarchar(10)
AS
insert into dbo.SaleRecords values(next value for dbo.CountSaleRecordsNo,@salesDate,@salesitemName, @salesPrice, @discount, @duty,@salesTotal, @paymentPlan);
GO



--Recipes 테이블의 Insert 프로시저
CREATE PROCEDURE dbo.InsertRecipe
@ingredientAmount int,
@menuCode nvarchar(10),
@InventoryTypeCode nvarchar(6),
@necessary bit
AS
insert into dbo.Recipes values('RCP'+ REPLICATE('0', 7- LEN(next value for dbo.CountRecipeNo)) + CAST(next value for dbo.CountRecipeNo as nvarchar), @ingredientAmount, @menuCode, @InventoryTypeCode, @necessary);
GO


--
--
--
--update
--
--
--

-- 판매기록 환불여부 
create procedure RefundSaleRecords
@salesNo int
as
update dbo.SaleRecords set paymentPlan = N'환불' where @salesNo = salesNo;
delete from Making where salesNo = @salesNo;

GO

--SaleRecords Update 저장 프로시저
create procedure UpdateSaleRecords
@salesNo int,
@salesDate datetime,
@salesitemName nvarchar(max),
@salesPrice float,
@discount float,
@duty float,
@salesTotal float,
@paymentPlan nvarchar(10)
as
update dbo.SaleRecords set salesDate = @salesDate, salesitemName = @salesitemName,salesPrice = @salesPrice ,discount = @discount, duty = @duty, salesTotal = @salesTotal , paymentPlan = @paymentPlan  where salesNo = @salesNo;
GO

--Recipe와 Sales 동시에 Update 할 수있는 프로시저 생성중.. (미완성)
create procedure UpdateSalesNRecipes
@division int,
@menuCode nvarchar(10),
@menuName nvarchar(30),
@price float,
@kCal int,
@menuImageLocation nvarchar(max),
@additionalContext nvarchar(200)
as
declare @updateNecessary bit,
@count int,
@num int,
if(@division != 0)
	begin
		update dbo.Sales set menuName = @menuName, price = @price, menuImageLocation = @menuImageLocation, division = @division, additionalContext = @additionalContext
		where menuCode = @menuCode;
	end
else
	begin
		set @count = (select count(necessary) from dbo.Recipes where menuCode =@menuCode)
		while (@num <@count)
			begin
				update dbo.Recipes set necessary = @necessary where menuCode = @menuCode
				set @num += 1
			end
		set @updateNecessary = (select necessary from Recipes where menuCode = @menuCode)
		
GO

--Recipe Update 저장 프로시저
create procedure UpdateRecipes
@ingredientAmount int,
@menuCode nvarchar(10),
@InventoryTypeCode nvarchar(6),
@necessary bit
as
update dbo.Recipes set ingredientAmount = @ingredientAmount, necessary = @necessary where menuCode = @menuCode and InventoryTypeCode = @InventoryTypeCode;
GO

--Sales Update 저장 프로시저
create procedure UpdateSalesMenu
@menuCode nvarchar(10),
@menuName nvarchar(30),
@price float,
@kCal int,
@menuImageLocation nvarchar(max),
@division int,
@additionalContext nvarchar(200),
@oldMenuCode nvarchar(10),
@discountRatio float
as
update dbo.SalesMenu set menuCode = @menuCode, menuName = @menuName, price = @price, kCal = @kCal,menuImageLocation=@menuImageLocation, division = @division, additionalContext = @additionalContext, discountRatio = @discountRatio
where menuCode = @oldMenuCode;
GO


--
--
--
--delete
--
--
--

--DeleteRecipesByMenuCode
create procedure DeleteRecipesByMenuCode
@menuCode nvarchar(10)
as
delete from dbo.Recipes where menuCode = @menuCode;
GO

-- DeleteSaleRecordsbysalesNo
create procedure DeleteSaleRecordsbysalesNo
@salesNo int
as
delete from dbo.SaleRecords where salesNo = @salesNo;
GO

--메뉴 삭제하는 DeleteSales 저장프로시저
create procedure DeleteSalesMenu
@menuCode nvarchar(10)
as
declare @division int
set @division = (select division from SalesMenu where menuCode = @menuCode)
if (@division != 0)
	begin
		delete from dbo.SalesMenu
		where menuCode = @menuCode
	end
else
	begin
		exec DeleteRecipesByMenuCode @menuCode;
		delete from dbo.SalesMenu
		where menuCode = @menuCode;
	end
GO


--
--
--
-- 시퀀스
--
--
--

--RecipeNo에 대한 시퀀스
CREATE SEQUENCE CountRecipeNo
    START WITH 1
    INCREMENT BY 1;
GO
--CountSaleRecordsNo에 대한 시퀀스
CREATE SEQUENCE CountSaleRecordsNo
    START WITH 1
    INCREMENT BY 1;
GO

-- Sequence를 특정값으로 재설정
ALTER SEQUENCE dbo.CountRecipeNo RESTART WITH 100;
GO


--
--
--
--재고별 단가 출력 쿼리문
--
--
--
select inven.InventoryTypeCode, rcv.UnitPrice
from InventoryType as inven, ReceivingDetails as rcv
where inven.InventoryTypeCode = rcv.InventoryTypeCode;