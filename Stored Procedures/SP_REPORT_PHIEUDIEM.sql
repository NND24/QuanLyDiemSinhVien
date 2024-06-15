USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_PHIEUDIEM]    Script Date: 15/06/2024 9:31:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_REPORT_PHIEUDIEM] @MaSV nchar(10)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM SINHVIEN WHERE MASV=@MaSV)
		BEGIN
			SELECT TENMH, DIEM=MAX(DIEM_CC*0.1+DIEM_GK*0.3+DIEM_CK*0.6)
			FROM (SELECT MALTC, DIEM_CC, DIEM_CK, DIEM_GK FROM DANGKY WHERE MASV= @MaSV AND (DANGKY.HUYDANGKY =0 OR DANGKY.HUYDANGKY IS NULL)) DK
			JOIN (SELECT LOPTINCHI.MALTC, MONHOC.TENMH
				  FROM LOPTINCHI JOIN MONHOC ON LOPTINCHI.MAMH = MONHOC.MAMH
				  WHERE LOPTINCHI.HUYLOP = 0) as LTC ON DK.MALTC = LTC.MALTC
			GROUP BY LTC.TENMH
			ORDER BY LTC.TENMH
		END
	ELSE
		BEGIN
			RAISERROR('Sinh viên không tồn tại',16,1);
			RETURN 0;
		END
END
