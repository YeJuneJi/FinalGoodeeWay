--입고내역 테이블

CREATE TABLE ReceivingDetails (
    [ReceivingDetailsID]   NVARCHAR (10) NOT NULL,
    [ReceivingDetailsDate] DATETIME      NOT NULL,
    [ExpirationDate]       DATETIME      NULL,
    [Quantity]             INT           DEFAULT ((0)) NOT NULL,
    [UnitPrice]            FLOAT (53)    DEFAULT ((0)) NOT NULL,
    [ReturnStatus]         NVARCHAR (10) NOT NULL,
    [InventoryTypeCode]    NVARCHAR (6)  REFERENCES InventoryType(InventoryTypeCode) NOT NULL,
    PRIMARY KEY CLUSTERED ([ReceivingDetailsID] ASC),

);

Go

--재고종류 테이블

CREATE TABLE [dbo].InventoryType
(
	[InventoryTypeCode] NVARCHAR(6) NOT NULL PRIMARY KEY, 
    [ReceivingQuantity] INT NOT NULL, 
    [InventoryName] NVARCHAR(47) NOT NULL
)

Go

--재고종류테이블 추가

Go

--재고테이블
CREATE TABLE [dbo].[Inventory] (
    [InventoryID]        NVARCHAR (10) NOT NULL,
    [InventoryQuantity]  INT           NOT NULL,
    [DateOfUse]          DATETIME      NULL,
    [DateOfDisposal]     DATETIME      NULL,
    [ReceivingDetailsID] NVARCHAR (10) References ReceivingDetails(ReceivingDetailsID) NOT NULL,
    [InventoryTypeCode]  NVARCHAR (6)  References InventoryType(InventoryTypeCode) NOT NULL,
    PRIMARY KEY CLUSTERED ([InventoryID] ASC)
);

Go

--발주내역
CREATE TABLE [dbo].OrderDetails (
    OrderID        NVARCHAR (10) NOT NULL,
    OrderDate  DATETIME           NOT NULL,
    InventoryTypeCode   NVARCHAR(6)    References InventoryType(InventoryTypeCode) NOT NULL,
    Quantity     int    NOT NULL,
    PRIMARY KEY CLUSTERED (OrderID ASC)
);

Go
--재고insert 저장프로시져
CREATE PROCEDURE [dbo].InsertInventory
	@InventoryQuantity int,
	@RemainingQuantity int,
	@DateOfDisposal datetime,
	@ReceivingDetailsID nvarchar(10),
	@InventoryTypeCode nvarchar(6)
AS
	insert into Inventory(InventoryID,InventoryQuantity,DateOfDisposal,ReceivingDetailsID,InventoryTypeCode,RemainingQuantity)
	values('STR'+ REPLICATE('0',7  - LEN(next value for dbo.Inventory_SEQ))+ convert(nvarchar, next value for dbo.Inventory_SEQ)
	,@InventoryQuantity,@DateOfDisposal,@ReceivingDetailsID,@InventoryTypeCode,@RemainingQuantity);

Go

--재고종류 insert 저장프로시져
CREATE PROCEDURE [dbo].InsertInventoryType
	@InventoryTypeCode nvarchar(6),
	@ReceivingQuantity int,
	@InventoryName nvarchar(47),
	@MaterialClassification nvarchar(30)
AS
	insert into InventoryType(InventoryTypeCode,ReceivingQuantity,InventoryName,MaterialClassification)
	values(@InventoryTypeCode,@ReceivingQuantity,@InventoryName,@MaterialClassification)


Go
--재고종류 전체 select 저장프로시져
Go
--1
CREATE PROCEDURE [dbo].SelectInventoryType

AS
	select InventoryTypeCode, InventoryName, ReceivingQuantity, isnull(IT.MinimumQuantity,0)'MinimumQuantity',
	isnull((select sum(RemainingQuantity) from Inventory I2 where I2.InventoryTypeCode=IT.InventoryTypeCode),0) 'SumReceivingQuantuty',
	(isnull((select sum(RemainingQuantity) from Inventory I2 where I2.InventoryTypeCode=IT.InventoryTypeCode),0)*IT.ReceivingQuantity) 'TotalReceivingQuantuty',
	MaterialClassification 
	from InventoryType IT

Go
--입고내역리스트 저장프로시져
CREATE PROCEDURE [dbo].SelectReceivingDetailsList
	
AS
	SELECT ReceivingDetailsDate from ReceivingDetails group by ReceivingDetailsDate;

Go

--입고내역 상세뷰 저장프로시져
CREATE PROCEDURE [dbo].SelectReceivingDetails_InventoryType_DetailView
	@receivingDetailsDate nvarchar(10)
AS
	SELECT R.ReceivingDetailsID,I.InventoryName,CONVERT(NVARCHAR(10),R.ExpirationDate,23) 
