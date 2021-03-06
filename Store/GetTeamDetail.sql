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
ALTER PROCEDURE [dbo].[GetTeamDetail] 
	@TeamId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    select cast(ROW_NUMBER() OVER(ORDER BY nv.NhanVienID ASC) as int) AS TeamDetailID,
	nv.TeamID,
	1 as NhomQuyenID,
	nv.CapBacCode,
	nv.CapBacCode as CapBacName,
	nv.NhanVienID,
	nv.CreatedBy,
	nv.CreatedTime,
	nv.UpdatedTime,
	nv.UpdatedBy,
	nv.MaNhanVien,
	nv.HoTen,
	t.TeamCode,
	t.TeamName,
	t.MoTa,
	t.CongTyID
	from Teams t 
	join NhanViens nv on t.TeamID=nv.TeamID
	where t.TeamID=@TeamId
END
