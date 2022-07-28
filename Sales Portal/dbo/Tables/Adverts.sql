CREATE TABLE [dbo].[Advert]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Make] VARCHAR(50) NOT NULL, 
    [Model] VARCHAR(50) NOT NULL, 
    [Year] VARCHAR(4) NOT NULL, 
    [Color] VARCHAR(50) NOT NULL, 
    [Condition] VARCHAR(50) NOT NULL, 
    [Price] FLOAT NOT NULL, 
    [Images] IMAGE NOT NULL, 
    [Doors] INT NOT NULL, 
    [Status] VARCHAR(50) NOT NULL
)