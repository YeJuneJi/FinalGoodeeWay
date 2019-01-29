﻿--입고내역 테이블

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
ALTER TABLE InventoryType
ADD(MaterialClassification nvarchar(30));

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

