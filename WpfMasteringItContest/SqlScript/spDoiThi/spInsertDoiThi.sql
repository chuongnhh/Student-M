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
