CREATE TABLE [dbo].[Colis]
(
	[Id] INT NOT NULL PRIMARY KEY,
	 [Nom_colis] VARCHAR NOT NULL, 
	 [Valeur] INT(20) NOT NULL, 
	 [Description] VARCHAR(120) NOT NULL, 
	 Id_exp INT NOT NULL, 
	 Id_rec INT NOT NULL, 
	 Id_ag INT NOT NULL
)
