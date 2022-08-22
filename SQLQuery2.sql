USE [Movies]
GO

/****** Object:  Table [dbo].[movietype]    Script Date: 8/22/2022 3:03:29 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE movietype(
	typeID int NOT NULL PRIMARY KEY,
	Type nvarchar(max) NOT NULL
) 

GO


