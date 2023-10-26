create database SistemScolar
use SistemScolar

create table Judet(judetID int primary key identity(1, 1), numeJudet varchar(50))
create table Municipiu(municipiuID int primary key identity(1, 1), numeMunicipiu varchar(50), judetID int foreign key references Judet(judetID))
create table Oras(orasID int primary key identity(1, 1), numeOras varchar(50), municipiuID int foreign key references Municipiu(municipiuID))