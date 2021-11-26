USE HydroLAN;
use Proyecto;

CREATE TABLE Empleado
( 
idEmpleado INT IDENTITY(1,1) PRIMARY KEY,
nombreUsuario VARCHAR(100) UNIQUE NOT NULL,
nombre VARCHAR(100) NOT NULL,
apellidoPaterno VARCHAR(100) NOT NULL,
apellidoMaterno VARCHAR(100) NOT NULL,
nacimiento DATE NOT NULL,
genero CHAR(1) NOT NULL,
numeroExterior INT NOT NULL,
calle VARCHAR(100) NOT NULL,
colonia VARCHAR(100) NOT NULL,
municipio VARCHAR(100) NOT NULL,
fechaAltaMod DATETIME,
FOREIGN KEY (nombreUsuario) REFERENCES Usuario(nombreUsuario),
FOREIGN KEY (municipio) REFERENCES Municipio(municipio)
);

CREATE PROCEDURE sp_ConsultarEmpleados
AS
BEGIN
SELECT idEmpleado, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, numeroExterior, calle, colonia, municipio, fechaAltaMod FROM Empleado;
END
GO

CREATE PROCEDURE sp_ConsultarEmpleadosBaneados
AS
BEGIN
SELECT Usuario.nombreUsuario, Empleado.nombre, Empleado.apellidoPaterno, Empleado.apellidoMaterno, Empleado.nacimiento, Empleado.genero, Empleado.municipio, Empleado.fechaAltaMod
FROM Usuario
INNER JOIN Empleado ON Usuario.nombreUsuario = Empleado.nombreUsuario AND Usuario.estado = 2;
END
GO

CREATE PROCEDURE sp_BuscarEmpleado(@idEmpleado int)
AS
BEGIN
SELECT idEmpleado, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, numeroExterior, calle, colonia, municipio, fechaAltaMod FROM Empleado WHERE idEmpleado = @idEmpleado;
END
GO

CREATE PROCEDURE sp_AgregarEmpleado(@nombreUsuario varchar(100), @nombre varchar(100), @apellidoPaterno varchar(100), @apellidoMaterno varchar(100), @nacimiento date, @genero char(1), @numeroExterior int, @calle varchar(100), @colonia varchar(100), @municipio varchar(100))
AS
BEGIN
INSERT INTO Empleado(nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, numeroExterior, calle, colonia, municipio, fechaAltaMod) VALUES(@nombreUsuario, @nombre, @apellidoPaterno, @apellidoMaterno, @nacimiento, @genero, @numeroExterior, @calle, @colonia, @municipio, CURRENT_TIMESTAMP);
END
GO

CREATE PROCEDURE sp_ModificarEmpleado(@idEmpleado int, @nombreUsuario varchar(100), @nombre varchar(100), @apellidoPaterno varchar(100), @apellidoMaterno varchar(100), @nacimiento date, @genero char(1), @numeroExterior int, @calle varchar(100), @colonia varchar(100), @municipio varchar(100))
AS
BEGIN
UPDATE Empleado SET nombreUsuario = @nombreUsuario, nombre = @nombre, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno, nacimiento = @nacimiento, genero = @genero, numeroExterior = @numeroExterior, calle = @calle, colonia = @colonia, municipio = @municipio, fechaAltaMod = CURRENT_TIMESTAMP WHERE idEmpleado = @idEmpleado;
END
GO

CREATE PROCEDURE sp_EliminarEmpleado(@idEmpleado int)
AS
BEGIN
DELETE Empleado WHERE idEmpleado = @idEmpleado;
END
GO

insert into Empleado(nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, numeroExterior, calle, colonia, municipio, fechaAltaMod) values('aldana', 'isaac', 'aldana', 'nuñez', '1995-06-10', 'H', 773, 'groove street','alamedas', 'guadalupe', CURRENT_TIMESTAMP);
insert into Empleado(nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, numeroExterior, calle, colonia, municipio, fechaAltaMod) values('mohidan', 'isaac2', 'aldana2', 'nuñez2', '1992-07-15', 'H', 759, 'groove street','alamedas', 'guadalupe', CURRENT_TIMESTAMP);
select * from Empleado;