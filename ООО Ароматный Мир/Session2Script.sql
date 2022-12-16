USE [DBPorfume]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 16.12.2022 18:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 16.12.2022 18:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeasurementUnit]    Script Date: 16.12.2022 18:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeasurementUnit](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 16.12.2022 18:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[OutpostID] [int] NOT NULL,
	[ClientFullName] [nvarchar](200) NOT NULL,
	[RecieveCode] [int] NOT NULL,
	[StatusID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatus]    Script Date: 16.12.2022 18:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Outpost]    Script Date: 16.12.2022 18:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Outpost](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 16.12.2022 18:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Article] [nvarchar](20) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[MeasurementUnitID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[ManufacturerID] [int] NOT NULL,
	[VendorID] [int] NOT NULL,
	[Cost] [decimal](19, 4) NOT NULL,
	[CurrentDiscount] [tinyint] NOT NULL,
	[MaximumDiscount] [tinyint] NOT NULL,
	[QuantityInStock] [int] NOT NULL,
	[Photo] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Article] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 16.12.2022 18:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 16.12.2022 18:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Surename] [nvarchar](100) NOT NULL,
	[RoleID] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Patronymic] [nvarchar](100) NOT NULL,
	[Login] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 16.12.2022 18:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name]) VALUES (1, N'Женский парфюм')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (2, N'Мужской парфюм')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] ON 

INSERT [dbo].[Manufacturer] ([ID], [Name]) VALUES (1, N'Chanel')
INSERT [dbo].[Manufacturer] ([ID], [Name]) VALUES (2, N'Lsncoma')
INSERT [dbo].[Manufacturer] ([ID], [Name]) VALUES (3, N'Lanvin')
INSERT [dbo].[Manufacturer] ([ID], [Name]) VALUES (4, N'Dolce & Gabbana')
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
GO
SET IDENTITY_INSERT [dbo].[MeasurementUnit] ON 

INSERT [dbo].[MeasurementUnit] ([ID], [Name]) VALUES (1, N'шт.')
SET IDENTITY_INSERT [dbo].[MeasurementUnit] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([ID], [OrderDate], [DeliveryDate], [OutpostID], [ClientFullName], [RecieveCode], [StatusID]) VALUES (1, CAST(N'2022-05-16T00:00:00.000' AS DateTime), CAST(N'2022-05-22T00:00:00.000' AS DateTime), 10, N'Анохин Арсений Андреевич', 911, 1)
INSERT [dbo].[Order] ([ID], [OrderDate], [DeliveryDate], [OutpostID], [ClientFullName], [RecieveCode], [StatusID]) VALUES (2, CAST(N'2022-05-17T00:00:00.000' AS DateTime), CAST(N'2022-05-23T00:00:00.000' AS DateTime), 5, N'Козлов Максим Максимович', 912, 2)
INSERT [dbo].[Order] ([ID], [OrderDate], [DeliveryDate], [OutpostID], [ClientFullName], [RecieveCode], [StatusID]) VALUES (3, CAST(N'2022-05-18T00:00:00.000' AS DateTime), CAST(N'2022-05-24T00:00:00.000' AS DateTime), 11, N'Черных Марк Кириллович', 913, 2)
INSERT [dbo].[Order] ([ID], [OrderDate], [DeliveryDate], [OutpostID], [ClientFullName], [RecieveCode], [StatusID]) VALUES (4, CAST(N'2022-05-19T00:00:00.000' AS DateTime), CAST(N'2022-05-25T00:00:00.000' AS DateTime), 10, N'', 914, 2)
INSERT [dbo].[Order] ([ID], [OrderDate], [DeliveryDate], [OutpostID], [ClientFullName], [RecieveCode], [StatusID]) VALUES (5, CAST(N'2022-05-20T00:00:00.000' AS DateTime), CAST(N'2022-05-26T00:00:00.000' AS DateTime), 1, N'', 915, 1)
INSERT [dbo].[Order] ([ID], [OrderDate], [DeliveryDate], [OutpostID], [ClientFullName], [RecieveCode], [StatusID]) VALUES (6, CAST(N'2022-05-21T00:00:00.000' AS DateTime), CAST(N'2022-05-27T00:00:00.000' AS DateTime), 32, N'', 916, 1)
INSERT [dbo].[Order] ([ID], [OrderDate], [DeliveryDate], [OutpostID], [ClientFullName], [RecieveCode], [StatusID]) VALUES (7, CAST(N'2022-05-22T00:00:00.000' AS DateTime), CAST(N'2022-05-28T00:00:00.000' AS DateTime), 20, N'Козлов Давид Александрович', 917, 1)
INSERT [dbo].[Order] ([ID], [OrderDate], [DeliveryDate], [OutpostID], [ClientFullName], [RecieveCode], [StatusID]) VALUES (8, CAST(N'2022-05-23T00:00:00.000' AS DateTime), CAST(N'2022-05-29T00:00:00.000' AS DateTime), 34, N'', 918, 2)
INSERT [dbo].[Order] ([ID], [OrderDate], [DeliveryDate], [OutpostID], [ClientFullName], [RecieveCode], [StatusID]) VALUES (9, CAST(N'2022-05-24T00:00:00.000' AS DateTime), CAST(N'2022-05-30T00:00:00.000' AS DateTime), 25, N'', 919, 1)
INSERT [dbo].[Order] ([ID], [OrderDate], [DeliveryDate], [OutpostID], [ClientFullName], [RecieveCode], [StatusID]) VALUES (10, CAST(N'2022-05-25T00:00:00.000' AS DateTime), CAST(N'2022-05-31T00:00:00.000' AS DateTime), 36, N'', 920, 2)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderStatus] ON 

