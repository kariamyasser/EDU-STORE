USE Edustore; -- The DB we created in Lab6
GO
CREATE PROCEDURE Update_CustomerPassword
	-- Add the parameters for the stored procedure here
	@Username varchar(50),
	@Password varchar(50)
	
AS
BEGIN
Update Customer
Set Password=@Password
Where Username=@Username
END
GO
CREATE PROCEDURE getcuOrders
	-- Add the parameters for the stored procedure here
	@CID int
	
AS
BEGIN
Select O_ID as OrderID,Item,Price_dollars as Price,Price_points as Points ,Store_Name as StoreName,ostate as State,PayMethod as PayMethod 
From Orders
Where CU_ID =@CID
END 
GO

CREATE PROCEDURE update_state
	-- Add the parameters for the stored procedure here
	@CID int,
	@x varchar(50),
	@xx varchar(50)


AS
BEGIN
Update Orders
Set ostate = @xx
Where CU_ID=@CID 



Update Orders
Set ostate = @x
Where CU_ID=@CID AND ESSN is not NULL 

END
GO

CREATE PROCEDURE getCid
	-- Add the parameters for the stored procedure here
	@Username varchar(50)
	
AS
BEGIN
Select CU_ID
From Customer
Where Username=@Username
END
GO


CREATE PROCEDURE getCost
	-- Add the parameters for the stored procedure here
	@CID int
	
AS
BEGIN
Select SUM(Price_dollars),SUM(Price_points)
From SC_contents
Where CU_ID =@CID
END 
GO

CREATE PROCEDURE getOrders
	-- Add the parameters for the stored procedure here
	@CID int
	
AS
BEGIN
Select *
From Orders
Where CU_ID =@CID
END 
GO





CREATE PROCEDURE UpdateMethod
	-- Add the parameters for the stored procedure here
	@CID int,
	@method varchar(50)
	
AS
BEGIN
Update Orders
set PayMethod=@method
Where CU_ID =@CID
END 
GO






CREATE PROCEDURE getsc
	-- Add the parameters for the stored procedure here
	@CID int
	
AS
BEGIN
Select ID,Item,store_name as StoreName,Price_dollars as Price,Price_points as Points 
From SC_contents
Where CU_ID =@CID
END 
GO



CREATE PROCEDURE Deletefromsc
	-- Add the parameters for the stored procedure here
	
	@id int 

AS
BEGIN
Delete 
from SC_contents
where ID=@id
END
GO




CREATE PROCEDURE deletesc
	-- Add the parameters for the stored procedure here
	@CID int
	
AS
BEGIN
Delete 
From SC_contents
Where CU_ID =@CID
END 
GO





CREATE PROCEDURE addorder 
	-- Add the parameters for the stored procedure here
		@CID int
AS
BEGIN
Insert Into Orders(SC_ID,CU_ID,Item,Store_Name,Price_dollars,Price_points)
Select SC_ID,CU_ID,Item,Store_Name,Price_dollars,Price_points
From SC_contents
Where CU_ID =@CID
END 
GO

CREATE PROCEDURE IncCuPoints
	-- Add the parameters for the stored procedure here
	@Username varchar(50),
	@Points int
	
AS
BEGIN
Update Customer
Set Wallet_points=Wallet_points+0.25*@Points
Where Username=@Username
END
GO


CREATE PROCEDURE GetCuPoints
	-- Add the parameters for the stored procedure here
	@Username varchar(50)
	
AS
BEGIN
Select Wallet_points
From Customer
Where Username=@Username
END
GO


CREATE PROCEDURE DecCuPoints
	-- Add the parameters for the stored procedure here
	@Username varchar(50),
	@Points int
	
AS
BEGIN
Update Customer
Set Wallet_points=Wallet_points-@Points
Where Username=@Username
END
GO



