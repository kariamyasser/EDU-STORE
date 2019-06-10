USE Edustore; -- The DB we created in Lab6
GO
CREATE PROCEDURE insert_shopping 
	-- Add the parameters for the stored procedure here
	
	@CU_ID int 
	
AS
BEGIN
INSERT INTO Shopping_Cart(Cu_ID)
Values (@CU_ID)
END
GO
CREATE PROCEDURE insert_customer 
	-- Add the parameters for the stored procedure here
	
	@UserName varchar(50),
    @Cuname varchar(50),
     @Password varchar(150),
	 @phone int,
	 @Walletpoints int,
	 @address varchar(50)
	
AS
BEGIN
INSERT INTO customer(Username,CU_Name,password,Phone,Wallet_points,Address)
Values (@UserName,@Cuname,@Password,@Phone,@Walletpoints,@address)
END
GO



CREATE PROCEDURE Update_email 
	-- Add the parameters for the stored procedure here
	@email varchar(50),
	@UserName varchar(50)
	
AS
BEGIN
UPDATE  customer
SET Email=@email
WHERE Username=@UserName 
END
GO


CREATE PROCEDURE Update_age
	-- Add the parameters for the stored procedure here
	@age int,
	@UserName varchar(50)
	
AS
BEGIN
UPDATE  customer
SET Age=@age
WHERE Username=@UserName
END
GO


CREATE PROCEDURE Update_card 
	-- Add the parameters for the stored procedure here
	@card int,
	@UserName varchar(50)
	
AS
BEGIN
UPDATE  customer
SET Credit_Card=@card
WHERE Username=@UserName
END
GO



CREATE PROCEDURE count_customer 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
select  count(*)
from Customer
END
GO
CREATE PROCEDURE GetCheckCount
	-- Add the parameters for the stored procedure here
	@UName varchar(50)
	
	
AS
BEGIN
Select  Count(*)
from customer
where Username=@UName
END
GO