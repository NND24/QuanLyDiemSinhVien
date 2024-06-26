USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_DSSV_DANGKY_LTC]    Script Date: 6/14/2024 8:13:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_REPORT_DSSV_DANGKY_LTC]
    @NienKhoa NCHAR(9), @HocKy INT, @MaMH NCHAR(10), @Nhom INT
AS
BEGIN 
	 SELECT SV.MASV, SV.HO, SV.TEN, SV.PHAI, SV.MALOP FROM 
	 (SELECT MALTC, MAMH, NIENKHOA, HOCKY, NHOM FROM LOPTINCHI) AS LTC
	 JOIN (SELECT MALTC, MASV, HUYDANGKY FROM DANGKY) AS DK ON LTC.MALTC = DK.MALTC
	 JOIN (SELECT MASV, HO, TEN, PHAI, MALOP FROM SINHVIEN) AS SV ON DK.MASV = SV.MASV
	 WHERE NIENKHOA=@NienKhoa AND HOCKY=@HocKy AND MAMH=@MaMH AND NHOM=@Nhom AND (DK.HUYDANGKY=0 OR DK.HUYDANGKY IS NULL)
	 ORDER BY (SV.TEN + SV.HO)
END