'ExpirationDate',R.Quantity,R.UnitPrice,R.ReturnStatus,I.InventoryTypeCode from ReceivingDetails R, InventoryType I
	where R.InventoryTypeCode=I.InventoryTypeCode and convert(nvarchar(10),R.ReceivingDetailsDate,23)=@receivingDetailsDate;


Go
--재고테이블 재고종류테이블 조인 저장프로시져
CREATE PROCEDURE [dbo].SelectInventory_InventoryType
AS
	SELECT I.InventoryID, IT.InventoryName,I.InventoryQuantity,I.RemainingQuantity,
	Convert(nvarchar(10),I.DateOfUse,23) 'DateOfUse',
	Convert(nvarchar(10),I.DateOfDisposal,23) 'DateOfDisposal',
	I.ReceivingDetailsID,I.InventoryTypeCode
	from Inventory I, InventoryType IT
	where I.InventoryTypeCode=IT.InventoryTypeCode and substring(I.InventoryID,4,2)='00';

Go
--재고종류 삭제 프로시져
CREATE PROCEDURE [dbo].InventoryTypeDelete
	@InventoryTypeCode nvarchar(6)
AS
	delete from InventoryType
	where InventoryTypeCode=@InventoryTypeCode;

Go
--재고종류 수정 프로시져
CREATE PROCEDURE [dbo].UpdateInventoryType
	@InventoryTypeCode nvarchar(6),
	@ReceivingQuantity nvarchar(20),
	@InventoryName nvarchar(47),
	@MaterialClassification nvarchar(30),
	@MinimumQuantity int
AS
	update  InventoryType
	set ReceivingQuantity=@ReceivingQuantity,InventoryName=@InventoryName,MaterialClassification=@MaterialClassification, MinimumQuantity=@MinimumQuantity
	where InventoryTypeCode=@InventoryTypeCode;

Go
--발주내역 산출 프로시져

CREATE PROCEDURE [dbo].SelectInventoryTypeNeed

AS
	select IT.InventoryTypeCode, IT.InventoryName, 

	isnull((select sum(RemainingQuantity) 
			from Inventory I2 
			where I2.InventoryTypeCode=IT.InventoryTypeCode and Substring(I2.InventoryID,4,2)='00'),0) 'SumReceivingQuantuty',

	(isnull(IT.MinimumQuantity,0)+isnull(IT.MinimumQuantity,0)-
	isnull((select sum(RemainingQuantity) 
			from Inventory I2
			where I2.InventoryTypeCode=IT.InventoryTypeCode and Substring(I2.InventoryID,4,2)='00'),0)) 'NeedQuantity'
	
	from InventoryType IT ;
Go
--발주내역산출을 위한 입고내역 & 재고종류 테이블 select
CREATE PROCEDURE [dbo].SelectReceivingDetailsInventorytype

AS
	
	select i.InventoryTypeCode 'InventoryTypeCode', i.InventoryName 'InventoryName', 
	isnull((select sum(InventoryQuantity) 
			from Inventory I2 
			where I2.InventoryTypeCode=i.InventoryTypeCode and Substring(I2.InventoryID,4,2)='00'),0) 'SumReceivingQuantuty',

	R.Quantity 'NeedQuantity',
	r.ReturnStatus 'ReturnStatus', 
	r.ReceivingDetailsID 'ReceivingDetailsID'
	
	from InventoryType i, ReceivingDetails r where i.InventoryTypeCode=r.InventoryTypeCode and (r.ReturnStatus=N'교환' or r.ReturnStatus=N'반품');




Go
--입고내역 반품여부 컬럼에 '반품' 또는 '교환' 일 경우 '반품완' 또는 '교환완'으로 수정
CREATE PROCEDURE [dbo].UpdateReceivingDetails
	@ReceivingDetailsID nvarchar(10),
	@ReturnStatus nvarchar(10)
AS
	
	if (@ReturnStatus=N'반품')
	update  ReceivingDetails
	set 
	ReturnStatus=N'반품완'
	where ReceivingDetailsID=@ReceivingDetailsID
	else if(@ReturnStatus=N'교환')
	update  ReceivingDetails
	set 
	ReturnStatus=N'교환완'
	where ReceivingDetailsID=@ReceivingDetailsID;
Go
--발주내역리스트 저장프로시져
CREATE PROCEDURE [dbo].SelectOrderDetailsList
	
AS
	SELECT OrderDate from OrderDetails group by OrderDate;

Go
--발주내역 Insert 저장 프로시져
CREATE PROCEDURE [dbo].InsertOrderDetails
	@OrderID nvarchar(10),
	@OrderDate datetime,
	@InventoryTypeCode nvarchar(6),
	@Quantity int
AS
	insert into OrderDetails(OrderID,OrderDate,InventoryTypeCode,Quantity)
	values(@OrderID,@OrderDate,@InventoryTypeCode,@Quantity)
