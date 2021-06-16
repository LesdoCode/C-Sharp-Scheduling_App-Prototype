CREATE TABLE [dbo].[Service] (
    [Serviceid] NVARCHAR (30) NOT NULL,
    [Starttime] TIME (5)      NOT NULL,
	[Duration] TIME (6)      NOT NULL, 
    CONSTRAINT [PK_Service] PRIMARY KEY ([Serviceid]),
    
);

