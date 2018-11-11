-- Fill table
CREATE TABLE [dbo].[Giphies]
(
	[ID]			INT IDENTITY (1,1)	NOT NULL,
	[CurrentTime]	DATETIME			NULL,
	[InputTerm]		NVARCHAR(50)		NOT NULL,
	[IPAddress]		NVARCHAR(50)		NOT NULL,
	[BrowserType]	NVARCHAR(300)		NOT NULL,

	CONSTRAINT [PK_dbo.Giphies] PRIMARY KEY CLUSTERED ([ID] ASC)
);

GO