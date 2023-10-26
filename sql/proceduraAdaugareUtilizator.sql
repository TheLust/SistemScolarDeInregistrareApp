CREATE PROCEDURE AdaugareUtilizator
(
@NumeUtilizator AS NVARCHAR(50),
@Parola AS NVARCHAR(50),
@Pozitia AS NVARCHAR(50)
)
AS
	BEGIN
		INSERT INTO tblUtilizatori ([Nume Utilizator], Parola, Pozitia)
		Values (@NumeUtilizator, @Parola, @Pozitia)
	END