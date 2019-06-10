USE Edustore; -- The DB we created in Lab6
GO
CREATE PROCEDURE insert_printing
	-- Add the parameters for the stored procedure here
	@NoOfCopies int,
	@Source varchar(50),
	@size varchar(10),
	@color varchar(20),
	@CU_ID int,
	@SC_ID int

	
AS
BEGIN
INSERT INTO  Printing_Order(No_copies,sources,Size,color,SC_ID,CU_ID)
Values (@NoOfCopies,@Source,@size,@color,@SC_ID,@CU_ID)
END
GO