Go
--발주내역 상세보기 
CREATE PROCEDURE [dbo].SelectOrderDetails
	@OrderDate datetime
AS
	SELECT o.OrderID, i.InventoryName,o.Quantity,i.InventoryTypeCode from OrderDetails o, InventoryType i where o.InventoryTypeCode=i.InventoryTypeCode and OrderDate=@OrderDate;

Go
--발주내역 업데이트
CREATE PROCEDURE [dbo].UpdateOrderDetails
	@OrderID nvarchar(10),
	@Quantity int
AS
	update  OrderDetails
	set 
	Quantity=@Quantity
	where Quantity!=@Quantity and OrderID=@OrderID

GO
--재고사용내역 select
CREATE PROCEDURE [dbo].SelectInventoryDetails
	@ReceivingDetailsID nvarchar(10)
AS
	SELECT it.InventoryName,
	case 
	when substring(i.InventoryID,4,2)='00' then N'총재고'
	when substring(i.InventoryID,4,2)='UN' then N'사용'
	end 'InventoryID',
	i.InventoryQuantity,i.DateOfUse
	from Inventory i, InventoryType it
	where i.InventoryTypeCode=it.InventoryTypeCode and ReceivingDetailsID=@ReceivingDetailsID;

Go
--입고번호 입력하여 한개 row 에 대한 재고 가져오기
CREATE PROCEDURE [dbo].SelectInventoryDetailsForInsert
	@receivingDetailsID nvarchar(10)
AS
	SELECT CONVERT(NVARCHAR(10),I.DateOfDisposal,23) 'DateOfDisposal',I.InventoryTypeCode,IT.ReceivingQuantity from Inventory I, InventoryType IT
	where ReceivingDetailsID=@receivingDetailsID and I.InventoryTypeCode=IT.InventoryTypeCode;

GO
-- 재고사용내역 추가
CREATE PROCEDURE [dbo].InsertInventoryUseDetails
	@InventoryQuantity int,
	@DateOfUse datetime,
	@DateOfDisposal datetime,
	@ReceivingDetailsID nvarchar(10),
	@InventoryTypeCode nvarchar(6)
AS
	insert into Inventory(InventoryID,InventoryQuantity,DateOfUse,DateOfDisposal,ReceivingDetailsID,InventoryTypeCode)
	values('STR'+ 'UN'+REPLICATE('0',5  - LEN(next value for dbo.Inventory_SEQ))+ convert(nvarchar, next value for dbo.Inventory_SEQ),
	@InventoryQuantity,@DateOfUse,@DateOfDisposal,@ReceivingDetailsID,@InventoryTypeCode);
Go
	


	CREATE PROCEDURE [dbo].InsertInventoryUseDetails
	@RealUseQuantity int,
	@DateOfUse datetime,
	@DateOfDisposal datetime,
	@ReceivingDetailsID nvarchar(10),
	@InventoryTypeCode nvarchar(6),
	@ReceivingQuantity int,
	@InventoryQuantity int,
	@UseQuantity int
AS
	insert into Inventory(InventoryID,InventoryQuantity,DateOfUse,DateOfDisposal,ReceivingDetailsID,InventoryTypeCode)
	values('STR'+ 'UN'+REPLICATE('0',5  - LEN(next value for dbo.Inventory_SEQ))+ convert(nvarchar, next value for dbo.Inventory_SEQ),
	@RealUseQuantity,@DateOfUse,@DateOfDisposal,@ReceivingDetailsID,@InventoryTypeCode)

	update  Inventory
	set RemainingQuantity=@InventoryQuantity-((@UseQuantity+@RealUseQuantity)/@ReceivingQuantity)
	where ReceivingDetailsID=@ReceivingDetailsID;


Go
--재고사용내역 재고 소진 시 날짜 입력

CREATE PROCEDURE [dbo].UpdateInventoryUseDate
	@DateOfUse datetime,
	@ReceivingDetailsID nvarchar(10)
AS
	update Inventory
	set DateOfUse=@DateOfUse
	where ReceivingDetailsID=@ReceivingDetailsID and SUBSTRING(InventoryID,4,2)='00';


Go
--재고별판매량 출력(재고명, 사용수량),입력(재료종류,시작날짜,종료날짜)
create procedure [dbo].SelectInventoryTypeChart
	@MaterialClassification nvarchar(30),
	@StartDate datetime,
	@EndDate dateTime
AS
select t.InventoryName,sum(i.InventoryQuantity) 'UseInventory'
from Inventory i, InventoryType t
where i.InventoryTypeCode=t.InventoryTypeCode 
	and SUBSTRING(i.InventoryID,4,2)='UN' 
	and t.MaterialClassification=@MaterialClassification
	and i.DateOfUse >=@StartDate
	and i.DateOfUse <=@EndDate
group by t.InventoryName;