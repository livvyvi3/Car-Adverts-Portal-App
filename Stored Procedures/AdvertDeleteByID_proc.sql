CREATE PROC AdvertDeleteByID
@Id int
AS 
	DELETE FROM Adverts 
	WHERE Id = @Id