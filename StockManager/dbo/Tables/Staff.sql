CREATE TABLE [dbo].[Staff]
(
	[Identifier] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [Grade] NCHAR(10) NOT NULL 
)


