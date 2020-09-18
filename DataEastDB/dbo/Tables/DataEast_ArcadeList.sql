CREATE TABLE [dbo].[DataEast_ArcadeList] (
    [Title]         NVARCHAR (50) NOT NULL,
    [Release_Date]  INT           NOT NULL,
    [Hardware_Type] NVARCHAR (50) NOT NULL,
    [Genre]         NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_DataEast_ArcadeList] PRIMARY KEY CLUSTERED ([Title] ASC)
);

