USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_DS_LTC_DANGKY]    Script Date: 06/04/2024 1:05:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_LAY_DS_LTC_DANGKY] 
    @NienKhoa NCHAR(9), 
    @HocKy INT, 
    @MaSV NCHAR(10)
AS
BEGIN
    SELECT 
        MALTC, 
        LOPTINCHI.MAMH, 
        TENMH, 
        NHOM,
        GIANGVIEN=(SELECT HO + ' ' + TEN FROM GIANGVIEN WHERE GIANGVIEN.MAGV=LOPTINCHI.MAGV),
        DADANGKY=(SELECT COUNT(*) FROM DANGKY DK WHERE DK.MALTC=LOPTINCHI.MALTC AND (HUYDANGKY=0 OR HUYDANGKY IS NULL))
    FROM 
        LOPTINCHI
    JOIN 
        MONHOC ON MONHOC.MAMH = LOPTINCHI.MAMH
    WHERE 
        NIENKHOA=@NienKhoa 
        AND HOCKY=@HocKy 
        AND HUYLOP=0
        AND @MaSV NOT IN (SELECT MASV FROM DANGKY WHERE DANGKY.MALTC=LOPTINCHI.MALTC AND (HUYDANGKY=0 OR HUYDANGKY IS NULL));
END
