--SELECT * FROM DataEast_ArcadeList ORDER BY Hardware_Type;


--UPDATE DataEast_ArcadeList SET Hardware_Type = 'JAMMA' where Title = 'Karnov''s Revenge';s

CREATE PROCEDURE [dbo].[GameByDate]


AS 

BEGIN

SELECT * FROM DataEast_ArcadeList ORDER BY Release_Date, Title;


END 

