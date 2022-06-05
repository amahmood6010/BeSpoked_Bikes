USE [BeSpokedBick]
GO

/****** Object:  Table [dbo].[Sales]    Script Date: 6/3/2022 8:11:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sales](
       [Id] [bigint] IDENTITY(1,1) NOT NULL,
       [ProductId] [bigint] NOT NULL,
       [SalespersonId] [bigint] NOT NULL,
       [CustomerId] [bigint] NOT NULL,
       [Sales_Date] [datetime] NOT NULL,
	   [Sale_Price] [float] NOT NULL,
	   [Commission] [float] NOT NULL,
	   [Qty_Sold] [int] NOT NULL,
CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
       [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE Sales
ADD FOREIGN KEY (ProductId) REFERENCES Products(Id);
ALTER TABLE Sales
ADD FOREIGN KEY (SalespersonId) REFERENCES Salespersons(Id);
ALTER TABLE Sales
ADD FOREIGN KEY (CustomerId) REFERENCES Customers(Id);


