USE [master]
GO
/****** Object:  Database [KhuVuiChoi]    Script Date: 09/05/2018 04:04:21 PM ******/
CREATE DATABASE [KhuVuiChoi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KhuVuiChoi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\KhuVuiChoi.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'KhuVuiChoi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\KhuVuiChoi_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [KhuVuiChoi] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KhuVuiChoi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KhuVuiChoi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET ARITHABORT OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [KhuVuiChoi] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [KhuVuiChoi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KhuVuiChoi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KhuVuiChoi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [KhuVuiChoi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KhuVuiChoi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KhuVuiChoi] SET  MULTI_USER 
GO
ALTER DATABASE [KhuVuiChoi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KhuVuiChoi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KhuVuiChoi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KhuVuiChoi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [KhuVuiChoi]
GO
/****** Object:  StoredProcedure [dbo].[BanVe]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BanVe] 
(
@Mave nchar(10),
@MaKH nchar(10),
@Makhu nchar(10),
@SLNL INT,
@SLTE int,
@Ngayban date,
@Thanhtien int
)
AS
BEGIN
	INSERT INTO dbo.Ve
	        ( MaVe ,
	          MaKH ,
	          MaKhu ,
	          SoLuongNguoiLon ,
	          SoLuongTreEm ,
	          NgayBan ,
	          ThanhTien
	        )
	VALUES  ( @Mave , -- MaVe - nchar(10)
	          @MaKH , -- MaKH - nchar(10)
	          @Makhu , -- MaKhu - nchar(10)
	          @SLNL , -- SoLuongNguoiLon - nchar(10)
	          @SLTE , -- SoLuongTreEm - nchar(10)
	          @Ngayban , -- NgayBan - date
	          @Thanhtien -- ThanhTien - int
	        )


END
GO
/****** Object:  StoredProcedure [dbo].[BanVeKhachMoi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BanVeKhachMoi]
(
	@Makh nchar(10),
	@Tenkh nvarchar(50),
	@Tuoi INT,
	@GioiTinh NVARCHAR(10),

	@Mave nchar(10),
	@Makhu nchar(10),
	@SLNL INT,
	@SLTE int,
	@Ngayban date,
	@Thanhtien int
)
AS
BEGIN
	BEGIN
	INSERT INTO dbo.KhachHang
        ( MaKH, TenKH, TuoiKH, GioiTinhKH )
		VALUES  ( @Makh, -- MaKH - nchar(10)
          @Tenkh, -- TenKH - nvarchar(50)
          @Tuoi, -- TuoiKH - int
          @GioiTinh  -- GioiTinhKH - nvarchar(50)
          )
	END

    BEGIN
	INSERT INTO dbo.Ve
	        ( MaVe ,
	          MaKH ,
	          MaKhu ,
	          SoLuongNguoiLon ,
	          SoLuongTreEm ,
	          NgayBan ,
	          ThanhTien
	        )
	VALUES  ( @Mave , -- MaVe - nchar(10)
	          @Makh , -- MaKH - nchar(10)
	          @Makhu , -- MaKhu - nchar(10)
	          @SLNL , -- SoLuongNguoiLon - nchar(10)
	          @SLTE , -- SoLuongTreEm - nchar(10)
	          @Ngayban , -- NgayBan - date
	          @Thanhtien -- ThanhTien - int
	        )
	END

END
GO
/****** Object:  StoredProcedure [dbo].[CapNhatLuong]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CapNhatLuong]
(
	@MaNV NCHAR(10),
	@Luong INT
)
AS BEGIN
   	UPDATE dbo.NhanVien SET Luong = @Luong WHERE MaNV = @MaNV
   END
GO
/****** Object:  StoredProcedure [dbo].[createAccount]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[createAccount](@Uname NCHAR(10), @Pass NCHAR(10), @MaQuyen int)
AS
BEGIN
	INSERT INTO dbo.Login
	        ( UserName, PassWord, MaQuyen )
	VALUES  ( @Uname, -- UserName - nchar(10)
	          @Pass, -- PassWord - nchar(10)
	          @MaQuyen -- MaQuyen - int
	          )
END
GO
/****** Object:  StoredProcedure [dbo].[DemKhach]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DemKhach](@Start date, @end date)
AS
BEGIN
	DECLARE @TongKhach INT
	DECLARE @TongVe INT

	SELECT @TongKhach = (COUNT(SoLuongTreEm) + COUNT(SoLuongNguoiLon))
	FROM dbo.Ve
	WHERE NgayBan BETWEEN @Start AND @end

	SELECT @TongVe = COUNT(MaVe) FROM dbo.Ve WHERE NgayBan BETWEEN @Start AND @end

	SELECT @TongKhach AS TongKhach, @TongVe AS TongVe

END
GO
/****** Object:  StoredProcedure [dbo].[DemKhach_DemVe]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DemKhach_DemVe](@Start date, @end date)
AS
BEGIN
	DECLARE @TongKhach INT
	DECLARE @TongVe INT
	DECLARE @LanSDDV INT

	SELECT @TongKhach = sum(SoLuongTreEm + SoLuongNguoiLon)
	FROM dbo.Ve
	WHERE NgayBan BETWEEN @Start AND @end

	SELECT @LanSDDV = sum(SoLuongDV) 
	FROM dbo.ChiTietHoaDon cthd, dbo.HoaDon hd
	WHERE hd.MaHoaDon = cthd.MaHoaDon AND hd.NgayHoaDon BETWEEN @Start AND @end

	SELECT @TongVe = COUNT(MaVe) FROM dbo.Ve WHERE NgayBan BETWEEN @Start AND @end

	SELECT @TongKhach AS TongKhach, @TongVe AS TongVe, @LanSDDV AS LanDungDV

END

GO
/****** Object:  StoredProcedure [dbo].[DemKhach1]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DemKhach1](@Start date, @end DATE)
AS
BEGIN
	DECLARE @TongKhach int
	SELECT @TongKhach = sum(SoLuongTreEm + SoLuongNguoiLon)
	FROM dbo.Ve
	WHERE NgayBan BETWEEN @Start AND @end

	SELECT @TongKhach AS TongKhach
END
GO
/****** Object:  StoredProcedure [dbo].[DemLuotDV]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Đưa ra số lượt sử dụng dịch vụ 
CREATE PROC [dbo].[DemLuotDV](@Start date, @end date)
AS
BEGIN
	SELECT cthd.MaDV,dv.TenDV, SUM(cthd.SoLuongDV) AS SoLanSD
	FROM dbo.DichVu dv, dbo.HoaDon hd, dbo.ChiTietHoaDon cthd
	WHERE dv.MaDV = cthd.MaDV
	AND cthd.MaHoaDon = hd.MaHoaDon
	AND hd.NgayHoaDon BETWEEN @Start AND @end
	GROUP BY cthd.MaDV,dv.TenDV
	ORDER BY SUM(cthd.SoLuongDV) DESC
END
GO
/****** Object:  StoredProcedure [dbo].[get_ctn]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[get_ctn](@ma char(10))
as begin
select Mactn as[Mã CTN],TenHH as[Tên HH],chitietnhap.Soluong as [SL],Dongia as[Gia] ,Tien as[Tiền] from ChitietNhap,HangHoa
where HangHoa.MaHH=ChitietNhap.MaHH and MaPN=@ma
end

GO
/****** Object:  StoredProcedure [dbo].[get_HH]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[get_HH]
as begin
select MaHH as[Mã Hàng Hóa],TenHH as[Tên Hàng Hóa],ChungLoai as[Chủng Loại],DonViTinh as[Đơn vị tính],trongluong as [Trọng Lượng],
GiaBan as[Giá Bán],NoiSX as[ Nơi SX],HSD as[Hạn sử dụng] from HangHoa
end

GO
/****** Object:  StoredProcedure [dbo].[get_HH1]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[get_HH1](@ma char(15))
as begin
select MaHH as[Mã Hàng Hóa],TenHH as[Tên Hàng Hóa],ChungLoai as[Chủng Loại],DonViTinh as[Đơn vị tính],trongluong as [Trọng Lượng],
GiaBan as[Giá Bán],NoiSX as[ Nơi SX],HSD as[Hạn sử dụng] from HangHoa where MaHH=@ma
end

GO
/****** Object:  StoredProcedure [dbo].[get_HH2]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[get_HH2](@giaban1 float,@giaban2 float)
as begin
select MaHH as[Mã Hàng Hóa],TenHH as[Tên Hàng Hóa],ChungLoai as[Chủng Loại],DonViTinh as[Đơn vị tính],trongluong as [Trọng Lượng],
GiaBan as[Giá Bán],NoiSX as[ Nơi SX],HSD as[Hạn sử dụng] from HangHoa where GiaBan >@giaban1 and GiaBan<@giaban2
end

GO
/****** Object:  StoredProcedure [dbo].[get_HH3]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[get_HH3](@chungloai nvarchar(30))
as begin
select MaHH as[Mã Hàng Hóa],TenHH as[Tên Hàng Hóa],ChungLoai as[Chủng Loại],DonViTinh as[Đơn vị tính],trongluong as [Trọng Lượng],
GiaBan as[Giá Bán],NoiSX as[ Nơi SX],HSD as[Hạn sử dụng] from HangHoa where ChungLoai = @chungloai
end

GO
/****** Object:  StoredProcedure [dbo].[get_Kho]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[get_Kho]
as
begin
select MaKho as[Mã Kho], TenKho as[Tên Kho],TenNV as[Tên Thủ Kho],KhoHang.DiaChi as[Địa chỉ] from KhoHang,NhanVien
where NhanVien.MaNV=KhoHang.MaThuKho
end

GO
/****** Object:  StoredProcedure [dbo].[get_pn]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[get_pn]
as begin
select MaPN as[Mã PN],TenKho as [Tên Kho],TenNV as[Tên Thủ Kho],Ngaylap as[Ngày Lập],
VAT as [VAT (%)],Tongtien as [Tổng Tiền ] from PhieuNhap,NhanVien,KhoHang
where PhieuNhap.MaKho=KhoHang.MaKho and PhieuNhap.MaThuKho=NhanVien.MaNV
end

GO
/****** Object:  StoredProcedure [dbo].[GiaDV]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GiaDV](@madv NCHAR(10))
AS
BEGIN
	SELECT Gia
	FROM dbo.DichVu
	WHERE MaDV = @madv
END
GO
/****** Object:  StoredProcedure [dbo].[GiaVeVaoKhu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GiaVeVaoKhu](@MaKhu NCHAR(10))
AS
BEGIN
	SELECT GiaVeNguoiLon, GiaVeTreEm FROM dbo.KhuTroChoi WHERE MaKhu = @MaKhu
END

GO
/****** Object:  StoredProcedure [dbo].[KiemTraVe]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[KiemTraVe]
(
	@MaKH NCHAR(10),
	@MaKhu NCHAR(10),
	@NgayBan date
)
AS
BEGIN
	--DECLARE @temp INT

	SELECT *FROM dbo.Ve WHERE MaKH = @MaKH AND MaKhu = @MaKhu AND NgayBan = @NgayBan
END
GO
/****** Object:  StoredProcedure [dbo].[LuongNV]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LuongNV]
AS 
BEGIN
   	SELECT MaNV, TenNV, NgaySinh, QueQuan, Luong FROM dbo.NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[luu_tien_nhap]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[luu_tien_nhap](@mapn char(10),@tongtien float)
as
begin
update PhieuNhap
set Tongtien=@tongtien
where MaPN=@mapn
end

GO
/****** Object:  StoredProcedure [dbo].[SoVe_theoKhu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoVe_theoKhu](@Start date, @end date)
AS
BEGIN
	SELECT ktc.MaKhu, TenKhu, COUNT(v.MaVe) AS SLVe
	FROM dbo.KhuTroChoi ktc, dbo.Ve v
	WHERE ktc.MaKhu = v.MaKhu AND NgayBan BETWEEN @Start AND @end
	GROUP BY ktc.MaKhu, TenKhu
	--ORDER BY COUNT(v.MaVe) DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Del_KH]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SP_Del_KH]
(
	@Makh NCHAR(10)
)
AS
BEGIN
	--DECLARE @MaHoaDon NCHAR(10)
	--SELECT @MaHoaDon = MaHoaDon FROM dbo.HoaDon WHERE MaKH = @Makh
	BEGIN
		DELETE dbo.ChiTietHoaDon WHERE MaHoaDon 
		IN
		(
			SELECT MaHoaDon FROM dbo.HoaDon WHERE MaKH = @Makh
		)
	END
	
	BEGIN
		DELETE dbo.HoaDon WHERE MaKH = @Makh
	END
	
	BEGIN
		DELETE dbo.Ve WHERE MaKH = @Makh
	END
	
	BEGIN
		DELETE dbo.KhachHang WHERE MaKH = @Makh
	END
	
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DoanhThu1]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DoanhThu1]
as
begin
select ktc.MaKhu, sum(tong) DoanhThu  from KhuTroChoi ktc,
(select v.MaKhu, (v.ThanhTien+ct.ThanhTien) tong from Ve v, KhachHang kh, HoaDon hd, ChiTietHoaDon ct
where v.MaKH=kh.MaKH and kh.MaKH=hd.MaKH and hd.MaHoaDon=ct.MaHoaDon) a
where ktc.MaKhu=a.MaKhu
group by ktc.MaKhu
end

GO
/****** Object:  StoredProcedure [dbo].[SP_DoanhThuCacKhu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DoanhThuCacKhu]
as
begin
select ktc.MaKhu, SUM(a.tong)  from KhuTroChoi ktc,
(select v.MaKhu, (v.ThanhTien + ct.ThanhTien) tong from Ve v, KhachHang kh, HoaDon hd, ChiTietHoaDon ct
where v.MaKH=kh.MaKH and kh.MaKH=hd.MaKH and hd.MaHoaDon=ct.MaHoaDon) a
where ktc.MaKhu=a.MaKhu
group by ktc.MaKhu
end

GO
/****** Object:  StoredProcedure [dbo].[SP_SuaHD1]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE proc [dbo].[SP_SuaHD1](@MaHD nchar(10), @Makh nchar(10), @Madv nchar(10),@NgayHD Date, @Giadv int,@SLDV int, @Thanhtien int)
as
update HoaDon
set   NgayHoaDon=@NgayHD, MaKH=@Makh
where MaHoaDon=@MaHD
update ChiTietHoaDon
set MaDV=@Madv, GiaDV=@Giadv, SoLuongDV=@SLDV, ThanhTien=@Thanhtien
where MaHoaDon=@MaHD

GO
/****** Object:  StoredProcedure [dbo].[SP_SuaKhachHang]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SuaKhachHang]
(
	@Makh nchar(10),
	@Tenkh nvarchar(50),
	@Tuoi INT,
	@GioiTinh NVARCHAR(10)
)
as
begin 
update KhachHang set MaKH =@Makh  , TenKH=@Tenkh ,TuoiKH = @Tuoi , GioiTinhKH =@GioiTinh where MaKH = @Makh
end


GO
/****** Object:  StoredProcedure [dbo].[SP_ThemHD1]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[SP_ThemHD1](@MaHD nchar(10), @Madv nchar(10),@NgayHD Date, @Makh nchar(10), @Giadv int,@SLDV int, @Thanhtien int)
as
begin
insert into HoaDon(MaHoaDon, MaKH, NgayHoaDon)
values(@MaHD, @Makh, @NgayHD)
select @MaHD from HoaDon
where @MaHD=MaHoaDon
INSERT INTO ChiTietHoaDon(MaHoaDon, MaDV, GiaDV, SoLuongDV,ThanhTien)

values(@MaHD, @Madv, @Giadv, @SLDV,@Thanhtien)
end

GO
/****** Object:  StoredProcedure [dbo].[SP_ThemKhachHang]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ThemKhachHang]
(
	@Makh nchar(10),
	@Tenkh nvarchar(50),
	@Tuoi INT,
	@GioiTinh NVARCHAR(10)
)
AS
INSERT INTO dbo.KhachHang
        ( MaKH, TenKH, TuoiKH, GioiTinhKH )
VALUES  ( @Makh, -- MaKH - nchar(10)
          @Tenkh, -- TenKH - nvarchar(50)
          @Tuoi, -- TuoiKH - int
          @GioiTinh  -- GioiTinhKH - nvarchar(50)
          )
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemPhongBan]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Thủ tục thêm mới phòng ban

CREATE PROC [dbo].[SP_ThemPhongBan] 
(    
	 @Mapb nchar(10),
     @Tenpb nvarchar(50),
	 @Matp NCHAR(10),
	 @Ngaync DATE,
	 @diadiem NVARCHAR(50)
  ) 
AS 
INSERT INTO PhongBan
VALUES(@Mapb,@Tenpb, @Matp, @Ngaync, @diadiem) 


GO
/****** Object:  StoredProcedure [dbo].[SP_XemHD]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_XemHD](@MaHD nchar(10))
as
begin
select hd.MaHoaDon, MaKH, MaDV, NgayHoaDon, GiaDV, SoLuongDV,ThanhTien
from HoaDon hd, ChiTietHoaDon ct
where hd.MaHoaDon=ct.MaHoaDon and @MaHD=hd.MaHoaDon
end
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaHD]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[SP_XoaHD](@MaHD nchar(10))
as
begin
delete ChiTietHoaDon
where MaHoaDon=@MaHD
delete HoaDon
where MaHoaDon=@MaHD
end

GO
/****** Object:  StoredProcedure [dbo].[sua_ctn]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sua_ctn](@mactn char(10),@mahh char(15),@soluong int,@tien float,@dongia float)
as begin
update ChitietNhap
set MaHH=@mahh,
Soluong=@soluong,
Tien=@tien,
Dongia=@dongia
where Mactn=@mactn
end

GO
/****** Object:  StoredProcedure [dbo].[sua_DichVu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sua_DichVu](@maDV nchar(10), @tenDV nvarchar(50) , @maKhu nchar(10) ,@Gia int )
as
begin 
update DichVu set MaDV = @maDV  , TenDV=@tenDV , Gia = @Gia ,MaKhu = @maKhu where MaDV = @maDV
end

GO
/****** Object:  StoredProcedure [dbo].[sua_KhuTroChoi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------------------
create procedure [dbo].[sua_KhuTroChoi](@maKhu nchar(10), @tenKhu nvarchar(50) , @maNVQL nchar(10) ,@GiaVeNguoiLon int , @GiaVeTreEm int)
as
begin 
update KhuTroChoi set MaKhu = @maKhu  , TenKhu=@tenKhu , MaNVQL	 = @maNVQL ,GiaVeNguoiLon = @GiaVeNguoiLon , GiaVeTreEm = @GiaVeTreEm where MaKhu = @maKhu
end

GO
/****** Object:  StoredProcedure [dbo].[sua_pn]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sua_pn](@mapn char(10),@mathukho char(10),@makho char(10),@ngaylap datetime,@vat float)
as begin
update PhieuNhap
set MaThuKho=@mathukho,
MaKho=@makho,
Ngaylap=@ngaylap,
VAT=@vat
where MaPN=@mapn
end

GO
/****** Object:  StoredProcedure [dbo].[Sua_Ve]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Sua_Ve]
(
@Mave nchar(10),
@MaKH nchar(10),
@Makhu nchar(10),
@SLNL INT,
@SLTE int,
@Ngayban date,
@Thanhtien int
)
AS
BEGIN
	UPDATE dbo.Ve
	SET
    MaVe = @Mave,
	MaKH = @MaKH,
	MaKhu = @Makhu,
	SoLuongNguoiLon = @SLNL,
	SoLuongTreEm = @SLTE,
	NgayBan = @Ngayban,
	ThanhTien = @Thanhtien
	WHERE MaVe = @Mave
END


GO
/****** Object:  StoredProcedure [dbo].[Sua_Ve_KhachMoi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Sua_Ve_KhachMoi]
(
	@Makh nchar(10),
	@Tenkh nvarchar(50),
	@Tuoi INT,
	@GioiTinh NVARCHAR(10),

	@Mave nchar(10),
	@Makhu nchar(10),
	@SLNL INT,
	@SLTE int,
	@Ngayban date,
	@Thanhtien int
)
AS

BEGIN
	begin 
		UPDATE KhachHang set MaKH =@Makh  , TenKH=@Tenkh ,TuoiKH = @Tuoi , GioiTinhKH =@GioiTinh where MaKH = @Makh
	END

	BEGIN
		UPDATE dbo.Ve
		SET
		MaVe = @Mave,
		MaKH = @MaKH,
		MaKhu = @Makhu,
		SoLuongNguoiLon = @SLNL,
		SoLuongTreEm = @SLTE,
		NgayBan = @Ngayban,
		ThanhTien = @Thanhtien
		WHERE MaVe = @Mave
	END
END
GO
/****** Object:  StoredProcedure [dbo].[ThanhTien]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ThanhTien]
(
	@MaVe NCHAR(10)
)
AS 
BEGIN
	DECLARE @Makhu NCHAR(10)
	DECLARE @Giavenguoilon int
	DECLARE @Giavetreem INT
    DECLARE @ThanhTien INT
	DECLARE @SLnguoilon INT , @SLtreem INT


	SELECT @Makhu = Makhu FROM Ve WHERE MaVe = @MaVe
	SELECT @Giavenguoilon = GiaVeNguoiLon, @Giavetreem = GiaVeTreEm FROM dbo.KhuTroChoi WHERE MaKhu = @Makhu
	SELECT @SLnguoilon = SoLuongNguoiLon, @SLtreem = SoLuongTreEm FROM dbo.Ve WHERE MaVe = @MaVe
	SELECT @ThanhTien = @GiaVetreem*@SLtreem + @Giavenguoilon*@SLnguoilon
	SELECT @ThanhTien
	 
END


GO
/****** Object:  StoredProcedure [dbo].[them_ctn]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[them_ctn](@mactn char(10),@mapn char(10),@mahh char(15),@soluong int,@tien float,@dongia float)
as begin
if exists(select Mactn from ChitietNhap where Mactn=@mactn) print('khong them duoc')
else insert ChitietNhap values(@mactn,@mapn,@mahh,@soluong,@tien,@dongia)
end

GO
/****** Object:  StoredProcedure [dbo].[them_DichVu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[them_DichVu](@maDV nchar(10), @tenDV nvarchar(50) , @maKhu nchar(10) ,@Gia int )
as
begin 
insert into DichVu (MaDV , TenDV ,Gia , MaKhu) values(@maDV ,@tenDV  ,@Gia , @maKhu)
end
----------------------------------------------------------------------											

GO
/****** Object:  StoredProcedure [dbo].[Them_KhuTroChoi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Thủ tục thêm KhuTroChoi mới
 CREATE PROC [dbo].[Them_KhuTroChoi]
 (
	@Makhu NCHAR(10),
	@Tenkhu NVARCHAR(50),
	@Manvql NCHAR(10),
	@Giavetreem INT,
	@Giavenguoilon INT
 )
 AS INSERT INTO dbo.KhuTroChoi
         ( MaKhu ,
           TenKhu ,
           MaNVQL ,
           GiaVeTreEm ,
           GiaVeNguoiLon
         )
 VALUES  ( @Makhu, -- MaKhu - nchar(10)
           @Tenkhu , -- TenKhu - nvarchar(50)
           @Manvql , -- MaNVQL - nchar(10)
           @Giavetreem , -- GiaVeTreEm - int
           @Giavenguoilon  -- GiaVeNguoiLon - int
         )

GO
/****** Object:  StoredProcedure [dbo].[Them_NhanVien]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Them_NhanVien]
(
	@Manv NCHAR(10),
	@Tennv NVARCHAR(50),
	@Ngaysinh DATE,
	@Gioitinh NVARCHAR(10),
	@Vitriphutrach NVARCHAR(50),
	@Makhupt NCHAR(10),
	@Mapb NCHAR(10),
	@Luong float,
	@Quequan INT
) AS INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          ViTriPhuTrach ,
          MaKhuPhuTrach ,
          MaPB ,
          Luong ,
          QueQuan
        )
VALUES  ( @Manv , -- MaNV - nchar(10)
          @Tennv , -- TenNV - nvarchar(50)
          @Ngaysinh , -- NgaySinh - date
          @Gioitinh, -- GioiTinh - nvarchar(20)
          @Vitriphutrach , -- ViTriPhuTrach - nvarchar(50)
          @Makhupt , -- MaKhuPhuTrach - nchar(10)
          @Mapb , -- MaPB - nchar(10)
          @Luong, -- Luong - float
          @Quequan -- QueQuan - int
        )

GO
/****** Object:  StoredProcedure [dbo].[them_pn]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[them_pn](@mapn char(10),@mathukho char(10),@makho char(10),@ngaylap datetime,@vat float,@tongtien float)
as
begin
if exists(select Mapn from phieunhap where MaPN=@mapn) print('khong them duoc')
else
insert PhieuNhap values(@mapn,@mathukho,@makho,@ngaylap,@vat,@tongtien)
end

GO
/****** Object:  StoredProcedure [dbo].[Them_ThietBi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Them_ThietBi]
(
	@Matb NCHAR(10),
	@Tentb NVARCHAR(50),
	@Matrochoi NCHAR(10),
	@Tinhtrang NVARCHAR(50)
)
AS INSERT INTO dbo.ThietBi
        ( MaTB, TenTB, MaTroChoi, TinhTrang )
VALUES  ( @Matb, -- MaTB - nchar(10)
          @Tentb, -- TenTB - nvarchar(50)
          @Matrochoi, -- MaTroChoi - nvarchar(50)
          @Tinhtrang  -- TinhTrang - nvarchar(50)
          )



GO
/****** Object:  StoredProcedure [dbo].[ThemTroChoi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemTroChoi]
(
	@Matc NCHAR(10),
	@Tentc NVARCHAR(50),
	@Manvpt NCHAR(10),
	@SLNC INT,
	@Makhu NCHAR(10)
)
AS INSERT INTO dbo.TroChoi
        ( MaTroChoi ,
          TenTroChoi ,
          MaNVPhuTrach ,
          SoLuongNC_Max ,
          MaKhu
        )
VALUES  ( @Matc , -- MaTroChoi - nvarchar(50)
          @Tentc , -- TenTroChoi - nvarchar(50)
          @Manvpt , -- MaNVPhuTrach - nchar(10)
          @SLNC, -- SoLuongNC_Max - int
          @Makhu -- MaKhu - nchar(10)
        )

GO
/****** Object:  StoredProcedure [dbo].[TienDV_CacKhu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TienDV_CacKhu](@Start date, @end DATE)
AS
BEGIN
	SELECT ktc.MaKhu, ktc.TenKhu, SUM(ct.ThanhTien) AS TienDV
	FROM dbo.KhuTroChoi ktc, dbo.DichVu dv, dbo.ChiTietHoaDon ct, dbo.HoaDon hd
	WHERE ktc.MaKhu = dv.MaKhu
	AND dv.MaDV = ct.MaDV
	AND ct.MaHoaDon = hd.MaHoaDon
	AND hd.NgayHoaDon BETWEEN @Start AND @end
	GROUP BY ktc.MaKhu, ktc.TenKhu
END
GO
/****** Object:  StoredProcedure [dbo].[tienve]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[tienve](@Start date, @end date)
AS
BEGIN
	SELECT ktc.MaKhu, TenKhu, sum(v.ThanhTien)
	FROM dbo.KhuTroChoi ktc, dbo.Ve v, dbo.DichVu dv, dbo.ChiTietHoaDon cthd, dbo.HoaDon hd
	WHERE ktc.MaKhu = v.MaKhu AND NgayBan BETWEEN @Start AND @end
	AND dv.MaDV = cthd.MaDV
	AND cthd.MaHoaDon = hd.MaHoaDon
	AND NgayHoaDon BETWEEN @Start AND @end
	GROUP BY ktc.MaKhu, TenKhu

END
GO
/****** Object:  StoredProcedure [dbo].[TienVe_CacKhu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TienVe_CacKhu](@Start date, @end DATE)
AS
BEGIN
	SELECT ktc.MaKhu, ktc.TenKhu, SUM(v.ThanhTien) AS TienVe
	FROM dbo.KhuTroChoi ktc, dbo.Ve v
	WHERE v.MaKhu = ktc.MaKhu AND v.NgayBan  BETWEEN @Start AND @end 
	GROUP BY ktc.MaKhu, ktc.TenKhu
END

GO
/****** Object:  StoredProcedure [dbo].[TienVeTrongNgay]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TienVeTrongNgay](@MaKH NCHAR(10),@Date DATE)
AS 
BEGIN
	SELECT SUM(ThanhTien) 
	FROM dbo.Ve v , dbo.KhachHang kh 
	WHERE v.MaKH = @MaKH AND NgayBan = @Date AND v.MaKH = kh.MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[tk_nhap]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tk_nhap]
as
select CTN.MaHH as 'Mã HH', HH.TenHH as'Tên HH', sum(CTN.Soluong) as 'Số Lượng', CTN.Dongia as 'Đơn Giá',(CTN.Tien) as 'Tiền Trả'
from ChitietNhap CTN, HangHoa HH,PhieuNhap PN
where CTn.MaHH=HH.MaHH and CTN.MaPN=PN.MaPN
group by CTN.MaHH,HH.TenHH, CTN.Dongia,CTN.Tien


GO
/****** Object:  StoredProcedure [dbo].[TK_SLVe]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TK_SLVe](@Start date, @end date)
AS
BEGIN
	SELECT COUNT(MaVe) AS SoLuongVe FROM dbo.Ve WHERE NgayBan BETWEEN @Start AND @end
END
GO
/****** Object:  StoredProcedure [dbo].[TongDoanhThu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TongDoanhThu](@Start date, @end date)
AS
BEGIN
	DECLARE @TongTienVe INT
	DECLARE @TongTienDV INT
	DECLARE @DoanhThu INT

	SET @TongTienDV = 0
	SET @TongTienVe = 0
	SET @DoanhThu = 0

	SELECT @TongTienVe = SUM(v.ThanhTien)
	FROM dbo.Ve v
	WHERE NgayBan BETWEEN @Start AND @end
	
	SELECT @TongTienDV = SUM(cthd.ThanhTien)
	FROM dbo.HoaDon hd, dbo.ChiTietHoaDon cthd
	WHERE hd.MaHoaDon = cthd.MaHoaDon AND hd.NgayHoaDon BETWEEN @Start AND @end

	IF(@TongTienDV != 0 and @TongTienVe != 0)
		SET @DoanhThu = (@TongTienDV + @TongTienVe)
	ELSE IF (@TongTienDV !=0 or @TongTienVe = 0)
		SET @DoanhThu = @TongTienDV
	ELSE IF (@TongTienDV = 0 or @TongTienVe != 0)
		SET @DoanhThu = @TongTienVe
		ELSE
		SET @DoanhThu = 0

	SELECT @DoanhThu
END


GO
/****** Object:  StoredProcedure [dbo].[TongDoanhThu_TheoKhu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TongDoanhThu_TheoKhu](@Start date, @end DATE, @MaKhu NCHAR(10))
AS
BEGIN
	DECLARE @TongTienVe INT
	DECLARE @TongTienDV INT
	DECLARE @DoanhThu INT

	SET @TongTienDV = 0
	SET @TongTienVe = 0
	SET @DoanhThu = 0

	SELECT @TongTienVe = SUM(v.ThanhTien)
	FROM dbo.Ve v
	WHERE NgayBan BETWEEN @Start AND @end AND v.MaKhu = @MaKhu
	
	SELECT @TongTienDV = SUM(cthd.ThanhTien)
	FROM dbo.HoaDon hd, dbo.ChiTietHoaDon cthd, dbo.DichVu dv
	WHERE hd.MaHoaDon = cthd.MaHoaDon AND dv.MaDV = cthd.MaDV AND hd.NgayHoaDon BETWEEN @Start AND @end 
	AND dv.MaKhu = @MaKhu

	IF(@TongTienDV != 0 and @TongTienVe != 0)
		SET @DoanhThu = (@TongTienDV + @TongTienVe)
	ELSE IF (@TongTienDV !=0 or @TongTienVe = 0)
		SET @DoanhThu = @TongTienDV
	ELSE IF (@TongTienDV = 0 or @TongTienVe != 0)
		SET @DoanhThu = @TongTienVe
		ELSE
		SET @DoanhThu = 0

	SELECT @DoanhThu
END

GO
/****** Object:  StoredProcedure [dbo].[TongLuongNV]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[TongLuongNV]
AS
BEGIN
	SELECT SUM(Luong)
	FROM dbo.NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[TongTien_CacKH]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TongTien_CacKH]
AS
BEGIN
	DECLARE @TongTien INT

	SELECT kh.MaKH, kh.TenKH, SUM(ct.ThanhTien) + SUM(v.ThanhTien)
	FROM dbo.KhachHang kh, dbo.Ve v, dbo.HoaDon hd, dbo.ChiTietHoaDon ct
	WHERE kh.MaKH = v.MaKH OR v.MaKH = hd.MaKH AND hd.MaHoaDon = ct.MaHoaDon 
	GROUP BY kh.MaKH, kh.TenKH	
END
GO
/****** Object:  StoredProcedure [dbo].[TongTienKH]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[TongTienKH](@MaKH NCHAR(10))
AS
BEGIN
	DECLARE @TienVe INT
	DECLARE @TienDV INT
	DECLARE @ThanhTien INT

	SELECT @TienVe = SUM(ThanhTien)
	FROM dbo.Ve v, dbo.KhachHang kh
	WHERE v.MaKH = kh.MaKH AND kh.MaKH = @MaKH

	SELECT @TienDV = SUM(ThanhTien)
	FROM dbo.ChiTietHoaDon ct, dbo.HoaDon hd, dbo.KhachHang kh
	WHERE ct.MaHoaDon = hd.MaHoaDon AND kh.MaKH = hd.MaKH AND hd.MaKH = @MaKH

	IF(@TienDV != 0 and @TienVe != 0)
		SET @ThanhTien = (@TienDV + @TienVe)
	ELSE IF (@TienDV !=0 or @TienVe = 0)
		SET @ThanhTien = @TienDV
	ELSE IF (@TienDV = 0 or @TienVe != 0)
		SET @ThanhTien = @TienVe

		ELSE
		SET @ThanhTien = 0

	SELECT @TienDV AS TienDV, @TienVe AS TienVe, @ThanhTien AS ThanhTien
	 
END
GO
/****** Object:  StoredProcedure [dbo].[Update_NhanVien]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_NhanVien]
(
	@Manv NCHAR(10),
	@Tennv NVARCHAR(50),
	@Ngaysinh DATE,
	@Gioitinh NVARCHAR(10),
	@Vitriphutrach NVARCHAR(50),
	@Makhupt NCHAR(10),
	@Mapb NCHAR(10),
	@Luong float,
	@Quequan INT
) AS UPDATE dbo.NhanVien
SET
	MaNV = @Manv,
	TenNV = @Tennv,
	NgaySinh = @Ngaysinh,
	GioiTinh = @Gioitinh,
	ViTriPhuTrach = @Vitriphutrach,
	MaKhuPhuTrach = @Makhupt,
	Mapb = @Mapb,
	Luong = @Luong,
	QueQuan = @Quequan
WHERE MaNV = @Manv

GO
/****** Object:  StoredProcedure [dbo].[Update_TB]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_TB]
(
	@Matb NCHAR(10),
	@Tentb NVARCHAR(50),
	@Matrochoi NCHAR(10),
	@Tinhtrang NVARCHAR(50)
)AS UPDATE dbo.ThietBi
SET MaTB = @Matb,
	TenTB = @Tentb,
	MaTroChoi = @Matrochoi,
	TinhTrang = @Tinhtrang

GO
/****** Object:  StoredProcedure [dbo].[Update_TroChoi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Update_TroChoi]
(
	@Matc NCHAR(10),
	@Tentc NVARCHAR(50),
	@Manvpt NCHAR(10),
	@SLNC INT,
	@Makhu NCHAR(10)
)
AS UPDATE dbo.TroChoi
SET
MaTroChoi = @Matc,
TenTroChoi = @Tentc,
MaNVPhuTrach = MaNVPhuTrach,
SoLuongNC_Max = @SLNC,
MaKhu = @Makhu
WHERE MaTroChoi = @Matc

GO
/****** Object:  StoredProcedure [dbo].[UpdateKTC]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Thủ tục sửa khutrochoi

CREATE PROC [dbo].[UpdateKTC]
(
	@Makhu NCHAR(10),
	@Tenkhu NVARCHAR(50),
	@Manvql NCHAR(10),
	@Giavetreem INT,
	@Giavenguoilon INT
)
AS UPDATE dbo.KhuTroChoi
SET
MaKhu = @Makhu,
TenKhu = @Tenkhu,
MaNVQL = @Manvql,
GiaVeTreEm = @Giavetreem,
GiaVeNguoiLon = @Giavenguoilon
WHERE MaKhu = @Makhu


GO
/****** Object:  StoredProcedure [dbo].[UpdatePB]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdatePB]
(
	@Mapb nchar(10),
     @Tenpb nvarchar(50),
	 @Matp NCHAR(10),
	 @Ngaync DATE,
	 @diadiem NVARCHAR(50)
)
AS UPDATE dbo.PhongBan
SET MaPB = @Mapb, 
	TenPB = @Tenpb,
	MaTP = @Matp,
	NgayNC = @Ngaync,
	DiaDiem = @diadiem
WHERE MaPB = @Mapb

GO
/****** Object:  StoredProcedure [dbo].[VeKH]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VeKH](@MaKH NCHAR(10))
AS
BEGIN
	SELECT MaVe FROM dbo.Ve WHERE MaKH = @MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[XemGia]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemGia](@Mave NCHAR(10))
AS
BEGIN
	SELECT GiaVeTreEm, GiaVeNguoiLon
	FROM dbo.KhuTroChoi
	WHERE MaKhu 
	IN
	(
		SELECT Makhu FROM dbo.Ve WHERE MaVe = @Mave
	)

end
GO
/****** Object:  StoredProcedure [dbo].[XemNhanVien]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XemNhanVien](@Manv NCHAR(10))
AS
BEGIN
	SELECT MaNV FROM dbo.NhanVien WHERE MaNV = @Manv
END



GO
/****** Object:  StoredProcedure [dbo].[XemVe]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemVe]( @MaVe NCHAR(10))
AS
BEGIN
	SELECT v.MaKH,kh.TenKH, MaVe, v.MaKhu, v.SoLuongTreEm, v.SoLuongNguoiLon, v.NgayBan, v.ThanhTien
	FROM dbo.Ve v , dbo.KhachHang kh 
	WHERE v.MaVe = @MaVe AND v.MaKH = kh.MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[xoa_ctn]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoa_ctn](@mactn char(10))
as begin
delete ChitietNhap where Mactn=@mactn
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_DichVu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------
create procedure [dbo].[xoa_DichVu](@maDV nchar(10)  )
as
begin 
delete  DichVu where MaDV = @maDV
end
GO
/****** Object:  StoredProcedure [dbo].[xoa_kh]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoa_kh](@makh char(10))
as begin
delete KhachHang where MaKh=@makh
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_KhuTroChoi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------------------
create procedure [dbo].[xoa_KhuTroChoi](@maKhu nchar(10))
as
begin 
delete ThietBi where MaTroChoi in (select tc.MaTroChoi from  TroChoi tc , KhuTroChoi ktc where tc.MaKhu=@maKhu and tc.MaKhu = ktc.MaKhu )
delete TroChoi where MaTroChoi in (select tc.MaTroChoi from  TroChoi tc , KhuTroChoi ktc where tc.MaKhu  = @maKhu  )
update NhanVien set MaKhuPhuTrach = null where maNV = (select MaNVQL from KhuTroChoi where MaKhu = @maKhu )
update DichVu set MaKhu = null where MaDV = (select MaDV from DichVu where MaKhu = @maKhu )
delete  KhuTroChoi where MaKhu = @maKhu
end

----------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[Xoa_KVC]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_KVC] (@Makhu NCHAR(10))
AS DELETE dbo.KhuTroChoi WHERE MaKhu = @Makhu

GO
/****** Object:  StoredProcedure [dbo].[Xoa_NhanVien]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_NhanVien]
(@Manv NCHAR(10))
AS
DELETE dbo.NhanVien WHERE MaNV = @Manv

GO
/****** Object:  StoredProcedure [dbo].[xoa_nv]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoa_nv](@manv char(10))
as
begin
delete NhanVien
where MaNV=@manv
end 

GO
/****** Object:  StoredProcedure [dbo].[xoa_pn]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xoa_pn](@mapn char(10))
as begin
delete ChitietNhap where maPN=@mapn
delete PhieuNhap where MaPN=@mapn
end

GO
/****** Object:  StoredProcedure [dbo].[Xoa_TB]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_TB]
(
	@Matb NCHAR(10)
)
AS DELETE dbo.ThietBi WHERE MaTB = @Matb

GO
/****** Object:  StoredProcedure [dbo].[Xoa_TroChoi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_TroChoi] (@Matc NCHAR(10))
AS DELETE dbo.TroChoi
WHERE MaTroChoi = @Matc

GO
/****** Object:  StoredProcedure [dbo].[XoaPB]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaPB](@Ma NCHAR(10))
AS DELETE dbo.PhongBan
WHERE MaPB = @Ma

GO
/****** Object:  UserDefinedFunction [dbo].[DoanhThu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[DoanhThu](@Makhu nchar(10), @ngay DATE)
RETURNS @Bang TABLE
(
	Ngay date,
	Makhu nchar(10),
	DoanhThu int
)
AS
BEGIN
DECLARE @TongTienDV INT
DECLARE @TongTienVe INT
DECLARE @DoanhThu INT
--DECLARE @Ngay DATE

BEGIN
SELECT @TongTienDV = SUM(ThanhTien)
FROM dbo.ChiTietHoaDon cthd, dbo.HoaDon hd, dbo.DichVu dv
WHERE cthd.MaHoaDon = hd.MaHoaDon AND cthd.MaDV = dv.MaDV AND dv.MaKhu = @Makhu
GROUP BY hd.NgayHoaDon, dv.MaKhu
END

BEGIN
SELECT @TongTienVe = SUM(ThanhTien)
FROM dbo.Ve v, dbo.KhuTroChoi ktc
WHERE v.MaKhu = ktc.MaKhu AND ktc.MaKhu = 'k01' AND v.NgayPhatHanh = @ngay
GROUP BY v.MaKhu,v.NgayPhatHanh
end

INSERT INTO @Bang
        ( Ngay, Makhu, DoanhThu )
VALUES  ( @Ngay, -- Ngay - date
          @Makhu, -- Makhu - nchar(10)
          @TongTienDV+@TongTienVe -- DoanhThu - int
          )

return
END

GO
/****** Object:  UserDefinedFunction [dbo].[F3_DSNV11]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Function [dbo].[F3_DSNV11] (@TENPB nvarchar(50))
 returns @Bang table
	(
	MAnv char(10),
	TENnv nvarchar(50) 
	)
as
begin

if (@TENPB is NULL)
	insert into @Bang
	select MaNV, TenNV
	from NhanVien
ELSE 
	declare @MAPB char(10)
	select @MAPB = MaPB
	from PhongBan
	where TenPB = @TENPB 		
	insert into @Bang
	select MaNV, TenNV
	from NhanVien
	where MaPB = @MAPB

return	
end

GO
/****** Object:  UserDefinedFunction [dbo].[TongKHGiaoDich]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TongKHGiaoDich](@Ngay date)
RETURNs @Bang TABLE
(
	TongKH INT,
    Ngay1 date
)
AS
BEGIN
	INSERT INTO @Bang
	SELECT COUNT(DISTINCT MaKH), @Ngay
	FROM dbo.HoaDon
	WHERE NgayHoaDon = @Ngay
	return
END

GO
/****** Object:  UserDefinedFunction [dbo].[TongTienDV]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TongTienDV](@Makh nchar(10))
RETURNs @Bang TABLE
(
	MAKH NCHAR(10),
	MAHD nchar(10),
	Tongtien int
)
AS 
BEGIN 
INSERT INTO @Bang
SELECT hd.MaKH , hd.MaHoaDon, Sum(ThanhTien)
FROM dbo.ChiTietHoaDon cthd, dbo.HoaDon hd
WHERE cthd.MaHoaDon = hd.MaHoaDon AND hd.MaKH = @Makh
GROUP BY hd.MaKH , hd.MaHoaDon

RETURN
END

GO
/****** Object:  UserDefinedFunction [dbo].[XemDV_TheoTenKhu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--6. Tạo hàm đưa ra dịch vụ của khu trò chơi có tên là gì đấy

CREATE FUNCTION [dbo].[XemDV_TheoTenKhu](@tenkhu NCHAR(10))
RETURNS @Bang TABLE
(
	madv NCHAR(10),
	tendv nvarchar(50)
)
as
BEGIN
DECLARE @makhu NCHAR(10)
SELECT @makhu = MaKhu FROM dbo.KhuTroChoi WHERE TenKhu = @tenkhu
INSERT INTO @Bang
SELECT MaDV, TenDV FROM dbo.DichVu dv WHERE dv.MaKhu = @makhu

RETURN
END

GO
/****** Object:  UserDefinedFunction [dbo].[XemKhuTC]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[XemKhuTC](@Makhu nchar(10))
RETURNs @Bang TABLE
(
	makhu nchar(10),
	tenkhu nvarchar(50)
)
AS
BEGIN 
INSERT INTO @Bang
SELECT MaKhu, TenKhu
FROM dbo.KhuTroChoi
WHERE MaKhu = @Makhu
return
END

GO
/****** Object:  UserDefinedFunction [dbo].[XemKhuTC_TheoTen]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[XemKhuTC_TheoTen](@Tenkhu NVARCHAR(50))
RETURNS @Bang TABLE
(
	makhu NCHAR(10),
	tenkhu NVARCHAR(50)
)
AS
BEGIN
	DECLARE @makhu NCHAR(10)
	SELECT @makhu = MaKhu 
	FROM dbo.KhuTroChoi
	WHERE TenKhu = @Tenkhu
	INSERT INTO @Bang
	SELECT MaKhu, TenKhu FROM dbo.KhuTroChoi WHERE MaKhu = @makhu
RETURN
END

GO
/****** Object:  UserDefinedFunction [dbo].[XemTB_TheoMaTC]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--7. Tạo hàm xem danh sách thiết bị của trò chơi có mã là gì đấy
CREATE FUNCTION [dbo].[XemTB_TheoMaTC](@Matc NCHAR(10))
RETURNS @Bang TABLE
(
	matb NCHAR(10),
	tentb nvarchar(50)
)
AS
BEGIN
INSERT INTO @Bang
SELECT MaTB, TenTB FROM dbo.ThietBi
WHERE MaTroChoi = @Matc
RETURN
END

GO
/****** Object:  UserDefinedFunction [dbo].[XemTC_theoTenNV]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[XemTC_theoTenNV](@tennv NVARCHAR(50))
RETURNS @Bang TABLE
(
	matc NCHAR(10),
	tenkhu NVARCHAR(50)
)
AS
BEGIN
	DECLARE @manv NCHAR(10)
	SELECT @manv= MaNV FROM dbo.NhanVien WHERE TenNV = @tennv
	INSERT INTO @Bang
	SELECT MaTroChoi, TenTroChoi FROM TroChoi WHERE MaNVPhuTrach = @manv

RETURN
END



GO
/****** Object:  UserDefinedFunction [dbo].[XemTroChoi_TheoMaNVQL]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[XemTroChoi_TheoMaNVQL](@manv NCHAR(10))
RETURNS @Bang TABLE
(
	Matc NCHAR(10),
	Tentc NVARCHAR(50)
)
AS
BEGIN
INSERT INTO @Bang
SELECT MaKhu, TenKhu FROM dbo.KhuTroChoi
WHERE MaNVQL = @manv

RETURN
END

GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [nchar](10) NOT NULL,
	[MaDV] [nchar](10) NOT NULL,
	[GiaDV] [int] NULL,
	[SoLuongDV] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [nchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[Gia] [int] NULL,
	[MaKhu] [nchar](10) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nchar](10) NOT NULL,
	[NgayHoaDon] [date] NULL,
	[MaKH] [nchar](10) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[TuoiKH] [int] NULL,
	[GioiTinhKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhuTroChoi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuTroChoi](
	[MaKhu] [nchar](10) NOT NULL,
	[TenKhu] [nvarchar](50) NULL,
	[MaNVQL] [nchar](10) NULL,
	[GiaVeTreEm] [int] NULL,
	[GiaVeNguoiLon] [int] NULL,
 CONSTRAINT [PK_KhuTroChoi] PRIMARY KEY CLUSTERED 
(
	[MaKhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserName] [nchar](10) NOT NULL,
	[PassWord] [nchar](10) NULL,
	[MaQuyen] [int] NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](20) NULL,
	[ViTriPhuTrach] [nvarchar](50) NULL,
	[MaKhuPhuTrach] [nchar](10) NULL,
	[MaPB] [nchar](10) NULL,
	[Luong] [int] NULL,
	[QueQuan] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaQuyen] [int] NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [nchar](10) NOT NULL,
	[TenPB] [nvarchar](30) NULL,
	[MaTP] [nchar](10) NULL,
	[NgayNC] [date] NULL,
	[DiaDiem] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QueQuan]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QueQuan](
	[MaTinh] [int] NOT NULL,
	[TenTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_QueQuan] PRIMARY KEY CLUSTERED 
(
	[MaTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[MaTB] [nchar](10) NOT NULL,
	[TenTB] [nvarchar](50) NULL,
	[MaTroChoi] [nvarchar](50) NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThietBi] PRIMARY KEY CLUSTERED 
(
	[MaTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TroChoi]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TroChoi](
	[MaTroChoi] [nvarchar](50) NOT NULL,
	[TenTroChoi] [nvarchar](50) NULL,
	[MaNVPhuTrach] [nchar](10) NULL,
	[SoLuongNC_Max] [int] NULL,
	[MaKhu] [nchar](10) NULL,
 CONSTRAINT [PK_TroChoi] PRIMARY KEY CLUSTERED 
(
	[MaTroChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ve]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[MaVe] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NULL,
	[MaKhu] [nchar](10) NULL,
	[SoLuongNguoiLon] [int] NULL,
	[SoLuongTreEm] [int] NULL,
	[NgayBan] [date] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_Ve] PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[Viu]    Script Date: 09/05/2018 04:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW [dbo].[Viu] 
AS
SELECT pb.MaPB, MaNV, nv.TenNV
FROM dbo.PhongBan pb, dbo.NhanVien nv
WHERE pb.MaPB = nv.MaPB


GO
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd01      ', N'dv01      ', 50000, 2, 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd01      ', N'dv02      ', 50000, 2, 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd01      ', N'dv03      ', 50000, 2, 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd01      ', N'dv04      ', 50000, 2, 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd02      ', N'dv07      ', 50000, 2, 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd03      ', N'dv09      ', 50000, 2, 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd05      ', N'dv03      ', 10000, 120, 1200000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd06      ', N'dv02      ', 100000, 1000, 100000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd07      ', N'dv03      ', 30000, 5, 150000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd08      ', N'dv01      ', 12000, 100, 1200000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaDV], [GiaDV], [SoLuongDV], [ThanhTien]) VALUES (N'hd09      ', N'dv05      ', 20000, 2, 40000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv01      ', N'Bán Xèng', 50000, N'k05       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv02      ', N'Thuê Phao', 50000, N'k01       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv03      ', N'Thuê Đồ Bơi Nam', 50000, N'k01       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv04      ', N'Thuê Đồ Bơi Nữ', 50000, N'k01       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv05      ', N'Bán Bỏng Ngô', 50000, N'k04       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv06      ', N'Thuê Quần Áo Thể Thao', 50000, N'k10       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv07      ', N'a', 50000, N'k02       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv08      ', N'b', 50000, N'k02       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv09      ', N'c', 50000, N'k03       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv10      ', N'd', 50000, N'k04       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv11      ', N'e', 50000, N'k05       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv12      ', N'f', 50000, N'k06       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv13      ', N'g', 50000, N'k07       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv14      ', N'h', 50000, N'k08       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv15      ', N'i', 50000, N'k09       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv16      ', N'j', 50000, N'k10       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv17      ', N'k', 50000, N'k01       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv18      ', N'l', 50000, N'k02       ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [MaKhu]) VALUES (N'dv19      ', N'm', 50000, N'k03       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayHoaDon], [MaKH]) VALUES (N'hd01      ', CAST(0x103E0B00 AS Date), N'kh01      ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayHoaDon], [MaKH]) VALUES (N'hd02      ', CAST(0x113E0B00 AS Date), N'kh02      ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayHoaDon], [MaKH]) VALUES (N'hd03      ', CAST(0x113E0B00 AS Date), N'kh03      ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayHoaDon], [MaKH]) VALUES (N'hd05      ', CAST(0x2F3E0B00 AS Date), N'kh02      ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayHoaDon], [MaKH]) VALUES (N'hd06      ', CAST(0x2F3E0B00 AS Date), N'kh01      ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayHoaDon], [MaKH]) VALUES (N'hd07      ', CAST(0x2F3E0B00 AS Date), N'kh03      ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayHoaDon], [MaKH]) VALUES (N'hd08      ', CAST(0x303E0B00 AS Date), N'kh04      ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayHoaDon], [MaKH]) VALUES (N'hd09      ', CAST(0x363E0B00 AS Date), N'kh05      ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh01      ', N'Nguyễn Ngọc Hà', 9, N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh02      ', N'Nguyễn Thành Nam', 12, N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh03      ', N'Nguyễn Thị Bích', 13, N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh04      ', N'Trần Hoàng Anh
', 12, N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh05      ', N'Vũ Mạnh Tuấn', 34, N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh06      ', N'Trần Quốc Bảo
', 23, N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh07      ', N'Nguyễn Thành Đạt', 12, N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh08      ', N'Nguyễn Văn Chình
', 34, N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh09      ', N'Trần Quang Chung
', 23, N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh10      ', N'Nguyễn Quốc Chưởng
', 32, N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh11      ', N'Vũ Vũ M', 21, N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh12      ', N'Nguyễn Xuân Trung', 34, N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh13      ', N'Nguyễn Văn Anh', 12, N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh14      ', N'Vũ Thị Lan', 50, N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh15      ', N'Vũ Đức Xương', 51, N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh16      ', N'Nguyễn Tùng Sơn', 22, N'Khác')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [TuoiKH], [GioiTinhKH]) VALUES (N'kh17      ', N'sadadsa', 12, N'Nữ')
INSERT [dbo].[KhuTroChoi] ([MaKhu], [TenKhu], [MaNVQL], [GiaVeTreEm], [GiaVeNguoiLon]) VALUES (N'k01       ', N'Khu Bể Bơi', N'nv11      ', 100000, 200000)
INSERT [dbo].[KhuTroChoi] ([MaKhu], [TenKhu], [MaNVQL], [GiaVeTreEm], [GiaVeNguoiLon]) VALUES (N'k02       ', N'Khu Trò Chơi Cảm Giác Mạnh', N'nv14      ', 200000, 400000)
INSERT [dbo].[KhuTroChoi] ([MaKhu], [TenKhu], [MaNVQL], [GiaVeTreEm], [GiaVeNguoiLon]) VALUES (N'k03       ', N'Khu Lái Xe', N'nv21      ', 100000, 200000)
INSERT [dbo].[KhuTroChoi] ([MaKhu], [TenKhu], [MaNVQL], [GiaVeTreEm], [GiaVeNguoiLon]) VALUES (N'k04       ', N'Khu Xem Phim', N'nv26      ', 100000, 200000)
INSERT [dbo].[KhuTroChoi] ([MaKhu], [TenKhu], [MaNVQL], [GiaVeTreEm], [GiaVeNguoiLon]) VALUES (N'k05       ', N'Khu Trò Chơi Điện Tử', N'nv30      ', 100000, 200000)
INSERT [dbo].[KhuTroChoi] ([MaKhu], [TenKhu], [MaNVQL], [GiaVeTreEm], [GiaVeNguoiLon]) VALUES (N'k06       ', N'Khu Trò Chơi Dân Gian', N'nv33      ', 100000, 200000)
INSERT [dbo].[KhuTroChoi] ([MaKhu], [TenKhu], [MaNVQL], [GiaVeTreEm], [GiaVeNguoiLon]) VALUES (N'k07       ', N'Khu Đu Quay', N'nv38      ', 300000, 500000)
INSERT [dbo].[KhuTroChoi] ([MaKhu], [TenKhu], [MaNVQL], [GiaVeTreEm], [GiaVeNguoiLon]) VALUES (N'k08       ', N'Khu Cầu Trượt', N'nv41      ', 100000, 200000)
INSERT [dbo].[KhuTroChoi] ([MaKhu], [TenKhu], [MaNVQL], [GiaVeTreEm], [GiaVeNguoiLon]) VALUES (N'k09       ', N'Khu Nhà Hơi', N'nv44      ', 100000, 200000)
INSERT [dbo].[KhuTroChoi] ([MaKhu], [TenKhu], [MaNVQL], [GiaVeTreEm], [GiaVeNguoiLon]) VALUES (N'k10       ', N'Khu Thể Thao', N'nv46      ', 100000, 200000)
INSERT [dbo].[Login] ([UserName], [PassWord], [MaQuyen]) VALUES (N'ad        ', N'123       ', 1)
INSERT [dbo].[Login] ([UserName], [PassWord], [MaQuyen]) VALUES (N'Admin     ', N'123       ', 1)
INSERT [dbo].[Login] ([UserName], [PassWord], [MaQuyen]) VALUES (N'TrungHieu  ', N'123      ', 1)
INSERT [dbo].[Login] ([UserName], [PassWord], [MaQuyen]) VALUES (N'NgocSon   ', N'123       ', 1)
INSERT [dbo].[Login] ([UserName], [PassWord], [MaQuyen]) VALUES (N'NhanVien  ', N'123       ', 2)
INSERT [dbo].[Login] ([UserName], [PassWord], [MaQuyen]) VALUES (N'QuanDuong ', N'123       ', 1)
INSERT [dbo].[Login] ([UserName], [PassWord], [MaQuyen]) VALUES (N'ThanhTu   ', N'123       ', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv02      ', N'Vũ Mạnh Tuấn', CAST(0xFE1F0B00 AS Date), N'Nam', N'Tổng Giám Đốc', N'k01       ', N'pb02      ', 50000000, 15)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv03      ', N'Dương Hoài Phương ', CAST(0x2D200B00 AS Date), N'Nữ', N'NV Hành Chính', NULL, N'pb01      ', 16000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv04      ', N'Nguyễn Thành Nam', CAST(0x26200B00 AS Date), N'Nam', N'NV Hành Chính', NULL, N'pb01      ', 15000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv05      ', N'Phan Vinh Bính', CAST(0x99200B00 AS Date), N'Nam', N'NV Hành Chính', NULL, N'pb01      ', 14500000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv06      ', N'Nguyễn Thanh Bình', CAST(0xFF1F0B00 AS Date), N'Nam', N'NV Hành Chính', NULL, N'pb01      ', 16000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv07      ', N'Nguyễn Quang Trung', CAST(0xB9200B00 AS Date), N'Nam', N'NV Hành Chính', NULL, N'pb01      ', 17000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv08      ', N'Võ Minh Thư', CAST(0xE8200B00 AS Date), N'Nữ', N'NV Hành Chính', NULL, N'pb01      ', 15100000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv09      ', N'Nguyễn Thế Vinh', CAST(0xFD1D0B00 AS Date), N'Nam', N'NV Hành Chính', NULL, N'pb01      ', 15000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv10      ', N'Đào Thanh Tú', CAST(0x58200B00 AS Date), N'Nữ', N'TP Quản Lý Khu Vực Vui Chơi', NULL, N'pb02      ', 20000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv11      ', N'Lê Minh Vương', CAST(0x5B200B00 AS Date), N'Nam', N'Nhân Viên Khu Bể Bơi', NULL, N'pb02      ', 16000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv12      ', N'Đỗ Nguyễn Nhất Anh', CAST(0x33200B00 AS Date), N'Nam', N'Nhân Viên Khu Bể Bơi', N'k01       ', N'pb02      ', 15000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv13      ', N'Phạm Hoàng Nam Trung', CAST(0xB4200B00 AS Date), N'Nam', N'Nhân Viên Khu Bể Bơi', N'k01       ', N'pb02      ', 15000000, 15)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv14      ', N'Kiều Hồng Trang', CAST(0x031F0B00 AS Date), N'Nam', N'Khu Cảm Giác Mạnh', N'k02       ', N'pb02      ', 16000000, 15)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv15      ', N'Phạm Văn Đông', CAST(0xBA1E0B00 AS Date), N'Nam', N'Khu Cảm Giác Mạnh', N'k01       ', N'pb01      ', 15000000, 14)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv16      ', N'Lê Thị Lệ Thủy', CAST(0x4C1D0B00 AS Date), N'Nam', N'Khu Cảm Giác Mạnh', N'k02       ', N'pb02      ', 15000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv17      ', N'Trương Yến Thanh', CAST(0x4C1D0B00 AS Date), N'Nữ', N'Khu Cảm Giác Mạnh', N'k02       ', N'pb02      ', 15000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv18      ', N'Trần Thị Cẩm Tiên', CAST(0x4C1D0B00 AS Date), N'Nữ', N'Khu Cảm Giác Mạnh', N'k02       ', N'pb02      ', 15000000, 3)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv19      ', N'Đào Duy Toàn', CAST(0x4C1D0B00 AS Date), N'Nam', N'Khu Cảm Giác Mạnh', N'k02       ', N'pb02      ', 15000000, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv20      ', N'Ngô Phạm Thanh Trúc', CAST(0x4C1D0B00 AS Date), N'Nữ', N'Khu Cảm Giác Mạnh', N'k02       ', N'pb02      ', 15000000, 5)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv21      ', N'Đào Duy Toàn', CAST(0x97170B00 AS Date), N'Nam', N'Nhân Viên Khu Lái Xe', N'k03       ', N'pb02      ', 15000000, 6)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv22      ', N'Nguyễn Thùy Như Quỳnh', CAST(0x721A0B00 AS Date), N'Nữ', N'Nhân Viên Khu Lái Xe', N'k03       ', N'pb02      ', 14000000, 7)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv23      ', N'Ngô Phạm Thanh Trúc', CAST(0x771A0B00 AS Date), N'Nữ', N'Nhân Viên Khu Lái Xe', N'k03       ', N'pb02      ', 14000000, 8)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv24      ', N'Trần Phan Bảo Thu', CAST(0xCD1A0B00 AS Date), N'Nữ', N'Nhân Viên Khu Lái Xe', N'k03       ', N'pb02      ', 14000000, 9)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv25      ', N'Phan Vũ Minh Quyền', CAST(0x121A0B00 AS Date), N'Nam', N'Nhân Viên Khu Lái Xe', N'k03       ', N'pb01      ', 14000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv26      ', N'Trần Phan Bảo Anh', CAST(0xB21A0B00 AS Date), N'Nữ', N'Nhân Viên Xem Phim', N'k04       ', N'pb02      ', 15000000, 10)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv27      ', N'Phạm Hoàng Nam Trung', CAST(0x0B1A0B00 AS Date), N'Nam', N'Nhân Viên Xem Phim', N'k04       ', N'pb02      ', 12000000, 11)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv28      ', N'Nguyễn Văn Khải ', CAST(0x9D180B00 AS Date), N'Nam', N'Nhân Viên Xem Phim', N'k04       ', N'pb02      ', 12000000, 12)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv29      ', N'Trương Hoài Thuận', CAST(0xBD180B00 AS Date), N'Nam', N'Nhân Viên Xem Phim', N'k04       ', N'pb02      ', 12000000, 13)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv30      ', N'Trương Thị Bích Ngọc', CAST(0x871D0B00 AS Date), N'Nữ', N'Nhân Viên Khu Trò Chơi Điện Tử', N'k05       ', N'pb02      ', 17000000, 14)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv31      ', N'Khưu Minh Trường', CAST(0x7C1D0B00 AS Date), N'Nam', N'Nhân Viên Khu Trò Chơi Điện Tử', N'k05       ', N'pb02      ', 16000000, 15)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv32      ', N'Đỗ Nguyễn Nhất Anh', CAST(0xA61D0B00 AS Date), N'Nữ', N'Nhân Viên Khu Trò Chơi Điện Tử', N'k05       ', N'pb02      ', 16000000, 16)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv33      ', N'Đặng Thị Thủy Tiên', CAST(0x7C1D0B00 AS Date), N'Nữ', N'Nhân Viên Khu Trò Chơi Dân Gian', N'k06       ', N'pb02      ', 17000000, 17)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv34      ', N'Hồ Thị Bích Ngọc', CAST(0x7C1D0B00 AS Date), N'Nữ', N'Nhân Viên Khu Trò Chơi Dân Gian', N'k06       ', N'pb02      ', 16000000, 18)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv35      ', N'Nguyễn Hoàng Nam', CAST(0x7C1D0B00 AS Date), N'Nữ', N'', N'k02       ', N'pb01      ', 15000000, 11)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv36      ', N'Đặng Như Ngọc ', CAST(0x24190B00 AS Date), N'Nữ', N'Nhân Viên Khu Trò Chơi Dân Gian', N'k06       ', N'pb02      ', 15000000, 18)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv37      ', N'Bùi Duy Quang', CAST(0x16190B00 AS Date), N'Nam', N'Nhân Viên Khu Trò Chơi Dân Gian', N'k06       ', N'pb02      ', 15000000, 11)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv38      ', N'Nguyễn Huỳnh Thanh Hiền', CAST(0xF01B0B00 AS Date), N'Nữ', N'Nhân Viên Khu Đu Quay', N'k07       ', N'pb02      ', 16000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv39      ', N'Huỳnh Khánh Duy', CAST(0x0F1C0B00 AS Date), N'Nam', N'Nhân Viên Khu Đu Quay', N'k07       ', N'pb02      ', 15000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv40      ', N'Nguyễn Đình Đức', CAST(0x131C0B00 AS Date), N'Nam', N'Nhân Viên Khu Đu Quay', N'k07       ', N'pb02      ', 15000000, 3)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv41      ', N'Lê Nguyễn Kim Ngọc', CAST(0x39190B00 AS Date), N'Nữ', N'Nhân Viên Khu Cầu Trượt', N'k08       ', N'pb02      ', 15000000, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv42      ', N'Ngô Nguyệt An', CAST(0x16190B00 AS Date), N'Nữ', N'Nhân Viên Khu Cầu Trượt', N'k08       ', N'pb02      ', 14000000, 5)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv43      ', N'Ngô Kim Dung', CAST(0x64190B00 AS Date), N'Nữ', N'Nhân Viên Khu Cầu Trượt', N'k08       ', N'pb02      ', 14000000, 6)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv44      ', N'Tạ Ngọc Sơn', CAST(0x69190B00 AS Date), N'Nữ', N'Nhân Viên Khu Nhà Hơi', N'k03       ', N'pb01      ', 13000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv45      ', N'Lê Thị Thùy Liên', CAST(0xE9180B00 AS Date), N'Nữ', N'Nhân Viên Khu Nhà Hơi', N'k09       ', N'pb02      ', 12000000, 8)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv46      ', N'Trần Châu Bảo Ngọc', CAST(0xA7180B00 AS Date), N'Nữ', N'Nhân Viên Khu Thể Thao', N'k10       ', N'pb02      ', 14000000, 9)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv47      ', N'Nguyễn Mai Lê', CAST(0x91190B00 AS Date), N'Nữ', N'Nhân Viên Khu Thể Thao', N'k10       ', N'pb02      ', 13000000, 10)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv48      ', N'Võ Việt Hải', CAST(0xA0190B00 AS Date), N'Nam', N'Nhân Viên Khu Thể Thao', N'k10       ', N'pb02      ', 13000000, 11)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv49      ', N'Lục Kim Ngọc', CAST(0xD9180B00 AS Date), N'Nam', N'Nhân Viên Khu Thể Thao', N'k10       ', N'pb02      ', 13000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv50      ', N'Hoàng Thi Hằng', CAST(0xFB1F0B00 AS Date), N'Nữ', N'Trưởng Phòng Tài Chính', NULL, N'pb03      ', 21000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv51      ', N'Ngô Hồng Nhung', CAST(0x711E0B00 AS Date), N'Nữ', N'Nhân Viên Tài Chính', NULL, N'pb03      ', 21000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv52      ', N'Lê Hồng Phúc', CAST(0x561E0B00 AS Date), N'Nữ', N'Nhân Viên Tài Chính', NULL, N'pb03      ', 21000000, 3)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv53      ', N'Lu Kim Hoà', CAST(0x581E0B00 AS Date), N'Nữ', N'Nhân Viên Tài Chính', NULL, N'pb03      ', 21000000, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv54      ', N'Huỳnh Phạm Ngọc Thả', CAST(0xC61F0B00 AS Date), N'Nữ', N'Nhân Viên Tài Chính', NULL, N'pb03      ', 21000000, 5)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv55      ', N'Thạch Thùy Chinh', CAST(0xCC1F0B00 AS Date), N'Nữ', N'Trưởng Phòng Quản Lý Dự Án', NULL, N'pb04      ', 21000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv56      ', N'Cai Huỳnh Trúc Vy', CAST(0xE51F0B00 AS Date), N'Nữ', N'Nhân Viên Phòng Quản Lý Dự Án', NULL, N'pb04      ', 21000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv57      ', N'Phan Hữu Sơn', CAST(0xE51C0B00 AS Date), N'Nam', N'Nhân Viên Phòng Quản Lý Dự Án', NULL, N'pb04      ', 21000000, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv58      ', N'Nhâm Bá Duy ', CAST(0x331E0B00 AS Date), N'Nam', N'Nhân Viên Phòng Quản Lý Dự Án', NULL, N'pb04      ', 21000000, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv59      ', N'Nguyễn Hữu Bảo', CAST(0x421E0B00 AS Date), N'Nam', N'Nhân Viên Phòng Quản Lý Dự Án', NULL, N'pb04      ', 21000000, 3)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv60      ', N'Nguyễn Ngọc Ánh', CAST(0x1D210B00 AS Date), N'Nữ', N'Trưởng Phòng Quản Lý Nhân Sự', N'k03       ', N'pb01      ', 18000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv61      ', N'Hồ Thanh Tùng', CAST(0xF4200B00 AS Date), N'Nam', N'Nhân Viên Phòng Quản Lý Nhân Sự', NULL, N'pb05      ', 18000000, 12)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv62      ', N'Phạm Minh Long', CAST(0xFA200B00 AS Date), N'Nam', N'Nhân Viên Phòng Quản Lý Nhân Sự', NULL, N'pb05      ', 18000000, 5)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv63      ', N'Ngô Thị Dung', CAST(0x18210B00 AS Date), N'Nữ', N'Nhân Viên Phòng Quản Lý Nhân Sự', NULL, N'pb05      ', 18000000, 12)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv64      ', N'Phí Minh Hoàng', CAST(0xAB1F0B00 AS Date), N'Nam', N'Nhân Viên Phòng Quản Lý Nhân Sự', NULL, N'pb05      ', 18000000, 5)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv65      ', N'Nguyễn Bá Quân', CAST(0x631B0B00 AS Date), N'Nam', N'Trưởng Phòng Kế Toán', NULL, N'pb06      ', 25000000, 7)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv66      ', N'Ngô Thanh Hoàng', CAST(0x151A0B00 AS Date), N'Nam', N'Nhân Viên Kế Toán', NULL, N'pb06      ', 25000000, 3)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv67      ', N'Hồ Thị Hạnh', CAST(0x781B0B00 AS Date), N'Nữ', N'Nhân Viên Kế Toán', NULL, N'pb06      ', 24000000, 5)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv68      ', N'Đào Duy Tùng', CAST(0x521E0B00 AS Date), N'Nam', N'Nhân Viên Kế Toán', NULL, N'pb06      ', 25000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv69      ', N'Hoàng Mai Hương', CAST(0x521E0B00 AS Date), N'Nữ', N'Nhân Viên Kế Toán', NULL, N'pb06      ', 25000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv70      ', N'Hoàng Thùy Linh', CAST(0x9D180B00 AS Date), N'Nữ', N'Trưởng Phòng Tạp Vụ', NULL, N'pb07      ', 14000000, 8)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv71      ', N'Ngô Thị Lam', CAST(0x16190B00 AS Date), N'Nữ', N'Nhân Viên Tạp Vụ', NULL, N'pb07      ', 14000000, 7)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv72      ', N'Nguyễn Thị Hồng', CAST(0x21190B00 AS Date), N'Nữ', N'Nhân Viên Tạp Vụ', NULL, N'pb07      ', 14000000, 5)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv73      ', N'Nguyễn Thị Thanh', CAST(0x21190B00 AS Date), N'Nữ', N'Nhân Viên Tạp Vụ', NULL, N'pb07      ', 14000000, 3)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv74      ', N'Nguyễn Kim Lys', CAST(0xA7180B00 AS Date), N'Nữ', N'Nhân Viên Tạp Vụ', NULL, N'pb07      ', 14000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv75      ', N'Nguyễn Xuân Trường', CAST(0xB9200B00 AS Date), N'Nam', N'Trưởng Phòng Bảo Vệ', NULL, N'pb08      ', 15000000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv76      ', N'Phạm Văn Thành', CAST(0xC61F0B00 AS Date), N'Nam', N'Nhân Viên Bảo Vệ', NULL, N'pb08      ', 15000000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv77      ', N'Dương Hải Quân', CAST(0x25210B00 AS Date), N'Nam', N'Nhân Viên Bảo Vệ', NULL, N'pb08      ', 15000000, 5)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv78      ', N'Hoàng Văn Nam', CAST(0x18210B00 AS Date), N'Nam', N'Nhân Viên Bảo Vệ', NULL, N'pb08      ', 16000000, 6)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv79      ', N'Nguyễn Hoàng An', CAST(0xFE1F0B00 AS Date), N'Nữ', N'Nhân Viên', N'k01       ', N'pb02      ', 1600000, 10)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [ViTriPhuTrach], [MaKhuPhuTrach], [MaPB], [Luong], [QueQuan]) VALUES (N'nv80      ', N'bbbbbbbb', CAST(0xFE1F0B00 AS Date), N'Nữ', N'Nhân Viên', N'k01       ', N'pb02      ', 1600000, 10)
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen]) VALUES (1, N'Admin     ')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen]) VALUES (2, N'Nhân Viên ')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNC], [DiaDiem]) VALUES (N'pb01      ', N'Phòng Hành Chính', N'nv02      ', CAST(0xBA3D0B00 AS Date), N'Hà Nội')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNC], [DiaDiem]) VALUES (N'pb02      ', N'Phòng Quản Lý Khu Vực Vui Chơi', N'nv10      ', CAST(0xFB3A0B00 AS Date), N'Cầu Giấy - Hà Nội')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNC], [DiaDiem]) VALUES (N'pb03      ', N'Phòng Tài Chính', N'nv50      ', CAST(0x873C0B00 AS Date), N'Cầu Giấy - Hà Nội')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNC], [DiaDiem]) VALUES (N'pb04      ', N'Phòng Quản Lý Dự Án', N'nv55      ', CAST(0x493C0B00 AS Date), N'Đống Đa - Hà Nội')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNC], [DiaDiem]) VALUES (N'pb05      ', N'Phòng Quản Lý Nhân Sự', N'nv60      ', CAST(0xFE3A0B00 AS Date), N'Bắc Từ Liêm - Hà Nội')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNC], [DiaDiem]) VALUES (N'pb06      ', N'Phòng Kế Toán', N'nv65      ', CAST(0x033B0B00 AS Date), N'Cầu Giấy - Hà Nội')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNC], [DiaDiem]) VALUES (N'pb07      ', N'Phòng Tạp Vụ', N'nv70      ', CAST(0x033B0B00 AS Date), N'Cầu Giấy - Hà Nội')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNC], [DiaDiem]) VALUES (N'pb08      ', N'Phòng Bảo Vệ', N'nv75      ', CAST(0x6E390B00 AS Date), N'Cầu Giấy - Hà Nội')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (1, N'Hà Nội')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (2, N'Hồ Chí Minh')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (3, N'Hải Phòng')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (4, N'Đà Nẵng')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (5, N'Hà Giang')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (6, N'Cao Bằng')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (7, N'Lai Châu')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (8, N'Lào Cai')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (9, N'Tuyên Quang')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (10, N'Lạng Sơn')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (11, N'Bắc Kạn')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (12, N'Thái Nguyên')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (13, N'Yên Bái')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (14, N'Sơn La')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (15, N'Phú Thọ')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (16, N'Vĩnh Phúc')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (17, N'Quảng Ninh')
INSERT [dbo].[QueQuan] ([MaTinh], [TenTinh]) VALUES (18, N'Nam Định')
INSERT [dbo].[ThietBi] ([MaTB], [TenTB], [MaTroChoi], [TinhTrang]) VALUES (N'tb01      ', N'Bánh Tàu Lượn', N'tc03', N'Tốt')
INSERT [dbo].[ThietBi] ([MaTB], [TenTB], [MaTroChoi], [TinhTrang]) VALUES (N'tb02      ', N'Đường Ray Tàu Lượn', N'tc03', N'Tốt')
INSERT [dbo].[ThietBi] ([MaTB], [TenTB], [MaTroChoi], [TinhTrang]) VALUES (N'tb03      ', N'Xe Đua', N'tc04', N'Tốt')
INSERT [dbo].[ThietBi] ([MaTB], [TenTB], [MaTroChoi], [TinhTrang]) VALUES (N'tb05      ', N'Máy Điện Tử Bắn Súng', N'tc21', N'Tốt')
INSERT [dbo].[ThietBi] ([MaTB], [TenTB], [MaTroChoi], [TinhTrang]) VALUES (N'tb06      ', N'Trực Thăng Xoay', N'tc28', N'Tốt')
INSERT [dbo].[ThietBi] ([MaTB], [TenTB], [MaTroChoi], [TinhTrang]) VALUES (N'tb07      ', N'Cầu Trượt Đơn', N'tc30', N'Tốt')
INSERT [dbo].[ThietBi] ([MaTB], [TenTB], [MaTroChoi], [TinhTrang]) VALUES (N'tb08      ', N'Nhà Hơi', N'tc33', N'Tốt')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc03', N'Tàu Lượn Siêu Tốc', N'nv14      ', 20, N'k02       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc04', N'Đua Xe Thể Thức 1', N'nv15      ', 20, N'k02       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc05', N'Tàu Hòa Bình', N'nv15      ', 15, N'k02       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc06', N'Con Tàu Lốc Xoáy', N'nv15      ', 20, N'k02       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc07', N'Vượt Thác', N'nv18      ', 20, N'k02       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc08', N'Thám Hiểm Bầu Trời', N'nv19      ', 15, N'k02       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc09', N'Vòng Xoay Vũ Trụ', N'nv20      ', 25, N'k02       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc10', N'Đụng Xe Hơi', N'nv21      ', 20, N'k03       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc11', N'Đoàn Xe Leo Dốc', N'nv22      ', 20, N'k03       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc12', N'Lái Xe Cỡ Nhỏ', N'nv23      ', 15, N'k03       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc13', N'Đua Xe Mini', N'nv24      ', 15, N'k03       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc14', N'Đoàn Tàu Hỏa', N'nv25      ', 15, N'k03       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc15', N'Rạp Chiếu Phim Thường', N'nv26      ', 50, N'k04       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc16', N'Rạp Phim 6D', N'nv27      ', 6, N'k04       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc17', N'Rạp Phim 8D', N'nv28      ', 6, N'k04       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc18', N'Rạp Phim 9D', N'nv29      ', 6, N'k04       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc19', N'Đua Xe Máy Giả Lập', N'nv30      ', 10, N'k05       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc20', N'Bắn Cá ', N'nv31      ', 10, N'k05       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc21', N'Bắn Súng 3D', N'nv32      ', 10, N'k05       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc22', N'Bịt Mắt Đập Ấm', N'nv33      ', 5, N'k06       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc23', N'Bịt Mắt Bắt Dê', N'nv34      ', 10, N'k06       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc24', N'Rồng Rắn Lên Mây', NULL, 10, N'k06       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc25', N'Mèo Đuổi Chuột', N'nv36      ', 10, N'k06       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc26', N'Kéo Co', N'nv37      ', 20, N'k06       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc27', N'Cưỡi Thú', N'nv38      ', 20, N'k06       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc28', N'Trực Thăng Bay', N'nv39      ', 20, N'k06       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc29', N'Đu Dây Trượt', N'nv40      ', 15, N'k07       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc30', N'Cầu Trượt Đơn', N'nv41      ', 15, N'k08       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc31', N'Cầu Trượt PanDa siêu hạng', N'nv42      ', 15, N'k08       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc32', N'Cầu Ốc', N'nv43      ', 15, N'k08       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc33', N'Nhà Hơi Nhún', N'nv44      ', 20, N'k09       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc34', N'Thú Hơi Nhún', N'nv45      ', 20, N'k09       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc35', N'Đá Bóng Trong Nhà', N'nv46      ', 30, N'k10       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc36', N'Bóng Rổ', N'nv47      ', 30, N'k10       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc37', N'Cầu Lông', N'nv48      ', 20, N'k10       ')
INSERT [dbo].[TroChoi] ([MaTroChoi], [TenTroChoi], [MaNVPhuTrach], [SoLuongNC_Max], [MaKhu]) VALUES (N'tc38', N'Bóng Bàn', NULL, 20, N'k10       ')
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv01      ', N'kh01      ', N'k01       ', 1, 1, CAST(0x103E0B00 AS Date), 300000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv02      ', N'kh02      ', N'k02       ', 1, 1, CAST(0x103E0B00 AS Date), 300000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv03      ', N'kh03      ', N'k03       ', 1, 1, CAST(0x103E0B00 AS Date), 300000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv04      ', N'kh04      ', N'k04       ', 1, 1, CAST(0x103E0B00 AS Date), 300000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv05      ', N'kh05      ', N'k05       ', 1, 1, CAST(0x103E0B00 AS Date), 300000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv06      ', N'kh06      ', N'k06       ', 1, 1, CAST(0x103E0B00 AS Date), 300000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv07      ', N'kh07      ', N'k07       ', 1, 1, CAST(0x103E0B00 AS Date), 300000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv08      ', N'kh08      ', N'k08       ', 1, 1, CAST(0x103E0B00 AS Date), 300000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv09      ', N'kh09      ', N'k09       ', 1, 1, CAST(0x103E0B00 AS Date), 300000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv10      ', N'kh10      ', N'k01       ', 2, 3, CAST(0x233E0B00 AS Date), 700000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv11      ', N'kh11      ', N'k05       ', 2, 5, CAST(0x243E0B00 AS Date), 900000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv12      ', N'kh11      ', N'k07       ', 2, 5, CAST(0x243E0B00 AS Date), 900000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv13      ', N'kh12      ', N'k01       ', 2, 4, CAST(0x243E0B00 AS Date), 800000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv14      ', N'kh12      ', N'k08       ', 1, 4, CAST(0x243E0B00 AS Date), 600000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv15      ', N'kh01      ', N'k06       ', 3, 4, CAST(0x243E0B00 AS Date), 1000000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv16      ', N'kh02      ', N'k06       ', 3, 4, CAST(0xCA3D0B00 AS Date), 1000000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv17      ', N'kh02      ', N'k06       ', 3, 4, CAST(0xE93D0B00 AS Date), 1000000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv18      ', N'kh02      ', N'k06       ', 3, 4, CAST(0x053E0B00 AS Date), 1000000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv19      ', N'kh02      ', N'k06       ', 3, 4, CAST(0xB73C0B00 AS Date), 1000000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv20      ', N'kh02      ', N'k06       ', 3, 4, CAST(0x5D3C0B00 AS Date), 1000000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv21      ', N'kh03      ', N'k07       ', 2, 5, CAST(0xE93D0B00 AS Date), 900000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv22      ', N'kh03      ', N'k07       ', 2, 5, CAST(0xE93D0B00 AS Date), 900000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv23      ', N'kh01      ', N'k01       ', 4, 5, CAST(0x263E0B00 AS Date), 1300000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv24      ', N'kh13      ', N'k04       ', 2, 4, CAST(0x263E0B00 AS Date), 800000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv25      ', N'kh01      ', N'k04       ', 5, 4, CAST(0x2B3E0B00 AS Date), 1400000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv26      ', N'kh14      ', N'k07       ', 2, 2, CAST(0x2B3E0B00 AS Date), 600000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv27      ', N'kh15      ', N'k08       ', 2, 2, CAST(0x2B3E0B00 AS Date), 600000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv28      ', N'kh16      ', N'k02       ', 5, 16, CAST(0x2B3E0B00 AS Date), 2600000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv29      ', N'kh16      ', N'k09       ', 2, 3, CAST(0x2B3E0B00 AS Date), 700000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv30      ', N'kh16      ', N'k03       ', 2, 3, CAST(0x2B3E0B00 AS Date), 700000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv32      ', N'kh12      ', N'k02       ', 3, 10, CAST(0x2B3E0B00 AS Date), 3200000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv33      ', N'kh04      ', N'k03       ', 1, 10, CAST(0x2C3E0B00 AS Date), 1200000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv34      ', N'kh01      ', N'k03       ', 1, 7, CAST(0x2C3E0B00 AS Date), 900000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv35      ', NULL, N'k03       ', 1, 7, CAST(0x2C3E0B00 AS Date), 900000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv36      ', N'kh03      ', N'k01       ', 1, 3, CAST(0x2F3E0B00 AS Date), 500000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv37      ', N'kh03      ', N'k02       ', 1, 4, CAST(0x2F3E0B00 AS Date), 1200000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv38      ', N'kh04      ', N'k05       ', 2, 2, CAST(0x303E0B00 AS Date), 600000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv39      ', N'kh17      ', N'k02       ', 2, 3, CAST(0x363E0B00 AS Date), 1400000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv40      ', N'kh17      ', N'k02       ', 3, 5, CAST(0x363E0B00 AS Date), 2200000)
INSERT [dbo].[Ve] ([MaVe], [MaKH], [MaKhu], [SoLuongNguoiLon], [SoLuongTreEm], [NgayBan], [ThanhTien]) VALUES (N'mv41      ', N'kh05      ', N'k04       ', 4, 6, CAST(0x363E0B00 AS Date), 1400000)
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_DichVu]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD  CONSTRAINT [FK_DichVu_KhuTroChoi] FOREIGN KEY([MaKhu])
REFERENCES [dbo].[KhuTroChoi] ([MaKhu])
GO
ALTER TABLE [dbo].[DichVu] CHECK CONSTRAINT [FK_DichVu_KhuTroChoi]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [HD_KH_FK] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [HD_KH_FK]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_PhanQuyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_PhanQuyen]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_KhuTroChoi] FOREIGN KEY([MaKhuPhuTrach])
REFERENCES [dbo].[KhuTroChoi] ([MaKhu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_KhuTroChoi]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_KhuTroChoi1] FOREIGN KEY([MaKhuPhuTrach])
REFERENCES [dbo].[KhuTroChoi] ([MaKhu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_KhuTroChoi1]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_QueQuan] FOREIGN KEY([QueQuan])
REFERENCES [dbo].[QueQuan] ([MaTinh])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_QueQuan]
GO
ALTER TABLE [dbo].[PhongBan]  WITH CHECK ADD  CONSTRAINT [FK_PhongBan_NhanVien] FOREIGN KEY([MaTP])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhongBan] CHECK CONSTRAINT [FK_PhongBan_NhanVien]
GO
ALTER TABLE [dbo].[ThietBi]  WITH CHECK ADD  CONSTRAINT [FK_ThietBi_TroChoi1] FOREIGN KEY([MaTroChoi])
REFERENCES [dbo].[TroChoi] ([MaTroChoi])
GO
ALTER TABLE [dbo].[ThietBi] CHECK CONSTRAINT [FK_ThietBi_TroChoi1]
GO
ALTER TABLE [dbo].[TroChoi]  WITH CHECK ADD  CONSTRAINT [FK_TroChoi_KhuTroChoi] FOREIGN KEY([MaKhu])
REFERENCES [dbo].[KhuTroChoi] ([MaKhu])
GO
ALTER TABLE [dbo].[TroChoi] CHECK CONSTRAINT [FK_TroChoi_KhuTroChoi]
GO
ALTER TABLE [dbo].[TroChoi]  WITH CHECK ADD  CONSTRAINT [FK_TroChoi_NhanVien1] FOREIGN KEY([MaNVPhuTrach])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TroChoi] CHECK CONSTRAINT [FK_TroChoi_NhanVien1]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_KhachHang1] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_KhachHang1]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_KhuTroChoi] FOREIGN KEY([MaKhu])
REFERENCES [dbo].[KhuTroChoi] ([MaKhu])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_KhuTroChoi]
GO
USE [master]
GO
ALTER DATABASE [KhuVuiChoi] SET  READ_WRITE 
GO
