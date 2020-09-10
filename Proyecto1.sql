/*create database Proyecto1IPC2
use Proyecto1IPC2

create table usuario(
id_usuario int primary key identity not null,
nombres varchar(50) not null,
apellidos varchar(50) not null,
usuario varchar(30) not null,
contra varchar(30) not null,
fechaNac varchar(30) not null,
pais varchar(50) not null,
correo varchar(50) not null
/*foreign key (id_partida) references partida(id_partida) on update cascade on delete cascade*/
);

create table partida(
	id_partida int primary key identity not null,
	partida_g xml not null,
	tipo_partida varchar(50) not null,
	movimientos int not null,
	pge varchar(30) not null
);

create table tablero(
	id_ficha int primary key identity not null,
	color varchar(20) not null,
	columna varchar(10) not null,
	fila varchar(10) not null,
	posicion int not null
);*/
select * from partida
/*delete usuario from usuario where nombres ='Ariel Rubelce';*/