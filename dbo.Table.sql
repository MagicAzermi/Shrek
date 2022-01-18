CREATE TABLE [dbo].[scoreBoard]
(
    [Date] DATETIME NOT NULL, 
    [PlayerName] VARCHAR(50) NULL, 
    [CurrentScore] INT NULL, 
    CONSTRAINT [PK_scoreBoard] PRIMARY KEY ([Date])
)
