CREATE PROCEDURE rapElevi
AS
BEGIN
	SELECT 	Elevi.eleviID, Elevi.nume, Elevi.prenume, Clase.numeClasa, Elevi.adresa, Elevi.email, Elevi.dataInregistrarii,
	Elevi.dataNasterii,Elevi.telefon, Elevi.sex, Judet.numeJudet, Municipiu.numeMunicipiu, Oras.numeOras
	FROM Elevi
	inner join Clase on Elevi.eleviID = Clase.clasaID
	inner join Judet on Elevi.judetID = Judet.judetID
	inner join Municipiu on Elevi.municipiuID = Municipiu.municipiuID
	inner join Oras on Elevi.orasID = Oras.orasID
END