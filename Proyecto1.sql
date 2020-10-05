/*create database Proyecto1IPC2
use Proyecto1IPC2

create table usuario(
id_usuario int primary key identity not null,
nombres varchar(50) not null,
apellidos varchar(50) not null,
usuario varchar(30) not null,
contra varchar(30) not null,
fechaNac date not null,
pais varchar(50) not null,
correo varchar(50) not null
);

create table partida(
	id_partida int primary key identity not null,
	partida_g xml not null,
	tipo_partida varchar(50) not null,
	color varchar(20) not null,
	movimientos int not null,
	pge varchar(30) not null,
	id_usuario int not null,
	foreign key (id_usuario) references usuario(id_usuario) on update cascade on delete cascade
);

create table torneo(
	id_torneo int primary key identity not null,
	cant_jugadores int not null,
	ganador varchar(20) not null,
	id_usuario int not null,
	foreign key (id_usuario) references usuario(id_usuario) on update cascade on delete cascade
);

create table ronda(
	id_ronda int primary key identity not null,
	cant_ronda int not null,
	id_torneo int not null,
	foreign key (id_torneo) references torneo(id_torneo) on update cascade on delete cascade
);

create table partida_T(
	id_partida_T int primary key identity not null,
	partida_g xml not null,
	movimientos int not null,
	pge varchar(20) not null,
	id_ronda int not null,
	foreign key (id_ronda) references ronda(id_ronda) on update cascade on delete cascade
);

create table reporte(
	id_reporte int primary key identity not null,
	cant_ganado int not null,
	cant_perdido int not null,
	cant_empate int not null,
	cant_T_participado int not null,
	cant_T_perdido int not null,
	cant_T_ganado int not null,
	id_usuario int not null,
	foreign key (id_usuario) references usuario(id_usuario) on update cascade on delete cascade
);*/

select * from usuario
select * from partida
select * from torneo
select * from ronda
select * from partida_T
select * from reporte

drop table partida