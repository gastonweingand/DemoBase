USE [master]
GO
/****** Object:  Database [DemoDB]    Script Date: 06/13/2022 19:20:19 ******/
CREATE DATABASE [DemoDB] ON  PRIMARY 
( NAME = N'DemoDB', FILENAME = N'C:\MisProgramas\SQLServer\DATA\DemoDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DemoDB_log', FILENAME = N'C:\MisProgramas\SQLServer\DATA\DemoDB.ldf' , SIZE = 2816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DemoDB] SET COMPATIBILITY_LEVEL = 100
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
ALTER DATABASE [DemoDB] SET AUTO_CREATE_STATISTICS ON
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
ALTER DATABASE [DemoDB] SET  READ_WRITE
GO
ALTER DATABASE [DemoDB] SET RECOVERY FULL
GO
ALTER DATABASE [DemoDB] SET  MULTI_USER
GO
ALTER DATABASE [DemoDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DemoDB] SET DB_CHAINING OFF
GO
USE [DemoDB]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 06/13/2022 19:20:23 ******/
ALTER TABLE [dbo].[Address] DROP CONSTRAINT [DF_Address_IdAddress]
GO
DROP TABLE [dbo].[Address]
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 06/13/2022 19:20:23 ******/
DROP TABLE [dbo].[Almacen]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 06/13/2022 19:20:23 ******/
ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [DF_Cliente_IdCliente]
GO
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 06/13/2022 19:20:22 ******/
ALTER TABLE [dbo].[Familia] DROP CONSTRAINT [DF__Familia__IdFamil__09DE7BCC]
GO
DROP TABLE [dbo].[Familia]
GO
/****** Object:  Table [dbo].[Familia_copy]    Script Date: 06/13/2022 19:20:22 ******/
ALTER TABLE [dbo].[Familia_copy] DROP CONSTRAINT [DF__Familia_c__IdFam__0EA330E9]
GO
DROP TABLE [dbo].[Familia_copy]
GO
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 06/13/2022 19:20:22 ******/
DROP TABLE [dbo].[FamiliaPatente]
GO
/****** Object:  Table [dbo].[OperacionCAB]    Script Date: 06/13/2022 19:20:22 ******/
DROP TABLE [dbo].[OperacionCAB]
GO
/****** Object:  Table [dbo].[OperacionLIN]    Script Date: 06/13/2022 19:20:22 ******/
DROP TABLE [dbo].[OperacionLIN]
GO
/****** Object:  Table [dbo].[Patente]    Script Date: 06/13/2022 19:20:22 ******/
ALTER TABLE [dbo].[Patente] DROP CONSTRAINT [DF__Patente__IdPaten__1367E606]
GO
DROP TABLE [dbo].[Patente]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 06/13/2022 19:20:22 ******/
ALTER TABLE [dbo].[Producto] DROP CONSTRAINT [DF_Producto_id]
GO
DROP TABLE [dbo].[Producto]
GO
/****** Object:  Table [dbo].[PuntoDistribucion]    Script Date: 06/13/2022 19:20:22 ******/
DROP TABLE [dbo].[PuntoDistribucion]
GO
/****** Object:  Table [dbo].[Ta_Combo]    Script Date: 06/13/2022 19:20:22 ******/
ALTER TABLE [dbo].[Ta_Combo] DROP CONSTRAINT [DF_Ta_Combo_idTa_Combo]
GO
DROP TABLE [dbo].[Ta_Combo]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 06/13/2022 19:20:22 ******/
ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [DF__Usuario__IdUsuar__182C9B23]
GO
DROP TABLE [dbo].[Usuario]
GO
/****** Object:  User [desarrollador]    Script Date: 06/13/2022 19:20:19 ******/
DROP USER [desarrollador]
GO
/****** Object:  User [desarrollador]    Script Date: 06/13/2022 19:20:19 ******/
CREATE USER [desarrollador] FOR LOGIN [desarrollador] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 06/13/2022 19:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF__Usuario__IdUsuar__182C9B23]  DEFAULT (newid()),
	[Nombre] [varchar](1000) NULL,
	[Clave] [varchar](16) NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Usuario__5B65BF97164452B1] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ta_Combo]    Script Date: 06/13/2022 19:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ta_Combo](
	[idTa_Combo] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_Ta_Combo_idTa_Combo]  DEFAULT (newid()),
	[Data] [varchar](20) NULL,
	[Code] [varchar](80) NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_Ta_Combo] PRIMARY KEY CLUSTERED 
