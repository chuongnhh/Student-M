USE [DB_MITContest]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCauHoi]    Script Date: 4/8/2016 11:40:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spUpdateCauHoi]
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
