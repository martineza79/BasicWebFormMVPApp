CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FIrstName] NVARCHAR(20) NOT NULL, 
    [LastName] NVARCHAR(30) NOT NULL, 
    [CardNumber] NUMERIC NOT NULL, 
    [CardExpire] DATETIME2 NOT NULL, 
    [CardType] NVARCHAR(50) NULL, 
    [CardCVN] NUMERIC NULL
)
