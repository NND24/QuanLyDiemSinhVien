USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_HOCPHI]    Script Date: 15/06/2024 9:32:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_XOA_HOCPHI] 
    @MaSV NCHAR(10),
    @NienKhoa NCHAR(9),
    @HocKy INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM CT_DONGHOCPHI WHERE MASV=@MaSV AND NIENKHOA=@NienKhoa AND HOCKY=@HocKy)
		BEGIN
			RAISERROR('Sinh Viên Đã Đóng Học Phí! Không Thể Xóa!',16,1)
		END
	ELSE
	  BEGIN
			DELETE FROM HOCPHI
			WHERE MASV=@MaSV AND NIENKHOA=@NienKhoa AND HOCKY=@HocKy
	  END
END
