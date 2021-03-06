USE [master]
GO
/****** Object:  Database [Innovazione]    Script Date: 15/9/2018 13:57:06 ******/
CREATE DATABASE [Innovazione]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Innovazione', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Innovazione.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Innovazione_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Innovazione_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Innovazione] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Innovazione].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Innovazione] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Innovazione] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Innovazione] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Innovazione] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Innovazione] SET ARITHABORT OFF 
GO
ALTER DATABASE [Innovazione] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Innovazione] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Innovazione] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Innovazione] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Innovazione] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Innovazione] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Innovazione] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Innovazione] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Innovazione] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Innovazione] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Innovazione] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Innovazione] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Innovazione] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Innovazione] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Innovazione] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Innovazione] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Innovazione] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Innovazione] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Innovazione] SET  MULTI_USER 
GO
ALTER DATABASE [Innovazione] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Innovazione] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Innovazione] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Innovazione] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Innovazione] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Innovazione] SET QUERY_STORE = OFF
GO
USE [Innovazione]
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
USE [Innovazione]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[nroDni] [int] NOT NULL,
	[tipoDni] [int] NOT NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[mail] [varchar](200) NULL,
	[telefono] [varchar](200) NULL,
 CONSTRAINT [primaryKeyCliente] PRIMARY KEY CLUSTERED 
(
	[nroDni] ASC,
	[tipoDni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[idEgreso] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [primaryKeyDetalleCompra] PRIMARY KEY CLUSTERED 
(
	[idEgreso] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[nroFactura] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [primaryKeyDetalleFactura] PRIMARY KEY CLUSTERED 
(
	[nroFactura] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleReserva]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleReserva](
	[idReserva] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NULL,
	[descripcion] [varchar](300) NULL,
 CONSTRAINT [primaryKeyDetalleReserva] PRIMARY KEY CLUSTERED 
(
	[idReserva] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Egreso]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Egreso](
	[idEgreso] [int] NOT NULL,
	[idProveedor] [int] NULL,
	[fechaEgreso] [date] NULL,
	[fechaEntrega] [date] NULL,
	[compra] [varchar](1) NOT NULL,
	[idEstado] [int] NULL,
 CONSTRAINT [primaryKeyEgreso] PRIMARY KEY CLUSTERED 
(
	[idEgreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[idEstado] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [primaryKeyEstado] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[nroFactura] [int] NOT NULL,
	[nroDniCliente] [int] NULL,
	[tipoDniCliente] [int] NULL,
	[fechaFactura] [date] NOT NULL,
	[pagado] [varchar](1) NOT NULL,
 CONSTRAINT [primaryKeyFactura] PRIMARY KEY CLUSTERED 
(
	[nroFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](200) NULL,
	[precio] [float] NOT NULL,
	[cantDisponible] [int] NOT NULL,
 CONSTRAINT [primaryKeyProducto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[CUIL] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
 CONSTRAINT [primaryKeyProveedor] PRIMARY KEY CLUSTERED 
(
	[CUIL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[idReserva] [int] NOT NULL,
	[nroDni] [int] NULL,
	[tipoDni] [int] NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaEntrega] [date] NOT NULL,
	[idEstado] [int] NOT NULL,
	[precioManoObra] [float] NULL,
	[nroFactura] [int] NULL,
	[seña] [float] NULL,
 CONSTRAINT [primaryKeyReserva] PRIMARY KEY CLUSTERED 
(
	[idReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDni]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDni](
	[idTipoDni] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [primaryKeyTipoDni] PRIMARY KEY CLUSTERED 
(
	[idTipoDni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/9/2018 13:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] NOT NULL,
	[nomUser] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[activo] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [foreignKeyTipoDniCliente] FOREIGN KEY([tipoDni])
REFERENCES [dbo].[TipoDni] ([idTipoDni])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [foreignKeyTipoDniCliente]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [foreignKeyDetalleCompraEgreso] FOREIGN KEY([idEgreso])
REFERENCES [dbo].[Egreso] ([idEgreso])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [foreignKeyDetalleCompraEgreso]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [foreignKeyDetalleCompraProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [foreignKeyDetalleCompraProducto]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [foreignKeyDetalleFacturaFactura] FOREIGN KEY([nroFactura])
REFERENCES [dbo].[Factura] ([nroFactura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [foreignKeyDetalleFacturaFactura]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [foreignKeyDetalleFacturaProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [foreignKeyDetalleFacturaProducto]
GO
ALTER TABLE [dbo].[DetalleReserva]  WITH CHECK ADD  CONSTRAINT [foreignKeyDetalleReservaProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleReserva] CHECK CONSTRAINT [foreignKeyDetalleReservaProducto]
GO
ALTER TABLE [dbo].[DetalleReserva]  WITH CHECK ADD  CONSTRAINT [foreignKeyDetalleReservaReserva] FOREIGN KEY([idReserva])
REFERENCES [dbo].[Reserva] ([idReserva])
GO
ALTER TABLE [dbo].[DetalleReserva] CHECK CONSTRAINT [foreignKeyDetalleReservaReserva]
GO
ALTER TABLE [dbo].[Egreso]  WITH CHECK ADD  CONSTRAINT [foreginKeyEgresoProveedor] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedor] ([CUIL])
GO
ALTER TABLE [dbo].[Egreso] CHECK CONSTRAINT [foreginKeyEgresoProveedor]
GO
ALTER TABLE [dbo].[Egreso]  WITH CHECK ADD  CONSTRAINT [foreignKeyEgresoEstado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Estado] ([idEstado])
GO
ALTER TABLE [dbo].[Egreso] CHECK CONSTRAINT [foreignKeyEgresoEstado]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [foreignKeyClienteFactura] FOREIGN KEY([nroDniCliente], [tipoDniCliente])
REFERENCES [dbo].[Cliente] ([nroDni], [tipoDni])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [foreignKeyClienteFactura]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [foreignKeyReseraCliente] FOREIGN KEY([nroDni], [tipoDni])
REFERENCES [dbo].[Cliente] ([nroDni], [tipoDni])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [foreignKeyReseraCliente]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [foreignKeyReservaEstado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Estado] ([idEstado])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [foreignKeyReservaEstado]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [foreignKeyReservaFactura] FOREIGN KEY([nroFactura])
REFERENCES [dbo].[Factura] ([nroFactura])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [foreignKeyReservaFactura]
GO
ALTER TABLE [dbo].[Egreso]  WITH CHECK ADD  CONSTRAINT [checkCompraVarchar] CHECK  (([compra]='S' OR [compra]='N'))
GO
ALTER TABLE [dbo].[Egreso] CHECK CONSTRAINT [checkCompraVarchar]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [checkFechaFactura] CHECK  (([fechaFactura]<=getdate()))
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [checkFechaFactura]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [checkPagadoFactura] CHECK  (([pagado]='S' OR [pagado]='N'))
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [checkPagadoFactura]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [checkFechasReserva] CHECK  (([fechaInicio]<=[fechaEntrega]))
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [checkFechasReserva]
GO
USE [master]
GO
ALTER DATABASE [Innovazione] SET  READ_WRITE 
GO
