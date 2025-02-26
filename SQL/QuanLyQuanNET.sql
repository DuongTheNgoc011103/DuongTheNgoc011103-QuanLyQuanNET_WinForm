create database QuanLyQuanNET
go
use QuanLyQuanNET

create table TAIKHOAN
(
	TaiKhoan nvarchar(100) not null,
	MatKhau nvarchar(100) not null,
	AnhAD nvarchar(MAX)
)
create table MAY
(
	MaMay varchar(6) not null,
	TenMay nvarchar(100),
	TrangThaiMay nvarchar(20),

	constraint PK_MAY primary key(MaMay)
)
CREATE SEQUENCE MAYSequence
START WITH 1
INCREMENT BY 1
GO
ALTER TABLE MAY
ADD DEFAULT ('MAY' + RIGHT('000'+CAST(NEXT VALUE FOR MAYSequence AS VARCHAR(3)),3)) FOR MaMay


create table KHACHHANG
(
	SDT varchar(10) not null,
	TenKH nvarchar(100),
	DiaChi nvarchar(200),

	constraint PK_KHACHHANG primary key(SDT)
)

create table DICHVU
(
	MaDV varchar(8) not null,
	TenDV nvarchar(100),
	DVTinh nvarchar(50),
	DonGia int not null,
	SoLuong float,
	HinhAnh nvarchar(max),

	constraint PK_DICHVU primary key(MaDV)
)
CREATE SEQUENCE DICHVUSequence
START WITH 1
INCREMENT BY 1
GO
ALTER TABLE DICHVU
ADD DEFAULT ('DV' + RIGHT('000000'+CAST(NEXT VALUE FOR DICHVUSequence AS VARCHAR(6)),6)) FOR MaDV



create table HOADON
(
	MaHD varchar(8) not null,
	SDT varchar(10) not null,
	MaMay varchar(6) not null,
	TGBatDau datetime,
	TGKetThuc datetime,
	TongTien int,
	TrangThaiHD nvarchar(20),

	constraint PK_HOADON primary key(MaHD),

	constraint FK_HOADON_KHACHHANG foreign key(SDT) references KHACHHANG(SDT),
	constraint FK_HOADON_MAY foreign key(MaMay) references MAY(MaMay)
)

CREATE SEQUENCE HOADONSequence
START WITH 1
INCREMENT BY 1
GO
ALTER TABLE HOADON
ADD DEFAULT ('HD' + RIGHT('000000'+CAST(NEXT VALUE FOR HOADONSequence AS VARCHAR(6)),6)) FOR MaHD

create table CTHOADON
(
	MaCTHD varchar(10) not null,
	MaHD varchar(8) not null,
	MaDV varchar(8) not null,
	DonGia int,
	SoLuong float,

	constraint PK_CTHOADON primary key(MaCTHD),

	constraint FK_CTHOADON_HOADON foreign key(MaHD) references HOADON(MaHD),
	constraint FK_CTHOADON_DICHVU foreign key(MaDV) references MAY(MaDV)
)

CREATE SEQUENCE CTHOADONSequence
START WITH 1
INCREMENT BY 1
GO
ALTER TABLE CTHOADON
ADD DEFAULT ('CTHD' + RIGHT('000000'+CAST(NEXT VALUE FOR CTHOADONSequence AS VARCHAR(6)),6)) FOR MaCTHD