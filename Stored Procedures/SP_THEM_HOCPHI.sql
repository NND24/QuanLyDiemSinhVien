USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_HOCPHI]    Script Date: 15/06/2024 9:31:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_THEM_HOCPHI] @MaSV NCHAR(10), @NienKhoa NCHAR(9), @HocKy INT, @HocPhi INT
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM HOCPHI WHERE MASV=@MaSV AND NIENKHOA=@NienKhoa AND HOCKY=@HocKy)
		BEGIN
			INSERT INTO HOCPHI(MASV,NIENKHOA,HOCKY,HOCPHI)
			VALUES(@MaSV,@NienKhoa,@HocKy,@HocPhi)
		END
	ELSE
	  BEGIN
		RAISERROR('Sinh Viên Đã Có Thông Tin Học Phí Học Kỳ Này!',16,1)
	  END
END
