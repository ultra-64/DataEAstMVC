
CREATE PROCEDURE [dbo].[GameByName] 
	@Title nvarchar (50)

AS
BEGIN

	SET NOCOUNT ON;

	SELECT *
	FROM dbo.DataEast_ArcadeList
	WHERE Title = @Title;
END
