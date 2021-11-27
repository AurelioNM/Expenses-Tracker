CREATE TABLE [dbo].[ExpenseTbl]
(
	[ExpId] INT NULL PRIMARY KEY IDENTITY, 
    [ExpName] VARCHAR(50) NULL, 
    [ExpAmt] INT NULL, 
    [ExpCat] VARCHAR(50) NULL, 
    [ExpDate] DATE NULL, 
    [ExpComment] VARCHAR(100) NULL, 
    [ExpUser] VARCHAR(50) NULL
)
