USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_DS_HOCKY]    Script Date: 06/04/2024 1:04:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_LAY_DS_HOCKY] @NienKhoa NCHAR(9)
	
AS
BEGIN
	SELECT HOCKY FROM LOPTINCHI WHERE NIENKHOA = @NienKhoa GROUP BY HOCKY
END
