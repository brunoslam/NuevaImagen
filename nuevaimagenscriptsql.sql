USE [master]
GO
/****** Object:  Database [NuevaImagen]    Script Date: 01-07-2016 21:56:18 ******/
CREATE DATABASE [NuevaImagen]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NuevaImagen', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\NuevaImagen.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NuevaImagen_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\NuevaImagen_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [NuevaImagen] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NuevaImagen].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NuevaImagen] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NuevaImagen] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NuevaImagen] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NuevaImagen] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NuevaImagen] SET ARITHABORT OFF 
GO
ALTER DATABASE [NuevaImagen] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NuevaImagen] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NuevaImagen] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NuevaImagen] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NuevaImagen] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NuevaImagen] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NuevaImagen] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NuevaImagen] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NuevaImagen] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NuevaImagen] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NuevaImagen] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NuevaImagen] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NuevaImagen] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NuevaImagen] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NuevaImagen] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NuevaImagen] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NuevaImagen] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NuevaImagen] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NuevaImagen] SET  MULTI_USER 
GO
ALTER DATABASE [NuevaImagen] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NuevaImagen] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NuevaImagen] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NuevaImagen] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NuevaImagen] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NuevaImagen] SET QUERY_STORE = OFF
GO
USE [NuevaImagen]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [NuevaImagen]
GO
/****** Object:  Table [dbo].[Aplicativo]    Script Date: 01-07-2016 21:56:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aplicativo](
	[ID_Aplicativo] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Aplicativo] [varchar](50) NULL,
	[Tintuta] [varchar](50) NULL,
	[Numero_Color] [varchar](50) NULL,
	[Oxidante] [varchar](50) NULL,
	[Fecha_Aplicacion] [date] NULL,
 CONSTRAINT [PK_Aplicativo] PRIMARY KEY CLUSTERED 
(
	[ID_Aplicativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 01-07-2016 21:56:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[DescripcionCliente] [varchar](250) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Vista]    Script Date: 01-07-2016 21:56:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista]
AS
SELECT        dbo.Aplicativo.ID_Aplicativo AS ID, dbo.Cliente.Nombre, dbo.Aplicativo.Aplicativo, dbo.Aplicativo.Tintuta, dbo.Aplicativo.Numero_Color AS [Número Color], dbo.Aplicativo.Oxidante, 
                         dbo.Aplicativo.Fecha_Aplicacion AS [Fecha Aplicación], dbo.Cliente.ID_Cliente
FROM            dbo.Aplicativo INNER JOIN
                         dbo.Cliente ON dbo.Aplicativo.ID_Cliente = dbo.Cliente.ID_Cliente

GO
ALTER TABLE [dbo].[Aplicativo]  WITH CHECK ADD  CONSTRAINT [FK_Aplicativo_Cliente] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Cliente] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Aplicativo] CHECK CONSTRAINT [FK_Aplicativo_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[IngresarAplicativo]    Script Date: 01-07-2016 21:56:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[IngresarAplicativo]
	-- Add the parameters for the stored procedure here
	
	@NombreCliente varchar(50) = '',
	@Telefono varchar(50)  = '',
	@Direccion varchar(50)  = '',
	@Descripcion varchar(150) = '',

	@Aplicativo varchar(50)  = '',
	@Tintura varchar(50)  = '',
	@NroColor varchar(50)  = '',
	@Oxidante varchar(50)  = '',
	@FechaAplicacion Date = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare @IdCliente int = 0;
    -- Insert statements for procedure here
	SELECT @IdCliente = ID_Cliente
	FROM Cliente
	WHERE Nombre = @NombreCliente
	
	IF(@IdCliente = 0)
	BEGIN
		INSERT INTO Cliente VALUES (@NombreCliente, @Telefono, @Direccion, @Descripcion)
		SELECT  TOP(1) @IdCliente = ID_Cliente FROM Cliente ORDER BY ID_Cliente DESC
	END

	INSERT INTO Aplicativo VALUES (@IdCliente, @Aplicativo, @Tintura, @NroColor, @Oxidante, @FechaAplicacion)	
	
END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[18] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Aplicativo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 219
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 6
               Left = 257
               Bottom = 136
               Right = 445
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2595
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3375
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista'
GO
USE [master]
GO
ALTER DATABASE [NuevaImagen] SET  READ_WRITE 
GO
