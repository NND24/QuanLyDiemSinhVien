USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_DS_MONHOC]    Script Date: 20/06/2024 10:07:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_LAY_DS_MONHOC] @NienKhoa NCHAR(9), @HocKy INT
	
AS
BEGIN
	SELECT MH.MAMH, MH.TENMH 
	FROM (SELECT MAMH FROM LOPTINCHI WHERE NIENKHOA = @NienKhoa AND HOCKY = @HocKy) LTC,
	(SELECT MAMH, TENMH FROM MONHOC) MH
	WHERE LTC.MAMH = MH.MAMH
    GROUP BY MH.MAMH, MH.TENMH
END