(
	[idTa_Combo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'e33ce278-5342-440f-8888-01c8cd04b46b', N'USER', N'ADMIN', N'MARIA')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'8255521e-2a8b-41c0-b940-104c239419ad', N'PROD', N'29.32', N'PANTALON')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'PCIA', N'BUE', N'Buenos Aires')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'a52ce7d5-c1f1-4a61-9c60-2e597f2f20f1', N'USER', N'ADMIN', N'JUAN')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'f27b1ff2-82a2-49a8-ba5b-40232030c8b9', N'TID', N'DP', N'Depósito')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'ea15c230-84bd-48f3-b609-40e5b03a220b', N'PCIA', N'LP', N'La Pampa')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'f0afda5a-3909-4fc3-808b-61dbba9dc50e', N'PROD', N'1070.22', N'ZAPATILLA BLA')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'2663ce39-914d-41c9-8fd7-6c5037952a28', N'TID', N'TD', N'Tienda')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'65f5b9c6-1060-4f28-9f7d-77719a07fb21', N'PROD', N'200.45', N'SACO LANA')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'9a9184b8-55d8-42ff-8de3-7b48aa088566', N'PROD', N'45.21', N'CAMISA CELESTE')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'1b663a19-1dfb-4104-812f-83da2ec778fe', N'LOC', N'SF', N'San Fernando')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'27002b82-937f-4593-8708-876d7327da63', N'USER', N'ADM', N'PEDRO')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'c667ece3-2006-4420-8d8d-ae9d2baddfe5', N'LOC', N'SI', N'San Isidro')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'd22bcf29-689c-40ac-ad0d-b09d8fe108b3', N'PROD', N'345.22', N'SOMBRERO')
