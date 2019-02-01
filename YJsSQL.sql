-- Sales 테이블 생성문과 제약조건
use GoodeeWay;
create table dbo.Sales
(
menuCode nvarchar(10) constraint sales_mcode_nn not null,
menuName nvarchar(30) constraint sales_mname_nn not null,
price float constraint sales_price_nn not null default 0,
kCal int constraint sales_kcal_nn not null,
menuImage image constraint sales_mImage_nn not null default 0x00,
division int constraint sales_div_nn not null,
additionalContext nvarchar(200) constraint sales_addcon_nn not null,
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
constraint recipe_menuCode_fk foreign key(menucode) references dbo.Sales(menuCode) on delete cascade on update cascade
);
GO

--SaleRecord 테이블 생성문과 제약조건
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
constraint saleRecords_menuCode_fk foreign key(menuCode) references dbo.Sales(menuCode) on delete cascade on update cascade
);
GO
\

--Sales 테이블의 Insert 프로시저
CREATE PROCEDURE dbo.InsertMenu
@menuCode nvarchar(10),
@menuName nvarchar(30),
@price float,
@kCal int,
@menuImage image ,
@division int,
@additionalContext nvarchar(200)
as
insert into dbo.Sales
values (@menuCode, @menuName, @price, @kCal, @menuImage, @division, @additionalContext);
GO

--Sales 테이블의 Select 프로시저
CREATE PROCEDURE dbo.SelectMenu
as
Select * from dbo.Sales;
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

--RecipeNo에 대한 시퀀스
CREATE SEQUENCE CountRecipeNo
    START WITH 1
    INCREMENT BY 1;
GO


-- Sequence를 특정값으로 재설정
ALTER SEQUENCE dbo.CountRecipeNo RESTART WITH 100;
GO


-- Recipe 테이블과 InventoryType , Sales의 조합으로 만들어진 저장프로시저
create procedure dbo.SelectByRecipesJoinToInventryTypeNSales
@menuName nvarchar(30)
as
select r.recipeNo, r.ingredientAmount, r.menuCode, r.inventoryTypeCode, r.necessary, i.InventoryName, i.MaterialClassification, s.menuName
from Recipes r, InventoryType i, Sales s
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

--Recipe와 Sales 동시에 Update 할 수있는 프로시저 생성중.. (미완성)
create procedure UpdateSalesNRecipes
@division int,
@menuCode nvarchar(10),
@menuName nvarchar(30),
@price float,
@kCal int,
@menuImage image,
@additionalContext nvarchar(200)
as
declare @updateNecessary bit,
@count int,
@num int,
if(@division != 0)
	begin
		update dbo.Sales set menuName = @menuName, price = @price, menuImage = @menuImage, division = @division, additionalContext = @additionalContext
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
create procedure UpdateSales
@menuCode nvarchar(10),
@menuName nvarchar(30),
@price float,
@kCal int,
@menuImage image,
@division int,
@additionalContext nvarchar(200),
@oldMenuCode nvarchar(10)
as
update dbo.Sales set menuCode = @menuCode, menuName = @menuName, price = @price, kCal = @kCal, division = @division, additionalContext = @additionalContext
where menuCode = @oldMenuCode;
GO

--DeleteRecipesByMenuCode
create procedure DeleteRecipesByMenuCode
@menuCode nvarchar(10)
as
delete from dbo.Recipes where menuCode = @menuCode;
GO