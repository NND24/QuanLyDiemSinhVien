USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_HOCPHI]    Script Date: 08/05/2024 4:29:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_CAPNHAT_HOCPHI] 
    @MaSV NCHAR(10),
    @NienKhoa NCHAR(9),
    @HocKy INT,
    @HocPhi INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM CT_DONGHOCPHI WHERE MASV = @MaSV AND NIENKHOA = @NienKhoa AND HOCKY = @HocKy)
    BEGIN
        RAISERROR('Sinh Viên Đã Đóng Học Phí! Không Thể Sửa!', 16, 1)
    END
    ELSE
    BEGIN
        UPDATE HOCPHI 
        SET HOCPHI = @HocPhi 
        WHERE MASV = @MaSV AND NIENKHOA = @NienKhoa AND HOCKY = @HocKy
    END
END
