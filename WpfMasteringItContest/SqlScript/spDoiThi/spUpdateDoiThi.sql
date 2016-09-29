USE [DB_MITContest]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateDoiThi]    Script Date: 4/8/2016 11:32:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spUpdateDoiThi]
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
