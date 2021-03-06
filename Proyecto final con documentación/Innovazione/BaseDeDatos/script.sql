USE [master]
GO
/****** Object:  Database [Innovazione]    Script Date: 15/11/2018 18:39:29 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/11/2018 18:39:30 ******/
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
	[estadoBajaCliente] [varchar](1) NOT NULL,
 CONSTRAINT [pkCliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleEgreso]    Script Date: 15/11/2018 18:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleEgreso](
	[idDetalleEgreso] [int] IDENTITY(1,1) NOT NULL,
	[idEgreso] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [float] NOT NULL,
 CONSTRAINT [pkDetalleEgreso] PRIMARY KEY CLUSTERED 
(
	[idDetalleEgreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 15/11/2018 18:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[idDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[nroVenta] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subTotal] [float] NOT NULL,
 CONSTRAINT [pKDetalleVenta] PRIMARY KEY CLUSTERED 
(
	[idDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Egreso]    Script Date: 15/11/2018 18:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Egreso](
	[idEgreso] [int] IDENTITY(1,1) NOT NULL,
	[idProveedor] [int] NULL,
	[fechaEgreso] [date] NOT NULL,
	[fechaEntrega] [date] NULL,
	[estadoEgreso] [varchar](1) NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [pkEgreso] PRIMARY KEY CLUSTERED 
(
	[idEgreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 15/11/2018 18:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](200) NULL,
	[precioCompra] [float] NOT NULL,
	[precioVenta] [float] NOT NULL,
	[cantDisponible] [int] NOT NULL,
	[estadoBajaProducto] [varchar](1) NOT NULL,
 CONSTRAINT [pkProducto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 15/11/2018 18:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[CUIL] [varchar](11) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[estadoBajaProveedor] [varchar](1) NOT NULL,
 CONSTRAINT [pkProveedor] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDni]    Script Date: 15/11/2018 18:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDni](
	[idTipoDni] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [primaryKeyTD] PRIMARY KEY CLUSTERED 
(
	[idTipoDni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/11/2018 18:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nomUser] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [pkUsuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 15/11/2018 18:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[nroVenta] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NOT NULL,
	[fechaFactura] [date] NOT NULL,
	[pagado] [varchar](1) NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [pkVenta] PRIMARY KEY CLUSTERED 
(
	[nroVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idCliente], [nroDni], [tipoDni], [apellido], [nombre], [mail], [telefono], [estadoBajaCliente]) VALUES (1, 40026118, 1, N'Martínez', N'Gabriel Gonzalo', N'martinez.gabriel.gonzalo@gmail.com', N'0357415401415', N'S')
INSERT [dbo].[Cliente] ([idCliente], [nroDni], [tipoDni], [apellido], [nombre], [mail], [telefono], [estadoBajaCliente]) VALUES (2, 42338842, 1, N'Perrone', N'Fabrizio Uriel', NULL, NULL, N'S')
INSERT [dbo].[Cliente] ([idCliente], [nroDni], [tipoDni], [apellido], [nombre], [mail], [telefono], [estadoBajaCliente]) VALUES (3, 36314795, 1, N'Zurita', N'Gonzalo', N'gonzalo.zurita92@gmail.com', N'0351153933195', N'S')
INSERT [dbo].[Cliente] ([idCliente], [nroDni], [tipoDni], [apellido], [nombre], [mail], [telefono], [estadoBajaCliente]) VALUES (4, 41593729, 1, N'Mezzopeva', N'Faundo', N'', N'', N'S')
INSERT [dbo].[Cliente] ([idCliente], [nroDni], [tipoDni], [apellido], [nombre], [mail], [telefono], [estadoBajaCliente]) VALUES (5, 43607780, 1, N'Perrone', N'Ian Lucca', N'', N'', N'S')
INSERT [dbo].[Cliente] ([idCliente], [nroDni], [tipoDni], [apellido], [nombre], [mail], [telefono], [estadoBajaCliente]) VALUES (6, 40029199, 1, N'Rodriguez', N'Federico', N'', N'', N'S')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[DetalleEgreso] ON 

INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (1, 1, 10, 2, 16.66)
INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (2, 1, 13, 2, 11.1111111111111)
INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (3, 2, 14, 1, 10)
INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (4, 2, 16, 1, 13.8888888888889)
INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (5, 2, 15, 3, 41.6666666666667)
INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (6, 3, 3, 15, 58.3333333333334)
INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (7, 3, 13, 1, 5.55555555555556)
INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (8, 4, 8, 2, 14.4444444444444)
INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (9, 4, 13, 3, 16.6666666666667)
INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (10, 5, 15, 5, 69.4444444444445)
INSERT [dbo].[DetalleEgreso] ([idDetalleEgreso], [idEgreso], [idProducto], [cantidad], [subtotal]) VALUES (11, 5, 16, 5, 69.4444444444445)
SET IDENTITY_INSERT [dbo].[DetalleEgreso] OFF
SET IDENTITY_INSERT [dbo].[DetalleVenta] ON 

INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subTotal]) VALUES (1, 1, 1, 1, 18)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subTotal]) VALUES (2, 1, 2, 1, 18)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subTotal]) VALUES (3, 2, 2, 1, 18)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subTotal]) VALUES (4, 2, 3, 1, 7)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subTotal]) VALUES (5, 3, 20, 3, 60)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subTotal]) VALUES (6, 3, 19, 2, 60)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subTotal]) VALUES (7, 4, 3, 2, 14)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subTotal]) VALUES (8, 4, 20, 3, 60)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subTotal]) VALUES (9, 5, 20, 2, 40)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subTotal]) VALUES (10, 5, 19, 1, 30)
SET IDENTITY_INSERT [dbo].[DetalleVenta] OFF
SET IDENTITY_INSERT [dbo].[Egreso] ON 