INSERT [dbo].[Ta_Combo] ([idTa_Combo], [Data], [Code], [Description]) VALUES (N'3b3704d2-5aad-45f5-9a8f-b66e8ecb423b', N'LOC', N'CABA', N'CABA')
/****** Object:  Table [dbo].[PuntoDistribucion]    Script Date: 06/13/2022 19:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PuntoDistribucion](
	[idPuntoDistribucion] [uniqueidentifier] NOT NULL,
	[idTipoPuntoDistribucion] [uniqueidentifier] NULL,
	[Nombre] [varchar](80) NULL,
	[idProvincia] [uniqueidentifier] NULL,
	[idLocalidad] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'8a8d9e29-9b54-4f9d-a09d-17738e4b534d', N'f27b1ff2-82a2-49a8-ba5b-40232030c8b9', N'Labrador', N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'c667ece3-2006-4420-8d8d-ae9d2baddfe5')
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'27b41efc-8f40-4750-b32a-8c9babea213d', N'f27b1ff2-82a2-49a8-ba5b-40232030c8b9', N'Canal San Fernando', N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'1b663a19-1dfb-4104-812f-83da2ec778fe')
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'46af3ed6-c98d-4be8-b2da-77a729ee60d0', N'2663ce39-914d-41c9-8fd7-6c5037952a28', N'Tienda Los Arboles', N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'c667ece3-2006-4420-8d8d-ae9d2baddfe5')
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'2663ce39-914d-41c9-8fd7-6c5037952a28', N'Tienda Michou', N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'c667ece3-2006-4420-8d8d-ae9d2baddfe5')
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'413d08e4-98f0-4601-922b-bc5d272f747d', N'2663ce39-914d-41c9-8fd7-6c5037952a28', N'Tienda Lopez', N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'1b663a19-1dfb-4104-812f-83da2ec778fe')
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'a69f1a0c-9cee-40b4-879e-5828e7322579', N'2663ce39-914d-41c9-8fd7-6c5037952a28', N'Tienda Osito Panda', N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'c667ece3-2006-4420-8d8d-ae9d2baddfe5')
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'252b178d-1020-4fce-b0b2-833db679e59c', N'2663ce39-914d-41c9-8fd7-6c5037952a28', N'TIenda Las 5 esquinas', N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'1b663a19-1dfb-4104-812f-83da2ec778fe')
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'd6ea7377-1fa4-4377-93ce-e7df96f36b85', N'f27b1ff2-82a2-49a8-ba5b-40232030c8b9', N'Farmacity', N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'1b663a19-1dfb-4104-812f-83da2ec778fe')
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'53dcbddc-2586-4f5f-a201-a83afa5f3099', N'f27b1ff2-82a2-49a8-ba5b-40232030c8b9', N'Distribuidora Mabelerdi', N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'3b3704d2-5aad-45f5-9a8f-b66e8ecb423b')
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'66c90bf7-3244-4f29-b6a7-51c3a4c292b4', N'f27b1ff2-82a2-49a8-ba5b-40232030c8b9', N'Distribuidora Norte', N'ea15c230-84bd-48f3-b609-40e5b03a220b', N'1b663a19-1dfb-4104-812f-83da2ec778fe')
INSERT [dbo].[PuntoDistribucion] ([idPuntoDistribucion], [idTipoPuntoDistribucion], [Nombre], [idProvincia], [idLocalidad]) VALUES (N'5c589692-711a-407d-878e-0ec91edf8cbb', N'f27b1ff2-82a2-49a8-ba5b-40232030c8b9', N'Distribuidora SICSA', N'553e1624-9c9e-410a-9477-2b4a1e8728b6', N'c667ece3-2006-4420-8d8d-ae9d2baddfe5')
/****** Object:  Table [dbo].[Producto]    Script Date: 06/13/2022 19:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_Producto_id]  DEFAULT (newid()),
	[Codigo] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Precio] [decimal](18, 3) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Producto] ([id], [Codigo], [Descripcion], [Precio]) VALUES (N'b7b1df22-b624-4ec1-a339-0754b0e72f73', N'PELOTA-FT-N2', N'PELOTA FUTBOL NRO 2', CAST(1100.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([id], [Codigo], [Descripcion], [Precio]) VALUES (N'c1d77ec6-6d44-4b22-ae84-4f993df01d8c', N'CORB-AZ', N'CORBATA AZUL', CAST(3500.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([id], [Codigo], [Descripcion], [Precio]) VALUES (N'38af8bcc-da4c-4749-9ff2-755b127130eb', N'ZAP-ADI-BL-TEN', N'ZAPATILLAS ADIDAS BLANCAS TENIS', CAST(37890.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([id], [Codigo], [Descripcion], [Precio]) VALUES (N'89e37d5c-db9c-40b2-bc8b-be8bf81c8039', N'PELOTA-FT-N3', N'PELOTA FUTBOL NRO 3', CAST(1500.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([id], [Codigo], [Descripcion], [Precio]) VALUES (N'23ce2ac2-4cd4-4e38-9099-d7500cafe2a2', N'PELOTA-FT-N5', N'PELOTA FUTBOL NRO 5', CAST(1500.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([id], [Codigo], [Descripcion], [Precio]) VALUES (N'43605eba-d451-45b9-bac3-e0667bc18e90', N'PANT-AZ-V', N'PANTALON AZUL VESTIR', CAST(3000.000 AS Decimal(18, 3)))
/****** Object:  Table [dbo].[Patente]    Script Date: 06/13/2022 19:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patente](
	[IdPatente] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF__Patente__IdPaten__1367E606]  DEFAULT (newid()),
	[Nombre] [varchar](1000) NULL,
	[Vista] [varchar](1000) NULL,
	[FormName] [varchar](1000) NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Patente__9F4EF95C117F9D94] PRIMARY KEY CLUSTERED 
(
	[IdPatente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'd765db5f-fdc1-412a-9de7-02adfa58e843', N'Procesos', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'bc38d3f5-a710-49cc-9b6c-14ea3af93206', N'Auditoria', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'87bb2266-a8fb-4e71-94d9-1ff21e9b6046', N'Articulos Ventas', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'6189ab84-8de1-412e-87c6-22547bfbaf52', N'Notas de Credito', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'c5c37026-567c-4401-b3b9-28ed195d3dc8', N'Datos', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'e4596228-44f0-4c85-8b22-42b7d97ae37c', N'Proveedores', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'90bc2b0a-412e-4b48-bc68-4773ed18dfe2', N'Informes', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'c1a37e85-adb7-430c-9a53-4956494c7e87', N'Restarurar Datos', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'76affe82-9496-4491-9b21-53a536f6e361', N'Ordenes de Pago', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'd023cb4b-a9d2-4d74-a43f-612d46b1030f', N'Recepcion', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'ff100128-b447-49b5-b8fb-8662b04b91e5', N'Clientes', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'6acfb798-d5c1-48f4-9eb9-bec1eb273e6e', N'Herramientas', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'c8caf7fc-1ae2-4f57-8795-c06c1b6a8210', N'Articulos Compras', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'b456b73d-01ea-4050-90db-d110ce4b86d9', N'Backup', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'b8247a55-8a3c-41a8-9b8d-d1ba3e86accb', N'Facturacion', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'16437bf4-5284-4d1f-951b-dae63cd7ed12', N'Estadisticas', NULL, NULL)
INSERT [dbo].[Patente] ([IdPatente], [Nombre], [Vista], [FormName]) VALUES (N'8c4f67f0-a8c3-4de1-aecf-dba52675427d', N'Notas de Debito', NULL, NULL)
/****** Object:  Table [dbo].[OperacionLIN]    Script Date: 06/13/2022 19:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperacionLIN](
	[idOperacionLIN] [uniqueidentifier] NOT NULL,
	[idOperacionCAB] [uniqueidentifier] NULL,
	[idProducto] [uniqueidentifier] NULL,
	[Cantidad] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'f61b7609-b66f-4b0d-abe5-7e1fc15792fe', N'd6499911-7a17-4859-8722-b881e4274e72', N'8255521e-2a8b-41c0-b940-104c239419ad', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'0d398ed8-0912-4523-8694-adfb32e071cc', N'd6499911-7a17-4859-8722-b881e4274e72', N'65f5b9c6-1060-4f28-9f7d-77719a07fb21', 40)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'e18ecbbc-46b2-4133-8c58-f1dfdc1576aa', N'41ebe076-dae0-43bf-90e4-474bf69c844b', N'8255521e-2a8b-41c0-b940-104c239419ad', 40)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'7bdf2263-83a2-47e5-a615-9a0281948f5f', N'41ebe076-dae0-43bf-90e4-474bf69c844b', N'65f5b9c6-1060-4f28-9f7d-77719a07fb21', 34)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'85b6851f-2482-40cb-ac9c-16dc613db32e', N'41ebe076-dae0-43bf-90e4-474bf69c844b', N'd22bcf29-689c-40ac-ad0d-b09d8fe108b3', 34)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'bce28295-c29e-46eb-b49d-f4c337b27848', N'c9d8dc8f-a002-4b92-84ac-adfbf311c186', N'8255521e-2a8b-41c0-b940-104c239419ad', 24)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'8ed2ad11-8f53-489c-a32e-044f86f9eb60', N'67540801-b315-4647-b718-2abc047d6bbe', N'f0afda5a-3909-4fc3-808b-61dbba9dc50e', 18)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'89d8f3fb-bfc6-4b78-bd1d-8d35c54fa734', N'b325e454-6a04-4f57-8610-20ac47dde22d', N'8255521e-2a8b-41c0-b940-104c239419ad', 56)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'8f50a587-0657-4acf-b483-152ae6400cee', N'b325e454-6a04-4f57-8610-20ac47dde22d', N'8255521e-2a8b-41c0-b940-104c239419ad', 56)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'f20fc2ff-3fd2-42ec-9291-fa904466a488', N'6cfa4a37-ff4e-4f76-a3e4-de325f770204', N'd22bcf29-689c-40ac-ad0d-b09d8fe108b3', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'374403d5-b8ba-481b-b279-1c8305d09628', N'8144b4aa-39f3-4ba2-8053-5e2ff300463b', N'8255521e-2a8b-41c0-b940-104c239419ad', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'd0d533c0-6122-4e7d-9a35-832c57b7c8a1', N'be2b4d82-f90a-405a-a492-9bf64b2210e1', N'8255521e-2a8b-41c0-b940-104c239419ad', 45)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'd45a874d-7397-4182-b40f-14679459bc49', N'be2b4d82-f90a-405a-a492-9bf64b2210e1', N'9a9184b8-55d8-42ff-8de3-7b48aa088566', 45)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'b343cee9-99fe-4cbb-9333-6409cb9b298f', N'807ecdd8-0c0e-4cbd-880e-d0d1d838aa8f', N'8255521e-2a8b-41c0-b940-104c239419ad', 45)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'f2f558ff-abd5-489c-b2c3-576ae5bcbf33', N'807ecdd8-0c0e-4cbd-880e-d0d1d838aa8f', N'f0afda5a-3909-4fc3-808b-61dbba9dc50e', 45)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'b9ac0b9a-e410-4266-95bb-4d32a97dbf97', N'807ecdd8-0c0e-4cbd-880e-d0d1d838aa8f', N'd22bcf29-689c-40ac-ad0d-b09d8fe108b3', 20)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'a7b0076d-0c2e-483a-944c-0c94a2cded99', N'07dd7142-a25f-463d-b33d-af7e222128a5', N'65f5b9c6-1060-4f28-9f7d-77719a07fb21', 19)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'a91f7f17-21d9-44c2-afad-61831b9be468', N'58c907d9-3dc9-453d-95a4-733c1eb131dd', N'8255521e-2a8b-41c0-b940-104c239419ad', 109)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'6c6ec65e-1267-4cb4-89d6-0eae0a3f565b', N'5939abec-5028-48d7-b920-b078a18ad0cb', N'8255521e-2a8b-41c0-b940-104c239419ad', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'4addf216-705f-442c-a961-815dbf971628', N'ee4f7792-1a5b-4014-8160-23f5e18c0b28', N'65f5b9c6-1060-4f28-9f7d-77719a07fb21', 14)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'c64ef4cc-33da-4632-b178-40a554dc04db', N'b866717e-a911-44bd-a196-1d20a0f1c21a', N'f0afda5a-3909-4fc3-808b-61dbba9dc50e', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'9d2292af-6be1-4319-b1ac-d005adcff7e2', N'c833a783-ccc9-4937-a3f2-4cc554bc4bdd', N'd22bcf29-689c-40ac-ad0d-b09d8fe108b3', 200)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'1875e82e-aa1d-49e7-9456-20a0699e0023', N'76283733-dfab-4cb3-a1e5-8a2bf8e11bb2', N'9a9184b8-55d8-42ff-8de3-7b48aa088566', 1043)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'a7f38c1e-4d1e-47be-9914-053707bf2f90', N'8f4cf515-c703-4cef-b12a-f6a8c7f094bf', N'9a9184b8-55d8-42ff-8de3-7b48aa088566', 16)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'1a46b087-23b2-4831-ab5f-fdfdc98c8798', N'8f4cf515-c703-4cef-b12a-f6a8c7f094bf', N'f0afda5a-3909-4fc3-808b-61dbba9dc50e', 16)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'bef8f71c-77b6-4779-8d0d-776b38ec24b7', N'8f4cf515-c703-4cef-b12a-f6a8c7f094bf', N'd22bcf29-689c-40ac-ad0d-b09d8fe108b3', 16)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'e0d97f3d-791f-4ccb-bc89-d52eb2aae323', N'0af640c4-5045-4d6b-89a1-9f9c3c80eb20', N'f0afda5a-3909-4fc3-808b-61dbba9dc50e', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'b1e9df80-8d49-4e96-a4ad-e0992dbd6e04', N'0af640c4-5045-4d6b-89a1-9f9c3c80eb20', N'd22bcf29-689c-40ac-ad0d-b09d8fe108b3', 3)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'e405facf-8853-433c-ae84-13919bd1fc60', N'0af640c4-5045-4d6b-89a1-9f9c3c80eb20', N'65f5b9c6-1060-4f28-9f7d-77719a07fb21', 15)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'd902d2f1-c7b3-4b6c-b12f-700b06c814a2', N'99277974-cf8c-4128-b8e4-b103afb39776', N'8255521e-2a8b-41c0-b940-104c239419ad', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'f98a6541-e7d4-4d60-b665-f3c12de392f6', N'99277974-cf8c-4128-b8e4-b103afb39776', N'65f5b9c6-1060-4f28-9f7d-77719a07fb21', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'4366513b-17c1-414e-ad4b-331c3098f2db', N'99277974-cf8c-4128-b8e4-b103afb39776', N'd22bcf29-689c-40ac-ad0d-b09d8fe108b3', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'791d14f7-a378-4dc2-9f3f-92e917883a4f', N'41006bd8-fe01-417e-ad85-68307d6e0641', N'8255521e-2a8b-41c0-b940-104c239419ad', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'd5c16cc7-5dbd-4f70-8249-67f777cacdc6', N'f8feb042-3c6f-4ed5-a56a-1a0f9558e248', N'8255521e-2a8b-41c0-b940-104c239419ad', 190)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'4eb1aec7-23f8-4e8c-bf10-1abbcf358d9e', N'a93d520e-8a22-48ec-9a8b-66bad9fdbe51', N'f0afda5a-3909-4fc3-808b-61dbba9dc50e', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'e6625f79-54b9-402b-9d4b-79b62b79a219', N'eb2e902e-2cc2-4673-8f38-9ef5b98da974', N'65f5b9c6-1060-4f28-9f7d-77719a07fb21', 12)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'ddce06a4-6a9a-425b-9c20-9a05a59db6a2', N'8eca9760-a5b1-46b6-a785-43c9e71d610a', N'8255521e-2a8b-41c0-b940-104c239419ad', 1)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'7dc42c84-6eae-4d89-9dc4-6bfae7cb9401', N'd142d1be-644c-4693-91d0-5cd705a30089', N'9a9184b8-55d8-42ff-8de3-7b48aa088566', 19)
INSERT [dbo].[OperacionLIN] ([idOperacionLIN], [idOperacionCAB], [idProducto], [Cantidad]) VALUES (N'35435dea-d081-490f-90f8-1104ecf616c7', N'42d719e3-fe5c-41cb-b7e3-99dbc9745cf6', N'65f5b9c6-1060-4f28-9f7d-77719a07fb21', 19)
/****** Object:  Table [dbo].[OperacionCAB]    Script Date: 06/13/2022 19:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperacionCAB](
	[idOperacionCAB] [uniqueidentifier] NOT NULL,
	[Fecha] [datetime] NULL,
	[idPuntoDistribucionOrigen] [uniqueidentifier] NULL,
	[idPuntoDistribucionDestino] [uniqueidentifier] NULL,
	[idUsuario] [uniqueidentifier] NULL,
	[NumeroOperacion] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_OperacionCAB] PRIMARY KEY CLUSTERED 
(
	[idOperacionCAB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OperacionCAB] ON
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'f8feb042-3c6f-4ed5-a56a-1a0f9558e248', CAST(0x0000AEB30018F59B AS DateTime), N'd6ea7377-1fa4-4377-93ce-e7df96f36b85', N'252b178d-1020-4fce-b0b2-833db679e59c', N'e33ce278-5342-440f-8888-01c8cd04b46b', 23)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'b866717e-a911-44bd-a196-1d20a0f1c21a', CAST(0x0000AE4700FAB414 AS DateTime), N'53dcbddc-2586-4f5f-a201-a83afa5f3099', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'27002b82-937f-4593-8708-876d7327da63', 16)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'b325e454-6a04-4f57-8610-20ac47dde22d', CAST(0x0000AE590150BD78 AS DateTime), N'd6ea7377-1fa4-4377-93ce-e7df96f36b85', N'a69f1a0c-9cee-40b4-879e-5828e7322579', N'e33ce278-5342-440f-8888-01c8cd04b46b', 4)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'ee4f7792-1a5b-4014-8160-23f5e18c0b28', CAST(0x0000AE4700E93400 AS DateTime), N'27b41efc-8f40-4750-b32a-8c9babea213d', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'e33ce278-5342-440f-8888-01c8cd04b46b', 15)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'8eca9760-a5b1-46b6-a785-43c9e71d610a', CAST(0x0000AE47018B12AC AS DateTime), N'53dcbddc-2586-4f5f-a201-a83afa5f3099', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'a52ce7d5-c1f1-4a61-9c60-2e597f2f20f1', 8)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'41ebe076-dae0-43bf-90e4-474bf69c844b', CAST(0x0000AE47014C4616 AS DateTime), N'27b41efc-8f40-4750-b32a-8c9babea213d', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'e33ce278-5342-440f-8888-01c8cd04b46b', 2)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'c833a783-ccc9-4937-a3f2-4cc554bc4bdd', CAST(0x0000AE4701120218 AS DateTime), N'53dcbddc-2586-4f5f-a201-a83afa5f3099', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'a52ce7d5-c1f1-4a61-9c60-2e597f2f20f1', 17)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'd142d1be-644c-4693-91d0-5cd705a30089', CAST(0x0000AE470004BA8C AS DateTime), N'27b41efc-8f40-4750-b32a-8c9babea213d', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'27002b82-937f-4593-8708-876d7327da63', 9)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'8144b4aa-39f3-4ba2-8053-5e2ff300463b', CAST(0x0000AE47015679D4 AS DateTime), N'd6ea7377-1fa4-4377-93ce-e7df96f36b85', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'a52ce7d5-c1f1-4a61-9c60-2e597f2f20f1', 5)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'41006bd8-fe01-417e-ad85-68307d6e0641', CAST(0x0000AEAF0157DD1E AS DateTime), N'27b41efc-8f40-4750-b32a-8c9babea213d', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'e33ce278-5342-440f-8888-01c8cd04b46b', 22)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'58c907d9-3dc9-453d-95a4-733c1eb131dd', CAST(0x0000AEA100C9C1C4 AS DateTime), N'66c90bf7-3244-4f29-b6a7-51c3a4c292b4', N'413d08e4-98f0-4601-922b-bc5d272f747d', N'e33ce278-5342-440f-8888-01c8cd04b46b', 13)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'76283733-dfab-4cb3-a1e5-8a2bf8e11bb2', CAST(0x0000AEA1013143DA AS DateTime), N'66c90bf7-3244-4f29-b6a7-51c3a4c292b4', N'a69f1a0c-9cee-40b4-879e-5828e7322579', N'e33ce278-5342-440f-8888-01c8cd04b46b', 18)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'42d719e3-fe5c-41cb-b7e3-99dbc9745cf6', CAST(0x0000AEA10009F0E9 AS DateTime), N'27b41efc-8f40-4750-b32a-8c9babea213d', N'a69f1a0c-9cee-40b4-879e-5828e7322579', N'e33ce278-5342-440f-8888-01c8cd04b46b', 10)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'be2b4d82-f90a-405a-a492-9bf64b2210e1', CAST(0x0000AE4701629ED0 AS DateTime), N'53dcbddc-2586-4f5f-a201-a83afa5f3099', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'27002b82-937f-4593-8708-876d7327da63', 6)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'eb2e902e-2cc2-4673-8f38-9ef5b98da974', CAST(0x0000AE4701631784 AS DateTime), N'd6ea7377-1fa4-4377-93ce-e7df96f36b85', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'a52ce7d5-c1f1-4a61-9c60-2e597f2f20f1', 7)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'0af640c4-5045-4d6b-89a1-9f9c3c80eb20', CAST(0x0000AEA200AEE1F0 AS DateTime), N'5c589692-711a-407d-878e-0ec91edf8cbb', N'413d08e4-98f0-4601-922b-bc5d272f747d', N'a52ce7d5-c1f1-4a61-9c60-2e597f2f20f1', 20)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'c9d8dc8f-a002-4b92-84ac-adfbf311c186', CAST(0x0000AEA0014F9078 AS DateTime), N'27b41efc-8f40-4750-b32a-8c9babea213d', N'46af3ed6-c98d-4be8-b2da-77a729ee60d0', N'e33ce278-5342-440f-8888-01c8cd04b46b', 3)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'07dd7142-a25f-463d-b33d-af7e222128a5', CAST(0x0000AEA100C4C544 AS DateTime), N'27b41efc-8f40-4750-b32a-8c9babea213d', N'413d08e4-98f0-4601-922b-bc5d272f747d', N'e33ce278-5342-440f-8888-01c8cd04b46b', 12)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'5939abec-5028-48d7-b920-b078a18ad0cb', CAST(0x0000AEA100CCC2BC AS DateTime), N'66c90bf7-3244-4f29-b6a7-51c3a4c292b4', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'e33ce278-5342-440f-8888-01c8cd04b46b', 14)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'99277974-cf8c-4128-b8e4-b103afb39776', CAST(0x0000AEAF0151C0CA AS DateTime), N'd6ea7377-1fa4-4377-93ce-e7df96f36b85', N'27b41efc-8f40-4750-b32a-8c9babea213d', N'e33ce278-5342-440f-8888-01c8cd04b46b', 21)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'd6499911-7a17-4859-8722-b881e4274e72', CAST(0x0000AE63014879F4 AS DateTime), N'd6ea7377-1fa4-4377-93ce-e7df96f36b85', N'9f0b6715-59eb-45be-a5a3-9327c7dd032f', N'e33ce278-5342-440f-8888-01c8cd04b46b', 1)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'807ecdd8-0c0e-4cbd-880e-d0d1d838aa8f', CAST(0x0000AEA100A74EBB AS DateTime), N'27b41efc-8f40-4750-b32a-8c9babea213d', N'46af3ed6-c98d-4be8-b2da-77a729ee60d0', N'e33ce278-5342-440f-8888-01c8cd04b46b', 11)
INSERT [dbo].[OperacionCAB] ([idOperacionCAB], [Fecha], [idPuntoDistribucionOrigen], [idPuntoDistribucionDestino], [idUsuario], [NumeroOperacion]) VALUES (N'8f4cf515-c703-4cef-b12a-f6a8c7f094bf', CAST(0x0000AEA101401994 AS DateTime), N'27b41efc-8f40-4750-b32a-8c9babea213d', N'46af3ed6-c98d-4be8-b2da-77a729ee60d0', N'e33ce278-5342-440f-8888-01c8cd04b46b', 19)
SET IDENTITY_INSERT [dbo].[OperacionCAB] OFF
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 06/13/2022 19:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliaPatente](
	[idFamiliaPatente] [uniqueidentifier] NULL,
	[Familia] [uniqueidentifier] NULL,
	[Patente] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familia_copy]    Script Date: 06/13/2022 19:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familia_copy](
	[IdFamilia] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF__Familia_c__IdFam__0EA330E9]  DEFAULT (newid()),
	[Nombre] [varchar](1000) NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Familia___751F80CF0CBAE877] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 06/13/2022 19:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familia](
	[IdFamilia] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF__Familia__IdFamil__09DE7BCC]  DEFAULT (newid()),
	[Nombre] [varchar](1000) NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Familia__751F80CF07F6335A] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Familia] ([IdFamilia], [Nombre]) VALUES (N'cf2fcd96-bb43-4c6b-a3b3-160c85e9d872', N'RECURSOS HUMANOS')
INSERT [dbo].[Familia] ([IdFamilia], [Nombre]) VALUES (N'b4dccad7-0351-4faf-80a0-35cb82c0675a', N'SECRETARIA')
INSERT [dbo].[Familia] ([IdFamilia], [Nombre]) VALUES (N'54bc0266-20ee-4af5-a681-6d81a1b6a1d6', N'FACTURACION')
INSERT [dbo].[Familia] ([IdFamilia], [Nombre]) VALUES (N'86ebc5e1-452f-43f7-bb53-8c1cababe874', N'CONTADURIA')
INSERT [dbo].[Familia] ([IdFamilia], [Nombre]) VALUES (N'1c7e5453-e5ef-43f1-8193-adb14b9a8950', N'SISTEMAS')
/****** Object:  Table [dbo].[Customer]    Script Date: 06/13/2022 19:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[IdCustomer] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Cliente_IdCliente]  DEFAULT (newsequentialid()),
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[DateBirth] [date] NULL,
	[Doc] [varchar](50) NULL,
	[IdAddress] [uniqueidentifier] NULL,
	[State] [bit] NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCustomer] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'437d8083-6bbc-ec11-a53c-1cbfc06d7140', N'Eddie', N'Zunino', NULL, N'22334', NULL, 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'b0ad646c-6ebc-ec11-a53c-1cbfc06d7140', N'Vladimir', N'Putin', NULL, N'93456765', NULL, 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'dfe3a8ce-92bd-ec11-a53d-1cbfc06d7140', N'Marcelo Antonio', N'Di Deo', NULL, N'17359945', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'cd10d9ca-9abd-ec11-a53d-1cbfc06d7140', N'demo', N'demo', CAST(0xD7440B00 AS Date), N'demo', NULL, 0, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'fbd2463a-aabd-ec11-a53d-1cbfc06d7140', N'demo2', N'demo2', CAST(0xD4430B00 AS Date), N'demo', NULL, 0, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'6b363b18-acbd-ec11-a53d-1cbfc06d7140', N'demo2', N'demo2', CAST(0xD4430B00 AS Date), N'demo', NULL, 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'ed39e01d-b6bd-ec11-a53d-1cbfc06d7140', N'test7', N'test7', NULL, N'234324', NULL, 1, CAST(0x0000AE7901051FCD AS DateTime))
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'4accdc70-98be-ec11-a53d-1cbfc06d7140', N'CAPITAN', N'WAY', NULL, N'22456765', NULL, 1, CAST(0x0000AE7A0136967B AS DateTime))
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'df525cdc-e2d9-ec11-a547-1cbfc06d7140', N'VEREMOS', N'TESTING PARCIAL', NULL, N'34332112', NULL, 1, CAST(0x0000AE9D00CBACC2 AS DateTime))
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'dfc4ea32-b367-e911-b60a-88b111dc18cd', N'Alejandro', N'Vallejo', CAST(0x130E0B00 AS Date), N'31243721', N'46c3019e-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'a9447091-b867-e911-b60a-88b111dc18cd', N'Julio', N'Panini', CAST(0x5FF20A00 AS Date), N'31243721', N'46c3019e-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'a042345f-bb67-e911-b60a-88b111dc18cd', N'Roberto', N'Maluf', CAST(0x65F40A00 AS Date), N'31243721', N'46c3019e-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'9bddd372-bb67-e911-b60a-88b111dc18cd', N'Roberto', N'Cremona', CAST(0x1AFA0A00 AS Date), N'31243721', N'46c3019e-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'9875b881-bb67-e911-b60a-88b111dc18cd', N'SIlvia', N'Jacobez', CAST(0x1D0E0B00 AS Date), N'31243721', N'46c3019e-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'cd309cb1-bb67-e911-b60a-88b111dc18cd', N'Adriana', N'De Santis', CAST(0x730E0B00 AS Date), N'31243721', N'46c3019e-198b-ea11-81a3-e8d8d142d59b', 0, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'9ad8bf04-6868-e911-b60b-88b111dc18cd', N'Enrique', N'Lalia', CAST(0x210E0B00 AS Date), N'31243721', N'46c3019e-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'49af6dae-4a71-ea11-8198-98af655c0ae3', N'Andrea', N'Guigliani', CAST(0x510E0B00 AS Date), N'31243721', N'46c3019e-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'221421aa-5071-ea11-8198-98af655c0ae3', N'Siria', N'Alarcon', CAST(0x160E0B00 AS Date), N'31243721', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'b36ba268-7371-ea11-8198-98af655c0ae3', N'Daniel', N'Fernandez', CAST(0xD0150B00 AS Date), N'94531565', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'7285b85b-7771-ea11-8198-98af655c0ae3', N'Mario', N'Etchevarne', CAST(0x64260B00 AS Date), N'1234568', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'59e3005c-f471-ea11-8198-98af655c0ae3', N'Francisco', N'Ranea', CAST(0x8F1D0B00 AS Date), N'5624865', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b', 0, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'82748e1b-f571-ea11-8198-98af655c0ae3', N'Dario', N'Chickiar', CAST(0x1D260B00 AS Date), N'1234444', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'd27b510d-9bcb-4e25-a94f-9eebaacfe703', N'Alfredo', N'Ramos', CAST(0x430D0B00 AS Date), N'31243721', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'f8125fed-ba5c-e911-9c4f-b8975a5b5736', N'Oscar', N'Mediavilla', CAST(0x030D0B00 AS Date), N'31243721', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'f9125fed-ba5c-e911-9c4f-b8975a5b5736', N'Paula', N'Santini', CAST(0x4C0D0B00 AS Date), N'31243721', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
INSERT [dbo].[Customer] ([IdCustomer], [FirstName], [LastName], [DateBirth], [Doc], [IdAddress], [State], [InsertDate]) VALUES (N'85d670a1-bb5c-e911-9c4f-b8975a5b5736', N'Pia', N'Santini', CAST(0x430D0B00 AS Date), N'31243721', N'bfb7f9b7-198b-ea11-81a3-e8d8d142d59b', 1, NULL)
/****** Object:  Table [dbo].[Almacen]    Script Date: 06/13/2022 19:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Almacen](
	[id] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Localidad] [varchar](50) NULL,
	[Provincia] [varchar](50) NULL,
 CONSTRAINT [PK_Almacen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Address]    Script Date: 06/13/2022 19:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[IdAddress] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Address_IdAddress]  DEFAULT (newsequentialid()),
	[Street] [varchar](50) NULL,
	[Number] [int] NULL,
	[City] [varchar](50) NULL,
	[idCustomer] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[IdAddress] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
