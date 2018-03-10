
CREATE PROC SpAddUser
(
@FirstName	varchar(100),
@LastName varchar(100),
@Email	 varchar(100),
@Mobile  varchar(100),
@UserName varchar(100),
@Password varchar(100)
)
AS
BEGIN
 DECLARE @COUNT INT =(SELECT COUNT(*) FROM OwnerRegistration Where Email=@Email And FirstName=@FirstName AND LastName=@LastName)

 IF(@COUNT>0)
 SELECT 'This user already exists' AS REPONSE
 ELSE
 BEGIN
INSERT INTO OwnerRegistration (FirstName,LastName,Email,Mobile,UserName,Password) Values (@FirstName,@LastName,@Email,@Mobile,@UserName,@Password)
  SELECT 'user added sucessfully' AS REPONSE
 END


END
GO