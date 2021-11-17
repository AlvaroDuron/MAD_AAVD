USE HydroLAN;
use Proyecto;

CREATE PROCEDURE sp_BuscarUsuario(@nombreUsuario varchar(100))
AS
BEGIN
SELECT * FROM Usuario WHERE nombreUsuario = @nombreUsuario;
END
GO

CREATE PROCEDURE sp_ModificarUsuario(@nombreUsuario varchar(100), @contraseña varchar(100), @intentos tinyint, @estado tinyint)
AS
BEGIN
UPDATE Usuario SET contraseña = @contraseña, intentos = @intentos, estado = @estado WHERE nombreUsuario = @nombreUsuario;
END
GO

CREATE PROCEDURE sp_EliminarUsuario(@nombreUsuario varchar(100))
AS
BEGIN
DELETE Usuario WHERE nombreUsuario = @nombreUsuario;
END
GO