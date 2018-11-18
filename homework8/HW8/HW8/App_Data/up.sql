--Create tables
CREATE TABLE dbo.Buyers
(
	BuyerID	INT IDENTITY (1,1)	NOT NULL,
	BuyerName NVARCHAR(100) NOT NULL,

	CONSTRAINT [PK_dbo.Buyers] PRIMARY KEY CLUSTERED (BuyerID ASC)
);

CREATE TABLE dbo.Sellers
(
	SellerID	INT IDENTITY (1,1)	NOT NULL,
	SellerName NVARCHAR(100) NOT NULL,

	CONSTRAINT [PK_dbo.Sellers] PRIMARY KEY CLUSTERED (SellerID ASC)
);


CREATE TABLE dbo.Items
(
	ItemID	INT IDENTITY (1001,1)	NOT NULL,
	ItemName NVARCHAR(100) NOT NULL,
	Description NVARCHAR(400) NOT NULL,
	SellerID INT NOT NULL,

	CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED (ItemID ASC),
	CONSTRAINT [FK_dbo.Items] FOREIGN KEY (SellerID) REFERENCES Sellers(SellerID)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

CREATE TABLE dbo.Bids
(
	BidID	INT IDENTITY (1,1)	NOT NULL,
	ItemID	INT NOT NULL,
	BuyerID INT NOT NULL,
	Price INT NOT NULL,
	Timestamp DATETIME NOT NULL,

	CONSTRAINT [PK_dbo.Bids] PRIMARY KEY CLUSTERED (BidID ASC),
	CONSTRAINT [FK1_dbo.Bids] FOREIGN KEY (ItemID) REFERENCES Items(ItemID)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT [FK2_dbo.Bids] FOREIGN KEY (BuyerID) REFERENCES Buyers(BuyerID)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

INSERT INTO dbo.Buyers(BuyerName) VALUES
	('Sam Hartman'),
	('Julie Steelback'),
	('Jackson Griffold')

INSERT INTO dbo.Sellers(SellerName) VALUES
	('Kate Kidson'),
	('George Giraffe'),
	('Tammy Tarans')

INSERT INTO dbo.Items(ItemName,Description,SellerID) VALUES
	('A Weird Painting', 'It is very weird looking so people want to pay a lot of money', 1),
	('A Cool Wallet', 'This Wallet is very cool', 1),
	('Yard Sign', 'Plain white yard sign', 2),
	('Snowball', 'A Snowball frozen 105 years ago', 3)

INSERT INTO dbo.Bids(ItemID, BuyerID, Price, Timestamp) VALUES
	(1001, 1, 400, '2018-11-11 11:15:14'),
	(1001, 3, 450, '2018-11-12 11:16:10'),
	(1001, 2, 500, '2018-11-13 03:30:14'),
	(1002, 1, 2000, '2018-11-13 04:12:44'),
	(1003, 3, 30, '2018-11-15 01:59:45'),
	(1003, 2, 31, '2018-11-17 09:16:33'),
	(1004, 2, 950, '2018-11-17 13:13:12')