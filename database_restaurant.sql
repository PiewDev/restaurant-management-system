USE [master]
GO
/****** Object:  Database [Test_Final_Programacion_3]    Script Date: 21/2/2020 21:58:54 ******/
CREATE DATABASE [Test_Final_Programacion_3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Test_Final_Programacion_3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Test_Final_Programacion_3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Test_Final_Programacion_3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Test_Final_Programacion_3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Test_Final_Programacion_3] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Test_Final_Programacion_3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Test_Final_Programacion_3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET ARITHABORT OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET  MULTI_USER 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Test_Final_Programacion_3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Test_Final_Programacion_3] SET QUERY_STORE = OFF
GO
USE [Test_Final_Programacion_3]
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
USE [Test_Final_Programacion_3]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria2]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria2](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comanda]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comanda](
	[id_comanda] [int] NULL,
	[categoria] [varchar](50) NULL,
	[tipo] [varchar](50) NULL,
	[precio_unitario] [int] NULL,
	[cantidad] [int] NULL,
	[total] [int] NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comanda2]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comanda2](
	[id_comanda] [int] IDENTITY(1,1) NOT NULL,
	[id_mozo] [int] NOT NULL,
	[total] [int] NOT NULL,
	[fecha] [varchar](50) NOT NULL,
	[hora] [varchar](50) NOT NULL,
	[id_mesa] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estado] [varchar](50) NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaPrima]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaPrima](
	[id_materiaprima] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](50) NOT NULL,
	[marca] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaPrima2]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaPrima2](
	[id_materiaprima] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaPrimaUtilizada]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaPrimaUtilizada](
	[id_materiaprimautilizada] [int] IDENTITY(1,1) NOT NULL,
	[id_materiaprima] [int] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesa]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesa](
	[id_mesa] [int] IDENTITY(1,1) NOT NULL,
	[numero] [int] NOT NULL,
	[estado] [varchar](50) NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesa2]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesa2](
	[id_mesa] [int] IDENTITY(1,1) NOT NULL,
	[numero] [int] NULL,
	[estado] [varchar](50) NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesa3]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesa3](
	[id_mesa] [int] IDENTITY(1,1) NOT NULL,
	[numero] [int] NOT NULL,
	[id_estado] [int] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesa4]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesa4](
	[id_mesa] [int] IDENTITY(1,1) NOT NULL,
	[numero] [int] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mozo]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mozo](
	[id_mozo] [int] NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dni] [varchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[baja] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mozo2]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mozo2](
	[id_mozo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dni] [varchar](50) NULL,
	[fecha_nacimiento] [varchar](50) NULL,
	[baja] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [int] NULL,
	[precio_venta] [int] NULL,
	[tipo] [varchar](50) NULL,
	[id_categoria] [int] NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoCompuesto]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoCompuesto](
	[id_productocompuesto] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [float] NOT NULL,
	[precio_venta] [float] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoCompuesto2]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoCompuesto2](
	[id_productocompuesto] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [varchar](50) NOT NULL,
	[precio_venta] [varchar](50) NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoCompuesto3]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoCompuesto3](
	[id_productocompuesto] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [int] NULL,
	[precio_venta] [int] NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoCompuesto4]    Script Date: 21/2/2020 21:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoCompuesto4](
	[id_productocompuesto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[costo] [int] NOT NULL,
	[precio_venta] [int] NOT NULL,
	[id_materiaprima] [int] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoCompuesto5]    Script Date: 21/2/2020 21:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoCompuesto5](
	[id_productocompuesto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[costo] [int] NOT NULL,
	[precio_venta] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoSimple]    Script Date: 21/2/2020 21:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoSimple](
	[id_productosimple] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](50) NULL,
	[categoria] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [int] NULL,
	[precio_venta] [int] NULL,
	[cantidad] [int] NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoSimple2]    Script Date: 21/2/2020 21:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoSimple2](
	[id_productosimple] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [int] NOT NULL,
	[precio_venta] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoSimple3]    Script Date: 21/2/2020 21:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoSimple3](
	[id_productosimple] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [int] NOT NULL,
	[precio_venta] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temporal]    Script Date: 21/2/2020 21:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temporal](
	[id_temporal] [int] NOT NULL,
	[mesa] [int] NOT NULL,
	[total] [int] NOT NULL,
	[id_mozo] [int] NOT NULL,
	[id_productosimple] [int] NULL,
	[id_productocompuesto] [int] NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temporal2]    Script Date: 21/2/2020 21:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temporal2](
	[id_temporal] [int] NULL,
	[mesa] [int] NULL,
	[total] [int] NULL,
	[id_mozo] [int] NULL,
	[id_productosimple] [int] NULL,
	[id_productocompuesto] [int] NULL,
	[baja] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temporal3]    Script Date: 21/2/2020 21:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temporal3](
	[id_temporal] [int] NULL,
	[mesa] [int] NULL,
	[id_mozo] [int] NULL,
	[id_productosimple] [int] NULL,
	[id_productocompuesto] [int] NULL,
	[baja] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 21/2/2020 21:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[comanda] [int] NULL,
	[mozo] [varchar](50) NULL,
	[mesa] [int] NULL,
	[fecha] [varchar](50) NULL,
	[hora] [varchar](50) NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta2]    Script Date: 21/2/2020 21:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta2](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[comanda] [int] NULL,
	[mozo] [varchar](50) NULL,
	[mesa] [int] NULL,
	[fecha] [varchar](50) NULL,
	[hora] [varchar](50) NULL,
	[total] [int] NOT NULL,
	[baja] [int] NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Test_Final_Programacion_3] SET  READ_WRITE 
GO
