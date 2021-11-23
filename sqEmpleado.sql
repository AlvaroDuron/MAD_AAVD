USE HydroLAN;
use Proyecto;

CREATE TABLE Empleado
( 
idEmpleado INT IDENTITY(1,1) PRIMARY KEY,
nombre VARCHAR(100) NOT NULL,
apellidoPaterno VARCHAR(100) NOT NULL,
apellidoMaterno VARCHAR(100) NOT NULL,
nacimiento DATE NOT NULL,
genero CHAR(1) NOT NULL,
numeroExterior INT NOT NULL,
calle VARCHAR(100) NOT NULL,
colonia VARCHAR(100) NOT NULL,
fechaAltaMod DATETIME,
nombreUsuario VARCHAR(100) UNIQUE NOT NULL,
FOREIGN KEY (nombreUsuario) REFERENCES Usuario(nombreUsuario),
municipio VARCHAR(100) NOT NULL,
FOREIGN KEY (municipio) REFERENCES Zona(municipio)
);

CREATE PROCEDURE sp_ConsultarEmpleados
AS
BEGIN
SELECT idEmpleado, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, numeroExterior, calle, colonia, municipio, fechaAltaMod FROM Empleado;
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