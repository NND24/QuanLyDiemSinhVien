USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[SP_XEM_DIEM_SV]    Script Date: 6/19/2024 4:47:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[SP_XEM_DIEM_SV] @MaSV NCHAR(10)
AS
BEGIN
SELECT MH.MAMH, LTC.MALTC, LTC.HOCKY , MH.TENMH, DK.DIEM_CC, DK.DIEM_GK, DK.DIEM_CK,
(DIEM_CC * 0.1 + DIEM_GK*0.3 + DIEM_CK * 0.6) AS 'Điểm tổng kết'
FROM DANGKY AS DK
JOIN (SELECT MALTC, HOCKY, MAMH FROM LOPTINCHI) AS LTC ON DK.MALTC = LTC.MALTC
JOIN (SELECT MAMH, TENMH FROM MONHOC) AS MH ON MH.MAMH = LTC.MAMH
WHERE DK.MASV = @MaSV AND DK.HUYDANGKY = 0
ORDER BY LTC.HOCKY, MH.MAMH
END

Select * from MONHOC