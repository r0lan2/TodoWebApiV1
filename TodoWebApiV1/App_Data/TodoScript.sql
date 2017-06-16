
TODO script:
USE [TodoDB]
GO

/****** Object:  Table [dbo].[Todos]    Script Date: 06/16/2017 17:38:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Todos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](200) NOT NULL,
	[Complete] [bit] NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