INSERT [dbo].[OrderStatus] ([ID], [Name]) VALUES (1, N'Новый')
INSERT [dbo].[OrderStatus] ([ID], [Name]) VALUES (2, N'Завершен')
SET IDENTITY_INSERT [dbo].[OrderStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[Outpost] ON 

INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (1, N'344288, г. Москва, ул. Чехова, 1')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (2, N'614164, г.Москва,  ул. Степная, 30')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (3, N'394242, г. Москва, ул. Коммунистическая, 43')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (4, N'660540, г. Москва, ул. Солнечная, 25')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (5, N'125837, г. Москва, ул. Шоссейная, 40')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (6, N'125703, г. Москва, ул. Партизанская, 49')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (7, N'625283, г. Москва, ул. Победы, 46')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (8, N'614611, г. Москва, ул. Молодежная, 50')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (9, N'454311, г.Москва, ул. Новая, 19')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (10, N'660007, г.Москва, ул. Октябрьская, 19')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (11, N'603036, г. Москва, ул. Садовая, 4')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (12, N'450983, г.Москва, ул. Комсомольская, 26')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (13, N'394782, г. Москва, ул. Чехова, 3')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (14, N'603002, г. Москва, ул. Дзержинского, 28')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (15, N'450558, г. Москва, ул. Набережная, 30')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (16, N'394060, г.Москва, ул. Фрунзе, 43')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (17, N'410661, г. Москва, ул. Школьная, 50')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (18, N'625590, г. Москва, ул. Коммунистическая, 20')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (19, N'625683, г. Москва, ул. 8 Марта')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (20, N'400562, г. Москва, ул. Зеленая, 32')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (21, N'614510, г. Москва, ул. Маяковского, 47')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (22, N'410542, г. Москва, ул. Светлая, 46')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (23, N'620839, г. Москва, ул. Цветочная, 8')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (24, N'443890, г. Москва, ул. Коммунистическая, 1')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (25, N'603379, г. Москва, ул. Спортивная, 46')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (26, N'603721, г. Москва, ул. Гоголя, 41')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (27, N'410172, г. Москва, ул. Северная, 13')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (28, N'420151, г. Москва, ул. Вишневая, 32')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (29, N'125061, г. Москва, ул. Подгорная, 8')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (30, N'630370, г. Москва, ул. Шоссейная, 24')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (31, N'614753, г. Москва, ул. Полевая, 35')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (32, N'426030, г. Москва, ул. Маяковского, 44')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (33, N'450375, г. Москва ул. Клубная, 44')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (34, N'625560, г. Москва, ул. Некрасова, 12')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (35, N'630201, г. Москва, ул. Комсомольская, 17')
INSERT [dbo].[Outpost] ([ID], [Address]) VALUES (36, N'190949, г. Москва, ул. Мичурина, 26')
SET IDENTITY_INSERT [dbo].[Outpost] OFF
GO
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'B320R5', N'Духи', N'Цветочный аромат', 1, 1, 2, 2, CAST(4300.0000 AS Decimal(19, 4)), 2, 15, 6, N'B320R5.jpg')
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'B431R5', N'Одеколон', N'Входит в набор', 1, 2, 4, 2, CAST(2700.0000 AS Decimal(19, 4)), 2, 10, 5, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'C436G5', N'Духи', N'Объекм 100 мл', 1, 1, 4, 3, CAST(10200.0000 AS Decimal(19, 4)), 2, 15, 9, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'D268G5', N'Одеколон', N'Ванильный аромат', 1, 2, 1, 1, CAST(4399.0000 AS Decimal(19, 4)), 3, 10, 12, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'D329H3', N'Туалетная вода', N'Туалетная вода для женщин', 1, 1, 4, 2, CAST(1890.0000 AS Decimal(19, 4)), 4, 10, 4, N'D329H3.jpg')
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'D364R4', N'Духи', N'Аромат чайной розы', 1, 1, 1, 3, CAST(12400.0000 AS Decimal(19, 4)), 2, 10, 5, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'D572U8', N'Духи', N'Аромат чайной розы', 1, 1, 4, 3, CAST(4100.0000 AS Decimal(19, 4)), 3, 5, 6, N'D572U8.jpg')
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'E482R4', N'Одеколон', N'Оформление в красивой упаковке', 1, 2, 2, 1, CAST(1800.0000 AS Decimal(19, 4)), 2, 15, 14, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'F427R5', N'Одеколон', N'Поставляется вместе с галстуком', 1, 2, 1, 3, CAST(11800.0000 AS Decimal(19, 4)), 4, 10, 11, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'F572H7', N'Одеколон', N'Объекм 100 мл', 1, 2, 3, 1, CAST(2700.0000 AS Decimal(19, 4)), 2, 15, 14, N'F572H7.jpg')
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'F635R4', N'Туалетная вода', N'Туалетная вода 100 мл', 1, 1, 2, 2, CAST(3244.0000 AS Decimal(19, 4)), 2, 20, 13, N'F635R4.jpg')
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'G432E4', N'Спрей', N'Терпкий аромат для мужщин', 1, 2, 1, 1, CAST(2800.0000 AS Decimal(19, 4)), 3, 10, 15, N'G432E4.jpg')
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'G531F4', N'Туалетная вода', N'Подарочный вариант', 1, 2, 3, 4, CAST(6600.0000 AS Decimal(19, 4)), 2, 5, 9, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'G783F5', N'Спрей', N'Легкий спрей', 1, 1, 1, 3, CAST(5900.0000 AS Decimal(19, 4)), 2, 25, 8, N'G783F5.jpg')
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'H535R5', N'Спрей', N'Аромат морской волны', 1, 2, 1, 2, CAST(2300.0000 AS Decimal(19, 4)), 2, 25, 7, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'H782T5', N'Одеколон', N'Насыщенный аромат', 1, 2, 3, 2, CAST(4499.0000 AS Decimal(19, 4)), 4, 30, 5, N'H782T5.jpg')
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'J384T6', N'Духи', N'Концентрированные дихи', 1, 1, 1, 4, CAST(3800.0000 AS Decimal(19, 4)), 2, 10, 16, N'J384T6.jpg')
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'J542F5', N'Спрей', N'Объекм 100 мл', 1, 2, 1, 3, CAST(500.0000 AS Decimal(19, 4)), 3, 5, 12, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'K345R4', N'Духи', N'Цветочный аромат', 1, 1, 1, 3, CAST(2100.0000 AS Decimal(19, 4)), 2, 15, 3, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'K358H6', N'Духи', N'Концентрированные дихи', 1, 1, 2, 4, CAST(599.0000 AS Decimal(19, 4)), 3, 5, 2, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'L754R4', N'Одеколон', N'Аромат морской волны', 1, 2, 2, 2, CAST(1700.0000 AS Decimal(19, 4)), 2, 10, 7, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'M542T5', N'Духи', N'Сладкий аромат', 1, 1, 2, 3, CAST(2800.0000 AS Decimal(19, 4)), 5, 5, 3, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'N457T5', N'Одеколон', N'Максимальный объем', 1, 2, 3, 2, CAST(4600.0000 AS Decimal(19, 4)), 3, 5, 13, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'O754F4', N'Духи', N'Насыщенный аромат', 1, 1, 4, 3, CAST(5400.0000 AS Decimal(19, 4)), 4, 10, 18, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'P764G4', N'Духи', N'Концентрированные дихи', 1, 1, 3, 3, CAST(6800.0000 AS Decimal(19, 4)), 3, 30, 15, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'S213E3', N'Туалетная вода', N'Аромат морской волны', 1, 2, 4, 2, CAST(2156.0000 AS Decimal(19, 4)), 3, 5, 6, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'S326R5', N'Туалетная вода', N'Концентрированные дихи', 1, 1, 3, 1, CAST(9900.0000 AS Decimal(19, 4)), 3, 15, 15, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'S634B5', N'Спрей', N'Объекм 100 мл', 1, 2, 1, 4, CAST(5500.0000 AS Decimal(19, 4)), 3, 20, 6, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'T324F5', N'Туалетная вода', N'Цветочный аромат', 1, 1, 3, 3, CAST(4699.0000 AS Decimal(19, 4)), 2, 15, 5, NULL)
INSERT [dbo].[Product] ([Article], [Name], [Description], [MeasurementUnitID], [CategoryID], [ManufacturerID], [VendorID], [Cost], [CurrentDiscount], [MaximumDiscount], [QuantityInStock], [Photo]) VALUES (N'А112Т4', N'Духи', N'Женские духи с толким ароматом', 1, 1, 1, 1, CAST(4990.0000 AS Decimal(19, 4)), 3, 30, 6, N'А112Т4.jpg')
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [Name]) VALUES (1, N'Гость')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (2, N'Клиент')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (3, N'Менеджер')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (4, N'Администратор')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Surename], [RoleID], [Name], [Patronymic], [Login], [Password]) VALUES (21, N'Федоров', 4, N'Глеб', N'Михайлович', N'o@outlook.com', N'2L6KZG')
INSERT [dbo].[User] ([ID], [Surename], [RoleID], [Name], [Patronymic], [Login], [Password]) VALUES (22, N'Семенова', 4, N'Софья', N'Дмитриевна', N'hr6zdl@yandex.ru', N'uzWC67')
INSERT [dbo].[User] ([ID], [Surename], [RoleID], [Name], [Patronymic], [Login], [Password]) VALUES (23, N'Васильев', 4, N'Егор', N'Германович', N'kaft93x@outlook.com', N'8ntwUp')
INSERT [dbo].[User] ([ID], [Surename], [RoleID], [Name], [Patronymic], [Login], [Password]) VALUES (24, N'Смирнова', 3, N'Ирина', N'Александровна', N'dcu@yandex.ru', N'YOyhfR')
INSERT [dbo].[User] ([ID], [Surename], [RoleID], [Name], [Patronymic], [Login], [Password]) VALUES (25, N'Петров', 3, N'Андрей', N'Владимирович', N'19dn@outlook.com', N'RSbvHv')
INSERT [dbo].[User] ([ID], [Surename], [RoleID], [Name], [Patronymic], [Login], [Password]) VALUES (26, N'Егоров', 3, N'Максим', N'Андреевич', N'pa5h@mail.ru', N'rwVDh9')
INSERT [dbo].[User] ([ID], [Surename], [RoleID], [Name], [Patronymic], [Login], [Password]) VALUES (27, N'Никитин', 2, N'Артур', N'Алексеевич', N'281av0@gmail.com', N'LdNyos')
INSERT [dbo].[User] ([ID], [Surename], [RoleID], [Name], [Patronymic], [Login], [Password]) VALUES (28, N'Киселев', 2, N'Максим', N'Сергеевич', N'8edmfh@outlook.com', N'gynQMT')
INSERT [dbo].[User] ([ID], [Surename], [RoleID], [Name], [Patronymic], [Login], [Password]) VALUES (29, N'Борисов', 2, N'Тимур', N'Егорович', N'sfn13i@mail.ru', N'AtnDjr')
INSERT [dbo].[User] ([ID], [Surename], [RoleID], [Name], [Patronymic], [Login], [Password]) VALUES (30, N'Климов', 2, N'Арсений', N'Тимурович', N'g0orc3x1@outlook.com', N'JlFRCZ')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[Vendor] ON 

INSERT [dbo].[Vendor] ([ID], [Name]) VALUES (1, N'NDK PARFUM')
INSERT [dbo].[Vendor] ([ID], [Name]) VALUES (2, N'Парфюм для дома')
INSERT [dbo].[Vendor] ([ID], [Name]) VALUES (3, N'Elivero')
INSERT [dbo].[Vendor] ([ID], [Name]) VALUES (4, N'GN-GROUP')
SET IDENTITY_INSERT [dbo].[Vendor] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__User__5E55825BE49B515D]    Script Date: 16.12.2022 18:28:33 ******/
ALTER TABLE [dbo].[User] ADD UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([OutpostID])
REFERENCES [dbo].[Outpost] ([ID])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([StatusID])
REFERENCES [dbo].[OrderStatus] ([ID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([ManufacturerID])
REFERENCES [dbo].[Manufacturer] ([ID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([MeasurementUnitID])
REFERENCES [dbo].[MeasurementUnit] ([ID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([VendorID])
REFERENCES [dbo].[Vendor] ([ID])
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
