Public Class query
	-- esta es la query, la colocamos aqui para su evaluacion

-- base de datos inicio
Drop database CompuCenter
create database CompuCenter
go

	-- esquema
create schema Center
go

	-- uso de la base
use CompuCenter
go

	-- drops para reinciar tablas
Drop table Center.telefonos
Drop table Center.empleados
drop table Center.stock


	-- tabla de telefonos
create table Center.telefonos(
	id int primary key  Not null,
	puesto varchar(35) null,
	modelo varchar(30) Not null,
	tipoPaquete varchar(30) Not null,
    Descripcion varchar(120) Not null,
    cantidad int null
)

	-- tabla de empleados
create table Center.empleados(
	IdCodigo int primary key,
	identidad varchar(15)  Not null,
	nombre varchar(50) Not null,
	direccion varchar(60) Not null,
	edad int Not null,
	sexo varchar(10),
	puesto varchar(35),
    idPuesto int null
)

	-- tabla de stock
create table Center.stock(
	IdCodigo int primary key Not null,
	identidad varchar(15) Not null,
	nombre varchar(50) Not null,
	puesto varchar(35),
	idPuesto int null FOREIGN KEY REFERENCES Center.telefonos(id)
)

	-- purebas para ingreso de base a visual absic
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1','0318-2002-01454','Andrea Lucia Martinez Fernandez','Comayagua, Siguatepeque, EL centro','20','Femenina','Gerente','0')
Select Case* From Center.empleados

Select Case* From Center.empleados UPDATE Center.empleados set identidad = '0318-2002-01454', nombre = 'Andrea Lucia Martinez Fernandez',direccion =  'Comayagua, Siguatepeque, EL centro', edad = '20', sexo = 'Femenina', puesto = 'Gerente', idPuesto = '0'
Where IdCodigo = '1'


	-- prueba inicial de las bases (no tocar a menos defallo)
insert into Center.telefonos (id, puesto, modelo, tipoPaquete,Descripcion,cantidad) values ('0','Gerente','Samsung S10','Paquete de 38$','Minutos ilimitados todas las redes, USA y Canada + 2,000 mensajes a todas las redes, USA y Canada + Internet +30GB','1')
insert into Center.telefonos (id, puesto, modelo, tipoPaquete,Descripcion,cantidad) values ('1','Jefe De Calidad','Huawei Y7 2019','Plan de $28.00','Minutos ilimitados dentro de la red + 350 minutos todas las redes + 350 mensajes + internet :16GB','1')
insert into Center.telefonos (id, puesto, modelo, tipoPaquete,Descripcion,cantidad) values ('2','Jefe De TI(Infraestrutura)','Huawei Y7 2019','Plan de $28.00','Minutos ilimitados dentro de la red + 350 minutos todas las redes + 350 mensajes + internet :16GB','1')
insert into Center.telefonos (id, puesto, modelo, tipoPaquete,Descripcion,cantidad) values ('3','Jefe De TI(Desarrollo)','Huawei Y7 2019','Plan de $28.00','Minutos ilimitados dentro de la red + 350 minutos todas las redes + 350 mensajes + internet :16GB','1')
insert into Center.telefonos (id, puesto, modelo, tipoPaquete,Descripcion,cantidad) values ('4','Soporte TI','Huawei Y5 2018','Plan de $20','Minutos ilimitados dentro de la red + 350 minutos todas las redes + 350 mensajes + internet 5GB','1')
insert into Center.telefonos (id, puesto, modelo, tipoPaquete,Descripcion,cantidad) values ('5','Medios','Huawei Y5 2018','Plan de $20','Minutos ilimitados dentro de la red + 350 minutos todas las redes + 350 mensajes + internet 5GB','1')
insert into Center.telefonos (id, puesto, modelo, tipoPaquete,Descripcion,cantidad) values ('6','Marketing','Huawei Y5 2018','Plan de $20','Minutos ilimitados dentro de la red + 350 minutos todas las redes + 350 mensajes + internet 5GB','1')
insert into Center.telefonos (id, puesto, modelo, tipoPaquete,Descripcion,cantidad) values ('7','Jefe de RRHH','Huawei Y7 2019','Plan de $28.00','Minutos ilimitados dentro de la red + 350 minutos todas las redes + 350 mensajes + internet :16GB','1')
insert into Center.telefonos (id, puesto, modelo, tipoPaquete,Descripcion,cantidad) values ('8','Ejecutivos','Huawei Y5 2018','Plan de $20','Minutos ilimitados dentro de la red + 350 minutos todas las redes + 350 mensajes + internet 5GB','1')


	-- seleccion par alas tablas 
