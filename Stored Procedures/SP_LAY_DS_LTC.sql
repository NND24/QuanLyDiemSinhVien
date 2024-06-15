USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_DS_LTC]    Script Date: 15/06/2024 9:27:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_LAY_DS_LTC] @NienKhoa NVARCHAR(10), @HocKy INT, @Nhom INT, @MonHoc NCHAR(10)
AS
BEGIN
	SELECT MALTC, MONHOC.TENMH, NHOM, HOTEN = HO + ' ' + TEN
	FROM MONHOC 
	JOIN (LOPTINCHI JOIN (SELECT MAGV,HO,TEN FROM GIANGVIEN) GV ON LOPTINCHI.MAGV = GV.MAGV) 
	ON LOPTINCHI.MAMH = MONHOC.MAMH
	WHERE LOPTINCHI.NIENKHOA = @NienKhoa AND LOPTINCHI.HOCKY = @HocKy 
	AND LOPTINCHI.NHOM = @Nhom AND LOPTINCHI.MAMH = @MonHoc
END
