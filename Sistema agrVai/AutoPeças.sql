USE [master]
GO
/****** Object:  Database [AutoPecas]    Script Date: 24/06/2019 21:12:41 ******/
CREATE DATABASE [AutoPecas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AutoPecas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AutoPecas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AutoPecas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AutoPecas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AutoPecas] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AutoPecas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AutoPecas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AutoPecas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AutoPecas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AutoPecas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AutoPecas] SET ARITHABORT OFF 
GO
ALTER DATABASE [AutoPecas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AutoPecas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AutoPecas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AutoPecas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AutoPecas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AutoPecas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AutoPecas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AutoPecas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AutoPecas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AutoPecas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AutoPecas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AutoPecas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AutoPecas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AutoPecas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AutoPecas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AutoPecas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AutoPecas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AutoPecas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AutoPecas] SET  MULTI_USER 
GO
ALTER DATABASE [AutoPecas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AutoPecas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AutoPecas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AutoPecas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AutoPecas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AutoPecas] SET QUERY_STORE = OFF
GO
USE [AutoPecas]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 24/06/2019 21:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Telefone] [nvarchar](15) NOT NULL,
	[CPF] [numeric](11, 0) NOT NULL,
	[Endereco] [nvarchar](50) NOT NULL,
	[Num] [int] NULL,
	[CEP] [nvarchar](50) NOT NULL,
	[Cidade] [nvarchar](50) NOT NULL,
	[UF] [char](2) NOT NULL,
	[Nascimento] [date] NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Sexo] [char](2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 24/06/2019 21:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[desc_produto] [nvarchar](50) NOT NULL,
	[Modelo] [nvarchar](50) NOT NULL,
	[Ano] [numeric](4, 0) NOT NULL,
	[Qtde] [int] NOT NULL,
	[Valor] [numeric](18, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venda]    Script Date: 24/06/2019 21:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[id_venda] [int] IDENTITY(1,1) NOT NULL,
	[Cliente] [nvarchar](50) NOT NULL,
	[Produto] [nvarchar](50) NOT NULL,
	[Qtde] [int] NOT NULL,
	[Valor] [numeric](18, 2) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [AutoPecas] SET  READ_WRITE 
GO
