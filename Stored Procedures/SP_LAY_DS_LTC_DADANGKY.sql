USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_DS_LTC_DADANGKY]    Script Date: 20/06/2024 9:53:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_LAY_DS_LTC_DADANGKY] 
    @NienKhoa NCHAR(9), 
    @HocKy INT, 
    @MaSV NCHAR(10)
AS
BEGIN
    SELECT 
        MALTC, 
        LTC.MAMH, 
        TENMH, 
        NHOM,
        GIANGVIEN=(SELECT HO + ' ' + TEN FROM GIANGVIEN WHERE GIANGVIEN.MAGV=LTC.MAGV),
        DADANGKY=(SELECT COUNT(*) FROM DANGKY DK WHERE DK.MALTC=LTC.MALTC AND (HUYDANGKY=0 OR HUYDANGKY IS NULL))
    FROM 
        (SELECT MALTC,NHOM,MAMH,MAGV FROM LOPTINCHI WHERE NIENKHOA = @NienKhoa AND HOCKY = @HocKy AND HUYLOP=0) LTC,
        (SELECT MAMH,TENMH FROM MONHOC) MH 
    WHERE 
		MH.MAMH = LTC.MAMH
        AND @MaSV IN (SELECT MASV FROM DANGKY WHERE DANGKY.MALTC=LTC.MALTC AND (HUYDANGKY=0 OR HUYDANGKY IS NULL));
END
