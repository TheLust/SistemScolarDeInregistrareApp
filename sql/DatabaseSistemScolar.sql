
CREATE DATABASE SistemScolar

GO

USE SistemScolar

GO

CREATE TABLE Judet(
	judetID INT PRIMARY KEY IDENTITY(1,1),
	numeJudet VARCHAR(50)
	)
	GO


CREATE TABLE Municipiu(
	municipiuID INT PRIMARY KEY IDENTITY(1,1),
	numeMunicipiu VARCHAR(50),
	judetID INT FOREIGN KEY REFERENCES Judet(judetID)
	)

	GO

CREATE TABLE Oras(
	orasID INT PRIMARY KEY IDENTITY(1,1),
	numeOras VARCHAR(50),
	municipiuID INT FOREIGN KEY REFERENCES Municipiu(municipiuID)
	)
	GO

INSERT INTO Judet VALUES
	('Satu Mare'),
	('Maramures'),
	('Bihor'),
	('Cluj')
	GO
SELECT * FROM Judet
GO
INSERT INTO Municipiu VALUES
	('Satu Mare',1),
	('Baia Mare',2),
	('Sighetu Marmatiei',2),
	('Marghita',3),
	('Cluj-Napoca',4)
	GO
SELECT * FROM Municipiu
GO
INSERT INTO Oras VALUES
	('Carei',1),
	('Ardud',1),
	('Negresti-Oas',1),
	('Baia Mare',2),
	('Firiza',2),
	('Valea Neagra',2),
	('Iapa',3),
	('Sugau',3),
	('Sighetu Marmatiei',3),
	('Chet',4),
	('Marghita',4),
	('Ghenetea',4),
	('Chet',4),
	('Campia Turzii',5),
	('Dej',5)
	GO
SELECT * FROM Oras
--creare tabel clasa
GO

CREATE TABLE Clase(
		clasaID INT PRIMARY KEY IDENTITY(1,1),
		numeClasa VARCHAR(50)
		)

GO

INSERT INTO Clase VALUES
	('Clasa IX'),
	('Clasa X'),
	('Clasa XI'),	
	('Clasa XII')

SELECT * FROM Clase

GO

CREATE TABLE Elevi(
	eleviID INT PRIMARY KEY IDENTITY(1,1),
	sex VARCHAR(50),
	nume VARCHAR(50),
	prenume VARCHAR(50),
	adresa VARCHAR(50),
	telefon VARCHAR(50),
	email VARCHAR(50),
	dataNasterii VARCHAR(50),
	dataInregistrarii VARCHAR(50),
	clasaID INT FOREIGN KEY REFERENCES Clase(clasaID),
	judetID INT FOREIGN KEY REFERENCES Judet(judetID),
	municipiuID INT FOREIGN KEY REFERENCES Municipiu(municipiuID),
	orasID INT FOREIGN KEY REFERENCES Oras(orasID)
	)
	GO
SELECT * FROM Elevi
GO
SELECT Elevi.eleviID, Elevi.nume, Elevi.prenume, Elevi.sex, Elevi.adresa, Elevi.telefon, Elevi.email, Elevi.dataNasterii, Elevi.dataInregistrarii,
Clase.numeClasa, Judet.numeJudet, Municipiu.numeMunicipiu, Oras.numeOras
FROM Elevi 
INNER JOIN Clase ON Elevi.clasaID=Clase.clasaID
INNER JOIN Judet ON Elevi.judetID=Judet.judetID
INNER JOIN Municipiu ON Elevi.municipiuID=Municipiu.municipiuID
INNER JOIN Oras ON Elevi.orasID=Oras.orasID
	GO
------------------------------Profesori-------------------
CREATE TABLE Experienta(
	experientaID INT PRIMARY KEY IDENTITY(1,1),
	experienta VARCHAR(50)
	)

	GO

INSERT INTO Experienta VALUES
	('C++'),
	('Java'),
	('C#'),
	('Python'),	
	('ASP.NET'),
	('PHP'),	
	('JavaScript')

	SELECT * FROM Experienta

	GO

CREATE TABLE Profesori(
	ProfesorID INT PRIMARY KEY IDENTITY(1,1),
	Nume VARCHAR(50),
	Prenume VARCHAR(50),
	Adresa VARCHAR(50),
	Telefon VARCHAR(50),
	Email VARCHAR(50),
	Sex VARCHAR(50),
	DataNasterii VARCHAR(50),
	ExperientaID INT FOREIGN KEY REFERENCES Experienta(experientaID),
	judetID INT FOREIGN KEY REFERENCES Judet(judetID),
	municipiuID INT FOREIGN KEY REFERENCES Municipiu(municipiuID),
	orasID INT FOREIGN KEY REFERENCES Oras(orasID)

	)
	GO
SELECT * FROM Profesori
GO
---------------Taxe--------------------
CREATE TABLE Lunile (
	LunaID INT PRIMARY KEY IDENTITY(1,1),
	Luna VARCHAR(50)
	)
	GO
INSERT INTO Lunile VALUES
	('Ianuarie'),
	('Februarie'),
	('Martie'),
	('Aprilie'),
	('Mai'),
	('Iunie'),
	('Iulie'),
	('August'),
	('Septembrie'),
	('Octombrie'),
	('Noiembrie'),
	('Decembrie')
	GO
	SELECT * FROM Lunile
	GO
CREATE TABLE Taxa(
	TaxaID INT PRIMARY KEY IDENTITY(1,1),
	ClasaID INT FOREIGN KEY REFERENCES Clase(clasaID),
	NumeID INT FOREIGN KEY REFERENCES Elevi(eleviID),
	PrenumeID INT FOREIGN KEY REFERENCES Elevi(eleviID),
	DataAdmiterii VARCHAR(50),
	LunaID INT FOREIGN KEY REFERENCES Lunile(LunaID),
	Suma INT
	)
	GO
	create table tbUtilizatori
(
    UtilizatorID int primary key identity(1,1),
    [Nume Utilizator] varchar(50) not null,
    Parola varchar(50) not null,
    Pozitia varchar(50) not null
)
go
create table tblAdmin
(
    Admin varchar(50) not null,
    Parola varchar(50) not null
)
go

SELECT * FROM tbUtilizatori
GO
INSERT INTO tbUtilizatori VALUES 
	('Maria Berinde', 'Parola05', 'Analist'),
	('Carmen Bodnar', 'Parola02', 'Ajutor Programator'),
	('Andreea Bodnar', 'Parola02', 'Ajutor Programator')










