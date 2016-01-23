CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[FirstName] nvarchar NOT NULL,
	[SecondName] nvarchar NULL,
	[LastName] nvarchar NOT NULL,
	[Gender] int NOT NULL,
	[DateOfBirth] Date NOT NULL,
	[Address] nvarchar NOT NULL,
	[City] nvarchar NOT NULL,
	[CurrentCountry] nvarchar NOT NULL,
	[BirthCountry] nvarchar NULL
	)
