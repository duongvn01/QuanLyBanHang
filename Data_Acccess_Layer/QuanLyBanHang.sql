﻿use master
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
	
	ThongTinKhac nvarchar(100),
	ConQuanLy bit
)

go
drop table NhaCungCap
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
	ConQuanLy bit
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

	MaHangHoa varchar(15) primary key,
	TenHangHoa nvarchar(50) not null,
	MaKho varchar(15) not null,
	MaNhomHang varchar(15) not null,
	
	MaVachNSX varchar(30),
	MaDonVi varchar(15) not null,--DonViGoc(phan mem)
	
	XuatXu nvarchar(30),
	Thue float,
	TonKhoToiThieu int,
	TonHienTai int,

	MaNhaCungCap varchar(15) not null,
	GiaMua money,
	GiaBanSi money,
	GiaBanLe money,
	HangHoaOrDichVu int,--1. hang hoa, 2. dich vu
	ConQuanLy bit
)
go 
create table BoPhan
(
	MaBoPhan varchar(10) primary key,
	TenBoPhan nvarchar(50) not null,
	GhiChu nvarchar(50),
	ConQuanLy bit
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
	MaNguoiQuanLy varchar(15),
	ConQuanLy bit
)


go

create table MuaHang
(
	MaPhieu varchar(15)primary key,
	TenPhieu nvarchar(30),
	NgayLapPhieu date,
	SoHoaDonVAT varchar(20),
	SoPhieuVietTay varchar(20),
	MaThanhToan varchar(15),
	MaHinhThuc varchar(15),
	MaNhaCungCap varchar(15),
	ThoiHanThanhToan date,
	
	GhiChu nvarchar(50),

	MaNhanVien varchar(15),
	MaKho varchar(15),

	TongTien money,
	PTramCK int,
	Thue int,
	TuongDuongTien money,
	TienThanhToan money
)
go

drop table ChiTietPhieuMuaHang
create table  ChiTietPhieuMuaHang
(
	MaChiTietPhieu varchar(15) primary key,
	MaPhieu varchar(15) not null,
	MaHangHoa varchar(15) not null,
	SoLuong int,
	DonGia money,
	ThanhTien money
)
go

create table BanHang
(
	MaPhieuBan varchar(15)primary key,
	TenPhieu nvarchar(30),
	NgayLapPhieu date,
	MaThanhToan varchar(15),
	MaHinhThuc varchar(15),
	ThoiHanThanhToan date,

	MaKhachHang varchar(15),
	NgayGiaoHang date,

	MaNhanVien varchar(15),
	MaKho varchar(15),
	GhiChu nvarchar(50),

	TongTien money,
	PTramCK int,
	Thue int,
	TuongDuongTien money,
	TienThanhToan money
)

go

create table ChiTietPhieuBanHang
(
	MaChiTietPhieuBan varchar(15) primary key,
	MaPhieuBan varchar(15) not null,
	MaHangHoa varchar(15) not null,
	SoLuong int,
	DonGia money,
	ThanhTien money
)
go
create table KieuThanhToan
(
	MaThanhToan varchar(15),
	TenThanhToan nvarchar(30),
	GhiChu nvarchar(50),
)
go
create table HinhThucThanhToan
(
	MaHinhThuc varchar(15),
	TenHinhThuc nvarchar(30),
	GhiChu nvarchar(50)
)
go

create table TonKho
(
	MaHangHoa varchar(15),
	MaKho varchar(15),
	MaDonVi varchar(15),
	SoLuong int,
)

go
create table ChuyenKho
(
	MaPhieuChuyen varchar(15),
	NgayLapPhieu date,
	GhiChu nvarchar(50),
	MaKhoChuyen varchar(15),
	MaKhoNhan varchar(15),
	MaNguoiChuyen varchar(15),
	MaNguoiNhan varchar(15)
)

go
create table ChiTietChuyenKho
(
	MaChiTietPhieuChuyen varchar(15) primary key,
	MaPhieuChuyen varchar(15),
	MaHangHoa varchar(15),
	SoLuong int,
	DonGia money,
	ThanhTien money
)

go

create table TraHang
(
	MaPhieuTra varchar(15) primary key,
	NgayLapPhieu date,
	GhiChu nvarchar(50),
	MaKhachHang varchar(15),
	MaNhanVien varchar(15),
	MaKho varchar(15),
	TongTien money,
	PTramCK int,
	Thue int,
	TuongDuongTien money,
	TienThanhToan money
)
create table ChiTietTraHang
(	
	MaChiTietPhieuTra varchar(15) primary key,
	MaPhieuTra varchar(15),
	MaHangHoa varchar(15),
	SoLuong int,
	DonGia money,
	ThanhTien money
)

create procedure proGetTraHang_KhachHang_Kho
as
begin
	select TraHang.MaPhieuTra,NgayLapPhieu,KhachHang.MaKhachHang,TenKhachHang,TongTien
	,PTramCK,Thue,TuongDuongTien,TienThanhToan,GhiChu,MaNhanVien,Kho.MaKho,TenKho
	from TraHang,KhachHang,Kho
	where TraHang.MaKhachHang=KhachHang.MaKhachHang and TraHang.MaKho=Kho.MaKho
end

--
create procedure proGetTraHang_KhachHang_Kho_IfMaPhieuTra
@MaPhieuTra varchar(15)
as
begin
	select TraHang.MaPhieuTra,NgayLapPhieu,KhachHang.MaKhachHang,TenKhachHang,TongTien
	,PTramCK,Thue,TuongDuongTien,TienThanhToan,GhiChu,MaNhanVien,Kho.MaKho,TenKho
	from TraHang,KhachHang,Kho
	where MaPhieuTra=@MaPhieuTra and
	TraHang.MaKhachHang=KhachHang.MaKhachHang and TraHang.MaKho=Kho.MaKho
end


create procedure proGetTraHang_KhachHang_Kho_IfNgayNay_NgayKia
@NgayNay date,
@NgayKia date
as
begin
	select TraHang.MaPhieuTra,NgayLapPhieu,KhachHang.MaKhachHang,TenKhachHang,TongTien
	,PTramCK,Thue,TuongDuongTien,TienThanhToan,GhiChu,MaNhanVien,Kho.MaKho,TenKho
	from TraHang,KhachHang,Kho
	where NgayLapPhieu>=@NgayNay and NgayLapPhieu<=@NgayKia and
	TraHang.MaKhachHang=KhachHang.MaKhachHang and TraHang.MaKho=Kho.MaKho
end


