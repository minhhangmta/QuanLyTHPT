USE [master]
GO
/****** Object:  Database [QuanLyTHPT]    Script Date: 30/05/2017 8:42:12 AM ******/
CREATE DATABASE [QuanLyTHPT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyTHPT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyTHPT.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyTHPT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyTHPT_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyTHPT] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyTHPT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyTHPT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyTHPT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTHPT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyTHPT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyTHPT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyTHPT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyTHPT] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyTHPT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyTHPT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyTHPT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyTHPT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyTHPT] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyTHPT]
GO
/****** Object:  UserDefinedFunction [dbo].[func_ma_next]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_ma_next](@last_ma varchar(10),@char1 varchar(3),@size int) returns varchar(10)
		as
		begin
			if(@last_ma='')
				set @last_ma=@char1+REPLICATE(0,@size-LEN(@char1))
			declare @num_next_ma int,@next_ma varchar(10)
			set @last_ma=LTRIM(RTRIM(@last_ma))
			set @num_next_ma=REPLACE(@last_ma,@char1,'')+1
			set @size=@size-len(@char1)
			set @next_ma=@char1 + REPLICATE(0,@size-LEN(@char1))
			set @next_ma=@char1+RIGHT(REPLICATE(0,@size)+CONVERT(varchar(MAX),@num_next_ma),@size)
			return @next_ma
		end


GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BangDiem](
	[maHS] [int] NOT NULL,
	[maMH] [int] NOT NULL,
	[namHoc] [varchar](10) NULL,
	[tbHocKy1] [decimal](3, 2) NULL,
	[tbHocKy2] [decimal](3, 2) NULL,
	[tbNamHoc] [decimal](3, 2) NULL,
 CONSTRAINT [PK_BangDiem] PRIMARY KEY CLUSTERED 
(
	[maHS] ASC,
	[maMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[maCV] [int] IDENTITY(1,1) NOT NULL,
	[tenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[maCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[maGV] [int] IDENTITY(1,1) NOT NULL,
	[hoTenGV] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[diaChi] [nvarchar](100) NULL,
	[email] [varchar](50) NULL,
	[sdt] [varchar](15) NULL,
	[trinhDo] [nvarchar](50) NULL,
	[trangThai] [int] NULL,
	[maMH] [int] NULL,
	[maCV] [int] NULL,
	[maLuong] [int] NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[maGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HanhKiem]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HanhKiem](
	[maHS] [int] NOT NULL,
	[namHoc] [varchar](10) NOT NULL,
	[hocKy1] [nvarchar](50) NOT NULL,
	[hocKy2] [nvarchar](50) NOT NULL,
	[caNam] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HanhKiem] PRIMARY KEY CLUSTERED 
(
	[maHS] ASC,
	[namHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[maHS] [int] IDENTITY(1,1) NOT NULL,
	[hoTenHS] [nvarchar](50) NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[ngaySinh] [date] NULL,
	[dcThuongTru] [nvarchar](100) NULL,
	[dcTamTru] [nvarchar](100) NULL,
	[danToc] [nvarchar](20) NULL,
	[tonGiao] [nvarchar](20) NULL,
	[hoTenCha] [nvarchar](50) NULL,
	[ngheNghiepCha] [nvarchar](20) NULL,
	[hoTenMe] [nvarchar](50) NULL,
	[ngheNghiepMe] [nvarchar](20) NULL,
	[chucVu] [nvarchar](20) NULL,
	[trangThai] [int] NULL,
	[maLop] [int] NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[maHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoiLop]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhoiLop](
	[maKhoi] [int] IDENTITY(1,1) NOT NULL,
	[tenKhoi] [varchar](10) NULL,
	[soHS] [int] NULL,
	[soLopGioi] [int] NULL,
	[soLopKha] [int] NULL,
	[soLopTB] [int] NULL,
 CONSTRAINT [PK_KhoiLop] PRIMARY KEY CLUSTERED 
(
	[maKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[maLop] [int] IDENTITY(1,1) NOT NULL,
	[tenLop] [varchar](10) NULL,
	[siSo] [int] NULL,
	[maKhoi] [int] NULL,
	[maBan] [int] NULL,
	[maGVCN] [int] NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[maLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[maLuong] [int] IDENTITY(1,1) NOT NULL,
	[luongCB] [decimal](9, 0) NULL,
	[heSoLuong] [decimal](3, 2) NULL,
	[thuong] [decimal](9, 0) NULL,
	[tongLuong] [decimal](9, 0) NULL,
 CONSTRAINT [PK_Luong] PRIMARY KEY CLUSTERED 
(
	[maLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[maMH] [int] IDENTITY(1,1) NOT NULL,
	[tenMH] [nvarchar](25) NULL,
	[soTiet] [int] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[maMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanBan]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanBan](
	[maBan] [int] IDENTITY(1,1) NOT NULL,
	[tenBan] [nvarchar](20) NULL,
 CONSTRAINT [PK_PhanBan] PRIMARY KEY CLUSTERED 
(
	[maBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[maUser] [int] IDENTITY(1,1) NOT NULL,
	[tenDangNhap] [varchar](50) NULL,
	[matKhau] [varchar](15) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[maUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (1, 1, N'2017', CAST(9.20 AS Decimal(3, 2)), CAST(9.00 AS Decimal(3, 2)), CAST(9.10 AS Decimal(3, 2)))
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (1, 2, N'2017', CAST(8.00 AS Decimal(3, 2)), CAST(8.00 AS Decimal(3, 2)), CAST(8.00 AS Decimal(3, 2)))
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (1, 3, N'2017', CAST(7.00 AS Decimal(3, 2)), CAST(7.00 AS Decimal(3, 2)), CAST(7.00 AS Decimal(3, 2)))
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (1, 4, N'2017', CAST(6.00 AS Decimal(3, 2)), CAST(6.00 AS Decimal(3, 2)), CAST(6.00 AS Decimal(3, 2)))
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (2, 1, N'2017', CAST(8.00 AS Decimal(3, 2)), CAST(8.00 AS Decimal(3, 2)), CAST(8.00 AS Decimal(3, 2)))
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (2, 2, N'2017', CAST(7.00 AS Decimal(3, 2)), CAST(7.00 AS Decimal(3, 2)), CAST(7.00 AS Decimal(3, 2)))
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (2, 3, N'2017', CAST(9.00 AS Decimal(3, 2)), CAST(9.00 AS Decimal(3, 2)), CAST(9.00 AS Decimal(3, 2)))
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (11, 1, N'2017', CAST(4.00 AS Decimal(3, 2)), CAST(4.00 AS Decimal(3, 2)), CAST(4.00 AS Decimal(3, 2)))
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (11, 2, N'2017', CAST(4.00 AS Decimal(3, 2)), CAST(4.00 AS Decimal(3, 2)), CAST(4.00 AS Decimal(3, 2)))
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (11, 3, N'2017', CAST(2.00 AS Decimal(3, 2)), CAST(2.00 AS Decimal(3, 2)), CAST(2.00 AS Decimal(3, 2)))
INSERT [dbo].[BangDiem] ([maHS], [maMH], [namHoc], [tbHocKy1], [tbHocKy2], [tbNamHoc]) VALUES (13, 4, N'2017', CAST(5.00 AS Decimal(3, 2)), CAST(5.00 AS Decimal(3, 2)), CAST(5.00 AS Decimal(3, 2)))
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (1, N'Hiệu trưởng')
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (2, N'Hiệu phó ')
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (3, N'Chủ tịch công đoàn')
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (4, N'Bí thư đoàn trường')
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (5, N'Tổ trưởng bộ môn Toán')
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (6, N'Tổ trưởng bộ môn Hóa')
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (7, N'Tổ trưởng bộ môn Sinh')
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (8, N'Tổ trưởng bộ môn Lý')
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (9, N'Tổ trưởng bộ môn Tiếng Anh')
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (10, N'Giáo viên')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
SET IDENTITY_INSERT [dbo].[GiaoVien] ON 

INSERT [dbo].[GiaoVien] ([maGV], [hoTenGV], [ngaySinh], [gioiTinh], [diaChi], [email], [sdt], [trinhDo], [trangThai], [maMH], [maCV], [maLuong]) VALUES (1, N'Võ Đình Thuần', CAST(N'1980-01-01' AS Date), N'Nam', N'dlskdjf', N'kfskd', N'01132156421', N'Đại học', 1, 1, 1, 1)
INSERT [dbo].[GiaoVien] ([maGV], [hoTenGV], [ngaySinh], [gioiTinh], [diaChi], [email], [sdt], [trinhDo], [trangThai], [maMH], [maCV], [maLuong]) VALUES (3, N'kdf', CAST(N'1990-01-01' AS Date), N'Nam', N'sdjai', N'kdjs', N'01322140211', N'Đại học', 1, 2, 2, 1)
INSERT [dbo].[GiaoVien] ([maGV], [hoTenGV], [ngaySinh], [gioiTinh], [diaChi], [email], [sdt], [trinhDo], [trangThai], [maMH], [maCV], [maLuong]) VALUES (4, N'hhh', CAST(N'1980-01-01' AS Date), N'Nam', N'k', N'd', N'0123541201', N'Đại học', 1, 1, 10, 1)
INSERT [dbo].[GiaoVien] ([maGV], [hoTenGV], [ngaySinh], [gioiTinh], [diaChi], [email], [sdt], [trinhDo], [trangThai], [maMH], [maCV], [maLuong]) VALUES (5, N'Võ Ngọc Bửu Chánh', CAST(N'1987-01-17' AS Date), N'Nam', N'Hà Nội', N'anh@gmail.com', N'0165321102', N'Đại Học', 1, 4, 10, 1)
SET IDENTITY_INSERT [dbo].[GiaoVien] OFF
INSERT [dbo].[HanhKiem] ([maHS], [namHoc], [hocKy1], [hocKy2], [caNam]) VALUES (1, N'2017', N'Tốt', N'Tốt', N'Tốt')
INSERT [dbo].[HanhKiem] ([maHS], [namHoc], [hocKy1], [hocKy2], [caNam]) VALUES (2, N'2017', N'Khá', N'Khá', N'Khá')
INSERT [dbo].[HanhKiem] ([maHS], [namHoc], [hocKy1], [hocKy2], [caNam]) VALUES (11, N'2017', N'Trung bình', N'Trung bình', N'Trung bình')
INSERT [dbo].[HanhKiem] ([maHS], [namHoc], [hocKy1], [hocKy2], [caNam]) VALUES (13, N'2017', N'Yếu', N'Yếu', N'Yếu')
SET IDENTITY_INSERT [dbo].[HocSinh] ON 

INSERT [dbo].[HocSinh] ([maHS], [hoTenHS], [gioiTinh], [ngaySinh], [dcThuongTru], [dcTamTru], [danToc], [tonGiao], [hoTenCha], [ngheNghiepCha], [hoTenMe], [ngheNghiepMe], [chucVu], [trangThai], [maLop]) VALUES (1, N'Nguyễn Thị Minh Hằng', N'Nữ', CAST(N'1996-01-01' AS Date), N'aa', N'g', N'Kinh', N'Không', N'c', N'e', N'd', N'f', N'Lớp trưởng', 1, 1)
INSERT [dbo].[HocSinh] ([maHS], [hoTenHS], [gioiTinh], [ngaySinh], [dcThuongTru], [dcTamTru], [danToc], [tonGiao], [hoTenCha], [ngheNghiepCha], [hoTenMe], [ngheNghiepMe], [chucVu], [trangThai], [maLop]) VALUES (2, N'Trần Huyền Trang', N'Nữ', CAST(N'1995-01-01' AS Date), N'Ha', N'Noi', N'Kinh', N'Không', N'A', N'ca', N'V', N'a', N'Không có', 1, 1)
INSERT [dbo].[HocSinh] ([maHS], [hoTenHS], [gioiTinh], [ngaySinh], [dcThuongTru], [dcTamTru], [danToc], [tonGiao], [hoTenCha], [ngheNghiepCha], [hoTenMe], [ngheNghiepMe], [chucVu], [trangThai], [maLop]) VALUES (11, N'Tùng', N'Nam', CAST(N'1996-01-01' AS Date), N's', N'f', N'Kinh', N'Không', N'f', N'hhh', N'oo', N'jjjj', N'Không có', 1, 1)
INSERT [dbo].[HocSinh] ([maHS], [hoTenHS], [gioiTinh], [ngaySinh], [dcThuongTru], [dcTamTru], [danToc], [tonGiao], [hoTenCha], [ngheNghiepCha], [hoTenMe], [ngheNghiepMe], [chucVu], [trangThai], [maLop]) VALUES (13, N'Nam', N'Nam', CAST(N'1996-01-19' AS Date), N'a', N'b', N'Kinh', N'Không', N'yyyy', N'e', N'ddd', N'f', N'Không có', 1, 1)
INSERT [dbo].[HocSinh] ([maHS], [hoTenHS], [gioiTinh], [ngaySinh], [dcThuongTru], [dcTamTru], [danToc], [tonGiao], [hoTenCha], [ngheNghiepCha], [hoTenMe], [ngheNghiepMe], [chucVu], [trangThai], [maLop]) VALUES (14, N'Nguyễn Thiện Nhân', N'Nam', CAST(N'1996-01-01' AS Date), N'ss', N'sss', N'Kinh', N'Không có', N'sd', N'd', N'd', N'd', N'Không có', 1, 1)
SET IDENTITY_INSERT [dbo].[HocSinh] OFF
SET IDENTITY_INSERT [dbo].[KhoiLop] ON 

INSERT [dbo].[KhoiLop] ([maKhoi], [tenKhoi], [soHS], [soLopGioi], [soLopKha], [soLopTB]) VALUES (1, N'10', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhoiLop] ([maKhoi], [tenKhoi], [soHS], [soLopGioi], [soLopKha], [soLopTB]) VALUES (2, N'11', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhoiLop] ([maKhoi], [tenKhoi], [soHS], [soLopGioi], [soLopKha], [soLopTB]) VALUES (3, N'12', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[KhoiLop] OFF
SET IDENTITY_INSERT [dbo].[Lop] ON 

INSERT [dbo].[Lop] ([maLop], [tenLop], [siSo], [maKhoi], [maBan], [maGVCN]) VALUES (1, N'10A', 49, 1, 1, 1)
INSERT [dbo].[Lop] ([maLop], [tenLop], [siSo], [maKhoi], [maBan], [maGVCN]) VALUES (2, N'10B', 54, 1, 2, NULL)
INSERT [dbo].[Lop] ([maLop], [tenLop], [siSo], [maKhoi], [maBan], [maGVCN]) VALUES (4, N'10C', 51, 1, 3, NULL)
INSERT [dbo].[Lop] ([maLop], [tenLop], [siSo], [maKhoi], [maBan], [maGVCN]) VALUES (5, N'10D', 52, 1, 4, 3)
SET IDENTITY_INSERT [dbo].[Lop] OFF
SET IDENTITY_INSERT [dbo].[Luong] ON 

INSERT [dbo].[Luong] ([maLuong], [luongCB], [heSoLuong], [thuong], [tongLuong]) VALUES (1, CAST(5000000 AS Decimal(9, 0)), CAST(0.64 AS Decimal(3, 2)), CAST(500000 AS Decimal(9, 0)), CAST(8000000 AS Decimal(9, 0)))
SET IDENTITY_INSERT [dbo].[Luong] OFF
SET IDENTITY_INSERT [dbo].[MonHoc] ON 

INSERT [dbo].[MonHoc] ([maMH], [tenMH], [soTiet]) VALUES (1, N'Toán học', 180)
INSERT [dbo].[MonHoc] ([maMH], [tenMH], [soTiet]) VALUES (2, N'Ngữ văn', 180)
INSERT [dbo].[MonHoc] ([maMH], [tenMH], [soTiet]) VALUES (3, N'Tiếng Anh', 160)
INSERT [dbo].[MonHoc] ([maMH], [tenMH], [soTiet]) VALUES (4, N'Hóa học', 170)
INSERT [dbo].[MonHoc] ([maMH], [tenMH], [soTiet]) VALUES (5, N'Vật lý', 180)
INSERT [dbo].[MonHoc] ([maMH], [tenMH], [soTiet]) VALUES (6, N'Lịch sử', 180)
INSERT [dbo].[MonHoc] ([maMH], [tenMH], [soTiet]) VALUES (7, N'Địa lý', 170)
INSERT [dbo].[MonHoc] ([maMH], [tenMH], [soTiet]) VALUES (8, N'Sinh học', 160)
SET IDENTITY_INSERT [dbo].[MonHoc] OFF
SET IDENTITY_INSERT [dbo].[PhanBan] ON 

INSERT [dbo].[PhanBan] ([maBan], [tenBan]) VALUES (1, N'A')
INSERT [dbo].[PhanBan] ([maBan], [tenBan]) VALUES (2, N'B')
INSERT [dbo].[PhanBan] ([maBan], [tenBan]) VALUES (3, N'C')
INSERT [dbo].[PhanBan] ([maBan], [tenBan]) VALUES (4, N'D1')
INSERT [dbo].[PhanBan] ([maBan], [tenBan]) VALUES (5, N'A1')
INSERT [dbo].[PhanBan] ([maBan], [tenBan]) VALUES (6, N'H')
INSERT [dbo].[PhanBan] ([maBan], [tenBan]) VALUES (7, N'D2')
INSERT [dbo].[PhanBan] ([maBan], [tenBan]) VALUES (8, N'D3')
INSERT [dbo].[PhanBan] ([maBan], [tenBan]) VALUES (9, N'D4')
SET IDENTITY_INSERT [dbo].[PhanBan] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([maUser], [tenDangNhap], [matKhau]) VALUES (1, N'admin', N'123456')
INSERT [dbo].[User] ([maUser], [tenDangNhap], [matKhau]) VALUES (2, N'hang', N'123456')
INSERT [dbo].[User] ([maUser], [tenDangNhap], [matKhau]) VALUES (3, N'a', N'123456')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_HocSinh] FOREIGN KEY([maHS])
REFERENCES [dbo].[HocSinh] ([maHS])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_HocSinh]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_MonHoc] FOREIGN KEY([maMH])
REFERENCES [dbo].[MonHoc] ([maMH])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_MonHoc]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_ChucVu] FOREIGN KEY([maCV])
REFERENCES [dbo].[ChucVu] ([maCV])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_ChucVu]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_Luong] FOREIGN KEY([maLuong])
REFERENCES [dbo].[Luong] ([maLuong])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_Luong]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_MonHoc] FOREIGN KEY([maMH])
REFERENCES [dbo].[MonHoc] ([maMH])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_MonHoc]
GO
ALTER TABLE [dbo].[HanhKiem]  WITH CHECK ADD  CONSTRAINT [FK_HanhKiem_HocSinh] FOREIGN KEY([maHS])
REFERENCES [dbo].[HocSinh] ([maHS])
GO
ALTER TABLE [dbo].[HanhKiem] CHECK CONSTRAINT [FK_HanhKiem_HocSinh]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop] FOREIGN KEY([maLop])
REFERENCES [dbo].[Lop] ([maLop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_GiaoVien] FOREIGN KEY([maGVCN])
REFERENCES [dbo].[GiaoVien] ([maGV])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_GiaoVien]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_KhoiLop] FOREIGN KEY([maKhoi])
REFERENCES [dbo].[KhoiLop] ([maKhoi])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_KhoiLop]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_PhanBan] FOREIGN KEY([maBan])
REFERENCES [dbo].[PhanBan] ([maBan])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_PhanBan]
GO
/****** Object:  StoredProcedure [dbo].[tb_BangDiem_GetList]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_BangDiem_GetList]
as
begin
	select *from BangDiem
end


GO
/****** Object:  StoredProcedure [dbo].[tb_BangDiem_Insert]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_BangDiem_Insert] (@maHS varchar(10), @maMH varchar(10), @namHoc     varchar(10)
, @tbHocKy1   decimal(3,2), @tbHocKy2   decimal(3,2), @tbNamHoc decimal(3,2))
as
begin
	Insert into BangDiem (maHS, maMH, namHoc, tbHocKy1, tbHocKy2, tbNamHoc)
	values (@maHS, @maMH, @namHoc, @tbHocKy1, @tbHocKy2, @tbNamHoc)
end


GO
/****** Object:  StoredProcedure [dbo].[tb_ChucVu_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_ChucVu_Delete](@maCV varchar(10))
as 
begin
	Delete from ChucVu
	where maCV=@maCV
end



GO
/****** Object:  StoredProcedure [dbo].[tb_ChucVu_GetList]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_ChucVu_GetList]
as
begin
	select *from ChucVu
end


GO
/****** Object:  StoredProcedure [dbo].[tb_ChucVu_Insert]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_ChucVu_Insert](@maCV varchar (10), @chucVu   nvarchar(20), @ngayNhamChuc  date,
 @ngayKetThuc  date, @nhiemKi     int)
as
begin
	Insert into ChucVu(maCV, chucVu, ngayNhamChuc, ngayKetThuc, nhiemKi)
	values (@maCV, @chucVu, @ngayNhamChuc, @ngayKetThuc, @nhiemKi)
end


GO
/****** Object:  StoredProcedure [dbo].[tb_ChucVu_Update]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[tb_ChucVu_Update] (@maCV varchar (10), @chucVu   nvarchar(20), @ngayNhamChuc  date,
 @ngayKetThuc  date, @nhiemKi     int)
 as
 begin
	Update ChucVu
	set chucVu=@chucVu, ngayNhamChuc=@ngayNhamChuc, ngayKetThuc=@ngayKetThuc, nhiemKi=@nhiemKi
	where maCV=@maCV
 end


GO
/****** Object:  StoredProcedure [dbo].[tb_GiaoVien_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_GiaoVien_Delete](@maGV varchar(10))
as
begin
	delete from GiaoVien 
	where maGV=@maGV
end



GO
/****** Object:  StoredProcedure [dbo].[tb_GiaoVien_getIDnext]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_GiaoVien_getIDnext]
as
begin
	select dbo.func_ma_next((select top 1 maGV from GiaoVien order by maGV desc),'GV',6) as maGV
end


GO
/****** Object:  StoredProcedure [dbo].[tb_GiaoVien_GetList]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_GiaoVien_GetList]
as
begin
	select *from GiaoVien
end



GO
/****** Object:  StoredProcedure [dbo].[tb_HocSinh_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_HocSinh_Delete](@maHS varchar(10))
as
begin
	delete from HocSinh 
	where maHS=@maHS
end


GO
/****** Object:  StoredProcedure [dbo].[tb_HocSinh_getIDnext]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_HocSinh_getIDnext]
as
begin
	select dbo.func_ma_next((select top 1 maHS from HocSinh order by maHS desc),'HS',6) as maHS
end


GO
/****** Object:  StoredProcedure [dbo].[tb_HocSinh_GetList]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_HocSinh_GetList]
as
begin
	select *from HocSinh
end


GO
/****** Object:  StoredProcedure [dbo].[tb_HocSinh_Insert]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[tb_HocSinh_Insert] (@hoTenHS  nvarchar(50), 
@gioiTinh nvarchar(10), @ngaySinh  date, @dcThuongTru  nvarchar(100), @dcTamTru  nvarchar(100), 
@danToc nvarchar(20), @tonGiao  nvarchar(20), @hoTenCha nvarchar(50), @ngheNghiepCha nvarchar(20),
 @hoTenMe nvarchar(50), @ngheNghiepMe  nvarchar(20), @chucVu varchar(20), @trangThai  int, @maLop  varchar(10))
as
begin
	Insert into HocSinh(hoTenHS, gioiTinh, ngaySinh, dcThuongTru, dcTamTru, danToc, tonGiao, hoTenCha, ngheNghiepCha, hoTenMe, ngheNghiepMe,
	chucVu, trangThai, maLop)
	values (@hoTenHS, @gioiTinh, @ngaySinh, @dcThuongTru, @dcTamTru, @danToc, @tonGiao, @hoTenCha, @ngheNghiepCha, @hoTenMe,
	@ngheNghiepMe, @chucVu, @trangThai, @maLop)
end



GO
/****** Object:  StoredProcedure [dbo].[tb_HocSinh_Update]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_HocSinh_Update] (@maHS varchar(10), @hoTenHS  nvarchar(50), 
@gioiTinh nvarchar(10), @ngaySinh  date, @dcThuongTru  nvarchar(100), @dcTamTru  nvarchar(100), 
@danToc nvarchar(20), @tonGiao  nvarchar(20), @hoTenCha nvarchar(50), @ngheNghiepCha nvarchar(20),
 @hoTenMe nvarchar(50), @ngheNghiepMe  nvarchar(20), @chucVu varchar(20), @trangThai  int, @maLop  varchar(10))
as
begin
	Update HocSinh
	set hoTenHS=@hoTenHS, gioiTinh=@gioiTinh, ngaySinh=@ngaySinh, dcThuongTru=@dcThuongTru, dcTamTru=@dcTamTru,
	danToc=@danToc, tonGiao=@tonGiao, hoTenCha=@hoTenCha, ngheNghiepCha=@ngheNghiepCha, hoTenMe=@hoTenMe, ngheNghiepMe=@ngheNghiepMe,
	chucVu=@chucVu, trangThai=@trangThai, maLop=@maLop
	where maHS =@maHS
end



GO
/****** Object:  StoredProcedure [dbo].[tb_KhoiLop_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_KhoiLop_Delete] (@maKhoi varchar(10))
as
begin
	Delete from KhoiLop
	where maKhoi=@maKhoi
end


GO
/****** Object:  StoredProcedure [dbo].[tb_KhoiLop_GetList]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_KhoiLop_GetList]
as
begin
	Select *from KhoiLop
end


GO
/****** Object:  StoredProcedure [dbo].[tb_Lop_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_Lop_Delete] (@maLop varchar(10))
as
begin
	delete from Lop
	where maLop=@maLop
end


GO
/****** Object:  StoredProcedure [dbo].[tb_Lop_getIDnext]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_Lop_getIDnext]
as
begin
	select dbo.func_ma_next((select top 1 maLop from Lop order by maLop desc),'LH',6) as maLop
end



GO
/****** Object:  StoredProcedure [dbo].[tb_Lop_Insert]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_Lop_Insert] (@maLop varchar(10), @tenLop  varchar(10), @siSo   int, @xepLoai nvarchar(15),
 @maKhoi  varchar(10), @maBan  varchar(10), @maGVCN varchar(10))
as
begin
	Insert into Lop(maLop, tenLop, siSo, xepLoai, maKhoi, maBan, maGVCN)
	values (@maLop, @tenLop, @siSo, @xepLoai, @maKhoi, @maBan, @maGVCN)
end


GO
/****** Object:  StoredProcedure [dbo].[tb_Lop_Update]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_Lop_Update] (@maLop varchar(10), @tenLop  varchar(10), @siSo   int, @xepLoai nvarchar(15),
 @maKhoi  varchar(10), @maBan  varchar(10), @maGVCN varchar(10))
as
begin
	Update Lop
	set tenLop=@tenLop, siSo=@siSo, xepLoai=@xepLoai, maKhoi=@maKhoi, maBan=@maBan, maGVCN=@maGVCN
	where maLop=@maLop
end


GO
/****** Object:  StoredProcedure [dbo].[tb_Luong_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_Luong_Delete](@maLuong varchar(10))
as
begin
	Delete from Luong
	where maLuong=@maLuong
end


GO
/****** Object:  StoredProcedure [dbo].[tb_Luong_GetList]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_Luong_GetList]
as
begin
	select *from Luong
end


GO
/****** Object:  StoredProcedure [dbo].[tb_Luong_Insert]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_Luong_Insert](@maLuong varchar(10), @luongCB      decimal(9,0), 
@heSoLuong  int, @thuong          decimal(9,0), @tongLuong   decimal(9,0))
as
begin
	Insert into Luong(maLuong, luongCB, heSoLuong, thuong, tongLuong)
	values (@maLuong, @luongCB, @heSoLuong, @thuong, @tongLuong)
end


GO
/****** Object:  StoredProcedure [dbo].[tb_Luong_Update]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_Luong_Update](@maLuong varchar(10), @luongCB      decimal(9,0), 
@heSoLuong  int, @thuong          decimal(9,0), @tongLuong   decimal(9,0))
as
begin
	Update Luong 
	set luongCB=@luongCB, heSoLuong=@heSoLuong, thuong=@thuong, tongLuong=@tongLuong
	where maLuong=@maLuong
end


GO
/****** Object:  StoredProcedure [dbo].[tb_MonHoc_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_MonHoc_Delete] (@maMH varchar(10))
as
begin
	Delete from MonHoc
	where maMH=@maMH
end


GO
/****** Object:  StoredProcedure [dbo].[tb_MonHoc_GetList]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_MonHoc_GetList]
as
begin
	select *from MonHoc
end


GO
/****** Object:  StoredProcedure [dbo].[tb_PhanBan_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[tb_PhanBan_Delete](@maBan varchar(10))
as
begin
	Delete from PhanBan
	where maBan=@maBan
end


GO
/****** Object:  StoredProcedure [dbo].[tb_PhanBan_GetList]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_PhanBan_GetList]
as
begin
	select *from PhanBan
end


GO
/****** Object:  StoredProcedure [dbo].[tb_PhanBan_Update]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_PhanBan_Update] (@maBan varchar(10), @tenBan nvarchar(20))
as
begin
	Update PhanBan
	set tenBan=@tenBan
	where maBan=@maBan
end


GO
/****** Object:  Trigger [dbo].[tb_ChucVu_tg_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tb_ChucVu_tg_Delete] on [dbo].[ChucVu] instead of delete
as
declare @maCV varchar(10)
begin
	select @maCV=maCV from deleted

	update GiaoVien
	set maCV=Null
	where maCV=@maCV
	
	delete ChucVu
	where maCV=@maCV
end

GO
/****** Object:  Trigger [dbo].[tb_GiaoVien_tg_delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tb_GiaoVien_tg_delete] on [dbo].[GiaoVien] instead of delete
as
declare @maGVCN varchar(10)
begin
	select @maGVCN=maGV from deleted

	update Lop
	set maGVCN=Null
	where maGVCN=@maGVCN
	
	delete GiaoVien
	where maGV=@maGVCN
end



GO
/****** Object:  Trigger [dbo].[tg_Insert_HocSinh]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_Insert_HocSinh] on [dbo].[HocSinh] for Insert
as 
begin 
	Update Lop 
	set siSo = siSo +1 
end



GO
/****** Object:  Trigger [dbo].[tb_KhoiLop_tg_delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tb_KhoiLop_tg_delete] on [dbo].[KhoiLop] instead of delete
as
declare @maKhoi varchar(10)
begin
	select @maKhoi=maKhoi from deleted

	update Lop
	set maKhoi=Null
	where maKhoi=@maKhoi
	
	delete KhoiLop
	where maKhoi=@maKhoi
end



GO
/****** Object:  Trigger [dbo].[tb_Luong_tg_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tb_Luong_tg_Delete] on [dbo].[Luong] instead of delete
as
declare @maLuong varchar(10)
begin
	select @maLuong=maLuong from deleted

	update GiaoVien
	set maLuong=Null
	where maLuong=@maLuong
	
	delete Luong
	where maLuong=@maLuong
end

GO
/****** Object:  Trigger [dbo].[tb_PhanBan_tg_Delete]    Script Date: 30/05/2017 8:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tb_PhanBan_tg_Delete] on [dbo].[PhanBan] instead of Delete
as
declare @maBan varchar(10)
begin
	select @maBan = maBan from deleted

	Update Lop
	set maBan=NULL
	where maBan=@maBan

	Delete from PhanBan
	where maBan=@maBan
end



GO
USE [master]
GO
ALTER DATABASE [QuanLyTHPT] SET  READ_WRITE 
GO
