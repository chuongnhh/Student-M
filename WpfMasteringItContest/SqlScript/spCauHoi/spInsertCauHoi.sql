-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
use DB_MITContest
go

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

CREATE PROCEDURE spDeleteDoiThi
	@maDoiThi int,
	@maHeThi int
AS
BEGIN
	delete from DoiThi where maDoiThi=@maDoiThi and maHeThi=@maHeThi
END

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