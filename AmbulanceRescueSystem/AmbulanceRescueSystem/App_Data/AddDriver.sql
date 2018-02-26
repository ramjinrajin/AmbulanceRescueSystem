USE [AmbulanceRescue]
GO

/****** Object:  Table [dbo].[AddDriver]    Script Date: 2/26/2018 10:54:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[AddDriver](
	[Uid] [int] IDENTITY(1,1) NOT NULL,
	[VehicleNo] [varchar](100) NULL,
	[DriverName] [varchar](100) NULL,
	[LicenseNo] [varchar](50) NULL,
	[GpsId] [varchar](50) NULL,
	[Hospital] [varchar](100) NULL,
	[Address] [varchar](100) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

