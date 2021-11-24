USE HydroLAN;
use Proyecto;


insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('alan', 123, 0, 0, 0);
insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('mohidan', 123, 1, 0, 0);
insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('aldana', 123, 2, 0, 0);
select * from Usuario;
delete from Usuario WHERE nombreUsuario = 'JJ';

insert into Empleado(nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, numeroExterior, calle, colonia, municipio, fechaAltaMod) values('aldana', 'isaac', 'aldana', 'nuñez', '1995-06-10', 'H', 773, 'groove street','alamedas', 'guadalupe', CURRENT_TIMESTAMP);
insert into Empleado(nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, numeroExterior, calle, colonia, municipio, fechaAltaMod) values('mohidan', 'isaac2', 'aldana2', 'nuñez2', '1995-06-10', 'H', 773, 'groove street','alamedas', 'guadalupe', CURRENT_TIMESTAMP);
select * from Empleado;

INSERT INTO Cliente_Moral(rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod) VALUES('1234jdse8854', 'alan', 'pemex', '1850-06-22', 'pemex_alan@sasa.com', CURRENT_TIMESTAMP);
select * from Cliente_Moral;
select * from Cliente_Fisico;

UPDATE Usuario SET empleadoCliente = 0 WHERE nombreUsuario = 'alan';

insert into Categoria(categoria, porcentaje) values('A', 0.10);
insert into Categoria(categoria, porcentaje) values('B', 0.15);
insert into Categoria(categoria, porcentaje) values('C', 0.18);
select * from Categoria;

insert into Zona(municipio, numeroZona) values('guadalupe', 1);
insert into Zona(municipio, numeroZona) values('juarez', 1);
insert into Zona(municipio, numeroZona) values('garcia', 2);
insert into Zona(municipio, numeroZona) values('san pedro', 3);
insert into Zona(municipio, numeroZona) values('san nicolas', 3);
insert into Zona(municipio, numeroZona) values('apodaca', 4);
select * from Zona;

insert into Tipo_Servicio(tipoServicio, cuotaDrenaje) values('Domicilio', 55);


INSERT INTO Contrato(nombreUsuario, numeroMedidor, tipoServicio, categoria, estado, numeroExterior, calle, colonia, municipio, creacion, fechaAltaMod) VALUES('dasda', 5005, 'Domicilio', 'A', 0, 778, 'calle7', 'alamedas', 'guadalupe', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
select * from Contrato;
