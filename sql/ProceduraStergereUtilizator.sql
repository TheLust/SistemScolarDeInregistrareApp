CREATE PROCEDURE StergereUtilizator
(
@UtilizatorID int
)
AS
	BEGIN
		Delete From tblUtilizatori
		Where UtilizatorID = @UtilizatorID
	END
