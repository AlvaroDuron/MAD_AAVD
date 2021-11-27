USE HydroLAN;
USE Proyecto;

CREATE TABLE Municipio
( municipio VARCHAR(100) PRIMARY KEY,
numeroZona INT,
FOREIGN KEY (numeroZona) REFERENCES Zona(numeroZona)
);

CREATE PROCEDURE sp_ConsultarMunicipios
AS
BEGIN
SELECT municipio, numeroZona 
FROM Municipio;
END
GO

CREATE PROCEDURE sp_ConsultarMunicipiosPorNombre
AS
BEGIN
SELECT municipio 
FROM Municipio;
END
GO

CREATE PROCEDURE sp_ConsultarMunicipiosZonas
AS
BEGIN
SELECT Zona.numeroZona, Municipio.municipio, Zona.nombre
FROM Zona
INNER JOIN Municipio ON Zona.numeroZona = Municipio.numeroZona;
END
GO


CREATE PROCEDURE sp_BuscarMunicipio(@municipio varchar(100))
AS
BEGIN
SELECT municipio, numeroZona 
FROM Municipio 
WHERE municipio = @municipio;
END
GO

CREATE PROCEDURE sp_ModificarMunicipio(@municipio varchar(100), @numeroZona int)
AS
BEGIN
UPDATE Municipio 
SET municipio = @municipio, numeroZona = @numeroZona 
WHERE municipio = @municipio;
END
GO

CREATE PROCEDURE sp_AgregarMunicipio(@municipio varchar(100), @numeroZona int)
AS
BEGIN
INSERT INTO Municipio(municipio, numeroZona) 
VALUES(@municipio, @numeroZona);
END
GO

CREATE PROCEDURE sp_EliminarMunicipio(@municipio varchar(100))
AS
BEGIN
DELETE Municipio 
WHERE municipio = @municipio;
END
GO


insert into Municipio(municipio, numeroZona) VALUES('guadalupe', 3);
insert into Municipio(municipio, numeroZona) VALUES('juarez', 3);
insert into Municipio(municipio, numeroZona) VALUES('monterrey', 5);
insert into Municipio(municipio, numeroZona) VALUES('san pedro', 2);
insert into Municipio(municipio, numeroZona) VALUES('apodaca', 1);

select * from Municipio;


