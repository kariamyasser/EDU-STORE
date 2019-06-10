USE Edustore; -- The DB we created
GO
CREATE PROCEDURE Update_EmployeePassword
	-- Add the parameters for the stored procedure here
	@Username varchar(50),
	@Password varchar(50)
	
AS
BEGIN
Update Employee
Set Password=@Password
Where Username=@Username
END
GO

CREATE PROCEDURE DeleteTheseOrders @O_ID int
AS
BEGIN
DELETE 
FROM Orders 
WHERE O_ID=@O_ID
END
GO

CREATE PROCEDURE GetEmpOrders @Username varchar(50)
AS
BEGIN
SELECT O_ID,CU_Name as CustomerName,Phone,Address,item,Price_dollars,PayMethod
FROM Orders as O,Customer as C
WHERE  O.ESSN In (Select SSN  From  Employee where Username = @Username And O.ESSN=SSN) And O.CU_ID=C.CU_ID
END
GO


CREATE PROCEDURE addpayment 
	-- Add the parameters for the stored procedure here
		@id int
AS
BEGIN
Insert Into Payment(O_ID,SC_ID,CU_ID,Item,Price_dollars,Price_points,Store_Name,PayMethod,ESSN)
Select O_ID,SC_ID,CU_ID,Item,Price_dollars,Price_points,Store_Name,PayMethod,ESSN
From Orders
Where O_ID =@id
END 
GO


