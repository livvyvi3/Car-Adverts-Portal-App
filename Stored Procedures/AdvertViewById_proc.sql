CREATE PROC AdvertViewById
    @ID INT
AS 
    SELECT * 
    FROM Adverts
    WHERE Id = @Id