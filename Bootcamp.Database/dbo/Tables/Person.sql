CREATE TABLE [dbo].[Person] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (50) NULL,
    [Lastname]       VARCHAR (50) NULL,
    [DocumentTypeId] INT          NULL,
    [DocumentNumber] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([DocumentTypeId]) REFERENCES [dbo].[DocumentType] ([Id])
);

