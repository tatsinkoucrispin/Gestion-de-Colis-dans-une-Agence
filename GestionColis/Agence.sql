CREATE TABLE [dbo].[Agence]
(
	[Id_ag] INT NOT NULL PRIMARY KEY,
	[Nom_ag] VARCHAR(25) NOT NULL,
	[Localisation] VARCHAR(50) NOT NULL,
	[Adresse] VARCHAR(50) NOT NULL,
	[Numero] INT(9)
)