create procedure proThemTraHang
	@MaPhieuTra varchar(15),
	@NgayLapPhieu date,
	@GhiChu nvarchar(50),
	@MaKhachHang varchar(15),
	@MaNhanVien varchar(15),
	@MaKho varchar(15),
	@TongTien money,
	@PTramCK int,
	@Thue int,
	@TuongDuongTien money,
	@TienThanhToan money
as
begin
	insert into TraHang values(
	@MaPhieuTra,
	@NgayLapPhieu,
	@GhiChu,
	@MaKhachHang,
	@MaNhanVien,
	@MaKho,
	@TongTien,
	@PTramCK,
	@Thue,
	@TuongDuongTien,
	@TienThanhToan
	)
end
create procedure proSuaTraHang
	@MaPhieuTra varchar(15),
	@NgayLapPhieu date,
	@GhiChu nvarchar(50),
	@MaKhachHang varchar(15),
	@MaNhanVien varchar(15),
	@MaKho varchar(15),
	@TongTien money,
	@PTramCK int,
	@Thue int,
	@TuongDuongTien money,
	@TienThanhToan money
as
begin
	update TraHang set
	NgayLapPhieu=@NgayLapPhieu,
	GhiChu=@GhiChu,
	MaKhachHang=@MaKhachHang,
	MaNhanVien=@MaNhanVien,
	MaKho=@MaKho,
	TongTien=@TongTien,
	PTramCK=@PTramCK,
	Thue=@Thue,
	TuongDuongTien=@TuongDuongTien,
	TienThanhToan=@TienThanhToan
	where MaPhieuTra=@MaPhieuTra
end

create procedure proXoaTraHang
@MaPhieuTra varchar(15)
as
begin
	delete from TraHang where MaPhieuTra=@MaPhieuTra
end

-- lay all chi tiet tra hang
create procedure proGetChiTietTraHang_HangHoa_DonVi
as
begin
	select MaChiTietPhieuTra,ChiTietTraHang.MaPhieuTra,ChiTietTraHang.MaHangHoa,SoLuong,DonGia,ThanhTien
	,DonVi.MaDonVi,TenDonVi,HangHoa.TenHangHoa
	from ChiTietTraHang,HangHoa,DonVi
	where ChiTietTraHang.MaHangHoa=HangHoa.MaHangHoa and HangHoa.MaDonVi = DonVi.MaDonVi
end
--chi tiet tra hang
create procedure proGetChiTietTraHang_HangHoa_DonVi_IfMaPhieuTra
@MaPhieuTra varchar(10)
as
begin
	select MaChiTietPhieuTra,ChiTietTraHang.MaPhieuTra,ChiTietTraHang.MaHangHoa,SoLuong,DonGia,ThanhTien
	,DonVi.MaDonVi,TenDonVi,HangHoa.TenHangHoa
	from ChiTietTraHang,HangHoa,DonVi
	where ChiTietTraHang.MaPhieuTra=@MaPhieuTra
		and ChiTietTraHang.MaHangHoa=HangHoa.MaHangHoa and HangHoa.MaDonVi = DonVi.MaDonVi
end
--sua chi tiet
create procedure proSuaChiTietTraHangByMaPhieuTra_MaHangHoa
	@MaPhieuTra varchar(15),
	@MaHangHoa varchar(15),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
as
begin
	update ChiTietTraHang set
	SoLuong = @SoLuong,
	DonGia = @DonGia,
	ThanhTien = @ThanhTien
	where MaPhieuTra=@MaPhieuTra and MaHangHoa=@MaHangHoa
end

--xoa chitietTra hang bang maphieutra
create procedure proXoaChiTietTraHangIfMaPhieuTra
	@MaPhieuTra varchar(15)
as
begin
	delete from ChiTietTraHang where MaPhieuTra=@MaPhieuTra
end
--xoa chi tiet tra hang ban MaPhieu
create procedure proXoaChiTietTraHangIfMaPhieuTraMaHangHoa
	@MaPhieuTra varchar(15),
	@MaHangHoa varchar(15)
as
begin
	delete from ChiTietTraHang where MaPhieuTra=@MaPhieuTra and MaHangHoa=@MaHangHoa
end
-------------------
--------Stored Procedures------------------------------------------------------------------------
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
create procedure proThemKho
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
create procedure proThemMuaHang
	@MaPhieu varchar(15),
	@TenPhieu nvarchar(30),
	@NgayLapPhieu date,
	@SoHoaDonVAT varchar(20),
	@SoPhieuVietTay varchar(20),
	@MaThanhToan varchar(15),
	@MaHinhThuc varchar(15),
	@MaNhaCungCap varchar(15),
	@ThoiHanThanhToan date,
	
	@GhiChu nvarchar(50),

	@MaNhanVien varchar(15),
	@MaKho varchar(15),

	@TongTien money,
	@PTramCK int,
	@Thue int,
	@TuongDuongTien money,
	@TienThanhToan money
as
begin
	insert into MuaHang values(
	@MaPhieu,
	@TenPhieu,
	@NgayLapPhieu,
	@SoHoaDonVAT,
	@SoPhieuVietTay,
	@MaThanhToan,
	@MaHinhThuc,
	@MaNhaCungCap,
	@ThoiHanThanhToan,
	
	@GhiChu,

	@MaNhanVien,
	@MaKho,

	@TongTien,
	@PTramCK,
	@Thue,
	@TuongDuongTien,
	@TienThanhToan
	)
end
go
create procedure proThemBanHang
	@MaPhieuBan varchar(15),
	@TenPhieu nvarchar(30),
	@NgayLapPhieu date,
	@MaKieuThanhToan varchar(15),
	@MaHinhThuc varchar(15),
	@ThoiHanThanhToan date,

	@MaKhachHang varchar(15),
	@NgayGiaoHang date,

	@MaNhanVien varchar(15),
	@MaKho varchar(15),
	@GhiChu nvarchar(50),

	@TongTien money,
	@PTramCK int,
	@Thue int,
	@TuongDuongTien money,
	@TienThanhToan money
as
begin
	insert into BanHang values(
	@MaPhieuBan,
	@TenPhieu,
	@NgayLapPhieu,
	@MaKieuThanhToan,
	@MaHinhThuc,
	@ThoiHanThanhToan,

	@MaKhachHang,
	@NgayGiaoHang,

	@MaNhanVien,
	@MaKho,
	@GhiChu,

	@TongTien,
	@PTramCK,
	@Thue,
	@TuongDuongTien,
	@TienThanhToan
	)
end

go

--them chuyen kho
create procedure proThemChuyenKho
	@MaPhieuChuyen varchar(15),
	@NgayLapPhieu date,
	@GhiChu nvarchar(50),
	@MaKhoChuyen varchar(15),
	@MaKhoNhan varchar(15),
	@MaNguoiChuyen varchar(15),
	@MaNguoiNhan varchar(15)
