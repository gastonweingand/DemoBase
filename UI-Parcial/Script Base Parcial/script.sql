USE [master]
GO
/****** Object:  Database [DemoDB]    Script Date: 9/6/2022 17:19:22 ******/
CREATE DATABASE [DemoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Empresa', FILENAME = N'D:\Bases\Migración\Empresa.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Empresa_log', FILENAME = N'D:\Bases\Migración\Empresa_log.ldf' , SIZE = 427392KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DemoDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DemoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DemoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DemoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DemoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DemoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DemoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DemoDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DemoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DemoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DemoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DemoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DemoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DemoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DemoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DemoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DemoDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DemoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DemoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DemoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DemoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DemoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DemoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DemoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DemoDB] SET RECOVERY FULL 
GO
ALTER DATABASE [DemoDB] SET  MULTI_USER 
GO
ALTER DATABASE [DemoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DemoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DemoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DemoDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DemoDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DemoDB] SET QUERY_STORE = OFF
GO
USE [DemoDB]
GO
/****** Object:  User [test]    Script Date: 9/6/2022 17:19:22 ******/
CREATE USER [test] FOR LOGIN [test] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [test]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 9/6/2022 17:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[IdAddress] [uniqueidentifier] NOT NULL,
	[Street] [varchar](50) NULL,
	[Number] [int] NULL,
	[City] [varchar](50) NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[IdAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 9/6/2022 17:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[IdCustomer] [uniqueidentifier] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[DateBirth] [date] NULL,
	[Doc] [varchar](50) NULL,
	[IdAddress] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 9/6/2022 17:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [uniqueidentifier] NOT NULL,
	[Codigo] [int] NULL,
	[Descripcion] [varchar](100) NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Address] ([IdAddress], [Street], [Number], [City]) VALUES (N'46c3019e-198b-ea11-81a3-e8d8d142d59b', N'Antonio Sáenz', 1785, N'José León Suárez')
INSERT [dbo].[Address] ([IdAddress], [Street], [Number], [City]) VALUES (N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b', N'Lavalle', 1494, N'Vicente Lopez')
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress]) VALUES (N'dfc4ea32-b367-e911-b60a-88b111dc18cd', N'Gastón', N'Weingand', CAST(N'1984-08-13' AS Date), N'31243721', N'46c3019e-198b-ea11-81a3-e8d8d142d59b')
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress]) VALUES (N'7285b85b-7771-ea11-8198-98af655c0ae3', N'Lucila', N'Perez', CAST(N'2001-12-12' AS Date), N'1234568', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b')
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress]) VALUES (N'59e3005c-f471-ea11-8198-98af655c0ae3', N'Pedro', N'Gomez', CAST(N'1995-12-12' AS Date), N'5624865', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b')
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress]) VALUES (N'82748e1b-f571-ea11-8198-98af655c0ae3', N'Oscar', N'Presunto', CAST(N'2001-12-12' AS Date), N'1234444', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b')
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress]) VALUES (N'2f814d52-21d6-eb11-8285-98af655c0ae3', N'Aldo', N'Corco', CAST(N'1990-12-12' AS Date), N'123456', NULL)
INSERT [dbo].[Producto] ([Id], [Codigo], [Descripcion], [Precio]) VALUES (N'43605eba-d451-45b9-bac3-e0667bc18e90', 123, N'Televisor LG 60 pulgadas', 75800.0000)
ALTER TABLE [dbo].[Address] ADD  CONSTRAINT [DF_Address_IdAddress]  DEFAULT (newsequentialid()) FOR [IdAddress]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Cliente_IdCliente]  DEFAULT (newsequentialid()) FOR [IdCustomer]
GO
ALTER TABLE [dbo].[Producto] ADD  CONSTRAINT [DF_Producto_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Address] FOREIGN KEY([IdAddress])
REFERENCES [dbo].[Address] ([IdAddress])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_Address]
GO
USE [master]
GO
ALTER DATABASE [DemoDB] SET  READ_WRITE 
GO
