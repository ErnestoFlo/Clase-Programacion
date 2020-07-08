create database Tienda
go

create schema factura
go

use Tienda
go

----------------------drops-----------------------------------------------------
drop database Tienda
drop schema factura
drop table factura.cliente
drop table factura.producto
drop table factura.venta

------------------------uso de tablas-------------------------------------------
Select Case* From factura.cliente
Select * From factura.producto
Select * From factura.Venta


---------------------tablas------------------------------------------------------

create table factura.cliente (
	idCliente int primary key Not null,
	nombre varchar(25),
	apellido varchar(25),
	direccion varchar(50),
)


create table factura.producto(
	idProducto int primary key Not null,
	nombreProducto varchar(40),
	descripcion varchar(50)
)

create table factura.Venta(
	idVenta int primary key Not null,
	fechaVenta Date,
	precio int,
	cantidad int,
	idCliente int foreign key references factura.cliente(idCliente),
	idProducto int foreign key references factura.producto(idProducto)
)
---------------registro--------------------------------
insert into factura.cliente (idCliente, nombre, apellido, direccion) values ('1','Ernesto','Flores','Barrio el parnaso')
insert into factura.cliente (idCliente, nombre, apellido, direccion) values ('2','Carmen','Garcia','Barrio el higo')
insert into factura.cliente (idCliente, nombre, apellido, direccion) values ('3','Danilo','Argueta','Barrio el carmen')
insert into factura.cliente (idCliente, nombre, apellido, direccion) values ('4','Marien','Ramos','Barrio san miguel')
insert into factura.cliente (idCliente, nombre, apellido, direccion) values ('5','Esdras','Trochez','Barrio fatima')
insert into factura.cliente (idCliente, nombre, apellido, direccion) values ('6','Elizabeth','Marqez','Barrio san antonio')


insert into factura.producto (idProducto, nombreProducto, descripcion) values ('1','Balon de futbol','Especial para hacer un buen hatrick')
insert into factura.producto (idProducto, nombreProducto, descripcion) values ('2','Camisa FC Barcelona','De calidad y comodidad')
insert into factura.producto (idProducto, nombreProducto, descripcion) values ('3','Tacos Adidas','Otorgan velocidad y regates magistrales')
insert into factura.producto (idProducto, nombreProducto, descripcion) values ('4','Balon De Oro','Los mejores del mundo tienen una')
insert into factura.producto (idProducto, nombreProducto, descripcion) values ('5','Bota De oro ','Todo gran goleador tiene una')
insert into factura.producto (idProducto, nombreProducto, descripcion) values ('6','Mascarilla FCB','Perfectas para ver a tus fans ')

insert into factura.Venta (idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) values ('25','07/07/2020','20','1','1','1')
insert into factura.Venta (idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) values ('26','07/07/2020','15','1','2','2')
insert into factura.Venta (idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) values ('27','07/07/2020','15','1','3','3')
insert into factura.Venta (idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) values ('28','07/07/2020','1000','1','4','4')
insert into factura.Venta (idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) values ('29','07/07/2020','100','1','5','5')
insert into factura.Venta (idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) values ('30','07/07/2020','50','1','6','6')

----------------------union de las tablas--------------------------------------

Select Case fc.nombre, fc.apellido, fp.nombreProducto, fv.precio, fv.cantidad, fv.fechaVenta  
from factura.Venta fv
inner join factura.cliente fc 
On fv.idCliente = fc.idCliente inner join factura.producto fp
On fv.idProducto = fp.idProducto  
