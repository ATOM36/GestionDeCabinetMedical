CREATE TABLE Categorie
(
	CategorieId int PRIMARY KEY IDENTITY(1,19),
	NomCategorie char(30) unique
);

CREATE TABLE Produit
(
	Nom char(20) primary key,
	Categorie char(30) FOREIGN KEY REFERENCES Categorie(NomCategorie),
	Prix_Unitaire float,
	Quantite int
);

CREATE TABLE Horaire
(
	UserID int FOREIGN KEY REFERENCES Utilisateur(UserID),
	Nom char(20),
	Prenom char(20),
	Specialite char(20),
	Date_Presence char(10)
);
