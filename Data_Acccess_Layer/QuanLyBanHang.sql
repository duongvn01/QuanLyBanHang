use master
go
create database QuanLyBanHang
go
use QuanLyBanHang
go
--drop table KhuVuc
create table KhuVuc
(
	MaKhuVuc varchar(10) primary key,
	TenKhuVuc nvarchar(30) not null,
	GhiChu nvarchar(50),
	ConQuanLy bit
)
go
create table KhachHang
(
	SiOrLe int,--1. dai ly, 2. khach le

	MaKhachHang varchar(15) primary key,
	MaKhuVuc varchar(10) not null,
	TenKhachHang nvarchar(50) not null,
	DiaChi nvarchar(100),
	MaSoThue varchar(15),
	Fax varchar(15),
	SoDienThoai varchar(12),
	SoDiDong varchar(12),
	Email varchar(30),
	Website varchar(100),

	TaiKhoan varchar(15),
	NganHang varchar(20),
	GioiHanNo money,
	NoHienTai money,
	ChietKhau float,
	NguoiLienHe nvarchar(50),
	
	ThongTinKhac nvarchar(100)
)

go
create table NhaCungCap
(
	MaNhaCungCap varchar(15) primary key,
	TenNhaCungCap nvarchar(100) not null,
	MaKhuVuc varchar(10) not null,
	DiaChi nvarchar(100),
	MaSoThue varchar(15),
	Fax varchar(15),
	SoDienThoai varchar(12),
	SoDiDong varchar(12),
	Email varchar(30),
	Website varchar(100),

	TaiKhoan varchar(15),
	NganHang varchar(20),
	GioiHanNo money,
	NoHienTai money,
	ChietKhau float,
	NguoiLienHe nvarchar(50),
	ChucVu nvarchar(50),
	
	ThongTinKhac nvarchar(100),
	ConQuanLy int
)
go
create table Kho
(
	MaKho varchar(15) primary key,
	TenKho nvarchar(50) not null,
	MaNguoiQuanLy varchar(15),

	KyHieu varchar(15),
	NguoiLienHe nvarchar(50),
	DiaChi nvarchar(100),
	Fax varchar(15),
	SoDienThoai varchar(12),
	Email varchar(30),	
	DienGiai nvarchar(50),

	ConQuanLy bit
)
go
create table DonVi
(
	MaDonVi varchar(15),
	TenDonVi nvarchar(30),
	GhiChu nvarchar(50),
	ConQuanLy bit
)
go
create table NhomHang
(
	MaNhomHang varchar(15),
	TenNhomHang nvarchar(30),
	GhiChu nvarchar(50),
	ConQuanLy bit
)
go
create table HangHoa
(
	HangHoaOrDichVu bit,--1. hang hoa, 2. dich vu
	MaKho varchar(15) not null,
	MaNhomHang varchar(15) not null,
	
	MaHangHoa varchar(15) primary key,
	TenHangHoa nvarchar(50) not null,
	MaVachNSX varchar(30),
	MaDonVi varchar(15),--DonViGoc(phan mem)
	XuatXu nvarchar(30),
	Thue float,
	TonKhoToiThieu int,
	TonHienTai int,
	MaNhaCungCap varchar(15),
	GiaMua money,
	GiaBanSi money,
	GiaBanLe money,
	ConQuanLy bit
)
go 
create table BoPhan
(
	MaBoPhan varchar(10) primary key,
	TenBoPhan nvarchar(50) not null,
	GhiChu nvarchar(50),
	ConQuanLy int
)
go

create table NhanVien
(

	MaNhanVien varchar(15) primary key,
	TenNhanVien nvarchar(50) not null,
	ChucVu nvarchar(30),
	DiaChi nvarchar(100),	
	SoDienThoai varchar(12),
	SoDiDong varchar(12),
	Email varchar(30),

	--DienGiai nvarchar(50),
	MaBoPhan varchar(10) not null,
	MaNguoiQuanLy varchar(15)
)

go
---------------------------Stored Procedures------------------------------------------------------------------------
--Them Khu Vuc

create procedure proThemKhuVuc
@MaKhuVuc nvarchar(10),
@TenKhuVuc nvarchar(30),
@GhiChu nvarchar(50),
@ConQuanLy bit
as
begin  
   insert into KhuVuc values(@MaKhuVuc,@TenKhuVuc,@GhiChu,@ConQuanLy);
end

