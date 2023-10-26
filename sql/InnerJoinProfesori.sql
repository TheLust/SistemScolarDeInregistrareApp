

select Profesori.ProfesorID, Profesori.Nume, Profesori.Prenume, Profesori.Adresa,
Profesori.Telefon, Profesori.Email, Profesori.DataNasterii, Profesori.Sex, 
Experienta.experienta, Judet.numeJudet, Municipiu.numeMunicipiu, Oras.numeOras
from Profesori
inner join Experienta on Experienta.experientaID = Profesori.ExperientaID
inner join Judet on Judet.judetID = Profesori.judetID
inner join Municipiu on Municipiu.municipiuID = Profesori.municipiuID
inner join Oras on Oras.orasID  = Profesori.orasID
