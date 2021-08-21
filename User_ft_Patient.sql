create table Utilisateur
(
	UserID int identity(1,7) primary key,
	UserName char(20) unique,
	CodeSecurite char(20),
	Nom char(20),
	Prenom char(20),
	Statut char(20)
);




create table Patient
(
	PatientID int primary key identity(1,5),
	DocteurID int foreign key references Utilisateur(UserID),
	SecretaireID int foreign key references Utilisateur(UserID),
	NomPatient char(30),
	PrenomPatient char(30),
	Age int,
	Poids float,
	CauseAdmission char(100),
	DateAdmission char(10)
);