go
--Them Khach Hang
Create procedure proThemKhachHang
	@SiOrLe int,
	@MaKhachHang varchar(15),
	@MaKhuVuc varchar(10),
	@TenKhachHang nvarchar(50),
	@DiaChi nvarchar(100),
	@MaSoThue varchar(15),
	@Fax varchar(15),
	@SoDienThoai varchar(12),
	@SoDiDong varchar(12),
	@Email varchar(30),
	@Website varchar(100),

	@TaiKhoan varchar(15),
	@NganHang varchar(20),
	@GioiHanNo money,
	@NoHienTai money,
	@ChietKhau float,
	@NguoiLienHe nvarchar(50),
	
	@ThongTinKhac nvarchar(100),
	@ConQuanLy bit
as
begin
insert into KhachHang values(
	@SiOrLe,
	@MaKhachHang,
	@MaKhuVuc,
	@TenKhachHang,
	@DiaChi,
	@MaSoThue,
	@Fax,
	@SoDienThoai,
	@SoDiDong,
	@Email,
	@Website,

	@TaiKhoan,
	@NganHang,
	@GioiHanNo,
	@NoHienTai,
	@ChietKhau,
	@NguoiLienHe,
	
	@ThongTinKhac,
	@ConQuanLy)
end


go
--Them Nha Cung Cap
create procedure proThemNhaCungCap
	@MaNhaCungCap varchar(15),
	@TenNhaCungCap nvarchar(100),
	@MaKhuVuc varchar(10),
	@DiaChi nvarchar(100),
	@MaSoThue varchar(15),
	@Fax varchar(15),
	@SoDienThoai varchar(12),
	@SoDiDong varchar(12),
	@Email varchar(30),
	@Website varchar(100),

	@TaiKhoan varchar(15),
	@NganHang varchar(20),
	@GioiHanNo money,
	@NoHienTai money,
	@ChietKhau float,
	@NguoiLienHe nvarchar(50),
	@ChucVu nvarchar(50),
	
	@ThongTinKhac nvarchar(100),
	@ConQuanLy bit
as
begin
	insert into NhaCungCap values(
	@MaNhaCungCap,
	@TenNhaCungCap,
	@MaKhuVuc,
	@DiaChi,
	@MaSoThue,
	@Fax,
	@SoDienThoai,
	@SoDiDong,
	@Email,
	@Website,

	@TaiKhoan,
	@NganHang,
	@GioiHanNo,
	@NoHienTai,
	@ChietKhau,
	@NguoiLienHe,
	@ChucVu,
	
	@ThongTinKhac,
	@ConQuanLy
	)
end

--them kho
create procedure [dbo].[proThemKho]
	@MaKho varchar(15),
	@TenKho nvarchar(50),
	@MaNguoiQuanLy varchar(15),
	@KyHieu varchar(15),
	@NguoiLienHe nvarchar(50),
	@DiaChi nvarchar(100),
	@Fax varchar(15),
	@SoDienThoai varchar(12),
	@Email varchar(30),	
	
	@DienGiai nvarchar(50),
	@ConQuanLy bit
as
begin
	insert into Kho values(
	@MaKho,
	@TenKho,
	@MaNguoiQuanLy,
	@KyHieu,
	@NguoiLienHe,
	@DiaChi,
	@Fax,
	@SoDienThoai,
	@Email,
	
	@DienGiai,
	@ConQuanLy
	)
end


go
--lay bang kho va nhan vien(lay cho gridviewKhoHang)
create procedure proGetKhoNhanVien
as
select MaKho,TenKho,TenNhanVien as TenQuanLy,KyHieu,NguoiLienHe,Kho.DiaChi,Fax,Kho.SoDienThoai,Kho.Email,DienGiai,ConQuanLy
from Kho,NhanVien
where Kho.MaNguoiQuanLy = NhanVien.MaNhanVien
--Them don vi
create procedure proThemDonVi
	@MaDonVi varchar(15),
	@TenDonVi nvarchar(30),
	@GhiChu nvarchar(50),
	@ConQuanLy bit
as
begin
	insert into DonVi values(
	@MaDonVi,
	@TenDonVi,
	@GhiChu,
	@ConQuanLy
	)
end

--Them Nhom Hang
create procedure proThemNhomHang
	@MaNhomHang varchar(15),
	@TenNhomHang nvarchar(30),
	@GhiChu nvarchar(50),
	@ConQuanLy bit
