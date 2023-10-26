CREATE PROCEDURE VerificareUtilizatori
@NumeUtilizator nvarchar(50),	
@Parola nvarchar(50)
AS
BEGIN
	SELECT * FROM tblUtilizatori
	Where [Nume Utilizator] = @NumeUtilizator or
	Parola = @Parola	
END

