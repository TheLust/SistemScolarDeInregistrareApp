CREATE PROCEDURE [dbo].[verificareAdmin]
@Admin nvarchar(50),
@Parola nvarchar(50)
AS
BEGIN
	
	SELECT * FROM tblAdmin
	WHERE [Admin] = @Admin AND Parola = @Parola

END