as
begin
	insert into NhomHang values(
	@MaNhomHang,
	@TenNhomHang,
	@GhiChu,
	@ConQuanLy
	)
end


go
--Them hang hoa
create procedure proThemHangHoa
	@HangHoaOrDichVu bit,--1. hang hoa, 0. dich vu
	@MaNhomHang varchar(15),
	@MaHangHoa varchar(15),
	@TenHangHoa nvarchar(50),
	@MaVachNSX varchar(30),
	@MaDonVi varchar(15),--DonViGoc(phan mem)
	@XuatXu nvarchar(30),
	@Thue float,
	@TonKhoToiThieu int,
	@TonHienTai int,
	@MaNhaCungCap varchar(15),
	@GiaMua money,
	@GiaBanSi money,
	@GiaBanLe money
as
begin
	insert into HangHoa values(
	@HangHoaOrDichVu,--1. hang hoa, 2. dich vu
	@MaNhomHang,
	@MaHangHoa,
	@TenHangHoa,
	@MaVachNSX,
	@MaDonVi,--DonViGoc(phan mem)
	@XuatXu,
	@Thue,
	@TonKhoToiThieu,
	@TonHienTai,
	@MaNhaCungCap,
	@GiaMua,
	@GiaBanSi,
	@GiaBanLe
	)
end

go
--Them Bo Phan
create procedure proThemBoPhan
	@MaBoPhan varchar(10),
	@TenBoPhan nvarchar(50),
	@GhiChu nvarchar(50),
	@ConQuanLy bit
as
begin
	insert into BoPhan values(
	@MaBoPhan,
	@TenBoPhan,
	@GhiChu,
	@ConQuanLy
	)
end


go
--Them Nhan Vien
create procedure proThemNhanVien
	@MaNhanVien varchar(15),
	@TenNhanVien nvarchar(50),
	@ChucVu nvarchar(30),
	@DiaChi nvarchar(100),	
	@SoDienThoai varchar(12),
	@SoDiDong varchar(12),
	@Email varchar(30),

	@MaBoPhan varchar(10),
	@MaNguoiQuanLy varchar(15),
	@ConQuanLy bit
as
begin
	insert into NhanVien values(
	@MaNhanVien,
	@TenNhanVien,
	@ChucVu,
	@DiaChi,	
	@SoDienThoai,
	@SoDiDong,
	@Email,

	@MaBoPhan,
	@MaNguoiQuanLy,
	@ConQuanLy
	)
end

go
----------------------------------------Procedure Sua-----------------------------------------
--Sua Khu Vuc
create procedure proSuaKhuVuc
@MaKhuVuc nvarchar(10),
@TenKhuVuc nvarchar(30),
@GhiChu nvarchar(50),
@ConQuanLy int
as
begin
	update KhuVuc set
	MaKhuVuc=@MaKhuVuc,
	TenKhuVuc=@TenKhuVuc,
	GhiChu=@Ghichu,
	ConQuanLy=@ConQuanLy
	where MaKhuVuc=@MaKhuVuc
end

go
--Sua khach hang
create procedure proSuaKhachHang
	@SiOrLe int,
	@MaKhachHang varchar(15),
	@MaKhuVuc varchar(10),
	@TenKhachHang nvarchar(50),
	@DiaChi nvarchar(100),
	@MaSoThue varchar(15),
	@Fax varchar(15),
	@SoDienThoai varchar(12),
	@SoDiDong varchar(12),
	@Email varchar(30),
	@Website varchar(100),

	@TaiKhoan varchar(15),
	@NganHang varchar(20),
	@GioiHanNo money,
	@NoHienTai money,
	@ChietKhau float,
	@NguoiLienHe nvarchar(50),
	
	@ThongTinKhac nvarchar(100),
	@ConQuanLy bit
as
begin
	update KhachHang set
	SiOrLe= @SiOrLe,
	MaKhachHang=@MaKhachHang,
	MaKhuVuc=@MaKhuVuc,
	TenKhachHang=@TenKhachHang,
	DiaChi=@DiaChi,
	MaSoThue=@MaSoThue,
	Fax=@Fax,
	SoDienThoai=@SoDienThoai,
	SoDiDong=@SoDiDong,
	Email=@Email,
	Website=@Website,

	TaiKhoan=@TaiKhoan,
	NganHang=@NganHang,
	GioiHanNo=@GioiHanNo,
	NoHienTai=@NoHienTai,
	ChietKhau=@ChietKhau,
	NguoiLienHe=@NguoiLienHe,
	
	ThongTinKhac=@ThongTinKhac,
	ConQuanLy=@ConQuanLy
	where MaKhachHang=@MaKhachHang