as
begin
	insert into ChuyenKho values(
	@MaPhieuChuyen,
	@NgayLapPhieu,
	@GhiChu,
	@MaKhoChuyen,
	@MaKhoNhan,
	@MaNguoiChuyen,
	@MaNguoiNhan
	)
end


go

--lay allChuyenKho kho nhan vien
create procedure proGetChuyenKho_Kho_NhanVien
as
begin
	select MaPhieuChuyen,NgayLapPhieu,GhiChu,KhoChuyen.TenKho as TenKhoChuyen,KhoNhan.TenKho as TenKhoNhan
	,NguoiChuyen.TenNhanVien as TenNguoiChuyen,NguoiNhan.TenNhanVien as TenNguoiNhan --Ten
	,KhoChuyen.MaKho as MaKhoChuyen,KhoNhan.MaKho as MaKhoNhan --Ma
	,NguoiChuyen.MaNhanVien as MaNguoiChuyen,NguoiNhan.MaNhanVien as MaNguoiNhan --Ma
	from ChuyenKho,Kho as KhoChuyen,Kho as KhoNhan,NhanVien as NguoiChuyen,NhanVien as NguoiNhan
	where ChuyenKho.MaKhoChuyen = KhoChuyen.MaKho and ChuyenKho.MaKhoNhan = KhoNhan.MaKho
		and ChuyenKho.MaNguoiChuyen=NguoiChuyen.MaNhanVien and ChuyenKho.MaNguoiNhan = NguoiNhan.MaNhanVien
end

go
--lay allChuyenKho_kho_NhanVien by MaPhieuChuyen
create procedure proGetChuyenKho_Kho_NhanVien_IfMaPhieuChuyen
@MaPhieuChuyen varchar(15)
as
begin
	select MaPhieuChuyen,NgayLapPhieu,GhiChu,KhoChuyen.TenKho as TenKhoChuyen,KhoNhan.TenKho as TenKhoNhan
	,NguoiChuyen.TenNhanVien as TenNguoiChuyen,NguoiNhan.TenNhanVien as TenNguoiNhan --Ten
	,KhoChuyen.MaKho as MaKhoChuyen,KhoNhan.MaKho as MaKhoNhan --Ma
	,NguoiChuyen.MaNhanVien as MaNguoiChuyen,NguoiNhan.MaNhanVien as MaNguoiNhan --Ma
	from ChuyenKho,Kho as KhoChuyen,Kho as KhoNhan,NhanVien as NguoiChuyen,NhanVien as NguoiNhan
	where MaPhieuChuyen=@MaPhieuChuyen
		and ChuyenKho.MaKhoChuyen = KhoChuyen.MaKho and ChuyenKho.MaKhoNhan = KhoNhan.MaKho
		and ChuyenKho.MaNguoiChuyen=NguoiChuyen.MaNhanVien and ChuyenKho.MaNguoiNhan = NguoiNhan.MaNhanVien
end

--lay allChuyenKho by Ngay nay, ngay kia
create procedure proGetChuyenKho_Kho_NhanVien_IfNgayNay_NgayKia
@NgayNay date,
@NgayKia date
as
begin
	select MaPhieuChuyen,NgayLapPhieu,GhiChu,KhoChuyen.TenKho as TenKhoChuyen,KhoNhan.TenKho as TenKhoNhan
	,NguoiChuyen.TenNhanVien as TenNguoiChuyen,NguoiNhan.TenNhanVien as TenNguoiNhan --Ten
	,KhoChuyen.MaKho as MaKhoChuyen,KhoNhan.MaKho as MaKhoNhan --Ma
	,NguoiChuyen.MaNhanVien as MaNguoiChuyen,NguoiNhan.MaNhanVien as MaNguoiNhan --Ma
	from ChuyenKho,Kho as KhoChuyen,Kho as KhoNhan,NhanVien as NguoiChuyen,NhanVien as NguoiNhan
	where NgayLapPhieu>=@NgayNay and NgayLapPhieu<=@NgayKia
		and ChuyenKho.MaKhoChuyen = KhoChuyen.MaKho and ChuyenKho.MaKhoNhan = KhoNhan.MaKho
		and ChuyenKho.MaNguoiChuyen=NguoiChuyen.MaNhanVien and ChuyenKho.MaNguoiNhan = NguoiNhan.MaNhanVien
end
--sua chuyen kho
create procedure proSuaChuyenKho
begin
	MaPhieuChuyen=@MaPhieuChuyen,
	NgayLapPhieu=@NgayLapPhieu,
	GhiChu=@GhiChu,
	MaKhoChuyen=@MaKhoChuyen,
	MaKhoNhan=@MaKhoNhan,
	MaNguoiChuyen=@MaNguoiChuyen,
	MaNguoiNhan=@MaNguoiNhan 
end
--them chi tiet chuyen kho
create procedure proThemChiTietPhieuChuyen
	@MaChiTietPhieuChuyen varchar(15),
	@MaPhieuChuyen varchar(15),
	@MaHangHoa varchar(15),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
as
begin
	set @MaChiTietPhieuChuyen = dbo.funAutoCreateIDMaChiTietPhieuChuyen()
	insert into ChiTietChuyenKho values(
	@MaChiTietPhieuChuyen,
	@MaPhieuChuyen,
	@MaHangHoa,
	@SoLuong,
	@DonGia,
	@ThanhTien
	)
end

--
go

create procedure proThemChiTietPhieuTra
	@MaChiTietPhieuTra varchar(15),
	@MaPhieuTra varchar(15),
	@MaHangHoa varchar(15),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
as
begin
	set @MaChiTietPhieuTra = dbo.funAutoCreateIDMaChiTietPhieuTra()
	insert into ChiTietTraHang values(
	@MaChiTietPhieuTra,
	@MaPhieuTra,
	@MaHangHoa,
	@SoLuong,
	@DonGia,
	@ThanhTien
	)
end

go
--them ton kho
create procedure proThemTonKho
	@MaHangHoa varchar(15),
	@MaKho varchar(15),
	@SoLuong int
as
IF EXISTS
(
	SELECT MaHangHoa
	FROM TonKho
	WHERE @MaHangHoa=MaHangHoa and @MaKho=MaKho
)
begin
	update TonKho set
	SoLuong = SoLuong + @SoLuong
	where @MaHangHoa=MaHangHoa and @MaKho=MaKho
end
else
begin
insert into TonKho values
(
	@MaHangHoa,
	@MaKho,
	@SoLuong
)
end

