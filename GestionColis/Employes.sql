CREATE TABLE [dbo].[Employes]
(
	[Id_emp] INT NOT NULL PRIMARY KEY,
	[Nom_emp] VARCHAR(25) NOT NULL,
	[Prenom_emp] VARCHAR(25) NOT NULL,
	[Email_emp] VARCHAR(10) NOT NULL, 
	[Telephone_emp] INT(10) NOT NULL, 
	[Poste_emp] VARCHAR(10) NOT NULL, 
	[Id_ag] INT(10) NOT NULL
)
