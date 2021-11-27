USE HydroLAN;
use Proyecto;

CREATE TABLE Tarifa
( numeroZona INT NOT NULL,
tipoServicio VARCHAR(100) NOT NULL,
año INT NOT NULL,
mes INT NOT NULL,
cuotaFija DECIMAL(12,2),
rango1 DECIMAL(12,2),
rango2 DECIMAL(12,2),
rango3 DECIMAL(12,2),
FOREIGN KEY (numeroZona) REFERENCES Zona(numeroZona),
FOREIGN KEY (tipoServicio) REFERENCES Tipo_Servicio(nombre),
PRIMARY KEY(numeroZona, tipoServicio, año, mes)
);

CREATE PROCEDURE sp_ConsultarTarifas
AS
BEGIN
SELECT numeroZona, tipoServicio, año, mes, cuotaFija, rango1, rango2, rango3 FROM Tarifa;
END
GO

CREATE PROCEDURE sp_BuscarTarifa(@numeroZona int, @tipoServicio varchar(100), @año int, @mes int)
AS
BEGIN
SELECT numeroZona, tipoServicio, año, mes, cuotaFija, rango1, rango2, rango3 FROM Tarifa WHERE numeroZona = @numeroZona AND tipoServicio = @tipoServicio AND año = @año AND mes = @mes;
END
GO

CREATE PROCEDURE sp_ModificarTarifa(@numeroZona int, @tipoServicio varchar(100), @año int, @mes int, @cuotaFija decimal(12,2), @rango1 decimal(12,2), @rango2 decimal(12,2), @rango3 decimal(12,2))
AS
BEGIN
UPDATE Tarifa SET cuotaFija = @cuotaFija, rango1 = @rango1, rango2 = @rango2, rango3 = @rango3 WHERE numeroZona = @numeroZona AND tipoServicio = @tipoServicio AND año = @año AND mes = @mes;
END
GO

CREATE PROCEDURE sp_AgregarTarifa(@numeroZona int, @tipoServicio varchar(100), @año int, @mes int, @cuotaFija decimal(12,2), @rango1 decimal(12,2), @rango2 decimal(12,2), @rango3 decimal(12,2))
AS
BEGIN
INSERT INTO Tarifa(numeroZona, tipoServicio, año, mes, cuotaFija, rango1, rango2, rango3) VALUES(@numeroZona, @tipoServicio, @año, @mes, @cuotaFija, @rango1, @rango2, @rango3);
END
GO

CREATE PROCEDURE sp_EliminarTarifa(@numeroZona int, @tipoServicio varchar(100), @año int, @mes int)
AS
BEGIN
DELETE Tarifa WHERE numeroZona = @numeroZona AND tipoServicio = @tipoServicio AND año = @año AND mes = @mes;
END
GO

insert into Tarifa(numeroZona, tipoServicio, año, mes, cuotaFija, rango1, rango2, rango3) values(5, 'Domestico', 2021, 1, 52.5, 3.5, 6, 9.5);
select * from Tarifa;

SELECT numeroZona, tipoServicio, año, mes, cuotaFija, rango1, rango2, rango3 FROM Tarifa WHERE numeroZona = 1 AND tipoServicio = 'Comercial' AND año = 2021 AND mes = 2;