--cong so luong ton kho(Sua ton kho)
create procedure proCongSoLuongTonKho
	@MaHangHoa varchar(15),
	@MaKho varchar(15),
	@SoLuong int
as
begin
	update TonKho set
	SoLuong = SoLuong + @SoLuong
	where @MaHangHoa=MaHangHoa and @MaKho=MaKho
end

--trigger
Create Trigger tr_SoCTHD On CTHD For Insert 
As
 If (Select Count(a.SoHD)
     From CTHD a Inner Join INSERTED b On a.SoHD = b.SoHD) > 10
 Begin
   Print 'So CTHD Khong the > 10'
   RollBack Tran
 End

 create trigger trThemTonKho on ChiTietPhieuMuaHang for Insert
 as
 begin
	Declare @MaHangHoa varchar(15)
	Declare @SoLuong int
	set @SoLuong = (select ChiTietPhieuMuaHang.SoLuong,MaChiTietPhieu
					From ChiTietPhieuMuaHang,TonKho
					where ChiTietPhieuMuaHang.MaHangHoa = TonKho.MaHangHoa
					)
	if EXISTS(select
				From TonKho
				where TonKho.MaHangHoa = ChiTietPhieuMuaHang.MaHangHoa and TonKho.MaKho 
			)
	insert into TonKho(SoLuong) values(@SoLuong)
 end

--tru so luong ton kho(Sua ton kho)
create procedure proTruSoLuongTonKho
	@MaHangHoa varchar(15),
	@MaKho varchar(15),
	@SoLuong int
as
begin
	update TonKho set
	SoLuong = SoLuong - @SoLuong
	where @MaHangHoa=MaHangHoa and @MaKho=MaKho
end
--Xuat tonkho
create procedure proXuatTonKho
	@MaHangHoa varchar(15),
	@MaKho varchar(15),
	@SoLuong int
as
IF EXISTS
(
	SELECT MaHangHoa
	FROM TonKho
	WHERE @MaHangHoa=MaHangHoa and @MaKho=MaKho
)
begin
	update TonKho set
	SoLuong = SoLuong - @SoLuong
	where @MaHangHoa=MaHangHoa and @MaKho=MaKho
end

go
--sua mua hang
create procedure proSuaMuaHang
	@MaPhieu varchar(15),
	@TenPhieu nvarchar(30),
	@NgayLapPhieu date,
	@SoHoaDonVAT varchar(20),
	@SoPhieuVietTay varchar(20),
	@MaThanhToan varchar(15),
	@MaHinhThuc varchar(15),
	@MaNhaCungCap varchar(15),
	@ThoiHanThanhToan date,
	
	@GhiChu nvarchar(50),

	@MaNhanVien varchar(15),
	@MaKho varchar(15),

	@TongTien money,
	@PTramCK int,
	@Thue int,
	@TuongDuongTien money,
	@TienThanhToan money
as
begin
	update MuaHang set
	MaPhieu= @MaPhieu,
	TenPhieu = @TenPhieu,
	NgayLapPhieu = @NgayLapPhieu,
	SoHoaDonVAT = @SoHoaDonVAT,
	SoPhieuVietTay=@SoPhieuVietTay,
	MaThanhToan=@MaThanhToan,
	MaHinhThuc=@MaHinhThuc,
	MaNhaCungCap=@MaNhaCungCap,
	ThoiHanThanhToan=@ThoiHanThanhToan,
	
	GhiChu=@GhiChu,

	MaNhanVien=@MaNhanVien,
	MaKho=@MaKho,

	TongTien=@TongTien,
	PTramCK=@PTramCK,
	Thue=@Thue,
	TuongDuongTien=@TuongDuongTien,
	TienThanhToan=@TienThanhToan
	where MaPhieu=@MaPhieu
end

go
create procedure proSuaBanHang
	@MaPhieuBan varchar(15),
	@TenPhieu nvarchar(30),
	@NgayLapPhieu date,
	@MaThanhToan varchar(15),
	@MaHinhThuc varchar(15),
	@ThoiHanThanhToan date,

	@MaKhachHang varchar(15),
	@NgayGiaoHang date,

	@MaNhanVien varchar(15),
	@MaKho varchar(15),
	@GhiChu nvarchar(50),

	@TongTien money,
	@PTramCK int,
	@Thue int,
	@TuongDuongTien money,
	@TienThanhToan money
as
begin
	update BanHang set
	MaPhieuBan=@MaPhieuBan,
	TenPhieu=@TenPhieu,
	NgayLapPhieu=@NgayLapPhieu,
	MaThanhToan=@MaThanhToan,
	MaHinhThuc=@MaHinhThuc,
	ThoiHanThanhToan=@ThoiHanThanhToan,

	MaKhachHang=@MaKhachHang,
	NgayGiaoHang=@NgayGiaoHang,

	MaNhanVien=@MaNhanVien,
	MaKho=@MaKho,
	GhiChu=@GhiChu,

	TongTien=@TongTien,
	PTramCK=@PTramCK,
	Thue=@Thue,
	TuongDuongTien=@TuongDuongTien,
	TienThanhToan=@TienThanhToan
	where MaPhieuBan=@MaPhieuBan
end

go
create procedure proSuaTonKho
	@MaHangHoa varchar(15),
	@MaKho varchar(15),
	@MaDonVi varchar(15),
	@MaNhomHang varchar(15),
	@SoLuong int
as
begin
	update TonKho set
	MaHangHoa=@MaHangHoa,
	MaKho=@MaKho,
	MaDonVi=@MaDonVi,
	MaNhomHang=@MaNhomHang,
	SoLuong=@SoLuong
	where MaHangHoa=@MaHangHoa
end

go

create procedure proXoaTonKho
@MaHangHoa varchar(15)
as
begin
	delete from TonKho where MaHangHoa=@MaHangHoa
end


go
--lay bang kho va nhan vien(lay cho gridviewKhoHang)
create procedure proGetKhoNhanVien
as
select MaKho,TenKho,TenNhanVien as TenQuanLy,KyHieu,NguoiLienHe,Kho.DiaChi,Fax,Kho.SoDienThoai,Kho.Email,DienGiai,ConQuanLy
from Kho,NhanVien
where Kho.MaNguoiQuanLy = NhanVien.MaNhanVien

go

-- lay lich su mua hang
create procedure proGetMuaHang_NhaCC_Kho
as
begin
	select MuaHang.MaPhieu,TenPhieu,NgayLapPhieu,NhaCungCap.MaNhaCungCap,TenNhaCungCap,TongTien
	,PTramCK,Thue,TienThanhToan,SoHoaDonVAT,GhiChu,Kho.MaKho,TenKho
	from MuaHang,NhaCungCap,Kho
	where MuaHang.MaNhaCungCap = NhaCungCap.MaNhaCungCap and MuaHang.MaKho = Kho.MaKho
