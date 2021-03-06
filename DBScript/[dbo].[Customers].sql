USE [CoffeeshopMgmt]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 3/7/2018 7:41:01 PM ******/
DROP TABLE [dbo].[Customers]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 3/7/2018 7:41:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[Cust_FirstName] [varchar](100) NOT NULL,
	[Cust_LastName] [varchar](100) NULL,
	[Cust_Addr1] [varchar](200) NULL,
	[Cust_Addr2] [varchar](200) NULL,
	[Cust_City] [varchar](50) NULL,
	[Cust_Country] [varchar](50) NULL,
	[Cust_ContactNumber] [varchar](20) NOT NULL,
	[Cust_ProvinceState] [varchar](50) NULL,
	[Cust_Email] [varchar](100) NULL,
	[Cust_Website] [varchar](50) NULL,
	[Cust_ZipPostalCode] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustID], [Cust_FirstName], [Cust_LastName], [Cust_Addr1], [Cust_Addr2], [Cust_City], [Cust_Country], [Cust_ContactNumber], [Cust_ProvinceState], [Cust_Email], [Cust_Website], [Cust_ZipPostalCode]) VALUES (1, N'Ascot', N'', N'120 W. Florence Avenue', N'', N'Los Angeles', N'USA', N'(323) 759-4817', N'CA', N'ascott@laplaa.org', N'', 90003)
INSERT [dbo].[Customers] ([CustID], [Cust_FirstName], [Cust_LastName], [Cust_Addr1], [Cust_Addr2], [Cust_City], [Cust_Country], [Cust_ContactNumber], [Cust_ProvinceState], [Cust_Email], [Cust_Website], [Cust_ZipPostalCode]) VALUES (2, N'Atwater', N'Village', N'3379 Glendale Boulevard', N'', N'Los Angeles', N'USA', N'(323) 664-1353', N'CA', N'atwatr@laplaa.org', N'', 90039)
INSERT [dbo].[Customers] ([CustID], [Cust_FirstName], [Cust_LastName], [Cust_Addr1], [Cust_Addr2], [Cust_City], [Cust_Country], [Cust_ContactNumber], [Cust_ProvinceState], [Cust_Email], [Cust_Website], [Cust_ZipPostalCode]) VALUES (3, N'Baldwin', N'Hills', N'2906 S. La Brea Avenue', N'', N'Los Angeles', N'USA', N'(323) 733-1196', N'CA', N'bldhls@laplaa.org', N'', 90016)
INSERT [dbo].[Customers] ([CustID], [Cust_FirstName], [Cust_LastName], [Cust_Addr1], [Cust_Addr2], [Cust_City], [Cust_Country], [Cust_ContactNumber], [Cust_ProvinceState], [Cust_Email], [Cust_Website], [Cust_ZipPostalCode]) VALUES (4, N'Benjamin', N'Franklin', N'2200 E. 1st Street', N'', N'Los Angeles', N'USA', N'(323) 263-6901', N'CA', N'bnfrnk@laplaa.org', N'', 90033)
INSERT [dbo].[Customers] ([CustID], [Cust_FirstName], [Cust_LastName], [Cust_Addr1], [Cust_Addr2], [Cust_City], [Cust_Country], [Cust_ContactNumber], [Cust_ProvinceState], [Cust_Email], [Cust_Website], [Cust_ZipPostalCode]) VALUES (5, N'Cahuenga', N'', N'4591 Santa Monica Boulevard', N'', N'Los Angeles', N'USA', N'(323) 664-6418', N'CA', N'cahung@laplaa.org', N'', 90029)
INSERT [dbo].[Customers] ([CustID], [Cust_FirstName], [Cust_LastName], [Cust_Addr1], [Cust_Addr2], [Cust_City], [Cust_Country], [Cust_ContactNumber], [Cust_ProvinceState], [Cust_Email], [Cust_Website], [Cust_ZipPostalCode]) VALUES (6, N'Canoga', N'Park', N'20939 Sherman Way', NULL, N'Canoga Park', N'USA', N'(818) 887-0320', N'CA', N'cngopk@laplaa.org', N'WWW.CANOGA.COM', 91303)
INSERT [dbo].[Customers] ([CustID], [Cust_FirstName], [Cust_LastName], [Cust_Addr1], [Cust_Addr2], [Cust_City], [Cust_Country], [Cust_ContactNumber], [Cust_ProvinceState], [Cust_Email], [Cust_Website], [Cust_ZipPostalCode]) VALUES (7, N'Donald Bruce Kaufman', N'Brentwood', N'11820 San Vicente Boulevard', N'', N'Los Angeles', N'USA', N'(310) 575-8273', N'CA', N'brntwd@laplaa.org', N'', 90049)
INSERT [dbo].[Customers] ([CustID], [Cust_FirstName], [Cust_LastName], [Cust_Addr1], [Cust_Addr2], [Cust_City], [Cust_Country], [Cust_ContactNumber], [Cust_ProvinceState], [Cust_Email], [Cust_Website], [Cust_ZipPostalCode]) VALUES (8, N'Chatsworth', NULL, N'21052 Devonshire Street ', NULL, N'Chatsworth', N'USA', N'(818) 341-4276', N'CA', N'ctswrt@laplaa.org', NULL, 91311)
INSERT [dbo].[Customers] ([CustID], [Cust_FirstName], [Cust_LastName], [Cust_Addr1], [Cust_Addr2], [Cust_City], [Cust_Country], [Cust_ContactNumber], [Cust_ProvinceState], [Cust_Email], [Cust_Website], [Cust_ZipPostalCode]) VALUES (12, N'Chinatown', NULL, N'639 N. Hill Street', NULL, N'Los Angeles', N'United States', N'(213) 620-0925', N'CA', N'cwtown@laplaa.org', NULL, 90012)
SET IDENTITY_INSERT [dbo].[Customers] OFF
