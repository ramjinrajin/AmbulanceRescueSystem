
CREATE PROC SpAddVehicle
(
@VehicleNo varchar(100),
@DriverName varchar(100),
@LisenceNo varchar(100),
@GPSId  varchar(100),
@Hospital  varchar(100),
@Address  varchar(100),
@Password  varchar(100)
)
AS
BEGIN
 DECLARE @COUNT INT =(SELECT COUNT(*) FROM AddDriver Where DriverName=@DriverName And Hospital=@Hospital)

 IF(@COUNT>0)
 SELECT 'This driver already exists' AS REPONSE
 ELSE
 BEGIN

  INSERT INTO AddDriver(VehicleNo,DriverName,LicenseNo,GpsId,Hospital,[Address],[Password])
  VALUES              (@VehicleNo,@DriverName,@LisenceNo,@GPSId ,@Hospital,@Address,@Password )
  SELECT 'Driver added sucessfully' AS REPONSE
 END


END
GO