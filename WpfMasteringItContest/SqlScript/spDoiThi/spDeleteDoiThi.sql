USE [DB_MITContest]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteDoiThi]    Script Date: 4/8/2016 11:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spDeleteDoiThi]
	@maDoiThi int,
	@maHeThi int
AS
BEGIN
	delete from DoiThi where maDoiThi=@maDoiThi and maHeThi=@maHeThi
END
