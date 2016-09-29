-- =============================================
-- Author:		NGUYỄN HOÀNG CHƯƠNG
-- Create date: 9/4/2016
-- Description:	Trường Đh SƯ PHẠM KỸ THUẬT TP HCM
-- =============================================

create database DB_MITContest
go

use DB_MITContest
go
--===========================

create table HeThi(
	maHeThi int primary key identity(1,1),
	tenHeThi nvarchar(100)
)
go


use DB_MITContest
go
create table TroChoi(
	maTroChoi int primary key identity(1,1),
	tenTroChoi nvarchar(100),
	thoiGian int,
	maHeThi int,

	foreign key(maHeThi) references HeThi(maHeThi)
)
go

create table CauHoi(
	maCauHoi int primary key identity(1,1),
	tenCauHoi nvarchar(100),
	noiDung nvarchar(MAX),

	-- Dap an lua chon
	luaChonA nvarchar(MAX),
	luaChonB nvarchar(MAX),
	luaChonC nvarchar(MAX),
	luaChonD nvarchar(MAX),
	-- Dap an dung
	dapAnDung nvarchar(10),-- A-B-C-hoac D
	giaiThich nvarchar(MAX),
	-- khoa ngoai
	maTroChoi int,
	foreign key(maTroChoi) references TroChoi(maTroChoi)
)
go

create table DoiThi(
	maDoiThi int identity(1,1),
	maHeThi int,
	tenDoiThi nvarchar(100),

	primary key(maDoiThi,maHeThi),
	foreign key(maHeThi) references HeThi(maHeThi),
	thanhVien1 nvarchar(100),
	thanhVien2 nvarchar(100),
	thanhVien3 nvarchar(100),
	thanhVien4 nvarchar(100),
	thanhVien5 nvarchar(100)
)
go

create table DiemSo(
	maDoiThi int,
	maTroChoi int,
	maHeThi int,
	diemSo int,

	primary key(maDoiThi,maTroChoi,maHeThi),
	foreign key (maDoiThi,maHeThi) references DoiThi(maDoiThi,maHeThi),
	foreign key (maTroChoi) references TroChoi(maTroChoi)
)
go