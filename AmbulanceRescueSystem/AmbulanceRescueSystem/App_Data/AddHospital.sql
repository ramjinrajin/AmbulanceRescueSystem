USE [AmbulanceRescue]
GO

/****** Object:  Table [dbo].[AddHospital]    Script Date: 26-Feb-18 11:02:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[AddHospital](
	[HospitalName] [varchar](100) NULL,
	[Location] [varchar](100) NULL,
	[Type] [varchar](100) NULL,
	[AmbulanceNo] [varchar](100) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

