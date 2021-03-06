USE [master]
GO
/****** Object:  Database [ModelOficina]    Script Date: 12/06/2019 23:48:31 ******/
CREATE DATABASE [ModelOficina]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ModelOficina', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ModelOficina.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ModelOficina_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ModelOficina_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ModelOficina] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ModelOficina].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ModelOficina] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ModelOficina] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ModelOficina] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ModelOficina] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ModelOficina] SET ARITHABORT OFF 
GO
ALTER DATABASE [ModelOficina] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ModelOficina] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ModelOficina] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ModelOficina] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ModelOficina] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ModelOficina] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ModelOficina] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ModelOficina] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ModelOficina] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ModelOficina] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ModelOficina] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ModelOficina] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ModelOficina] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ModelOficina] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ModelOficina] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ModelOficina] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ModelOficina] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ModelOficina] SET RECOVERY FULL 
GO
ALTER DATABASE [ModelOficina] SET  MULTI_USER 
GO
ALTER DATABASE [ModelOficina] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ModelOficina] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ModelOficina] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ModelOficina] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ModelOficina] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ModelOficina', N'ON'
GO
ALTER DATABASE [ModelOficina] SET QUERY_STORE = OFF
GO
USE [ModelOficina]
GO
/****** Object:  Table [dbo].[Aluguer]    Script Date: 12/06/2019 23:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluguer](
	[IdAluguer] [int] IDENTITY(1,1) NOT NULL,
	[DataInicio] [nvarchar](max) NOT NULL,
	[DataFim] [nvarchar](max) NOT NULL,
	[Valor] [nvarchar](max) NOT NULL,
	[Kms] [nvarchar](max) NOT NULL,
	[ClienteIdCliente] [int] NOT NULL,
	[CarroAluguer_IdCarro] [int] NOT NULL,
 CONSTRAINT [PK_Aluguer] PRIMARY KEY CLUSTERED 
(
	[IdAluguer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carro]    Script Date: 12/06/2019 23:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carro](
	[IdCarro] [int] IDENTITY(1,1) NOT NULL,
	[NumeroChassis] [nvarchar](max) NOT NULL,
	[Marca] [nvarchar](max) NOT NULL,
	[Modelo] [nvarchar](max) NOT NULL,
	[Combustivel] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Carro] PRIMARY KEY CLUSTERED 
(
	[IdCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carro_CarroAluguer]    Script Date: 12/06/2019 23:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carro_CarroAluguer](
	[Estado] [nvarchar](max) NOT NULL,
	[Matricula] [nvarchar](max) NOT NULL,
	[IdCarro] [int] NOT NULL,
 CONSTRAINT [PK_Carro_CarroAluguer] PRIMARY KEY CLUSTERED 
(
	[IdCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carro_CarroOficina]    Script Date: 12/06/2019 23:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carro_CarroOficina](
	[Matricula] [nvarchar](max) NOT NULL,
	[Kms] [nvarchar](max) NOT NULL,
	[ClienteIdCliente] [int] NOT NULL,
	[IdCarro] [int] NOT NULL,
 CONSTRAINT [PK_Carro_CarroOficina] PRIMARY KEY CLUSTERED 
(
	[IdCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carro_CarroVenda]    Script Date: 12/06/2019 23:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carro_CarroVenda](
	[Extras] [nvarchar](max) NOT NULL,
	[IdCarro] [int] NOT NULL,
 CONSTRAINT [PK_Carro_CarroVenda] PRIMARY KEY CLUSTERED 
(
	[IdCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/06/2019 23:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](max) NOT NULL,
	[NIF] [nvarchar](max) NOT NULL,
	[Morada] [nvarchar](max) NOT NULL,
	[Contacto] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parcela]    Script Date: 12/06/2019 23:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parcela](
	[IdParcela] [int] IDENTITY(1,1) NOT NULL,
	[Valor] [nvarchar](max) NOT NULL,
	[Descricao] [nvarchar](max) NOT NULL,
	[ServicoIdServico] [int] NOT NULL,
 CONSTRAINT [PK_Parcela] PRIMARY KEY CLUSTERED 
(
	[IdParcela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicos]    Script Date: 12/06/2019 23:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicos](
	[IdServico] [int] IDENTITY(1,1) NOT NULL,
	[DataEntrada] [nvarchar](max) NOT NULL,
	[Tipo] [nvarchar](max) NOT NULL,
	[DataSaida] [nvarchar](max) NOT NULL,
	[CarroOficinaIdCarro] [int] NOT NULL,
 CONSTRAINT [PK_Servicos] PRIMARY KEY CLUSTERED 
(
	[IdServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venda]    Script Date: 12/06/2019 23:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[IdVendas] [int] IDENTITY(1,1) NOT NULL,
	[Valor] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Data] [nvarchar](max) NOT NULL,
	[ClienteIdCliente] [int] NOT NULL,
	[CarroVenda_IdCarro] [int] NOT NULL,
 CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 
(
	[IdVendas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_AluguerCarroAluguer]    Script Date: 12/06/2019 23:48:32 ******/
