

select Taxa.TaxaID, Clase.numeClasa, Elevi.nume, Elevi.prenume, Lunile.Luna, Taxa.DataAdmiterii, Taxa.Suma
from Taxa
inner join Clase on Clase.clasaID = Taxa.ClasaID
inner join Elevi on Elevi.eleviID = Taxa.NumeID
inner join Lunile on Lunile.LunaID = Taxa.LunaID