end

go
--sua nha cung cap
create procedure proSuaNhaCungCap
	@MaNhaCungCap varchar(15),
	@TenNhaCungCap nvarchar(100),
	@MaKhuVuc varchar(10),
	@DiaChi nvarchar(100),
	@MaSoThue varchar(15),
	@Fax varchar(15),
	@SoDienThoai varchar(12),
	@SoDiDong varchar(12),
	@Email varchar(30),
	@Website varchar(100),

	@TaiKhoan varchar(15),
	@NganHang varchar(20),
	@GioiHanNo money,
	@NoHienTai money,
	@ChietKhau float,
	@NguoiLienHe nvarchar(50),
	@ChucVu nvarchar(50),
	
	@ThongTinKhac nvarchar(100),
	@ConQuanLy int
as
begin
	update NhaCungCap set
	MaNhaCungCap=@MaNhaCungCap,
	TenNhaCungCap=@TenNhaCungCap,
	MaKhuVuc=@MaKhuVuc,
	DiaChi=@DiaChi,
	MaSoThue=@MaSoThue,
	Fax=@Fax,
	SoDienThoai=@SoDienThoai,
	SoDiDong=@SoDiDong,
	Email=@Email,
	Website=@Website,

	TaiKhoan=@TaiKhoan,
	NganHang=@NganHang,
	GioiHanNo=@GioiHanNo,
	NoHienTai=@NoHienTai,
	ChietKhau=@ChietKhau,
	NguoiLienHe=@NguoiLienHe,
	ChucVu=@ChucVu,
	
	ThongTinKhac=@ThongTinKhac,
	ConQuanLy=@ConQuanLy
	where MaNhaCungCap=@MaNhaCungCap
end

go
-- Sua Kho
create procedure [dbo].[proSuaKho]
	@MaKho varchar(15),
	@TenKho nvarchar(50),
	@MaNguoiQuanLy varchar(15),
	@KyHieu varchar(15),
	@NguoiLienHe nvarchar(50),
	@DiaChi nvarchar(100),
	@Fax varchar(15),
	@SoDienThoai varchar(12),
	@Email varchar(30),	
	
	@DienGiai nvarchar(50),
	@ConQuanLy bit
as
begin
	update Kho set
	MaKho=@MaKho,
	TenKho=@TenKho,
	MaNguoiQuanLy=@MaNguoiQuanLy,
	KyHieu=@KyHieu,
	NguoiLienHe=@NguoiLienHe,
	DiaChi=@DiaChi,
	Fax=@Fax,
	SoDienThoai=@SoDienThoai,
	Email=@Email,
	DienGiai=@DienGiai,
	ConQuanLy=@ConQuanLy
	where MaKho=@MaKho
end

go
--Sua Don Vi
create procedure proSuaDonVi
	@MaDonVi varchar(15),
	@TenDonVi nvarchar(30),
	@GhiChu nvarchar(50),
	@ConQuanLy int
as
begin
	update DonVi set
	MaDonVi=@MaDonVi,
	TenDonVi=@TenDonVi,
	GhiChu=@GhiChu,
	ConQuanLy=@ConQuanLy
	where MaDonVi=@MaDonVi
end

go
-- Sua Nhom Hang
create procedure proSuaNhomHang
	@MaNhomHang varchar(15),
	@TenNhomHang nvarchar(30),
	@GhiChu nvarchar(50),
	@ConQuanLy int
as
begin
	update NhomHang set
	MaNhomHang=@MaNhomHang,
	TenNhomHang=@TenNhomHang,
	GhiChu=@GhiChu,
	ConQuanLy=@ConQuanLy
	where MaNhomHang=@MaNhomHang
end


go
--Sua hang hoa
create procedure proSuaHangHoa
	@HangHoaOrDichVu int,--1. hang hoa, 2. dich vu
	@MaNhomHang varchar(15),
	@MaHangHoa varchar(15),
	@TenHangHoa nvarchar(50),
	@MaVachNSX varchar(30),
	@MaDonVi varchar(15),--DonViGoc(phan mem)
	@XuatXu nvarchar(30),
	@Thue float,
	@TonKhoToiThieu int,
	@TonHienTai int,
	@MaNhaCungCap varchar(15),
	@GiaMua money,
	@GiaBanSi money,
	@GiaBanLe money
