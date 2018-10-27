﻿-- Users table
CREATE TABLE [dbo].[Renters]
(
	[ID]			INT IDENTITY (1,1)	NOT NULL,
	[FirstName]		NVARCHAR(20)		NOT NULL,
	[LastName]		NVARCHAR(20)		NOT NULL,
	[PhoneNumber]	NVARCHAR(12)		NOT NULL,
	[ApartmentName]	NVARCHAR(30)		NOT NULL,
	[UnitNumber]	INT					NOT NULL,
	[Explanation]	NVARCHAR(60)		NOT NULL,
	[Permission]	BIT					NOT NULL,
	CONSTRAINT [PK_dbo.Renters] PRIMARY KEY CLUSTERED ([ID] ASC)
);

INSERT INTO [dbo].[Renters] (FirstName, LastName, PhoneNumber, ApartmentName, UnitNumber, Explanation, Permission) VALUES
	('Sam', 'Samson', '503-444-5555', 'Westfield Apartments', '280', 'Freezer Exploded', 0),
	('John', 'Roberts', '971-888-8889', 'Clearwater Apartments', '300', 'Bathroom door split in half', 1),
	('Theresa', 'King', '503-999-9990', 'Ridgeview Apartments', '1002', 'The pool water is green', 0),
	('Jane', 'Thomas', '971-111-1112', 'Ridgeview Apartments', '80', 'Washing Machine is giving attitude', 1),
	('Bill', 'Smith', '503-333-3336', 'Westfield Apartments', '85', 'The Carpet has been stolen', 1)
GO