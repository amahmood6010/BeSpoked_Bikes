USE [BeSpokedBick]
GO

/****** Object:  Table [dbo].[Salesperson]    Script Date: 6/3/2022 8:12:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Salespersons](
       [Id] [bigint] IDENTITY(1,1) NOT NULL,
       [First_Name] [nchar](56) NOT NULL,
       [Last_Name] [nchar](56) NOT NULL,
       [Address] [nchar](100) NOT NULL,
       [Phone] [nvarchar](56) NOT NULL,
       [Start_Date] [datetime] NOT NULL,       
       [Termination_Date] [datetime] NULL,
       [Manager] [nchar](56) NOT NULL,
CONSTRAINT [PK_Salesperson] PRIMARY KEY CLUSTERED 
(
       [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE UNIQUE NONCLUSTERED INDEX [IX_Salespersons] ON [dbo].[Salespersons]
(
	[First_Name] ASC,
	[Last_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO

INSERT INTO [dbo].[Salespersons] ([First_Name], [Last_Name], [Address],[Phone], [Start_Date],[Termination_Date],[Manager])
VALUES ('Todd', 'Pearson', '916 Talon Way Birmingham, Alabama 35242', '2055664328', '01/10/2022', null, 'Robert, Knox');
INSERT INTO [dbo].[Salespersons] ([First_Name], [Last_Name], [Address],[Phone], [Start_Date],[Termination_Date],[Manager])
VALUES ('Steve', 'Moraski', '100 Roswell Road, Atlanta Georgia 30009', '4045664328', '02/10/2022', null, 'Robert, Knox');
INSERT INTO [dbo].[Salespersons] ([First_Name], [Last_Name], [Address],[Phone], [Start_Date],[Termination_Date],[Manager])
VALUES ('Dat', 'Chi', '1000 Sandy Spring Road, Atlanta Georgia 30009', '7075664328', '02/10/2021', '02/10/2022', 'Robert, Knox');