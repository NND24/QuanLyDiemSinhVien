USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_MAKHOA]    Script Date: 06/04/2024 1:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_LAY_MAKHOA]
AS
BEGIN
	 select MaKhoa from Khoa
END
