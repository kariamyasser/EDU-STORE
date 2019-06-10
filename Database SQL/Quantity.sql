use edustore 
go


CREATE PROCEDURE DecBQuantity
	-- Add the parameters for the stored procedure here
	@itemname varchar(50),
	@storename varchar(50)
	
AS
BEGIN
Update Book
Set Quantity=Quantity-1
Where Store_Name=@storename and Name=@itemname
END
GO



CREATE PROCEDURE DecPQuantity
	-- Add the parameters for the stored procedure here
	@itemname varchar(50),
	@storename varchar(50)
	
AS
BEGIN
Update Product
Set Quantity=Quantity-1
Where Store_Name=@storename and Description=@itemname
END
GO



CREATE PROCEDURE IncBQuantity
	-- Add the parameters for the stored procedure here
	@itemname varchar(50),
	@storename varchar(50)
	
AS
BEGIN
Update Book
Set Quantity=Quantity+1
Where Store_Name=@storename and Name=@itemname
END
GO



CREATE PROCEDURE IncPQuantity
	-- Add the parameters for the stored procedure here
	@itemname varchar(50),
	@storename varchar(50)
	
AS
BEGIN
Update Product
Set Quantity=Quantity+1
Where Store_Name=@storename and Description=@itemname
END
GO


CREATE PROCEDURE GetItemDepartment
	-- Add the parameters for the stored procedure here
	@ID int
	
	
AS
BEGIN
Select Dname
From SC_contents
Where ID=@ID
END
GO



