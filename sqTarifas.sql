USE HydroLAN;
use Proyecto;

CREATE TABLE Tarifa
( numeroZona INT NOT NULL,
año CHAR(4) NOT NULL,
mes CHAR(2) NOT NULL,
cuotaFija MONEY,
basico MONEY,
intermedio MONEY,
excedente MONEY,
municipio VARCHAR(100),
FOREIGN KEY (municipio) REFERENCES Zona(municipio),
idParametro INT,
FOREIGN KEY (idParametro) REFERENCES Parametro(idParametro),
PRIMARY KEY(numeroZona, año, mes)
);

CREATE PROCEDURE sp_ConsultarTarifas
AS
BEGIN
SELECT * FROM Zona;
END
GO

CREATE PROCEDURE sp_ModificarTarifa(@municipio varchar(100), @numeroZona int)
AS
BEGIN
UPDATE Zona SET numeroZona = @numeroZona WHERE municipio = @municipio;
END
GO

CREATE PROCEDURE sp_AgregarTarifa(@municipio varchar(100), @numeroZona int)
AS
BEGIN
INSERT INTO Zona(municipio, numeroZona) VALUES(@municipio, @numeroZona);
END
GO

CREATE PROCEDURE sp_EliminarTarifa(@municipio varchar(100))
AS
BEGIN
DELETE Zona WHERE municipio = @municipio;
END
GO

