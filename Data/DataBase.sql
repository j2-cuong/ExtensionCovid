USE [master]
GO
/****** Object:  Database [GTVT]    Script Date: 8/11/2021 4:21:50 PM ******/
CREATE DATABASE [GTVT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gtvt', FILENAME = N'D:\Fast\Fast\GTVT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'gtvt_log', FILENAME = N'D:\Fast\Fast\GTVT.ldf' , SIZE = 15040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GTVT] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GTVT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GTVT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GTVT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GTVT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GTVT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GTVT] SET ARITHABORT OFF 
GO
ALTER DATABASE [GTVT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GTVT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GTVT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GTVT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GTVT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GTVT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GTVT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GTVT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GTVT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GTVT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GTVT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GTVT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GTVT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GTVT] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [GTVT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GTVT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GTVT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GTVT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GTVT] SET  MULTI_USER 
GO
ALTER DATABASE [GTVT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GTVT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GTVT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GTVT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GTVT] SET DELAYED_DURABILITY = DISABLED 
GO
USE [GTVT]
GO
/****** Object:  Table [dbo].[DMBsy]    Script Date: 8/11/2021 4:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMBsy](
	[DMBsy_id] [uniqueidentifier] NOT NULL,
	[DMBsy_Ma] [nvarchar](250) NOT NULL,
	[DMBsy_Ten] [nvarchar](250) NOT NULL,
	[DMBsy_diaChi] [nvarchar](max) NOT NULL,
	[DMBsy_chuyenKhoa] [nvarchar](max) NULL,
	[DMBsy_Exp] [nvarchar](max) NULL,
	[DMBsy_Phone] [nvarchar](max) NOT NULL,
	[DMBsy_bangCap] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[DMBsy_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[DMBsy_Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DMHC]    Script Date: 8/11/2021 4:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMHC](
	[Tinh] [nvarchar](max) NOT NULL,
	[TinhCode] [nvarchar](max) NOT NULL,
	[Quan] [nvarchar](max) NOT NULL,
	[QuanCode] [nvarchar](max) NULL,
	[Xa] [nvarchar](max) NOT NULL,
	[XaCode] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DTuong]    Script Date: 8/11/2021 4:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DTuong](
	[DTuong_id] [uniqueidentifier] NOT NULL,
	[DTuong_ma] [char](50) NOT NULL,
	[DTuong_ten] [nvarchar](max) NOT NULL,
	[DTuong_nsinh] [datetime] NOT NULL,
	[DTuong_GTinh] [nvarchar](250) NULL,
	[DTuong_DVCtac] [nvarchar](max) NOT NULL,
	[DTuong_SDT] [nvarchar](10) NOT NULL,
	[DTuong_CCCD] [nvarchar](12) NOT NULL,
	[DTuong_BHYT] [nvarchar](15) NOT NULL,
	[DTuong_MaNhom] [nvarchar](50) NOT NULL,
	[DTuong_Tinh] [nvarchar](50) NOT NULL,
	[DTuong_TinhCode] [nvarchar](50) NOT NULL,
	[DTuong_Quan] [nvarchar](50) NOT NULL,
	[DTuong_QuanCode] [nvarchar](50) NOT NULL,
	[DTuong_Xa] [nvarchar](50) NOT NULL,
	[DTuong_XaCode] [nvarchar](50) NOT NULL,
	[DTuong_DCCtiet] [nvarchar](max) NOT NULL,
	[isTimeAdd] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[DTuong_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[DTuong_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GroupDTuong]    Script Date: 8/11/2021 4:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GroupDTuong](
	[GroupDTuong_id] [uniqueidentifier] NOT NULL,
	[GroupDTuong_ma] [char](50) NOT NULL,
	[GroupDTuong_ten] [nvarchar](max) NOT NULL,
	[isTimeAdd] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupDTuong_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[GroupDTuong_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Router]    Script Date: 8/11/2021 4:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Router](
	[Tinh] [nvarchar](max) NULL,
	[TinhCode] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sheet1]    Script Date: 8/11/2021 4:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sheet1](
	[Tinh] [nvarchar](max) NULL,
	[TinhCode] [nvarchar](max) NULL,
	[Quan] [nvarchar](max) NULL,
	[QuanCode] [nvarchar](max) NULL,
	[Xa] [nvarchar](max) NULL,
	[XaCode] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangChu]    Script Date: 8/11/2021 4:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TrangChu](
	[TrangChu_id] [uniqueidentifier] NOT NULL,
	[DTuong_ma] [char](50) NOT NULL,
	[DTuong_ten] [nvarchar](max) NULL,
	[DTuong_nsinh] [nvarchar](250) NOT NULL,
	[DTuong_GTinh] [nvarchar](250) NULL,
	[DTuong_DVCtac] [nvarchar](max) NULL,
	[DTuong_SDT] [nvarchar](10) NULL,
	[DTuong_CCCD] [nvarchar](12) NULL,
	[DTuong_BHYT] [nvarchar](15) NULL,
	[DTuong_MaNhom] [nvarchar](50) NULL,
	[DTuong_Tinh] [nvarchar](50) NULL,
	[DTuong_TinhCode] [nvarchar](50) NULL,
	[DTuong_Quan] [nvarchar](50) NULL,
	[DTuong_QuanCode] [nvarchar](50) NULL,
	[DTuong_Xa] [nvarchar](50) NULL,
	[DTuong_XaCode] [nvarchar](50) NULL,
	[DTuong_DCCtiet] [nvarchar](max) NULL,
	[vx_ma] [nvarchar](250) NOT NULL,
	[vx_ten] [nvarchar](250) NULL,
	[vx_nsx] [nvarchar](250) NULL,
	[vx_location] [nvarchar](250) NULL,
	[vx_lo] [nvarchar](250) NULL,
	[vx_ngayNhap] [nvarchar](250) NULL,
	[vx__slXuat] [int] NULL,
	[DMBsy_Ten] [nvarchar](250) NOT NULL,
	[DMBsy_diaChi] [nvarchar](max) NULL,
	[DMBsy_chuyenKhoa] [nvarchar](max) NULL,
	[DMBsy_Exp] [nvarchar](max) NULL,
	[DMBsy_Phone] [nvarchar](max) NOT NULL,
	[DMBsy_bangCap] [nvarchar](max) NULL,
	[vx_ma2] [nvarchar](250) NOT NULL,
	[vx_ten2] [nvarchar](250) NULL,
	[vx_nsx2] [nvarchar](250) NULL,
	[vx_location2] [nvarchar](250) NULL,
	[vx_lo2] [nvarchar](250) NULL,
	[vx_ngayNhap2] [nvarchar](250) NULL,
	[vx__slXuat2] [int] NULL,
	[DMBsy_Ten2] [nvarchar](250) NOT NULL,
	[DMBsy_diaChi2] [nvarchar](max) NULL,
	[DMBsy_chuyenKhoa2] [nvarchar](max) NULL,
	[DMBsy_Exp2] [nvarchar](max) NULL,
	[DMBsy_Phone2] [nvarchar](max) NOT NULL,
	[DMBsy_bangCap2] [nvarchar](max) NULL,
	[TimeTiem1] [nvarchar](250) NULL,
	[TimeTiem2] [nvarchar](250) NULL,
	[timeNew] [datetime] NULL,
	[timeUpdate] [datetime] NULL,
	[trang_thai] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[TrangChu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[DTuong_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VacXin]    Script Date: 8/11/2021 4:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VacXin](
	[vx_id] [uniqueidentifier] NOT NULL,
	[vx_ma] [nvarchar](250) NOT NULL,
	[vx_ten] [nvarchar](250) NOT NULL,
	[vx_nsx] [nvarchar](250) NOT NULL,
	[vx_location] [nvarchar](250) NOT NULL,
	[vx_lo] [nvarchar](250) NOT NULL,
	[vx_ngayNhap] [datetime] NULL,
	[vx_hsd] [datetime] NULL,
	[vx_slNhap] [int] NOT NULL,
	[vx__slXuat] [int] NULL,
	[tgTiem] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[vx_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[vx_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[PrintData]    Script Date: 8/11/2021 4:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[PrintData]
 @id NVARCHAR(250) ,
 @type bit
 AS 
BEGIN
BEGIN TRY
DECLARE @tableTempMaster TABLE(
	id nvarchar(250) ,
	ma_dt NVARCHAR(250),
	ten_dt NVARCHAR(250),
	nam_sinh NVARCHAR(250),
	gioi_tinh NVARCHAR(250),
	dia_chi NVARCHAR(max),
	don_vi NVARCHAR(max),
	cmnd NVARCHAR(250),
	dien_thoai NVARCHAR(250),
	vx_ma NVARCHAR(250),
	vx_ten NVARCHAR(250),
	vx_lo NVARCHAR(250),
	TimeTiem1 NVARCHAR(250),
	DMBsy_Ten NVARCHAR(250),
	ngay_thang DATETIME
)
IF(@type = 0) 
	BEGIN 
		INSERT INTO @tableTempMaster   SELECT TrangChu_id, DTuong_ma, DTuong_ten, DTuong_nsinh,DTuong_GTinh, DTuong_DCCtiet, 
										DTuong_DVCtac, DTuong_CCCD, DTuong_SDT,vx_ma,vx_ten, vx_lo ,TimeTiem1  ,DMBsy_Ten , 

										CONVERT (DATETIME, TimeTiem1, 103)
								FROM dbo.TrangChu 
								WHERE TrangChu_id = @id
	END
ELSE 
	BEGIN 
		INSERT INTO @tableTempMaster   SELECT TrangChu_id, DTuong_ma, DTuong_ten, DTuong_nsinh,DTuong_GTinh, DTuong_DCCtiet, 
										DTuong_DVCtac, DTuong_CCCD, DTuong_SDT,vx_ma2,vx_ten2, vx_lo2 ,TimeTiem2  ,DMBsy_Ten2,
										CONVERT (DATETIME, TimeTiem1, 103)
								FROM dbo.TrangChu 
								WHERE TrangChu_id = @id
	END
SELECT * FROM @tableTempMaster 
END Try
BEGIN CATCH  
    DECLARE @ErrorMessage NVARCHAR(4000);  
    DECLARE @ErrorSeverity INT;  
    DECLARE @ErrorState INT;  

    SELECT   
        @ErrorMessage = ERROR_MESSAGE(),  
        @ErrorSeverity = ERROR_SEVERITY(),  
        @ErrorState = ERROR_STATE();  

    RAISERROR (@ErrorMessage, -- Message text.  
               @ErrorSeverity, -- Severity.  
               @ErrorState -- State.  
               );  
END CATCH;
END

GO
USE [master]
GO
ALTER DATABASE [GTVT] SET  READ_WRITE 
GO
