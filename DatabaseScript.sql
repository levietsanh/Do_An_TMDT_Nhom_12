USE [master]
GO
/****** Object:  Database [ShoppingCartDB]    Script Date: 22-May-22 12:53:49 AM ******/
CREATE DATABASE [ShoppingCartDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShoppingCartDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\ShoppingCartDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShoppingCartDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\ShoppingCartDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ShoppingCartDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShoppingCartDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShoppingCartDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ShoppingCartDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShoppingCartDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShoppingCartDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ShoppingCartDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShoppingCartDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShoppingCartDB] SET  MULTI_USER 
GO
ALTER DATABASE [ShoppingCartDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShoppingCartDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShoppingCartDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShoppingCartDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShoppingCartDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ShoppingCartDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ShoppingCartDB] SET QUERY_STORE = OFF
GO
USE [ShoppingCartDB]
GO
/****** Object:  Table [dbo].[AdminInfo]    Script Date: 22-May-22 12:53:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Email] [nvarchar](30) NULL,
	[Password] [nvarchar](6) NULL,
	[LastLogin] [nvarchar](25) NULL,
	[CreatedOn] [nvarchar](25) NULL,
	[UpdatedOn] [nvarchar](25) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 22-May-22 12:53:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 22-May-22 12:53:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Email] [nvarchar](30) NULL,
	[MobileNo] [nvarchar](10) NULL,
	[Password] [nvarchar](6) NULL,
	[LastLogin] [nvarchar](25) NULL,
	[CreatedOn] [nvarchar](25) NULL,
	[UpdatedOn] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerOrder]    Script Date: 22-May-22 12:53:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[OrderId] [nvarchar](9) NULL,
	[PaymentMode] [nvarchar](50) NULL,
	[ShippingAddress] [nvarchar](200) NULL,
	[ShippingCharges] [int] NULL,
	[SubTotal] [int] NULL,
	[Total] [int] NULL,
	[ShippingStatus] [nvarchar](max) NULL,
	[CreatedOn] [nvarchar](25) NULL,
	[UpdatedOn] [nvarchar](25) NULL,
	[PaymentReferenceNumber] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodOrder]    Script Date: 22-May-22 12:53:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [nvarchar](100) NULL,
	[StarterName] [nvarchar](200) NULL,
	[SQty] [nvarchar](10) NULL,
	[MainName] [nvarchar](200) NULL,
	[MQty] [nvarchar](10) NULL,
	[DesertName] [nvarchar](200) NULL,
	[DQty] [nvarchar](10) NULL,
	[DishType] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 22-May-22 12:53:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [nvarchar](9) NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
	[SubTotal] [int] NULL,
	[CreatedOn] [nvarchar](25) NULL,
	[UpdatedOn] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 22-May-22 12:53:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Price] [int] NULL,
	[CategoryId] [int] NULL,
	[ImageUrl] [varchar](100) NULL,
	[Stock] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ShoppingCartDB] SET  READ_WRITE 
GO
