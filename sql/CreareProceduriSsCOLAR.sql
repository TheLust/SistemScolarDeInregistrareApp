CREATE PROCEDURE rapElevi
AS
BEGIN
	SELECT Elevi.eleviID, Elevi.nume, Elevi.prenume, Clase.numeClasa, Elevi.adresa, Elevi.email, Elevi.dataInregistrarii,
	Elevi.dataNasterii, Elevi.telefon, Elevi.sex, Judet.numeJudet, Municipiu.numeMunicipiu, Oras.numeOras
	FROM Elevi
	INNER JOIN Clase ON Elevi.eleviID = Clase.clasaID
	INNER JOIN Judet ON Elevi.judetID = Judet.judetID
	INNER JOIN Municipiu ON Elevi.municipiuID = Municipiu.municipiuID
	INNER JOIN Oras ON Elevi.orasID = Oras.orasID
END

GO

CREATE PROCEDURE rapTaxa
AS
BEGIN
	SELECT Taxa.TaxaID, Clase.clasaID, Elevi.nume, Elevi.prenume, Taxa.DataAdmiterii, Taxa.Suma, Lunile.Luna
	FROM Taxa
	INNER JOIN Clase ON	Taxa.TaxaID = Clase.clasaID
	INNER JOIN Elevi ON Taxa.NumeID = Elevi.eleviID
	INNER JOIN Lunile ON Taxa.LunaID = Lunile.LunaID
END

GO

CREATE PROCEDURE AdaugareUtilizator
(
@numeUtilizator AS NVARCHAR(50),
@Parola AS NVARCHAR(50),
@Pozitia AS NVARCHAR(50)
)
AS
	BEGIN
		INSERT INTO tblUtilizatori([Nume Utilizator], Parola, Pozitia)
		VALUES (@NumeUtilizator, @Parola, @Pozitia)
	END

	GO

CREATE PROCEDURE VerificareUtilizatori
@NumeUtilizator NVARCHAR(50),
@Parola NVARCHAR(50)
AS
	BEGIN
		SELECT * FROM tblUtilizatori
		WHERE [Nume Utilizator] = @NumeUtilizator or
		Parola = @Parola
	END

	GO

CREATE PROCEDURE ActualizareUtilizatori
@UtilizatorID INT,
@NumeUtilizator NVARCHAR(50),
@Parola NVARCHAR(50),
@Pozitia NVARCHAR(50)
AS
	BEGIN
		UPDATE tblUtilizatori SET [Nume Utilizator] = @NumeUtilizator, Parola = @Parola, Pozitia = @Pozitia
		WHERE UtilizatorID = @UtilizatorID
	END

	GO

CREATE PROCEDURE StergereUtilizator
@UtilizatorID INT
AS
	BEGIN
		DELETE FROM tblUtilizatori
		WHERE UtilizatorID = @UtilizatorID
	END

	GO

CREATE PROCEDURE [dbo].[isAdminValid]
(
@Admin NVARCHAR(50),
@Parola NVARCHAR(50)
)
AS
	BEGIN
		DECLARE @isAdminValid BIT
		SET @isAdminValid = 0

		IF EXISTS (SELECT * FROM tblAdmin WHERE [Admin] = @Admin
					AND Parola = @Parola)
		BEGIN
		SET @isAdminValid = 1
		END

		SELECT @isAdminValid
	END

	GO






