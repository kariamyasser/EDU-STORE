USE Edustore; -- The DB we created in Lab6
GO

CREATE PROCEDURE insert_store
	-- Add the parameters for the stored procedure here
	@name  varchar(50), 
	@Address varchar(50),
	@Username varchar(50), 
	@Password varchar(50)
	
AS
BEGIN
INSERT INTO Store(name,Address,Username,Password)
Values (@name,@Address,@Username,@Password)
END
GO


CREATE PROCEDURE delete_store
	-- Add the parameters for the stored procedure here
	@name  varchar(50)
	
AS
BEGIN
Delete From Store
Where Name= @name
END
GO


CREATE PROCEDURE insert_admin
	-- Add the parameters for the stored procedure here
	@Username varchar(50), 
	@Password varchar(50)
	
AS
BEGIN
INSERT INTO Admin(Username,Password)
Values (@Username,@Password)
END
GO


CREATE PROCEDURE delete_admin
	-- Add the parameters for the stored procedure here
	@Username varchar(50)
	
AS
BEGIN
Delete From Admin
Where Username=@Username
END
GO


CREATE PROCEDURE Update_AdminPassword
	-- Add the parameters for the stored procedure here
	@Username varchar(50),
	@Password varchar(50)
	
AS
BEGIN
Update Admin
Set Password=@Password
Where Username=@Username
END
GO

CREATE PROCEDURE delete_customer
	-- Add the parameters for the stored procedure here
	@Username varchar(50)
	
AS
BEGIN
Delete From Customer
Where Username=@Username
END
GO


CREATE PROCEDURE get_customer
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
SELECT * FROM Customer
END
GO


CREATE PROCEDURE get_admin
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
SELECT * FROM Admin
END
GO
CREATE PROCEDURE get_store
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
SELECT * FROM Store
END
GO


CREATE PROCEDURE assign_printing
	-- Add the parameters for the stored procedure here

	@price_dollars int, 
	@price_points int,
	@id int
	
	
AS
BEGIN
Update Printing_Order
Set Price_dollars = @price_dollars,
	Price_points =@price_points
where ID=@id
END
GO

CREATE PROCEDURE get_printorder
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
SELECT * FROM Printing_Order
END
GO