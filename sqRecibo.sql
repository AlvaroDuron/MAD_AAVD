USE HydroLAN;
USE Proyecto;

CREATE TABLE Recibo
( nombreUsuario VARCHAR(100) NOT NULL,
numeroContrato INT NOT NULL,
año INT NOT NULL,
mes INT NOT NULL,
expedicion VARCHAR(100) NOT NULL,
numeroZona INT NOT NULL,
consumo FLOAT NOT NULL,
subtotal1 DECIMAL(12,2),
subtotal2 DECIMAL(12,2),
subtotal3 DECIMAL(12,2),
total DECIMAL(12,2),
vencimiento DATETIME,
pagado BIT,
FOREIGN KEY (nombreUsuario) REFERENCES Usuario(nombreUsuario),
FOREIGN KEY (numeroContrato) REFERENCES Contrato(numeroContrato),
FOREIGN KEY (expedicion) REFERENCES Municipio(municipio),
FOREIGN KEY (numeroZona) REFERENCES Zona(numeroZona),
PRIMARY KEY(numeroContrato, año, mes)
);

CREATE PROCEDURE sp_ConsultarRecibos(@año int, @mes int)
AS
BEGIN
SELECT nombreUsuario, numeroContrato, año, mes, expedicion, numeroZona, consumo, subtotal1, subtotal2, subtotal3, total, vencimiento, pagado FROM Recibo WHERE año = @año AND mes = @mes;
END
GO

CREATE PROCEDURE sp_ConsultarRecibosPorServicio(@tipoServicio varchar(100), @año int, @mes int)
AS
BEGIN
SELECT Recibo.nombreUsuario, Recibo.numeroContrato, Recibo.año, Recibo.mes, Recibo.expedicion, Recibo.numeroZona, Recibo.consumo, Recibo.subtotal1, Recibo.subtotal2, Recibo.subtotal3, Recibo.total, Recibo.vencimiento, Recibo.pagado
FROM Contrato
INNER JOIN Recibo ON Contrato.numeroContrato = Recibo.numeroContrato AND Contrato.tipoServicio = @tipoServicio AND Recibo.año = @año AND Recibo.mes = @mes;
END
GO

CREATE PROCEDURE sp_BuscarRecibo(@numeroContrato int, @año int, @mes int)
AS
BEGIN
SELECT nombreUsuario, numeroContrato, año, mes, expedicion, numeroZona, consumo, subtotal1, subtotal2, subtotal3, total, vencimiento, pagado 
FROM Recibo WHERE numeroContrato = @numeroContrato AND año = @año AND mes = mes;
END
GO

CREATE PROCEDURE sp_AgregarRecibo(@nombreUsuario varchar(100), @numeroContrato int, @año int, @mes int, @expedicion varchar(100), @numeroZona int, @consumo float, @subtotal1 decimal(12,2), @subtotal2 decimal(12,2), @subtotal3 decimal(12,2), @total decimal(12,2), @vencimiento datetime, @pagado bit)
AS
BEGIN
INSERT INTO Recibo(nombreUsuario, numeroContrato, año, mes, expedicion, numeroZona, consumo, subtotal1, subtotal2, subtotal3, total, vencimiento, pagado) 
VALUES(@nombreUsuario, @numeroContrato, @año, @mes, @expedicion, @numeroZona, @consumo, @subtotal1, @subtotal2, @subtotal3, @total, @vencimiento, @pagado);
END
GO

CREATE PROCEDURE sp_EliminarRecibo(@numeroContrato int, @año int, @mes int)
AS
BEGIN
DELETE Recibo WHERE numeroContrato = @numeroContrato AND año = @año AND mes = @mes;
END
GO

INSERT INTO Recibo(nombreUsuario, numeroContrato, año, mes, expedicion, numeroZona, consumo, subtotal1, subtotal2, subtotal3, total, vencimiento, pagado) 
VALUES('isaac', 2, 2021, 1, 'guadalupe', 3, 77.4, 60, 72.3, 90.5, 94.2, '2021-2-04 12:00:00.000', 0);

select * from Recibo;