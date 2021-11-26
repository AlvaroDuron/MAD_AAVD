USE HydroLAN;
USE Proyecto;

CREATE TABLE Cliente_Fisico
( curp CHAR(18) PRIMARY KEY NOT NULL,
nombreUsuario VARCHAR(100) UNIQUE NOT NULL,
nombre VARCHAR(100) NOT NULL,
apellidoPaterno VARCHAR(100) NOT NULL,
apellidoMaterno VARCHAR(100) NOT NULL,
nacimiento DATE NOT NULL,
genero CHAR(1) NOT NULL,
email VARCHAR(100) NOT NULL,
fechaAltaMod DATETIME NOT NULL,
FOREIGN KEY (nombreUsuario) REFERENCES Usuario(nombreUsuario)
);

CREATE TABLE Cliente_Moral
( rfc CHAR(12) PRIMARY KEY NOT NULL,
nombreUsuario VARCHAR(100) UNIQUE NOT NULL,
nombre VARCHAR(100) NOT NULL,
constitucion DATE NOT NULL,
email VARCHAR(100) NOT NULL,
fechaAltaMod DATETIME NOT NULL,
FOREIGN KEY (nombreUsuario) REFERENCES Usuario(nombreUsuario)
);


CREATE PROCEDURE sp_ConsultarClientesFisicos
AS
BEGIN
SELECT curp, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, email, genero, fechaAltaMod FROM Cliente_Fisico;
END
GO

CREATE PROCEDURE sp_ConsultarClientesFisicosBaneados
AS
BEGIN
SELECT Usuario.nombreUsuario, Cliente_Fisico.nombre, Cliente_Fisico.apellidoPaterno, Cliente_Fisico.apellidoMaterno, Cliente_Fisico.nacimiento, Cliente_Fisico.genero, Cliente_Fisico.fechaAltaMod
FROM Usuario
INNER JOIN Cliente_Fisico ON Usuario.nombreUsuario = Cliente_Fisico.nombreUsuario AND Usuario.estado = 2;
END
GO

CREATE PROCEDURE sp_ConsultarClientesFisicosPorUsuario
AS
BEGIN
SELECT nombreUsuario FROM Cliente_Fisico;
END
GO

CREATE PROCEDURE sp_BuscarClienteFisico(@curp char(18))
AS
BEGIN
SELECT curp, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, email, genero, fechaAltaMod FROM Cliente_Fisico WHERE curp = @curp;
END
GO

CREATE PROCEDURE sp_AgregarClienteFisico(@curp char(18), @nombreUsuario varchar(100), @nombre varchar(100), @apellidoPaterno varchar(100), @apellidoMaterno varchar(100), @nacimiento date, @genero char(1), @email varchar(100))
AS
BEGIN
INSERT INTO Cliente_Fisico(curp, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, email, fechaAltaMod) VALUES(@curp, @nombreUsuario, @nombre, @apellidoPaterno, @apellidoMaterno, @nacimiento, @genero, @email, CURRENT_TIMESTAMP);
END
GO

CREATE PROCEDURE sp_ModificarClienteFisico(@curp char(18), @nombreUsuario varchar(100), @nombre varchar(100), @apellidoPaterno varchar(100), @apellidoMaterno varchar(100), @nacimiento date, @genero char(1), @email varchar(100))
AS
BEGIN
UPDATE Cliente_Fisico SET curp = @curp, nombreUsuario = @nombreUsuario, nombre = @nombre, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno, nacimiento = @nacimiento, genero = @genero, email = @email, fechaAltaMod = CURRENT_TIMESTAMP WHERE curp = @curp;
END
GO

CREATE PROCEDURE sp_EliminarClienteFisico(@curp char(18))
AS
BEGIN
DELETE Cliente_Fisico WHERE curp = @curp;
END
GO


CREATE PROCEDURE sp_ConsultarClientesMorales
AS
BEGIN
SELECT rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod FROM Cliente_Moral;
END
GO

CREATE PROCEDURE sp_ConsultarClientesMoralesBaneados
AS
BEGIN
SELECT Usuario.nombreUsuario, Cliente_Moral.nombre, Cliente_Moral.constitucion, Cliente_Moral.fechaAltaMod
FROM Usuario
INNER JOIN Cliente_Moral ON Usuario.nombreUsuario = Cliente_Moral.nombreUsuario AND Usuario.estado = 2;
END
GO

CREATE PROCEDURE sp_ConsultarClientesMoralesPorUsuario
AS
BEGIN
SELECT nombreUsuario FROM Cliente_Moral;
END
GO

CREATE PROCEDURE sp_BuscarClienteMoral(@rfc char(12))
AS
BEGIN
SELECT rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod FROM Cliente_Moral WHERE rfc = @rfc;
END
GO

CREATE PROCEDURE sp_AgregarClienteMoral(@rfc char(12), @nombreUsuario varchar(100), @nombre varchar(100), @constitucion date, @email varchar(100))
AS
BEGIN
INSERT INTO Cliente_Moral(rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod) VALUES(@rfc, @nombreUsuario, @nombre, @constitucion, @email, CURRENT_TIMESTAMP);
END
GO

CREATE PROCEDURE sp_ModificarClienteMoral(@rfc char(12), @nombreUsuario varchar(100), @nombre varchar(100), @constitucion date, @email varchar(100))
AS
BEGIN
UPDATE Cliente_Moral SET rfc = @rfc, nombreUsuario = @nombreUsuario, nombre = @nombre, constitucion = @constitucion, email = @email, fechaAltaMod = CURRENT_TIMESTAMP WHERE rfc = @rfc;
END
GO

CREATE PROCEDURE sp_EliminarClienteMoral(@rfc char(12))
AS
BEGIN
DELETE Cliente_Moral WHERE rfc = @rfc;
END
GO

insert into Cliente_Fisico(curp, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, email, fechaAltaMod) values('559941315', 'isaac', 'Alan Isaac', 'Aldana', 'Nuñez', '1997-11-03', 'H', 'alan.isaac@sasa.com', CURRENT_TIMESTAMP);
select * from Cliente_Fisico;
insert into Cliente_Moral(rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod) values('1234jdse8854', 'alan', 'pemex', '1850-06-22', 'pemex_alan@sasa.com', CURRENT_TIMESTAMP);
select * from Cliente_Moral;
