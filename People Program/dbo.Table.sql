CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[FirstName] nvarchar NOT NULL,
	[SecondName] nvarchar NULL,
	[LastName] nvarchar NOT NULL,
	[Gender] int NOT NULL,
	[DateOfBirth] Date NULL,
	[Address] nvarchar NOT NULL,
	[CurrentCity] nvarchar NOT NULL,
	[BirthCountry] nvarchar NULL,
	[CurrentCountry] nvarchar NULL
)
