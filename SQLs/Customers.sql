USE [BeSpokedBick]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 6/3/2022 8:11:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customers](
       [Id] [bigint] IDENTITY(1,1) NOT NULL,
       [First_Name] [nchar](56) NOT NULL,
       [Last_Name] [nchar](56) NOT NULL,
       [Address] [nchar](100) NOT NULL,
       [Phone] [nvarchar](56) NOT NULL,
       [Start_Date] [datetime] NOT NULL,
CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
       [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Customers] ([First_Name], [Last_Name], [Address],[Phone], [Start_Date])
VALUES ('Tom', 'Claussen', 'ABC Road Birmingham, Alabama 35242', '2055664328', '05/10/2022');
INSERT INTO [dbo].[Customers] ([First_Name], [Last_Name], [Address],[Phone], [Start_Date])
VALUES ('Abu', 'Arif', '1000 Talon Way Birmingham, Alabama 35242', '2055664328', '04/10/2022');
INSERT INTO [dbo].[Customers] ([First_Name], [Last_Name], [Address],[Phone], [Start_Date])
VALUES ('Tiger', 'Woods', '12257 Alpharetta, Georgia 30004', '2055664328', '04/10/2022');