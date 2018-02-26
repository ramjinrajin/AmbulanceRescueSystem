USE [AmbulanceRescue]
GO

/****** Object:  Table [dbo].[OwnerRegistration]    Script Date: 26-Feb-18 10:00:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[OwnerRegistration](
	[Uid] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Mobile] [bigint] NULL,
	[UserName] [varchar](100) NULL,
	[Password] [varchar](100) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