CREATE NONCLUSTERED INDEX [IX_FK_AluguerCarroAluguer] ON [dbo].[Aluguer]
(
	[CarroAluguer_IdCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ClienteAluguer]    Script Date: 12/06/2019 23:48:32 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ClienteAluguer] ON [dbo].[Aluguer]
(
	[ClienteIdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ClienteCarroOficina]    Script Date: 12/06/2019 23:48:32 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ClienteCarroOficina] ON [dbo].[Carro_CarroOficina]
(
	[ClienteIdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ServicoParcela]    Script Date: 12/06/2019 23:48:32 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ServicoParcela] ON [dbo].[Parcela]
(
	[ServicoIdServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CarroOficinaServico]    Script Date: 12/06/2019 23:48:32 ******/
CREATE NONCLUSTERED INDEX [IX_FK_CarroOficinaServico] ON [dbo].[Servicos]
(
	[CarroOficinaIdCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ClienteVenda]    Script Date: 12/06/2019 23:48:32 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ClienteVenda] ON [dbo].[Venda]
(
	[ClienteIdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_VendaCarroVenda]    Script Date: 12/06/2019 23:48:32 ******/
CREATE NONCLUSTERED INDEX [IX_FK_VendaCarroVenda] ON [dbo].[Venda]
(
	[CarroVenda_IdCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Aluguer]  WITH CHECK ADD  CONSTRAINT [FK_AluguerCarroAluguer] FOREIGN KEY([CarroAluguer_IdCarro])
REFERENCES [dbo].[Carro_CarroAluguer] ([IdCarro])
GO
ALTER TABLE [dbo].[Aluguer] CHECK CONSTRAINT [FK_AluguerCarroAluguer]
GO
ALTER TABLE [dbo].[Aluguer]  WITH CHECK ADD  CONSTRAINT [FK_ClienteAluguer] FOREIGN KEY([ClienteIdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Aluguer] CHECK CONSTRAINT [FK_ClienteAluguer]
GO
ALTER TABLE [dbo].[Carro_CarroAluguer]  WITH CHECK ADD  CONSTRAINT [FK_CarroAluguer_inherits_Carro] FOREIGN KEY([IdCarro])
REFERENCES [dbo].[Carro] ([IdCarro])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carro_CarroAluguer] CHECK CONSTRAINT [FK_CarroAluguer_inherits_Carro]
GO
ALTER TABLE [dbo].[Carro_CarroOficina]  WITH CHECK ADD  CONSTRAINT [FK_CarroOficina_inherits_Carro] FOREIGN KEY([IdCarro])
REFERENCES [dbo].[Carro] ([IdCarro])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carro_CarroOficina] CHECK CONSTRAINT [FK_CarroOficina_inherits_Carro]
GO
ALTER TABLE [dbo].[Carro_CarroOficina]  WITH CHECK ADD  CONSTRAINT [FK_ClienteCarroOficina] FOREIGN KEY([ClienteIdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Carro_CarroOficina] CHECK CONSTRAINT [FK_ClienteCarroOficina]
GO
ALTER TABLE [dbo].[Carro_CarroVenda]  WITH CHECK ADD  CONSTRAINT [FK_CarroVenda_inherits_Carro] FOREIGN KEY([IdCarro])
REFERENCES [dbo].[Carro] ([IdCarro])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carro_CarroVenda] CHECK CONSTRAINT [FK_CarroVenda_inherits_Carro]
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD  CONSTRAINT [FK_ServicoParcela] FOREIGN KEY([ServicoIdServico])
REFERENCES [dbo].[Servicos] ([IdServico])
GO
ALTER TABLE [dbo].[Parcela] CHECK CONSTRAINT [FK_ServicoParcela]
GO
ALTER TABLE [dbo].[Servicos]  WITH CHECK ADD  CONSTRAINT [FK_CarroOficinaServico] FOREIGN KEY([CarroOficinaIdCarro])
REFERENCES [dbo].[Carro_CarroOficina] ([IdCarro])
GO
ALTER TABLE [dbo].[Servicos] CHECK CONSTRAINT [FK_CarroOficinaServico]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_ClienteVenda] FOREIGN KEY([ClienteIdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_ClienteVenda]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_VendaCarroVenda] FOREIGN KEY([CarroVenda_IdCarro])
REFERENCES [dbo].[Carro_CarroVenda] ([IdCarro])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_VendaCarroVenda]
GO
USE [master]
GO
ALTER DATABASE [ModelOficina] SET  READ_WRITE 
GO