end

go

-- lay lich su mua hang bang MaPhieu
create procedure proGetMuaHang_NhaCC_Kho_IfMaPhieu
@MaPhieu varchar(15)
as
begin
	select MuaHang.MaPhieu,TenPhieu,NgayLapPhieu,NhaCungCap.MaNhaCungCap,TenNhaCungCap,TongTien
	,PTramCK,Thue,TuongDuongTien,TienThanhToan,SoHoaDonVAT,SoPhieuVietTay,MaThanhToan,MaHinhThuc,ThoiHanThanhToan,GhiChu,MaNhanVien,Kho.MaKho,TenKho
	from MuaHang,NhaCungCap,Kho
	where @MaPhieu=MaPhieu and
	MuaHang.MaNhaCungCap = NhaCungCap.MaNhaCungCap and MuaHang.MaKho = Kho.MaKho
end


-- lay tat ca banhang
create procedure proGetBanHang_KhachHang_Kho
as
begin
	select BanHang.MaPhieuBan,TenPhieu,NgayLapPhieu,KhachHang.MaKhachHang,TenKhachHang,TongTien
	,PTramCK,Thue,TuongDuongTien,TienThanhToan,MaThanhToan,MaHinhThuc,ThoiHanThanhToan,NgayGiaoHang,GhiChu,MaNhanVien,Kho.MaKho,TenKho
	from BanHang,KhachHang,Kho
	where BanHang.MaKhachHang = KhachHang.MaKhachHang and BanHang.MaKho = Kho.MaKho 	
end
--lay lich su mua hang bang MaPhieuBan
create procedure proGetBanHang_KhachHang_Kho_IfMaPhieuBan
@MaPhieuBan varchar(15)
as
begin
	select BanHang.MaPhieuBan,TenPhieu,NgayLapPhieu,KhachHang.MaKhachHang,TenKhachHang,TongTien
	,PTramCK,Thue,TuongDuongTien,TienThanhToan,MaThanhToan,MaHinhThuc,ThoiHanThanhToan,NgayGiaoHang,GhiChu,MaNhanVien,Kho.MaKho,TenKho
	from BanHang,KhachHang,Kho
	where @MaPhieuBan=MaPhieuBan and
	BanHang.MaKhachHang = KhachHang.MaKhachHang and BanHang.MaKho = Kho.MaKho 	
end

go
-- lay lich su mua hang theo MaNhaCungCap
create procedure proGetMuaHang_NhaCC_Kho_IfMaNhaCungCap
@MaNhaCungCap varchar(15)
as
begin
	select MuaHang.MaPhieu,TenPhieu,NgayLapPhieu,NhaCungCap.MaNhaCungCap,TenNhaCungCap,TongTien
	,PTramCK,Thue,TienThanhToan,SoHoaDonVAT,GhiChu,Kho.MaKho,TenKho
	from MuaHang,NhaCungCap,Kho
	where NhaCungCap.MaNhaCungCap = @MaNhaCungCap
		and MuaHang.MaNhaCungCap = NhaCungCap.MaNhaCungCap and MuaHang.MaKho = Kho.MaKho
end
-- lay lich su ban hang theo ngay
create procedure proGetBanHang_KhachHang_Kho_IfNgayNay_NgayKia
@NgayNay date,
@NgayKia date
as
begin
	select BanHang.MaPhieuBan,TenPhieu,NgayLapPhieu,KhachHang.MaKhachHang,TenKhachHang,TongTien
	,PTramCK,Thue,TuongDuongTien,TienThanhToan,MaThanhToan,MaHinhThuc,ThoiHanThanhToan,NgayGiaoHang,GhiChu,MaNhanVien,Kho.MaKho,TenKho
	from BanHang,KhachHang,Kho
	where NgayLapPhieu>=@NgayNay and NgayLapPhieu<=@NgayKia
		and BanHang.MaKhachHang = KhachHang.MaKhachHang and BanHang.MaKho = Kho.MaKho
end



go
create procedure proGetMuaHang_NhaCC_Kho_IfNgayNay_NgayKia
@NgayNay date,
@NgayKia date
as
begin
	select MuaHang.MaPhieu,TenPhieu,NgayLapPhieu,NhaCungCap.MaNhaCungCap,TenNhaCungCap,TongTien
	,PTramCK,Thue,TienThanhToan,SoHoaDonVAT,GhiChu,Kho.MaKho,TenKho
	from MuaHang,NhaCungCap,Kho
	where NgayLapPhieu>=@NgayNay and NgayLapPhieu<=@NgayKia
		and MuaHang.MaNhaCungCap = NhaCungCap.MaNhaCungCap and MuaHang.MaKho = Kho.MaKho
end
go

--lay ChiTietPhieuMuaHang bang MaPhieu
create procedure proGetChiTietPhieuMuaHang_HangHoa_DonVi_IfMaPhieu
@MaPhieu varchar(15)
as
begin
	select MaChiTietPhieu,ChiTietPhieuMuaHang.MaPhieu,ChiTietPhieuMuaHang.MaHangHoa,SoLuong,DonGia,ThanhTien,HangHoa.TenHangHoa
	,DonVi.MaDonVi,TenDonVi
	from ChiTietPhieuMuaHang,HangHoa,DonVi
	where ChiTietPhieuMuaHang.MaPhieu = @MaPhieu
		and ChiTietPhieuMuaHang.MaHangHoa = HangHoa.MaHangHoa and HangHoa.MaDonVi = DonVi.MaDonVi
end

go

--lay ChiTietPhieuBanHang bang MaPhieuBan
create procedure proGetChiTietPhieuBanHang_HangHoa_DonVi_IfMaPhieu
@MaPhieuBan varchar(15)
as
begin
	select MaChiTietPhieuBan,ChiTietPhieuBanHang.MaPhieuBan,ChiTietPhieuBanHang.MaHangHoa,SoLuong,DonGia,ThanhTien
	,DonVi.MaDonVi,TenDonVi,HangHoa.TenHangHoa
	from ChiTietPhieuBanHang,HangHoa,DonVi
	where ChiTietPhieuBanHang.MaPhieuBan = @MaPhieuBan
		and ChiTietPhieuBanHang.MaHangHoa = HangHoa.MaHangHoa and HangHoa.MaDonVi = DonVi.MaDonVi
end
go

