USE [DBPorfume]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 15.12.2022 18:39:23 ******/
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
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 15.12.2022 18:39:23 ******/
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
/****** Object:  Table [dbo].[MeasurementUnit]    Script Date: 15.12.2022 18:39:23 ******/
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
/****** Object:  Table [dbo].[Product]    Script Date: 15.12.2022 18:39:23 ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 15.12.2022 18:39:23 ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 15.12.2022 18:39:23 ******/
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
/****** Object:  Table [dbo].[Vendor]    Script Date: 15.12.2022 18:39:23 ******/
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
/****** Object:  Index [UQ__User__5E55825BE49B515D]    Script Date: 15.12.2022 18:39:23 ******/
ALTER TABLE [dbo].[User] ADD UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
