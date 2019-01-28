--입고내역 테이블

CREATE TABLE [dbo].[ReceivingDetails] (
    [ReceivingDetailsID]   NVARCHAR (10) NOT NULL,
    [ReceivingDetailsDate] DATETIME      NOT NULL,
    [ExpirationDate]       DATETIME      NULL,
    [Quantity]             INT           DEFAULT ((0)) NOT NULL,
    [UnitPrice]            FLOAT (53)    DEFAULT ((0)) NOT NULL,
    [ReturnStatus]         NVARCHAR (10) NOT NULL,
    [InventoryTypeCode]    NVARCHAR (6)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ReceivingDetailsID] ASC)
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

--재고테이블
CREATE TABLE [dbo].[Table]
(
	[InventoryID] NVARCHAR(10) NOT NULL PRIMARY KEY, 
    [InventoryQuantity] INT NOT NULL, 
    [DateOfUse] DATETIME NOT NULL, 
    [DateOfDisposal] DATETIME NOT NULL, 
    [ReceivingDetailsID] NVARCHAR(10) NULL, 
    [InventoryTypeCode] NVARCHAR(6) NULL
)