Select Case* From Center.telefonos
Select Case* From Center.stock
Select Case* From Center.empleados


	-- emtodo de insercion par visual basic
use CompuCenter
go 

alter procedure mostrarStock 
as begin

Select Case st.IdCodigo, st.identidad , st.nombre, st.puesto, te.modelo,te.tipoPaquete,te.Descripcion, te.cantidad
from Center.stock st 
inner join Center.telefonos te
On st.idPuesto = te.id

End
execute mostrarStock

	-- prueba para contar elementos de tablas (no tocar a menos de falla)

Select Case count(*) As cantidad from Center.stock where puesto='Gerente'
Select Case count(*) As paquete1 from Center.stock where puesto='Gerente'


------------  base para la tabla de empleados --------------------
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('001','0101-1981-24572','Jose Manuel Ayala Mencilla','La Ceiba,Atlantida, Col. Pizzaty','39','Masculino','Gerente','0')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('003','1804-1980-04558','Merlin Alexandra Ramos Ponce','Yoro,Yoro, Villa Nuria','40','Femenino','Gerente','0')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('005','0205-1997-15743','Nino Carlos Sanchez Mendoza','Colon,Saba, La Esperanza','23','Masculino','Dependiente','0')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('191','0101-1981-27511','Carlos Daniel Romero Mencilla','La Ceiba,Atlantida, Col. Pizzaty','39','Masculino','Jefe Calidad','1')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('193','0101-1982-22207','Gustavo Josue Colindres Almendares','La Ceiba,Atlantida, Col. Sierra Pina','38','Masculino','Jefe Calidad','1')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('221','0101-1982-22207','Sebastian Miguel Barahona Mencia','La Ceiba,Atlantida, Col. Sierra Pina','38','Masculino','Jefe de TI Infraestructura','2')

insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values  ('1458','0201-2001-00011','Josue Marlon Castro Mencilla','Comayagua, Siguatepeque, San Antonio','19','Masculino','Jefe de TI Desarrollo','3')
insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values   ('2596','0318-1981-34572','Rigorberto Cardona Aguilarr','Comayagua, siguatepeque, San Juan','39','Masculino','Gerente','0')

insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('440','0318-1990-03001','Gustavo Enrique Arellano Arias','Comayagua,Siguatepeque, Las Colinas','30','Masculino','Soporte de TI','4')
insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('442','0318-1986-00012','Roberto Jose Gomez Moncada','Comayagua,Siguatepeque, Barrio Fatima','34','Masculino','Soporte de TI','4')
insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('444','0318-1986-00873','Carlos Alonso Estrada Castillo','Comayagua,Siguatepeque, Barrio Abajo','34','Masculino','Soporte de TI','4')
insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('446','0318-1989-00345','Daniela Alejandra Castro Castro','Comayagua,Siguatepeque, Barrio San Antonio','31','Femenino','Soporte de TI','4')
insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('448','0318-1992-00741','Lidia Jimena Aguilar Espinoza','Comayagua,Siguatepeque, El Centro','29','Femenino','Soporte de TI','4')
insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1253','0318-2001-00445','Daniela Isabel Vasquez','Comayagua,Siguatepeque, Barrio San Antonio','19','Femenino','Soporte de TI','4')
insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('4589','0318-2004-00731','Elmer Chandia Sabillon','Comayagua,Siguatepeque, El Centro','19','Maculino','Soporte de TI','4')

insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('551','0318-1993-00400','Nicol Pamela Jimenez Mejia','Comayagua,Siguatepeque, El Centro','27','Femenino','Medios','5')
insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('553','0318-1990-08821','Rocio Beatriz Meza Palacios','Comayagua,Siguatepeque, El Carmen','30','Femenino','Medios','5')


insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('991','0101-1994-24872','Ricardo Alberto Lopez Ramirez','La Ceiba,Atlantida, Barrio Mejia','19','Masculino','Dependiente','9')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('993','1804-2001-05389','Merlin Denisse Guerra Ponce','Yoro,Yoro, Villa Nuria','18','Femenino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('995','0205-1997-15743','Christian Omar Sanchez Munguia','Colon,Saba, La Esperanza','23','Masculino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('997','0401-1992-58437','Andrea Maria Garcia Muñoz','Copán, Santa Rosa de Copan, Col Osorios','28','Femenino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('999','1501-1998-00103','Amelia Ruth Lopez Muñoz','Olancho, Juticalpa, Col Saturno','21','Femenino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('9911','1402-1996-01062','Gabriela Paola Escobar Contreras','Ocotepeque, Belen Gualcho, Col Neptuno','23','Femenino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('9913','1101-1996-01163','Kurt David Hernandez Jones','Islas de la Bahia, Roatan, Col Small Key','23','Masculino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('9915','1102-2001-03697','Jose Dario Peralta Paz','Islas de la Bahia, Guanaja, Barrio Abajo','18','Masculino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('9917','0318-2002-05628','Antonio Raul Valladares Castillo','Comayagua,Siguatepeque, Barrio Abajo','18','Masculino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('9919','0301-2002-05629','Francisco Jose Valladares Castillo','Comayagua,Siguatepeque, Barrio Abajo','18','Masculino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('9921','0801-2001-00034','German Jose Molinero Mejia','Francisco Morazan,Tegucigalpa, Valle de Angeles','19','Masculino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('9923','0801-2000-000134','Daniel Fernando Molinero Mejia','Francisco Morazan,Tegucigalpa, Valle de Angeles','20','Masculino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('9925','0501-1999-01134','Fabian Alejandro Castro Facusse','Cortes,San Pedro Sula, Colonia Satelite','21','Masculino','Dependiente','9')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('9927','0501-1998-01434','Santiago Andres Castro Facusse','Cortes,San Pedro Sula, Colonia Satelite','22','Masculino','Dependiente','9')


insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('101','0101-2000-04263','Oscar Manuel Rivera Amador','Atlantida,La Ceiba, Vista de Palmira','19','Masculino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('103','0101-2000-00018','Abril de las Santisimas Barahona Calix','Atlantida,La Ceiba, El Sauce','19','Femenino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('105','0101-2003-00245','Genesis Paola Cerrato Atala','Atlantida,La Ceiba, Toronjal II','19','Femenino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('107','0101-1966-01081','Gloria Ondina Valladares Romero','Atlantida,La Ceiba, Toronjal II','19','Femenino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('109','0101-1966-01284','Jose Gustavo Murillo Valladares','Atlantida,La Ceiba, Toronjal II','19','Masculino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1011','0801-1993-22101','Gustavo Antonio Murillo Valladares','Francisco Morazan,Tegucigalpa, Col. 21 de Octubre','26','Masculino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1013','0801-1995-01234','Maria Fernanda Cuestas Fernandez ','Francisco Morazon,Tegucigalpa, Col. 21 de Octubre','19','Femenino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1015','0318-1999-06851','Esdras Joel Tinoco Mejia','Comayagua,Siguatepeque, El Centro','20','Masculino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1017','0101-2000-07580','Eduardo Manuel Mencia Lopez','Atlantida,La Ceiba, Villa Mary','20','Masculino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1019','0101-2000-01185','Carlos Mario Paz Santos','Atlantida,La Ceiba, Villa Mary','20','Masculino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1021','0101-1991-03336','Christopher Josue Ramos Diaz','Atlantida,La Ceiba, Santa Lucia','29','Masculino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1023','0101-1990-08974','Christopher Alejandro Cabrera Romero','Atlantida,La Ceiba, El Naranjal','30','Masculino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1025','0501-1991-00032','Enrique Federico Cruz Cruz ','Cortes,San Pedro Sula, El Centro','29','Masculino','Cocinero','10')
insert into Center.empleados (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values ('1027','1101-1989-02222','Carlos Joe Jones Diaz ','Islas de la Bahia,Roatan, El Centro','31','Masculino','Cocinero','10')

insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values
('550','1016-1997-00006','Luis Benjamin Hernandez Betrand','Comayagua, Siguatepeque, Las Colinas','23','Masculino','Marketing','6')

insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values
('321','0101-1997-00006','Henrry Osmani Costa Benitez','Comayagua, Siguatepeque, El Parnaso','23','Masculino','Ejecutivos de RRHH','8'),
('412','0403-2000-00006','Daniela Alejandra Garcia Medina','Comayagua, Siguatepeque, San Antonio','20','Femenino','Ejecutivos de RRHH','8'),
('350','0107-1998-00006','Francisco Jose Hernandez Gonzales','Comayagua, Siguatepeque, Colonia Mata','22','Masculino','Ejecutivos de RRHH','8')

insert into Center.empleados (idCodigo, identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values
('320','0313-1999-00006','Jose Isidro Ventura Reyes','Comayagua, Siguatepeque, El Carmen','21','Masculino','Jefe de RRHH','7')

insert into Center.empleados (identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values
insert into Center.empleados ('0313-1997-00006','Edwin Fernando Alvarado Lainez','Comayagua, Siguatepeque, El Parnaso','23','Masculino','Operador','13'),
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('21','0310-1999-01211','Sonia Erlinda Jimenez Gonzales','Intibuca, La Esperanza, El Way','21','Femenino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('12','0312-2000-01564','Katerin Ivani Ulloa Martinez','La Paz, Cane, Barrio Arriba','20','Femenino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('23','0311-2001-00002','Valeria Zohat Diaz Hernandez','Comayagua, Taulabe, El centro','19','Femenino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('14','0314-2002-02012','Brayan Edgardo Medina Turcios','Lempira, Gracias, Barrio Abajo','18','Masculino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('25','0302-1974-00041','Jose Benjamin Reyes Gonzales','Choluteca, Pespire, Barrio Abajo','46','Masculino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('61','0301-1976-02015','Olvin Noel Gomez Ventura','Comayagua, Siguatepeque, El Carmen','44','Masculino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('27','1016-1995-00320','Frank Edgardo Medina Portillo','Comayagua, Taulabe, El Centro','25','Masculino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('18','0405-1980-00247','Oscar Naun Gonzales Martinez','Atlantida, Tela, El Centro','40','Masculino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('29','1016-1985-01478','Claudia Patricia Medina Gonzales','Comayagua, Siguatepeque, San Antonio','35','Femenino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('10','1012-1995-00004','Ruth Areli Amaya Lopez','Comayagua, Siguatepeque, Las Colinas','25','Femenino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('11','1001-1997-00189','Ricardo Javier Aguilar Lopez','Intibuca, La Esperanza, Buenos Aires','23','Masculino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('12','0405-1980-00247','Omar Alberto Medina Portillo','Atlantida, La Ceiba, El Centro','40','Masculino','Operador','13')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('13','0303-2000-03154','Juan Sebastian Gomez Hernandez','Atlantida, Jutiapa, San Juan','20','Masculino','Operador','13') 

insert into Center.empleados (identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('124','0202-1997-00006','Edwin Fernando Alvarado Lainez','Comayagua, Siguatepeque, Colonia Mata','23','Masculino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('114','1016-1995-00320','Frank Brayan Mejia Amaya','Comayagua, Taulabe, El Centro','25','Masculino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('112','0201-2000-00124','Andrea Nohemy Toledo Medina','Atlantida, Jutiapa, Barrio Arriba','20','Femenino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('136','0503-1999-01212','Alex Jose Gomez Garcia','Copan, Veracruz, Barrio Abajo','21','Masculino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('157','1014-2001-00142','Rosa Delia Medina Medina','Copan, Cabañas, El Centro','19','Femenino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('197','0401-1980-00172','Maria Jose Hernandez Dominguez','Atlantida, Tela, El Centro','25','Femenino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('185','1012-1995-04789','Ruth Areli Amaya Lopez','Comayagua, Siguatepeque, Las Colinas','25','Femenino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('120','1114-1985-01478','Claudia Xiomara Calix Reyes','Comayagua, Siguatepeque, El Porvenir','35','Femenino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('132','0311-2001-00002','Valeria Zohat Diaz Hernandez','Comayagua, Taulabe, El centro','19','Femenino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('137','0301-1976-02015','Olvin Noel Gomez Ventura','Comayagua, Siguatepeque, El Carmen','44','Masculino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('198','0405-1980-00247','Oscar Naun Gonzales Martinez','Atlantida, Tela, El Centro','40','Masculino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('112','1014-1995-00147','Edwin Jose Garcia Medina','Comayagua, Siguatepeque, Las Colinas','25','Masculino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('120','1001-1997-00007','Ricardo Javier Calix Sandoval','Intibuca, La Esperanza, La Gruta','23','Masculino','Chofer','14')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('101','0201-1987-00284','Cristina Isabel Lopez Ventura','Cortes, Omoa, El Centro','33','Femenino','Chofer','14')

insert into Center.empleados (identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('443','1010-1997-00352','Juan Jose Hernandez Garcia','Comayagua, Siguatepeque, Colonia Mata','23','Masculino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('487','1012-1995-04789','Ruth Areli Amaya Lopez','Comayagua, Siguatepeque, Las Colinas','25','Femenino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('12341','1016-1995-00320','Frank Brayan Mejia Amaya','Comayagua, Taulabe, El Centro','25','Masculino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('5487','0318-2002-00555','Ernesto Jose Flores Hernandez','Comayagua, Siguatepeque, El Parnaso','18','Masculino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('1235','0311-2001-00002','Valeria Zohat Diaz Hernandez','Comayagua, Taulabe, El centro','19','Femenino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('1124','0405-1980-00247','Oscar Naun Gonzales Martinez','Atlantida, Tela, El Centro','40','Masculino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('9874','0201-2000-00124','Andrea Nohemy Toledo Medina','Atlantida, Jutiapa, Barrio Arriba','20','Femenino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('9313','0305-1976-01487','Jose Jose Hernandez Bertrand','Comayagua, Siguatepeque, El Carmen','44','Masculino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('341','0318-2001-00007','Sven Alessandro Rodriguez Mesa','Comayagua, Siguatepeque, San Antonio','19','Masculino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('9987','0101-2000-02963','Gloria Andrea Murillo Valladares', 'Atlantida, La Ceiba, El Naranjal','20','Femenino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('214','1001-1997-00189','Ricardo Javier Bertrand Castañeda','Intibuca, La Esperanza, Buenos Aires','23','Masculino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('164','0318-2004-02610','Sandra Jackelin Calderon Ramirez','Comayagua, Siguatepeque, San Juan','19','Femenino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('138','0302-1974-00041','Jose Benjamin Reyes Gonzales','Choluteca, Pespire, Barrio Abajo','46','Masculino','Programador','15')
insert into Center.empleados  (IdCodigo,identidad,nombre,direccion,edad,sexo,puesto,idPuesto) values('512','1010-1999-00004','Juan Eduardo Villanueva Garcia','Comayagua, Siguatepeque, Colonia Mata','21','Masculino','Programador','15')
--------------------------------------------------------------------


	--------- base para stock ------------------------------
	insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('001','0101-1981-24572','Jose Manuel Ayala Mencilla','Gerente','0')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('003','1804-1980-04558','Merlin Alexandra Ramos Ponce','Gerente','0')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('005','0205-1997-15743','Nino Carlos Sanchez Mendoza','Dependiente','0')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('2596','0318-1981-34572','Rigorberto Cardona Aguilarr','Gerente','0')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('191','0101-1981-27511','Carlos Daniel Romero Mencilla','Jefe Calidad','1')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values ('193','0101-1982-22207','Gustavo Josue Colindres Almendares','Jefe Calidad','1')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('221','0101-1982-22207','Sebastian Miguel Barahona Mencia','Jefe de TI Infraestructura','2')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('1458','0201-2001-00011','Josue Marlon Castro Mencilla','Jefe de TI Desarrollo','3')

	insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values ('440','0318-1990-03001','Gustavo Enrique Arellano Arias','Soporte de TI','4')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values ('442','0318-1986-00012','Roberto Jose Gomez Moncada','Soporte de TI','4')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('444','0318-1986-00873','Carlos Alonso Estrada Castillo','Soporte de TI','4')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('446','0318-1989-00345','Daniela Alejandra Castro Castro',,'Soporte de TI','4')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values ('448','0318-1992-00741','Lidia Jimena Aguilar Espinoza','Soporte de TI','4')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('1253','0318-2001-00445','Daniela Isabel Vasquez','Soporte de TI','4')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('4589','0318-2004-00731','Elmer Chandia Sabillon','Soporte de TI','4')

insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('551','0318-1993-00400','Nicol Pamela Jimenez Mejia','Medios','5')
insert into Center.stock (idCodigo, identidad,nombre,puesto,idPuesto) values  ('553','0318-1990-08821','Rocio Beatriz Meza Palacios','Medios','5')

End Class
