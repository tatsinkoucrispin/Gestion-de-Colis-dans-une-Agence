CREATE TABLE [dbo].[Recepteur]
(
	[Id_rec] INT NOT NULL PRIMARY KEY,
	[Nom_rec] VARCHAR(25)  NOT NULL,
	[Prenom_rec] VARCHAR(25)  NOT NULL,
	[Telephone_rec] INT(9) NOT NULL,
	[Adresse_rec] VARCHAR(25)  NOT NULL
)
