USE [QLTeam]
GO
/****** Object:  StoredProcedure [dbo].[GetTeam]    Script Date: 10/23/2021 11:51:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SearchNhanVien] 
	@HoTen nvarchar(max),
	@MaNhanVien nvarchar(max),
	@CapBacCode nvarchar(max),
	@CreatedTime nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @sql NVARCHAR(MAX) = '',
	@sqlWhere NVARCHAR(MAX) = 'WHERE 1=1',
	@sqlHoTen NVARCHAR(MAX) ='',
	@sqlMaNhanVien NVARCHAR(MAX) = '',
	@sqlCapBacCode NVARCHAR(MAX)='',
	@sqlCreateTime NVARCHAR(MAX) =''
	IF @HoTen IS NOT NULL AND @HoTen <> ''
	BEGIN
		SET @sqlHoTen = ' AND HoTen LIKE N''%' + @HoTen + '%''' 
	END
	IF @MaNhanVien IS NOT NULL AND @MaNhanVien <> ''
	BEGIN
		SET @sqlMaNhanVien = ' AND NhanVienID = '''+@MaNhanVien+''' '
	END
	IF @CapBacCode IS NOT NULL AND @CapBacCode <> ''
	BEGIN
		SET @sqlCapBacCode = ' AND CapBacCode = '''+@CapBacCode+''' '
	END
	IF @CreatedTime IS NOT NULL AND @CreatedTime <> ''

	BEGIN
		set @CreateTime = cast(@CreateTime as date)
		SET @sqlCreateTime = ' AND CONVERT(DATETIME,(CONVERT(VARCHAR(10), CreatedTime, 103)), 103) >= CONVERT(DATETIME, ''' + @CreatedTime+ ''', 103)'
	END
	set @sql = 'select * from NhanViens nv ' + @sqlWhere + @sqlHoTen + @sqlMaNhanVien + @sqlCapBacCode + @sqlCreateTime
	--SELECT @sql
	EXEC(@sql)
END
