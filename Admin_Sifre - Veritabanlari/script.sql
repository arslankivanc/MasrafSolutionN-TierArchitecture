USE [master]
GO
/****** Object:  Database [MasrafTakip]    Script Date: 1.01.2018 19:20:31 ******/
CREATE DATABASE [MasrafTakip]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MasrafTakip', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MasrafTakip.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MasrafTakip_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MasrafTakip_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MasrafTakip].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MasrafTakip] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MasrafTakip] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MasrafTakip] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MasrafTakip] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MasrafTakip] SET ARITHABORT OFF 
GO
ALTER DATABASE [MasrafTakip] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MasrafTakip] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MasrafTakip] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MasrafTakip] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MasrafTakip] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MasrafTakip] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MasrafTakip] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MasrafTakip] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MasrafTakip] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MasrafTakip] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MasrafTakip] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MasrafTakip] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MasrafTakip] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MasrafTakip] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MasrafTakip] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MasrafTakip] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MasrafTakip] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MasrafTakip] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MasrafTakip] SET  MULTI_USER 
GO
ALTER DATABASE [MasrafTakip] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MasrafTakip] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MasrafTakip] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MasrafTakip] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MasrafTakip] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MasrafTakip', N'ON'
GO
USE [MasrafTakip]
GO
/****** Object:  Table [dbo].[Kisi]    Script Date: 1.01.2018 19:20:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisi](
	[pid] [int] IDENTITY(1,1) NOT NULL,
	[İsim] [nvarchar](50) NULL,
	[Soyisim] [nvarchar](50) NULL,
	[AktifMi] [bit] NULL,
 CONSTRAINT [PK_Kisi] PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanıcı]    Script Date: 1.01.2018 19:20:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanıcı](
	[personid] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Aktif] [bit] NULL,
	[YöneticiRol] [int] NULL,
 CONSTRAINT [PK_Kullanıcı] PRIMARY KEY CLUSTERED 
(
	[personid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Masraflar]    Script Date: 1.01.2018 19:20:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Masraflar](
	[masrafid] [int] IDENTITY(1,1) NOT NULL,
	[Baslik] [nvarchar](50) NULL,
	[Tutar] [decimal](18, 0) NOT NULL,
	[Acıklama] [varchar](max) NULL,
	[Tarih] [date] NULL,
	[OnayDurumu] [varchar](50) NULL,
	[MasrafSahibi] [nvarchar](50) NULL,
	[YetkiRol] [int] NULL,
 CONSTRAINT [PK_Masraflar] PRIMARY KEY CLUSTERED 
(
	[masrafid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kisi] ON 

INSERT [dbo].[Kisi] ([pid], [İsim], [Soyisim], [AktifMi]) VALUES (1, N'Kıvanç', N'Arslan', 1)
INSERT [dbo].[Kisi] ([pid], [İsim], [Soyisim], [AktifMi]) VALUES (2, N'Miraç', N'Arslan', 1)
INSERT [dbo].[Kisi] ([pid], [İsim], [Soyisim], [AktifMi]) VALUES (3, N'Evren', N'Yazıcı', 1)
INSERT [dbo].[Kisi] ([pid], [İsim], [Soyisim], [AktifMi]) VALUES (4, N'Dilara', N'Yılmaz', 1)
INSERT [dbo].[Kisi] ([pid], [İsim], [Soyisim], [AktifMi]) VALUES (5, N'Dilruba', N'Yılmaz', 1)
INSERT [dbo].[Kisi] ([pid], [İsim], [Soyisim], [AktifMi]) VALUES (6, N'Çiğdem', N'KHüseyin', 1)
SET IDENTITY_INSERT [dbo].[Kisi] OFF
SET IDENTITY_INSERT [dbo].[Kullanıcı] ON 

INSERT [dbo].[Kullanıcı] ([personid], [Username], [Password], [Aktif], [YöneticiRol]) VALUES (1, N'kıvanç', N'123', 1, 1)
INSERT [dbo].[Kullanıcı] ([personid], [Username], [Password], [Aktif], [YöneticiRol]) VALUES (2, N'miraç', N'12345', 1, 2)
INSERT [dbo].[Kullanıcı] ([personid], [Username], [Password], [Aktif], [YöneticiRol]) VALUES (3, N'evren', N'ev61', 1, 3)
INSERT [dbo].[Kullanıcı] ([personid], [Username], [Password], [Aktif], [YöneticiRol]) VALUES (4, N'dilara', N'd34', 1, 2)
INSERT [dbo].[Kullanıcı] ([personid], [Username], [Password], [Aktif], [YöneticiRol]) VALUES (5, N'dilruba', N'ruba34', 1, 3)
INSERT [dbo].[Kullanıcı] ([personid], [Username], [Password], [Aktif], [YöneticiRol]) VALUES (6, N'Çiğdem', N'123', 1, 61)
SET IDENTITY_INSERT [dbo].[Kullanıcı] OFF
SET IDENTITY_INSERT [dbo].[Masraflar] ON 

INSERT [dbo].[Masraflar] ([masrafid], [Baslik], [Tutar], [Acıklama], [Tarih], [OnayDurumu], [MasrafSahibi], [YetkiRol]) VALUES (1, N'elektrik', CAST(4 AS Decimal(18, 0)), N'elektrik masraf', CAST(N'2018-01-01' AS Date), N'Bekliyor', N'Kıvanç  Arslan', 1)
INSERT [dbo].[Masraflar] ([masrafid], [Baslik], [Tutar], [Acıklama], [Tarih], [OnayDurumu], [MasrafSahibi], [YetkiRol]) VALUES (3, N'su fatura ', CAST(7 AS Decimal(18, 0)), N'su fatura borcu', CAST(N'2018-01-01' AS Date), N'Bekliyor', N'Miraç  Arslan', 2)
INSERT [dbo].[Masraflar] ([masrafid], [Baslik], [Tutar], [Acıklama], [Tarih], [OnayDurumu], [MasrafSahibi], [YetkiRol]) VALUES (4, N'hava', CAST(3 AS Decimal(18, 0)), N'dsad', CAST(N'2018-01-01' AS Date), N'Bekliyor', N'Kıvanç  Arslan', 3)
INSERT [dbo].[Masraflar] ([masrafid], [Baslik], [Tutar], [Acıklama], [Tarih], [OnayDurumu], [MasrafSahibi], [YetkiRol]) VALUES (5, N'dsad', CAST(1 AS Decimal(18, 0)), N'ddd', CAST(N'2018-01-01' AS Date), N'Muhasebe', N'Kıvanç  Arslan', 2)
INSERT [dbo].[Masraflar] ([masrafid], [Baslik], [Tutar], [Acıklama], [Tarih], [OnayDurumu], [MasrafSahibi], [YetkiRol]) VALUES (6, N'ahmt23', CAST(4 AS Decimal(18, 0)), N'dd', CAST(N'2018-01-01' AS Date), N'Muhasebe', N'Kıvanç  Arslan', 3)
INSERT [dbo].[Masraflar] ([masrafid], [Baslik], [Tutar], [Acıklama], [Tarih], [OnayDurumu], [MasrafSahibi], [YetkiRol]) VALUES (8, N'doğal gaz masraf', CAST(12 AS Decimal(18, 0)), N'fatura hesap masrafı', CAST(N'2018-01-01' AS Date), N'Onaylandı', N'Kıvanç  Arslan', 1)
SET IDENTITY_INSERT [dbo].[Masraflar] OFF
ALTER TABLE [dbo].[Kisi]  WITH CHECK ADD  CONSTRAINT [FK_Kisi_Kullanıcı] FOREIGN KEY([pid])
REFERENCES [dbo].[Kullanıcı] ([personid])
GO
ALTER TABLE [dbo].[Kisi] CHECK CONSTRAINT [FK_Kisi_Kullanıcı]
GO
USE [master]
GO
ALTER DATABASE [MasrafTakip] SET  READ_WRITE 
GO
