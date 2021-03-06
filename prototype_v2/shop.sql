SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS (SELECT * FROM master..sysdatabases WHERE Name = 'Shop') DROP DATABASE Shop CREATE DATABASE Shop

USE Shop
go

IF EXISTS (SELECT * FROM Shop.dbo.sysobjects WHERE Name = 'Stock') BEGIN DROP TABLE HowToDemo.dbo.Stock END

CREATE TABLE [dbo].[Stock](
	[Barcode] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[VAT] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [Stock_PK] PRIMARY KEY NONCLUSTERED 
(
	[Barcode] ASC
) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Users](
	[PassWord] [int] NOT NULL,
 CONSTRAINT [Users_PK] PRIMARY KEY NONCLUSTERED 
(
	[PassWord] ASC
) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Discounts](
	[Barcode] [int] NOT NULL,
	[Percentage] [int] NOT NULL,
 CONSTRAINT [Discounts_PK] PRIMARY KEY NONCLUSTERED 
(
	[Barcode] ASC
) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Orders](
	[OrderNumber] [int] NOT NULL,
	[Barcode] [int] NULL,
	[Price] [money] NOT NULL,
	[Quantity] [int] NULL,
	[OrderDate] [datetime] NULL,
 CONSTRAINT [Orders_PK] PRIMARY KEY NONCLUSTERED 
(
	[OrderNumber] ASC
) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Discounts]  WITH CHECK ADD  CONSTRAINT [Discounts_FK00] FOREIGN KEY([Barcode])
REFERENCES [dbo].[Stock] ([Barcode])
GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [Orders_FK00] FOREIGN KEY([Barcode])
REFERENCES [dbo].[Stock] ([Barcode])
GO


CREATE PROCEDURE [dbo].[Product_Insert]
@Barcode int,
@Name nvarchar(50),
@Price money,
@Vat int,
@Quantity int
AS
If (EXISTS (Select * FROM Stock Where Barcode=@Barcode))
UPDATE [dbo].[Stock]
SET [Name] = @Name,[Price] = @Price,[Vat] = @Vat,[Quantity] = @Quantity
WHERE [Barcode] = @Barcode;
Else
INSERT INTO [dbo].[Stock] VALUES (@Barcode, @Name, @Price, @VAT, @Quantity);
GO

CREATE PROCEDURE [dbo].[Discounts_Insert]
@Barcode int,
@Percentage int
AS
If (EXISTS (Select * FROM Discounts Where Barcode=@Barcode))
UPDATE [dbo].[Discounts]
SET [Percentage] = @Percentage
WHERE [Barcode] = @Barcode;
Else
INSERT INTO [dbo].[Discounts] VALUES (@Barcode, @Percentage);
GO

CREATE PROCEDURE [dbo].[Product_Delete]
@Barcode int
AS
DELETE FROM Stock
WHERE Barcode=@Barcode;
GO

CREATE PROCEDURE [dbo].[Stock_Insert]
@Barcode int,
@Quantity int
AS
If (EXISTS (Select * FROM Stock Where Barcode=@Barcode))
UPDATE [dbo].[Stock]
SET [Quantity] = @Quantity+Stock.Quantity
WHERE [Barcode] = @Barcode;
GO

CREATE PROCEDURE [dbo].[Stock_Reduce]
@Barcode int,
@Quantity int
AS
If (EXISTS (Select * FROM Stock Where Barcode=@Barcode))
UPDATE [dbo].[Stock]
SET [Quantity] = Stock.Quantity-@Quantity
WHERE [Barcode] = @Barcode;
GO

CREATE PROCEDURE [dbo].[Product_Find]
@Barcode int,
@Name nvarchar(50) output,
@Price money output,
@VAT int output
AS
BEGIN
SET NOCOUNT ON;
SELECT @Name=Name, @Price=Price, @VAT=VAT
FROM Stock
Where Barcode=@Barcode
END
GO

CREATE PROCEDURE [dbo].[Orders_Delete]
@Ordernumber int
AS
DELETE FROM Orders
WHERE OrderNumber=@Ordernumber;
GO

CREATE PROCEDURE [dbo].[Orders_Insert]
@Barcode int,
@Quantity int
AS
declare @onum int
declare @Discount int
declare @Price1 money

Select @Price1=Price
From Stock
Where Barcode=@Barcode

IF EXISTS(Select * From Discounts Where Barcode=@Barcode)
Select @Discount=Percentage
From Discounts
Where Barcode=@Barcode
ELSE
SET  @Discount=0

Select @onum=(max(OrderNumber)+1)
From Orders
if (@onum=1)
BEGIN
EXEC Orders_Delete 0
set @onum=1
END
INSERT INTO [dbo].[Orders] VALUES (@onum, @Barcode, (SELECT CAST(((@Price1*@Quantity)*(100-@Discount)/100) AS money)), @Quantity,GETDATE());
GO


CREATE PROCEDURE [dbo].[Get5VAT]
AS
BEGIN
SET NOCOUNT ON;
SELECT *
FROM Orders,Stock
Where Orders.Barcode=Stock.Barcode AND VAT=5
END
GO

CREATE PROCEDURE [dbo].[maxOrder]
@MAXON int output
AS
BEGIN
SET NOCOUNT ON;
SELECT @MAXON=max(OrderNumber)
FROM Orders
END
GO

CREATE PROCEDURE [dbo].[getDetails]
@OrN int,
@Barcode int output,
@Name nvarchar(50) output,
@Price money output,
@VAT int output,
@Quantity int output
AS
BEGIN
SET NOCOUNT ON;
SELECT @Barcode=Orders.Barcode,@Name=Stock.Name,@Price=Orders.Price,@VAT=Stock.VAT,@Quantity=Orders.Quantity
FROM Orders,Stock
Where Orders.Barcode = Stock.Barcode AND Orders.OrderNumber=@OrN
END
GO

CREATE PROCEDURE [dbo].[getDaily]
@OrN int,
@Barcode int output,
@Name nvarchar(50) output,
@Price money output,
@VAT int output,
@Quantity int output,
@Dates date output
AS
BEGIN
SET NOCOUNT ON;
SELECT @Barcode=Orders.Barcode,@Name=Stock.Name,@Price=Orders.Price,@VAT=Stock.VAT,@Quantity=Orders.Quantity,@Dates=CONVERT (date, Orders.OrderDate)
FROM Orders,Stock
Where Orders.Barcode = Stock.Barcode AND Orders.OrderNumber=@OrN
END
GO

CREATE PROCEDURE [dbo].[getDiscounts]
@Barcode int,
@Discount int output
AS
BEGIN
SET NOCOUNT ON;
SELECT @Discount=Discounts.Percentage
FROM Discounts
Where Discounts.Barcode = @Barcode
IF NOT EXISTS(SELECT * FROM Discounts Where Discounts.Barcode = @Barcode)
SET @Discount=0
END
GO

EXEC Product_Insert 123,'water',1.5,19,8
INSERT INTO [dbo].[Orders] VALUES (0, 123, 1.5, 0,NULL);
