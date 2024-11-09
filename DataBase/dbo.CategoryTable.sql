CREATE TABLE [dbo].CategoryTable
(
	[Id] INT NOT NULL  IDENTITY(1,1) , 
    [CategoryName] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_CategoryTable] PRIMARY KEY ([Id])
)
