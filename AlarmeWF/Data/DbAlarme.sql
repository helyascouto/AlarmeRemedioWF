

create table Alarme(
id int primary key not null identity,
nome varchar(50),
fk_horarios int
foreign key (fk_horarios) references Horarios (id_horarios)
)

create table Horarios(
id_horarios int primary key not null identity,
horarios varchar(50)
)
delete from Alarme