INSERT [dbo].[Egreso] ([idEgreso], [idProveedor], [fechaEgreso], [fechaEntrega], [estadoEgreso], [total]) VALUES (1, 1, CAST(N'2018-11-06' AS Date), CAST(N'2018-11-06' AS Date), N'E', 27.7711111111111)
INSERT [dbo].[Egreso] ([idEgreso], [idProveedor], [fechaEgreso], [fechaEntrega], [estadoEgreso], [total]) VALUES (2, 1, CAST(N'2018-11-06' AS Date), CAST(N'2018-11-07' AS Date), N'E', 65.5555555555556)
INSERT [dbo].[Egreso] ([idEgreso], [idProveedor], [fechaEgreso], [fechaEntrega], [estadoEgreso], [total]) VALUES (3, 1, CAST(N'2018-11-07' AS Date), CAST(N'2018-11-14' AS Date), N'E', 63.888888888889)
INSERT [dbo].[Egreso] ([idEgreso], [idProveedor], [fechaEgreso], [fechaEntrega], [estadoEgreso], [total]) VALUES (4, 1, CAST(N'2018-11-14' AS Date), CAST(N'2018-11-14' AS Date), N'E', 31.1111111111111)
INSERT [dbo].[Egreso] ([idEgreso], [idProveedor], [fechaEgreso], [fechaEntrega], [estadoEgreso], [total]) VALUES (5, 1, CAST(N'2018-11-14' AS Date), NULL, N'N', 148.8889)
SET IDENTITY_INSERT [dbo].[Egreso] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (1, N'Lapicera BIC', N'Todos los colores en cualquier trazo!', 10, 18, 0, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (2, N'Corrector Simball', N'TAIKO', 10, 18, 0, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (3, N'Goma Maped', N'Goma de borrar', 3.88888888888889, 7, 13, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (4, N'Fotocopias ByN', N'', 0, 2, 1000000, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (5, N'Fotocopia Color', N'', 0, 20, 1000000, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (6, N'Lapiz de Color BIC', N'Caja de color BIC', 22.2222222222222, 40, 0, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (7, N'Cartulina', N'Cartulina de diversos colores', 5.55555555555556, 10, 0, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (8, N'Afiches', N'Afiche de todos los colores', 7.22222222222222, 13, 2, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (9, N'Papel Creppé', N'', 10, 18, 0, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (10, N'Papel de forrar', N'', 8.33333333333333, 15, 0, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (11, N'Papel madera', N'', 5.55555555555556, 10, 0, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (12, N'Mantel estampado', N'', 27.7777777777778, 50, 20, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (13, N'Bolsa de cartón chica', N'', 5.55555555555556, 10, 4, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (14, N'Bolsa de cartón mediana', N'', 10, 18, 21, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (15, N'Bolsa de cartón grande', N'', 13.8888888888889, 25, 28, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (16, N'Fibron al agua ITO', N'', 13.8888888888889, 25, 26, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (17, N'Fibrón permanente ITO', N'', 19.4444444444444, 35, 20, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (18, N'Fibrón de pizarra ITO', N'', 25, 45, 20, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (19, N'Resaltadores Faber Castell', N'', 16.6666666666667, 30, 17, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (20, N'Resaltadores BIC', N'', 11.1111111111111, 20, 12, N'S')
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [precioCompra], [precioVenta], [cantDisponible], [estadoBajaProducto]) VALUES (21, N'Resaltador FILGO', N'', 8.33333333333333, 15, 20, N'S')
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([idProveedor], [CUIL], [nombre], [apellido], [estadoBajaProveedor]) VALUES (1, N'20400261181', N'Gonzalo', N'Martínez', N'S')
INSERT [dbo].[Proveedor] ([idProveedor], [CUIL], [nombre], [apellido], [estadoBajaProveedor]) VALUES (2, N'20711151113', N'Multipapel', N'Asupapel S.A.', N'S')
INSERT [dbo].[Proveedor] ([idProveedor], [CUIL], [nombre], [apellido], [estadoBajaProveedor]) VALUES (3, N'30615419938', N'Comercial', N'Suma', N'S')
INSERT [dbo].[Proveedor] ([idProveedor], [CUIL], [nombre], [apellido], [estadoBajaProveedor]) VALUES (4, N'20264138885', N'Marcelo Fabian', N'Alvarez', N'S')
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
SET IDENTITY_INSERT [dbo].[TipoDni] ON 

INSERT [dbo].[TipoDni] ([idTipoDni], [descripcion]) VALUES (1, N'Documento Único')
INSERT [dbo].[TipoDni] ([idTipoDni], [descripcion]) VALUES (2, N'Libreta Cívica')
INSERT [dbo].[TipoDni] ([idTipoDni], [descripcion]) VALUES (3, N'Libreta de Enrolamiento')
SET IDENTITY_INSERT [dbo].[TipoDni] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([idUsuario], [nomUser], [contraseña], [estado]) VALUES (1, N'Keila123', N'innovazione', N'S')
INSERT [dbo].[Usuario] ([idUsuario], [nomUser], [contraseña], [estado]) VALUES (2, N'Gonza', N'atmilicon88...', N'S')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([nroVenta], [idCliente], [fechaFactura], [pagado], [total]) VALUES (1, 1, CAST(N'2018-11-06' AS Date), N'N', 36)
INSERT [dbo].[Venta] ([nroVenta], [idCliente], [fechaFactura], [pagado], [total]) VALUES (2, 2, CAST(N'2018-11-06' AS Date), N'N', 25)
INSERT [dbo].[Venta] ([nroVenta], [idCliente], [fechaFactura], [pagado], [total]) VALUES (3, 2, CAST(N'2018-11-07' AS Date), N'N', 118.8)
INSERT [dbo].[Venta] ([nroVenta], [idCliente], [fechaFactura], [pagado], [total]) VALUES (4, 6, CAST(N'2018-11-08' AS Date), N'S', 74)
INSERT [dbo].[Venta] ([nroVenta], [idCliente], [fechaFactura], [pagado], [total]) VALUES (5, 1, CAST(N'2018-11-14' AS Date), N'S', 70)
SET IDENTITY_INSERT [dbo].[Venta] OFF
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [fkClienteTD] FOREIGN KEY([tipoDni])
REFERENCES [dbo].[TipoDni] ([idTipoDni])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [fkClienteTD]
GO
ALTER TABLE [dbo].[DetalleEgreso]  WITH CHECK ADD  CONSTRAINT [fkDetalleEgresoEgreso] FOREIGN KEY([idEgreso])
REFERENCES [dbo].[Egreso] ([idEgreso])
GO
ALTER TABLE [dbo].[DetalleEgreso] CHECK CONSTRAINT [fkDetalleEgresoEgreso]
GO
ALTER TABLE [dbo].[DetalleEgreso]  WITH CHECK ADD  CONSTRAINT [fkDetalleEgresoProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleEgreso] CHECK CONSTRAINT [fkDetalleEgresoProducto]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [fkDetalleVentaProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [fkDetalleVentaProducto]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [fkDetalleVentaVenta] FOREIGN KEY([nroVenta])
REFERENCES [dbo].[Venta] ([nroVenta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [fkDetalleVentaVenta]
GO
ALTER TABLE [dbo].[Egreso]  WITH CHECK ADD  CONSTRAINT [fkEgresoProveedor] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[Egreso] CHECK CONSTRAINT [fkEgresoProveedor]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [fkVentaCliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [fkVentaCliente]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [chequeoEstadoCliente] CHECK  (([estadoBajaCliente]='S' OR [estadoBajaCliente]='N'))
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [chequeoEstadoCliente]
GO
ALTER TABLE [dbo].[Egreso]  WITH CHECK ADD  CONSTRAINT [chequeoEstadoEgreso] CHECK  (([estadoEgreso]='N' OR [estadoEgreso]='E'))
GO
ALTER TABLE [dbo].[Egreso] CHECK CONSTRAINT [chequeoEstadoEgreso]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [chequeoEstadoBajaProducto] CHECK  (([estadoBajaProducto]='S' OR [estadoBajaProducto]='N'))
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [chequeoEstadoBajaProducto]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [chequeoEstadoProveedor] CHECK  (([estadoBajaProveedor]='S' OR [estadoBajaProveedor]='N'))
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [chequeoEstadoProveedor]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [chequeoEstadoUsuario] CHECK  (([estado]='S' OR [estado]='N'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [chequeoEstadoUsuario]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [chequeoPagado] CHECK  (([pagado]='S' OR [pagado]='N'))
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [chequeoPagado]
GO
USE [master]
GO
ALTER DATABASE [Innovazione] SET  READ_WRITE 
GO