as
begin
	update HangHoa set
	HangHoaOrDichVu=@HangHoaOrDichVu,--1. hang hoa, 2. dich vu
	@MaNhomHang=@MaNhomHang,
	MaHangHoa=@MaHangHoa,
	TenHangHoa=@TenHangHoa,
	MaVachNSX=@MaVachNSX,
	MaDonVi=@MaDonVi,--DonViGoc(phan mem)
	XuatXu=@XuatXu,
	Thue=@Thue,
	TonKhoToiThieu=@TonKhoToiThieu,
	TonHienTai=@TonHienTai,
	MaNhaCungCap=@MaNhaCungCap,
	GiaMua=@GiaMua,
	GiaBanSi=@GiaBanSi,
	GiaBanLe=@GiaBanLe
	where  MaHangHoa=@MaHangHoa
end


go
--Sua Bo Phan
create procedure proSuaBoPhan
	@MaBoPhan varchar(10),
	@TenBoPhan nvarchar(50),
	@GhiChu nvarchar(50),
	@ConQuanLy int
as
begin
	update BoPhan set
	MaBoPhan=@MaBoPhan,
	TenBoPhan=@TenBoPhan,
	GhiChu=@GhiChu,
	ConQuanLy=@ConQuanLy
	where MaBoPhan=@MaBoPhan
end

go
--Sua Nhan Vien
create procedure proSuaNhanVien
	@MaNhanVien varchar(15),
	@TenNhanVien nvarchar(50),
	@ChucVu nvarchar(30),
	@DiaChi nvarchar(100),	
	@SoDienThoai varchar(12),
	@SoDiDong varchar(12),
	@Email varchar(30),
	@MaBoPhan varchar(10),
	@MaNguoiQuanLy varchar(15)
as
begin
	update NhanVien set
	MaNhanVien=@MaNhanVien,
	TenNhanVien=@TenNhanVien,
	ChucVu=@ChucVu,
	DiaChi=@DiaChi,	
	SoDienThoai=@SoDienThoai,
	SoDiDong=@SoDiDong,
	Email=@Email,
	MaBoPhan=@MaBoPhan,
	MaNguoiQuanLy=@MaNguoiQuanLy
	where MaNhanVien=@MaNhanVien
end


go
-------------------procedure xoa----------------------------------------------------------------------------------------------

--Xoa khu vuc
create procedure proXoaKhuVuc
@MaKhuVuc nvarchar(10)
as
begin
	delete from KhuVuc where MaKhuVuc=@MaKhuVuc
end


go
--Xoa Khach Hang
create procedure proXoaKhachHang
@MaKhachHang varchar(15)
as
begin
	delete from KhachHang where MaKhachHang=@MaKhachHang
end
--Xoa Nha Cung Cap
create procedure proXoaNhaCungCap
@MaNhaCungCap varchar(15)
as
begin
	delete from NhaCungCap where MaNhaCungCap=@MaNhaCungCap
end


go
--Xoa Kho
create procedure proXoaKho
@MaKho varchar(15)
as
begin
	delete from Kho where MaKho=@MaKho
end


go
--Xoa Don Vi
create procedure proXoaDonVi
@MaDonVi varchar(15)
as
begin
	delete from DonVi where MaDonVi=@MaDonVi
end


go
--Xoa Nhom Hang
create procedure proXoaNhomHang
@MaNhomHang varchar(15)
as
begin
	delete from NhomHang where MaNhomHang=@MaNhomHang
end

go
--Xoa hang hoa
create procedure proXoaHangHoa
@MaHangHoa varchar(15)
as
begin
	delete from HangHoa where MaHangHoa=@MaHangHoa
end

go
-- Xoa Bo Phan
create procedure proXoaBoPhan
@MaBoPhan varchar(10)
as
begin
	delete from BoPhan where MaBoPhan=@MaBoPhan
end

go
--Xoa Nhan Vien
create procedure proXoaNhanVien
@MaNhanVien varchar(15)
as
begin
	delete from NhanVien where MaNhanVien=@MaNhanVien
end


go
-- funtion sinh ma khu vuc
CREATE FUNCTION funDemMaKhuVuc()
RETURNS int AS 
BEGIN
	DECLARE @tong int; 
	SELECT @tong = count(MaKhuVuc) 
	FROM KhuVuc
	return @tong
END
