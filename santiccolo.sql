create database LoginCore;
use LoginCore;

create table Cliente(
Id int auto_increment primary key,
Nome varchar(50) not null,
Nascimento datetime not null,
Sexo char(1),
CPF varchar(11) not null,
Telefone varchar(14) not null,
Email varchar (50),
Senha varchar(8) not null,
ConfirmacaoSenha varchar(8) not null,
Situacao char(1) not null
);

create table Colaborador(
Id int auto_increment primary key,
Nome varchar(50) not null,
Email varchar (50),
Senha varchar(8) not null,
Tipo varchar(8) not null
);