--lay hanghoa
create procedure proGetAllHangHoa_NhomHang_DonVi_Kho_NhaCungCap
as
select MaHangHoa,TenHangHoa,HangHoa.MaNhomHang,TenNhomHang,HangHoa.MaDonVi,TenDonVi,HangHoa.MaKho,TenKho,MaVachNSX
	,XuatXu,Thue,TonKhoToiThieu,TonHienTai,HangHoa.MaNhaCungCap,TenNhaCungCap,GiaMua,GiaBanSi,GiaBanLe
	,HangHoaOrDichVu,HangHoa.ConQuanLy
from HangHoa,NhomHang,DonVi,Kho,NhaCungCap
where HangHoa.MaNhomHang = NhomHang.MaNhomHang and HangHoa.MaDonVi = DonVi.MaDonVi and HangHoa.MaKho = Kho.MaKho
	and HangHoa.MaNhaCungCap = NhaCungCap.MaNhaCungCap

go
-- lay ton kho
create procedure proGetTonKho_Kho_HangHoa_DonVi_NhomHang
as
begin
	select HangHoa.MaHangHoa,TenHangHoa,Kho.MaKho,TenKho,DonVi.MaDonVi,TenDonVi,SoLuong,NhomHang.MaNhomHang,TenNhomHang
	From Kho,TonKho,HangHoa,DonVi,NhomHang
	Where TonKho.MaHangHoa = HangHoa.MaHangHoa and TonKho.MaKho =Kho.MaKho and
		HangHoa.MaDonVi = DonVi.MaDonVi and HangHoa.MaNhomHang = NhomHang.MaNhomHang
end

--lay bang kho = makho
create procedure proGetTonKho_Kho_HangHoa_DonVi_NhomHang_IfMaKho
@MaKho varchar(15)
as
begin
	select HangHoa.MaHangHoa,TenHangHoa,Kho.MaKho,TenKho,DonVi.MaDonVi,TenDonVi,SoLuong,NhomHang.MaNhomHang,TenNhomHang
	From Kho,TonKho,HangHoa,DonVi,NhomHang
	where @MaKho=Kho.MaKho and TonKho.MaHangHoa = HangHoa.MaHangHoa and TonKho.MaKho =Kho.MaKho and
		HangHoa.MaDonVi = DonVi.MaDonVi and HangHoa.MaNhomHang = NhomHang.MaNhomHang
end

--
create procedure proGetChiTietChuyenKho_HangHoa_DonVi_IfMaPhieuChuyen
	@MaPhieuChuyen varchar(15)
as
begin
	select MaChiTietPhieuChuyen,MaPhieuChuyen,ChiTietChuyenKho.MaHangHoa,SoLuong,DonGia,ThanhTien
	,TenHangHoa,DonVi.MaDonVi,TenDonVi
	from ChiTietChuyenKho,HangHoa,DonVi
	where ChiTietChuyenKho.MaPhieuChuyen = @MaPhieuChuyen
		and ChiTietChuyenKho.MaHangHoa = HangHoa.MaHangHoa and HangHoa.MaDonVi = DonVi.MaDonVi
end
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
<<<<<<< HEAD
create procedure [dbo].[proThemHangHoa]
	@MaHangHoa varchar(15),
	@TenHangHoa nvarchar(50),
	@MaKho varchar(15),
	@MaNhomHang varchar(15),
	
=======
create procedure proThemHangHoa
	@HangHoaOrDichVu bit,--1. hang hoa, 0. dich vu
	@MaNhomHang varchar(15),
	@MaHangHoa varchar(15),
	@TenHangHoa nvarchar(50),
>>>>>>> a8687d99ddb71e3488e90dece9b27b2a5d3891eb
	@MaVachNSX varchar(30),
	@MaDonVi varchar(15),--DonViGoc(phan mem)
	@XuatXu nvarchar(30),
	@Thue float,
	@TonKhoToiThieu int,
	@TonHienTai int,
	@MaNhaCungCap varchar(15),
	@GiaMua money,
	@GiaBanSi money,
<<<<<<< HEAD
	@GiaBanLe money,
	@HangHoaOrDichVu int,--1. hang hoa, 2. dich vu
	@ConQuanLy bit	
as
begin
	insert into HangHoa values(
	@MaHangHoa,
	@TenHangHoa,
	@MaKho,
	@MaNhomHang,
	
=======
	@GiaBanLe money
as
begin
	insert into HangHoa values(
	@HangHoaOrDichVu,--1. hang hoa, 2. dich vu
	@MaNhomHang,
	@MaHangHoa,
	@TenHangHoa,
>>>>>>> a8687d99ddb71e3488e90dece9b27b2a5d3891eb
	@MaVachNSX,
	@MaDonVi,--DonViGoc(phan mem)
	@XuatXu,
	@Thue,
	@TonKhoToiThieu,
	@TonHienTai,
	@MaNhaCungCap,
	@GiaMua,
	@GiaBanSi,
<<<<<<< HEAD
	@GiaBanLe,
	@HangHoaOrDichVu,--1. hang hoa, 2. dich vu
	@ConQuanLy
	)
end
=======
	@GiaBanLe
	)
end

>>>>>>> a8687d99ddb71e3488e90dece9b27b2a5d3891eb

go

create procedure proThemMuaHang
	@MaPhieu varchar(15),
	@TenPhieu nvarchar(30),
	@NgayLapPhieu date,
	@SoHoaDonVAT varchar(20),
	@SoPhieuVietTay varchar(20),
	@MaThanhToan varchar(15),
	@MaHinhThuc varchar(15),
	@MaNhaCungCap varchar(15),
	@ThoiHanThanhToan date,
	
	@GhiChu nvarchar(50),

	@MaNhanVien varchar(15),
	@MaKho varchar(15),

	@TongTien money,
	@PTramCK int,
	@Thue int,
	@TuongDuongTien money,
	@TienThanhToan money
as
begin
	insert into MuaHang values(
	@MaPhieu,
	@TenPhieu,
	@NgayLapPhieu,
	@SoHoaDonVAT,
	@SoPhieuVietTay,
	@MaThanhToan,
	@MaHinhThuc,
	@MaNhaCungCap,
	@ThoiHanThanhToan,
	
	@GhiChu,

	@MaNhanVien,
	@MaKho,

	@TongTien,
	@PTramCK,
	@Thue,
	@TuongDuongTien,
	@TienThanhToan
	)
end



go

--them ChiTietPhieuMuaHang
create procedure [dbo].[proThemChiTietPhieuMuaHang]
	@MaChiTietPhieu varchar(15),
	@MaPhieu varchar(15),
	@MaHangHoa varchar(15),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
