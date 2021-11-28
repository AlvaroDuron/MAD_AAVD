USE HydroLAN;
USE Proyecto;

CREATE TABLE Consumo
( numeroMedidor INT NOT NULL,
año INT NOT NULL,
mes INT NOT NULL,
lecturaAnterior DECIMAL(12,2) NOT NULL,
lecturaActual DECIMAL NOT NULL,
numeroContrato INT,
FOREIGN KEY (numeroContrato) REFERENCES Contrato(numeroContrato),
PRIMARY KEY(numeroMedidor, año, mes)
);

CREATE PROCEDURE sp_ConsultarConsumos
AS
BEGIN
SELECT numeroMedidor, año, mes, lecturaAnterior, lecturaActual, numeroContrato FROM Consumo;
END
GO

CREATE PROCEDURE sp_ConsultarConsumosPorContrato(@numeroContrato int)
AS
BEGIN
SELECT numeroMedidor, año, mes, lecturaAnterior, lecturaActual, numeroContrato FROM Consumo WHERE numeroContrato = @numeroContrato;
END
GO

CREATE PROCEDURE sp_BuscarConsumo(@numeroMedidor int, @año int, @mes int)
AS
BEGIN
SELECT numeroMedidor, año, mes, lecturaAnterior, lecturaActual, numeroContrato FROM Consumo WHERE numeroMedidor = @numeroMedidor AND año = @año AND mes = @mes;
END
GO

CREATE PROCEDURE sp_BuscarConsumoPorContrato(@numeroContrato int, @año int, @mes int)
AS
BEGIN
SELECT numeroMedidor, año, mes, lecturaAnterior, lecturaActual, numeroContrato FROM Consumo WHERE numeroContrato = @numeroContrato AND año = @año AND mes = @mes;
END
GO

CREATE PROCEDURE sp_ModificarConsumo(@numeroMedidor int, @año int, @mes int, @lecturaActual decimal(12,2))
AS
BEGIN
UPDATE Consumo SET lecturaActual = @lecturaActual WHERE numeroMedidor = @numeroMedidor AND año = @año AND mes = @mes;
END
GO

CREATE PROCEDURE sp_AgregarConsumo(@numeroMedidor int, @año int, @mes int, @lecturaAnterior decimal(12,2), @lecturaActual decimal(12,2), @numeroContrato int)
AS
BEGIN
INSERT INTO Consumo(numeroMedidor, año, mes, lecturaAnterior, lecturaActual, numeroContrato) VALUES(@numeroMedidor, @año, @mes, @lecturaAnterior, @lecturaActual, @numeroContrato);
END
GO

CREATE PROCEDURE sp_EliminarConsumo(@numeroMedidor int, @año int, @mes int)
AS
BEGIN
DELETE Consumo WHERE numeroMedidor = @numeroMedidor AND año = @año AND mes = @mes;
END
GO

select * from Consumo;