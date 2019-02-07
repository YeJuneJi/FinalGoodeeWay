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
	@DateOfDisposal datetime,
	@ReceivingDetailsID nvarchar(10),
	@InventoryTypeCode nvarchar(6)
AS
	insert into Inventory(InventoryID,InventoryQuantity,DateOfDisposal,ReceivingDetailsID,InventoryTypeCode)
	values('STR'+ REPLICATE('0',7  - LEN(next value for dbo.Inventory_SEQ))+ convert(nvarchar, next value for dbo.Inventory_SEQ),@InventoryQuantity,@DateOfDisposal,@ReceivingDetailsID,@InventoryTypeCode);

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
CREATE PROCEDURE [dbo].SelectInventoryType

AS
	select InventoryTypeCode, InventoryName, ReceivingQuantity, 
	isnull((select sum(InventoryQuantity) from Inventory I2 where I2.InventoryTypeCode=IT.InventoryTypeCode),0) 'SumReceivingQuantuty',
	(isnull((select sum(InventoryQuantity) from Inventory I2 where I2.InventoryTypeCode=IT.InventoryTypeCode),0)*IT.ReceivingQuantity) 'TotalReceivingQuantuty',
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
	SELECT I.InventoryID, IT.InventoryName,I.InventoryQuantity,Convert(nvarchar(10),I.DateOfUse,23) 'DateOfUse',Convert(nvarchar(10),I.DateOfDisposal,23) 'DateOfDisposal',
	I.ReceivingDetailsID,I.InventoryTypeCode
	from Inventory I, InventoryType IT
	where I.InventoryTypeCode=IT.InventoryTypeCode

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
	@MaterialClassification nvarchar(30)
AS
	update  InventoryType
	set ReceivingQuantity=@ReceivingQuantity,InventoryName=@InventoryName,MaterialClassification=@MaterialClassification
	where InventoryTypeCode=@InventoryTypeCode;
