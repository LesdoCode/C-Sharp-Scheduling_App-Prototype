CREATE TABLE [dbo].[Workers] (
    [Id]          INT           NOT NULL IDENTITY DEFAULT 1 ,
    [Workerid]    NVARCHAR (13) NOT NULL,
    [Name]        NVARCHAR (30) NOT NULL,
    [Venuerating] INT           NOT NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([Id])
);

