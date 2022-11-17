CREATE TABLE [dbo].[Expediteur]
(
	[Id_exp] INT NOT NULL PRIMARY KEY,
	[Nom_exp] VARCHAR(25)  NOT NULL,
	[Prenom_exp] VARCHAR(25)  NOT NULL,
	[Telephone_exp] INT(9) NOT NULL,
	[Adresse_exp] VARCHAR(25)  NOT NULL
)
