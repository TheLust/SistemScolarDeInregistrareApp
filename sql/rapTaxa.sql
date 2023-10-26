CREATE PROCEDURE rapTaxa
AS
BEGIN
	SELECT 	Taxa.TaxaID, Clase.clasaID, Elevi.nume, Elevi.prenume, Taxa.DataAdmiterii, Taxa.Suma, Lunile.Luna
	FROM Taxa
	inner join Clase on Taxa.TaxaID = Clase.clasaID
	inner join Elevi on Taxa.NumeID = Elevi.eleviID
	inner join Lunile on Taxa.LunaID = Lunile.LunaID	
END