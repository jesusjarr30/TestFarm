CREATE DATABASE cervezeria;

use cervezeria; 

create table direccion(
id Integer primary key,
nombre VARCHAR(40), 
);

INSERT INTO direccion (id, nombre) VALUES (1, 'Gerencia');
INSERT INTO direccion (id, nombre) VALUES (2, 'Aseo');
INSERT INTO direccion (id, nombre) VALUES (3, 'Desarrollo');
INSERT INTO direccion (id, nombre) VALUES (4, 'Recursos Humanos');
INSERT INTO direccion (id, nombre) VALUES (5, 'Cajas');
INSERT INTO direccion (id, nombre) VALUES (6, 'CEDIS');
INSERT INTO direccion (id, nombre) VALUES (7, 'Trasportes');
INSERT INTO direccion (id, nombre) VALUES (8, 'Cocina');
INSERT INTO direccion (id, nombre) VALUES (9, 'Finanzas');

select * from direccion;


create table empleado(
id Integer primary key,
nombre varchar(40),
suledo integer,
idDireccion integer, 
FOREIGN KEY (idDireccion) REFERENCES direccion(id)
);

INSERT INTO empleado (id, nombre, suledo,idDireccion) VALUES (1,'Jesus',5,1);
INSERT INTO empleado (id, nombre, suledo,idDireccion) VALUES (2,'Maunel',60,2);
INSERT INTO empleado (id, nombre, suledo,idDireccion) VALUES (3,'Morelos',78,3);
INSERT INTO empleado (id, nombre, suledo,idDireccion) VALUES (4,'Hidalgo',96,2);
INSERT INTO empleado (id, nombre, suledo,idDireccion) VALUES (5,'Jose',25,3)
INSERT INTO empleado (id, nombre, suledo,idDireccion) VALUES (6,'Itzel',25,1);
INSERT INTO empleado (id, nombre, suledo,idDireccion) VALUES (7,'Alejandro',25,1);
INSERT INTO empleado (id, nombre, suledo,idDireccion) VALUES (8,'El pepe',25,2);
INSERT INTO empleado (id, nombre, suledo,idDireccion) VALUES (9,'Maria',25,2);
INSERT INTO empleado (id, nombre, suledo,idDireccion) VALUES (10,'Diana',25,3)

select * from empleado;


--La marca es la empresa y el modelos son todos 
--los tipos de cerveza que esta maneja
create table marca(
id Integer primary key,
nombre varchar(40),
);

create table modelo(
id Integer primary key,
nombre varchar,
idMarca Integer,
FOREIGN key  (idMarca) REFERENCES marca(id)
);