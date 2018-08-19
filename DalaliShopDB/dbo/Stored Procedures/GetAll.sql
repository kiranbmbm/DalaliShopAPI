CREATE PROCEDURE GetAll 
	@TypeOfUsers as varchar(200)
AS
BEGIN
DECLARE   @IsInTransaction BIT = 0
	BEGIN TRY
	BEGIN TRAN
	SET @IsInTransaction=1

	if (@TypeOfUsers = 'ALL')
	begin 
   select * from Owners
	where Active = 1 
	select * from Clients
	where Active = 1
	select * from Buyers
	where Active = 1 
	select * from Vendors
	where Active = 1 
	select * from Helpers
	where Active = 1 
	select * from Transporters
	where Active = 1 
	end 

	IF ( @TypeOfUsers = 'Owners')
	begin 
	select * from Owners
	where Active = 1
	end 

	if @TypeOfUsers = 'Clients'
	begin 
	select * from Clients
	where Active = 1 
	end 

	if @TypeOfUsers = 'Buyers'
	begin 
	select * from Buyers
	where Active = 1 
	end 

	if @TypeOfUsers = 'Vendors'
	begin 
	select * from Vendors
	where Active = 1 
	end 

	if @TypeOfUsers = 'Helpers'
	begin 
	select * from Helpers
	where Active = 1 
	end 

	if @TypeOfUsers = 'Transporters'
	begin 
	select * from Transporters
	where Active = 1 
	end 
	
		COMMIT TRAN
			SET @IsInTransaction = 0

			SELECT
				TRY_CAST(
							(
								SELECT
										'Success' AS OutputMessage,
										1		  AS OutputCode
								FOR JSON PATH
							)
							AS VARCHAR(MAX)
						)
			Output_JSON

	  END TRY
	  BEGIN CATCH
		
		IF @IsInTransaction = 1
			
			ROLLBACK TRAN
			
			SELECT
				TRY_CAST(
							(
								SELECT
										'Failed' AS OutputMessage,
										0		  AS OutputCode
								FOR JSON PATH
							)
							AS VARCHAR(MAX)
						)
			Output_JSON
			         
	END CATCH
END 
