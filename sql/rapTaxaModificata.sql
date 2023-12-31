USE [SistemScolar]
GO
/****** Object:  StoredProcedure [dbo].[rapTaxa]    Script Date: 07/06/2020 12:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[rapTaxa]
AS
BEGIN
	SELECT 	Taxa.TaxaID, Clase.numeClasa, Elevi.nume, Elevi.prenume, Taxa.DataAdmiterii, Taxa.Suma, Lunile.Luna
	FROM Taxa
	inner join Clase on Taxa.TaxaID = Clase.clasaID
	inner join Elevi on Taxa.NumeID = Elevi.eleviID
	inner join Lunile on Taxa.LunaID = Lunile.LunaID	
END