CREATE TABLE [dbo].[StockMovement] (
    [Identifier]   INT           IDENTITY (1, 1) NOT NULL,
    [Date]         DATE          NULL,
    [EmployeeCode] INT NOT NULL,
    [IsStockEntry] BIT           NOT NULL,
    CONSTRAINT [PK_StockMovement] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_StockMovement_Staff] FOREIGN KEY ([EmployeeCode]) REFERENCES [dbo].[Staff] ([Identifier])
);

