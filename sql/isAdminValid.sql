CREATE PROCEDURE [dbo].[isAdminValid]
(
@Admin NVARCHAR(50),
@Parola NVARCHAR(50)
)
AS
	BEGIN

		DECLARE @IsAdminValid BIT
		SET @IsAdminValid = 0

		IF EXISTS(SELECT * FROM tblAdmin WHERE [Admin] = @Admin
										AND Parola = @Parola)										
		BEGIN
		SET @IsAdminValid = 1
		END

		SELECT @IsAdminValid
	END

	GO

CREATE PROCEDURE [dbo].[isUtilizatorValid]
(
@NumeUtilizator NVARCHAR(50),
@Parola NVARCHAR(50)
)
AS
	BEGIN

		DECLARE @IsAdminValid BIT
		SET @IsAdminValid = 0

		IF EXISTS(SELECT * FROM tblUtilizatori WHERE [Nume Utilizator] = @NumeUtilizator
										AND Parola = @Parola)										
		BEGIN
		SET @IsAdminValid = 1
		END

		SELECT @IsAdminValid
	END


	SELECT * FROM tblUtilizatori