as
begin
	set @MaChiTietPhieu = dbo.funAutoCreateIDMaChiTietPhieu()
	insert into ChiTietPhieuMuaHang values(
	@MaChiTietPhieu,
	@MaPhieu,
	@MaHangHoa,
	@SoLuong,
	@DonGia,
	@ThanhTien
	)
end

go
create procedure proThemChiTietPhieuBan
	@MaChiTietPhieuBan varchar(15),
	@MaPhieuBan varchar(15),
	@MaHangHoa varchar(15),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
as
begin
	set @MaChiTietPhieuBan = dbo.funAutoCreateIDMaChiTietPhieuBan()
	insert into ChiTietPhieuBanHang values(
	@MaChiTietPhieuBan,
	@MaPhieuBan,
	@MaHangHoa,
	@SoLuong,
	@DonGia,
	@ThanhTien
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
--Sua ChiTietPhieuMuaHang
create procedure proSuaChiTietPhieuMuaHang
	@MaChiTietPhieu varchar(15),
	@MaPhieu varchar(15),
	@MaHangHoa varchar(15),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
as
begin
	update ChiTietPhieuMuaHang set
	MaChiTietPhieu = @MaChiTietPhieu,
	MaPhieu =  @MaPhieu,
	MaHangHoa =  @MaHangHoa,
	SoLuong = @SoLuong,
	DonGia = @DonGia,
	ThanhTien = @ThanhTien
	where MaChiTietPhieu=@MaChiTietPhieu
end

go
drop procedure proSuaChiTietPhieuMuaHangByMaPhieu_MaHangHoa
create procedure proSuaChiTietPhieuMuaHangByMaPhieu_MaHangHoa
	@MaPhieu varchar(15),
	@MaHangHoa varchar(15),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
as
begin
	update ChiTietPhieuMuaHang set
	--MaChiTietPhieu = @MaChiTietPhieu,
	MaPhieu =  @MaPhieu,
	MaHangHoa =  @MaHangHoa,
	SoLuong = @SoLuong,
	DonGia = @DonGia,
	ThanhTien = @ThanhTien
	where MaPhieu=@MaPhieu and MaHangHoa=@MaHangHoa
end
go
create procedure proSuaChiTietPhieuBanHang
	@MaChiTietPhieuBan varchar(15),
	@MaPhieuBan varchar(15),
	@MaHangHoa varchar(15),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
as
begin
	update ChiTietPhieuBanHang set
	MaChiTietPhieuBan = @MaChiTietPhieuBan,
	MaPhieuBan =  @MaPhieuBan,
	MaHangHoa =  @MaHangHoa,
	SoLuong = @SoLuong,
	DonGia = @DonGia,
	ThanhTien = @ThanhTien
	where MaChiTietPhieuBan=@MaChiTietPhieuBan
end

go
--Sua hang hoa
<<<<<<< HEAD
ALTER procedure [dbo].[proSuaHangHoa]
	@MaHangHoa varchar(15),
	@TenHangHoa nvarchar(50),
	@MaKho varchar(15),
	@MaNhomHang varchar(15),
	
=======
create procedure proSuaHangHoa
	@HangHoaOrDichVu int,--1. hang hoa, 2. dich vu
	@MaNhomHang varchar(15),
	@MaHangHoa varchar(15),
	@TenHangHoa nvarchar(50),
>>>>>>> a8687d99ddb71e3488e90dece9b27b2a5d3891eb
	@MaVachNSX varchar(30),
	@MaDonVi varchar(15),--DonViGoc(phan mem)
	@XuatXu nvarchar(30),
	@Thue float,
	@TonKhoToiThieu int,
	@TonHienTai int,
	@MaNhaCungCap varchar(15),
	@GiaMua money,
	@GiaBanSi money,
<<<<<<< HEAD
	@GiaBanLe money,
	@HangHoaOrDichVu int,--1. hang hoa, 2. dich vu
	@ConQuanLy bit	
as
begin
	update HangHoa set
	MaHangHoa=@MaHangHoa,
	TenHangHoa=@TenHangHoa,	
	MaKho=@MaKho,
	MaNhomHang=@MaNhomHang,

=======
	@GiaBanLe money
as
begin
	update HangHoa set
	HangHoaOrDichVu=@HangHoaOrDichVu,--1. hang hoa, 2. dich vu
	@MaNhomHang=@MaNhomHang,
	MaHangHoa=@MaHangHoa,
	TenHangHoa=@TenHangHoa,
>>>>>>> a8687d99ddb71e3488e90dece9b27b2a5d3891eb
	MaVachNSX=@MaVachNSX,
	MaDonVi=@MaDonVi,--DonViGoc(phan mem)
	XuatXu=@XuatXu,
	Thue=@Thue,
	TonKhoToiThieu=@TonKhoToiThieu,
	TonHienTai=@TonHienTai,
	MaNhaCungCap=@MaNhaCungCap,
	GiaMua=@GiaMua,
	GiaBanSi=@GiaBanSi,
<<<<<<< HEAD
	GiaBanLe=@GiaBanLe,
	HangHoaOrDichVu=@HangHoaOrDichVu,--1. hang hoa, 2. dich vu
	ConQuanLy=@ConQuanLy
	where  MaHangHoa=@MaHangHoa
end

go

create procedure proGetHangHoa_Kho_NhomHang_DonVi_NhaCC
as
select MaHangHoa,TenHangHoa,HangHoa.MaKho,TenKho,HangHoa.MaNhomHang,TenNhomHang,MaVachNSX,HangHoa.MaDonVi,TenDonVi,XuatXu,
	Thue,TonKhoToiThieu,TonHienTai,HangHoa.MaNhaCungCap,TenNhaCungCap,GiaMua,GiaBanSi,GiaBanLe,HangHoa.ConQuanLy,
	HangHoaOrDichVu
from HangHoa,Kho,NhomHang,DonVi,NhaCungCap
where HangHoa.MaKho=Kho.MaKho and HangHoa.MaNhomHang=NhomHang.MaNhomHang
	and HangHoa.MaDonVi=DonVi.MaDonVi and HangHoa.MaNhaCungCap=NhaCungCap.MaNhaCungCap
=======
	GiaBanLe=@GiaBanLe
	where  MaHangHoa=@MaHangHoa
end

>>>>>>> a8687d99ddb71e3488e90dece9b27b2a5d3891eb

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
	@MaNguoiQuanLy varchar(15),
	@ConQuanLy bit
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
	MaNguoiQuanLy=@MaNguoiQuanLy,
	ConQuanLy=@ConQuanLy
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
-- xoa muahang
create procedure proXoaMuaHang
@MaPhieu varchar(15)
as
begin
	delete from MuaHang where MaPhieu=@MaPhieu
end

go
create procedure proXoaBanHang
@MaPhieuBan varchar(15)
as
begin
	delete from BanHang where MaPhieuBan=@MaPhieuBan
end

go
--Xoa ChiTietPhieuMuaHang bang MaPhieu
create procedure proXoaChiTietPhieuMuaHangIfMaPhieu
	@MaPhieu varchar(15)
as
begin
	delete from ChiTietPhieuMuaHang where MaPhieu=@MaPhieu
end

go
--Xoa ChiTietChuyenKho bang MaPhieuChuyen
create procedure proXoaChiTietChuyenKhoIfMaPhieuChuyen
	@MaPhieuChuyen varchar(15)
as
begin
	delete from ChiTietChuyenKho where MaPhieuChuyen=@MaPhieuChuyen
end


go
--Xoa ChiTietChuyenKho bang MaPhieuChuyenMaHangHoa
create procedure proXoaChiTietChuyenKhoIfMaPhieuChuyenMaHangHoa
	@MaPhieuChuyen varchar(15),
	@MaHangHoa varchar(15)
as
begin
	delete from ChiTietChuyenKho where MaPhieuChuyen=@MaPhieuChuyen and MaHangHoa=@MaHangHoa
end
go
create procedure proXoaChiTietPhieuMuaHangByMaPhieuMaHangHoa
	@MaPhieu varchar(15),
	@MaHangHoa varchar(15)
as
begin
	delete from ChiTietPhieuMuaHang where MaPhieu=@MaPhieu and MaHangHoa = @MaHangHoa
end


go
create procedure proXoaChiTietPhieuBanHangByMaPhieuBanMaHangHoa
	@MaPhieuBan varchar(15),
	@MaHangHoa varchar(15)
as
begin
	delete from ChiTietPhieuBanHang where MaPhieuBan=@MaPhieuBan and MaHangHoa = @MaHangHoa
end
go
create procedure proXoaChiTietPhieuMuaHangByMaPhieu
	@MaPhieu varchar(15)
as
begin
	delete from ChiTietPhieuMuaHang where MaPhieu=@MaPhieu
end
go
--Xoa ChiTietPhieuBanHang bang MaPhieuBan
create procedure proXoaChiTietPhieuBanHangIfMaPhieuBan
	@MaPhieuBan varchar(15)
as
begin
	delete from ChiTietPhieuBanHang where MaPhieuBan=@MaPhieuBan
end

go
--Xoa ChiTietPhieuMuaHang bang MaChiTietPhieu
create procedure proXoaChiTietPhieuMuaHangIfMaChiTietPhieu
	@MaChiTietPhieu varchar(15)
as
begin
	delete from ChiTietPhieuMuaHang where MaChiTietPhieu=@MaChiTietPhieu
end

go
--Xoa ChiTietPhieuMuaHang bang MaChiTietPhieu
create procedure proXoaChiTietPhieuBanIfMaChiTietPhieuBan
	@MaChiTietPhieuBan varchar(15)
as
begin
	delete from ChiTietPhieuBanHang where MaChiTietPhieuBan=@MaChiTietPhieuBan
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

go
--funtion tu dong tao machitietphieu
CREATE FUNCTION funAutoCreateIDMaChiTietPhieu()
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @ID VARCHAR(15)
	DECLARE @maSo int = 1
	DECLARE @soLuong int = (SELECT COUNT(*) FROM ChiTietPhieuMuaHang)
	
	IF (@soLuong = 0)
		SET @ID = 'CTP' + cast(@maSo as varchar(12))
	ELSE
		begin
			set @ID = 'CTP' + cast(@maSo+1 as varchar(12))
			while not EXISTS
				(
					SELECT MaChiTietPhieu
					FROM ChiTietPhieuMuaHang
					WHERE @ID = ChiTietPhieuMuaHang.MaChiTietPhieu
				)
			begin
				set @maSo = @maSo + 1
				set @ID = 'CTP' + cast(@maSo as varchar(12))			
			end
		end
	RETURN @ID
END


go

-- funtion tu dong tao machitietphieuban
CREATE FUNCTION funAutoCreateIDMaChiTietPhieuBan()
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @ID VARCHAR(15)
	DECLARE @maSo int = 1
	DECLARE @soLuong int = (SELECT COUNT(*) FROM ChiTietPhieuBanHang)
	
	IF (@soLuong = 0)
		SET @ID = 'CTPB' + cast(@maSo as varchar(12))
	ELSE
		begin
			set @ID = 'CTPB' + cast(@maSo+1 as varchar(12))
			while not EXISTS
				(
					SELECT MaChiTietPhieuBan
					FROM ChiTietPhieuBanHang
					WHERE @ID = ChiTietPhieuBanHang.MaChiTietPhieuBan
				)
			begin
				set @maSo = @maSo + 1
				set @ID = 'CTPB' + cast(@maSo as varchar(12))			
			end
		end
	RETURN @ID
END

-- tu dong lay ma chitietphieuchuyen
create FUNCTION funAutoCreateIDMaChiTietPhieuChuyen()
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @ID VARCHAR(15);
	DECLARE @maSo int = 1;
	DECLARE @soLuong int;
	set @soLuong = (SELECT COUNT(MaChiTietPhieuChuyen) FROM ChiTietChuyenKho)
	
	IF (@soLuong = 0)
		SET @ID = 'CTPC' + cast(@maSo as varchar(12))
	ELSE
		begin
			set @ID = 'CTPC' + cast(@maSo as varchar(12))
			while EXISTS
				(
					SELECT MaChiTietPhieuChuyen
					FROM ChiTietChuyenKho
					WHERE @ID = ChiTietChuyenKho.MaChiTietPhieuChuyen
				)
			begin
				set @maSo = @maSo + 1
				set @ID = 'CTPC' + cast(@maSo as varchar(12))			
			end
		end
	RETURN @ID
END

--
go
CREATE FUNCTION funAutoCreateIDMaChiTietPhieuTra()
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @ID VARCHAR(15)
	DECLARE @maSo int = 1
	DECLARE @soLuong int = (SELECT COUNT(*) FROM ChiTietTraHang)
	
	IF (@soLuong = 0)
		SET @ID = 'CTPT' + cast(@maSo as varchar(12))
	ELSE
		begin
			set @ID = 'CTPT' + cast(@maSo+1 as varchar(12))
			while EXISTS
				(
					SELECT MaChiTietPhieuTra
					FROM ChiTietTraHang
					WHERE @ID = ChiTietTraHang.MaChiTietPhieuTra
				)
			begin
				set @maSo = @maSo + 1
				set @ID = 'CTPT' + cast(@maSo as varchar(12))			
			end
		end
	RETURN @ID
END
