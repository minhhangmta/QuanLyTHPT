USE [master]
GO
/****** Object:  Database [QuanLyTHPT]    Script Date: 16/05/2017 8:30:09 AM ******/
CREATE DATABASE [QuanLyTHPT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyTHPT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyTHPT.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyTHPT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyTHPT_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [QuanLyTHPT] SET AUTO_CLOSE OFF 
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
ALTER DATABASE [QuanLyTHPT] SET  DISABLE_BROKER 
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
/****** Object:  UserDefinedFunction [dbo].[func_ma_next]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  Table [dbo].[BangDiem]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BangDiem](
	[maHS] [varchar](10) NOT NULL,
	[maMH] [varchar](10) NOT NULL,
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
/****** Object:  Table [dbo].[ChucVu]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucVu](
	[maCV] [varchar](10) NOT NULL,
	[chucVu] [nvarchar](20) NULL,
	[ngayNhamChuc] [date] NULL,
	[ngayKetThuc] [date] NULL,
	[nhiemKi] [int] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[maCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[maGV] [varchar](10) NOT NULL,
	[hoTenGV] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[diaChi] [nvarchar](100) NULL,
	[email] [varchar](50) NULL,
	[sdt] [varchar](15) NULL,
	[trinhDo] [nvarchar](50) NULL,
	[loaiGV] [nvarchar](20) NULL,
	[xepLoai] [nvarchar](15) NULL,
	[trangThai] [int] NULL,
	[maMH] [varchar](10) NULL,
	[maCV] [varchar](10) NULL,
	[maLuong] [varchar](10) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[maGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocSinh](
	[maHS] [varchar](10) NOT NULL,
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
	[maLop] [varchar](10) NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[maHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoiLop]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhoiLop](
	[maKhoi] [varchar](10) NOT NULL,
	[tenKhoi] [varchar](10) NULL,
	[xepLoai] [nvarchar](20) NULL,
 CONSTRAINT [PK_KhoiLop] PRIMARY KEY CLUSTERED 
(
	[maKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[maLop] [varchar](10) NOT NULL,
	[tenLop] [varchar](10) NULL,
	[siSo] [int] NULL,
	[xepLoai] [nvarchar](15) NULL,
	[maKhoi] [varchar](10) NULL,
	[maBan] [varchar](10) NULL,
	[maGVCN] [varchar](10) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[maLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Luong](
	[maLuong] [varchar](10) NOT NULL,
	[luongCB] [decimal](9, 0) NULL,
	[heSoLuong] [int] NULL,
	[thuong] [decimal](9, 0) NULL,
	[tongLuong] [decimal](9, 0) NULL,
 CONSTRAINT [PK_Luong] PRIMARY KEY CLUSTERED 
(
	[maLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[maMH] [varchar](10) NOT NULL,
	[tenMH] [nvarchar](25) NULL,
	[soTiet] [int] NULL,
	[heSo] [int] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[maMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhanBan]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhanBan](
	[maBan] [varchar](10) NOT NULL,
	[tenBan] [nvarchar](20) NULL,
 CONSTRAINT [PK_PhanBan] PRIMARY KEY CLUSTERED 
(
	[maBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[maUser] [varchar](15) NOT NULL,
	[tenDangNhap] [varchar](15) NULL,
	[matKhau] [varchar](15) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[maUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
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
/****** Object:  StoredProcedure [dbo].[tb_BangDiem_GetList]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_BangDiem_Insert]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_ChucVu_Delete]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_ChucVu_GetList]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_ChucVu_Insert]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_ChucVu_Update]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_GiaoVien_Delete]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_GiaoVien_getIDnext]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_GiaoVien_GetList]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_GiaoVien_Insert]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_GiaoVien_Insert] (@maGV varchar(10), @hoTenGV nvarchar(50), @ngaySinh date, @gioiTinh  nvarchar(10), 
@diaChi  nvarchar(100), @email  varchar(50), @sdt  varchar(15), @trinhDo nvarchar(50), @loaiGV  nvarchar(20), @xepLoai  nvarchar(15), 
@trangThai   int, @maMH   varchar(10), @maCV   varchar(10), @maLuong varchar(10))
as
begin
	Insert into GiaoVien(hoTenGV, ngaySinh, gioiTinh, diaChi, email, sdt, trinhDo, loaiGV, xepLoai, trangThai, maMH, maCV, maLuong)
	values (@hoTenGV, @ngaySinh, @gioiTinh, @diaChi, @email, @sdt, @trinhDo, @loaiGV, @xepLoai, @trangThai, @maMH, @maCV, @maLuong)
end
GO
/****** Object:  StoredProcedure [dbo].[tb_GiaoVien_Update]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[tb_GiaoVien_Update] (@maGV varchar(10), @hoTenGV nvarchar(50), @ngaySinh date, @gioiTinh  nvarchar(10), 
@diaChi  nvarchar(100), @email  varchar(50), @sdt  varchar(15), @trinhDo nvarchar(50), @loaiGV  nvarchar(20), @xepLoai  nvarchar(15), 
@trangThai   int, @maMH   varchar(10), @maCV   varchar(10), @maLuong varchar(10))
as
begin
	Update GiaoVien
	set
		hoTenGV=@hoTenGV, ngaySinh=@ngaySinh, gioiTinh=@gioiTinh, diaChi=@diaChi, email=@email, sdt=@sdt,
		trinhDo=@trinhDo, loaiGV=@loaiGV, xepLoai=@xepLoai, trangThai=@trangThai, maMH=@maMH, maCV=@maCV, maLuong=@maLuong
	where maGV=@maGV
end

GO
/****** Object:  StoredProcedure [dbo].[tb_HocSinh_Delete]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_HocSinh_getIDnext]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_HocSinh_GetList]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_HocSinh_Insert]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_HocSinh_Insert] (@maHS varchar(10), @hoTenHS  nvarchar(50), 
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
/****** Object:  StoredProcedure [dbo].[tb_HocSinh_Update]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_KhoiLop_Delete]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_KhoiLop_GetList]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_KhoiLop_Insert]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[tb_KhoiLop_Insert] (@maKhoi varchar(10), @tenKhoi    varchar(10), @xepLoai    nvarchar(20) )
as
begin
	Insert into KhoiLop( tenKhoi, xepLoai)
	values ( @tenKhoi, @xepLoai)
end
GO
/****** Object:  StoredProcedure [dbo].[tb_KhoiLop_Update]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_KhoiLop_Update] (@maKhoi varchar(10), @tenKhoi    varchar(10), @xepLoai    nvarchar(20) )
as
begin
	Update KhoiLop
	set tenKhoi=@tenKhoi, xepLoai=@xepLoai
	where maKhoi=@maKhoi
end
GO
/****** Object:  StoredProcedure [dbo].[tb_Lop_Delete]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_Lop_getIDnext]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_Lop_Insert]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_Lop_Update]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_Luong_Delete]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_Luong_GetList]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_Luong_Insert]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_Luong_Update]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_MonHoc_Delete]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_MonHoc_GetList]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_MonHoc_Insert]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[tb_MonHoc_Insert] (@maMH varchar(10), @tenMH  nvarchar(25), @soTiet    int, @heSo     int)
as
begin
	Insert into MonHoc(maMH, tenMH, soTiet, heSo)
	values (@maMH, @tenMH, @soTiet, @heSo)
end
GO
/****** Object:  StoredProcedure [dbo].[tb_MonHoc_Update]    Script Date: 16/05/2017 8:30:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tb_MonHoc_Update]  (@maMH varchar(10), @tenMH  nvarchar(25), @soTiet    int, @heSo     int)
as
begin
	Update MonHoc
	set tenMH=@tenMH, soTiet=@soTiet, heSo=@heSo
	where maMH=@maMH
end

GO
/****** Object:  StoredProcedure [dbo].[tb_PhanBan_Delete]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_PhanBan_GetList]    Script Date: 16/05/2017 8:30:10 AM ******/
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
/****** Object:  StoredProcedure [dbo].[tb_PhanBan_Update]    Script Date: 16/05/2017 8:30:10 AM ******/
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
USE [master]
GO
ALTER DATABASE [QuanLyTHPT] SET  READ_WRITE 
GO
