CREATE TABLE [dbo].[EMEvents] (
    [EventName]     VARCHAR (50) NOT NULL,
    [EventLocation] VARCHAR (50) NULL,
    [StartDate]     DATETIME     NULL,
    [StartTime]     VARCHAR (50) NULL,
    [EndDate]       DATETIME     NULL,
    [EndTime]       VARCHAR (50) NULL,
    [Caterer]       VARCHAR (50) NULL,
    [Bar]           VARCHAR (50) NULL,
    [Florist]       VARCHAR (50) NULL,
    [A/V Rental]    VARCHAR (50) NULL,
    [Installer]     VARCHAR (50) NULL,
    [Attachments]   VARCHAR (50) NULL,
    [Notes]         VARCHAR (50) NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([EventName] ASC)
);

