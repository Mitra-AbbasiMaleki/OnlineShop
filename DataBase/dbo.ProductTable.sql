CREATE TABLE [dbo].Product
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [CategoryName] NVARCHAR(50) NULL, 
    [Quantity] INT NOT NULL, 
    [IsAvailable] BIT NULL
)
