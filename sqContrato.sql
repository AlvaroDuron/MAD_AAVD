USE HydroLAN;
USE Proyecto;

CREATE TABLE Contrato
( numeroContrato INT IDENTITY(1,1) PRIMARY KEY,
numeroMedidor INT UNIQUE NOT NULL,
nombreUsuario VARCHAR(100),
tipoServicio VARCHAR(100) NOT NULL,
categoria CHAR(1) NOT NULL,
numeroExterior INT,
calle VARCHAR(100),
colonia VARCHAR(100),
municipio VARCHAR(100),
estado TINYINT NOT NULL,
creacion DATE NOT NULL,
fechaAltaMod DATETIME,
FOREIGN KEY (nombreUsuario) REFERENCES Usuario(nombreUsuario),
FOREIGN KEY (tipoServicio) REFERENCES Tipo_Servicio(nombre),
FOREIGN KEY (categoria) REFERENCES Categoria(categoria),
FOREIGN KEY (municipio) REFERENCES Municipio(municipio),
);


CREATE PROCEDURE sp_ConsultarContratos
AS
BEGIN
SELECT numeroContrato, numeroMedidor, nombreUsuario, tipoServicio, categoria, numeroExterior, calle, colonia, municipio, estado, creacion, fechaAltaMod FROM Contrato;
END
GO

CREATE PROCEDURE sp_BuscarContrato(@numeroContrato int)
AS
BEGIN
SELECT numeroContrato, numeroMedidor, nombreUsuario, tipoServicio, categoria, numeroExterior, calle, colonia, municipio, estado, creacion, fechaAltaMod FROM Contrato WHERE numeroContrato = @numeroContrato;
END
GO

CREATE PROCEDURE sp_BuscarContratoPorMedidor(@numeroMedidor int)
AS
BEGIN
SELECT numeroContrato, numeroMedidor, nombreUsuario, tipoServicio, categoria, numeroExterior, calle, colonia, municipio, estado, creacion, fechaAltaMod FROM Contrato WHERE numeroMedidor = @numeroMedidor;
END
GO

CREATE PROCEDURE sp_AgregarContrato(@nombreUsuario char(100), @numeroMedidor int, @tipoServicio varchar(10), @categoria char(1), @estado int, @numeroExterior int, @calle varchar(100), @colonia varchar(100), @municipio varchar(100))
AS
BEGIN
INSERT INTO Contrato(nombreUsuario, numeroMedidor, tipoServicio, categoria, numeroExterior, calle, colonia, municipio, estado, creacion, fechaAltaMod) VALUES(@nombreUsuario, @numeroMedidor, @tipoServicio, @categoria, @numeroExterior, @calle, @colonia, @municipio, @estado, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
END
GO

CREATE PROCEDURE sp_ModificarContrato(@nombreUsuario char(100), @numeroContrato int, @numeroMedidor int, @tipoServicio varchar(10), @categoria char(1), @numeroExterior int, @calle varchar(100), @colonia varchar(100), @municipio varchar(100), @estado int, @creacion date)
AS
BEGIN
UPDATE Contrato SET nombreUsuario = @nombreUsuario, numeroMedidor = @numeroMedidor, tipoServicio = @tipoServicio, categoria = @categoria, numeroExterior = @numeroExterior, calle = @calle, colonia = @colonia, municipio = @municipio, estado = @estado, creacion = @creacion, fechaAltaMod = CURRENT_TIMESTAMP WHERE numeroContrato = @numeroContrato;
END
GO

CREATE PROCEDURE sp_EliminarContrato(@numeroContrato int)
AS
BEGIN
DELETE Contrato WHERE numeroContrato = @numeroContrato;
END
GO


INSERT INTO Contrato(nombreUsuario, numeroMedidor, tipoServicio, categoria, estado, numeroExterior, calle, colonia, municipio, creacion, fechaAltaMod) VALUES('isaac', 5005, 'Domestico', 'A', 0, 778, 'calle7', 'alamedas', 'guadalupe', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
select * from Contrato;