use SistemScolar

create table Experienta(experientaID int primary key identity(1,1), experienta varchar(50))
insert into Experienta values('C++'), ('Java'), ('C#'), ('Python'), ('ASP.NET'), ('PHP'), ('JavaScipt')

select * from Experienta