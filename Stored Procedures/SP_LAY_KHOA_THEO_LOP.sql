USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_KHOA_THEO_LOP]    Script Date: 20/06/2024 10:16:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_LAY_KHOA_THEO_LOP] @MaLop NCHAR(10)

AS
BEGIN
	SELECT TENKHOA=(SELECT TENKHOA FROM KHOA WHERE LOP.MAKHOA=KHOA.MAKHOA)
	FROM (SELECT MALOP,MAKHOA FROM LOP) LOP 
	WHERE LOP.MALOP = @MaLop
END
