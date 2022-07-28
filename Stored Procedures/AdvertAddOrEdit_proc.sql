CREATE PROC AdvertAddOrEdit
    @Id INT , 
    @Make VARCHAR(50), 
    @Model VARCHAR(50) , 
    @Year VARCHAR(4), 
    @Color VARCHAR(50) , 
    @Condition VARCHAR(50) , 
    @Price FLOAT , 
    @Images IMAGE, 
    @Doors INT , 
    @Status VARCHAR(50)
AS
    IF @Id = 0
        INSERT INTO Adverts(Make, Model, Year, Color, Condition, Price, Images, Doors, Status)
        VALUES (@Make, @Model, @Year, @Color, @Condition, @Price, @Images, @Doors, @Status)
    ELSE 
    UPDATE Adverts
    SET 
    Make = @Make,
    Model = @Model,
    Year = @Year,
    Color = @Color,
    Condition = @Condition,
    Price = @Price,
    Images = @Images,
    Doors = @Doors,
    Status = @Status
    WHERE Id = @Id
