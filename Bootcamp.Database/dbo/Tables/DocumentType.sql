CREATE TABLE [dbo].[DocumentType] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50) NULL,
    [Shortname] VARCHAR (5)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

