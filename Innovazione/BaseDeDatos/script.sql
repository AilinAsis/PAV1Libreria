USE [master]
GO
/****** Object:  Database [InnovazioneNueva]    Script Date: 1/11/2018 17:11:09 ******/
CREATE DATABASE [InnovazioneNueva]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InnovazioneNueva', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\InnovazioneNueva.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InnovazioneNueva_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\InnovazioneNueva_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [InnovazioneNueva] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InnovazioneNueva].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InnovazioneNueva] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET ARITHABORT OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InnovazioneNueva] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InnovazioneNueva] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InnovazioneNueva] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InnovazioneNueva] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [InnovazioneNueva] SET  MULTI_USER 
GO
ALTER DATABASE [InnovazioneNueva] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InnovazioneNueva] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InnovazioneNueva] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InnovazioneNueva] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InnovazioneNueva] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InnovazioneNueva] SET QUERY_STORE = OFF
GO
USE [InnovazioneNueva]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [InnovazioneNueva]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 1/11/2018 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nroDni] [int] NOT NULL,
	[tipoDni] [int] NOT NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[mail] [varchar](200) NULL,
	[telefono] [varchar](200) NULL,
	[estadoBajaCliente] [varchar](1) NULL,
 CONSTRAINT [primaryKeyCliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleEgreso]    Script Date: 1/11/2018 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleEgreso](
	[idEgreso] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [float] NOT NULL,
 CONSTRAINT [primaryKeyDetalleEgreso] PRIMARY KEY CLUSTERED 
(
	[idEgreso] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 1/11/2018 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[nroVenta] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subTotal] [float] NOT NULL,
 CONSTRAINT [chequeoPrimaryKeyDetalleVenta] PRIMARY KEY CLUSTERED 
(
	[nroVenta] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Egreso]    Script Date: 1/11/2018 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Egreso](
	[idEgreso] [int] IDENTITY(1,1) NOT NULL,
	[idProveedor] [int] NULL,
	[fechaEgreso] [date] NOT NULL,
	[fechaEntrega] [date] NULL,
	[idEstado] [int] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [primaryKeyEgreso] PRIMARY KEY CLUSTERED 
(
	[idEgreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 1/11/2018 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[idEstado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[estadoBajaEstado] [varchar](1) NOT NULL,
 CONSTRAINT [primaryKeyEstado] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 1/11/2018 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](200) NULL,
	[precio] [float] NOT NULL,
	[cantDisponible] [int] NOT NULL,
	[estadoBajaProducto] [varchar](1) NULL,
 CONSTRAINT [primaryKeyProducto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 1/11/2018 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[CUIL] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[estadoBajaProveedor] [varchar](1) NULL,
 CONSTRAINT [primaryKeyProveedor] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDni]    Script Date: 1/11/2018 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDni](
	[idTipoDni] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [primaryKeyTipoDni] PRIMARY KEY CLUSTERED 
(
	[idTipoDni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 1/11/2018 17:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nomUser] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [priamryKeyUser] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nomUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 1/11/2018 17:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[nroVenta] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NOT NULL,
	[fechaFactura] [datetime] NOT NULL,
	[pagado] [varchar](1) NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [chequeoPrimaryKeyVenta] PRIMARY KEY CLUSTERED 
(
	[nroVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [foreignKeyTipoDniCliente] FOREIGN KEY([tipoDni])
REFERENCES [dbo].[TipoDni] ([idTipoDni])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [foreignKeyTipoDniCliente]
GO
ALTER TABLE [dbo].[DetalleEgreso]  WITH CHECK ADD  CONSTRAINT [foreignKeyDetalleEgresoEgres] FOREIGN KEY([idEgreso])
REFERENCES [dbo].[Egreso] ([idEgreso])
GO
ALTER TABLE [dbo].[DetalleEgreso] CHECK CONSTRAINT [foreignKeyDetalleEgresoEgres]
GO
ALTER TABLE [dbo].[DetalleEgreso]  WITH CHECK ADD  CONSTRAINT [foreignKeyDetalleEgresoProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleEgreso] CHECK CONSTRAINT [foreignKeyDetalleEgresoProducto]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [chequeoForeignKeyDetalleVentaArticulo] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [chequeoForeignKeyDetalleVentaArticulo]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [chequeoForeignKeyDetalleVentaVenta] FOREIGN KEY([nroVenta])
REFERENCES [dbo].[Venta] ([nroVenta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [chequeoForeignKeyDetalleVentaVenta]
GO
ALTER TABLE [dbo].[Egreso]  WITH CHECK ADD  CONSTRAINT [foreignKeyEgresoEstado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Estado] ([idEstado])
GO
ALTER TABLE [dbo].[Egreso] CHECK CONSTRAINT [foreignKeyEgresoEstado]
GO
ALTER TABLE [dbo].[Egreso]  WITH CHECK ADD  CONSTRAINT [foreignKeyEgresoProveedor] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[Egreso] CHECK CONSTRAINT [foreignKeyEgresoProveedor]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [chequeoForeignKeyVenta] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [chequeoForeignKeyVenta]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [chequeoEstadoCliente] CHECK  (([estadoBajaCliente]='S' OR [estadoBajaCliente]='N'))
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [chequeoEstadoCliente]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [chequeoEstadoProducto] CHECK  (([estadoBajaProducto]='S' OR [estadoBajaProducto]='N'))
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [chequeoEstadoProducto]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [chequeoEstadoProveedor] CHECK  (([estadoBajaProveedor]='S' OR [estadoBajaProveedor]='N'))
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [chequeoEstadoProveedor]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [chequeoEstadoUsuario] CHECK  (([estado]='S' OR [estado]='N'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [chequeoEstadoUsuario]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [chequeoPagadoVenta] CHECK  (([pagado]='S' OR [pagado]='N'))
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [chequeoPagadoVenta]
GO
USE [master]
GO
ALTER DATABASE [InnovazioneNueva] SET  READ_WRITE 
GO
