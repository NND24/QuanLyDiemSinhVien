USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_DONG_HOCPHI]    Script Date: 15/06/2024 9:25:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_DONG_HOCPHI] 
    @MaSV NCHAR(10),
    @NienKhoa NCHAR(9),
    @HocKy INT,
	@NgayDong DATE,
	@SoTienDong INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM CT_DONGHOCPHI WHERE MASV = @MaSV AND NIENKHOA = @NienKhoa AND HOCKY = @HocKy AND NGAYDONG = @NgayDong)
    BEGIN
        RAISERROR('Sinh Viên Đã Đóng Học Phí!', 16, 1)
    END
    ELSE
    BEGIN
        INSERT INTO CT_DONGHOCPHI(MASV,NIENKHOA,HOCKY,NGAYDONG,SOTIENDONG)
		VALUES (@MaSV,@NienKhoa,@HocKy,@NgayDong,@SoTienDong)
    END
END
