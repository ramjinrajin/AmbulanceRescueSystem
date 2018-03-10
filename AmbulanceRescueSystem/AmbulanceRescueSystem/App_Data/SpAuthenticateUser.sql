 


CREATE Proc [dbo].[SpAuthenticateUser]
(
@Email varchar(100) ,
@Password varchar(100)
)
AS
BEGIN

	Declare @Response varchar(100),@RetryCount INT
SET @Response=(SELECT  TOP 1
	  (CASE
	     WHEN Email=@Email AND [Password]=@Password AND IsActive=0 THEN 'USER_INACTIVE'
		 WHEN Email=@Email AND [Password]=@Password AND IsActive=1 AND IsDeleted=1 THEN 'USER_DELETED'
		 WHEN Email=@Email AND [Password]=@Password AND IsActive=1 AND IsDeleted=0 AND ISBlocked=1 THEN 'USER_BLOCKED'
		  WHEN Email=@Email AND [Password]=@Password AND IsActive=1 AND IsDeleted=0 AND ISBlocked=0 THEN 'USER_VALID'
	    ELSE  
		   'USER_INVALID'

		  END) RESPONSE

		   FROM OwnerRegistration)


		   IF(@Response='USER_VALID')
		   BEGIN 
			Declare @Logincounts INT
			SELECT @Logincounts=LoggedCounts FROM OwnerRegistration Where Email=@Email
			Update OwnerRegistration SET LoggedCounts=@Logincounts+1 Where Email=@Email
		   END


		   IF(@Response='USER_BLOCKED')
		   BEGIN
			Declare @IsBlocked INT,@BlockedDate Date
			SELECT @IsBlocked=IsBlocked FROm OwnerRegistration Where Email=@Email
			SELECT @BlockedDate=BlockedDate FROm OwnerRegistration Where Email=@Email
			IF(@IsBlocked=1 AND @BlockedDate<>(CAST(GETDATE() AS VARCHAR(100))))
			BEGIN
			UPDATE OwnerRegistration SET ISBlocked=0 , RetryCount=0 Where  Email=@Email
			SELECT 'USER_VALID' AS RESULT
			RETURN;
			END
		   END

		   

		   IF(@Response='USER_INVALID')
		   BEGIN
		    SET @RetryCount=(SELECT RetryCount FROM OwnerRegistration Where Email=@Email)
			UPDATE OwnerRegistration SET RetryCount=@RetryCount+1 Where  Email=@Email
		   END
		   IF(@Response='USER_INVALID')
		   BEGIN
		    SET @RetryCount=(SELECT RetryCount FROM OwnerRegistration Where Email=@Email)
			IF(@RetryCount>=3)
			UPDATE OwnerRegistration SET ISBlocked=1 , BlockedDate=GETDATE() Where  Email=@Email
		   END

		SELECT @Response AS RESULT
END