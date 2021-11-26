USE HydroLAN;
USE Proyecto;

CREATE TABLE Tipo_Servicio
( nombre VARCHAR(100) PRIMARY KEY NOT NULL,
cuotaDrenaje FLOAT,
rango1 FLOAT,
rango2 FLOAT,
rango3 FLOAT
);

CREATE PROCEDURE sp_ConsultarTipoServiciosPorNombre
AS
BEGIN
SELECT nombre FROM Tipo_Servicio;
END
GO

CREATE PROCEDURE sp_ConsultarTipoServicios
AS
BEGIN
SELECT nombre, cuotaDrenaje, rango1, rango2, rango3 FROM Tipo_Servicio;
END
GO

CREATE PROCEDURE sp_BuscarTipoServicio(@nombre char(100))
AS
BEGIN
SELECT nombre, cuotaDrenaje, rango1, rango2, rango3 FROM Tipo_Servicio WHERE nombre = @nombre;
END
GO

CREATE PROCEDURE sp_ModificarTipoServicio(@nombre char(100), @cuotaDrenaje decimal(12,2), @rango1 float, @rango2 float, @rango3 float)
AS
BEGIN
UPDATE Tipo_Servicio SET cuotaDrenaje = @cuotaDrenaje, rango1 = @rango1, rango2 = @rango2, rango3 = @rango3 WHERE nombre = @nombre;
END
GO


INSERT INTO Tipo_Servicio(nombre, cuotaDrenaje, rango1, rango2, rango3) VALUES('Domestico', 10, 50, 100, 200);
INSERT INTO Tipo_Servicio(nombre, cuotaDrenaje, rango1, rango2, rango3) VALUES('Comercial', 10, 50, 100, 200);
INSERT INTO Tipo_Servicio(nombre, cuotaDrenaje, rango1, rango2, rango3) VALUES('Industrial', 10, 50, 100, 200);
SELECT * FROM Tipo_Servicio;