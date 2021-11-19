USE HydroLAN;
use Proyecto;



insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('mohidan', 123, 1, 0, 0);
insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('aldana', 123, 2, 0, 0);
select * from Usuario;

insert into Categoria(categoria, porcentaje) values('A', 0.10);
insert into Categoria(categoria, porcentaje) values('B', 0.15);
insert into Categoria(categoria, porcentaje) values('C', 0.18);
select * from Categoria;