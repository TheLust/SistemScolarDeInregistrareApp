
select Elevi.eleviID, Elevi.nume, Elevi.prenume, Elevi.sex, Elevi.adresa, Elevi.telefon, Elevi.email, Elevi.dataNasterii,Elevi.dataInregistrarii,
Clase.numeClasa, Judet.numeJudet, Municipiu.numeMunicipiu, Oras.numeOras
from Elevi
inner join Clase
on
Elevi.clasaID = Clase.clasaID
inner join Judet
on
Elevi.judetID = Judet.judetID
inner join Municipiu
on
Elevi.municipiuID = Municipiu.municipiuID
inner join Oras
on
Elevi.orasID = Oras.orasID
