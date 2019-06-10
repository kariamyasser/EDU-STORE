USE Edustore;
GO


CREATE PROCEDURE GetProductByStoreNameAndDepartment
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@DName varchar(50)

	
AS
BEGIN
SELECT Description,Quantity,Price_dollars,Price_points,Store_Name,DName
FROM Product

where Store_Name=@Name 
And DName=@DName And Quantity>0
END
GO

CREATE PROCEDURE GetProducts
	-- Add the parameters for the stored procedure here
	
	
AS
BEGIN
SELECT Description,Quantity,Price_dollars,Price_points,Store_Name,DName 
FROM Product
where  Quantity>0

END
GO

CREATE PROCEDURE GetProductsByDepartment
	-- Add the parameters for the stored procedure here
@DName varchar(50)	
	
AS
BEGIN
SELECT Description,Quantity,Price_dollars,Price_points,Store_Name,DName 
FROM Product
where DName=@DName And Quantity>0

END
GO

CREATE PROCEDURE InsertProductInSC
	-- Add the parameters for the stored procedure here
	
	@SC_ID int ,

@CU_ID inT ,
@Item varchar(50) , 
@store_name varchar(50) ,
@Price_dollars int ,
@Price_points int ,
@DName varchar(50)
	
AS
BEGIN
INSERT INTO SC_contents(SC_ID,CU_ID,Item,store_name,Price_dollars,Price_points,DName)
VALUES (@SC_ID,@CU_ID,@Item,@store_name,@Price_dollars,@Price_points,@DName)

END
GO





CREATE PROCEDURE GetProductByNameandDepartment
 @Pname varchar(50), 
 @Dname varchar(50)
AS
BEGIN
SELECT Description,Quantity,Price_dollars,Price_points,Store_Name,DName
FROM Product

where Description=@Pname and DName=@Dname And Quantity>0
END
GO

CREATE PROCEDURE GetProductByNameAndStoreAndDepartment
 @Pname varchar(50), 
 @SName varchar(50),
 @DName varchar(50)
AS
BEGIN
SELECT Description,Quantity,Price_dollars,Price_points,Store_Name,DName
FROM Product

where Store_Name=@SName And Description=@Pname And DName=@DName And Quantity>0
END
GO




