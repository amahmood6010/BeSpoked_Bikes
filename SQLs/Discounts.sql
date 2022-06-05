USE [BeSpokedBick]
GO

/****** Object:  Table [dbo].[Discount]    Script Date: 6/3/2022 8:11:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Discounts](
       [Id] [bigint] IDENTITY(1,1) NOT NULL,
       [ProductId] [bigint] NOT NULL,
       [Begin_Date] [datetime] NOT NULL,
       [End_Date] [datetime] NOT NULL,
       [Discount_Percentage] [float] NOT NULL,
CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
       [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE Discounts
ADD FOREIGN KEY (ProductId) REFERENCES Products(Id);


INSERT INTO [dbo].[Discounts] ([ProductId],[Begin_Date],[End_Date],[Discount_Percentage])
VALUES (1, '01/01/2022', '01/01/2023', 5);
