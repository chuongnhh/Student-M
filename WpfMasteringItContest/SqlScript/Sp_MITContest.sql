
-- =============================================
-- Author:		NGUYỄN HOÀNG CHƯƠNG
-- Create date: 9/4/2016
-- Description:	Trường Đh SƯ PHẠM KỸ THUẬT TP HCM
-- =============================================

--=======================================================================================================================================
create database DB_MITContest
go

use DB_MITContest
go
-- =============================================

create table HeThi(
	maHeThi int primary key identity(1,1),
	tenHeThi nvarchar(100)
)
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
--=======================================================================================================================================
-- CÂU HỎI
-- =============================================
CREATE PROCEDURE spInsertCauHoi
	@tenCauHoi nvarchar(100),
	@noiDung nvarchar(MAX),
	@luaChonA nvarchar(MAX),
	@luaChonB nvarchar(MAX),
	@luaChonC nvarchar(MAX),
	@luaChonD nvarchar(MAX),
	@dapAnDUng nvarchar(10),
	@giaiThich nvarchar(MAX),
	@maTroChoi int
AS
BEGIN
	insert into CauHoi values(@tenCauHoi,@noiDung,@luaChonA,@luaChonB,@luaChonC,@luaChonD,@dapAnDUng,@giaiThich,@maTroChoi)
END
GO

CREATE PROCEDURE spDeleteCauHoi
	@maCauHoi int
AS
BEGIN
	delete from CauHoi where maCauHoi=@maCauHoi
END
GO

CREATE PROCEDURE spUpdateCauHoi
	@maCauHoi int,
	@tenCauHoi nvarchar(100),
	@noiDung nvarchar(MAX),
	@luaChonA nvarchar(MAX),
	@luaChonB nvarchar(MAX),
	@luaChonC nvarchar(MAX),
	@luaChonD nvarchar(MAX),
	@dapAnDUng nvarchar(10),
	@giaiThich nvarchar(MAX),
	@maTroChoi int
AS
BEGIN
	update CauHoi set tenCauHoi= @tenCauHoi,noiDung= @noiDung,
	luaChonA= @luaChonA, luaChonB= @luaChonB,luaChonC=@luaChonC,luaChonD=@luaChonD,
	dapAnDung=@dapAnDUng,giaiThich= @giaiThich,maTroChoi= @maTroChoi where maCauHoi=@maCauHoi
END
GO

-- ĐIỂM SÔ
-- =============================================
CREATE PROCEDURE spInsertDiemSo
	@maDoiThi int,
	@maTroChoi int,
	@maHeThi int,
	@diemSo float
AS
BEGIN
	insert into DiemSo values(@maDoiThi,@maTroChoi,@maHeThi,@diemSo)
END
GO

CREATE PROCEDURE spUpDateDiemSo
	@maDoiThi int,
	@maTroChoi int,
	@maHeThi int,
	@diemSo float
AS
BEGIN
	update DiemSo set diemSo=@diemSo where maDoiThi=@maDoiThi and maTroChoi=@maTroChoi and maHeThi=@maHeThi
END
GO

CREATE PROCEDURE spDeleteDiemSo
	@maDoiThi int,
	@maTroChoi int,
	@maHeThi int
AS
BEGIN
	delete DiemSo where maDoiThi=@maDoiThi and maTroChoi=@maTroChoi and maHeThi=@maHeThi
END
GO

-- ĐỘI THI
-- =============================================
CREATE PROCEDURE spInsertDoiThi
	@maHeThi int,
	@tenDoiThi nvarchar(100),
	@thanhVien1 nvarchar(100),
	@thanhVien2 nvarchar(100),
	@thanhVien3 nvarchar(100),
	@thanhVien4 nvarchar(100),
	@thanhVien5 nvarchar(100)
AS
BEGIN
	insert into DoiThi values(@maHeThi,@tenDoiThi,@thanhVien1,@thanhVien2,@thanhVien3,@thanhVien4,@thanhVien5)
END
GO

CREATE PROCEDURE spUpdateDoiThi
	@maDoiThi int,
	@maHeThi int,
	@tenDoiThi nvarchar(100),
	@thanhVien1 nvarchar(100),
	@thanhVien2 nvarchar(100),
	@thanhVien3 nvarchar(100),
	@thanhVien4 nvarchar(100),
	@thanhVien5 nvarchar(100)
AS
BEGIN
	update DoiThi set tenDoiThi=@tenDoiThi,
	thanhVien1=@thanhVien1,thanhVien2=@thanhVien2,thanhVien3=@thanhVien3,thanhVien4=@thanhVien4,thanhVien5=@thanhVien5
	where maDoiThi=@maDoiThi and maHeThi=@maHeThi
END
GO

CREATE PROCEDURE spDeleteDoiThi
	@maDoiThi int,
	@maHeThi int
AS
BEGIN
	delete from DoiThi where maDoiThi=@maDoiThi and maHeThi=@maHeThi
END
GO

-- HỆ THI
-- =============================================
CREATE PROCEDURE spInsertHeThi
	@tenHeThi nvarchar(100)
AS
BEGIN
	insert into HeThi values(@tenHeThi)
END
GO

CREATE PROCEDURE spUpdateHeThi
	@maHeThi int,
	@tenHeThi nvarchar(100)
AS
BEGIN
	update HeThi set tenHeThi=@tenHeThi  where maHeThi=@maHeThi
END
GO

CREATE PROCEDURE spDeleteHeThi
	@maHeThi int
AS
BEGIN
	delete from HeThi where maHeThi=@maHeThi
END
GO

-- HỆ THI
-- =============================================
CREATE PROCEDURE spInsertTroChoi
	@tenTroChoi nvarchar(100),
	@thoiGian int,
	@maHeThi int
AS
BEGIN
	insert into TroChoi values(@tenTroChoi,@thoiGian,@maHeThi)
END
GO

CREATE PROCEDURE spUpdateTroChoi
	@maTroChoi int,
	@tenTroChoi nvarchar(100),
	@thoiGian int,
	@maHeThi int
AS
BEGIN
	update TroChoi set tenTroChoi= @tenTroChoi, thoiGian=@thoiGian where maHeThi= @maHeThi
END
GO

CREATE PROCEDURE spDeleteTroChoi
	@maTroChoi int
AS
BEGIN
	delete from TroChoi where maTroChoi=@maTroChoi
END
GO
--=======================================================================================================================================