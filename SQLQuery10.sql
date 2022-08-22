USE [Movies]
GO

/****** Object:  Table [dbo].[movie]    Script Date: 8/22/2022 4:46:33 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[movie](
	[movieID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](255) NOT NULL,
	[Previewed] [BIT] NOT NULL,
	[Year] [char](10) NULL,
	[typeid] [int] NULL,
 CONSTRAINT [PK__movie__42EB372E97A4F02C] PRIMARY KEY CLUSTERED 
(
	[movieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[movie]  WITH CHECK ADD  CONSTRAINT [FK__movie__typeid__345EC57D] FOREIGN KEY([typeid])
REFERENCES [dbo].[movietype] ([typeID])
GO

ALTER TABLE [dbo].[movie] CHECK CONSTRAINT [FK__movie__typeid__345EC57D]
GO


