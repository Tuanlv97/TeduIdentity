USE [TeduIdentity]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS ( SELECT *
FROM sysobjects
WHERE  id = object_id(N'[Get_Permission_ByRoleId]')
	and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
	DROP PROCEDURE [Get_Permission_ByRoleId]
END

GO
CREATE PROCEDURE [Get_Permission_ByRoleId]
	@roleId varchar(50) null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT *
	FROM [Identity].Permissions WHERE RoleId = @roleId
END