drop database dbBancoApp;
create database dbBancoApp;
use dbBancoApp;

create table tbusuario(
idUsu int primary key auto_increment,
nomeUsu varchar(50) not null,
Cargo varchar(50) not null,
DataNasc datetime);

insert into tbusuario(nomeUsu, Cargo, DataNasc)
	values('Nilson', 'Gerente', '1978/05/01'),
	('Bruno', 'Colaborador', '2000/10/12');

select*from tbusuario;

