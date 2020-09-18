--SELECT * FROM DataEast_ArcadeList ORDER BY Hardware_Type;


--UPDATE DataEast_ArcadeList SET Hardware_Type = 'JAMMA' where Title = 'Karnov''s Revenge';s

CREATE PROCEDURE [dbo].[GameByHardware]


AS 

BEGIN

SELECT * FROM DataEast_ArcadeList ORDER BY Hardware_Type, Title;

END 

