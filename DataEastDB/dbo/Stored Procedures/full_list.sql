CREATE PROCEDURE [dbo].[full_list]
AS
BEGIN
SELECT * FROM DataEast_ArcadeList ORDER BY Title;
END
