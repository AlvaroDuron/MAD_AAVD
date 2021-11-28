USE HydroLAN;
USE Proyecto;

CREATE TABLE Consumo
( numeroMedidor INT NOT NULL,
a�o INT NOT NULL,
mes INT NOT NULL,
lecturaAnterior DECIMAL(12,2) NOT NULL,
lecturaActual DECIMAL NOT NULL,
numeroContrato INT,
FOREIGN KEY (numeroContrato) REFERENCES Contrato(numeroContrato),
PRIMARY KEY(numeroMedidor, a�o, mes)
);

CREATE PROCEDURE sp_ConsultarConsumos
AS
BEGIN
SELECT numeroMedidor, a�o, mes, lecturaAnterior, lecturaActual, numeroContrato FROM Consumo;
END
GO

CREATE PROCEDURE sp_ConsultarConsumosPorContrato(@numeroContrato int)
AS
BEGIN
SELECT numeroMedidor, a�o, mes, lecturaAnterior, lecturaActual, numeroContrato FROM Consumo WHERE numeroContrato = @numeroContrato;
END
GO

CREATE PROCEDURE sp_BuscarConsumo(@numeroMedidor int, @a�o int, @mes int)
AS
BEGIN
SELECT numeroMedidor, a�o, mes, lecturaAnterior, lecturaActual, numeroContrato FROM Consumo WHERE numeroMedidor = @numeroMedidor AND a�o = @a�o AND mes = @mes;
END
GO

CREATE PROCEDURE sp_BuscarConsumoPorContrato(@numeroContrato int, @a�o int, @mes int)
AS
BEGIN
SELECT numeroMedidor, a�o, mes, lecturaAnterior, lecturaActual, numeroContrato FROM Consumo WHERE numeroContrato = @numeroContrato AND a�o = @a�o AND mes = @mes;
END
GO

CREATE PROCEDURE sp_ModificarConsumo(@numeroMedidor int, @a�o int, @mes int, @lecturaActual decimal(12,2))
AS
BEGIN
UPDATE Consumo SET lecturaActual = @lecturaActual WHERE numeroMedidor = @numeroMedidor AND a�o = @a�o AND mes = @mes;
END
GO

CREATE PROCEDURE sp_AgregarConsumo(@numeroMedidor int, @a�o int, @mes int, @lecturaAnterior decimal(12,2), @lecturaActual decimal(12,2), @numeroContrato int)
AS
BEGIN
INSERT INTO Consumo(numeroMedidor, a�o, mes, lecturaAnterior, lecturaActual, numeroContrato) VALUES(@numeroMedidor, @a�o, @mes, @lecturaAnterior, @lecturaActual, @numeroContrato);
END
GO

CREATE PROCEDURE sp_EliminarConsumo(@numeroMedidor int, @a�o int, @mes int)
AS
BEGIN
DELETE Consumo WHERE numeroMedidor = @numeroMedidor AND a�o = @a�o AND mes = @mes;
END
GO

select * from Consumo;