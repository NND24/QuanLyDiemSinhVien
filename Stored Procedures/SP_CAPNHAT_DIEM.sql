USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_DIEM]    Script Date: 15/06/2024 9:24:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_CAPNHAT_DIEM]
@DIEMTHI TYPE_DANGKY READONLY 
	
AS
BEGIN
	MERGE INTO DANGKY AS TARGET
	USING (SELECT MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK FROM @DIEMTHI) AS SOURCE
	ON TARGET.MALTC = SOURCE.MALTC AND TARGET.MASV = SOURCE.MASV 
	WHEN MATCHED THEN
		UPDATE SET TARGET.DIEM_CC = SOURCE.DIEM_CC,
				   TARGET.DIEM_GK = SOURCE.DIEM_GK,
				   TARGET.DIEM_CK = SOURCE.DIEM_CK
	WHEN NOT MATCHED THEN 
		INSERT ( MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK)
		 VALUES (SOURCE.MALTC, SOURCE.MASV, SOURCE.DIEM_CC, SOURCE.DIEM_GK, SOURCE.DIEM_CK);
END
