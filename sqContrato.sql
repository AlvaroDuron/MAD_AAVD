USE HydroLAN;
USE Proyecto;

CREATE TABLE Contrato
( numeroContrato INT IDENTITY(1,1) PRIMARY KEY,
numeroMedidor INT NOT NULL,
estado TINYINT NOT NULL,
creacion DATE NOT NULL,
fechaAltaMod DATETIME,
numeroExterior INT,
calle VARCHAR(100),
colonia VARCHAR(100),
municipio VARCHAR(100),
FOREIGN KEY (municipio) REFERENCES Zona(municipio),
nombreUsuario VARCHAR(100),
FOREIGN KEY (nombreUsuario) REFERENCES Usuario(nombreUsuario),
tipoServicio VARCHAR(10) NOT NULL,
FOREIGN KEY (tipoServicio) REFERENCES Tipo_Servicio(tipoServicio),
categoria CHAR(1) NOT NULL,
FOREIGN KEY (categoria) REFERENCES Categoria(categoria),
);


CREATE PROCEDURE sp_ConsultarContratos
AS
BEGIN
SELECT nombreUsuario, numeroContrato, numeroMedidor, tipoServicio, categoria, estado, numeroExterior, calle, colonia, municipio, creacion, fechaAltaMod FROM Contrato;
END
GO

CREATE PROCEDURE sp_BuscarContrato(@numeroContrato int)
AS
BEGIN
SELECT nombreUsuario, numeroContrato, numeroMedidor, tipoServicio, categoria, estado, numeroExterior, calle, colonia, municipio, creacion, fechaAltaMod FROM Contrato WHERE numeroContrato = @numeroContrato;
END
GO

CREATE PROCEDURE sp_AgregarContrato(@nombreUsuario char(100), @numeroMedidor int, @tipoServicio varchar(10), @categoria char(1), @estado int, @numeroExterior int, @calle varchar(100), @colonia varchar(100), @municipio varchar(100), @creacion date)
AS
BEGIN
INSERT INTO Contrato(nombreUsuario, numeroMedidor, tipoServicio, categoria, estado, numeroExterior, calle, colonia, municipio, creacion, fechaAltaMod) VALUES(@nombreUsuario, @numeroMedidor, @tipoServicio, @categoria, @estado, @numeroExterior, @calle, @colonia, @municipio, @creacion, CURRENT_TIMESTAMP);
END
GO

CREATE PROCEDURE sp_ModificarContrato(@nombreUsuario char(100), @numeroContrato int, @numeroMedidor int, @tipoServicio varchar(10), @categoria char(1), @estado int, @numeroExterior int, @calle varchar(100), @colonia varchar(100), @municipio varchar(100), @creacion date)
AS
BEGIN
UPDATE Contrato SET nombreUsuario = @nombreUsuario, numeroMedidor = @numeroMedidor, tipoServicio = @tipoServicio, categoria = @categoria, estado = @estado, numeroExterior = @numeroExterior, calle = @calle, colonia = @colonia, municipio = @municipio, creacion = @creacion, fechaAltaMod = CURRENT_TIMESTAMP WHERE numeroContrato = @numeroContrato;
END
GO

CREATE PROCEDURE sp_EliminarContrato(@numeroContrato int)
AS
BEGIN
DELETE Contrato WHERE numeroContrato = @numeroContrato;
END
GO
