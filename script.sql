USE [master]
GO
/****** Object:  Database [sorveteria_milkshackper]    Script Date: 06/09/2023 12:39:23 ******/
CREATE DATABASE [sorveteria_milkshackper]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sorveteria_milkshackper', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\sorveteria_milkshackper.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sorveteria_milkshackper_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\sorveteria_milkshackper_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sorveteria_milkshackper] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sorveteria_milkshackper].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sorveteria_milkshackper] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET ARITHABORT OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sorveteria_milkshackper] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sorveteria_milkshackper] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sorveteria_milkshackper] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sorveteria_milkshackper] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [sorveteria_milkshackper] SET  MULTI_USER 
GO
ALTER DATABASE [sorveteria_milkshackper] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sorveteria_milkshackper] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sorveteria_milkshackper] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sorveteria_milkshackper] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sorveteria_milkshackper] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sorveteria_milkshackper] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [sorveteria_milkshackper] SET QUERY_STORE = OFF
GO
USE [sorveteria_milkshackper]
GO
/****** Object:  Table [dbo].[banco_milckshacksper]    Script Date: 06/09/2023 12:39:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[banco_milckshacksper](
	[email] [varchar](50) NOT NULL,
	[senha] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_banco_milckshacksper] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_1]    Script Date: 06/09/2023 12:39:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[senha] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [sorveteria_milkshackper] SET  READ_WRITE 
GO
