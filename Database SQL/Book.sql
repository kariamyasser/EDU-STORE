USE Edustore;
GO


CREATE PROCEDURE GetBookByStoreName
	-- Add the parameters for the stored procedure here
	@Name varchar(50)
	
AS
BEGIN
SELECT Name,Author,Quantity,Price_dollars,Price_points,Store_Name
FROM Book

where Store_Name=@Name And Quantity>0
END
GO

CREATE PROCEDURE GetBooks
	-- Add the parameters for the stored procedure here
	
	
AS
BEGIN
SELECT Name,Author,Quantity,Price_dollars,Price_points,Store_Name FROM Book

END
GO

CREATE PROCEDURE InsertBookInSC
	-- Add the parameters for the stored procedure here
	
	@SC_ID int ,

@CU_ID inT ,
@Item varchar(50) , 
@store_name varchar(50) ,
@Price_dollars int ,
@Price_points int 
	
AS
BEGIN
INSERT INTO SC_contents(SC_ID,CU_ID,Item,store_name,Price_dollars,Price_points)
VALUES (@SC_ID,@CU_ID,@Item,@store_name,@Price_dollars,@Price_points)

END
GO


CREATE PROCEDURE GetCustByName
 @CName varchar(50) 
AS
BEGIN
SELECT CU_ID 
FROM customer
WHERE Username= @CName
END
GO


CREATE PROCEDURE GetBookByName
 @BName varchar(50) 
AS
BEGIN
SELECT Name,Author,Quantity,Price_dollars,Price_points,Store_Name
FROM Book

where Name=@BName And Quantity>0
END
GO

CREATE PROCEDURE GetBookByNameAndStore
 @BName varchar(50), 
 @SName varchar(50)
AS
BEGIN
SELECT Name,Author,Quantity,Price_dollars,Price_points,Store_Name
FROM Book

where Store_Name=@SName And Name=@BName And Quantity>0
END
GO




