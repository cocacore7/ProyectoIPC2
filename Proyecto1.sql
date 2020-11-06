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
	estado int not null,
	nombre varchar(20) not null,
	tipo_partida varchar(50) not null,
	color varchar(20) not null,
	puntos int not null,
	pge varchar(30) not null,
	id_usuario int not null,
	foreign key (id_usuario) references usuario(id_usuario) on update cascade on delete cascade
);

create table partidax(
	id_partidax int primary key identity not null,
	puntos int not null,
	pge varchar(30) not null,
	id_usuario int not null,
	foreign key (id_usuario) references usuario(id_usuario) on update cascade on delete cascade
);

create table camponato(
	id_campeonato int primary key identity not null,
	nombre int not null,
	ganador varchar(20) not null,
	id_usuario int not null,
	foreign key (id_usuario) references usuario(id_usuario) on update cascade on delete cascade
);

create table ronda(
	id_ronda int primary key identity not null,
	nombre varchar(20) not null,
	ganador varchar(20) not null
);

create table equipo(
	id_equipo int primary key identity not null,
	nombre varchar(20) not null,
	puntos int not null
);

create table detalle_c(
	cant_e int not null,
	cant_r int not null,
	id_campeonato int not null,
	id_ronda int not null,
	id_equipo int not null,
	foreign key (id_campeonato) references campeonato(id_campeonato) on update cascade on delete cascade,
	foreign key (id_ronda) references ronda(id_ronda) on update cascade on delete cascade,
	foreign key (id_equipo) references equipo(id_equipo) on update cascade on delete cascade
);

create table jugador(
	id_jugador int primary key identity not null,
	nombre varchar(20) not null,
	id_equipo int not null,
	foreign key (id_equipo) references equipo(id_equipo) on update cascade on delete cascade
);

create table partida_T(
	id_partida_T int primary key identity not null,
	pge varchar(20) not null,
	id_ronda int not null,
	id_jugador int not null,
	foreign key (id_ronda) references ronda(id_ronda) on update cascade on delete cascade
	foreign key (id_jugador) references jugador(id_jugador) on update cascade on delete cascade
);*/

select * from usuario
select * from partida
select * from partidax

drop table partida

/*insert into partida(partida_g,tipo_partida,color,movimientos,pge,id_usuario) values('<tablero>
	<ficha>
		<color>negro</color>
		<columna>C</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>blanca</color>
		<columna>C</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>I</columna>
		<fila>13</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>D</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>D</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>D</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>E</columna>
		<fila>3</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>E</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>E</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>E</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>F</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>F</columna>
		<fila>6</fila>
	</ficha>
	<siguienteTiro>
		<color>negro</color>
	</siguienteTiro>
</tablero>', 'Versus', 'negro', 3,'.' ,1)

insert into partida(partida_g,tipo_partida,color,movimientos,pge,id_usuario) values('<tablero>
	<ficha>
		<color>negro</color>
		<columna>C</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>D</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>D</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>D</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>E</columna>
		<fila>3</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>E</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>E</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>E</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>F</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>F</columna>
		<fila>6</fila>
	</ficha>
	<siguienteTiro>
		<color>negro</color>
	</siguienteTiro>
</tablero>', 'Versus', 'negro', 2,'.' ,1)

insert into partida(partida_g,tipo_partida,color,movimientos,pge,id_usuario) values('<tablero>
	<ficha>
		<color>blanco</color>
		<columna>A</columna>
		<fila>1</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>A</columna>
		<fila>2</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>A</columna>
		<fila>3</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>A</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>A</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>A</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>A</columna>
		<fila>7</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>A</columna>
		<fila>8</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>B</columna>
		<fila>2</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>B</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>B</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>B</columna>
		<fila>7</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>B</columna>
		<fila>8</fila>
	</ficha>
    <ficha>
		<color>blanco</color>
		<columna>C</columna>
		<fila>1</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>C</columna>
		<fila>2</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>C</columna>
		<fila>3</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>C</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>C</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>C</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>C</columna>
		<fila>7</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>C</columna>
		<fila>8</fila>
	</ficha>
    <ficha>
		<color>blanco</color>
		<columna>D</columna>
		<fila>1</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>D</columna>
		<fila>2</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>D</columna>
		<fila>3</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>D</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>D</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>D</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>D</columna>
		<fila>7</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>D</columna>
		<fila>8</fila>
	</ficha>
    <ficha>
		<color>blanco</color>
		<columna>E</columna>
		<fila>1</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>E</columna>
		<fila>2</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>E</columna>
		<fila>3</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>E</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>E</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>E</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>E</columna>
		<fila>7</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>E</columna>
		<fila>8</fila>
	</ficha>
    <ficha>
		<color>blanco</color>
		<columna>F</columna>
		<fila>1</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>F</columna>
		<fila>2</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>F</columna>
		<fila>3</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>F</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>F</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>F</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>F</columna>
		<fila>7</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>F</columna>
		<fila>8</fila>
	</ficha>
    <ficha>
		<color>blanco</color>
		<columna>G</columna>
		<fila>1</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>G</columna>
		<fila>2</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>G</columna>
		<fila>3</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>G</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>G</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>G</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>G</columna>
		<fila>7</fila>
	</ficha>
	<ficha>
		<color>negro</color>
		<columna>G</columna>
		<fila>8</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>H</columna>
		<fila>2</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>H</columna>
		<fila>3</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>H</columna>
		<fila>4</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>H</columna>
		<fila>5</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>H</columna>
		<fila>6</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>H</columna>
		<fila>7</fila>
	</ficha>
	<ficha>
		<color>blanco</color>
		<columna>H</columna>
		<fila>8</fila>
	</ficha>
	<siguienteTiro>
		<color>blanco</color>
	</siguienteTiro>
</tablero>', 'Versus', 'negro', 18,'.' ,1)*/
