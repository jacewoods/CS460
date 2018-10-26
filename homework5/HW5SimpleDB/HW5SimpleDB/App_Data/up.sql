-- Users table
CREATE TABLE [dbo].[Renters]
(
	[ID]			INT IDENTITY (1,1)	NOT NULL,
	[FirstName]		NVARCHAR(32)		NOT NULL,
	[LastName]		NVARCHAR(32)		NOT NULL,
	[PhoneNumber]	NVARCHAR(12)		NOT NULL,
	[ApartmentName]	NVARCHAR(64)		NOT NULL,
	[UnitNumber]	SMALLINT		NOT NULL,
	[Explanation]	NVARCHAR(120)		NOT NULL,
	CONSTRAINT [PK_dbo.Renters] PRIMARY KEY CLUSTERED ([ID] ASC)
);

INSERT INTO [dbo].[Renters] (FirstName, LastName, PhoneNumber, ApartmentName, UnitNumber, Explanation) VALUES
	('Sam', 'Samson', '503-444-5555', 'Westfield Apartments', '280', 'Fridge Exploded'),
	('John', 'Roberts', '971-888-8889', 'Clearwater Apartments', '300', 'Fridge Split in Half'),
	('Theresa', 'King', '503-999-9990', 'Ridgeview Apartments', '1002', 'Fridge ate my Homework'),
	('Jane', 'Thomas', '971-111-1112', 'Ridgeview Apartments', '80', 'Fridge is on Fire'),
	('Bill', 'Smith', '503-333-3336', 'Westfield Apartments', '85', 'Fridge is being mean to me')
GO