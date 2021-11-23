USE HydroLAN;
use Proyecto;

CREATE TABLE Zona
( municipio VARCHAR(100) PRIMARY KEY,
numeroZona INT
);


CREATE PROCEDURE sp_ConsultarZonas
AS
BEGIN
SELECT municipio, numeroZona FROM Zona;
END
GO

CREATE PROCEDURE sp_ConsultarZonasPorMunicipio
AS
BEGIN
SELECT municipio FROM Zona;
END
GO

CREATE PROCEDURE sp_ModificarZona(@municipio varchar(100), @numeroZona int)
AS
BEGIN
UPDATE Zona SET municipio = @municipio, numeroZona = @numeroZona WHERE municipio = @municipio;
END
GO

CREATE PROCEDURE sp_AgregarZona(@municipio varchar(100), @numeroZona int)
AS
BEGIN
INSERT INTO Zona(municipio, numeroZona) VALUES(@municipio, @numeroZona);
END
GO

CREATE PROCEDURE sp_EliminarZona(@municipio varchar(100))
AS
BEGIN
DELETE Zona WHERE municipio = @municipio;
END
GO