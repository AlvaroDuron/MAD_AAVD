USE HydroLAN;
use Proyecto;

CREATE TABLE Usuario
( 
nombreUsuario VARCHAR(100) PRIMARY KEY, 
contraseña VARCHAR(100) NOT NULL,
empleadoCliente TINYINT NOT NULL,
intentos TINYINT,
estado TINYINT NOT NULL
);

CREATE PROCEDURE sp_ConsultarUsuariosPorNombre
AS
BEGIN
SELECT nombreUsuario FROM Usuario;
END
GO

CREATE PROCEDURE sp_BuscarUsuario(@nombreUsuario varchar(100))
AS
BEGIN
SELECT nombreUsuario, contraseña, empleadoCliente, intentos, estado FROM Usuario WHERE nombreUsuario = @nombreUsuario;
END
GO

CREATE PROCEDURE sp_AgregarUsuario(@nombreUsuario varchar(100), @contraseña varchar(100), @empleadoCliente tinyint, @intentos tinyint, @estado tinyint)
AS
BEGIN
INSERT INTO Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values(@nombreUsuario, @contraseña, @empleadoCliente, @intentos, @estado);
END
GO

CREATE PROCEDURE sp_ModificarUsuario(@nombreUsuario varchar(100), @contraseña varchar(100), @empleadoCliente tinyint, @intentos tinyint, @estado tinyint)
AS
BEGIN
UPDATE Usuario SET contraseña = @contraseña, empleadoCliente = @empleadoCliente, intentos = @intentos, estado = @estado WHERE nombreUsuario = @nombreUsuario;
END
GO

CREATE PROCEDURE sp_EliminarUsuario(@nombreUsuario varchar(100))
AS
BEGIN
DELETE Usuario WHERE nombreUsuario = @nombreUsuario;
END
GO

insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('alan', 123, 0, 0, 0);
insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('isaac', 123, 0, 0, 0);
insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('mohidan', 123, 1, 0, 0);
insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('aldana', 123, 2, 0, 0);
select * from Usuario;

update Usuario set intentos = 0 where nombreUsuario = 'mohidan';