USE Edustore; -- The DB we created in Lab6
GO


CREATE PROCEDURE get_product
	-- Add the parameters for the stored procedure here
	@Storename varchar(50)
AS
BEGIN
SELECT * FROM Product
Where Store_Name= @Storename
END
GO

CREATE PROCEDURE get_employees
	-- Add the parameters for the stored procedure here
	@Storename varchar(50)
AS
BEGIN
SELECT SSN,Name,Hours as WorkingHours
FROM Employee
Where Store_Name= @Storename
AND SSN not in(select ESSN from Store)
END
GO

CREATE PROCEDURE get_sale
	-- Add the parameters for the stored procedure here
	@Storename varchar(50)
AS
BEGIN
SELECT * FROM Sales
Where Store_Name= @Storename
END
GO

CREATE PROCEDURE get_storename
	-- Add the parameters for the stored procedure here
	@username varchar(50)
AS
BEGIN
SELECT Name FROM Store
Where Username= @username
END
GO


CREATE PROCEDURE get_book
	-- Add the parameters for the stored procedure here
	@Storename varchar(50)
AS
BEGIN
SELECT * FROM Book
Where Store_Name= @Storename
END
GO

CREATE PROCEDURE get_order
	-- Add the parameters for the stored procedure here
	@Storename varchar(50)
AS
BEGIN
SELECT * FROM Orders
Where Store_Name= @Storename
END
GO
CREATE PROCEDURE get_Notass_order
	-- Add the parameters for the stored procedure here
	@Storename varchar(50)
AS
BEGIN
SELECT * FROM Orders
Where Store_Name= @Storename AND Essn Is NULL
END
GO






CREATE PROCEDURE insert_product
	-- Add the parameters for the stored procedure here
	
	@Description varchar(50),
	@Quantity int, 
	@Price_dollars int,
	@Price_points int,
	@store_name  varchar(50),
	@Dname  varchar(50)
	
AS
BEGIN
INSERT INTO Product(Description,Quantity,Price_dollars,Price_points,Store_Name,DName)
Values (@Description,@Quantity,@Price_dollars,@Price_points,@store_name,@Dname)
END
GO

CREATE PROCEDURE insert_book
	-- Add the parameters for the stored procedure here
	
	@Name varchar(50), 
	@Author varchar(50),
	@Quantity int, 
	@Price_dollars int,
	@Price_points int,
	@store_name  varchar(50)
	
AS
BEGIN
INSERT INTO Book(Name,Author,Quantity,Price_dollars,Price_points,Store_Name)
Values (@Name,@Author,@Quantity,@Price_dollars,@Price_points,@store_name)
END
GO


CREATE PROCEDURE insert_sale
	-- Add the parameters for the stored procedure here
	@percentage int, 
	@Dname varchar(50),
	@Storename varchar(50)
	
AS
BEGIN
 INSERT INTO Sales(Percentage,Dname,Store_name)
Values (@percentage,@Dname,@Storename)
END
GO
CREATE PROCEDURE insert_employee
	-- Add the parameters for the stored procedure here
	@Name varchar(50), 
	@Username varchar(50),
	@Hours int,
	@Password varchar(50),
	@Storename varchar(50)
	
AS
BEGIN
 INSERT INTO Employee(Name,Username,password,Hours,Store_Name)
Values (@Name,@Username,@Password,@Hours,@Storename)
END
GO

CREATE PROCEDURE Add_price_sales
	-- Add the parameters for the stored procedure here

	@percentage float, 
	@Dname varchar(50),
	@Storename varchar(50)
	
	
AS
BEGIN
Update Product
Set Price_dollars=Price_dollars*(1-@percentage),
 Price_points=Price_points*(1-@percentage)
where DName=@Dname
AND Store_name =@Storename
END
GO
CREATE PROCEDURE Inc_prices
	-- Add the parameters for the stored procedure here

	@percentage float, 
	@Dname varchar(50),
	@Storename varchar(50)
	
	
AS
BEGIN
Update Product
Set Price_dollars=Price_dollars*(1+@percentage),
 Price_points=Price_points*(1+@percentage)
where DName=@Dname
AND Store_name =@Storename
END
GO

CREATE PROCEDURE Remove_price_sales
	-- Add the parameters for the stored procedure here

	@percentage float, 
	@Dname varchar(50),
	@Storename varchar(50)
	
	
AS
BEGIN
Update Product
Set Price_dollars=Price_dollars/(1-@percentage),
 Price_points=Price_points/(1-@percentage)
where DName=@Dname
AND Store_name =@Storename
END
GO


CREATE PROCEDURE assign_employee
	-- Add the parameters for the stored procedure here

	@ssn int, 
	@order_id int
	
	
AS
BEGIN
Update Orders
Set ESSN = @ssn
where O_ID=@order_id
END
GO


CREATE PROCEDURE update_product
	-- Add the parameters for the stored procedure here

	@quantity int, 
	@id int
	
	
AS
BEGIN
Update Product
Set Quantity=@quantity
where P_ID=@id
END
GO


CREATE PROCEDURE update_book
	-- Add the parameters for the stored procedure here

	@quantity int, 
	@id int
	
	
AS
BEGIN
Update Book
Set Quantity=@quantity
where B_ID=@id
END
GO

CREATE PROCEDURE Update_StorePassword
	-- Add the parameters for the stored procedure here
	@Username varchar(50),
	@Password varchar(50)
	
AS
BEGIN
Update Store
Set Password=@Password
Where Username=@Username
END
GO

CREATE PROCEDURE CheckSales 
        @Dname varchar(50),
	@Storename varchar(50)
AS 
BEGIN
SELECT Count(*)
FROM Sales
where Dname=@Dname
AND Store_name =@Storename
END
Go

CREATE PROCEDURE DeleteSale
        @Dname varchar(50),
	@Storename varchar(50)
AS 
BEGIN
Delete FROM Sales
where Dname=@Dname
AND Store_name =@Storename
END
GO

CREATE PROCEDURE GetPercent
        @Dname varchar(50),
	@Storename varchar(50)
AS
BEGIN
SELECT Percentage
FROM Sales
where Dname=@Dname
AND Store_name =@Storename
END
GO

CREATE PROCEDURE GetDnames 
AS
BEGIN
SELECT Name
FROM Department
END
GO         



CREATE PROCEDURE getpayment
	-- Add the parameters for the stored procedure here
	@storename varchar(50)
	
AS
BEGIN
Select *
From PAYMENT
Where Store_Name= @storename
END 
GO

CREATE PROCEDURE delete_emp
	-- Add the parameters for the stored procedure here
	@id varchar(50)
	
AS
BEGIN
Delete From Employee
Where SSN=@id
AND @id not in(select ESSN from Store)
END
GO