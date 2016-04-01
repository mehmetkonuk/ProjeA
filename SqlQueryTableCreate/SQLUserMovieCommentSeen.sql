CREATE TABLE [dbo].[Users] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NULL,
    [Surname]     NVARCHAR (50)  NULL,
    [Nickname]    NVARCHAR (50)  NULL,
    [Password]    NVARCHAR (50)  NULL,
    [BirthofDate] DATETIME       NOT NULL,
    [Image]       IMAGE NULL,
    [Grade]       NVARCHAR (50)  NULL,
    [DateofReg]   DATE           NULL
);
CREATE TABLE [dbo].[Seen] (
    [ID]        INT  IDENTITY (1, 1) NOT NULL,
    [ByID]      INT  NULL,
    [MovieID]   INT  NULL,
    [Date]      DATE NOT NULL,
    [TotalSeen] INT  NULL
);
CREATE TABLE [dbo].[Movies] (
    [ID]         INT            NULL,
    [ByAdd]      INT            NULL,
    [Name]       NVARCHAR (50)  NULL,
    [Country]    NVARCHAR (50)  NULL,
    [Year]       NVARCHAR (50)  NULL,
    [Rank]       NVARCHAR (50)  NULL,
    [Categories] NVARCHAR (MAX) NULL,
    [Actors]     NVARCHAR (50)  NULL,
    [Image]      IMAGE NULL,
    [Path]       NVARCHAR (MAX) NULL,
    [Seen]       INT            NULL,
    [Rent]       INT            NULL,
    [Prize]      FLOAT (53)     NULL
);
CREATE TABLE [dbo].[Commends] (
    [ID]      INT           IDENTITY (1, 1) NOT NULL,
    [ByID]    INT           NULL,
    [MovieID] INT           NULL,
    [Content] NVARCHAR (50) NULL,
    [Date]    DATE          NOT NULL,
    [Spoiler] INT           NULL
);