USE [Apartman_Yonetim]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 24.12.2024 13:43:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Admin_ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Admin_Ad_Soyad] [nvarchar](50) NOT NULL,
	[Kod_Adi] [nvarchar](50) NOT NULL,
	[Admin_Sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[Admin_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bina]    Script Date: 24.12.2024 13:43:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bina](
	[Kat_Sayisi] [nvarchar](2) NULL,
	[Daire_Sayisi] [nchar](2) NULL,
	[Bina_No] [nchar](2) NULL,
	[Oda_Sayisi] [nchar](5) NULL,
	[Konum] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calisanlar]    Script Date: 24.12.2024 13:43:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calisanlar](
	[Kapıcı] [int] NOT NULL,
	[merdiven_temizlikcisi] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Daire]    Script Date: 24.12.2024 13:43:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Daire](
	[Daire_No] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_Daire] PRIMARY KEY CLUSTERED 
(
	[Daire_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kiraci]    Script Date: 24.12.2024 13:43:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kiraci](
	[Kiracı_ID] [int] IDENTITY(1,1) NOT NULL,
	[Kiracı_Ad] [nvarchar](50) NOT NULL,
	[Kiracı_Soyad] [nvarchar](50) NOT NULL,
	[Kiracı_TC] [nchar](11) NOT NULL,
	[Kiracı_Tel] [nchar](10) NOT NULL,
	[Daire_No] [nvarchar](2) NOT NULL,
	[Odenen_Kira] [int] NOT NULL,
	[Kiracı_Sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kiraci] PRIMARY KEY CLUSTERED 
(
	[Kiracı_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([Admin_ID], [Admin_Ad_Soyad], [Kod_Adi], [Admin_Sifre]) VALUES (2, N'Eren Görmez', N'Admin242Eren', N'143256Eren')
INSERT [dbo].[Admin] ([Admin_ID], [Admin_Ad_Soyad], [Kod_Adi], [Admin_Sifre]) VALUES (4, N'Ebubekir Sıddık', N'Ebuabakar112', N'Sıddık1324')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
INSERT [dbo].[Bina] ([Kat_Sayisi], [Daire_Sayisi], [Bina_No], [Oda_Sayisi], [Konum]) VALUES (N'4', N'8 ', N'23', N'2+1  ', N'Beşiktaş/İstanbul Arnavutköy 303. sokak')
GO
INSERT [dbo].[Calisanlar] ([Kapıcı], [merdiven_temizlikcisi]) VALUES (4000, 3000)
GO
INSERT [dbo].[Daire] ([Daire_No]) VALUES (N'1')
INSERT [dbo].[Daire] ([Daire_No]) VALUES (N'2')
INSERT [dbo].[Daire] ([Daire_No]) VALUES (N'3')
INSERT [dbo].[Daire] ([Daire_No]) VALUES (N'4')
INSERT [dbo].[Daire] ([Daire_No]) VALUES (N'5')
INSERT [dbo].[Daire] ([Daire_No]) VALUES (N'6')
INSERT [dbo].[Daire] ([Daire_No]) VALUES (N'7')
INSERT [dbo].[Daire] ([Daire_No]) VALUES (N'8')
GO
SET IDENTITY_INSERT [dbo].[Kiraci] ON 

INSERT [dbo].[Kiraci] ([Kiracı_ID], [Kiracı_Ad], [Kiracı_Soyad], [Kiracı_TC], [Kiracı_Tel], [Daire_No], [Odenen_Kira], [Kiracı_Sifre]) VALUES (2, N'Bekircan', N'Kurt', N'54355532111', N'5436667741', N'1', 34000, N'Kurt312Bekir')
INSERT [dbo].[Kiraci] ([Kiracı_ID], [Kiracı_Ad], [Kiracı_Soyad], [Kiracı_TC], [Kiracı_Tel], [Daire_No], [Odenen_Kira], [Kiracı_Sifre]) VALUES (3, N'Çağrı', N'Kartal', N'43222467890', N'5520678844', N'2', 32000, N'Çağrı1344')
INSERT [dbo].[Kiraci] ([Kiracı_ID], [Kiracı_Ad], [Kiracı_Soyad], [Kiracı_TC], [Kiracı_Tel], [Daire_No], [Odenen_Kira], [Kiracı_Sifre]) VALUES (5, N'Barış', N'Kurt', N'54567783321', N'5445566321', N'3', 32000, N'Kurt332Barış')
SET IDENTITY_INSERT [dbo].[Kiraci] OFF
GO
ALTER TABLE [dbo].[Kiraci]  WITH CHECK ADD  CONSTRAINT [FK_Kiraci_Daire] FOREIGN KEY([Daire_No])
REFERENCES [dbo].[Daire] ([Daire_No])
GO
ALTER TABLE [dbo].[Kiraci] CHECK CONSTRAINT [FK_Kiraci_Daire]
GO
