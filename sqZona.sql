USE HydroLAN;
use Proyecto;

CREATE TABLE Zona
( numeroZona INT PRIMARY KEY,
nombre VARCHAR(100) UNIQUE NOT NULL
);


CREATE PROCEDURE sp_ConsultarZonas
AS
BEGIN
SELECT numeroZona, nombre FROM Zona;
END
GO

CREATE PROCEDURE sp_ConsultarZonasPorNombre
AS
BEGIN
SELECT nombre FROM Zona;
END
GO

CREATE PROCEDURE sp_BuscarZona(@numeroZona int)
AS
BEGIN
SELECT numeroZona, nombre FROM Zona WHERE numeroZona = @numeroZona;
END
GO

CREATE PROCEDURE sp_BuscarZonaPorNombre(@nombre varchar(100))
AS
BEGIN
SELECT numeroZona, nombre FROM Zona WHERE nombre = @nombre;
END
GO

CREATE PROCEDURE sp_ModificarZona(@numeroZona int, @nombre varchar(100))
AS
BEGIN
UPDATE Zona SET numeroZona = @numeroZona, nombre = @nombre WHERE numeroZona = @numeroZona;
END
GO

CREATE PROCEDURE sp_AgregarZona(@numeroZona int, @nombre varchar(100))
AS
BEGIN
INSERT INTO Zona(numeroZona, nombre) VALUES(@numeroZona, @nombre);
END
GO

CREATE PROCEDURE sp_EliminarZona(@numeroZona int)
AS
BEGIN
DELETE Zona WHERE numeroZona = @numeroZona;
END
GO

insert into Zona(numeroZona, nombre) VALUES(1, 'Zona Norte');
insert into Zona(numeroZona, nombre) VALUES(2, 'Zona Sur');
insert into Zona(numeroZona, nombre) VALUES(3, 'Zona Este');
insert into Zona(numeroZona, nombre) VALUES(4, 'Zona Oeste');
insert into Zona(numeroZona, nombre) VALUES(5, 'Zona Central');

select * from Zona;