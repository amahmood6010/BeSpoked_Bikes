USE [BeSpokedBick]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 6/3/2022 8:10:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
       [Id] [bigint] IDENTITY(1,1) NOT NULL,
       [Name] [nvarchar](56) NOT NULL,
       [Manufacturer] [nvarchar](56) NOT NULL,
       [Style] [nvarchar](56) NOT NULL,
       [Purchase_Price] [float] NOT NULL,
       [Sale_Price] [float] NOT NULL,
       [Qty_On_Hand] [int] NULL,
       [Commission_Percentage] [float] NULL,
CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
       [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

GO  
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT IX_Products_Name UNIQUE (Name);   
GO  



INSERT INTO [dbo].[Products] ([Name], [Manufacturer], [Style],[Purchase_Price], [Sale_Price],[Qty_On_Hand],[Commission_Percentage])
VALUES ('Bike1', 'Cruiser', 'AXS', '1150.50', '1250.50', 10, 5);
INSERT INTO [dbo].[Products] ([Name], [Manufacturer], [Style],[Purchase_Price], [Sale_Price],[Qty_On_Hand],[Commission_Percentage])
VALUES ('Bikes2', 'SRAM', 'AXS', '350.50', '450.50', 100, 5);
