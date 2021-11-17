USE HydroLAN;
use Proyecto;


CREATE PROCEDURE sp_ConsultarZonas
AS
BEGIN
SELECT * FROM Zona;
END
GO

CREATE PROCEDURE sp_ModificarZona(@municipio varchar(100), @numeroZona int)
AS
BEGIN
UPDATE Zona SET numeroZona = @numeroZona WHERE municipio = @municipio;
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

select * from Usuario;
insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('mohidan', 123, 1, 0, 0);