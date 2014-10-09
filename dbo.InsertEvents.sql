CREATE PROCEDURE dbo.InsertEvents
(
    @EventName  VARCHAR (50),
	@EventLocation VARCHAR (50),
	@StartTime  VARCHAR (50),
	@EndTime    VARCHAR (50)
	)
AS
    SET NOCOUNT OFF;
INSERT INTO [dbo].[EMEvents] ([EventName], [EventLocation], [StartTime], [EndTime]) VALUES (@EventName, @EventLocation, @StartTime, @EndTime);

RETURN 0