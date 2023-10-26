CREATE PROCEDURE ActualizareUtilizatori
@UtilizatorID int,
@NumeUtilizator nvarchar(50),	
@Parola nvarchar(50),
@Pozitia nvarchar(50)
AS
BEGIN
	UPDATE tblUtilizatori SET [Nume Utilizator] = @NumeUtilizator, Parola = @Parola, Pozitia = @Pozitia
	Where UtilizatorID = @UtilizatorID
END