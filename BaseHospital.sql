drop database if exists Sist_Turnos;
create database Sist_Turnos;
use Sist_Turnos;


create table Paciente(
IdPaciente int auto_increment,
nombre varchar(50),
apellido varchar(50),
DNI varchar(20),
telefono varchar(20),
direccion varchar(50),
obra_social varchar(50),
constraint PK_Paciente primary key (IdPaciente)
);

create table turnos(
IdTurno int auto_increment,
IdPaciente int,
Fecha date,
horario time,
tipo varchar(20),
constraint PK_Turno primary key (IdTurno),
constraint FK_Paciente foreign key (IdPaciente) references Paciente(IdPaciente)
);

